/// <summary>
/// A manager for a library's collection of books.
/// </summary>
public class LibraryManager : ILibraryManager
{
    private List<Book> _books;

    /// <summary>
    /// Adds a book to the library's collection.
    /// </summary>
    /// <param name="book">The book to add.</param>
    public void AddBook(Book book)
    {
        bool exist = false;
        foreach (book b in _books){
            if(b.title == book.title){
                exist = true;
                break;
            }
        }
        if (exist == false){
            _books.Add(book);
        }
        // TODO step 1.
        // TODO step 2.
    }

    /// <summary>
    /// Removes a book from the library's collection.
    /// </summary>
    /// <param name="book">The book to remove.</param>
    public void RemoveBook(Book book)
    {
        _books.remove(book);
        // TODO step 1.
    }
    public string Articul { get; set; }
}