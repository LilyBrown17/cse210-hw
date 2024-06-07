public class WritingAssignment : Assignment
{
    private string _writingTitle;

    public WritingAssignment(string _name, string _topic, string _title)
        : base(_name, _topic)
    {
        _writingTitle = _title;
    }

    public string GetWritingInformation()
    {
        string _name = GetStudentName();

        return $"{_writingTitle} by {_name}";
    }
}