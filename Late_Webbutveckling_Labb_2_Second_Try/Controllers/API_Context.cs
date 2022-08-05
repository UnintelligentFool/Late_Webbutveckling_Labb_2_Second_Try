namespace Late_Webbutveckling_Labb_2_Second_Try.Controllers {
    public class API_Context : DbContext {

        public API_Context(DbContextOptions<API_Context> contextOptions) : base(contextOptions) {



        }

        public DbSet<User> users {

            get;

            set;
        
        }

        public DbSet<Course> courses {

            get;

            set;

        }

    }
}