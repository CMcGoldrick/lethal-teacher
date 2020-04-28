using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lethal.Developer.ViewModels;
using Lethal.Developer.ViewProviders.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lethal.Developer.Controllers
{
    public class RootController : Controller
    {
        private static ITopicProvider _topicProvider;

        public RootController(ITopicProvider topicProvider)
        {
            _topicProvider = topicProvider;
        }

        public string UserId => GetUserId();
        public BaseViewModel BaseViewModel => GetBaseViewModel();

        private BaseViewModel GetBaseViewModel()
        {
            try
            {
                var vm = new BaseViewModel();
                var topicList = new List<TopicViewModel>();
                var topics = _topicProvider.GetAllTopics(Guid.Parse(UserId));

                foreach(var t in topics)
                {
                    topicList.Add(new TopicViewModel
                    {
                        Name = t.Name
                    });
                }

                vm.Topics = topicList;

                return vm;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private string GetUserId()
        {
            //if (Misc.IsLocal(HttpContext.Connection))
            //    //Do NOT CHANGE THIS.
            //    return "4303387A-23BD-47ED-AE8C-08808BE0785C";

            ////TODO: Move this to config file
            //const string oidClaim = "http://schemas.microsoft.com/identity/claims/objectidentifier";

            ////could not find user id
            //if (!(User.Identity is ClaimsIdentity claimsIdentity))
            //    throw new ArgumentException("Error - Could not find UserId");

            //string userId = null;
            //if (claimsIdentity.Claims.Any())
            //    userId = claimsIdentity.FindFirst(oidClaim).Value;

            //return string.IsNullOrEmpty(userId) ? null : userId;

            //Do NOT CHANGE THIS.
            return "9776506B-8CFE-448F-1BF5-08D7DCE61A3B";
        }

    }
}