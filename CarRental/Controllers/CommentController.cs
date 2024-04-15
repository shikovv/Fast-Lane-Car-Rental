using CarRental.Contracts;
using CarRental.Models.Comment;
using Microsoft.AspNetCore.Mvc;
using CarRental.Models.Comment;
using CarRental.Extensions;

namespace CarRental.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService commentService;
        public CommentController(ICommentService commentService)
        {
            this.commentService = commentService;
        }

        public async Task<IActionResult> All()
        {
            AllCommentViewModel model = new AllCommentViewModel()
            {
                Comments = await this.commentService.AllCommentsByCreationTime()
            };

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            CommentFormModel formModel = new CommentFormModel();

            return View(formModel);
        }

        [HttpPost]
        public async Task<IActionResult> Add(CommentFormModel formModel)
        {
            if (!ModelState.IsValid)
            {
                return View(formModel);
            }

            try
            {
                    await commentService.CreateAndReturnId(formModel, Guid.Parse(this.User.GetId())!);

                return RedirectToAction("All", "Comment");
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty,
                    "Unexpected error occurred while trying to add your new comment!");

                return View(formModel);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            try
            {
                bool commentExists = await commentService
                    .ExistById(Guid.Parse(id));

                if (!commentExists)
                {

                    return RedirectToAction("All", "Comment");
                }

                bool isAdmin = User.IsAdmin();
                bool isCurrentUserCreatorOfTheComment = await commentService.IsCreaterWithId(Guid.Parse(id), Guid.Parse(User.GetId())!);

                if (!isCurrentUserCreatorOfTheComment && !isAdmin)
                {
                    return RedirectToAction("All", "Comment");
                }

                CommentFormModel formModel = await commentService
                    .GetCommentForEditById(Guid.Parse(id));

                return View(formModel);
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(string id, CommentFormModel commentModel)
        {
            if (!ModelState.IsValid)
            {
                return View(commentModel);
            }

            try
            {
                bool commentExists = await commentService
                    .ExistById(Guid.Parse(id));

                if (!commentExists)
                {
                    return RedirectToAction("All", "Comment");
                }

                bool isAdmin = User.IsAdmin();
                bool isCurrentUserCreatorOfTheComment = await commentService.IsCreaterWithId(Guid.Parse(id), Guid.Parse(User.GetId())!);

                if (!isCurrentUserCreatorOfTheComment && !isAdmin)
                {
                    return RedirectToAction("All", "Comment");
                }


                await commentService.EditCommentByIdAndFormModel(Guid.Parse(id), commentModel);
            }
            catch (Exception)
            {
                return View(commentModel);
            }

            return RedirectToAction("All", "comment");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            try
            {
                bool commentExists = await commentService
                    .ExistById(Guid.Parse(id));

                if (!commentExists)
                {
                    return RedirectToAction("All", "Comment");
                }

                await this.commentService.DeleteCommentById(Guid.Parse(id));
                return RedirectToAction("All", "Comment");
            }
            catch (Exception)
            {
                return this.GeneralError();
            }
        }

        private IActionResult GeneralError()
        {
            return RedirectToAction("All", "Comment");
        }
    }
}
