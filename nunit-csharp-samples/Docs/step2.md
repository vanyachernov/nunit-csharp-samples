# Console Library System.

## Step 2. Book Articul

### Task

Розширити клас Book у проєкті nunit-csharp-samples, додавши нове поле Articul. Додати перевірку у відповідний метод AddBook класу LibraryManager. Для цього кроку в коді є підказки "TODO step 2".

### Performance

1. Create a new branch named "step2":

```sh
$ git checkout -b step2
$ git branch
  master
  step1
* step2
```

2. Add a new Articul field, in the [LibraryManager](../Implementations/LibraryManager.cs) class:

```cs
/// <summary>
/// Gets or sets a book articul.
/// </summary>
public string Articul { get; set; }
```

3. Add a check for the existence of an article in the system before adding a book (AddBook method in the [LibraryManager](../Implementations/LibraryManager.cs) class):

```cs
public void AddBook(Book book)
{
    // TODO step 2.
    ...
}
```

4. Save changes as a separate commit.

```sh
$ git status
$ git diff
$ git add *
$ git commit -m "Add Articul property to Book. Update AddBook method in LibraryManager."
$ git log
$ git push -u origin step2
```

5. Merge the "step2" branch with the "master" branch.

Switch to the "master" branch and verify that it is the master branch:

```sh
$ git checkout master
$ git branch
* master
  step1
  step2
$ git merge --squash step2
$ git commit -m "Merge step2. Add Articul property to Book. Update AddBook method in LibraryManager."
$ git push
```

### Materials

Materials for self-study:
* [Introduction to Git](https://git-scm.com/book/uk/v2)
* [Tutorial: Learn to debug using Visual Studio](https://docs.microsoft.com/en-us/visualstudio/debugger/getting-started-with-the-debugger)