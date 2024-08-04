using Hr_library.Core.interfaces;

namespace Hr_library.Core.Entities;

public class Book : Library<Guid>
{
    public Guid Id { get; }
    public string Name { get; set; } = null!;
    public DateTime PublicationDate { get; set; }
    public int Quantity { get; set; }
    public List<Author> Authors { get; set; }
    public List<Genre> Genres { get; set; }
    public Book()
    {
        Authors = new List<Author>();
        Genres = new List<Genre>();
    }
}
