// This file is part of the CSE210 project for Week 04.

class Video
// This class represents a YouTube video.
{
    public string Title { get; }
    public string Author { get; }
    public int Length { get; }
    private List<Comment> Comments { get; }
// It includes properties for the title, author, length (in seconds), and a list of comments.

    public Video(string title, string author, int length)
// Constructor to initialize the video with its title, author, and length.
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }
// The Comments property is initialized as an empty list to hold comments related to the video.
// The class provides methods to add comments, get the number of comments, and display video information.
    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }
    // This method returns the number of comments on the video.
    // It iterates through the Comments list and returns its count.

    public void DisplayInfo()
    // This method displays the video information, including the title, author, length, and comments.
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Length: {Length} sec");
        Console.WriteLine($"Number of comments: {GetNumberOfComments()}");
        foreach (var comment in Comments)
        {
            Console.WriteLine($" - {comment.CommenterName}: {comment.CommentText}");
        }
        Console.WriteLine();
    }
}

