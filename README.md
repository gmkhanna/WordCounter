# __*Scrabble Calculator*__

## By Grinil Khanna

## Description

This application is designed to count the amount of times your inputted word appears in a string.

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
  * **Output:** 8

5. The program is able to compare a string to a text of more than one word and return a count +1 for every word which is equal.
  * **Input:** "Buffalo" **Input:**  "The buffalo is large. Buffalo is my name."
  * **Output:** 2
