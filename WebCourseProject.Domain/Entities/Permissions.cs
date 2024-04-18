

namespace WebCourseProject.Domain.Entities
{
    public class Permissions
    {
        public int permId { get; set; }
        public bool create { get; set; }
        public bool read { get; set; }
        public bool write { get; set; }
        public bool update { get; set; }
        public int userId { get; set; }
        public Users? User { get; set; }
        public int gridId { get; set; }
        public Grids? Grid { get; set; }

    }
}
