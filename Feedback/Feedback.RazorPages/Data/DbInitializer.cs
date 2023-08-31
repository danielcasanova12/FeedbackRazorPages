using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Feedback.RazorPages.Models;

namespace Feedback.RazorPages.Data
{
    public class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            if (context.Feedbacks is not null && context.Feedbacks.Any())
            {
                return; // O banco de dados já foi inicializado com feedbacks.
            }

            var feedbacks = new FeedbackModel[]
            {
                new FeedbackModel
                {
                    NomeCliente = "Cliente 1",
                    EmailCliente = "cliente1@example.com",
                    DataFeedback = DateTime.Parse("2023-08-31"),
                    Comentario = "Comentário sobre o produto ou serviço.",
                    Avaliacao = 4
                },
                new FeedbackModel
                {
                    NomeCliente = "Cliente 2",
                    EmailCliente = "cliente2@example.com",
                    DataFeedback = DateTime.Parse("2023-09-05"),
                    Comentario = "Outro comentário sobre o produto ou serviço.",
                    Avaliacao = 5
                }
                // Adicione mais feedbacks se desejar
            };

            context.Feedbacks!.AddRange(feedbacks);
            context.SaveChanges();
        } 
    }
}