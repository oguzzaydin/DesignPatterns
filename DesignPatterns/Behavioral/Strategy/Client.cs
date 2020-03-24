namespace DesignPatterns.Behavioral.Strategy
{
    public class Client
    {
        public Client()
        {
            var users = new SortedList();

            users.Add("Samual");
            users.Add("Jimmy");
            users.Add("Sandra");
            users.Add("Vivek");
            users.Add("Anna");

            users.SetSortStrategy(new QuickSort());
            users.Sort();

            users.SetSortStrategy(new BubbleSort());
            users.Sort();

            users.SetSortStrategy(new MergeSort());
            users.Sort();
        }
    }
}