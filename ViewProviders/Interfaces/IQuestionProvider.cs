using Lethal.Developer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lethal.Developer.ViewProviders.Interfaces
{
    public interface IQuestionProvider
    {
        Task<IEnumerable<Question>> GetQuestionsByTopicAsync(Guid userId, int topicIc); 
    }
}
