using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Late_Webbutveckling_Labb_2_Second_Try.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase {

        List<Course> courseList = new List<Course> {

            new Course {

                Id = 1,
                CourseTitle = "Carpenting",
                CourseDescription = "If you ever wanted to be a skilled carpenter, this is the course for you!",
                CourseNumber = 54398,
                CourseLength = "2 years",
                CourseDifficulty = "Advanced",
                CourseStatus = true

            },

            new Course {

                Id = 2,
                CourseTitle = "Basic Fletcher Course",
                CourseDescription = "Ever asked yourself how to make simple arrows? Join us and find out how!",
                CourseNumber = 93749,
                CourseLength = "4 weeks",
                CourseDifficulty = "Beginner",
                CourseStatus = true

            },

            new Course {

                Id = 3,
                CourseTitle = "Coming Back Course",
                CourseDescription = "If you are a professional within a certain field but by whatever reason have been absent for several years from it, here is a course for how to return to your previous fame and glory - while avoiding some usual misstakes.",
                CourseNumber = 49874,
                CourseLength = "3 months",
                CourseDifficulty = "Expert",
                CourseStatus = true

            }

        };

        //public CourseController() {

        //    courseList.Add();

        //    //CourseTitle
        //    //CourseDescription
        //    //CourseNumber
        //    //CourseLength
        //    //CourseDifficulty
        //    //CourseStatus
        //    //Id

        //}

        private readonly API_Context _context;

        public CourseController(API_Context context) {

            _context = context;

        }

        [HttpGet("/api/GetAllCourses")]
        public async Task<ActionResult<List<Course>>> GetAllCourses() {

            GetAllCourses_Class getAllCourses = new GetAllCourses_Class(courseList);

            //return Ok(getAllCourses.ReturnAllCourses());
            //return StatusCode(200, getAllCourses.ReturnAllCourses());//Fungerar mot listan ovan

            return Ok(await _context.courses.ToListAsync());//Fungerar mot databasen

            //return Ok("Kurser hämtade");

        }

        [HttpGet("/api/GetSelectedCourse/{id}")]
        public async Task<ActionResult<Course>> GetSelectedCourse(int id) {

            GetSelectedCourse_Class getSelectedCourse = new GetSelectedCourse_Class(courseList, id, _context);

            if (getSelectedCourse.courseList.Find(courseWithId => courseWithId.Id == id) is null) {

                return BadRequest("Kunde inte hämta kurs");

            }

            //return StatusCode(200, await getSelectedCourse.ReturnSelectedCourse(id));

            //return Ok("Kurs hämtad");

            //return StatusCode(200, await _context.courses.FindAsync(id));

            //return Ok(await _context.courses.FindAsync(id));

            //return StatusCode(200, await getSelectedCourse.ReturnSelectedCourse(id));

            //var courseToReturn = await _context.courses.FindAsync(id);
            //return courseToReturn;

            //return StatusCode(200, await getSelectedCourse._context.courses.FindAsync(id));
            return StatusCode(200, await getSelectedCourse._context.courses.FindAsync(id));

        }

        [HttpPost("/api/AddCourse")]
        public async Task<ActionResult<List<Course>>> AddCourse(Course course) {

            AddCourse_Class addCourse = new AddCourse_Class(courseList, course);

            courseList = addCourse.courseList;

            return StatusCode(200, addCourse.courseList);

            //return Ok("Kurs tillagd");

        }
        
        [HttpPut("/api/RetireCourse")]
        public async Task<ActionResult<List<Course>>> RetireCourse(Course retiringCourse) {

            RetireCourse_Class retireCourse = new RetireCourse_Class(courseList, retiringCourse);

            courseList = retireCourse.courseList;

            return StatusCode(200, retireCourse.courseList);

            //return Ok("Kurs Pensionerad");

        }

        [HttpDelete("/api/DeleteCourse/{id}")]
        public async Task<ActionResult<List<Course>>> DeleteCourse(int id) {

            DeleteCourse_Class deleteCourse = new DeleteCourse_Class(courseList, id);

            return StatusCode(200, deleteCourse.DeletingCourse(id));

            //return Ok("Kurs borttagen");

        }

    }
}
