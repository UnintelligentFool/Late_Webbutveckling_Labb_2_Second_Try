namespace Late_Webbutveckling_Labb_2_Second_Try.Controllers.UserControllerClasses {
    public class AddUser_Class {

        public List<User> userList;
        //public User NewUser;

        public AddUser_Class(List<User> users, User userToBeAdded) {

            userList = users;

            //NewUser = userToBeAdded;

            AddTheUser(userToBeAdded);

        }

        public async Task<ActionResult<List<User>>> AddTheUser(User userToBeAdded) {

            //userList.Add(NewUser);
            
            userList.Add(userToBeAdded);

            return userList;

        }

    }
}
