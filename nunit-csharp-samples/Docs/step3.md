# Console Library System.

## Step 3. Library Statistics

### Task

Розширити клас LibraryStatisticsAnalyzer, додавши в нього методи GetBooksByAuthor, GetBookByTitle, GetBookByArticul.

### Performance

1. Create a new branch named "step3".

2. Extend the [LibraryStatisticsAnalyzer](../Implementations/LibraryStatisticsAnalyzer.cs) class by adding the GetBooksByAuthor(), GetBookByTitle(), GetBookByArticul() methods to it:

```cs
public List<Book> GetBooksByAuthor(string author)
{
    // TODO step 3.
    return [];
}
    
public Book GetBookByTitle(string title)
{
    // TODO step 3.
    return new Book();
}

public Book GetBookByArticul(string articul)
{
    // TODO step 3.
    return new Book();
}
```

3. Assemble the project, fix bugs and warnings (if any).

4. Save changes as a separate commit.

5. Merge the "step3" branch with the "master" branch.

### Materials

Materials for self-study:
* [Introduction to Git](https://git-scm.com/book/uk/v2)
* [Tutorial: Learn to debug using Visual Studio](https://docs.microsoft.com/en-us/visualstudio/debugger/getting-started-with-the-debugger)