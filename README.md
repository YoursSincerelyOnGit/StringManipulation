* Task: I was required to write a method that accepts the string "Yash is a javascript ninja" and transforms it into "ninja a yash" by rearranging words in a specific order.
* Approach: I split the input string into an array of words using Split(' '), selected the fifth word ("ninja"), third word ("a"), and first word ("Yash") converted to lowercase using ToLower(), then concatenated them with spaces.
* Result: The code outputs "ninja a yash" as required (see question1ResultsScreenshot.jpeg).
* Challenges: The solution assumes a fixed five-word input. I could improve it by adding validation for variable input lengths.
* Source Code Reference: The method ModifyString in OutputString.cs uses array indexing to achieve the transformation.
