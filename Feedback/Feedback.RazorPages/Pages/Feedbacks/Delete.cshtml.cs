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
    public class Delete : PageModel
    {
          private readonly AppDbContext _context;
        [BindProperty]
        public FeedbackModel FeedbackDetails { get; set; } = new();

        public Delete(AppDbContext context)
        {
            _context = context;
        }
        
        public async Task<IActionResult> OnPostAsync(int id)
        {
            var emptyFeedback = await _context.Feedbacks!.FindAsync(id);
            if (emptyFeedback == null)
            {
                return NotFound();
            }

            try
            {
                _context.Feedbacks.Remove(emptyFeedback);
                await _context.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            catch (Exception)
            {
                return Page();
            }
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