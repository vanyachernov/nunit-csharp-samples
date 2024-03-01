# Console Library System.

## Step 1. Library Manager

### Task

Розширити клас LibraryManager у проєкті nunit-csharp-samples, реалізувавши в ньому всі відсутні методи. Для цього кроку в коді є підказки "TODO step 1".

### Performance

0. Open "Git Bash" and navigate to the working directory of the nunit-csharp-samples repository.

```sh
user@MachineName MINGW64 ~
$ cd c:/Desktop/nunit-csharp-samples

user@MachineName MINGW64 /c/Desktop/nunit-csharp-samples (master)
$ git status
On branch master
Your branch is up to date with 'origin/master'.

nothing to commit, working tree clean
```

1. Create a new branch named "step1":

Create a branch using the command [git checkout](https://git-scm.com/book/uk/v2/%D0%93%D0%B0%D0%BB%D1%83%D0%B6%D0%B5%D0%BD%D0%BD%D1%8F-%D0%B2-git-%D0%9E%D1%81%D0%BD%D0%BE%D0%B2%D0%B8-%D0%B3%D0%B0%D0%BB%D1%83%D0%B6%D0%B5%D0%BD%D0%BD%D1%8F-%D1%82%D0%B0-%D0%B7%D0%BB%D0%B8%D0%B2%D0%B0%D0%BD%D0%BD%D1%8F):

```sh
$ git checkout -b step1
```

Check that the new branch "step1" is the current command [git branch](https://git-scm.com/book/uk/v2/%D0%93%D0%B0%D0%BB%D1%83%D0%B6%D0%B5%D0%BD%D0%BD%D1%8F-%D0%B2-git-%D0%A3%D0%BF%D1%80%D0%B0%D0%B2%D0%BB%D1%96%D0%BD%D0%BD%D1%8F-%D0%B3%D1%96%D0%BB%D0%BA%D0%B0%D0%BC%D0%B8):

```sh
$ git branch
  master
* step1
```

2. Implement the AddBook, RemoveBook, SearchBooks methods in the [LibraryManager](../Implementations/LibraryManager.cs) class:

```cs
public void AddBook(Book book)
{
    // TODO step 1.
}

public void RemoveBook(Book book)
{
    // TODO step 1.
}
```

3. Save changes as a separate commit.

View the list of modified files by command [git status](https://git-scm.com/book/uk/v2/%D0%9E%D1%81%D0%BD%D0%BE%D0%B2%D0%B8-Git-%D0%97%D0%B0%D0%BF%D0%B8%D1%81-%D0%B7%D0%BC%D1%96%D0%BD-%D0%B4%D0%BE-%D1%80%D0%B5%D0%BF%D0%BE%D0%B7%D0%B8%D1%82%D0%BE%D1%80%D1%96%D1%8F):

```sh
$ git status
```

View changes in files with the command [git diff](https://git-scm.com/book/uk/v2/%D0%9E%D1%81%D0%BD%D0%BE%D0%B2%D0%B8-Git-%D0%97%D0%B0%D0%BF%D0%B8%D1%81-%D0%B7%D0%BC%D1%96%D0%BD-%D0%B4%D0%BE-%D1%80%D0%B5%D0%BF%D0%BE%D0%B7%D0%B8%D1%82%D0%BE%D1%80%D1%96%D1%8F):

```sh
$ git diff
```

Add changes by command [git add](https://git-scm.com/book/uk/v2/%D0%9E%D1%81%D0%BD%D0%BE%D0%B2%D0%B8-Git-%D0%97%D0%B0%D0%BF%D0%B8%D1%81-%D0%B7%D0%BC%D1%96%D0%BD-%D0%B4%D0%BE-%D1%80%D0%B5%D0%BF%D0%BE%D0%B7%D0%B8%D1%82%D0%BE%D1%80%D1%96%D1%8F):

```sh
$ git add .
```

Create a new commit with a clear description with the command [git commit](https://git-scm.com/book/uk/v2/%D0%9E%D1%81%D0%BD%D0%BE%D0%B2%D0%B8-Git-%D0%97%D0%B0%D0%BF%D0%B8%D1%81-%D0%B7%D0%BC%D1%96%D0%BD-%D0%B4%D0%BE-%D1%80%D0%B5%D0%BF%D0%BE%D0%B7%D0%B8%D1%82%D0%BE%D1%80%D1%96%D1%8F):

```sh
$ git commit -m "Add implementation of AddBook, RemoveBook methods in LibraryManager."
```

View the branch log with the command [git log](https://git-scm.com/book/uk/v2/%D0%9E%D1%81%D0%BD%D0%BE%D0%B2%D0%B8-Git-%D0%9F%D0%B5%D1%80%D0%B5%D0%B3%D0%BB%D1%8F%D0%B4-%D1%96%D1%81%D1%82%D0%BE%D1%80%D1%96%D1%97-%D0%BA%D0%BE%D0%BC%D1%96%D1%82%D1%96%D0%B2):

```sh
$ git log
```

6. Push a branch.

Push the "step1" branch to the remote repository with the command git push.

```sh
$ git push -u origin step1
```

7. Merge the "step1" branch with the "master" branch.

Switch to the "master" branch and verify that it is the master branch:

```sh
$ git checkout master
$ git branch
* master
  step1
```

Paste the changes from the "step1" branch into the "master" branch:

```sh
$ git merge --squash step1
```

Create a new commit with a clear description:

```sh
$ git commit -m "Merge step1. Add implementation of AddBook, RemoveBook methods in LibraryManager."
```

Push changes to the master branch:

```sh
$ git push
```

### Materials

Materials for self-study:
* [Introduction to Git](https://git-scm.com/book/uk/v2)
* [Tutorial: Learn to debug using Visual Studio](https://docs.microsoft.com/en-us/visualstudio/debugger/getting-started-with-the-debugger)