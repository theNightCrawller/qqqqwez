namespace app
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var controller = new BookManager();
            Console.WriteLine("Welcome to book managment System :)");
            while (true)
            {
                Console.WriteLine("1: see all avalible books");
                Console.WriteLine("2: add ");
                Console.WriteLine("3: Delete");
                Console.WriteLine("4: Udpate ");


                int userInput = int.Parse(Console.ReadLine());
                switch (userInput)
                {
                    case 1:
                        controller.SeeAllBooks();
                        break;

                    case 2:
                        int bookId = Helpers.GetInput<int>("book Id");
                        string title = Helpers.GetInput<string>("Title");
                        int stockAmount = Helpers.GetInput<int>("Stock");
                        double price = Helpers.GetInput<double>("Price");
                        string authorFirstName = Helpers.GetInput<string>("Author First Name");
                        string authorLastName = Helpers.GetInput<string>("Author Last Name");

                        Author author = new Author(authorFirstName, authorLastName);

                        Console.WriteLine("Categories:");
                        Console.WriteLine("1: fiction");
                        Console.WriteLine("2: non-fiction");
                        Console.WriteLine("3: science - fiction");
                        Console.WriteLine("4: mystery");

                        int categoryId = Helpers.GetInput<int>("Pick Category id");
                        Category category;
                        Book book;
                        switch (categoryId)
                        {
                            case 1:

                                category = Category.Fiction;
                                book = new Book(bookId, title, stockAmount, price, author, category);
                                controller.AddNewBook(book);
                                break;

                            case 2:
                                category = Category.NonFiction;
                                book = new Book(bookId, title, stockAmount, price, author, category);
                                controller.AddNewBook(book);
                                break;
                            case 3:
                                category = Category.ScienceFiction;
                                book = new Book(bookId, title, stockAmount, price, author, category);
                                Console.WriteLine(book.ToString());
                                controller.AddNewBook(book);
                                break;
                            case 4:
                                category = Category.Mystery;
                                book = new Book(bookId, title, stockAmount, price, author, category);
                                controller.AddNewBook(book);
                                break;
                            default:
                                Console.WriteLine("try again");
                                break;
                        }
                        break;

                    case 3:
                        int bookToDelete = Helpers.GetInput<int>("book Id");
                        controller.DeleteBook(bookToDelete);
                        break;

                    case 4:
                        int updatedBookId = Helpers.GetInput<int>("book Id");
                        string updatedtitle = Helpers.GetInput<string>("new Title");
                        int updatedstockAmount = Helpers.GetInput<int>("new Stock");
                        double updatedprice = Helpers.GetInput<double>("new Price");
                        string updatedauthorFirstName = Helpers.GetInput<string>("new Author First Name");
                        string updatedauthorLastName = Helpers.GetInput<string>("new Author Last Name");

                        Author updatedauthor = new Author(updatedauthorFirstName, updatedauthorLastName);

                        Console.WriteLine("Categories:");
                        Console.WriteLine("1: fiction");
                        Console.WriteLine("2: non-fiction");
                        Console.WriteLine("3: science - fiction");
                        Console.WriteLine("4: mystery");

                        int updatedcategoryId = Helpers.GetInput<int>("Pick Category id");
                        Category updatedcategory;
                        Book updatedbook;
                        switch (updatedcategoryId)
                        {
                            case 1:

                                updatedcategory = Category.Fiction;
                                controller.UpdateBook(updatedBookId, updatedtitle, updatedstockAmount, updatedprice, updatedauthor, updatedcategory);
                                break;

                            case 2:
                                updatedcategory = Category.NonFiction;
                                controller.UpdateBook(updatedBookId, updatedtitle, updatedstockAmount, updatedprice, updatedauthor, updatedcategory);

                                break;
                            case 3:
                                updatedcategory = Category.ScienceFiction;
                                controller.UpdateBook(updatedBookId, updatedtitle, updatedstockAmount, updatedprice, updatedauthor, updatedcategory);
                                break;
                            case 4:
                                updatedcategory = Category.Mystery;
                                controller.UpdateBook(updatedBookId, updatedtitle, updatedstockAmount, updatedprice, updatedauthor, updatedcategory);
                                break;
                            default:
                                Console.WriteLine("try again");
                                break;
                        }
                        break;

                    default:
                        Console.WriteLine("try again");
                        break;
                }
            }


        }
    }
}