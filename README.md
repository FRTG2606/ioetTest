# ioetTest
Programming exercise for evaluate the skills on C#

* This project is developed in c#, as a console application.

The project was developed in the most logical way possible, using a class that contains the variables to be used, 
objects that refer the class, a matrix with values ​​represented in coordinates to determine the costs worked per hour 
and the logic that relates to the matrix wich is required in the test.

As a first step when executing the project, it will request a path where the file to load is located.
for example: *C:\Users\user\Documents\ioet\ACME Test\TestHours.txt*

When the file is loaded, the code will read the .txt file line by line 
(it validated that only considers .txt files, if another file is loaded, it will send a message saying that the file is not in .txt format)

The file can have one or several lines, the project will read them and calculate for each line.

By separators, the values ​​will be assigned.

In order to know the amount to pay, the prices assigned were validated by a referential digit:
- If is weekend or not.
- If the hours worked fall in a specific range, and the digit assigned for each one.
(The hours are represented as follows: 20:00 -> 2000
16:00 -> 1600  depending the case)

Each validation consists of an exception handler.

I hope the solution is easy to understand and fits what is required.