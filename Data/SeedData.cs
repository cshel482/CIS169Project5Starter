using CourseCatalog.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseCatalog.Data;

public class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context =
               new CourseCatalogContext(serviceProvider.GetRequiredService<DbContextOptions<CourseCatalogContext>>()))
        {
            if (context == null || context.Course == null)
            {
                throw new ArgumentNullException("Null context");
            }

            if (context.Course.Any())
            {
                return; 
            }
            context.Course.AddRange(
                new Course()
                {
                    CourseDescription = "Descriptive", 
                    CourseName = "Cobol", 
                    Id = 12, 
                    RoomNumber = 120,
                    StartTime = new TimeOnly(1,30)
                },
                new Course()
                {
                    CourseDescription = "Do Stuff", 
                    CourseName = "Program thing", 
                    Id = 13, 
                    RoomNumber = 200,
                    StartTime = new TimeOnly(1,45)
                },
                new Course()
                {
                    CourseDescription = "Thingy thing", 
                    CourseName = "Hacker Class", 
                    Id = 14, 
                    RoomNumber = 116,
                    StartTime = new TimeOnly(1,30)
                },
                new Course()
                {
                    CourseDescription = "Program things for stuff", 
                    CourseName = "Cobol II", 
                    Id = 15, 
                    RoomNumber = 200,
                    StartTime = new TimeOnly(1,00)
                },
                new Course()
                {
                    CourseDescription = "Make Websites", 
                    CourseName = "Web design", 
                    Id = 16, 
                    RoomNumber = 112,
                    StartTime = new TimeOnly(8,0)
                }
                
                );
            context.SaveChanges();
        }
    }
}