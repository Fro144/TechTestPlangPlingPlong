# TechTestPlangPlingPlong

### Objective 

The objective of this small project is to create a program that takes in numbers and returns a word based on if the number has a factor of either 3, 5, 7 or if it doesn't have any of these returns the number itself. Each factor will result in a different word being returned "Pling" for factors of 3, "Plang" for factors of 5, and "Plong" for factors of 7. If the number passed in has both/all factors that are equal to 3,5 or 7 then the word returned will have the extra word concatenated to the result. i.e. 30 would return "PlingPlang". 

### Code Example

![image](https://user-images.githubusercontent.com/64920672/119969405-6ed71d80-bfa6-11eb-90ff-c4b05fefc082.png)

 Above is the code created for this project. It takes in a number, then divides the number by 3,5,7 and if the remainder is 0 concatenates a word to the "Result" empty string variable. If the number is not a factor of either 3,5 or 7 then it is converted to a string with the "ToString()" method. It has been created as a static class to remove the need of instantiating the class, allowing the user to call the method directly. 

### Test Examples

![image](https://user-images.githubusercontent.com/64920672/119986004-43aaf900-bfbb-11eb-91f1-c83a546610df.png)

Above shows the tests done to test the individual words, i.e. if the number passed into the method ONLY has a factor of either 3,5 or 7. As shown within the "Pling" and "Plang" tests the method runs if the number entered is a negative number, this is done as an edge case to show that the functionality is prepared for this. 

![image](https://user-images.githubusercontent.com/64920672/119986079-545b6f00-bfbb-11eb-8e06-0932764539cf.png)

The tests above show functionality when dealing with numbers that have MULTIPLE factors, with the final test showing that its possible for all words to be returned provided that the number's factors feature all three numbers.

![image](https://user-images.githubusercontent.com/64920672/119986204-78b74b80-bfbb-11eb-8c0f-2a6d408f9d52.png)

The final test show that if the number does not have any factors then it will return the base number, done with both postive and negative versions of the number in order to test if it is capable of dealing with negative numbers.

