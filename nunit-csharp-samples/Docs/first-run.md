# Console Library System.

## First run

### Git та SSH-ключ

1. Go to this [Link](https://git-scm.com/downloads) and download the installer;
2. Install Git.
3. Select the next options;
4. In Start, find and run "Git Bash";
5. Generate an SSH-key, using your email. Press Enter 3 times:

```sh
user@vm-orbital MINGW64 ~
$ ssh-keygen -t rsa -b 4096 -C "tester@gmail.com"
Generating public/private rsa key pair.
Enter file in which to save the key (/c/Users/%user%/.ssh/id_rsa): <ENTER>
Created directory '/c/Users/%user%/.ssh'.
Enter passphrase (empty for no passphrase): <ENTER>
Enter same passphrase again: <ENTER>
Your identification has been saved in /c/Users/%user%/.ssh/id_rsa.
Your public key has been saved in /c/Users/%user%/.ssh/id_rsa.pub.
```

6. Open the file (id_rsa.pub), using the path from "Your identification has been saved in ..." and copy your key.

### GitHub and set up the SSH-key

1. Create a new account to [GitHub](https://github.com) or use and existing account;
2. Sign in;
3. Open the settings ["Settings\SSH and GPG keys"](https://github.com/settings/keys);
4. Press ["New SSH key"](https://github.com/settings/ssh/new);
5. Put in the new key from id_rsa.pub into the Key field;
6. Press "Add SSH key".

### Repositories

You should make a [copy of this repository](https://help.github.com/articles/fork-a-repo/) nunit-csharp-samples and then clone it to your local drive.

1. Go to [GitHub](https://github.com/);
2. Sign in to your account;
3. Open the repository [nunit-csharp-samples](https://github.com/vanyachernov/nunit-csharp-samples);
4. Press the button "Fork";
5. Go to the nunit-csharp-samples personal repository page. For example, if your username is tester, the page is https://github.com/tester/nunit-csharp-samples;
6. Press the button "Clone or download" and copy the path to your repository in the "Clone with SSH" window:

```sh
C:\tester\Desktop>git clone git@github.com:tester/nunit-csharp-samples.git
Cloning into 'nunit-csharp-samples'...
...
```

7. For subsequent commits, set a name and email for Git:

```sh
C:\tester\Desktop>git config --global user.email "test@gmail.com"
C:\tester\Desktop>git config --global user.name "Firstname Lastname"
```