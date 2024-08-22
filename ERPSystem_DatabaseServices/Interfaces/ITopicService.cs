using ERPSystem_DatabaseOperation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPSystem_DatabaseServices.Interfaces
{
    public interface ITopicService
    {
        void AddTopic(tbltraining_topics t);
        void UpdateTopic(tbltraining_topics t);
        void DeleteTopic(int topic_id);
        List<tbltraining_topics> GetTopics();
        tbltraining_topics GetTopic(int topic_id);
    }
}