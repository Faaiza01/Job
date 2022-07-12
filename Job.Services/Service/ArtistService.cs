using Job.Data.DAO;
using Job.Data.IDAO;
using Job.Data.Models.Domain;
using Job.Data.Repository;
using Job.Services.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.Services.Service
{
    public class ArtistService : IArtistService
    {
        private IArtistDAO artistDAO;

        public ArtistService()
        {
            artistDAO = new ArtistDAO();
        }

        //public IList<Artist> GetArtists()
        //{
        //    using(var context = new JobContext())
        //    {
        //        return artistDAO.GetArtists(context);
        //    }
        //}

        //public IList<Music> GetMusics(int id)
        //{
        //    using (var context = new JobContext())
        //    {
        //       return artistDAO.GetMusics(context, id);
        //    }
        //}
    }
}
