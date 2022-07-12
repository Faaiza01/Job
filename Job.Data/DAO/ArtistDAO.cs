using Job.Data.IDAO;
using Job.Data.Models.Domain;
using Job.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.Data.DAO
{
    public class ArtistDAO : IArtistDAO
    {
        //public void AddMusicToCollection(JobContext context, Music music, Artist artist)
        //{
        //    context.Artists.ToList().Find(b => b.ID == artist.ID).Musics.Add(music);
        //    context.SaveChanges();
        //}

        //public IList<Artist> GetArtists(JobContext context)
        //{
        //    return context.Artists.ToList();
        //}
        //public Artist GetArtist(JobContext context, int id)
        //{
        //    return context.Artists.ToList().Find(b => b.ID == id);
        //}

        //public IList<Music> GetMusics(JobContext context, int id)
        //{
        //   return context.Artists.ToList().Find(b => b.ID == id).Musics.ToList();
        //}

        //public int GetArtistByMusicID(JobContext context, int musicId)
        //{
        //    int artistID = 0;
        //    IList<Artist> artists = GetArtists(context);

        //    foreach (var artist in artists)
        //    {
        //        IList<Music> musics = GetMusics(context, artist.ID);

        //        foreach (var music in musics)
        //        {
        //            if (music.ID == musicId)
        //            {
        //                artistID = artist.ID;
        //            }
        //        }
        //    }
        //    return artistID;
        //}

    }
}
