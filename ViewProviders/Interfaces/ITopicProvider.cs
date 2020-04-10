using Lethal.Developer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lethal.Developer.ViewProviders.Interfaces
{
    public interface ITopicProvider
    {
        IEnumerable<TopicViewModel> GetAllTopics(Guid userId);
    }
}
