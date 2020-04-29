using Lethal.Developer.ViewModels;
using Lethal.Developer.ViewProviders.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lethal.Developer.DataAccess.Interfaces;

namespace Lethal.Developer.ViewProviders.Services
{
    public class QuestionProvider : IQuestionProvider
    {
        IQuestionRepository _questionRepository;

        public QuestionProvider(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }

        public async Task<IEnumerable<Question>> GetQuestionsByTopicAsync(Guid userId, int topicId)
        {
            try
            {
                var questions = await _questionRepository.GetQuestionsByTopicAsync(userId, topicId);
                var qvm = new List<Question>();

                foreach(var q in questions)
                {
                    qvm.Add(new Question
                    { 
                        Q = q.Q,
                        A = q.A
                    }); 
                }

                return qvm;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
