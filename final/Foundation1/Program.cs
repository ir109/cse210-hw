using System;
// Abstraction with Youtube videos
class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Title 1", "Ian", 123);
        video1.AddComment(new Comment("John", "comment"));
        video1.AddComment(new Comment("Bob", "test comment for video 1"));
        video1.AddComment(new Comment("Tim", "what"));

        Video video2 = new Video("Video #2", "Also Ian", 321);
        video2.AddComment(new Comment("abc", "def"));
        video2.AddComment(new Comment("ghi", "jklmn"));
        video2.AddComment(new Comment("opq", "rstuv"));
        video2.AddComment(new Comment("wx", "yz"));

        List<Video> videos = new List<Video> {video1, video2};

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title of video: {video.GetTitle()}");
            Console.WriteLine($"Author of video: {video.GetAuthor()}");
            Console.WriteLine($"Length of video: {video.GetLength()}");
            Console.WriteLine($"Number of comments on video: {video.GetNumberOfComments()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"* {comment.GetName()}: {comment.GetText()}");
            }
            Console.WriteLine();
        }
    }
}