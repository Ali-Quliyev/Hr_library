using Hr_library.Core.interfaces;

namespace Hr_library.Core.Entities;

internal class genre: library<int>
{
    public int Id { get; }
    public string Name { get; set; } = null!;
    private static int _id;
    public genre(string name)
    {
        Id = _id++;
        Name = name;
    }
}

