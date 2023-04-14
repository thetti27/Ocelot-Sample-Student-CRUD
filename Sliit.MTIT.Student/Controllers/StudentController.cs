using Microsoft.AspNetCore.Mvc;
using Sliit.MTIT.Student.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sliit.MTIT.Student.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        //-----------------------------------
        //New Impementation Starts Here 
        //-----------------------------------

        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService??throw new ArgumentNullException(nameof(studentService));
        }

        //-----------------------------------

        /// <summary>
        /// GET all students
        /// </summary>
        /// <returns>This method returns the list all students</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_studentService.GetStudents());
        }

        //-----------------------------------


        /// <summary>
        /// GET all students by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Returns the student with the passed ID </returns>
        [HttpGet("{id}")]
            
        public IActionResult Get(int id)
        {
            return _studentService.GetStudent(id) != null ? Ok(_studentService.GetStudent(id)) : NoContent();
        }

        //-----------------------------------


        /// <summary>
        /// Add Students
        /// </summary>
        /// <param name="student"></param>
        /// <returns> Returns the added student </returns>
        [HttpPost]
        public IActionResult Post([FromBody] Models.Student student)
        {
            return Ok(_studentService.AddStudent(student));
        }


        //-----------------------------------
        /// <summary>
        /// Update the student
        /// </summary>
        /// <param name="student"></param>
        /// <returns> Returns the updated student </returns>
        [HttpPut]
        public IActionResult Put([FromBody] Models.Student student)
        {
            return Ok(_studentService.UpdateStudent(student));
        }

        //-----------------------------------

        /// <summary>
        /// Delete the student with the passed ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns> </returns>
        [HttpDelete("{id}")]

        public IActionResult Delete(int id)

        {
            var result = _studentService.DeleteStudent(id);

            return result.HasValue & result == true ? Ok($"student with ID:{id} got deleted successfully.")
                : BadRequest($"Unable to delete the student with ID:{id}.");
        }   

    }
}
