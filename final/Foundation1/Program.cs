using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> youtubeVideos = new List<Video>();
        Video video1 = new Video("Crazy Cats", "CatLady", 123);
        Video video2 = new Video("Robot Running", "CoolDude", 96);
        Video video3 = new Video("UFO Footage", "Jeremy51", 489);


        youtubeVideos.Add(video1);
        youtubeVideos.Add(video2);
        youtubeVideos.Add(video3);
        foreach (Video video in youtubeVideos)
        {

            video.Write("Doug", "I love your video");
            video.Write("Susan", "Nice Work!");
            video.Write("Laurie", "How'd you record that?\n");

            video.DisplayVideo();
        }

    }
}
//Once you have the classes in place, write a program that creates 3-4 videos, sets the appropriate values, and for each one add a list of 3-4 comments (with the commenter's name and text). Put each of these videos in a list.

//Then, have your program iterate through the list of videos and for each one, display the title, author, length, number of comments (from the method) and then list out all of the comments for that video. Repeat this display for each video in the list.dfgsd