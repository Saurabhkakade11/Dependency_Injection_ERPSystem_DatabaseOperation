using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPSystem_DatabaseOperation
{
    public class CourseFeeModel
    {
        public int Course_id {  get; set; } 
        public int fee_id {  get; set; }
        public string course_name { get; set; }
        public string fee_type { get; set; }
        public float fee_amount { get; set; }
        public float gst { get; set; }
    }
}
