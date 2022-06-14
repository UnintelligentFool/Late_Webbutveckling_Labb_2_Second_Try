namespace Late_Webbutveckling_Labb_2_Second_Try.Controllers.UserControllerClasses {
    public class UpdateUserProfile_Class {

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

        public UpdateUserProfile_Class(List<User> users, User userToUpdate) {
            //userList.IndexOf(user.Id)
            userList = users;

            //var keepOriginalData = userList.Find(keepData => keepData.Id == userToUpdate.Id);

            //originalUserId = userToUpdate.Id;
            //originalUserFirstName = userToUpdate.FirstName;
            //originalUserLastName = userToUpdate.LastName;
            //originalUserEmail = userToUpdate.Email;
            //originalUserPhone = userToUpdate.Phone;
            //originalUserMailRecipient = userToUpdate.MailRecipient;
            //originalUserStreet = userToUpdate.Street;
            //originalUserZipCode = userToUpdate.ZipCode;
            //originalUserCity = userToUpdate.City;
            //originalUserCountry = userToUpdate.Country;

            UpdatingUser(userToUpdate);

        }

        public async Task<ActionResult<List<User>>> UpdatingUser(User userToUpdate) {

            var userprofile = userList.Find(updateThisUser => updateThisUser.Id == userToUpdate.Id);

            originalUserId = userList[(userToUpdate.Id - 1)].Id;
            originalUserFirstName = userList[(userToUpdate.Id - 1)].FirstName;
            originalUserLastName = userList[(userToUpdate.Id - 1)].LastName;
            originalUserEmail = userList[(userToUpdate.Id - 1)].Email;
            originalUserPhone = userList[(userToUpdate.Id - 1)].Phone;
            originalUserMailRecipient = userList[(userToUpdate.Id - 1)].MailRecipient;
            originalUserStreet = userList[(userToUpdate.Id - 1)].Street;
            originalUserZipCode = userList[(userToUpdate.Id - 1)].ZipCode;
            originalUserCity = userList[(userToUpdate.Id - 1)].City;
            originalUserCountry = userList[(userToUpdate.Id - 1)].Country;

            userprofile.FirstName = userToUpdate.FirstName;

            if (userprofile.FirstName == null || userprofile.FirstName == "string") {

                userprofile.FirstName = originalUserFirstName;

            }

            userprofile.LastName = userToUpdate.LastName;

            if (userprofile.LastName == null || userprofile.LastName == "string") {

                userprofile.LastName = originalUserLastName;

            }

            userprofile.Email = userToUpdate.Email;

            if (userprofile.Email == null || userprofile.Email == "string") {

                userprofile.Email = originalUserEmail;

            }

            userprofile.Phone = userToUpdate.Phone;

            if (userprofile.Phone == null || userprofile.Phone <= 99999) {//Expect telephone numbers to always be greater than 6 characters

                userprofile.Phone = originalUserPhone;

            }

            userprofile.MailRecipient = userToUpdate.MailRecipient;

            if (userprofile.MailRecipient == null || userprofile.MailRecipient == "string") {

                userprofile.MailRecipient = originalUserMailRecipient;

            }

            userprofile.Street = userToUpdate.Street;

            if (userprofile.Street == null || userprofile.Street == "string") {

                userprofile.Street = originalUserStreet;

            }

            userprofile.ZipCode = userToUpdate.ZipCode;

            if (userprofile.ZipCode == null || userprofile.ZipCode <= 9999) {//Expect zipcodes to contain 5 characters

                userprofile.ZipCode = originalUserZipCode;

            }

            userprofile.City = userToUpdate.City;

            if (userprofile.City == null || userprofile.City == "string") {

                userprofile.City = originalUserCity;

            }

            userprofile.Country = userToUpdate.Country;

            if (userprofile.Country == null || userprofile.Country == "string") {

                userprofile.Country = originalUserCountry;

            }

            //if (userprofile.FirstName != null && userprofile.FirstName != "string") {

            //    userprofile.FirstName = userToUpdate.FirstName;

            //} else {

            //    userprofile.FirstName = originalUserFirstName;

            //}

            //if (userprofile.LastName != null && userprofile.LastName != "string") {

            //    userprofile.LastName = userToUpdate.LastName;

            //} else {

            //    userprofile.LastName = originalUserLastName;

            //}

            //if (userprofile.Email != null && userprofile.Email != "string") {

            //    userprofile.Email = userToUpdate.Email;

            //} else {

            //    userprofile.Email = originalUserEmail;

            //}

            //if (userprofile.Phone != null && userprofile.Phone > 99999) {//Expect telephone numbers to always be greater than 6 characters

            //    userprofile.Phone = userToUpdate.Phone;

            //} else {

            //    userprofile.Phone = originalUserPhone;

            //}

            //if (userprofile.MailRecipient != null && userprofile.MailRecipient != "string") {

            //    userprofile.MailRecipient = userToUpdate.MailRecipient;

            //} else {

            //    userprofile.MailRecipient = originalUserMailRecipient;

            //}

            //if (userprofile.Street != null && userprofile.Street != "string") {

            //    userprofile.Street = userToUpdate.Street;

            //} else {

            //    userprofile.Street = originalUserStreet;

            //}

            //if (userprofile.ZipCode != null && userprofile.ZipCode > 9999) {//Expect zipcodes to contain 5 characters

            //    userprofile.ZipCode = userToUpdate.ZipCode;

            //} else {

            //    userprofile.ZipCode = originalUserZipCode;

            //}

            //if (userprofile.City != null && userprofile.City != "string") {

            //    userprofile.City = userToUpdate.City;

            //} else {

            //    userprofile.City = originalUserCity;

            //}

            //if (userprofile.Country != null && userprofile.Country != "string") {

            //    userprofile.Country = userToUpdate.Country;

            //} else {

            //    userprofile.Country = originalUserCountry;

            //}

            return (userList);

        }

    }

}