
using Job.Data.Models.Domain;
using Job.Services.IService;
using Job.Services.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Job.Controllers
{
    public class Helper
    {
        private IGenreService genreService;
        private IArtistService artistService;
        
        public Helper()
        {
            genreService = new GenreService();
            artistService = new ArtistService();
        }

        //public List<SelectListItem> GetGenreDropDownByMusicId(int musicId)
        //{
        //    List<SelectListItem> genreList = new List<SelectListItem>();
        //    IList<Genre> genres = genreService.GetGenres();

        //    int genreId = GetGenreByMusicID(musicId);

        //    foreach (var item in genres)
        //    {
        //        genreList.Add
        //            (
        //            new SelectListItem()
        //            {
        //                Text = item.Name,
        //                Value = item.ID.ToString(),
        //                Selected = (item.ID == genreId ? true : false)
        //            }
        //            );
        //    }
        //    return genreList;
        //}

        //public List<SelectListItem> GetArtistDropDownByMusicId(int musicId)
        //{
        //    List<SelectListItem> artistList = new List<SelectListItem>();
        //    IList<Artist> artists = artistService.GetArtists();

        //    int artistId = GetArtistByMusicID(musicId);

        //    foreach (var item in artists)
        //    {
        //        artistList.Add
        //            (new SelectListItem()
        //            {
        //                Text = item.Name,
        //                Value = item.ID.ToString(),
        //                Selected = item.ID == artistId ? true : false
        //            });
        //    }
        //    return artistList;
        //}

        //public List<SelectListItem> GetGenreDropDown()
        //{
        //    List<SelectListItem> genreList = new List<SelectListItem>();
        //    IList<Genre> genres = genreService.GetGenres();
        //    foreach (var item in genres)
        //    {
        //        genreList.Add
        //            (
        //            new SelectListItem()
        //            {
        //                Text = item.Name,
        //                Value = item.ID.ToString(),
        //                Selected = (item.Name == (genres[0].Name)? true : false)
        //            }
        //            );
        //    }
        //    return genreList;
        //}

        //public List<SelectListItem> GetArtistDropDown()
        //{
        //    List<SelectListItem> artistList = new List<SelectListItem>();
        //    IList<Artist> artists = artistService.GetArtists();
        //    foreach (var item in artists)
        //    {
        //        artistList.Add
        //            (new SelectListItem()
        //            {
        //                Text = item.Name,
        //                Value = item.ID.ToString(),
        //                Selected = item.Name == artists[0].Name ? true : false
        //            });
        //    }
        //    return artistList;
        //}

        //public int GetGenreByMusicID(int musicId)
        //{
        //    int genreID = 0;
        //    IList<Genre> genres = genreService.GetGenres();

        //    foreach (var genre in genres)
        //    {
        //        IList<Music> musics = genreService.GetMusics(genre.ID);
                
        //        foreach (var music in musics)
        //        {
        //            if (music.ID == musicId)
        //            {
        //                genreID = genre.ID;
        //            }
        //        }
        //    }
        //    return genreID;
        //}

        //public int GetArtistByMusicID(int musicId)
        //{
        //    int artistID = 0;
        //    IList<Artist> artists = artistService.GetArtists();

        //    foreach (var artist in artists)
        //    {
        //        IList<Music> musics = artistService.GetMusics(artist.ID);

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

        public IEnumerable<SelectListItem> GetSelectList<T>(IList<T> list,
            Func<T, object> funcToGetValue,
            Func<T, object> funcToGetText)
        {
            return list.Select(x => new SelectListItem
            {
                Value = funcToGetValue(x).ToString(),
                Text = funcToGetText(x).ToString()
            });
        }
    }
}