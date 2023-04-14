using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net;
using System.Xml.Linq;

namespace Sliit.MTIT.Student.Data
{
    public class StudentMockDataService
    {
        public static List<Models.Student> Students = new List<Models.Student>()
        {
            new Models.Student { Id = 1, Name = "John", Address = "123 Main St", Age = 20 },
            new Models.Student { Id = 2, Name = "Mary", Address = "U56 Second Ave", Age = 22 },
            new Models.Student { Id = 3, Name = "Tom", Address = "789 Third St", Age = 21 },
            new Models.Student { Id = 4, Name = "Kate", Address = "321 Fourth Ave", Age = 23 },
            new Models.Student { Id = 5, Name = "Mike", Address = "654 Fifth St", Age = 19 }
        };
    }
}
