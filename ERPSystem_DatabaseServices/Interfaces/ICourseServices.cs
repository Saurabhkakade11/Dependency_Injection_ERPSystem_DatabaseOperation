using ERPSystem_DatabaseOperation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPSystem_DatabaseServices.Interfaces
{
    public interface ICourseServices
    {
        void AddCourse(tbltraining_courses courses);
        void UpdateCourse(tbltraining_courses courses);
        void DeleteCourse(int course_id);
        List<tbltraining_courses> GetCourses();
        tbltraining_courses GetCourse(int course_id);

        void AddCourseFees(tbltraining_course_fees fee);
        void UpdateCourseFees(tbltraining_course_fees fee);
        void DeleteCourseFees(int course_id);
        List<CourseFeeModel> GetAllCourseFees();
        CourseFeeModel GetCourseFees(int fee_id);
        List<CourseFeeModel> GetCourseWiseFees(int course_id);

    }
}
