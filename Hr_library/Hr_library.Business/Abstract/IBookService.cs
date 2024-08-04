namespace Hr_library.Business.Abstract;

public interface IBookService
{
    void AddBook(string name,DateTime publicationDate,int quantity,List<int> authorIds,List<int> genreIds);
    void EditBook(int id,string newName,DateTime newPublicationDate,int newQuantity,List<int>newAuthorIds,List<int>newGenreIds);
    void DeleteBook(int id);
    void ListBooks();
}
