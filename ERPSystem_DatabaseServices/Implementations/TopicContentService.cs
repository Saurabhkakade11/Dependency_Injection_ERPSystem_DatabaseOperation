using ERPSystem_DatabaseOperation;
using ERPSystem_DatabaseServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPSystem_DatabaseServices.Implementations
{
    public class TopicContentService : ITopicContentService
    {
        IRepository<tbltopics_Contents> contentrepo;
        IRepository<tbltraining_topics> topicrepo;
        public TopicContentService(IRepository<tbltopics_Contents> contentrepo, IRepository<tbltraining_topics> topicrepo)
        {
            this.contentrepo = contentrepo;
            this.topicrepo = topicrepo;
        }

        public void AddTopicContent(tbltopics_Contents content)
        {
            contentrepo.Create(content);
        }

        public void DeleteTopicContent(int content_id)
        {

            contentrepo.Delete(content_id);
        }

        public TopicContentModel GetTopicContent(int content_id)
        {
            tbltopics_Contents c = contentrepo.GetById(content_id);
            tbltraining_topics t = topicrepo.GetById((int)c.topic_id);
            TopicContentModel ct = new TopicContentModel()
            {
                content_id = c.content_id,
                content_name = c.content_name,
                topic_id = t.topic_id,
                topic_name = t.topic_name
            };
            return ct;
        }

        public List<TopicContentModel> GetTopicContents()
        {
            List<TopicContentModel> lst = new List<TopicContentModel>();
            foreach (tbltopics_Contents c in contentrepo.GetAll())
            {

                tbltraining_topics t = topicrepo.GetById((int)c.topic_id);
                TopicContentModel ct = new TopicContentModel()
                {
                    content_id = c.content_id,
                    content_name = c.content_name,
                    topic_id = t.topic_id,
                    topic_name = t.topic_name
                };
                lst.Add(ct);
            }
            return lst;
        }

        public List<TopicContentModel> GetTopicWiseContents(int topic_id)
        {
            return GetTopicContents().Where(e => e.topic_id.Equals(topic_id)).ToList();
        }

        public void UpdateTopicContent(tbltopics_Contents content)
        {
            contentrepo.Update(content);
        }

    }
}
