namespace Late_Webbutveckling_Labb_2_Second_Try.Models {
    public class Course {

        //Id
        public int Id {

            get;
            set;

        }

        //Kursnummer
        public int CourseNumber {

            get;
            set;

        }

        //Kurstitel
        public string CourseTitle {

            get;
            set;

        } = String.Empty;

        //Kursbeskrivning
        public string CourseDescription {

            get;
            set;

        } = String.Empty;

        //Kurslängd
        public string CourseLength {

            get;
            set;

        } = String.Empty;

        //Nivå på kursen(nybörjare, medel, avancerad)
        public string CourseDifficulty {

            get;
            set;

        } = String.Empty;

        //Status(aktiv, pensionerad)
        public bool CourseStatus {

            get;
            set;

        }

        [JsonIgnore]
        public User? User {//Måste acceptera Null värden för att fungera med RetireCourse

            get;

            set;
        
        }
        
        public string? UserId {

            get;

            set;

        }
    }
}

//CourseTitle
//CourseDescription
//CourseNumber
//CourseLength
//CourseDifficulty
//CourseStatus
//Id