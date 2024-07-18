using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("8588 Fairway Ct", "Seven Valleys", "PA", "75360");
        Lecture lecture = new Lecture("Helping Kids Learn Programming", "Listen to a presentation by Lily Brown about how to help children learn coding!", "6/13/2026", "2:00pm", address1, "Lily Brown", "150");

        Address address2 = new Address("S 2nd W", "Rexburg", "ID", "83440");
        Outdoor outdoor = new Outdoor("4th of July Ward BBQ", "Come over to celebrate the 4th of July with us, with some good old-fashioned Barbeque!", "7/4/2024", "5:00pm", address2, "Sunny");

        Address address3 = new Address("12503 Mount Belford Way", "Peyton", "CO", "80831");
        Reception reception = new Reception("Lily's Baptism", "Celebrate Lily's baptism with us!", "May 28, 2011", "1:00pm", address3, "lisaandkevin@gmail.com");

        Console.Write($"\n{lecture.ShortDetails()}\n\n\n{outdoor.ShortDetails()}\n\n\n{reception.ShortDetails()}\n\n\n\n{lecture.StandardDetails()}\n\n\n{outdoor.StandardDetails()}\n\n\n{reception.StandardDetails()}\n\n\n\n{lecture.FullDetails()}\n\n\n{outdoor.FullDetails()}\n\n\n{reception.FullDetails()}");
    }
}