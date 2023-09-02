using System;
using System.Collections.Generic;
using System.Linq;
using Feedback.RazorPages.Models;

namespace Feedback.RazorPages.Services
{
    public class FeedbackService
    {
        private List<FeedbackModel> _feedbacks = new List<FeedbackModel>();

        public List<FeedbackModel> GetAllFeedbacks()
        {
            return _feedbacks;
        }

        public void AddFeedback(FeedbackModel feedback)
        {
            feedback.IdFeedback = _feedbacks.Count + 1;
            _feedbacks.Add(feedback);
        }

        public FeedbackModel? GetFeedbackById(int id)
        {
            return _feedbacks.FirstOrDefault(f => f.IdFeedback == id);
        }

        public void UpdateFeedback(FeedbackModel updatedFeedback)
        {
            var existingFeedback = _feedbacks.FirstOrDefault(f => f.IdFeedback == updatedFeedback.IdFeedback);
            if (existingFeedback != null)
            {
                existingFeedback.NomeCliente = updatedFeedback.NomeCliente;
                existingFeedback.EmailCliente = updatedFeedback.EmailCliente;
                existingFeedback.DataFeedback = updatedFeedback.DataFeedback;
                existingFeedback.Comentario = updatedFeedback.Comentario;
                existingFeedback.Avaliacao = updatedFeedback.Avaliacao;
            }
        }
                public void DeleteFeedback(int id)
        {
            var feedbackToDelete = _feedbacks.FirstOrDefault(f => f.IdFeedback == id);
            if (feedbackToDelete != null)
            {
                _feedbacks.Remove(feedbackToDelete);
            }
        }
    }
}
