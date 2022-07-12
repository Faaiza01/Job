using Job.Data;
using Job.Data.DAO;
using Job.Data.IDAO;
using Job.Data.Models.Domain;
using Job.Data.Repository;
using Job.Services.IService;
using Job.Services.Models;
using System.Collections.Generic;
using System.Linq;

namespace Job.Services.Service
{
    public class GenreService : IGenreService
    {
        private IGenreDAO genreDAO;

        public GenreService()
        {
            genreDAO = new GenreDAO();
        }
        public IList<Employer> GetGenres()
        {
            using (var context = new JobContext())
            {
                return genreDAO.GetGenres(context);
            }
        }

        public IList<AppliedJobsList> GetAppliedJobs(string UserId)
        {
            using (var context = new JobContext())
            {
                return genreDAO.GetAppliedJobs(context, UserId);
            }
        }

        public IList<AppliedJobsList> SearchByJobTitle(string text, string userId)
        {
            using (var context = new JobContext())
            {
                return genreDAO.SearchByJobTitle(context, text, userId);
                //musicDAO.DeleteMusic(context, music);
            }
        }
        public IList<AppliedJobsList> GetUserAppliedJobs(string UserId)
        {
            using (var context = new JobContext())
            {
                return genreDAO.GetUserAppliedJobs(context, UserId);
            }
        }

        public IList<SavedJobList> GetUserSavedJobs(string UserId)
        {
            using (var context = new JobContext())
            {
                return genreDAO.GetUserSavedJobs(context, UserId);
            }
        }
        public IList<ListOfApplicantsDto> GetListOfApplicants()
        {
            using (var context = new JobContext())
            {
                return genreDAO.GetListOfApplicants(context);
            }
        }


        public string GetResumePath(string identityId)
        {
            using (var context = new JobContext())
            {
                return genreDAO.GetResumePath(context, identityId);
            }
        }


        public App_User GetLoggedInUserData(string IdentityId)
        {
            using (var context = new JobContext())
            {
                return genreDAO.GetLoggedInUserData(context, IdentityId);
            }
        }

        public void EditProfile(EditProfileDto editProfileDto, string userId)
        {
            using (var context = new JobContext())
            {
                App_User app_User = new App_User();

                app_User.FirstName = editProfileDto.FirstName;
                app_User.LastName = editProfileDto.LastName;
                app_User.Resume = editProfileDto.Resume;
                genreDAO.EditProfile(context, app_User, userId);//Update existing music
                context.SaveChanges();
            }

            //public IList<Music> GetMusics(int id)
            //{
            //    using (var context = new JobContext())
            //    {
            //        return genreDAO.GetMusics(context, id);
            //        //return GetGenre(id).Musics.ToList();
            //    }
            //}
        }
    }
}
