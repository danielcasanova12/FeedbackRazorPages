using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Feedback.RazorPages.Data;
using Feedback.RazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Feedback.RazorPages.Pages.Feedbacks
{
    public class Create : PageModel
    {
        private readonly AppDbContext _context;
        [BindProperty]
        public FeedbackModel FeedbackDetails { get; set; } = new();

        public Create(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            try
            {
                _context.Feedbacks!.Add(FeedbackDetails);
                await _context.SaveChangesAsync();
                return RedirectToPage("/Feedbacks/Index");
            }
            catch (System.Exception)
            {
                return Page();
            }
        }

    }
}