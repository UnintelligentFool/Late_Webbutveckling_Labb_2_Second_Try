using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Late_Webbutveckling_Labb_2_Second_Try.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase {

        //List<Course> courseList = new List<Course> {

        //    new Course {

        //        Id = 1,
        //        CourseTitle = "Carpenting",
        //        CourseDescription = "If you ever wanted to be a skilled carpenter, this is the course for you!",
        //        CourseNumber = 54398,
        //        CourseLength = "2 years",
        //        CourseDifficulty = "Advanced",
        //        CourseStatus = true

        //    },

        //    new Course {

        //        Id = 2,
        //        CourseTitle = "Basic Fletcher Course",
        //        CourseDescription = "Ever asked yourself how to make simple arrows? Join us and find out how!",
        //        CourseNumber = 93749,
        //        CourseLength = "4 weeks",
        //        CourseDifficulty = "Beginner",
        //        CourseStatus = true

        //    },

        //    new Course {

        //        Id = 3,
        //        CourseTitle = "Coming Back Course",
        //        CourseDescription = "If you are a professional within a certain field but by whatever reason have been absent for several years from it, here is a course for how to return to your previous fame and glory - while avoiding some usual misstakes.",
        //        CourseNumber = 49874,
        //        CourseLength = "3 months",
        //        CourseDifficulty = "Expert",
        //        CourseStatus = true

        //    }

        //};

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












        /**/        [HttpGet("/api/GetCoursesForUser")]
                public async Task<ActionResult<List<Course>>> Get(/* int userId */ string userId) {

                    var courses = await _context.courses
                        .Where(c => c.UserId == userId)
                        //.Include(c => c.CourseTitle)
                        .ToListAsync();

                    return courses;

                } /**/

        [HttpPost("/api/AddCourse")]
        public async Task<ActionResult<List<Course>>> AddCourse(CourseDTO course) {
/*
            var user = await _context.users.FindAsync(course.UserId);
            if (user is null) {

                return StatusCode(404, "User to pair with course not found");
                //return NotFound();

            }

            var addingCourse = new Course {

                CourseNumber = course.CourseNumber,
                CourseTitle = course.CourseTitle,
                CourseDescription = course.CourseDescription,
                CourseLength = course.CourseLength,
                CourseDifficulty = course.CourseDifficulty,
                CourseStatus = course.CourseStatus,
                User = user


            };

            _context.courses.Add(addingCourse);
            await _context.SaveChangesAsync();

            var coursesToReturn = await _context.courses.Where(correctCourse => correctCourse.UserId == addingCourse.UserId).ToListAsync();

            return coursesToReturn;
*/

/**/
            //var user = await _context.users.FindAsync(course.UserId);
            //if (user is null) {

            //    return StatusCode(404, "User to pair with course not found");
            //    //return NotFound();

            //}

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

            //var coursesToReturn = await _context.courses.Where(correctCourse => correctCourse.UserId == addingCourse.UserId).ToListAsync();
            
            //return coursesToReturn;
            return Ok("Kurs tillagd");
/**/

/*
            //var user = await _context.users.FindAsync(course.UserId);
            //if (user is null) {

            //    return StatusCode(404, "User to pair with course not found");
            //    //return NotFound();

            //}

            //var user = await _context.users.FindAsync(course.UserId);

            var addingCourse = new Course {

                CourseNumber = course.CourseNumber,
                CourseTitle = course.CourseTitle,
                CourseDescription = course.CourseDescription,
                CourseLength = course.CourseLength,
                CourseDifficulty = course.CourseDifficulty,
                CourseStatus = course.CourseStatus//,
                //User = user

            };

            _context.courses.Add(addingCourse);
            await _context.SaveChangesAsync();

            //var coursesToReturn = await _context.courses.Where(correctCourse => correctCourse.UserId == addingCourse.UserId).ToListAsync();

            //return coursesToReturn;

            return Ok(await _context.courses.ToListAsync());
*/
            
        }







/*        [HttpPost]
        public async Task<ActionResult<List<Course>>> Create(CreateCourseDTO course) {

            var user = await _context.users.FindAsync(course.UserId);
            if (user is null) {

                return NotFound();
            
            }

            var addingCourse = new Course {

                CourseNumber = course.CourseNumber,
                CourseTitle = course.CourseTitle,
                CourseDescription = course.CourseDescription,
                CourseLength = course.CourseLength,
                CourseDifficulty = course.CourseDifficulty,
                CourseStatus = course.CourseStatus,
                User = user


            };

            _context.courses.Add(addingCourse);
            await _context.SaveChangesAsync();

            return await Get(addingCourse.UserId);

        }
*/












        [HttpGet("/api/GetAllCourses")]/*Works*/
        public async Task<ActionResult<List<Course>>> GetAllCourses() {

            return Ok(await _context.courses.ToListAsync());

        }

        [HttpGet("/api/GetSelectedCourse/{id}")]/* Works but only for specific entry in database with that ID not all identical entries */
        public async Task<ActionResult<Course>> GetSelectedCourse(int id) {

            var courseToReturn = _context.courses.FindAsync(id).Result;

            if (courseToReturn is null) {

                return BadRequest("Kunde inte hämta kurs");

            }

            //return await _context.courses.FindAsync(id);
            return Ok(courseToReturn);

            //GetSelectedCourse_Class getSelectedCourse = new GetSelectedCourse_Class(courseList, id, _context);

            //if (getSelectedCourse.courseList.Find(courseWithId => courseWithId.Id == id) is null) {

            //    return BadRequest("Kunde inte hämta kurs");

            //}

            //return StatusCode(200, await getSelectedCourse._context.courses.FindAsync(id));

        }

        [HttpPost("/api/Old_AddCourse")]/* The user field is required *//* Old that used to work but not with recent changes */
        public async Task<ActionResult<List<Course>>> Old_AddCourse(Course course) {

            //AddCourse_Class addCourse = new AddCourse_Class(courseList, course);

            //courseList = addCourse.courseList;

            await _context.courses.AddAsync(course);

            await _context.SaveChangesAsync();

            return StatusCode(200, _context.courses);

            //return Ok("Kurs tillagd");

        }
        
        
        
        
        





        //[HttpPut("/api/RetireCourse")]/* The user field is required */
        //public async Task<ActionResult<List<Course>>> RetireCourse(Course retiringCourse) {

        //    if (_context.courses.Find(retiringCourse.Id) is null) {

        //        return StatusCode(400, "Pensionering Misslyckad");

        //    }

        //    var courseprofile = _context.courses.Find(retiringCourse.Id);

        //    courseprofile.CourseStatus = retiringCourse.CourseStatus;

        //    await _context.SaveChangesAsync();

        //    return StatusCode(200, _context.courses);

        //}










        [HttpPut("/api/RetireCourse")]/* The user field is required */
        public async Task<ActionResult<List<Course>>> RetireCourse(Course retiringCourse) {

            //RetireCourse_Class retireCourse = new RetireCourse_Class(courseList, retiringCourse);
            //courseList = retireCourse.courseList;
            //return StatusCode(200, retireCourse.courseList);
            //return Ok("Kurs Pensionerad");

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

            //return Ok("Kurs borttagen");

        }

    }
}
