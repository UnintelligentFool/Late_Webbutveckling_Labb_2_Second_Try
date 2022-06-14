namespace Late_Webbutveckling_Labb_2_Second_Try.Controllers.CourseControllerClasses {
    public class GetAllCourses_Class {

        public List<Course> returnValue;

        public GetAllCourses_Class(List<Course> courses/*, API_Context apiContext*/) {

            returnValue = courses;

            //_apiContext = apiContext;

            //return ("Alla användare listade");

            //ReturnAllUsers();

        }

        public async Task<ActionResult<List<Course>>> ReturnAllCourses() {

            return returnValue;

        }

    }
}
