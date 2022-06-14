namespace Late_Webbutveckling_Labb_2_Second_Try.Controllers.UserControllerClasses {
    public class AddCourseToUserProfile_Class {

        public List<User> userList;

        protected int originalUserId;
        protected string originalUserFirstName;
        protected string originalUserLastName;
        protected string originalUserEmail;
        protected long originalUserPhone;
        protected string originalUserMailRecipient;
        protected string originalUserStreet;
        protected int originalUserZipCode;
        protected string originalUserCity;
        protected string originalUserCountry;

        //New Code // A disturbance in the force

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

        //New Code // There is no force

        public AddCourseToUserProfile_Class(List<User> users, /*int id,*/ User courseToAdd, Course course) {

            userList = users;
            
            //originalUserId = courseToAdd.Id;
            //originalUserFirstName = courseToAdd.FirstName;
            //originalUserLastName = courseToAdd.LastName;
            //originalUserEmail = courseToAdd.Email;
            //originalUserPhone = courseToAdd.Phone;
            //originalUserMailRecipient = courseToAdd.MailRecipient;
            //originalUserStreet = courseToAdd.Street;
            //originalUserZipCode = courseToAdd.ZipCode;
            //originalUserCity = courseToAdd.City;
            //originalUserCountry = courseToAdd.Country;

            AAddCourseToUser(courseToAdd, course);

        }

        public async Task<ActionResult<List<User>>> AAddCourseToUser(User courseToAdd, Course course) {

            var userprofile = userList.Find(updateThisUser => updateThisUser.Id == courseToAdd.Id);



            //originalUserId = userList[(courseToAdd.Id - 1)].Id;
            //originalUserFirstName = userList[(courseToAdd.Id - 1)].FirstName;
            //originalUserLastName = userList[(courseToAdd.Id - 1)].LastName;
            //originalUserEmail = userList[(courseToAdd.Id - 1)].Email;
            //originalUserPhone = userList[(courseToAdd.Id - 1)].Phone;
            //originalUserMailRecipient = userList[(courseToAdd.Id - 1)].MailRecipient;
            //originalUserStreet = userList[(courseToAdd.Id - 1)].Street;
            //originalUserZipCode = userList[(courseToAdd.Id - 1)].ZipCode;
            //originalUserCity = userList[(courseToAdd.Id - 1)].City;
            //originalUserCountry = userList[(courseToAdd.Id - 1)].Country;

            //userprofile.FirstName = originalUserFirstName;
            //userprofile.LastName = originalUserLastName;
            //userprofile.Email = originalUserEmail;
            //userprofile.Phone = originalUserPhone;
            //userprofile.MailRecipient = originalUserMailRecipient;
            //userprofile.Street = originalUserStreet;
            //userprofile.ZipCode = originalUserZipCode;
            //userprofile.City = originalUserCity;
            //userprofile.Country = originalUserCountry;

            //Course newCourse = new Course();
            //newCourse.Id = course.Id;
            //newCourse.CourseTitle = course.CourseTitle;
            //newCourse.CourseStatus = course.CourseStatus;
            //newCourse.CourseNumber = course.CourseNumber;
            //newCourse.CourseLength = course.CourseLength;
            //newCourse.CourseDifficulty = course.CourseDifficulty;
            //newCourse.CourseDescription = course.CourseDescription;

            //courseToAdd.OwnedCourses.Add(newCourse);

            //userList.Add(courseToAdd);
            //courseToAdd.OwnedCourses.Add(newCourse);
            courseToAdd.OwnedCourses.Add(course);
            userList.Add(courseToAdd);

            return (userList);

        }

            public async Task<ActionResult<List<User>>> AddCourseToUser(User courseToAdd, Course course) {

            var userprofile = userList.Find(updateThisUser => updateThisUser.Id == courseToAdd.Id);

            //if (userprofile.FirstName != null && userprofile.FirstName != "string") {

            //    userprofile.FirstName = courseToAdd.FirstName;

            //}

            //if (userprofile.LastName != null && userprofile.LastName != "string") {

            //    userprofile.LastName = courseToAdd.LastName;

            //}

            //if (userprofile.Email != null && userprofile.Email != "string") {

            //    userprofile.Email = courseToAdd.Email;

            //}

            //if (userprofile.Phone != null && userprofile.Phone > 99999) {//Expect telephone numbers to always be greater than 6 characters

            //    userprofile.Phone = courseToAdd.Phone;

            //}

            //if (userprofile.MailRecipient != null && userprofile.MailRecipient != "string") {

            //    userprofile.MailRecipient = courseToAdd.MailRecipient;

            //}

            //if (userprofile.Street != null && userprofile.Street != "string") {

            //    userprofile.Street = courseToAdd.Street;

            //}

            //if (userprofile.ZipCode != null && userprofile.ZipCode > 9999) {//Expect zipcodes to contain 5 characters

            //    userprofile.ZipCode = courseToAdd.ZipCode;

            //}

            //if (userprofile.City != null && userprofile.City != "string") {

            //    userprofile.City = courseToAdd.City;

            //}

            //userprofile.FirstName = courseToAdd.FirstName;
            //userprofile.LastName = courseToAdd.LastName;
            //userprofile.Email = courseToAdd.Email;
            //userprofile.Phone = courseToAdd.Phone;
            //userprofile.MailRecipient = courseToAdd.MailRecipient;
            //userprofile.Street = courseToAdd.Street;
            //userprofile.ZipCode = courseToAdd.ZipCode;
            //userprofile.City = courseToAdd.City;



            originalUserId = userList[(courseToAdd.Id - 1)].Id;
            originalUserFirstName = userList[(courseToAdd.Id - 1)].FirstName;
            originalUserLastName = userList[(courseToAdd.Id - 1)].LastName;
            originalUserEmail = userList[(courseToAdd.Id - 1)].Email;
            originalUserPhone = userList[(courseToAdd.Id - 1)].Phone;
            originalUserMailRecipient = userList[(courseToAdd.Id - 1)].MailRecipient;
            originalUserStreet = userList[(courseToAdd.Id - 1)].Street;
            originalUserZipCode = userList[(courseToAdd.Id - 1)].ZipCode;
            originalUserCity = userList[(courseToAdd.Id - 1)].City;
            originalUserCountry = userList[(courseToAdd.Id - 1)].Country;
            


            userprofile.FirstName = originalUserFirstName;
            userprofile.LastName = originalUserLastName;
            userprofile.Email = originalUserEmail;
            userprofile.Phone = originalUserPhone;
            userprofile.MailRecipient = originalUserMailRecipient;
            userprofile.Street = originalUserStreet;
            userprofile.ZipCode = originalUserZipCode;
            userprofile.City = originalUserCity;
            userprofile.Country = originalUserCountry;



            //userprofile.OwnedCourses.Add(course);
            //userprofile.OwnedCourses(course.Id) = course.Id;

            Course newCourse = new Course();
            newCourse.Id = course.Id;
            newCourse.CourseTitle = course.CourseTitle;
            newCourse.CourseStatus = course.CourseStatus;
            newCourse.CourseNumber = course.CourseNumber;
            newCourse.CourseLength = course.CourseLength;
            newCourse.CourseDifficulty = course.CourseDifficulty;
            newCourse.CourseDescription = course.CourseDescription;


            //New code


            // var courseprofile = userList.Find(updateThisUser => updateThisUser.Id == courseToAdd.Id);


            ////Course newCourse = new Course();
            //newCourse.Id = courseList[1].Id;
            //newCourse.CourseTitle = courseList[1].CourseTitle;
            //newCourse.CourseStatus = courseList[1].CourseStatus;
            //newCourse.CourseNumber = courseList[1].CourseNumber;
            //newCourse.CourseLength = courseList[1].CourseLength;
            //newCourse.CourseDifficulty = courseList[1].CourseDifficulty;
            //newCourse.CourseDescription = courseList[1].CourseDescription;


            //End new code


            userprofile.OwnedCourses.Add(newCourse);



            //userprofile.FirstName = courseToAdd.FirstName;
            //userprofile.LastName = courseToAdd.LastName;
            //userprofile.Email = courseToAdd.Email;
            //userprofile.Phone = courseToAdd.Phone;
            //userprofile.MailRecipient = courseToAdd.MailRecipient;
            //userprofile.Street = courseToAdd.Street;
            //userprofile.ZipCode = courseToAdd.ZipCode;
            //userprofile.City = courseToAdd.City;





            //userprofile.OwnedCourses += ;

            return (userList);

        }










































        //public async Task<ActionResult<List<User>>> AddCourseToUser(User courseToAdd, Course course) {

        //    var userprofile = userList.Find(updateThisUser => updateThisUser.Id == courseToAdd.Id);

        //    originalUserId = userList[(courseToAdd.Id - 1)].Id;
        //    originalUserFirstName = userList[(courseToAdd.Id - 1)].FirstName;
        //    originalUserLastName = userList[(courseToAdd.Id - 1)].LastName;
        //    originalUserEmail = userList[(courseToAdd.Id - 1)].Email;
        //    originalUserPhone = userList[(courseToAdd.Id - 1)].Phone;
        //    originalUserMailRecipient = userList[(courseToAdd.Id - 1)].MailRecipient;
        //    originalUserStreet = userList[(courseToAdd.Id - 1)].Street;
        //    originalUserZipCode = userList[(courseToAdd.Id - 1)].ZipCode;
        //    originalUserCity = userList[(courseToAdd.Id - 1)].City;
        //    originalUserCountry = userList[(courseToAdd.Id - 1)].Country;

        //    userprofile.FirstName = originalUserFirstName;
        //    userprofile.LastName = originalUserLastName;
        //    userprofile.Email = originalUserEmail;
        //    userprofile.Phone = originalUserPhone;
        //    userprofile.MailRecipient = originalUserMailRecipient;
        //    userprofile.Street = originalUserStreet;
        //    userprofile.ZipCode = originalUserZipCode;
        //    userprofile.City = originalUserCity;
        //    userprofile.Country = originalUserCountry;

        //    Course newCourse = new Course();
        //    newCourse.Id = course.Id;
        //    newCourse.CourseTitle = course.CourseTitle;
        //    newCourse.CourseStatus = course.CourseStatus;
        //    newCourse.CourseNumber = course.CourseNumber;
        //    newCourse.CourseLength = course.CourseLength;
        //    newCourse.CourseDifficulty = course.CourseDifficulty;
        //    newCourse.CourseDescription = course.CourseDescription;

        //    userprofile.OwnedCourses.Add(newCourse);

        //    return (userList);

        //}



































    }
}