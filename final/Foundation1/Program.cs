using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)

    {
        // Console.WriteLine("Hello Foundation1 World!");
        Console.WriteLine("Abstraction with Youtube videos program");
        Console.WriteLine();
        

        List<Videos> Vidlist = new List<Videos>();

        
        // create our first video instance        
        Videos video1 = new Videos("Encapsulation", "Offiong",  90000 );

        Comments comment1 = new Comments("mike pence","I really enjoyed the video");
        Comments comment2 = new Comments("vicky stone", "really educative, please make a video on abstraction also");
        Comments comment3 = new Comments("Godzill martian", "learned more than i ever did in college lectures, thaks man");
        Comments comment4 = new Comments("BigFoot567", "Nice video");

        video1.AddComent(comment1);
        video1.AddComent(comment2);
        video1.AddComent(comment3);
        video1.AddComent(comment4);

        Vidlist.Add(video1);

        // create our second video instance  
        Videos  video2 = new Videos("Making panckaes 101", "BigChef Mike", 972666);

        Comments comment5 = new Comments("Zhou fan","Great video");
        Comments comment6 = new Comments("Yang kai26336","thanks for the video");
        Comments comment7 = new Comments("narutoKun67","I really enjoyed the video");
        Comments comment8 = new Comments("Free Asta","I just made my pancake, thanks for the video");

        video2.AddComent(comment5);
        video2.AddComent(comment6);
        video2.AddComent(comment7);
        video2.AddComent(comment8);

        Vidlist.Add(video2);

        // create our third video instance 
        Videos video3 = new Videos("Abstraction", "Jason Blizzard", 66266000);

        Comments comment9 = new Comments("CodeAddict","I love the concepts, thanks for the video");
        Comments comment10 = new Comments("Freddy armsss","Nice thanks for the video");
        Comments comment11= new Comments("JerteeBoy456","nice video");
        Comments comment12= new Comments("Gift bassey","welldone, you explained better than my college professor");

        video3.AddComent(comment9);
        video3.AddComent(comment10);
        video3.AddComent(comment11);
        video3.AddComent(comment12);

        Vidlist.Add(video3);

        // create our fourth video instance 
        Videos video4 = new Videos("Dental hygiene tips 101", "Dr Toothy", 67800000);

        Comments commentx = new Comments("maris jane","Wow, thanks for the video");
        Comments commentq = new Comments("henry chad","Fnally getting closer to a better dental hygiene");
        Comments commentw= new Comments("Koksy lala","nice video doc");
        Comments commente= new Comments("Jih ah","welldone, you explained better than my college professor");

        video4.AddComent(commentx);
        video4.AddComent(commentq);
        video4.AddComent(commentw);
        video4.AddComent(commente);

        Vidlist.Add(video4);


       
        foreach( Videos ggs in Vidlist)
        {
          
            Console.WriteLine($"Title: {ggs._title} \nAuthor: {ggs._author}  \nLength: {ggs._length} \nNumber of Comments: {ggs.CommentNo()} \n--comment section--");
            // Console.WriteLine($"Comments: \n{ggs._commentList}");
            // Console.Write(string.Join(System.Environment.NewLine, ggs._commentList));
            
           
            List<Comments> dhhd = ggs._commentList;
            foreach ( Comments com in dhhd )
            {
            
               Console.WriteLine(com.DisplayComment());
                
            }

            Console.WriteLine();  // Add a line break between videos

        }







        








   




    
      



    }
}