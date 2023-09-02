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
    public class Create : PageModel
    {
              private readonly FeedbackService _feedbackService;

        [BindProperty]
        public FeedbackModel FeedbackDetails { get; set; } = new();

        public Create(FeedbackService feedbackService)
        {
            _feedbackService = feedbackService;
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            try
            {
                _feedbackService.AddFeedback(FeedbackDetails);

                // Redirecionar para a página de feedbacks ou fazer algo mais, se necessário.
                return RedirectToPage("/Feedbacks/Index");
            }
            catch (System.Exception)
            {
                return Page();
            }
        }
    }
}