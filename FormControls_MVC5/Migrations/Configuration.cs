namespace FormControls_MVC5.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Models.FormsDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Models.FormsDbContext context)
        {
            context.Countries.AddOrUpdate(new Models.Country { ID = "1", Name = "Australia" });
            context.Countries.AddOrUpdate(new Models.Country { ID = "2", Name = "Canada" });
            context.Countries.AddOrUpdate(new Models.Country { ID = "3", Name = "Turkey" });
            context.Countries.AddOrUpdate(new Models.Country { ID = "4", Name = "United Kingdom" });
            context.Countries.AddOrUpdate(new Models.Country { ID = "5", Name = "United States" });

            context.Courses.AddOrUpdate(new Models.Course { Name = "Course 1", ID = "1", Checked = false });
            context.Courses.AddOrUpdate(new Models.Course { Name = "Course 2", ID = "2", Checked = false });
            context.Courses.AddOrUpdate(new Models.Course { Name = "Course 3", ID = "3", Checked = false });
            context.Courses.AddOrUpdate(new Models.Course { Name = "Course 4", ID = "4", Checked = false });
            context.Courses.AddOrUpdate(new Models.Course { Name = "Course 5", ID = "5", Checked = false });
        }
    }
}
