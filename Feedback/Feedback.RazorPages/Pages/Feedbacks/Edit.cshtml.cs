using Feedback.RazorPages.Models;
using Feedback.RazorPages.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Feedback.RazorPages.Pages.Feedbacks
{
    public class Edit : PageModel
    {
        private readonly FeedbackService _feedbackService;
        
        [BindProperty]
        public FeedbackModel FeedbackDetails { get; set; } = new();

        public Edit(FeedbackService feedbackService)
        {
            _feedbackService = feedbackService;
        }

        public IActionResult OnGet(int id)
        {
            var feedbackModel = _feedbackService.GetFeedbackById(id);
            if (feedbackModel == null)
            {
                return NotFound();
            }

            FeedbackDetails = feedbackModel;

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            try
            {
                _feedbackService.UpdateFeedback(FeedbackDetails);
                return RedirectToPage("Index");
            }
            catch (System.Exception)
            {
                return Page();
            }
        }
    }
}
