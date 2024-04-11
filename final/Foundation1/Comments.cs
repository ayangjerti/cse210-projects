using System;

public class Comments 
{
    public string _commenterName;
    public string _commentText;

    // public Comments(string commenter, string commenttext){}

    public Comments(string commenter, string commenttext)
    {
        _commenterName = commenter;
        _commentText = commenttext;
    }



    public string GetCommenter()
    {
        return _commenterName;
    }

    public string GetCommentText()
    {
        return _commentText;
    }

    public string DisplayComment()
    {
        return $"{_commenterName} : {_commentText} ";
    }

    

















}