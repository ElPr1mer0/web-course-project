using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCourseProject.Domain.Entities
{
    public class Roles
    {
        public int roleId { get; set; }
        public string type { get; set; }
        public int userId { get; set; }
        public Users? User { get; set; }
    }
}
