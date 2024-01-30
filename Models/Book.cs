namespace app
{
    public class Book
    {
        public int Id;
        public string Title;
        public int InStockAmount;
        public double Price;
        public Author Author;
        public Category Category;

        public Book(int id, string title, int inStockAmount, double price, Author author, Category category)
        {
            Id = id;
            Title = title;
            InStockAmount = inStockAmount;
            Price = price;
            Author = author;
            Category = category;
        }

        public override string ToString()
        {
            return $"ID: {Id}, title: {Title}, Author: {Author} Category: {Category} Price: {Price} In Stock: {InStockAmount}";
        }


    }
}