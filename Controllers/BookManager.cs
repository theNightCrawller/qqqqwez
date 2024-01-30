
namespace app
{
    public class BookManager
    {
        public List<Book> ListOfBooks;
        public BookManager()
        {
            // zeby mi methoda dzialala przy powsatwanie pierwszej instancji book
            // inicjalizuje liste zebhy nie byla null
            ListOfBooks = new List<Book>();
        }


        public void SeeAllBooks()
        {
            foreach (var book in ListOfBooks)
            {
                Console.WriteLine("Book:");
                Console.WriteLine(book);
            }
        }
        public void AddNewBook(Book newBook)
        {
            int targetId = newBook.Id;
            List<Book> matchingBooks = ListOfBooks.FindAll(book => book.Id == targetId);
            if (matchingBooks.Any())
            {
                Console.WriteLine("this book id already exists in the book list try again :)");
            }

            else
            {
                ListOfBooks.Add(newBook);
                Console.WriteLine("book was added succesfully");
            }


        }

        public void DeleteBook(int targetId)
        {
            int result = ListOfBooks.RemoveAll(book => book.Id == targetId);
            if (result > 0)
            {
                Console.WriteLine("succesfully deleted book book managment System");
            }
            else
            {
                Console.WriteLine("Book id was not found :(");
            }

        }
        public void UpdateBook(int targetId, string newTitle, int newInStockAmount, double newPrice, Author newAuthor, Category newCategory)
        {
            Book bookToUpdate = ListOfBooks.Find(book => book.Id == targetId);

            if (bookToUpdate != null)
            {
                bookToUpdate.Title = newTitle;
                bookToUpdate.InStockAmount = newInStockAmount;
                bookToUpdate.Price = newPrice;
                bookToUpdate.Author = newAuthor;
                bookToUpdate.Category = newCategory;

                Console.WriteLine("Book updated successfully");
            }
            else
            {
                Console.WriteLine($"Book with ID {targetId} not found");
            }
        }

    }
}