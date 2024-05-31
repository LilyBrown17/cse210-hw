using System;

class Reference
{
    private string _reference;
    public Reference(string _book, string _chapter, string _verse)
    {
        _reference = $"{_book} {_chapter}:{_verse}";
    }

    public Reference(string _book, string _chapter, string _verse1, string _verse2)
    {
        _reference = $"{_book} {_chapter}:{_verse1}-{_verse2}";
    }

    public string ReturnReference()
    {
        return _reference;
    }
}