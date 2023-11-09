
// use csi to interactively run this file
// use #load "gcd.csx" to dynamically load defintions in this file
// run by executing: 
// use ctrl+c to quit
//  > gcd_it(10,20)
//  > gcd_rec(10,20)
//  > gcd_fun(10,20)


// iterative slow approach using Euclides' original algorithm
int gcd_it(int a, int b)
{
    while (a != 0 && b != 0)
    {
        if (a > b)
            a -= b;
        else
            b -= a;
    }

    return a | b;
}

int gcd_it_with_time(int a, int b){
    long startingTs = Environment.TickCount;
    long previousTs = startingTs;
    long totalTime = 0;
    int result =0;
    int totalRuns = 100;
    for(int i = 0; i< totalRuns; i++){
        result = gcd_it(a,b);
        totalTime += (Environment.TickCount - previousTs);
        previousTs = Environment.TickCount;
    }
    Console.WriteLine((totalTime/totalRuns) + " milliseconds elapsed in average");
    return result; 
}

// recursive approach
int gcd_rec(int a, int b) {
   return b == 0? a : gcd_rec(b, a%b);   
} 

// functional approach
Func<int, int, int> gcd_fun = (a, b) => b == 0? a : gcd_rec(b, a%b); 

