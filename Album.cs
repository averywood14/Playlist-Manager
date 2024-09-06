using System;
using System.ComponentModel;
using System.Globalization;
/**
   * 
   * File Name: Album.cs
   * Project Name: Project 2 - PlaylistManager++
   * Solution Name: Project 2 - PlaylistManager++
   * 
   * Authors name and email: Avery Wood, woodaj3@etsu.edu
   * Course-Section: CSCI 1260
   * Creation date: Feburary 19th, 2024
   * Modified Date: Febuary 29th, 2024
   * 
   */
public class Album : SongList
{
    /// <summary>
    /// Variables involved in the album
    /// </summary>
    public string AlbumId { get; }
    public string Artist { get; set; }
    public List<string> BandMembers { get; set; }
    public DateTime? ReleaseDate { get; set; }
    public string AlbumArtURL { get; set; }

    /// <summary>
    /// Fully parameritized constructor
    /// </summary>
    /// <param name="title">Album title</param>
    /// <param name="artist">Album artist</param>
    /// <param name="releaseDate">Album release date </param>
    /// <param name="bandMembers">The band members on the album</param>
    public Album(string title, string artist, DateTime? releaseDate, List<string> bandMembers, string albumArtURL) : base(title)
    {
        AlbumId = System.Guid.NewGuid().ToString();
        Title = title;
        Artist = artist;
        ReleaseDate = releaseDate;
        BandMembers = bandMembers;
        AlbumArtURL = albumArtURL;

    }
    /// <summary>
    /// Returns an organized string of information 
    /// </summary>
    /// <returns>A formatted string</returns>
    public override string ToString()
    {
        return $"{base.Title};{Artist};{ReleaseDate?.ToString("yyyy-MM-dd")};{String.Join(", ", BandMembers.ToArray())};{AlbumArtURL}";
    }
}


