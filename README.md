# __*Scrabble Calculator*__

## By Grinil Khanna

## Description

This application is designed to count the amount of times your inputted word appears in a string.

##Setup
_Setup/Installation Requirements

Clone the files from github Upload them in an editor Fire up a server and load the files onto a browser Fill out the form with contact details Navigate to specific contact details via name Clear entire list when desired._

## Specs

1. The program should take a single letter and be able to return a boolean against another string as a single letter.
  * **Input:** "A" **Input:**  "A"
  * **Output:** true
  * **Input:** "A" **Input:**  "B"
  * **Output:** false

2. The program is able to compare a string of more than two characters, and return a boolean against another string of more than two characters.
  * **Input:** "AT" **Input:**  "AT"
  * **Output:** true
  * **Input:** "AT" **Input:**  "AG"
  * **Output:** false

3. The program is able to compare a string of more than two characters, and return a count +1 if equal against another string of more than two characters regardless of case.
  * **Input:** "Buffalo" **Input:**  "BuFfaLo"
  * **Output:** 1

4. The program is able to split an entire text into an array of strings.
  * **Input:**  "The buffalo is large. Buffalo is my name."
  * **Output:** "The" "buffalo" "is" "large". "Buffalo" "is" "my" "name."

6. The program is able to count the number of strings in a text set.
* **Input:** "The" "buffalo" "is" "large". "Buffalo" "is" "my" "name."
* **Output:** 8

7. The program is able to count the number of words in the text string which are equal to the initial inputted word.
* **Input:** "Buffalo" **Input:**  "The buffalo is large. Buffalo is my name."
* **Output:** 2

##Known Bugs

_Receiving an error on the foreach loop. This is throwing the 500 error out on the site rendering it unatainable._

##Support and contact details

_Feel free to contact me - give me some pointers or feedback! gmkhanna@gmail.com --_

##Technologies Used

_HTML, C#, CSS, _

##License

_Copyright (c) 2017 Grinil Khanna, Epicodus

Copyright (c)

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
