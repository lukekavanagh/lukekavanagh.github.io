[Week 1 Home](../)

# Computer Set-Up Instructions: C# on Windows

## Learning Competencies
By the end of this lesson, you should be able to:

- Install technologies from the command line
- Understand what a package manager is and why it is helpful

## Summary
You will need to have your computer set up with the following tools for Phase 0 of Dev Academy. Make sure to go through this guide step-by-step. You'll need to have each of these technologies installed to have a smooth start to Phase 0 and your future career!

Here is the instructions for getting your windows environment set up. We will be installing:

- Chocolatey
- Sublime
- Node
- Git
- SQLite
- Microsoft Visual Studio Express 2013
- Microsoft SQL Server Express

## Releases
(i.e. directions - each release is necessary for the next release, so be sure to do everything in the order specified for all challenges)

## Release 0: Download Sublime Text

Download and follow instructions from [their site.](http://www.sublimetext.com/)

If you have done this correctly, you should be able to open files from the command prompt using `subl "filename"` now.

You don't have to purchase your license right away, you can "cancel" out of the dialog box as many times as you would like, but it is good practice to buy a license after you decide you like it. (Since eventually you're hoping to get paid for writing programs, you want to pay it forward in advance.)  
  
Bookmark [keyboard shortcuts for windows](http://sublime-text-unofficial-documentation.readthedocs.org/en/latest/reference/keyboard_shortcuts_win.html)  


## Release 1: Install Chocolatey
Now lets install our package manager to get the libraries we need.

Chocolatey works like howbrew for mac or apt-get for linux. We download this program and say:

"Chocolatey, download Ruby!" or "Chocolatey, download Nodejs!"

Chocolatey takes care of downloading and installing these programs for you. It even adjusts your PATH variable to make sure the OS accesses these languages correctly.

The first step is to install chocolatey, it can be found [here](http://chocolatey.org/).

Navigate to your root directory C:/ for cmd.exe or PS:/ if you are using powershell and run one of these commands.

```shell
cmd.exe
 C:/ @powershell -NoProfile -ExecutionPolicy unrestricted -Command "iex ((new-object net.webclient).DownloadString('https://chocolatey.org/install.ps1'))" && SET PATH=%PATH%;%ALLUSERSPROFILE%\chocolatey\bin
 ```

For the Powershell Users. Note that you do not want to run both of these, just use whichever relates to which terminal you use.

 ```shell
Powershell
PS:/ iex ((new-object net.webclient).DownloadString('https://chocolatey.org/install.ps1'))
```

It will give you a message to say that chocolatey has finished installing and your cursor will be under your control again. Now we can start installing packages. You can search a list of all the available for chocolatey on their website [Chocolatey packages](http://chocolatey.org/packages).

## Release 2: Install Node

Similar to Ruby, we just use a different command.

```shell
C:/ cinst nodejs
```

type node -v to test your succcess.

## Release 3: Install and Configure Git

You can download Github for Windows from [https://windows.github.com/](https://windows.github.com/)

Once installed, please remove the Github App shortcut and exclusively use "Gitshell" for any git operations.

Then we want to set up our default git editor to sublime. Follow [these instructions](http://stackoverflow.com/questions/8951275/git-config-core-editor-how-to-make-sublime-text-the-default-editor-for-git-on/9408117#9408117).

## Release 4: Install SQLite

The DLL
```shell
C:/ cinst SQLite
```
And the SQLite shell
```shell
C:/ cinst sqlite.shell
```

type this to test:

```shell
sqlite3 -version
```

## Release 5: Set up Sublime
Follow [these instructions](https://github.com/dev-academy-phase0/phase-0-handbook/blob/master/text-editor-setup.md) in the Phase 0 Handbook to make Sublime your default text editor.

## Release 6: Visual Studio Express 2013

Visual Studio is Microsoft's [IDE](http://en.wikipedia.org/wiki/Integrated_development_environment) of choice to develop software for the Windows platform.

Although it is not a requirement for Phase 0, you will be using Visual Studio extensively during the bootcamp phases.

You should download the "Windows Desktop" version, located at [http://www.visualstudio.com/downloads/download-visual-studio-vs#d-express-windows-desktop](http://www.visualstudio.com/downloads/download-visual-studio-vs#d-express-windows-desktop)

## Release 7: Microsoft SQL Server 

Similary to Visual Studio, you will not be needing this for Phase 0, but it's a good idea to have your machine set-up and ready for the bootcamp phases.

You can download the free version of Microsoft's SQL server at [http://www.microsoft.com/en-us/server-cloud/products/sql-server-editions/sql-server-express.aspx](http://www.microsoft.com/en-us/server-cloud/products/sql-server-editions/sql-server-express.aspx)

## Release 8: Thats all

You now have a set up environment for development! If you are interested in this kind of thing, there is a whole job created around automating server and terminal set up. It is called DevOps, they do lots of things to make software development more efficient. Check it out! [devopsreactions](http://devopsreactions.tumblr.com/)
