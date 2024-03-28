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


        public async Task<IActionResult> Detail(string id)
        {
            bool commentExists = await this.commentService
                .ExistById(Guid.Parse(id));

            if (!commentExists)
            {
                TempData["ErrorMessage"] = "Comment with the provided id does not exist!";

                return RedirectToAction("All", "Comment");
            }

            try
            {
                CommentDetailsModel viewModel = await this.commentService
                    .GetCommentForDetailsById(Guid.Parse(id));

                return View(viewModel);
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

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




        private IActionResult GeneralError()
        {
            TempData["ErrorMessage"] = "Unexpected error occurred!";

            return RedirectToAction("All", "Comment");
        }
    }
}
