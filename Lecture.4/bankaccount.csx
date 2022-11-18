class Circle{
    public float X;
    public float Y;
    public float Radius;

    public float Area{
        get{ 
            return Math.PI * radius * radius;
        }
    }
}


static void Main()
{
  float x,y,radius;
  Circle c; 
  /* initialise x,y and radius somehow*/
  c = new Circle(x,y,radius);

  Console.WriteLine(c.Area);
}