using System;
using System.Reflection;
/**
   * 
   * File Name: SongList.cs
   * Project Name: Project 2 - PlaylistManager++
   * Solution Name: Project 2 - PlaylistManager++
   * 
   * Authors name and email: Avery Wood, woodaj3@etsu.edu
   * Course-Section: CSCI 1260
   * Creation date: Feburary 19th, 2024
   * Modified Date: Febuary 29th, 2024
   * 
   */
public abstract class SongList
    {
        /// <summary>
        /// Variables for the songlist that are used throughout the program
        /// </summary>
        public List<Song> songs { get; set; }

        public double totalRuntime { get; protected set; }

        public string Title { get; set; }

        /// <summary>
        /// Fully Parameritized constructor
        /// </summary>
        /// <param name="Title">Title of the songlist</param>
        public SongList(string Title)
        {
            Title = Title;
            songs = new List<Song>();
            totalRuntime = 0;
        }

        /// <summary>
        /// Method to remove a song from the playlist
        /// and decrease the overall run time
        /// </summary>
        /// <param name="song">Song variable that is being removed</param>
        public void RemoveSong(Song song)
        {
            songs.Remove(song);
            totalRuntime -= song.Duration;
        }

        /// <summary>
        /// Method to add a song to the playlist
        /// and increase the overall runtime
        /// </summary>
        /// <param name="song">Song variable that is being added</param>
        public void AddSong(Song song)
        {
            this.songs.Add(song);
            totalRuntime += song.Duration;
        }

        /// <summary>
        /// Method to retrieve a certain song by its index
        /// </summary>
        /// <param name="songIndex">The index of the song that the user wishes to recieve</param>
        /// <returns>The song that the user wants to see</returns>
        public Song GetSong(int songIndex)
        {
            return songs[songIndex];
        }
    }