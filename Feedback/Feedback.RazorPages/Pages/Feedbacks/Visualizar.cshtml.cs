using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Feedback.RazorPages.Data;
using Feedback.RazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Feedback.RazorPages.Pages.Feedbacks
{
    public class Visualizar : PageModel
    {
        private readonly AppDbContext _context;
        public FeedbackModel FeedbackDetails { get; set; } = new();

        public Visualizar(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Feedbacks == null)
            {
                return NotFound();
            }

            var feedbackModel = await _context.Feedbacks.FirstOrDefaultAsync(f => f.IdFeedback == id);
            if (feedbackModel == null)
            {
                return NotFound();
            }

            FeedbackDetails = feedbackModel;

            return Page();
        }
    }
}