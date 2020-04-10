using Lethal.Developer.DataAccess.Interfaces;
using Lethal.Developer.Data;
using Lethal.Developer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

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
            var db = _serviceProvider.GetService<ApplicationDbContext>();

            var q = db.Questions;
        }
    }
}
