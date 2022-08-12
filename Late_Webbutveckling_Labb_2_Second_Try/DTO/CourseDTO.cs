namespace Late_Webbutveckling_Labb_2_Second_Try.DTO {
    public class CourseDTO {

        //Kursnummer
        public int CourseNumber {

            get;
            set;

        } = 100;

        //Kurstitel
        public string? CourseTitle {

            get;
            set;

        } = String.Empty;

        //Kursbeskrivning
        public string? CourseDescription {

            get;
            set;

        } = String.Empty;

        //Kurslängd
        public string? CourseLength {

            get;
            set;

        } = String.Empty;

        //Nivå på kursen(nybörjare, medel, avancerad)
        public string? CourseDifficulty {

            get;
            set;

        } = String.Empty;

        //Status(aktiv, pensionerad)
        public bool CourseStatus {

            get;
            set;

        } = true;

        public string? UserId {

            get;

            set;

        }
    }
}