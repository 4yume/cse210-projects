using System;

public class WritingAssignment : Assignment
{
    // add member variables
    private string _title;

    //set up the constructor
    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }

    //add the GetWritingInformation method
    public string GetWritingInformation()
    {
        return $"{_title} by {_studentName}";
    }
}