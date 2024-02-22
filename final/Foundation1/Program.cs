using System;

class Program
{
    static void Main(string[] args)
    {
         // Create videos
        Video video1 = new Video("Introduction to Programming", "John Doe", 300);
        Video video2 = new Video("Data Structures Explained", "Jane Smith", 450);
        Video video3 = new Video("C# Tutorial", "Bob Johnson", 600);

        // Add comments to videos
        video1.AddComment("Alice", "Great video! Very informative.");
        video1.AddComment("Charlie", "I learned a lot, thanks!");
        video1.AddComment("David", "Goldmine! Looking forward to more content.");

        video2.AddComment("Dave", "Nice explanation of data structures.");
        video2.AddComment("Eva", "Could you make a video on algorithms too?");
        video2.AddComment("Fiona", "Your teaching style is engaging.");

        video3.AddComment("Frank", "Helpful tutorial for beginners.");
        video3.AddComment("Grace", "I like your teaching style.");
        video3.AddComment("Henry", "Can you cover advanced topics as well?");

        // Create a list of videos
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display information for each video
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");
            foreach (var comment in video._comments)
            {
                Console.WriteLine($"{comment._commenterName}: {comment._commentText}");
            }

            Console.WriteLine();
        }
    }
}
    