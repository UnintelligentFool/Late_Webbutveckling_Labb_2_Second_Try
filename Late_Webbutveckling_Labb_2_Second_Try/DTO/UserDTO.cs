namespace Late_Webbutveckling_Labb_2_Second_Try.DTO {
    public class UserDTO {

        //Id
        public int Id {

            get;
            set;

        }

        //Förnamn
        public string FirstName {

            get;
            set;

        } = String.Empty;

        //Efternamn
        public string LastName {

            get;
            set;

        } = String.Empty;

        //E-post
        public string Email {

            get;
            set;

        } = String.Empty;

        //Mobilnummer
        public long Phone {

            get;
            set;

        }

        //Adressuppgifter: Namn på personen som tar emot posten, den posten sänds till
        public string MailRecipient {

            get;
            set;

        } = String.Empty;

        //Adressuppgifter: Gatunamn
        public string Street {

            get;
            set;

        } = String.Empty;

        //Adressuppgifter: Postnummer
        public int ZipCode {

            get;
            set;

        }

        //Adressuppgifter: Stad/Ort
        public string City {

            get;
            set;

        } = String.Empty;

        //Adressuppgifter: Land
        public string Country {

            get;
            set;

        } = String.Empty;

        public List<Course>? OwnedCourses {

            get;
            set;

        }

        /*StartNy*/
        //public int UserId {

        //    get;

        //    set;

        //} = 1;

        //public Course? Course {

        //    get;

        //    set;

        //}

        public int CourseId {

            get;

            set;

        } = 1;

        public List<Course>? courses {

            get;

            set;

        }

        /*EndNy*/

    }
}
