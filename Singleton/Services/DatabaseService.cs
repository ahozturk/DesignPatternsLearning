namespace Singleton.Services
{
    public class DatabaseService
    {
        public List<int> GetAll()
        {
            return new List<int>() { 1, 2, 3 };
        }
        public string GetById(int id)
        {
            return "Id: " + id;
        }


        DatabaseService()
        {
            Console.WriteLine($"{nameof(DatabaseService)} Created");
        }

        static DatabaseService ServiceInstance;

        public static DatabaseService Instance
        {
            get
            {
                if (ServiceInstance == null)
                    ServiceInstance = new DatabaseService();
                return ServiceInstance;
            }
        }

    }
}
