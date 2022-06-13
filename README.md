CSD228-HW2 Generate a Styled HTML Table

*For loops and other operators*
In this exercise we are going to write a method that generates a styled HTML table.

An HTML table consists of 3 main tags namely <table>, <tr>, and <td>. You can read about HTML on W3Schools.

The goal of this exercise is to generate a table with alternating row colors for more readability. This is a common practice when generating table rows dynamically in JavaScript or other backend programming languages when generating the HTML content.

The color of each row can be set by either the "style" or "class" attribute. To keep things simple, we are going to use style here. The following 4 row table is an example

Row 1
Row 2
Row 3
Row 4
The HTML that generates the above table is

<table>
    <tr>
        <td>Row 1</td>
    </tr>
    <tr style="background:gray">
        <td>Row 2</td>
    </tr>
    <tr>
        <td>Row 3</td>
    </tr>
    <tr style="background:gray">
        <td>Row 4</td>
    </tr>
</table>

We want to write a method that returns the HTML code for a table with alternating row background colors. This method should be called GenerateTable and it has 2 parameters. The first parameter, which is a string determines either the odd rows should be highlighted or the even rows. The method expects to see the words "even" and "odd" in this parameter. The second parameter determines the number of rows.

This method should be public a static method in the Program.cs file. Your program also needs to read the values stored in string[] args of he main method since the parameters for this table generation are passed to the program at runtime. The main method will call GenerateTable and print out the results.

*Example*
Users should be able to run your program with this command and see the HTM above:

dotnet run even 4
The following command will result in a table with 50 rows and odd rows highlighted

dotnet run odd 50


*Fail safe*
If the input to the program is not formatted correctly, meaning the number of arguments passed to the program is incorrect or cannot be parsed correctly, your program should print out "Wrong input" and exit. Your program should be fail safe. Some examples that should result in wrong input message:

dotnet run hello world
dotnet run 4 409
dotnet run odd


*Correct indentation*
Note that the counter for each row increments AND there are exactly 2 spaces before each <tr> and 4 spaces before each <td> tag. This will result in proper indentation.

Even though HTML is agnostic to white spaces and the browser can parse and render it without proper indentation, just like Java, proper indentation makes the code more readable.

Try to use the StringBuilder class rather than concatenating the string before return in your method. You can test your program by running the main method.

Hint 1: You need to use the modulus operator within a loop