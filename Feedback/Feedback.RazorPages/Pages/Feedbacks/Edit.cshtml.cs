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
    public class Edit : PageModel
    {
          private readonly AppDbContext _context;
        [BindProperty]
        public FeedbackModel FeedbackDetails { get; set; } = new();

        public Edit(AppDbContext context)
        {
            _context = context;
        }
        
        public async Task<IActionResult> OnPostAsync(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var emptyFeedback = await _context.Feedbacks!.FindAsync(id);
            if (emptyFeedback == null)
            {
                return NotFound();
            }

            emptyFeedback.NomeCliente = FeedbackDetails.NomeCliente;
            emptyFeedback.EmailCliente = FeedbackDetails.EmailCliente;
            emptyFeedback.DataFeedback = FeedbackDetails.DataFeedback;
            emptyFeedback.Comentario = FeedbackDetails.Comentario;
            emptyFeedback.Avaliacao = FeedbackDetails.Avaliacao;

            try
            {
                await _context.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            catch (System.Exception)
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