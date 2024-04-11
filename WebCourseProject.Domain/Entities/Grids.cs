using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCourseProject.Domain.Entities
{
    public class Grids
    {
        public int gridId { get; set; }
        public int userId { get; set; }
        public string name { get; set; }
        public string privacy { get; set; }
        public ICollection<Columns> Columns { get; set; }
    }
}
