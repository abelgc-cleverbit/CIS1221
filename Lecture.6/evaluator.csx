

// use csi to interactively run this file
// use #load "evaluator.csx" to dynamically load defintions in this file
// run
// EvaluateSum(90 + 25)



public static void EvaluateSum(string exp)
{
    // find the position of the 'plus' token
    int plusSignPos = exp.IndexOf("+");

    // split by the position of the 'plus' token
    // parse by every side into an integer
    var operand1 = int.Parse(exp.Substring(0,plusSignPos));
    var operand2 = int.Parse(exp.Substring(plusSignPos+1));

    // convert the expression into a C# expression
    Console.WriteLine(operand1 + operand2);
}


