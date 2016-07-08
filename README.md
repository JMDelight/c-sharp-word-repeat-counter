# _Word Repeat Counter_

#### _A basic C# web application to count the number of instances of a specific word in an inputted string. July 8, 2016_

#### By _**Joel Delight**_

## Description

_This is a C# web application that is designed to count the number of instances of a specific word in an inputted string using a web browser._

## Setup/Installation Requirements

* _Download the repository_
* _In the command line, navigate to the repository_
* _Run the command dnu restore_
* _Run the command dnx kestrel_
* _using a web browser, navigate to http://localhost:5004_

## Known Bugs

_There are no known issues with this page_

## Support and contact details

_If you have any questions or concerns, please email me at thefencingflutist@gmail.com_

## BDD specs used in creating this project

Behavior | Input String | Input Word | Expected Output | Reason for choice of Input
--- | --- | --- | --- | ---
Detect when input string matches input word | "a" | "a" | 1 | Only a simple word was needed.
Handle match with capitalization on string | A | a | 1 | Only a simple word is needed.
Handle match with capitalization on input | a | A | 1 | Only a simple word is needed.
Fail to detect a match when the inputted word is a part of a longer word in the inputted string | "cat" | "a" | 0 | Input string is a word that contains the inputted word within it.
Handles spaces in the input string | " a " | "a" | 1 | I want to ensure that it handles both leading and trailing spaces. Only one behavior should be needed to catch both types.
Detect a match in a multi word string | "a dog"| "a" | 1 | A two word phrase is all that is needed.
Detect multiple matches in the inputted sentence | "the cat is the best" | "the" | 2 | A sentence that contains the chosen word twice is needed.
Handles expected punctuation at the end of the word | "cat," | "cat" | 1 | I am just testing for it to handle punctuation
Ensure previous behaviors all work together | "The, cat is the best of these" | "The"/"the" | 2/2 | I just added elements from the previous tests to the sentence I used for the previous test.



## Technologies Used

_C#, Nancy, Razor, xUnit_

### License

*Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.*

Copyright (c) 2016 **_Joel Delight_**
