using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCourseProject.Domain.Entities
{
    public class Columns
    {
        public int columnId { get; set; }
        public int gridId { get; set; }
        public string name { get; set; }
        public string type { get; set; }
    }
}
