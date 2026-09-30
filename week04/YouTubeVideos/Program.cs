using System;

class Program
{
    static void Main(string[] args)
    {

        Video video1 = new Video("Introduction to Artificial Intelligence", "Tech Ghana", 620);

        video1.AddComment(new Comment("Kwame", "This was a very helpful introduction."));

        video1.AddComment(new Comment("Ama","I learned a lot from this video."));

        video1.AddComment(new Comment("Daniel", "The explanation was easy to understand."));


        Video video2 = new Video("Learning C# Classes", "Code Academy", 845);

        video2.AddComment(new Comment("Michael", "The explanation of classes was excellent."));

        video2.AddComment(new Comment("Grace", "I finally understand class composition."));

        video2.AddComment(new Comment("David", "Looking forward to the next lesson."));


        Video video3 = new Video("How Computers Work", "Computer World", 530);

        video3.AddComment(new Comment("Sarah", "This helped me understand the basics."));

        video3.AddComment(new Comment("Joseph", "Very informative video."));

        video3.AddComment(new Comment("Emmanuel", "I enjoyed this explanation."));


        List<Video> videos = new List<Video>();

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);


        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}