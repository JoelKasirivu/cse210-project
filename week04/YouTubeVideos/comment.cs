using System;
using System.Collections.Generic;
// This class represents a comment on a YouTube video.
// It includes the commenter's name and the text of the comment.

class Comment
{
    public string CommenterName { get; }
    public string CommentText { get; }
    // Constructor to initialize the comment with the commenter's name and the comment text.
    // The properties are read-only to ensure that they cannot be modified after creation.

    public Comment(string commenterName, string commentText)
    {
        CommenterName = commenterName;
        CommentText = commentText;
    }
}
