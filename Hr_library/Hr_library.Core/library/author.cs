using Hr_library.Core.interfaces;

namespace Hr_library.Core.Entities;

public class Author:Library<int>
{
    public int Id { get; }
    public string Name { get; set; } = null!;
    public string Surname { get; set; }
    private static int _id;
    public Author(string name,string surname)
    {
        Id = _id++;
        Name = name;
        Surname= surname;
    }
}
