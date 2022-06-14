namespace Late_Webbutveckling_Labb_2_Second_Try.Controllers.CourseControllerClasses {
    public class GetSelectedCourse_Class {

        public List<Course> courseList;

        public readonly API_Context _context;

        //public GetSelectedCourse_Class(List<Course> courses, int id, API_Context context) {

        //    _context = context;

        //    courseList = courses;

        //    ReturnSelectedCourse(id);

        //}

        //public async Task<ActionResult<Course>> ReturnSelectedCourse(int id) {

        //    //var courseToReturn = courseList.Find(returnValue => returnValue.Id == id);

        //    //_context.courses.ToListAsync()
        //    //var courseToReturn = await _context.courses.FindAsync(id);

        //    //var courseToReturn = await _context.courses.FindAsync(id);

        //    return await _context.courses.FindAsync(id);

        //    //return courseToReturn;

        //}

        public GetSelectedCourse_Class(List<Course> courses, int id, API_Context context) {

            _context = context;

            courseList = courses;

            RunGetSelectedCourse_Class(courses, id, context);

        }

        public static async Task<GetSelectedCourse_Class> RunGetSelectedCourse_Class(List<Course> courses, int id, API_Context context) {

            var getSelectedCourse_Class = new GetSelectedCourse_Class(courses, id, context);
            await getSelectedCourse_Class.ReturnSelectedCourse(id);
            return getSelectedCourse_Class;
        
        }

        public async Task<ActionResult<Course>> ReturnSelectedCourse(int id) {

            //var courseToReturn = courseList.Find(returnValue => returnValue.Id == id);

            //_context.courses.ToListAsync()
            //var courseToReturn = await _context.courses.FindAsync(id);

            //var courseToReturn = await _context.courses.FindAsync(id);

            return await _context.courses.FindAsync(id);

            //return courseToReturn;

        }

    }
}
