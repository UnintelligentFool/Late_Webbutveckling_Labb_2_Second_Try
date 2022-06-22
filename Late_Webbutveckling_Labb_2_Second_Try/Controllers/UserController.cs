namespace Late_Webbutveckling_Labb_2_Second_Try.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase {

        //private readonly API_Context _apiContext;

        //public UserController(API_Context api_Context) {

        //    _apiContext = api_Context;

        //}

        public List<User> userList = new List<User> {

            new User {

                Id = 1,
                FirstName = "Adam",
                LastName = "Savage",
                Email = "adam@savage.com",
                Phone = 0078833746,
                MailRecipient = "Adam Savage",
                Street = "Savagestreet 98",
                ZipCode = 43543,
                City = "Adamsville",
                Country = "United Penguin Federation",
                OwnedCourses = {}

            },

            new User {

                Id = 2,
                FirstName = "Katherine",
                LastName = "Kerr",
                Email = "kath@kerr.net",
                Phone = 9838983966,
                MailRecipient = "Katherine Kerr",
                Street = "Dragonroad 7",
                ZipCode = 74467,
                City = "Lughcarn",
                Country = "Deverry",
                OwnedCourses = {}

            },

            new User {

                Id = 3,
                FirstName = "Elisabeth",
                LastName = "Moon",
                Email = "e@moon.com",
                Phone = 6724308956,
                MailRecipient = "Elisabeth Moon",
                Street = "King's Street 16",
                ZipCode = 10958,
                City = "Verella",
                Country = "Tsaia",
                OwnedCourses = {}

            }

        };

        //public UserController() {

        //    userList.Add();

        //    //Id
        //    //FirstName
        //    //LastName
        //    //Email
        //    //Phone
        //    //MailRecipient
        //    //Street
        //    //ZipCode
        //    //City
        //    //Country

        //}


        private readonly API_Context _context;

        public UserController(API_Context context) {

            _context = context;

        }

        [HttpGet("/api/GetAllUsers")]
        public async Task<ActionResult<List<User>>> GetAllUsers() {

            return Ok(await _context.users.ToListAsync());

        }

        [HttpGet("/api/GetUserByEmail/{email}")]
        public async Task<ActionResult<User>> GetUserByEmail(string email) {

            //GetUserByEmail_Class getUserByEmail = new GetUserByEmail_Class(userList, email);

            //return Ok(getUserByEmail.ReturnUserByEmail(email));
            //return new ContentResult() { };
            //return StatusCode(222, getUserByEmail.ReturnUserByEmail(email));
            //return StatusCode(200, getUserByEmail.ReturnUserByEmail(email));
            //return Ok("Användare med vald e-post visas");

            //FirstOrDefaultAsync(e => e.Name == "abc000") //Lösning feån: https://entityframeworkcore.com/knowledge-base/54902969/ef-core-dealing-with-alternate-primary-keys

            var userToReturn = _context.users.FirstOrDefaultAsync(findEmail => findEmail.Email == email).Result;
            //var userToReturn = userList.Find(returnValue => returnValue.Email == userEmail);
            
            if (userToReturn is null) {

                return BadRequest("Kunde inte hämta användare");

            }

            //return await _context.courses.FindAsync(id);
            return Ok(userToReturn);

        }


        [HttpPost("/api/AddUser")]
        public async Task<ActionResult<List<User>>> AddUser(User user) {

            AddUser_Class addUser = new AddUser_Class(userList, user);

            userList = addUser.userList;

            return StatusCode(200, addUser.userList);
            //return Ok(addUser);

            //return Ok("Användare registrerad");

        }
        
        [HttpPut("/api/UpdateUserProfile")]
        public async Task<ActionResult<List<User>>> UpdateUserProfile(User user) {

            UpdateUserProfile_Class updateUserProfile = new UpdateUserProfile_Class(userList, user);

            userList = updateUserProfile.userList;

            return StatusCode(200, updateUserProfile.userList);

            //return Ok("Användarprofil uppdaterad");

        }
        
        [HttpPut("/api/AddCourseToUserProfile")]//  /{id}
        public async Task<ActionResult<List<User>>> AddCourseToUserProfile(/*int id,*/ User user, [FromQuery] Course course) {

            //User user = new User();

            //user.Id = id;
            //user.FirstName = userList[id].FirstName;
            //user.LastName = userList[id].LastName;

            AddCourseToUserProfile_Class addCourseToUserProfile = new AddCourseToUserProfile_Class(userList/*, id*/, user, course);

            userList = addCourseToUserProfile.userList;

            return StatusCode(200, addCourseToUserProfile.userList);

            //return Ok("Kurs tillagd i användarprofil");

        }

    }
}
