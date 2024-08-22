using ERPSystem_DatabaseOperation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPSystem_DatabaseServices.Interfaces
{
    public interface ITopicContentService
    {
        void AddTopicContent(tbltopics_Contents content);
        void UpdateTopicContent(tbltopics_Contents content);
        void DeleteTopicContent(int content_id);
        List<TopicContentModel> GetTopicContents();
        List<TopicContentModel> GetTopicWiseContents(int topic_id);
        TopicContentModel GetTopicContent(int content_id);

    }
}
