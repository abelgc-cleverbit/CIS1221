using System.Collections.Generic;

#region static variables

static string[] students = new [] {"Majed Abualrub",
"Isaac Attard",
"Xiangzong Bi",
"Peter Paul Buttigieg",
"Bradley Camilleri",
"Matthew Camilleri",
"Charlon Curmi",
"James Darmanin",
"Luca De Gabriele",
"Kathleen De Raffaele",
"Maksymilian Derewonko",
"Aleksandar Dimitrov",
"Skye Dinwoodie",
"Nathan Farrugia",
"Kayla Formosa",
"Nicholas Galea",
"Luca Gatt",
"Simona Gauci",
"Alan Grech",
"Neville Grech",
"Jeremy Grima",
"James Francis Mizzi",
"Matteo Naudi",
"Gregory Pavia",
"Esther Portelli",
"Samwel Sammut",
"Mathias Anthony Schembri",
"Christine Scicluna",
"Emma Scicluna",
"Matthew Spiteri",
"Ernest Cachia"};

#endregion

static IEnumerable<string> GetRandomStudents(){
    Random r = new Random(13);
    int last = students.Length; 

    while(last > 0){
        var randomPos = r.Next(0,last);
        yield return students[randomPos];

        last--;
        var tmp = students[last];
        students[last] = students[randomPos];
        students[randomPos] = tmp;
    }

}

static void Main(){
    
    Console.WriteLine("Press Enter to start generating students");
    Console.ReadLine();

    Console.WriteLine();

    foreach(var student in GetRandomStudents()){
        Console.WriteLine($"Next student is: {student}");
        Console.ReadLine();
    }

}