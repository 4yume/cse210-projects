using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        Video video1 = new Video("MainCraft", "Wine", 400);
        Video video2 = new Video("BioHarzard", "Cupcon", 500);
        Video video3 = new Video("Dragon Quest", "Ninten", 300);

        Comment comment1 = new Comment("Haru", "This is amazing");
        Comment comment2 = new Comment("John", "Very scary");
        Comment comment3 = new Comment("Bob", "The story is fantastic");
        Comment comment4 = new Comment("Mike", "I love this game!");
        Comment comment5 = new Comment("Haru", "I wana play too!");
        Comment comment6 = new Comment("Haru", "It is interesting");

        video1.AddComment(comment1);
        video1.AddComment(comment4);
        video1.AddComment(comment5);

        video2.AddComment(comment2);
        video2.AddComment(comment6);
        video2.AddComment(comment3);

        video3.AddComment(comment3);
        video3.AddComment(comment4);
        video3.AddComment(comment6);

        //add video to the list
        _videos.Add(video1);
        _videos.Add(video2);
        _videos.Add(video3);

        foreach (Video video in _videos)
        {
            video.Display();
        }
    }
}