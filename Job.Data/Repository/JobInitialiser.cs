using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Job.Data.Models.Domain;
using Job.Data.DAO;
using Job.Data.IDAO;

namespace Job.Data.Repository
{
    public class JobInitialiser :
        System.Data.Entity.DropCreateDatabaseIfModelChanges<JobContext>
    {
        protected override void Seed(JobContext context)
        {
            Genre genre1 = new Genre() { Name = "Rock" };
            Genre genre2 = new Genre() { Name = "Pop" };
            Genre genre3 = new Genre() { Name = "Country" };
            
            context.Genres.Add(genre1); context.Genres.Add(genre2);
            context.Genres.Add(genre3);

            Music music1 = new Music()
            {
                Title = "Sabbath Bloody Sabbath",
                num_track = 6,
                duration = 60,
                DateReleased = Convert.ToDateTime("12/11/1979"),
                Price = 2.50
            };
            Music music2 = new Music()
            {
                Title = "Sabbotage",
                num_track = 6,
                duration = 60,
                DateReleased = Convert.ToDateTime("12/11/1976"),
                Price = 12.50
            };
            Music music3 = new Music()
            {
                Title = "Burn",
                num_track = 6,
                duration = 60,
                DateReleased = Convert.ToDateTime("12/11/1975"),
                Price = 7.50
            };
            Music music4 = new Music()
            {
                Title = "Rumors",
                num_track = 6,
                duration = 60,
                DateReleased = Convert.ToDateTime("12/11/1975"),
                Price = 7.50
            };
            Music music5 = new Music()
            {
                Title = "Caravanserai",
                num_track = 6,
                duration = 60,
                DateReleased = Convert.ToDateTime("12/11/1975"),
                Price = 7.50
            };
            Music music6 = new Music()
            {
                Title = "Abraxes",
                num_track = 10,
                duration = 56,
                DateReleased = Convert.ToDateTime("12/02/1975"),
                Price = 17.50
            };
            context.Musics.Add(music1); context.Musics.Add(music2); context.Musics.Add(music3);
            context.Musics.Add(music4); context.Musics.Add(music5); context.Musics.Add(music6);

            Artist artist1 = new Artist() { Name = "Black Sabbath" };
            Artist artist2 = new Artist() { Name = "Deep Purple" };
            Artist artist3 = new Artist() { Name = "Santana" };
            Artist artist4 = new Artist() { Name = "Fleetwood Mac" };
            context.Artists.Add(artist1); context.Artists.Add(artist2);
            context.Artists.Add(artist3); context.Artists.Add(artist4);

            OrderLine orderLine1 = new OrderLine() { Quantity = 10 };
            OrderLine orderLine2 = new OrderLine() { Quantity = 8 };
            OrderLine orderLine3 = new OrderLine() { Quantity = 18 };
            OrderLine orderLine4 = new OrderLine() { Quantity = 16 };
            context.OrderLines.Add(orderLine1); context.OrderLines.Add(orderLine2);
            context.OrderLines.Add(orderLine3); context.OrderLines.Add(orderLine4);

            Order order1 = new Order() { Created = Convert.ToDateTime("12/11/2020"), DelAddress = "123 Muse Lane" };
            Order order2 = new Order() { Created = Convert.ToDateTime("23/05/2019"), DelAddress = "345 Abbey Lane" };
            context.Orders.Add(order1); context.Orders.Add(order2);

            User user1 = new User() { UserId = "mo", Name = "Mo", Email = "mo@mo.com" };
            User user2 = new User() { UserId = "sam", Name = "Sam", Email = "sam@sam.com" };
            User user3 = new User() { UserId = "joe", Name = "Joe", Email = "joe@joe.com" };
            context.Users.Add(user1); context.Users.Add(user2); context.Users.Add(user3);

            Employer employer1 = new Employer()
            { 
                JobTitle = "Software Engineer", 
                JobDescription = "Full Stack Developer",
                JobCategory = "Permanent",
                Salary = "50000",
                CompanyName = "Telenor",
                ComapanyEmail = "mo@mo.com",
                CompanyAddress = "XYZ",
                CompanyWebsite = "mo@mo.com",
            };
            context.Employers.Add(employer1);

            App_User appUser1 = new App_User()
            {
                FirstName = "Faaiza",
                LastName = "Rashid",
                Email = "faaizarashid@hotmail.com",
                Role = "Admin",
            };
            context.AppUsers.Add(appUser1);

            context.SaveChanges();
        }
    }
}
