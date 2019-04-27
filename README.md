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
| Spec | Input |Output|
| :-------------     | :------------- | :------------- |
| Program recognizes when a word string has been entered|||
| Program recognizes when sentence string has been entered|  | | 
| Program changes all input to lower case. | User Word Input: "A" / User Sentence Input: "A" | Output: "a"/"a" | 
| User inputs sentence string and program splits sentence into an array| User Word Input: "boy" / User Sentence Input: "Oh boy oh boy" | Output: "'oh','boy','oh','boy'" | 
| Program loops over the sentence array checking for user input word matches| User Word Input: "boy"/ User Sentence Input SPLIT: "'oh','boy','oh','boy'"| Output: "2 matches"|
| Program returns only full word matches, excluding longer words that contain matching word string characters.| User Word Input: "boy" / User Sentence Input: "Oh boyo boy! Can you believe they boycotted Boy George for not being more boyish?" | Output: "2 matches" |

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
