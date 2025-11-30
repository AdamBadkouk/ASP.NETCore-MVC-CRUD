using System.ComponentModel.DataAnnotations;

namespace ASP.NETCore_MVC.Entities
{
    public class Student
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string? Name { get; set; }

        [EmailAddress]
        [StringLength(100)]
        public string? Email { get; set; }

        [Phone]
        [StringLength(30)]
        public string? Phone { get; set; }

        [StringLength(50)]
        public string? City { get; set; }
    }
}
