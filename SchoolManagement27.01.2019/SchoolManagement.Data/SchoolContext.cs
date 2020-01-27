namespace SchoolManagement.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class SchoolContext : DbContext
    {
        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'SchoolManagement.Data.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public SchoolContext()
           // : base("name=SchoolContext")
           :base()
        {
           // Database.SetInitializer<SchoolContext>(new SchoolDBInitializer());
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<SchoolContext, SchoolManagement.Migrations.Configuration>());
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Classe> Classes { get; set; }
        public virtual DbSet<ClassMessage> ClassMessages { get; set; }
        public virtual DbSet<ClassTimeTable> ClassTimetables { get; set; }
        public virtual DbSet<ContactPerson> ContactPersons { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentClassEvaluation> StudentClassEvaluations { get; set; }
        public virtual DbSet<StudentPayment> StudentPayments { get; set; }
        public virtual DbSet<StudentPresence> StudentPresences { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public static SchoolContext Create()
        {
            return new SchoolContext();
        }
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        //public virtual DbSet<BaseEntity> MyEntities { get; set; }
    }

}