namespace HW12_delegats_events
{
    class Program
    {
        static void Main(string[] args)
        {
            NewsProvider newsProvider = new NewsProvider();


            Subscriber subscriber1 = new Subscriber("Ksenia", 21);
            newsProvider.NewSubscription(NewsProvider.News.Sport, subscriber1.OnMessage);
            newsProvider.NewNews(NewsProvider.News.Sport, "что-то про спорт");
        }
    }
}
