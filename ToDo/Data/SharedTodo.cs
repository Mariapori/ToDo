using System.ComponentModel.DataAnnotations;

namespace ToDo.Data
{
    public class SharedTodo
    {
        public int Id { get; set; }
        [Required]
        public string Kuvaus { get; set; }

        public List<todoMember>? Jasenet { get; set; }
        public List<todo>? Tehtavat { get; set; }
        public string Luoja { get; set; }
        public DateTime Luotu { get; set; }
    }

    public class todoMember
    {
        public string Id { get; set; }
        public string Email { get; set; }
    }
}
