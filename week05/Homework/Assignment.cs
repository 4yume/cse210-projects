using System;

public class Assignment
{
    protected string _studentName;
    protected string _topic;

    //create a constoructor
    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }

    //GetSummary method to return the student's name and topic
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}