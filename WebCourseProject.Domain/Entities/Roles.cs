

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
