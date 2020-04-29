using Lethal.Developer.DataAccess.Interfaces;
using Lethal.Developer.Data;
using Lethal.Developer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Lethal.Developer.DataAccess.Services
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly IServiceProvider _serviceProvider;

        public QuestionRepository(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateQuestion(Guid userId, Question Question)
        {
            try
            {
                var db = _serviceProvider.GetService<ApplicationDbContext>();
                var questions = db.Questions;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<Question>> GetQuestionsByTopicAsync(Guid userId, int topicId)
        {
            try
            {
                return await _serviceProvider.GetService<ApplicationDbContext>().Questions
                    .Where(q => q.UserId == userId && q.TopicId == topicId).ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
