namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            

            List<Book> books = new List<Book>();

            Book book = new Book("Xezer2", "Sehriyar1", 2001);
            Book book2 = new Book("Xezer3", "Sehriyar2", 2002);
            Book book3 = new Book("Xezer4", "Sehriyar3", 2003);

            DbStore dbStore = new DbStore();

            dbStore.Add(book);
            dbStore.Add(book2);
            dbStore.Add(book3);

            dbStore.ShowBook("37c322ec-44b5-4316-9bb1-5dce85934d42");
            //dbStore.Update("2");
            //dbStore.ShowAllBooks();

            //Console.WriteLine(book2.Name);
        }
    }
}