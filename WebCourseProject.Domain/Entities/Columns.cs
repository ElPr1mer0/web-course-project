using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCourseProject.Domain.Entities
{
    public class Columns
    {
        public int columnId { get; set; }  
        public string name { get; set; }
        public string type { get; set; }
        public int gridId { get; set; }
        public Grids? Grid { get; set; }
    }
}
