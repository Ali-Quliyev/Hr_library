using Hr_library.Core.interfaces;

namespace Hr_library.Core.Entities;

public class book : library<Guid>
{
    public Guid Id { get; }
    public string Name { get; set; } = null!;
    public DateTime PublicationDate { get; set; }
    public int Quantity
    {
        get; set;
    }
}
    
