namespace Late_Webbutveckling_Labb_2_Second_Try.Controllers.CourseControllerClasses {
    public class RetireCourse_Class {

        public List<Course> courseList;

        protected int originalCourseId;
        protected string originalCourseTitle;
        protected string originalCourseDescription;
        protected int originalCourseNumber;
        protected string originalCourseLength;
        protected string originalCourseDifficulty;
        protected bool originalCourseStatus;

        public RetireCourse_Class(List<Course> courses, Course courseToRetire) {
            
            courseList = courses;

            UpdatingUser(courseToRetire);

        }

        public async Task<ActionResult<List<Course>>> UpdatingUser(Course courseToRetire) {

            var courseprofile = courseList.Find(updateThisCourse => updateThisCourse.Id == courseToRetire.Id);

            originalCourseId = courseList[(courseToRetire.Id - 1)].Id;
            originalCourseTitle = courseList[(courseToRetire.Id - 1)].CourseTitle;
            originalCourseDescription = courseList[(courseToRetire.Id - 1)].CourseDescription;
            originalCourseNumber = courseList[(courseToRetire.Id - 1)].CourseNumber;
            originalCourseLength = courseList[(courseToRetire.Id - 1)].CourseLength;
            originalCourseDifficulty = courseList[(courseToRetire.Id - 1)].CourseDifficulty;
            originalCourseStatus = courseList[(courseToRetire.Id - 1)].CourseStatus;
            

            courseprofile.CourseTitle = courseToRetire.CourseTitle;

            if (courseprofile.CourseTitle != null || courseprofile.CourseTitle != "string") {

                courseprofile.CourseTitle = originalCourseTitle;

            }

            courseprofile.CourseDescription = courseToRetire.CourseDescription;

            if (courseprofile.CourseDescription != null || courseprofile.CourseDescription != "string") {

                courseprofile.CourseDescription = originalCourseDescription;

            }

            courseprofile.CourseLength = courseToRetire.CourseLength;

            if (courseprofile.CourseLength != null || courseprofile.CourseLength != "string") {

                courseprofile.CourseLength = originalCourseLength;

            }

            courseprofile.CourseNumber = courseToRetire.CourseNumber;

            if (courseprofile.CourseNumber != 0 || courseprofile.CourseNumber !> 999999) {//Expect there to be a limit of the amount of courses that will ever become available

                courseprofile.CourseNumber = originalCourseNumber;

            }

            courseprofile.CourseDifficulty = courseToRetire.CourseDifficulty;

            if (courseprofile.CourseDifficulty != null || courseprofile.CourseDifficulty != "string") {

                courseprofile.CourseDifficulty = originalCourseDifficulty;

            }

            courseprofile.CourseStatus = courseToRetire.CourseStatus;

            if (courseprofile.CourseStatus == true) {

                courseprofile.CourseStatus = originalCourseStatus;

            }

            return (courseList);

        }

    }
}
