using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class TeacherBL
    {
        public List<School> GetSchools()
        {
            return new TeacherDAL().GetSchools();
        }

        public List<Group> GetGroups(int sId)
        {
            return new TeacherDAL().GetGroups(sId);
        }
    }
}
