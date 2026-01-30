using System;
using System.Collections.Generic;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();


    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }


    public int GetNumberComment()
    {
        return _comments.Count;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    
    public void Display()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length}");
        Console.WriteLine($"Number of comments: {GetNumberComment()}");
        Console.WriteLine($"Comments: ");

        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"{comment._name}: {comment._text}");
        }
        Console.WriteLine();
    }
}