namespace Late_Webbutveckling_Labb_2_Second_Try.Controllers.UserControllerClasses {
    public class GetAllUsers_Class {
        
        public List<User> returnValue;

        private readonly API_Context _context;

        public GetAllUsers_Class(List<User> users, API_Context context) {

            //Theoden: "Death!"
            _context = context;
            
            //Theoden: "Death!!!"
            returnValue = users;

            //return ("Alla användare listade");

            //Theoden: "DEATH!!!"
            ReturnAllUsers();

        }

        public async Task<ActionResult<List<User>>> ReturnAllUsers() {

            return returnValue;
            //return await _context.users.ToListAsync();
            //return await _context.users.ToListAsync();

        }

    }
}






/*
 
  [HttpGet("/api/GetAllUsers")]
        public async Task<ActionResult<List<User>>> GetAllUsers() {

            string randomstring = "!";

            GetAllUsers_Class getAllUsers = new GetAllUsers_Class();

            //return Ok("Alla användare listade");
            return (getAllUsers(randomstring));

        }
 
 */ /* --> */ /*

public GetAllUsers_Class(string randomstring) {

            var returnstring = randomstring;

            returnstring = "Alla användare listade";

            return (returnstring);

        }

*/