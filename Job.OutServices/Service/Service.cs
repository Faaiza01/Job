using Job.Data.Models.Domain;
using Job.OutServices.IService;
using Job.OutServices.Models;
using Job.Services.IService;
using Job.Services.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.OutServices.Service
{
    public class Service : IContract
    {
        private IMusicService musicService;
        private IGenreService genreService;
        public Service()
        {
            musicService = new MusicService();
            genreService = new GenreService();
        }


        //Record[] GetRecords(IList<Music> musicList)
        //{
        //    Record[] list = new Record[musicList.Count];
        //    for (int i = 0; i < list.Length; i++)
        //    {
        //        list[i] = new Record 
        //        { 
        //            ID = musicList[i].ID, 
        //            Price = musicList[i].Price, 
        //            Title=musicList[i].Title, 
        //            Released=musicList[i].DateReleased.ToString() 
        //        };
        //    }
        //    return list;
        //}
        ////public Record[] GetRecords()
        ////{
        ////    IList<Genre> genres = genreService.GetGenres(); //Preparing a genre list
        ////    IList<Music> musicList = new List<Music>(); 

        ////    Record[] records = new Record[] { }; //Declaring a record array to store all the musics

        ////    foreach (var item in genres) //Iterating through each genre
        ////    {
        ////        for (int i = 0; i < item.Musics.ToList().Count; i++)
        ////        {
        ////            musicList.Add(item.Musics.ToList()[i]); //adding the music to music list
        ////        }                
        ////    }
        ////    records = GetRecords(musicList); //Using the Get Records (Music List method) to return a record array
        ////    return records; //Returning the record array
        ////}

        ////public Category[] GetMusicCategories()
        ////{
        ////    IList<Genre> genreList = genreService.GetGenres().ToList();
        ////    Category[] array = new Category[genreList.Count];
        ////    for (int i = 0; i < array.Length; i++)
        ////    {
        ////        array[i] = new Category 
        ////        { 
        ////            ID = genreList[i].ID, 
        ////            Name = genreList[i].Name, 
        ////            Records = GetRecords(genreList[i].Musics.ToList()) 
        ////        };
        ////    }
        ////    return array;
        ////}

        //public Category[] GetMusicCategoriesEmpty()
        //{
        //    return new Category[0];
        //}


        ////public Record GetRecord(int id)
        ////{
        ////    if (musicService.GetMusic(id) == null)
        ////    {
        ////        return null;
        ////    }
        ////    else
        ////    {
        ////        Music music = musicService.GetMusic(id);
        ////        return new Record(music.ID, music.Title, music.Price, music.DateReleased.ToString());
        ////    }
        ////}

        //public bool DeleteRecord(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public int PostRecord(Record record)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool PutRecord(Record record)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
