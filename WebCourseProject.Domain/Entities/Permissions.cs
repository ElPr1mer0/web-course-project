using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCourseProject.Domain.Entities
{
    public class Permissions
    {
        public int userId { get; set; }
        public int gridId { get; set; }
        public bool create { get; set; }
        public bool read { get; set; }
        public bool write { get; set; }
        public bool update { get; set; }

    }
}
