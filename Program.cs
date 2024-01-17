namespace GA_Constructors_DavidAbarca
{// David Abrca
 // Prog 3
 // RTC Will Cram
    internal class Program
    {

        static void Main(string[] args)
        {
            //Book newBook = new Book(); // <--- This is calling a constructor
            //Book bookAuthorAndNAme = new Book("Stephen Covey","The 7 Habits of Highly Effective People");
            //Book bookNameOnly = new Book("Atomic Habits");

            Book book1 = new Book("Stephen Covey", "The 7 Habits of Highly Effective People");
            Console.WriteLine($"Book 1: Title = {book1.Author}, Author = {book1.Title}");

            Book book2 = new Book("Atomic Habits");
            Console.WriteLine($"Book 2: Title = {book2.Title}, Author = {book2.Author}");

            Book book3 = new Book("The Great GAtsby", "F. Scott Fitzgerald");
            Console.WriteLine($"Book 1: Title = {book3.Title}, Author = {book3.Author}");

            Book book4 = new Book("To Kill a Mockingbird");
            Console.WriteLine($"Book 1: Title = {book4.Title}, Author = {book4.Author}");

            Book book5 = new Book("1984", "George Orwell");
            Console.WriteLine($"Book 1: Title = {book5.Title}, Author = {book5.Author}");

            Game Game1 = new Game("Super Mario Bros", "Nintendo");
            Console.WriteLine($"Game 1: Title = {Game1.Title}, Developer = {Game1.Developer}");

            Game Game2 = new Game("Elden Ring", "FromSoft");
            Console.WriteLine($"Game 1: Title = {Game2.Title}, Developer = {Game2.Developer}");

            Game Game3 = new Game("Street Fighter 6", "Capcom");
            Console.WriteLine($"Game 1: Title = {Game3.Title}, Developer = {Game3.Developer}");

            Game Game4 = new Game("Super Smash Bros Melee", "Nintendo");
            Console.WriteLine($"Game 1: Title = {Game4.Title}, Developer = {Game4.Developer}");

            Game Game5 = new Game("Minecraft", "Mojang");
            Console.WriteLine($"Game 1: Title = {Game5.Title}, Developer = {Game5.Developer}");











        }
    }
}