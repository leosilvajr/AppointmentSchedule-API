//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Design;

//namespace AppointmentSchedule.Infra.Context
//{
//    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AppointmentScheduleContext>
//    {
//        public AppointmentScheduleContext CreateDbContext(string[] args)
//        {
//            var optionsBuilder = new DbContextOptionsBuilder<AppointmentScheduleContext>();
//            optionsBuilder.UseSqlServer("Server=.;Database=AppointmentSchedule;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true");

//            return new AppointmentScheduleContext(optionsBuilder.Options);
//        }
//    }
//}
