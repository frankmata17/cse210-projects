class Video
{
    public string Title { get; }
    public string Author { get; }
    public int Length { get; }
    public List<Comment> Comments { get; }

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    public void AddComment(string userName, string text)
    {
        Comments.Add(new Comment(userName, text));
    }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }
}