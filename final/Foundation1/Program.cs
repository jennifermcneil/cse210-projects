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
        video1.Write("Doug", "I love your video");
        video1.Write("Susan", "Nice Work!");
        video1.Write("Laurie", "How'd you record that?\n");
        video2.Write("Joy", "Sweet,video");
        video2.Write("Jeremy", "Rad Robots");
        video2.Write("Jonathan", "How'd you get that to work?\n");
        video3.Write("Jay", "Nice work on your video");
        video3.Write("Karen", "Crazy");
        video3.Write("Kris", "Where is this filmed?\n");
        foreach (Video video in youtubeVideos)
        {
            video.DisplayVideo();
        }

    }
}
//Once you have the classes in place, write a program that creates 3-4 videos, sets the appropriate values, and for each one add a list of 3-4 comments (with the commenter's name and text). Put each of these videos in a list.

//Then, have your program iterate through the list of videos and for each one, display the title, author, length, number of comments (from the method) and then list out all of the comments for that video. Repeat this display for each video in the list.dfgsd