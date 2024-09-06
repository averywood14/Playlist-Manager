using System;
/**
   * 
   * File Name: Playlist.cs
   * Project Name: Project 2 - PlaylistManager++
   * Solution Name: Project 2 - PlaylistManager++
   * 
   * Authors name and email: Avery Wood, woodaj3@etsu.edu
   * Course-Section: CSCI 1260
   * Creation date: Feburary 19th, 2024
   * Modified Date: Febuary 29th, 2024
   * 
   */
public class Playlist : SongList
	{
		public Playlist(string title) : base (title) {}
        
        /// <summary>
        /// Method used to shuffle through the playlist of songs 
        /// </summary>
        public void Shuffle()
		{
			Random randy = new Random();
			int count = songs.Count;
			while(count > 1)
			{
				count--;
				int k = randy.Next(count + 1);
				Song value = songs[k];
				songs[k] = songs[count];
				songs[count] = value;
			}
		}

        /// <summary>
        /// Returns a formated string of the items in the playlist
        /// </summary>
        /// <returns>A formatted string of the items in the playlist</returns>
        public override string ToString()
        {
			string playlistDetails = $"PLaylist: {Title}\n";

            foreach (var item in base.songs.Select((song, index) => new { song, index }))
            {
                playlistDetails += $"{item.index + 1}. Song: {item.song}\n";
            }
            playlistDetails += $"\nTotal Runtime: {totalRuntime}\n";
            return playlistDetails;
        }

        /// <summary>
        /// Method used to display the details of a <see cref="Song"/>
        /// </summary>
        /// <param name="song">The song value to display the details of </param>
        /// <returns>The details of the song</returns>
        public string DisplaySongDetails (Song song) 
        {
            return ($"{song}");
        }
    }

