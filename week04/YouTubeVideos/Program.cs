using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        // Creating video objects
        Video video1 = new Video("AI Revolution", "Tech Guru", 120);
        Video video2 = new Video("Nature's Wonders", "Explorer", 180);
        Video video3 = new Video("Space Exploration", "NASA", 240);
        Video video4 = new Video("History of Programming", "CodeMaster", 300);

        // Adding comments
        video1.AddComment(new Comment("Alice", "Great content!"));
        video1.AddComment(new Comment("Bob", "Very insightful."));
        video1.AddComment(new Comment("Charlie", "Mind-blowing!"));

        video2.AddComment(new Comment("Dana", "Loved the visuals!"));
        video2.AddComment(new Comment("Eli", "This was informative."));
        video2.AddComment(new Comment("Frank", "Awesome documentary!"));

        video3.AddComment(new Comment("Grace", "Space is fascinating!"));
        video3.AddComment(new Comment("Hank", "NASA never disappoints."));
        video3.AddComment(new Comment("Ivy", "Great research."));

        video4.AddComment(new Comment("Jack", "Coding history is interesting."));
        video4.AddComment(new Comment("Kylie", "Very well explained!"));
        video4.AddComment(new Comment("Leo", "Informative and engaging."));

        // Storing videos in a list and displaying info
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        foreach (var video in videos)
        {
            video.DisplayInfo();
        }

    }
}