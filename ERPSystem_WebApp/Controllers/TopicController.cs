using ERPSystem_DatabaseOperation;
using ERPSystem_DatabaseServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERPSystem_WebApp.Controllers
{
    public class TopicController : Controller
    {
        // GET: Topic
        ITopicService topicService;
        public TopicController(ITopicService topicService)
        {
            this.topicService = topicService;
        }
        public ActionResult Index()
        {
            tbltraining_topics t=new tbltraining_topics();
            ViewBag.topics=topicService.GetTopics();
            return View(t);
        }
        [HttpPost]
        public ActionResult Index(tbltraining_topics tp)
        {
            topicService.AddTopic(tp);
            ViewBag.msg = "Topic added successfully";
            ViewBag.topics = topicService.GetTopics();

            tbltraining_topics t = new tbltraining_topics();
            return View(t); 
        }
    }
}