namespace Late_Webbutveckling_Labb_2_Second_Try.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase {

        private readonly API_Context _context;

        public UserController(API_Context context) {

            _context = context;

        }

        [HttpGet("/api/GetAllUsers")]/* Works */
        public async Task<ActionResult<List<User>>> GetAllUsers() {

            return Ok(await _context.users.ToListAsync());

        }

        [HttpGet("/api/GetUserByEmail/{email}")]/* Works */
        public async Task<ActionResult<User>> GetUserByEmail(string email) {

            //FirstOrDefaultAsync(e => e.Name == "abc000") //Lösning från: https://entityframeworkcore.com/knowledge-base/54902969/ef-core-dealing-with-alternate-primary-keys

            var userToReturn = _context.users.FirstOrDefaultAsync(findEmail => findEmail.Email == email).Result;
            
            if (userToReturn is null) {

                return BadRequest("Kunde inte hämta användare");

            }

            return Ok(userToReturn);

        }


        [HttpPost("/api/AddUser")]
        public async Task<ActionResult<List<User>>> AddUser(/*User user*/ UserDTO user, [FromForm] Course course) {

            if (user is null) {

                return StatusCode(400, "Kunde inte registrera användare");

            }

            var addingUser = new User {

                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Phone = user.Phone,
                MailRecipient = user.MailRecipient,
                Street = user.Street,
                ZipCode = user.ZipCode,
                City = user.City,
                Country = user.Country,
                OwnedCourses = user.OwnedCourses

            };

            _context.users.Add(addingUser);
            await _context.SaveChangesAsync();

            var usersToReturn = await _context.users.Where(correctUser => correctUser.Id == addingUser.Id).ToListAsync();

            return usersToReturn;

        }

        [HttpPut("/api/UpdateUserProfile")]
        public async Task<ActionResult<List<User>>> UpdateUserProfile(User user) {

            int originalUserId;
            string originalUserFirstName;
            string originalUserLastName;
            string originalUserEmail;
            long originalUserPhone;
            string originalUserMailRecipient;
            string originalUserStreet;
            int originalUserZipCode;
            string originalUserCity;
            string originalUserCountry;

            var userprofile = _context.users.Find(user.Id);

            if (userprofile is null) {

                return StatusCode(400, "Kunde inte uppdatera användare");

            }

            originalUserFirstName = _context.users.Find(user.Id).FirstName;
            originalUserLastName = _context.users.Find(user.Id).LastName;
            originalUserEmail = _context.users.Find(user.Id).Email;
            originalUserPhone = _context.users.Find(user.Id).Phone;
            originalUserMailRecipient = _context.users.Find(user.Id).MailRecipient;
            originalUserStreet = _context.users.Find(user.Id).Street;
            originalUserZipCode = _context.users.Find(user.Id).ZipCode;
            originalUserCity = _context.users.Find(user.Id).City;
            originalUserCountry = _context.users.Find(user.Id).Country;


            userprofile.FirstName = user.FirstName;

            if (userprofile.FirstName == null || userprofile.FirstName == "string") {

                userprofile.FirstName = originalUserFirstName;

            }

            userprofile.LastName = user.LastName;

            if (userprofile.LastName == null || userprofile.LastName == "string") {

                userprofile.LastName = originalUserLastName;

            }

            userprofile.Email = user.Email;

            if (userprofile.Email == null || userprofile.Email == "string") {

                userprofile.Email = originalUserEmail;

            }

            userprofile.Phone = user.Phone;

            if (userprofile.Phone == null || userprofile.Phone <= 99999) {//Expect telephone numbers to always be greater than 6 characters

                userprofile.Phone = originalUserPhone;

            }

            userprofile.MailRecipient = user.MailRecipient;

            if (userprofile.MailRecipient == null || userprofile.MailRecipient == "string") {

                userprofile.MailRecipient = originalUserMailRecipient;

            }

            userprofile.Street = user.Street;

            if (userprofile.Street == null || userprofile.Street == "string") {

                userprofile.Street = originalUserStreet;

            }

            userprofile.ZipCode = user.ZipCode;

            if (userprofile.ZipCode == null || userprofile.ZipCode <= 9999) {//Expect zipcodes to contain 5 characters

                userprofile.ZipCode = originalUserZipCode;

            }

            userprofile.City = user.City;

            if (userprofile.City == null || userprofile.City == "string") {

                userprofile.City = originalUserCity;

            }

            userprofile.Country = user.Country;

            if (userprofile.Country == null || userprofile.Country == "string") {

                userprofile.Country = originalUserCountry;

            }

            await _context.SaveChangesAsync();

            return StatusCode(200, _context.users);

        }

        [HttpPut("/api/AddCourseToUserProfile/{user}/{course}")]
        public async Task<ActionResult<List<Course>>> AddCourseToUserProfile(Course course, string user) {

            var courseprofile = _context.courses.Find(course.Id);

            if (courseprofile is null) {

                return StatusCode(400, "Unable to locate course");

            }

            courseprofile.UserId = user;

            await _context.SaveChangesAsync();

            return StatusCode(200, _context.courses);

        }
    }
}
