# Scrabble Scorrer

#### By Kirsten Opstad, Richard Cha, Daniel Yakovlev

#### A short description of ProjectName

## Technologies Used

* C#
* .Net 6

## Description

### Objectives (MVP)

Make a console application that takes a word and returns the Scrabble score for that word. Make sure to start with your specs, and that you include a README for this project and create a Git repository for it. Here are the values of letters in Scrabble:

  A, E, I, O, U, L, N, R, S, T       1
  D, G                               2
  B, C, M, P                         3
  F, H, V, W, Y                      4
  K                                  5
  J, X                               8
  Q, Z                               10

#### Specification
Takes user input string word

Calculates score based on Scrabble letter values
  *   Store letter values in class Score Word - potentially as a dict, where *array* of letters is the key and the letter value is the value
    b/u plan if can't store array as dict key: each letter is key that holds letter-value
  Iterate through each letter
  Get letter score
  Add letter score to word total

Returns int score


Dictionary<string[], int> 

  <!-- Non-MVP
  - add multiple player functionality ()
  - add abstract class Gameplay -->

<!-- Play Scrabble 
In the box: 
  - a board (center start, double letter scores, etc.)
  - finite number of letter tiles (A->Z + mystery)
  - hand stand (where your letters go)

Start a game:
> Get # of players
> Distribute [HAND_SIZE] (7?) tiles to each player
> Decide who starts

Play the game:
> Unitl all letters have beed drawn && no more plays left
  > Each player tries to build a word out of their "hand"
    > if not the first word, word must connect with another word & not conflict with existing
      > word has to be in dictionary
    > if player can't make word, they're out of the game -->



<!-- [x] Screenshots

![Screenshots](https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse1.mm.bing.net%2Fth%3Fid%3DOIP.03bZmDGXaBhBYyxxp3Ls3gHaEA%26pid%3DApi&f=1&ipt=e980d57210242747a51c41421e1f09a6de3b1fdaeaadd297496787bb64e80c88&ipo=images) -->

<!-- [Link to operational site](http://www.kirstenopstad.github.com/<REPOSITORY NAME>) -->

### Goals
1. Meet MVP

## Setup/Installation Requirements

* Clone this repo to your workspace.
* Navigate to the top level of the directory.
* Navigate to program directory ``` $ cd ProjectName ```
* Build the project with ``` $ dotnet build ```
* Run the project with ``` $ dotnet run ```

## Known Bugs

* No known bugs. If you find one, please email me at kirsten.opstad@gmail.com with the subject **[_Repo Name_] Bug** and include:
  * BUG: _A brief description of the bug_
  * FIX: _Suggestion for solution (if you have one!)_
  * If you'd like to be credited, please also include your **_github user profile link_**

## License
<!-- [Choose License](https://choosealicense.com/) -->

MIT License

Copyright (c) 2022 Kirsten Opstad

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
