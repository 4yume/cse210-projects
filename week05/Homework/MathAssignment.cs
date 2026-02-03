using System;

public class MathAssignment : Assignment
{
    //attributes as private member variable
    private string _textbookSection;
    private string _problems;

    //constructor four parameters, call the base class constructor
    public MathAssignment(string name, string topic, string section, string problems) : base(name, topic)
    {
        _textbookSection = section;
        _problems = problems;
    }

    //add the GetHomeworkList method
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}