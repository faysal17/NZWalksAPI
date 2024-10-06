using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NZWalks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        string[] studentsNames = new string[] { "faysal", "adnan", "rafat" };
        [HttpGet]
        public IActionResult getStudents()
        {
            return Ok(studentsNames);
        }
    }
}
