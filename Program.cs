using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Projects
{
    class Course
    {
        [Table("Projects")]
        public class Course
        {
            [Key]
            public int CourseId { get; set; }
            [Required]
            public string Course { get; set; }
            [Required]
            public string Nome { get; set; }
        }
    }
}
//teste