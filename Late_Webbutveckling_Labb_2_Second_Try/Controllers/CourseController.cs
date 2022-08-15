using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Late_Webbutveckling_Labb_2_Second_Try.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase {

        private readonly API_Context _context;

        public CourseController(API_Context context) {

            _context = context;

        }

        [HttpGet("/api/GetCoursesForUser/{userId}")]
        public async Task<ActionResult<List<Course>>> Get(string userId) {

            var courses = await _context.courses
                .Where(c => c.UserId == userId)
                .ToListAsync();

            return courses;

        }

        [HttpPost("/api/AddCourse")]
        public async Task<ActionResult<List<Course>>> AddCourse(CourseDTO course) {

            var addingCourse = new Course {

                CourseNumber = course.CourseNumber,
                CourseTitle = course.CourseTitle,
                CourseDescription = course.CourseDescription,
                CourseLength = course.CourseLength,
                CourseDifficulty = course.CourseDifficulty,
                CourseStatus = course.CourseStatus,
                //User = user,
                UserId = ""

            };

            _context.courses.Add(addingCourse);
            await _context.SaveChangesAsync();

            return Ok("Kurs tillagd");
            
        }

        [HttpGet("/api/GetAllCourses")]
        public async Task<ActionResult<List<Course>>> GetAllCourses() {

            return Ok(await _context.courses.ToListAsync());

        }

        [HttpGet("/api/GetSelectedCourse/{id}")]/* Works but only for specific entry in database with that ID not all identical entries */
        public async Task<ActionResult<Course>> GetSelectedCourse(int id) {

            var courseToReturn = _context.courses.FindAsync(id).Result;

            if (courseToReturn is null) {

                return BadRequest("Kunde inte hämta kurs");

            }

            return Ok(courseToReturn);

        }

        [HttpGet("/api/GetCourseByCourseNumber/{CourseNumber}")]
        public async Task<ActionResult<Course>> GetCourseByCourseNumber(int courseNumber) {

            var courseToReturn = _context.courses.FirstOrDefaultAsync(findCourse => findCourse.CourseNumber == courseNumber).Result;

/*            if (courseToReturn is null) {

                return BadRequest("Kunde inte hämta kurs");

            }*/

            return Ok(courseToReturn);

        }

        [HttpPost("/api/Old_AddCourse")]/* Old that used to work but encountered problems when rewriting stuff --> Also works now */
        public async Task<ActionResult<List<Course>>> Old_AddCourse(Course course) {

            await _context.courses.AddAsync(course);

            await _context.SaveChangesAsync();

            return StatusCode(200, _context.courses);

        }
        
        [HttpPut("/api/RetireCourse")]
        public async Task<ActionResult<List<Course>>> RetireCourse(Course retiringCourse) {

            if (_context.courses.Find(retiringCourse.Id) is null) {

                return StatusCode(400, "Pensionering Misslyckad");

            }

            var courseprofile = _context.courses.Find(retiringCourse.Id);

            courseprofile.CourseStatus = retiringCourse.CourseStatus;

            await _context.SaveChangesAsync();

            return StatusCode(200, _context.courses);

        }

        [HttpDelete("/api/DeleteCourse/{id}")]/* Works but only for specific entry in database with that ID not all identical entries */
        public async Task<ActionResult<List<Course>>> DeleteCourse(int id) {

            if (_context.courses.Find(id) is null) {

                return BadRequest("Kunde inte ta bort kurs");

            }

            _context.courses.Remove(_context.courses.Find(id));

            await _context.SaveChangesAsync();

            return Ok(await _context.courses.ToListAsync());

        }





        //DENNA KAN TAS BORT OM JAG INTE TAR MISTE
/*        [HttpGet("/api/GetACourse")]
        public async Task<ActionResult<List<Course>>> GetACourse() {

            //string? clown = _context.courses.FirstOrDefault().ToString();

            //return Ok(200); //Ok(await _context.courses.FirstOrDefaultAsync());

            return Ok(await _context.users.FirstAsync());

        }
*/





    }
}
