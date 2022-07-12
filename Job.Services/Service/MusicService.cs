using Job.Data;
using Job.Data.DAO;
using Job.Data.IDAO;
using Job.Data.Models.Domain;
using Job.Data.Repository;
using Job.Services.IService;
using Job.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.Services.Service
{
    public class MusicService : IMusicService
    {
        private IMusicDAO musicDAO;
        private IGenreDAO genreDAO;
        private IUserDAO userDAO;
        private IArtistDAO artistDAO;


        public MusicService()
        {
            musicDAO = new MusicDAO();
            genreDAO = new GenreDAO();
            userDAO = new UserDAO();
            artistDAO = new ArtistDAO();
        }

        public void DeleteJob(int id)
        {
            using (var context = new JobContext())
            {
                musicDAO.DeleteJob(context, id);
                //musicDAO.DeleteMusic(context, music);
            }
        }

        public void SaveJob(SavedJobs savedJobs)
        {
            using (var context = new JobContext())
            {
                musicDAO.SaveJob(context, savedJobs);
                //musicDAO.DeleteMusic(context, music);
            }
        }

        public void AddJob(PostJobDto postJobDto, string userId)
        {
            #region
            Employer newEmployer = new Employer()
            {
                //Dress up Music object using values of attributes
                JobTitle = postJobDto.JobTitle,
                JobDescription = postJobDto.JobDescription,
                JobCategory = postJobDto.JobCategory,
                Salary = postJobDto.Salary,
                CompanyName = postJobDto.CompanyName,
                CompanyAddress = postJobDto.CompanyAddress,
                ComapanyEmail = postJobDto.ComapanyEmail,
                CompanyWebsite = postJobDto.CompanyWebsite
            };
            #endregion

            #region - Working with DAOs to add object and add to collections
            using (var context = new JobContext())
            {   //context object is created
                musicDAO.AddJob(context, newEmployer);//Add music

                //Genre genre = genreDAO.GetGenre(context, musicGenreArtist.Genre); //Create Genre Object
                //genreDAO.AddMusicToCollection(context, genre, newMusic); //Add music to Collection of Genre

                //Artist artist = artistDAO.GetArtist(context, musicGenreArtist.Artist); //Create Artist object
                //artistDAO.AddMusicToCollection(context, newMusic, artist); //Add music to Collection of Artist

                //userDAO.AddToMusicCollection(context, userId, newMusic); //Add Music to Collection of User

                context.SaveChanges();
            }   //Context object is disposed
            #endregion
        }

        public void ApplyJob(AppliedJobs appliedJobs)
        {
          
            #region - Working with DAOs to add object and add to collections
            using (var context = new JobContext())
            {   //context object is created
                musicDAO.ApplyJob(context, appliedJobs);//Apply for a job
                context.SaveChanges();
            }   //Context object is disposed
            #endregion
        }

        public void AddUser(App_User app_User)
        {
            
            #region - Working with DAOs to add object and add to collections
            using (var context = new JobContext())
            {   //context object is created
                musicDAO.AddUser(context, app_User);//Add music
                context.SaveChanges();
            }   //Context object is disposed
            #endregion
        }
        //Using the add method after the changes to add as a new entry
        public void EditJob(PostJobDto postJobDto, string userId, int id)
        {
            using (var context = new JobContext())
            {
                Employer employer =new Employer();

                employer.JobTitle = postJobDto.JobTitle;
                employer.JobDescription = postJobDto.JobDescription;
                employer.JobCategory = postJobDto.JobCategory;
                employer.Salary = postJobDto.Salary;
                employer.CompanyName = postJobDto.CompanyName;
                employer.CompanyAddress = postJobDto.CompanyAddress;
                employer.ComapanyEmail = postJobDto.ComapanyEmail;
                employer.CompanyWebsite = postJobDto.CompanyWebsite;

                //int oldGenreId = genreDAO.GetGenreByMusicID(context, id);

                ////Creating the genre object using the current genreId
                //Genre oldGenre = genreDAO.GetGenre(context, oldGenreId);

                ////Remove music from Genre's music collection
                //oldGenre.Musics.Remove(context.Musics.Find(id));

                //int oldArtistId = artistDAO.GetArtistByMusicID(context, id);

                ////Creating the genre object using the current genreId
                //Artist oldArtist = artistDAO.GetArtist(context, oldArtistId);

                ////Remove music from Genre's music collection
                //oldArtist.Musics.Remove(context.Musics.Find(id));


                #region - Working with DAOs to add object and add to collections

                musicDAO.EditJob(context, employer, id);//Update existing music

                //genreDAO.AddMusicToCollection(context, genreDAO.GetGenre(context, musicGenreArtist.Genre), music); //Adding music to new genre
                //artistDAO.AddMusicToCollection(context, music, artistDAO.GetArtist(context, musicGenreArtist.Artist)); //Adding music to new genre


                context.SaveChanges();
                #endregion
            }

        }

        public Employer GetJob(int id)
        {
            using (var context = new JobContext())
            {
                return musicDAO.GetJob(context, id);
            }
        }

        public App_User GetUserData(string id)
        {
            using (var context = new JobContext())
            {
                return musicDAO.GetUserData(context, id);
            }
        }
        public void RemoveUser(string id)
        {
            using (var context = new JobContext())
            {
                musicDAO.RemoveUser(context, id);
            }
        }
        public IList<App_User> GetUsers()
        {
            using (var context = new JobContext())
            {
                return musicDAO.GetUsers(context);
            }
        }
    }
}
