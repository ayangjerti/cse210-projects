using System;
using System.Reflection.Emit;
using System.Collections.Generic;


public class Videos{
    public string _title; // 
    public string _author;
    public int _length;

    public List<Comments> _commentList = new List<Comments>();

    public void AddComent(Comments newComment)
    {
        _commentList.Add(newComment);
    }



// ConstructorBuilder for videos object
    public Videos(string title, string author, int length){
        _title = title;
        _author = author;
        _length = length;
    }

    public int CommentNo()
    {
        int itemCount = GetNumberOfItems(_commentList);

       return itemCount;
    }

    static int GetNumberOfItems<T>(List<T> list)
    {
        // You can use the Count property or the Count() method
        // return list.Count;
        return list.Count();
    }
}