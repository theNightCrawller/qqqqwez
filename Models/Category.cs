namespace app
{
    public class Category
    {

        public int CategoryId;
        public string CategoryName;

        public string Description;

        public Category(int categoryId, string categoryName, string description)
        {
            CategoryId = categoryId;
            CategoryName = categoryName;
            Description = description;

        }
        public static Category Fiction = new Category(1, "Fiction", "Books that are not based on real events.");
        public static Category NonFiction = new Category(2, "Non-Fiction", "Books based on real events or facts.");
        public static Category Mystery = new Category(3, "Mystery", "Books that involve suspense or unknown elements.");
        public static Category ScienceFiction = new Category(4, "Science Fiction", "Books based on futuristic or scientific concepts.");



        public override string ToString()
        {
            return $"{CategoryName}: {Description}";
        }

    }
}