// Loops
// For Loop, While Loop, Foreach Loop, Do While Loop
//Variants of our two main types of loops: for loop, while loop
//Loop is a block of code that repeats.

//For Loop!
//The most common type of loop.
//For loop is a block of code that runs a certain number of times Or. a block of code that repeats for some range of numbers.
//for( initializer ; condition; increment){
//
// }
//initializer -> statement that runs before the for loop starts
//condition -> condition we check after each loop to see if we should keep running
//increment -> statement we run after each loop ends.

//While Loop!
//Simplist loop.
//Runs WHILE a condition is true.
// while(condition){
// code to run
// include a change to the condition or a break statement
// }

// For Each Loop!
// Specific version of the for loop that repeats FOR EACH item in some collection
//Example. For Each Loop on a bag of 5 things will run 5 times, add something and it will run 6 times

// Do While Loop!
// A Do while loop is just a while loop that is guaranteed to run once.
//do {
//}
//while()

// Let's say we want to print out every number 0 to 100. i+=2 prints even number i+=3 odd i-=2 negative
//FOR:
//   starts here  stops here
for ( var i = 00; i <= 100; i++)
{
    Console.WriteLine(i);
}

//if(i ==47){
// break;
//}            ---> used to help stop at a certain number, not conventianal.place under console.writeline, break takes us here.



//WHILE
var j = 0; //initializer
while (j <= 100)   //condition
{
    j++;
    Console.WriteLine(j);
    if (j == 47)
        {
            break;
        }
    //j++;   //increment
}


var k = 250;
do
{
    k++;
    Console.WriteLine(k);
}
while (k <= 100);