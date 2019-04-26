# Word Counter

#### A program to tell you how many times an inputted word is contained within an inputted sentence. 4/26/2019

#### By **Maya Frame**

## Description
A program created with C# where a user can input a word and determine how many times it appears within an inputted sentence.

### Example
| Spec | Input |
| :-------------     | :------------- |
| **User Word Input** | "Boy" |  
| **User Sentence Input** | "Oh boyo boy! Can you believe they boycotted Boy George for flamboyantly liking boys?" |
| **Expected Output** | "2 matches" |

### Specs
| Input | Output | Spec Description|
| :-------------     | :------------- | :------------- |
| User Word Input: "a" / User Sentence Input: "a" | Output: "1 match" | User inputs single character word string and matching single character sentence string. The program outputs one match.|
| User Word Input: "a" / User Sentence Input: "a a" | Output: "2 matches" | User inputs single character word string and two character sentence string containing two matching characters. The program outputs two matches.|
| User Word Input: "boy" / User Sentence Input: "Oh boy oh boy" | Output: "2 matches" | User inputs multi-character word string ("boy") and a sentence string containing multiple instances of the word ("boy"). The program cycles through the sentence string, finds two instances of the word, outputs two matches.|
| User Word Input: "boy" / User Sentence Input: "Oh boyo boy! Can you believe they boycotted Boy George for flamboyantly liking boys?" | Output: "2 matches" | User inputs a word string ("boy") and a sentence string containing multiple words, including two instance of the word ("boy") AND words that contain the word string ("boy"). Program returns only full word matches, excluding longer words that contain matching word string characters.|

## Setup/Installation Requirements

1. To run this program, you must have a C# compiler.
2. Clone Github repository.
3. Run via Git Bash or other terminal.
4. https://github.com/meyerclemon/Independent_Project_5

## Known Bugs
* No known bugs at this time.

## Technologies Used
* C#

## Support and contact details

_Email mayacframe@gmail.com with any questions, comments, or concerns._

### License

*{This software is licensed under the MIT license}*

Copyright (c) 2019 **_{Maya Frame}_**
