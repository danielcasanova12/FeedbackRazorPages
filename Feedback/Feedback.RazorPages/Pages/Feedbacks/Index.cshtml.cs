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
    public class Index : PageModel
    {
        private readonly AppDbContext _context;
        public List<FeedbackModel> FeedbackList { get; set; } = new();

        public Index(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var eventsFromDb = await _context.Feedbacks!.ToListAsync();
            FeedbackList.AddRange(eventsFromDb);
            return Page();
        }
    }


}