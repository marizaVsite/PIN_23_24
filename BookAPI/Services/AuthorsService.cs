using BookAPI.Data;

namespace BookAPI.Services
{
    public class AuthorsService
    {
        private AppDbContext _context;
        public AuthorsService(AppDbContext context)
        {
            _context = context;
        }

        public void AddAuthor(AuthorVM author)
        {
            var newAuthor = new Author()
            {
                FullName = author.FullName,
            };
            _context.Authors.Add(newAuthor);
            _context.SaveChanges();
        }

        public AuthorWithBooksVM GetAuthorWithBooks(int id)
        {
            var author = _context.Authors.Where(n => n.Id == id).Select(n=> new AuthorWithBooksVM()
            {
                FullName =n.FullName,
                Books = n.BookAuthors.Select(n => n.Book.Title).ToList()
            }
            ).FirstOrDefault();

            return author;
        }
    }
}
