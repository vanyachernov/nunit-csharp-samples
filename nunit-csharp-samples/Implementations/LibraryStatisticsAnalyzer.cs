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
        // TODO step 3.
        return [];
    }
    
    /// <summary>
    /// Gets book by title.
    /// </summary>
    /// <param name="title">Book title.</param>
    /// <returns>Book.</returns>
    public Book GetBookByTitle(string title)
    {
        // TODO step 3.
        return new Book();
    }

    /// <summary>
    /// Gets book by articul.
    /// </summary>
    /// <param name="articul">Book articul.</param>
    /// <returns>Book.</returns>
    public Book GetBookByArticul(string articul)
    {
        // TODO step 3.
        return new Book();
    }
}