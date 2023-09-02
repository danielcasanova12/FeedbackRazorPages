
using Feedback.RazorPages.Models;
using Feedback.RazorPages.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Feedback.RazorPages.Pages.Feedbacks
{
    public class Delete : PageModel
    {
        private readonly FeedbackService _feedbackService;
        [BindProperty]
        public FeedbackModel FeedbackDetails { get; set; } = new();

        public Delete(FeedbackService feedbackService)
        {
            _feedbackService = feedbackService;
        }

        public IActionResult OnPost(int id)
        {
            _feedbackService.DeleteFeedback(id);
            return RedirectToPage("Index");
        }

        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var feedback = _feedbackService.GetFeedbackById(id.Value);

            if (feedback == null)
            {
                return NotFound();
            }

            FeedbackDetails = feedback;

            return Page();
            }

    }
}