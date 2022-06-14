namespace Late_Webbutveckling_Labb_2_Second_Try.Controllers.CourseControllerClasses {
    public class DeleteCourse_Class {

        public List<Course> courseList;

        public DeleteCourse_Class(List<Course> courses, int id) {

            courseList = courses;

            DeletingCourse(id);

        }

        public async Task<ActionResult<List<Course>>> DeletingCourse(int id) {

            //var courseToDelete = courseList.Find(deletingcourse => deletingcourse.Id == id);

            //courseList.Remove(courseToDelete);

            courseList.Remove(courseList.Find(deletingcourse => deletingcourse.Id == id));

            return (courseList);

        }

    }
}
