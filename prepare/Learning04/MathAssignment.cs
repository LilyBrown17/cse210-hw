public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _textbookProblems;

    public MathAssignment(string _name, string _topic, string _section, string _problems)
        : base(_name, _topic)
    {

        _textbookSection = _section;
        _textbookProblems = _problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_textbookProblems}";
    }
}