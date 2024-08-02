using Hr_library.Core.interfaces;

namespace Hr_library.Core.Entities;

public class author:library<int>
{
    public int Id { get; }
    public string Name { get; set; } = null!;
    public string Surname { get; set; }
    private static int _id;
    public author(string name)
    {
        Id = _id++;
        Name = name;
    }
}
