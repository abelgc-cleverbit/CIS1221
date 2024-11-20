// use csi to interactively run this file
// use #load "memory.csx" to dynamically load defintions in this file


//Example using pointers in c#

//the following example make use of the "unsafe" directive in C#: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/unsafe
//this is needed because the memory management is automatically handled by the compiler
//if the user wants to modify or decide the behavior around it, it needs to "take responsibility"
//hence declaring the code as unsafe
unsafe
{
    var v1 = 16;
    var v2 = 16;
    var v3 = v1;  


     IntPtr x = (IntPtr)(&v1);
     Console.WriteLine(x); //prints the address of value hold in v1
     Console.WriteLine((IntPtr)(&v2));  //prints the address of value hold in v2

     Console.WriteLine(v1 == v2); //compares values
     Console.WriteLine(object.ReferenceEquals(v1,v2)); //compares references v1 and v2
     
     Console.WriteLine((IntPtr)(&v3)); //compares references v1 and v3
     Console.WriteLine(object.ReferenceEquals(v1,v3));

}

