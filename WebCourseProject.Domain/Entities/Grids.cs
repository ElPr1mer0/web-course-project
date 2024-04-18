using System.Collections.Generic;

namespace WebCourseProject.Domain.Entities
{
    public class Grids
    {
        public int gridId { get; set; }
        public string name { get; set; }
        public string privacy { get; set; }
        public ICollection<Columns>? Columns { get; set; }
        public ICollection<Permissions>? Permissions { get; set; }
    }
}
