using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPSystem_DatabaseOperation
{
    public class CourseModel
    {
        public int course_id { get; set; }
        public string course_name { get; set; }
        public List<CourseFeeModel> Fees { get; set; }
        public List<CourseTopicModel> courseTopics { get; set; }

    }
}
