using BookAPI.Data;

namespace BookAPI.Services
{
    public class BooksService
    {
        private AppDbContext _context;
        public BooksService(AppDbContext context)
        {
            _context = context;
        }

        public void AddBook(BookVM book)
        {
            var newBook = new Book()
            {
                Title = book.Title,
                Description = book.Description,
                IsRead = book.IsRead,
                DateRead = book.IsRead ? book.DateRead : null,
                Rate = book.IsRead ? book.Rate : null,
                Genre = book.Genre,
                CoverPictureURL = book.CoverPictureURL,
                DateAdded = DateTime.Now,
                PublisherId = book.PublihserId
            };
            _context.Books.Add(newBook);
            _context.SaveChanges();

            foreach(var id in book.AuthorIds)
            {
                var bookAuthor = new BookAuthor()
                {
                    BookId = newBook.Id,
                    AuthorId = id
                };
                _context.BooksAuthors.Add(bookAuthor);
            }
            _context.SaveChanges();

        }


        public List<Book> GetAllBooks()
        {
            return _context.Books.ToList();
          
        }

        public BookWithAuthorsVM GetBookById(int id)
        {
            var book = _context.Books.Where(n=>n.Id == id).Select(book => new BookWithAuthorsVM()
            {
                Title = book.Title,
                Description = book.Description,
                IsRead = book.IsRead,
                DateRead = book.IsRead ? book.DateRead : null,
                Rate = book.IsRead ? book.Rate : null,
                Genre = book.Genre,
                CoverPictureURL = book.CoverPictureURL,
                PublihserName = book.Publisher.Name,
                AuthorNames = book.BookAuthors.Select(x=>x.Author.FullName).ToList()

            }).FirstOrDefault();

            return book;
        }


        public Book UpdateBookById(int id, BookVM bookVM)
        {
            var book = _context.Books.FirstOrDefault(x => x.Id == id);
            if(book !=null)
            {
                book.Title = bookVM.Title;
                bookVM.Description = bookVM.Description;
                book.IsRead = bookVM.IsRead;
                book.DateRead = bookVM.IsRead ? bookVM.DateRead : null;
                book.Rate = bookVM.IsRead ? bookVM.Rate : null;
                book.Genre = bookVM.Genre;
                book.CoverPictureURL = bookVM.CoverPictureURL;
                _context.SaveChanges();

            }

            return book;

        }

        public void DeleteBook(int id)
        {
            var book = _context.Books.FirstOrDefault(x => x.Id == id);
            _context.Books.Remove(book);
            _context.SaveChanges();
        }
          
    }
}

