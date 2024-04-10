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


        //public async Task<IActionResult> Detail(string id)
        //{
        //    bool commentExists = await this.commentService
        //        .ExistById(Guid.Parse(id));

        //    if (!commentExists)
        //    {
        //        TempData["ErrorMessage"] = "Comment with the provided id does not exist!";

        //        return RedirectToAction("All", "Comment");
        //    }

        //    try
        //    {
        //        CommentDetailsModel viewModel = await this.commentService
        //            .GetCommentForDetailsById(Guid.Parse(id));

        //        return View(viewModel);
        //    }
        //    catch (Exception)
        //    {
        //        return GeneralError();
        //    }
        //}

        public async Task<IActionResult> Add()
        {
            CommentFormModel formModel = new CommentFormModel();

            return this.View(formModel);
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
                string carId =
                    await commentService.CreateAndReturnId(formModel, Guid.Parse(this.User.GetId())!);

                TempData["SuccessMessage"] = "Comment was added successfully!";

                return RedirectToAction("Detail", "Comment", new { id = carId });
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
                    TempData["ErrorMessage"] = "Comment with the provided id does not exist!";

                    return RedirectToAction("All", "Comment");
                }

                bool isAdmin = User.IsAdmin();
                bool isCurrentUserCreatorOfTheComment = await commentService.IsCreaterWithId(Guid.Parse(id), Guid.Parse(User.GetId())!);

                if (!isCurrentUserCreatorOfTheComment && !isAdmin)
                {
                    TempData["ErrorMessage"] =
                        "You must be the creator of the comment in order to edit it!";

                    return RedirectToAction("Detail", "Comment", new { id });
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
                    TempData["ErrorMessage"] = "Comment with the provided id does not exist!";

                    return RedirectToAction("All", "Comment");
                }

                bool isAdmin = User.IsAdmin();
                bool isCurrentUserCreatorOfTheComment = await commentService.IsCreaterWithId(Guid.Parse(id), Guid.Parse(User.GetId())!);

                if (!isCurrentUserCreatorOfTheComment && !isAdmin)
                {
                    TempData["ErrorMessage"] =
                        "You must be the creator of the comment in order to edit it!";

                    return RedirectToAction("All", "Comment");
                }


                await commentService.EditCommentByIdAndFormModel(Guid.Parse(id), commentModel);

                this.TempData["InformationMessage"] = "Comment was edited successfully";
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, "Unexpected error occurred while trying to edit the comment!");

                return View(commentModel);
            }

            return RedirectToAction("Detail", "comment", new { id });
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
                    TempData["ErrorMessage"] = "Comment with the provided id does not exist!";

                    return RedirectToAction("All", "Comment");
                }

                await this.commentService.DeleteCommentById(Guid.Parse(id));

                TempData["WarningMessage"] = "The selected comment was successfully deleted from the Database!";

                return RedirectToAction("All", "Comment");
            }
            catch (Exception)
            {
                return this.GeneralError();
            }
        }




        private IActionResult GeneralError()
        {
            TempData["ErrorMessage"] = "Unexpected error occurred!";

            return RedirectToAction("All", "Comment");
        }
    }
}
