# WordCounter

## Description
Write a program that gathers both a word and sentence from a user, then checks how frequently the word appears in the sentence. It should check for full word matches only. (For instance, if provided the word "cat" and sentence "I'm walking to the cathedral." the first three letters of the word cathedral would not be counted.) Also, do not use regular expressions in your logic.

## Specs
Each spec should include a specific input and output, and a description sentence explaining why you selected that input value as the simplest way to test the behavior your spec covers.

* Input word (inputWord)
* Input sentence (inputSentence)
* Output number (wordCounter)

* split inputWord to character array ("c-a-t")
* split inputSentence to character array ("t-h-e- -c-a-t- -i-n- -t-h-e- -h-a-t-")

* search array for 0 index (first character) of inputWord
  * if proceeding index numbers for the length of the inputWord.array match the inputSentence.array
  * if index before/after (length-1, length+1) is != letter
  * wordCount++

**Behavior 1: Takes wordInput of single letter & a single letter sentence & returns wordCount**
* Input: "c" and "c"
* Output: "1"

**This is the simplest behavior because wordInput is only one letter and sentenceInput is only one letter.**


**Behavior: Takes wordInput of single letter & two single letter "sentence" & returns wordCount**
* Input: "c" and "c c"
* Output: "2"

**This would be the next behavior because wordInput is only one letter and sentenceInput is two "words".**

**Behavior: Takes wordInput of word & sentence & returns wordCount**
* Input: "cat" and "The cat in the hat"
* Output: "1"

**This would be the next behavior because following 1 letter is one word & sentence input is looking for word.**

**Behavior: Takes wordInput of word & sentence with word as part of another larger word (cat & cathedral) & returns correct wordCount**
* Input: "cat" and "The cat went to the cathedral"
* Output: "1"

**This is the final behavior, word (cat) appears in sentence & also characters within the word appear within another word (cathedral).**

----

## Setup Instructions

**.NET framework (which includes the C# language)**
* Download this .NET Core SDK (Software Development Kit).
* Clicking this link will prompt a .pkg file download from Microsoft.
* Open the file. This will launch an installer. Follow the steps it walks through. The default settings it suggests are alright.
* Confirm the installation is successful by opening the Terminal and running the command $ dotnet --version. You should see something like this in response (version numbers do not need to be the exact same): **1.1.4
* This means .NET (and therefore C# too) is successfully installed. Great!

----

**Mono: Mac Version**
* Download the Mac version from the Download section of the Mono website.
* Open the downloaded .pkg file to run the installation wizard.
* Confirm the installation is successful by running the command $ mono --version. You should see a response like this (it doesn't have to match exactly):

Mono JIT compiler version 5.10.1.57 (2017-12/ea8a24b1bbf Tue Apr 24 14:53:01 EDT 2018)
Copyright (C) 2002-2014 Novell, Inc, Xamarin Inc and Contributors. www.mono-project.com
    TLS:           normal
    SIGSEGV:       altstack
    Notification:  kqueue
    Architecture:  amd64
    Disabled:      none
    Misc:          softdebug
    Interpreter:   yes
    LLVM:          yes(3.6.0svn-mono-master/8b1520c8aae)
    GC:            sgen (concurrent by default)
    
**This means Mono is successfully installed, and our computer recognizes the corresponding $ mono command. Great!

----

**Mono: Windows Version**
* Download the Windows version from the Download section of the Mono website.
* Open the downloaded file to launch the installation wizard. Pay very careful attention the location you install Mono in, even if using the default location. We'll need this in step 6.
* Add the Mono environment variable to the system PATH. This is its own multi-step process. Instructions here are for Windows 10:
* Open the Control Panel and visit System > Advanced System Settings > Environment Variables...
* Then select PATH..., click Edit..., then Add.
* Add the exact location of your Mono installation, as mentioned in step two above, and click OK. (This location is likely C:\Program Files(x86)\Mono\bin\ or C:\Program Files\Mono\bin\, but may differ depending on your specific installation settings.)
* Confirm the installation is successful by restarting the Windows PowerShell, and running the command $ mono --version. You should see a response fairly similar to the one depicted above.
**This means Mono is successfully installed, and our computer recognizes the $ mono command.

----

**Installing MAMP**
** MAMP is free server and database software used to create, edit, connect to, query, and manage databases.

**Mac** 
** Download the Mac version of MAMP from the MAMP Downloads Page.
** Open the downloaded .pkg file to run the installer.
** Proceed to the Configuring Port Numbers section below.

**Windows**
** Download the Windows version of MAMP from the MAMP Downloads Page.
** Open the downloaded .exe file to launch the installer. Its default settings are fine, but pay careful attention the location you install MAMP, even if using the default. We'll need this info shortly.
** Add the MySQL environment variable to the System PATH. Just like with Mono, we must include MySQL (a type of database MAMP uses) in the System Environment Path Variable. This is its own multi-step process. Instructions here are for Windows 10:
** Open the Control Panel and visit System > Advanced System Settings > Environment Variables...
** Then select PATH..., click Edit..., then Add.
** Add the exact location of your MySQL installation, as mentioned in step two above, and click OK. (This location is likely C:\MAMP\bin\mysql\bin, but may differ depending on your specific installation.)
** If you receive error stating the command mySQL is "not recognized", the location you provided is likely inaccurate. Double-check it and try again.
** Proceed to the Configuring Port Numbers section below.
** Configuring Port Numbers (Both Mac and Windows)
** Both Mac and Windows users must configure Apache and MySQL to use the correct port numbers.
** Launch MAMP by locating the application and double-clicking it. (MAMP is a full application accessible through the GUI, not just the command line.)
** A popup may appear. If so, uncheck the Check for MAMP Pro when starting MAMP option, then click Launch MAMP. (The free version is fine for our course).
** You should see a MAMP window with several options. Click Preferences (or visit MAMP > Preferences in the toolbar) then select the Ports tab.
** Set the Apache Port to 8888, the MySQL Port to 8889, then click OK.
** Confirm MAMP and MySQL have been installed correctly by clicking Start Servers in the MAMP window. This will open a page with server data in the browser. You can close this.
** Connect to the server we just started by running $ mysql -uroot -proot in the command line.
** If you receive an error about not being able to connect to servers, or the command not being found, try running one of the following (the file path in these commands must match your MAMP installation location):

  ** For Mac: /Applications/MAMP/Library/bin/mysql --host=localhost -uroot -proot
  ** For Windows: C:\MAMP\bin\mysql --host=localhost -uroot -proot

** You should see a response like this in the command line:
** Welcome to the MySQL monitor.  Commands end with ; or \g.
** Your MySQL connection id is 2
** Server version: 5.7.23 MySQL Community Server (GPL)
** Copyright (c) 2000, 2018, Oracle and/or its affiliates. All rights reserved.
** Oracle is a registered trademark of Oracle Corporation and/or its affiliates. Other names may be trademarks of their respective
owners.

Type 'help;' or '\h' for help. Type '\c' to clear the current input statement.

mysql>

**This means you're logged into a MySQL server with the username root and password root. More importantly, it means your installation is successful!**
** You can now quit MySQL by running the following in the terminal: \q.

----

**Opening this Project**
* Open Mac Terminal or Windows Command Prompt
* Git clone this repository
* Type "cd WordCounter.Solution" and press enter to go to the solution directory.
* Type "cd WordCounter" and press enter to go to the application directory.

  * D:\user\WordCounter.Solution\WordCounter>dotnet restore
  * D:\user\WordCounter.Solution\WordCounter>dotnet build
  * D:\user\WordCounter.Solution\WordCounter>dotnet run
  * Hosting environment: Production
  * Content root path: D:\user\WordCounter.Solution\WordCounter
  * Now listening on: http://localhost:5000
  * Application started. Press Ctrl+C to shut down.

* Open a web browser and go to http://localhost:5000/*


## Technologies Used
* C#
* .NET Core
* Mono

## GitHub Repository
https://github.com/claramunro/WordCounter.Solution

## Known Bugs
None.

Copyright (c) 2019 Clara Munro
