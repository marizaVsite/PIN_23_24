namespace BookAPI.Data
{
    public class BookVM
    {
        public string Title { get; set; }
        public string Description { get; set; }
        //Da li smo pročitali knjigu
        public bool IsRead { get; set; }
        //datum kada smo ju pročitali (nullable Datetime - ako ju nismo pročitala datum će imati vrijednost null)
        public DateTime? DateRead { get; set; }
        //ocjena (nullable int - ako ju nismo pročitali ne možemo ju ocijeniti pa će vrijednost biti null)
        public int? Rate { get; set; }
        public string Genre { get; set; }
        public string CoverPictureURL { get; set; }

        public int PublihserId { get; set; }
        public List<int> AuthorIds { get; set; }
    }



    public class BookWithAuthorsVM
    {
        public string Title { get; set; }
        public string Description { get; set; }
        //Da li smo pročitali knjigu
        public bool IsRead { get; set; }
        //datum kada smo ju pročitali (nullable Datetime - ako ju nismo pročitala datum će imati vrijednost null)
        public DateTime? DateRead { get; set; }
        //ocjena (nullable int - ako ju nismo pročitali ne možemo ju ocijeniti pa će vrijednost biti null)
        public int? Rate { get; set; }
        public string Genre { get; set; }
        public string CoverPictureURL { get; set; }

        public string PublihserName { get; set; }
        public List<string> AuthorNames { get; set; }
    }
}
