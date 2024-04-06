using System;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("How to Program in C#", "ProgrammingwithUmah", 900);
        video1.AddComment(new Comment("Janell Monae", "Great video, I love it!"));
        video1.AddComment(new Comment("John Wick", "Very Useful."));
        video1.AddComment(new Comment("tony Montana", "Not Useful i got a better tutor."));

        Video video2 = new Video("Understanding Data Structures", "ComputerScience", 1200);
        video2.AddComment(new Comment("Miley Bobbey", "This was a bit complex but useful."));
        video2.AddComment(new Comment("Chris Brown", "Thanks for the clear explanation!"));
        video2.AddComment(new Comment("Jeremy Lynch", "Thanks but it was not so clear"));

        Video video3 = new Video("The Art of Writing", "English101", 1500);
        video3.AddComment(new Comment("James Brown", "This took forever to write."));
        video3.AddComment(new Comment("Tyler Perry", "Couldnt have done it without you!"));
        video3.AddComment(new Comment("Tom Holland", "It wasnt all bad but thanks anyway"));

        Video video4 = new Video("The complexity of Biology", "HumanScience", 600);
        video4.AddComment(new Comment("Daniel Grey", "I almost lost my thumb disecting."));
        video4.AddComment(new Comment("Umah Godday", "Thanks for the practical"));
        video4.AddComment(new Comment("Kendrick Lamar", "I could do better anyways"));

        Video video5 = new Video("Introduction to Music", "Music&Art", 1100);
        video5.AddComment(new Comment("Derek Philip", "Wow it took me 3 days to master."));
        video5.AddComment(new Comment("john johnson", "Thanks for the beautiful performance"));
        video5.AddComment(new Comment("Dwayn johnson", "Poor taste in music"));

        // Add videos to a list
        List<Video> videos = new List<Video> { video1, video2, video3, video4, video5 };

        // Display video information
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}, Author: {video.Author}, Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Comments ({video.GetNumberOfComments()}):");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}
