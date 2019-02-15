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
This is the simplest behavior because wordInput is only one letter and sentenceInput is only one letter.

**Behavior: Takes wordInput of single letter & two single letter "sentence" & returns wordCount**
* Input: "c" and "c c"
* Output: "2"
This would be the next behavior because wordInput is only one letter and sentenceInput is two "words".

**Behavior: Takes wordInput of word & sentence & returns wordCount**
* Input: "cat" and "The cat in the hat"
* Output: "1"
This would be the next behavior because following 1 letter is one word & sentence input is looking for word.

**Behavior: Takes wordInput of word & sentence with word as part of another larger word (cat & cathedral) & returns correct wordCount**
* Input: "cat" and "The cat went to the cathedral"
* Output: "1"
This is the final behavior, word (cat) appears in sentence & also characters within the word appear within another word (cathedral).


## Setup Instructions
* Clone repository
* Add to desktop using "git clone"

## Technologies Used
* C# & .NET

## GitHub Repository
https://github.com/claramunro/WordCounter.Solution

## Known Bugs
None.

Copyright (c) 2019 Clara Munro
