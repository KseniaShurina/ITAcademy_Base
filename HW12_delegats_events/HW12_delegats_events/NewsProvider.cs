namespace HW12_delegats_events
{
    public class NewsProvider
    {
        public enum News
        {
            Sport,
            Weather,
            Humor,
            Incident,
            AllNews,
        }
        public delegate void MySubscription(News type, string message);

        //  создаём события типа делегата
        private event MySubscription SubscriptionSport;
        private event MySubscription SubscriptionWeather;
        private event MySubscription SubscriptionHumor;
        private event MySubscription SubscriptionIncident;
        private event MySubscription SubscriptionAllNews;

        public void NewSubscription(News type, MySubscription mySubscription)
        {
            switch (type)
            {
                case News.Sport:
                    SubscriptionSport += mySubscription; //тут мы подписываемя на новость и добавляем в делегат ссылку на метод
                    break;
                case News.Weather:
                    SubscriptionWeather += mySubscription;
                    break;
                case News.Humor:
                    SubscriptionHumor += mySubscription;
                    break;
                case News.Incident:
                    SubscriptionIncident += mySubscription;
                    break;
                case News.AllNews:
                    SubscriptionAllNews += mySubscription;
                    break;
            }
        }

        public void NewNews(News type, string news)
        { // метод, который генерирует новость, на кот подписался подписчик
            switch (type)
            {
                case News.Sport:
                    SubscriptionSport?.Invoke(type, news);
                    break;
                case News.Weather:
                    SubscriptionWeather?.Invoke(type, news);
                    break;
                case News.Humor:
                    SubscriptionHumor?.Invoke(type, news);
                    break;
                case News.Incident:
                    SubscriptionIncident?.Invoke(type, news);
                    break;
                case News.AllNews:
                    SubscriptionAllNews?.Invoke(type, news);
                    break;
            }
        }
    }
}
