using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Feedback.RazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Feedback.RazorPages.Services;

namespace Feedback.RazorPages.Pages.Feedbacks
{
    public class Index : PageModel
        {
        private readonly FeedbackService _feedbackService;

        public Index(FeedbackService feedbackService)
        {
            _feedbackService = feedbackService;
        }


        public List<FeedbackModel> FeedbackList { get; set; } = new List<FeedbackModel>();

        public void OnGet()
        {
            FeedbackList = _feedbackService.GetAllFeedbacks();
        }

    }


}