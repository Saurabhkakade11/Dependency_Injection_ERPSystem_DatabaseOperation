using ERPSystem_DatabaseOperation;
using ERPSystem_DatabaseServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPSystem_DatabaseServices.Implementations
{
    public class CourseServices:ICourseServices
    {
        IRepository<tbltraining_courses> courserepo;
        IRepository<tbltraining_course_fees> feesrepo;
        IRepository<tbltraining_course_topics> coursetopicrepo;
        IRepository<tbltraining_topics> topicrepo;

        public CourseServices(IRepository<tbltraining_courses> courserepo, IRepository<tbltraining_course_fees> feerepo, IRepository<tbltraining_course_topics> coursetopirepo, IRepository<tbltraining_topics> topicrepo)
        {
            this.courserepo = courserepo;
            this.feesrepo = feerepo;
            this.courserepo = courserepo;
            this.topicrepo = topicrepo;
        }

        public void AddCourse(tbltraining_courses course)
        {
            courserepo.Create(course);
        }

        public void AddCourseFees(tbltraining_course_fees fee)
        {
            throw new NotImplementedException();
        }

        public void DeleteCourse(int course_id)
        {
            throw new NotImplementedException();
        }

        public void DeleteCourseFees(int course_id)
        {
            throw new NotImplementedException();
        }

        public List<CourseFeeModel> GetAllCourseFees()
        {
            throw new NotImplementedException();
        }

        public tbltraining_courses GetCourse(int course_id)
        {
            throw new NotImplementedException();
        }

        public CourseFeeModel GetCourseFees(int fee_id)
        {
            throw new NotImplementedException();
        }

        public List<tbltraining_courses> GetCourses()
        {
            throw new NotImplementedException();
        }

        public List<CourseFeeModel> GetCourseWiseFees(int course_id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCourse(tbltraining_courses course)
        {
            throw new NotImplementedException();
        }

        public void UpdateCourseFees(tbltraining_course_fees fee)
        {
            throw new NotImplementedException();
        }
    }
}
