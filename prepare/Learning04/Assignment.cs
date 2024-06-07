public class Assignment
{
    private string _studentName;
    private string _studentTopic;

    public Assignment(string _name, string _topic)
    {
        _studentName = _name;
        _studentTopic = _topic;
    }

    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _studentTopic;
    }

    public string GetSummary()
    {
        return _studentName + " - " + _studentTopic;
    }
}