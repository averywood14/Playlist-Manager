using System;
/**
   * 
   * File Name: Song.cs
   * Project Name: Project 2 - PlaylistManager++
   * Solution Name: Project 2 - PlaylistManager++
   * 
   * Authors name and email: Avery Wood, woodaj3@etsu.edu
   * Course-Section: CSCI 1260
   * Creation date: Feburary 19th, 2024
   * Modified Date: Febuary 29th, 2024
   * 
   */
public class Song
	{
    /// <summary>
    /// The variables that are related to each song 
    /// </summary>
        public string SongId { get; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public double Duration { get; set; } //make a double to do minutes and seconds 
        public Genre? Genre { get; set; }
        public Album Album { get; set; }

        /// <summary>
        /// Fully parameritized constructor 
        /// </summary>
        /// <param name="title">The title of song</param>
        /// <param name="artist">The artist of the song</param>
        /// <param name="duration">The duration of the song</param>
        /// <param name="genre">Song genre</param>
        /// <param name="album">Song album</param>
        public Song(string title, string artist, int duration, Genre? genre, Album album)
        {
            SongId = System.Guid.NewGuid().ToString();
            Title = title;
            Artist = artist;
            Duration = duration;
            Genre = genre;
            Album = album;
        }

        /// <summary>
        /// To string method to display the information accordingly 
        /// </summary>
        /// <returns>Returns Song details </returns>
        public override string ToString()
        {
            return ($"Title: {Title}\n Artist: {Artist}\n Duration: {Duration} seconds\n Genre: {Genre}\n Album:\n {Album}");
        }
    }

