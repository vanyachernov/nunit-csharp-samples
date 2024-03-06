public class LibraryStatisticsAnalyzer
{
    private readonly LibraryManager _manager;

    public LibraryStatisticsAnalyzer(LibraryManager manager)
    {
        _manager = manager;
    }
    
    /// <summary>
    /// Gets books by author.
    /// </summary>
    /// <param name="author">Book author.</param>
    /// <returns>Book list.</returns>
    public List<Book> GetBooksByAuthor(string author)
    {
        List<Book> books;
        foreach (Book b in _books){
            if(author == b.Author){
                books.add(b)
                break;
            }
        }

        // TODO step 3.
        return books;
    }
    
    /// <summary>
    /// Gets book by title.
    /// </summary>
    /// <param name="title">Book title.</param>
    /// <returns>Book.</returns>
    public Book GetBookByTitle(string title)
    {
        // TODO step 3.
        foreach (Book b in _books){
            if(title == b.Title){
                return b;
                break;
            }
            else{ return null}
        }

        // TODO step 3.
    }

    /// <summary>
    /// Gets book by articul.
    /// </summary>
    /// <param name="articul">Book articul.</param>
    /// <returns>Book.</returns>
    public Book GetBookByArticul(string articul)
    {
        foreach (Book b in _books){
            if(articul == b.Articul){
                return b;
                break;
            }
            else{ return null}
        }
    }
}