// use csi to interactively run this file
// use #load "hanoi.csx" to dynamically load defintions in this file
// run by executing: 
//  > hanoi(3, "L", "R", "C")


void hanoi (int discs, string source, string target, string aux)
{
    if(discs == 1)
    {
        Console.WriteLine($"Move top disk from {source} to {target}");
    }
    else
    {    
        hanoi(discs-1, source, aux, target);
        hanoi(1, source, target, null);  //we don't actually need an auxiliary one in this case
        hanoi(discs-1, aux, target, source);
    }
}