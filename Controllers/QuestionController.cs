using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lethal.Developer.ViewProviders.Interfaces;
using Lethal.Developer.ViewProviders.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lethal.Developer.Controllers
{
    public class QuestionController : RootController
    {
        public QuestionController(ITopicProvider topicProvider)
            : base(topicProvider)
        {

        }

        public IActionResult Index()
        {
            return View();
        }
    }
}