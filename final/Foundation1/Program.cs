using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        //1. Yesterday comments
        List<Comment> comments1 = new List<Comment>();
        comments1.Add(new Comment("Andrea", "Honestly guys, there are some songs that shouldn't have a dislike button."));
        comments1.Add(new Comment("Cristian Maldonaro", "Seems like four men on Earth got together to write the most beautiful songs that ever existed. They nail it every time."));
        comments1.Add(new Comment("Sean Rooney", "The fact that this song is 50 years old and where still listening to it....yeah point already made."));
        comments1.Add(new Comment("Elizabeth Raymundo", "For me, “Yesterday” is the greatest song of all time. The melody borned of the deepest of Paul McCarney's heart has conquisted many hearts."));

        //2. Let it Be comments
        List<Comment> comments2 = new List<Comment>();
        comments2.Add(new Comment("Kelveto", "The Beatles truly are one of the greatest bands to ever exist."));
        comments2.Add(new Comment("Mariano Statello", "I think that when a song is so well done it becomes timeless like classical music, many years will pass and these beautiful melodies covered hundreds of times will still be valid."));
        comments2.Add(new Comment("Sergio Payan", "To everyone around the world enduring these times of quarantine, as we battle through panic, fear, death and illness; There will be an answer. Let it be."));

        //3. Hey Jude
        List<Comment> comments3 = new List<Comment>();
        comments3.Add(new Comment("Cineraria", "Perfect song to hear when self-doubt and sadness hits me."));
        comments3.Add(new Comment("Bob Setter", "You have found her, now go and get her” always cuts me so deep. Now more than ever, since I think I finally found the one."));
        comments3.Add(new Comment("Benjamin Clasper", "This song is a beautiful masterpiece."));

        //4. In my Life
        List<Comment> comments4 = new List<Comment>();
        comments4.Add(new Comment("Jay Willey", "You don’t write a song like this at 25, unless God knows you’ll die at 40. RIP Mr. Lennon."));
        comments4.Add(new Comment("Paul Schipper", "It's hard to listen to this song without getting a tear in your eye."));
        comments4.Add(new Comment("James Quebral", "The greatest band of all time."));
        comments4.Add(new Comment("Ana Faccinetto", "This song was a gift to me in the day my first son was born, and I will always trasure it."));

        videos.Add(new Video("Yesterday", "The Beatles", 125, comments1));
        videos.Add(new Video("Let it Be", "The Beatles", 243, comments2));
        videos.Add(new Video("Hey Jude", "The Beatles", 425, comments3));
        videos.Add(new Video("In My Life", "The Beatles", 146, comments4));

        Console.Clear();

        foreach (Video item in videos)
        {
            Console.WriteLine($"title: {item.GetTitle()} - author: {item.GetAuthor()} - lenght: {item.GetLenght()} secs\r\n");
            Console.WriteLine($"Number of comments: {item.GetNumOfComments()}\r\n");

            foreach (Comment comment in item.GetCommentsList())
            {
                Console.WriteLine($"'{comment.GetText()}' by {comment.GetCommentAuthor()}\r\n");
            }
            
            Console.WriteLine("*************************************************************************************************");
        }

    }
}