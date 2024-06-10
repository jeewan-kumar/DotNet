using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CollegeApp.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public string GetStudentName() {
            return "Student Name1";
         }
    }
}

// using Microsoft.AspNetCore.Mvc;
// using System.Collections.Generic;

// namespace SimpleApi.Controllers
// {
//     [Route("api/[controller]")]
//     [ApiController]
//     public class StudentController : ControllerBase
//     {
//         private static readonly List<string> Students = new List<string>
//         {
//             "Student1",
//             "Student2",
//             "Student3"
//         };

//         [HttpGet]
//         public IEnumerable<string> Get()
//         {
//             return Students;
//         }

//         [HttpGet("{id}")]
//         public ActionResult<string> Get(int id)
//         {
//             if (id < 0 || id >= Students.Count)
//             {
//                 return NotFound();
//             }
//             return Students[id];
//         }

//         [HttpPost]
//         public ActionResult Post([FromBody] string student)
//         {
//             Students.Add(student);
//             return CreatedAtAction(nameof(Get), new { id = Students.Count - 1 }, student);
//         }

//         [HttpPut("{id}")]
//         public ActionResult Put(int id, [FromBody] string student)
//         {
//             if (id < 0 || id >= Students.Count)
//             {
//                 return NotFound();
//             }
//             Students[id] = student;
//             return NoContent();
//         }

//         [HttpDelete("{id}")]
//         public ActionResult Delete(int id)
//         {
//             if (id < 0 || id >= Students.Count)
//             {
//                 return NotFound();
//             }
//             Students.RemoveAt(id);
//             return NoContent();
//         }
//     }
// }
