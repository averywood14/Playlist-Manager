using System;
/**
   * 
   * File Name: IPlaylistService.cs
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
    /// Interface that includes everything the playlist should be able to do 
    /// </summary>
    public interface IPlaylistService
    {
        List<Album> GetAlbums();
        Playlist GetPlaylist();

        Boolean hasValidTitle();
        void AddAlbum(Album album);
        void AddSong(Song song);
        void RemoveSong(Song song);
        Song GetSong(string songId);
        Album GetAlbum(string albumId);
        List<Song> GetAlbumSongs(string albumId);
        void Shuffle();
    }
}

