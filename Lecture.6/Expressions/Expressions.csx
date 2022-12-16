abstract class Expression
{
    public abstract double Evaluate();
}

class SumExpression:Expression
{
    Expression operand1, operand2;

    public SumExpression(Expression operand1, Expression operand2) {
        this.operand1 = operand1; this.operand2 = operand2;
    }

    public override double Evaluate() {
        return operand1.Evaluate() + operand2.Evaluate();
    }
}

class MultExpression:Expression
{
    Expression operand1, operand2;

    public MultExpression(Expression operand1, Expression operand2)
    {
        this.operand1 = operand1;
        this.operand2 = operand2;
    }

    public override double Evaluate(){
        return operand1.Evaluate() * operand2.Evaluate();
    }
}

class ConstantExpression:Expression
{
    double val;

    public ConstantExpression(double val){
        this.val = val;
    }

    public override double Evaluate(){
        return val;
    }
}



var constant2 = new ConstantExpression(2);
var constant3 = new ConstantExpression(3);
var constant4 = new ConstantExpression(4); 

// 3 + 4 * 2
Expression exp = new SumExpression(constant3, 
                    new MultExpression(constant4,
                        constant2));

Console.WriteLine(exp.Evaluate());

var constantPi = new ConstantExpression(Math.PI);
var constant0 = new ConstantExpression(0);

Expression sum = new SumExpression(constantPi, constant0);
Console.WriteLine(sum.Evaluate());
