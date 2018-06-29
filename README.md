# _Word Counter_

#### _Counts how many times a specific words is in a string, 6/8/18_

#### By _**Renee Sarley**_

## Description

_This application will count how many times a specific word appears in a string and return the count to the user._
_Both the word to search for and the string will be provided by the user._

## Setup/Installation Requirements

* _Downloaded the project from the GitHub repo here: https://github.com/reneesarley/WordCounter.git_
* _Compile the Program.cs and RepeatCounter.cs files in the terminal using: $ mcs Program.cs RepeatCounter.cs_
* _If using Mono, run the Program.exe file using: $ mono Program.cs_

## Specifications


|Behavior  |     Input     | Output|
|:----------:|:-------------:|:------:|
| Get current value of the wordCounter|  | 0 |
| Set the value of wordToFind to an inputted word | back  | wordToCompare = "back" |
| Set the value of stringToSearch| Joe fell on his back.  | stringToSearch = "Joe fell on his back."|
| If two words are equal to each other return 1| "back" "back" | 1 |
| If two words are not equal to each other return 0 | "back" "backwards" | 0 |
| Change all letters to lowercase in a word| Back | back|
| Divide a sentence into individual words | "Bob fell on his back." | {"Bob", "fell", "on", "his", "back."} |
| Pass sentence with one matching word and update word counter to 1| Bob fell on his back | wordCount = 1 |
| Pass sentence with three matching words and update word counter to 3| Bob fell on his back but didn't hurt his back so he got back up. | wordCount = 3 |
| Pass sentence with no matching words and update word counter to 0| Bob fell on his face | wordCount = 0 |
| Remove any non-letters (numbers and punctuation) from the end of a word | back, | back |


## Known Bugs

_There are currently no known bugs._

## Support and contact details

_Please email me with any questions._

## Technologies Used

* _C#_

### License

*This software is licensed under the MIT license.*

Copyright (c) 2018 **_Renee Sarley_**
