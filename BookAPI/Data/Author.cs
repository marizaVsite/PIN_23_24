namespace BookAPI.Data
{
    public class Author
    {
        public int Id { get; set; }
        public string FullName { get; set; }   
        
        public List<BookAuthor> BookAuthors { get; set; }
    }
}
