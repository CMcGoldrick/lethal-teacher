﻿using Lethal.Developer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lethal.Developer.DataAccess.Interfaces
{
    public interface ITopicRepository
    {
        IEnumerable<Topic> GetAllTopics(Guid userId);
    }
}
