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
        IQuestionProvider _questionProvider; 

        public QuestionController(ITopicProvider topicProvider, IQuestionProvider questionProvider)
            : base(topicProvider)
        {
            _questionProvider = questionProvider;
        }

        public async Task<IActionResult> Index()
        {
            var qvm = new QuestionViewModel();
            var bvm = await BaseViewModel;
            qvm.Topics = bvm.Topics;

            return View(bvm);
        }

        [HttpGet]
        [Route("questions/{topicId}")]
        public async Task<IActionResult> QuestionsByTopic(int topicId)
        {
            var qvm = new QuestionViewModel();
            var bvm = await BaseViewModel;
            var questions = await _questionProvider.GetQuestionsByTopicAsync(UserId, topicId);
            
            qvm.Topics = bvm.Topics;
            qvm.Questions = questions;

            return View(qvm);
        }

    }
}