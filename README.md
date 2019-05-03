# Word Counter

#### A program to tell you how many times an inputted word is contained within an inputted sentence.

#### By **Maya Frame**

## Description
A program created with C# where a user can input a word and determine how many times it appears within an inputted sentence.

### Example
| Spec | Input |
| :-------------     | :------------- |
| **User Word Input** | "Boy" |  
| **User Sentence Input** | "Oh boyo boy! Can you believe they boycotted Boy George for not looking boyish?" |
| **Expected Output** | "2 matches" |

### Specs
| Spec | Word Input| Sentence Input |Output|
| :-------------     | :------------- | :------------- |:------------- |
| Program recognizes when a word string has been entered| "word"| |  "word"|
| Program recognizes when sentence string has been entered|| "Oh my word |  "Oh my word" | 
| Program changes all input to lower case. |  "Word" | "More words"| "word" / "more words"| 
| User inputs sentence string and program splits sentence into an array| "boy" |  "Oh boy oh boy" |  "'oh','boy','oh','boy'" | 
| Program loops over the sentence array checking for user input word matches| "boy"| SPLIT: "'oh','boy','oh','boy'"| "2 matches"|
| Program returns only full word matches, excluding longer words that contain matching word string characters.| "boy" | "Oh boyo boy! Can you believe they boycotted Boy George for not looking boyish?" | "2 matches" |

## Setup/Installation Requirements

Download .NET Core 2.2.103 SDK install it. Download Mono and install it.

Clone this repository: $ git clone repo name
Change into the work directory:: $ cd WordCounter.Solution
To edit the project, open the project in your preferred text editor.

To run the program, first navigate to the location of the WordCounter.cs file then compile and execute: $ cd WordCounter/Models $ mcs WordCounter.cs; mono WordCounter.exe;

To run the tests, use these commands: $ cd WordCounter.Tests $ dotnet test

## Known Bugs
* No known bugs at this time.

## Technologies Used
* C#

## Support and contact details

_Email mayacframe@gmail.com with any questions, comments, or concerns._

### License

*{This software is licensed under the MIT license}*

Copyright (c) 2019 **_{Maya Frame}_**
