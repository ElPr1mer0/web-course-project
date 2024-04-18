

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
