using Lethal.Developer.Data;
using Lethal.Developer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Lethal.Developer.DataAccess.Interfaces;

namespace Lethal.Developer.DataAccess.Services
{
    public class TopicRepository : ITopicRepository
    {
        private readonly IServiceProvider _serviceProvider;

        public TopicRepository(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IEnumerable<Topic> GetAllTopics(Guid userId)
        {
            try
            {
                var db = _serviceProvider.GetService<ApplicationDbContext>();

                var topic = db.Topics;

                return topic;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
