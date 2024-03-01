/// <summary>
/// Defines methods for managing a collection of books in a library.
/// </summary>
public interface ILibraryManager
{
    /// <summary>
    /// Adds a book to the library's collection.
    /// </summary>
    /// <param name="book">The book to add.</param>
    void AddBook(Book book);

    /// <summary>
    /// Removes a book from the library's collection.
    /// </summary>
    /// <param name="book">The book to remove.</param>
    void RemoveBook(Book book);
}