// use csi to interactively run this file
// use #load "ducktyping.csx" to dynamically load defintions in this file
// then try: 
//  var du = new Duck();
//  var hu = new HumanWithDuckInstincts();
//  fly_quack(du);
//  fly_quack(hu);

interface IDuck
{
    void fly();
    void quack();
}

class Duck : IDuck
{
    public void fly()
    {
        Console.WriteLine("Flap");
    }

    public void quack()
    {
        Console.WriteLine("Quack");
    }
}

class HumanWithDuckInstincts : IDuck
{
    public void fly()
    {
        Console.WriteLine("Spreading my arm to flap like a duck");
    }

    public void quack()
    {
        Console.WriteLine("Trying to Quack like a duck");
    }
} 


static void fly_quack(IDuck d)
{
    d.fly();
    d.quack();
}

