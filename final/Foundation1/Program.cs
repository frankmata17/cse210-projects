using System;

class Program
{
   static void Main()
    {
        // Create videos
        List<Video> videos = new List<Video>
        {
            new Video("Parkour in the Park", "Steve O", 300),
            new Video("Football Tricks 2", "Ronaldinho", 480),
            new Video("Cooking Lessons", "Selena", 600)
        };

        // Add comments to videos
        videos[0].AddComment("Daniel", "Great video!");
        videos[0].AddComment("Eric", "Awesome content!");
        videos[0].AddComment("Stacey", "Looks Dangerous!");

        videos[1].AddComment("Sarai", "I learned a lot from this.");
        videos[1].AddComment("Veronica", "Keep it up!");
        videos[1].AddComment("Ana", "Amazing!");

        videos[2].AddComment("Aimee", "Interesting topic.");
        videos[2].AddComment("Sam", "Looking forward to more.");
        videos[2].AddComment("Isaac", "Delicious. I have to try it now.");

        // Display video information
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"- {comment.UserName}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}