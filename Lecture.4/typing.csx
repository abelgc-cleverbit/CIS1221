
// use csi to interactively run this file
// use #load "typing.csx" to dynamically load defintions in this file
// then try: 
//  i.GetType()
//  copy.GetType()
//  copy = "mela"

    int i = 10; //explicit typing
    int j;

    j=5;
    var copy = i; //inferred typing

    var other; 

    other = 5;

    Console.WriteLine(i); 
    Console.WriteLine(copy);

    //copy = "mela"; //type violation, detected in compiling time in C#



