namespace Late_Webbutveckling_Labb_2_Second_Try.Controllers.CourseControllerClasses {
    public class AddCourse_Class {

        public List<Course> courseList;
        
        public AddCourse_Class(List<Course> courses, Course courseToBeAdded) {

            courseList = courses;

            AddTheCourse(courseToBeAdded);

        }

        public async Task<ActionResult<List<Course>>> AddTheCourse(Course courseToBeAdded) {

            courseList.Add(courseToBeAdded);

            return courseList;

        }

    }

}
