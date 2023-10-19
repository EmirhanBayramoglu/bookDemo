using bookDemo.Models;


namespace bookDemo.Data
{
    //static oluşturuyoruz ki buradaki değişikliklere anlık olarak her yerden ulaşılabilinsin
    //*staticler newlenemez
    public static class ApplicationContext
    {
        public static List<Book> Books { get; set; }

        static ApplicationContext()
        {
            Books = new List<Book>()
            {
                new Book(){Id = 1, Title = "Mesnevi", Price = 10},
                new Book(){Id = 2, Title = "Masal Masal icinde", Price = 150},
                new Book(){Id = 3, Title = "The Walking Dead", Price = 35}
            };
        }

    }
}
