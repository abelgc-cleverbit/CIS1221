// use csi to interactively run this file
// use #load "parameters.csx" to dynamically load defintions in this file


static void F(int i, object[] a1, object[] a2)
{
    // i is a value type, changes to it won't affect the original variable
    Console.WriteLine($"    F received i = {i}");
    i = 10;
    Console.WriteLine($"    F current value of i = {i}"); 

    // a1 is a reference type, changes to its elements will affect the original array
    Console.WriteLine($"    F received value of a1[0] = {a1[0]}");
    a1[0] = "mela";
    Console.WriteLine($"    F current value of a1[0] = {a1[0]}");

    // a2 is a reference type, but reassigning it won't affect the original array
    Console.WriteLine($"    F received value of a2[0] = {a2[0]}");
    Console.WriteLine($"    F received length of a2 = {a2.Length}");
    a2 = new object[3];
    a2[0] = "mela";
    Console.WriteLine($"    F current value of a2[0] = {a2[0]}");
    Console.WriteLine($"    F current length of a2 = {a2.Length}");
}

// Initial value of i
int i = 2; 
Console.WriteLine($"Before F value of i = {i}");

// Initial value of a1[0], which is null
object[] a1 = new object[1];
Console.WriteLine($"Before F value of a1[0] = {a1[0]}");

// Initial value and length of a2
object[] a2 = new object[10];
a2[0] = "claro";
Console.WriteLine($"Before F value of a2[0] = {a2[0]}");
Console.WriteLine($"Before F length of a2 = {a2.Length}");

// Call the function F
F(i, a1, a2);

// Check the values after calling F
Console.WriteLine($"After F value of i = {i}"); // i remains unchanged
Console.WriteLine($"After F value of a1[0] = {a1[0]}"); // a1[0] is changed
Console.WriteLine($"After F value of a2[0] = {a2[0]}"); // a2[0] remains unchanged
Console.WriteLine($"After F length of a2 = {a2.Length}"); 