// use csi to interactively run this file
// use #load "parameters.csx" to dynamically load defintions in this file

static void F(int i, object[] a1, object[] a2)
{
    Console.WriteLine($"    F received i = {i}");
    i = 10;
    Console.WriteLine($"    F current value of i = {i}"); 

    Console.WriteLine($"    F received value of a1[0] = {a1[0]}");
    a1[0] = "mela";
    Console.WriteLine($"    F current value of a1[0] = {a1[0]}");

    Console.WriteLine($"    F received value of a2[0] = {a2[0]}");
    Console.WriteLine($"    F received length of a2 = {a2.Length}");
    a2 = new object[3];
    a2[0] = "mela";
    Console.WriteLine($"    F current value of a2[0] = {a2[0]}");
    Console.WriteLine($"    F current length of a2 = {a2.Length}");
}

int i = 2; 
Console.WriteLine($"Before F value of i = {i}");

object[] a1 = new object[1];
Console.WriteLine($"Before F value of a1[0] = {a1[0]}");

object[] a2 = new object[10];
a2[0] = "claro";
Console.WriteLine($"Before F value of a2[0] = {a2[0]}");
Console.WriteLine($"Before F length of a2 = {a2.Length}");

Console.WriteLine();
F(i, a1, a2);
Console.WriteLine();

Console.WriteLine($"After F value of i = {i}");
Console.WriteLine($"After F value of a1[0] = {a1[0]}");
Console.WriteLine($"After F value of a2[0] = {a2[0]}");
Console.WriteLine($"After F length of a2 = {a2.Length}");
