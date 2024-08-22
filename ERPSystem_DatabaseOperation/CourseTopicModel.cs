using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPSystem_DatabaseOperation
{
    public class CourseTopicModel
    {
        public int course_topic_id { get; set; }
        public int topic_id { get; set; }
        public int course_id { get; set; }
        public string course_name { get; set; }
        public string topic_name { get; set; }

    }
}
