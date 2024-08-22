using ERPSystem_DatabaseOperation;
using ERPSystem_DatabaseServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ERPSystem_DatabaseServices.Implementations
{
    public class TopicService : ITopicService
    {
        private IRepository<tbltraining_topics> topicrepo;
        public TopicService(IRepository<tbltraining_topics> topicrepo)
        {
            this.topicrepo = topicrepo;
        }

        public void AddTopic(tbltraining_topics t)
        {
            topicrepo.Create(t);
        }

        public void DeleteTopic(int topic_id)
        {
            topicrepo.Delete(topic_id);
        }

        public tbltraining_topics GetTopic(int topic_id)
        {
            return topicrepo.GetById(topic_id);
        }

        public List<tbltraining_topics> GetTopics()
        {
            return topicrepo.GetAll();
        }

        public void UpdateTopic(tbltraining_topics t)
        {
            topicrepo.Update(t);
        }
    }
}

