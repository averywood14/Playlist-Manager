using System;
using System.Diagnostics;
/**
   * 
   * File Name: PlaylistService.cs
   * Project Name: Project 2 - PlaylistManager++
   * Solution Name: Project 2 - PlaylistManager++
   * 
   * Authors name and email: Avery Wood, woodaj3@etsu.edu
   * Course-Section: CSCI 1260
   * Creation date: Feburary 19th, 2024
   * Modified Date: Febuary 29th, 2024
   * 
   */
namespace Project2_PlaylistManager__.Data
{
    /// <summary>
    /// A playlist service that implements the interface 
    /// </summary>
	public class PlaylistService : IPlaylistService
	{
        //Creating a new album and a new playlist
        private List<Album> albums = new List<Album>();
        private Playlist playlist = new Playlist("");

        public PlaylistService()
        {

        }

        /// <summary>
        /// Method that checks of the title the user
        /// enters for their playlist is valid 
        /// </summary>
        /// <returns>The playlist title</returns>
        public Boolean hasValidTitle()
        {
            return !String.IsNullOrEmpty(playlist.Title);
        }

        /// <summary>
        /// Returns a list of albums that the user has entered 
        /// </summary>
        /// <returns>The list of albums</returns>
        public List<Album> GetAlbums()
        {
            return albums;
        }

        /// <summary>
        /// Returns everything in the playlist 
        /// </summary>
        /// <returns>The entire playlist</returns>
        public Playlist GetPlaylist()
        {
            return playlist;
        }

        /// <summary>
        /// Adds and album to the list of albums 
        /// </summary>
        /// <param name="album">The album that the user is adding to the list</param>
        public void AddAlbum(Album album)
        {
            albums.Add(album);
        }

        /// <summary>
        /// Method that adds a song to the playlist
        /// </summary>
        /// <param name="song">The song that the user is adding to the list</param>
        public void AddSong(Song song)
        {
            playlist.AddSong(song);
        }

        /// <summary>
        /// Method that returns a song based on the SongId
        /// </summary>
        /// <param name="songId">The songId that the user wihes to see the information for </param>
        /// <returns>The song that the user wishes to see</returns>
        public Song GetSong(string songId)
        {
            return playlist.songs.Where(song => song.SongId == songId).First();
        }

        /// <summary>
        /// Method to remove a song from the playlist 
        /// </summary>
        /// <param name="song">The song that the user wishes to remove</param>
        public void RemoveSong(Song song)
        {
            playlist.RemoveSong(song);
        }

        /// <summary>
        /// Method to shuffle the playlist 
        /// </summary>
        public void Shuffle()
        {
            playlist.Shuffle();
        }

        /// <summary>
        /// Method that returns the album that matches the albumId
        /// </summary>
        /// <param name="albumId">The album that the user chose</param>
        /// <returns>The album information of the chosen album</returns>
        public Album GetAlbum(string albumId)
        {
            return albums.Where(album => album.AlbumId == albumId).First();
        }

        /// <summary>
        /// Method that returns the songs of an album that matches the albumId
        /// </summary>
        /// <param name="albumId">The album that the user chose</param>
        /// <returns>The lst of songs of the chosen album</returns>
        public List<Song> GetAlbumSongs(string albumId)
        {
            return playlist.songs.Where(song => song.Album.AlbumId == albumId).ToList();
        }
    }
}

