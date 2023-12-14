namespace BookAPI.Data
{
    public class AuthorVM
    {
        public string FullName { get; set; }
    }


    public class AuthorWithBooksVM
    {
        public string FullName { get; set; }
        public List<string> Books { get; set; }
    }
}
