using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL
{
    public class TeacherDAL
    {
        public List<School> GetSchools()
        {
            using (TeacherScheduleContext context = new())
            {
                return context.Schools.ToList();
            }
        }

        public List<Group> GetGroups(int schoolId)
        {
            using(TeacherScheduleContext context = new())
            {
                return context.Groups.Where(g => g.SchoolId == schoolId).ToList();
            }
        }
    }
}
