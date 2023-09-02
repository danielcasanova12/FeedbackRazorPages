using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Feedback.RazorPages.Models;
using Feedback.RazorPages.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Feedback.RazorPages.Pages.Feedbacks
{
    public class Visualizar : PageModel
    {
        private readonly FeedbackService _feedbackService;

        public Visualizar(FeedbackService feedbackService)
        {
            _feedbackService = feedbackService;
        }

        public FeedbackModel FeedbackDetails { get; set; } = new FeedbackModel();

        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FeedbackDetails = new FeedbackModel(); 

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