using System;
using System.Runtime.CompilerServices;

class Video
{
    private string _title;
    private string _author;
    private string _length;

    private List<string> _comments = new List<string>();

    public Video(string title, string author, string length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(string name, string text)
    {
        Comment newComment = new Comment(name, text);
        _comments.Add(newComment.ReturnComment());
    }

    public string ReturnVideo()
    {
        string videoFull = $"{_title} \n {_author} \n Video Length: {_length} \n Comments: {_comments.Count()}";
        foreach (string comment in _comments)
        {
            videoFull = $"{videoFull} \n\n {comment}";
        }
        return videoFull;
    }

}