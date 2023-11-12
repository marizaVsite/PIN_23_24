using BookAPI.Data;

namespace BookAPI.Services
{
    public class PublishersService
    {
        private AppDbContext _context;
        public PublishersService(AppDbContext context)
        {
            _context = context;
        }

        public void AddPublisher(PublisherVM publisher)
        {
            var newPublisher = new Publisher()
            {
                Name = publisher.Name
            };
            _context.Publishers.Add(newPublisher);
            _context.SaveChanges();
        }

        public void DeletePublisher(int id)
        {
           var publisher = _context.Publishers.FirstOrDefault(x => x.Id == id);
            if(publisher != null)
            {
                _context.Publishers.Remove(publisher);
                _context.SaveChanges();
            }
        }
    }
}
