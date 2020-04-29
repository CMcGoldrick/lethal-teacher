using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Lethal.Developer.ViewModels;
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

        public async Task<IActionResult> Index()
        {
            var bvm = await BaseViewModel;
            var qvm = new QuestionViewModel();

            qvm.Topics = bvm.Topics;

            return View(bvm);
        }
    }
}