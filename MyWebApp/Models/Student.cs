using System.ComponentModel.DataAnnotations;

namespace MyWebApp.Models
{
    public class Student
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Code is not empty")]
        public string Code { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Name is not empty")]
        public string Name { get; set; }

        [Range(0,10)]
        public int Mark { get; set; }

        public Student() { }
        public Student(string code, string name, int mark)
        {
            Code = code;
            Name = name;
            Mark = mark;
        }
    }
}
