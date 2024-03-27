// See https://aka.ms/new-console-template for more information

using mod6_1302223136;

class Program
{
    public static void Main(string[] args)
    {
        SayaTubeUser user = new SayaTubeUser("Arvin");
        
        SayaTubeVideo video1 = new SayaTubeVideo("Review Film 1 oleh Arvin");
        SayaTubeVideo video2 = new SayaTubeVideo("Review Film 2 oleh Arvin");
        SayaTubeVideo video3 = new SayaTubeVideo("Review Film 3 oleh Arvin");
        SayaTubeVideo video4 = new SayaTubeVideo("Review Film 4 oleh Arvin");
        SayaTubeVideo video5 = new SayaTubeVideo("Review Film 5 oleh Arvin");
        SayaTubeVideo video6 = new SayaTubeVideo("Review Film 6 oleh Arvin");
        SayaTubeVideo video7 = new SayaTubeVideo("Review Film 7 oleh Arvin");
        SayaTubeVideo video8 = new SayaTubeVideo("Review Film 8 oleh Arvin");
        SayaTubeVideo video9 = new SayaTubeVideo("Review Film 9 oleh Arvin");
        SayaTubeVideo video10 = new SayaTubeVideo("Review Film 10 oleh Arvin");

        video1.PrintVideoDetails();
        video2.PrintVideoDetails();
        video3.PrintVideoDetails();
        video4.PrintVideoDetails();
        video5.PrintVideoDetails();
        video6.PrintVideoDetails();
        video7.PrintVideoDetails();
        video8.PrintVideoDetails();
        video9.PrintVideoDetails();
        video10.PrintVideoDetails();
        
        user.AddVideo(video1);
        user.AddVideo(video2);
        user.AddVideo(video3);
        user.AddVideo(video4);
        user.AddVideo(video5);
        user.AddVideo(video6);
        user.AddVideo(video7);
        user.AddVideo(video8);
        user.AddVideo(video9);
        user.AddVideo(video10);

        video1.IncreasePlayCount(60);
        video2.IncreasePlayCount(60);
        video3.IncreasePlayCount(60);
        video4.IncreasePlayCount(60);
        video5.IncreasePlayCount(60);
        video6.IncreasePlayCount(60);
        video7.IncreasePlayCount(60);
        video8.IncreasePlayCount(60);
        video9.IncreasePlayCount(60);
        video10.IncreasePlayCount(60);

        user.PrintAllVideoPlaycount();

        video1.PrintVideoDetails();
        video2.PrintVideoDetails();
        video3.PrintVideoDetails();
        video4.PrintVideoDetails();
        video5.PrintVideoDetails();
        video6.PrintVideoDetails();
        video7.PrintVideoDetails();
        video8.PrintVideoDetails();
        video9.PrintVideoDetails();
        video10.PrintVideoDetails();
            

    }
}