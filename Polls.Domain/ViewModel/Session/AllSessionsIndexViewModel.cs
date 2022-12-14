using Polls.Domain.ViewModel.Course;
using Polls.Domain.ViewModel.Instructor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polls.Domain.ViewModel.Session
{
    public class AllSessionsIndexViewModel
    {
        public List<SessionIndexViewModel> Sessions { get; set; }
        public List<CourseViewModel> Courses { get; set; }
        public List<InstructorIndexViewModel> Instructors { get; set; }
    }
}
