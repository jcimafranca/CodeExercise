using System;
using System.Collections.Generic;

/*
A playlist is considered a repeating playlist if any of the songs contain a reference to a previous song in the playlist. 
Otherwise, the playlist will end with the last song which points to null.

Implement a function IsRepeatingPlaylist that, efficiently with respect to time used, returns true if a playlist is repeating or false if it is not.

For example, the following code prints "True" as both songs point to each other.

Song first = new Song("Hello");
Song second = new Song("Eye of the tiger");
    
first.NextSong = second;
second.NextSong = first;

Console.WriteLine(first.IsRepeatingPlaylist());

*/

public class Song
{    

    private string name;
    public Song NextSong { get; set; }

    public Song(string name)
    {
        this.name = name;
    }

    public bool IsRepeatingPlaylist()
    {
        bool result = false;
        if (this == null || NextSong == null) return false;       

        Song Current = this;
        Dictionary<int, Song> Queue = new Dictionary<int, Song>();
        Queue.Add(Current.GetHashCode(), Current);

        while (Current.NextSong != null)
        {
            if (!Queue.ContainsKey(Current.NextSong.GetHashCode()))
            {
                Queue.Add(Current.NextSong.GetHashCode(), Current.NextSong);
                Current = Current.NextSong;                
            }
            else
            {
                result = true;
                break;
            }
        }
        return result;
    }
    

    //public static void Main(string[] args)
    //{
    //    Song first = new Song("Hey Jude");
    //    Song second = new Song("Eye of the tiger");
    //    Song third = new Song("Billie Jean");
    //    Song fourth = new Song("2 Become 1");
    //    Song fifth = new Song("Material Girl");

    //    first.NextSong = second;
    //    second.NextSong = third;
    //    third.NextSong = fourth;
    //    fourth.NextSong = fifth;
    //    fifth.NextSong = first;

    //    Console.WriteLine(first.IsRepeatingPlaylist());
    //}
}