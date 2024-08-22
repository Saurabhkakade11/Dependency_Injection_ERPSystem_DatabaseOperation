using ERPSystem_DatabaseOperation;
using ERPSystem_DatabaseServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERPSystem_WebApp.Controllers
{
          

    public class TopicContentController : Controller
    {
        ITopicContentService ContentService;
        ITopicService topicService;
        
        public TopicContentController(ITopicContentService contentService,ITopicService topic)
        {
            this.ContentService = contentService;
            this.topicService = topic;
        }


        // GET: TopicContent
        public ActionResult Index()
        {
            ViewBag.topics = GetTopic();
            tbltopics_Contents c =new tbltopics_Contents();
            return View();
        }

        public List<SelectListItem> GetTopic()
        {
            List<SelectListItem> lst = new List<SelectListItem>();
            foreach (tbltraining_topics d in topicService.GetTopics())
            {
                SelectListItem item = new SelectListItem()
                {
                    Text = d.topic_name,
                    Value = d.topic_id.ToString()
                };
                lst.Add(item);
            }
            return lst;
            
        }



     
    }
}