namespace Late_Webbutveckling_Labb_2_Second_Try.Controllers.UserControllerClasses {
    public class GetUserByEmail_Class {
    
        public List<User> userList;

        public GetUserByEmail_Class(List<User> users, string userEmail) {
 
            userList = users;

            ReturnUserByEmail(userEmail);

        }
 
        public async Task<ActionResult<User>> ReturnUserByEmail(string userEmail) {

            //var userToReturn = await userList.Find(userEmail);
            //var userToReturn = await userList.Where(returnValue => returnValue.Email(userEmail));
            //var userToReturn = await userList.Find(returnValue => returnValue.Email(userEmail));
            var userToReturn = userList.Find(returnValue => returnValue.Email == userEmail);

            
            return userToReturn;
 
        }

    }

}
