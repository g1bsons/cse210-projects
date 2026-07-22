using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Larry Lengeds", "Larry Wheels", 300);
        video1.AddComment(new Comment("Alice", "Great video!"));
        video1.AddComment(new Comment("Gregory", "I love what you did here!"));
        video1.AddComment(new Comment("Thomas", "I cant wait to see more of these videos"));


        Video video2 = new Video("Trials Two", "Sam Sampson", 658);
        video2.AddComment(new Comment("Larry", "This stinks dude, what the heck"));
        video2.AddComment(new Comment("Jenny", "I LOVED this so much"));
        video2.AddComment(new Comment("Lisa", "This is so dangeroues, why would you do this to yourself"));
        video2.AddComment(new Comment("Bobby", "sick dude"));

        Video video3 = new Video("How to make a cake", "Auntie Heather", 45);
        video3.AddComment(new Comment("Sheniquia", "Thank you for the help"));
        video3.AddComment(new Comment("Tommy", "This video is way way too short"));
        video3.AddComment(new Comment("Patty", "I like this!"));

        Video video4 = new Video("Star Wars, What Really Happened", "Q", 471);
        video4.AddComment(new Comment("Chih", "I would say this is wrong but then again after watching your video idk if youd even know what I was saying"));
        video4.AddComment(new Comment("Casey", "What about yoda???"));
        video4.AddComment(new Comment ("Erica", "you forgot about the role that the clones played"));
        video4.AddComment(new Comment("Joshua", "whered you get the music???"));


        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (Video v  in videos)
        {
            v.Display();
        }
    }
}