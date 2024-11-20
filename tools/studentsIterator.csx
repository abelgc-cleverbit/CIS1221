using System.Collections.Generic;

#region static variables

static string[] students = new [] {
"Kieran Agius",
"Akinjide Sahib Akinyemi",
"Isaac Azzopardi",
"Gianluca Baldacchino",
"Luke Bigeni",
"Jean Bonnici",
"Isaac Borg",
"Josman Cauchi",
"Daniel Ciantar",
"Luke Coppini",
"Samuel Falzon",
"Chantelle Farrugia",
"Michael Galea",
"Tanya Dimitrova Gitsova",
"Justin Grech",
"Zselyke Boroka Kis",
"Dariusz Krych",
"Nathan Micallef",
"Dale Alexander Monaghan",
"Isaac Paul Piscopo",
"Victor Rapa",
"Christian Peter Scerri",
"Bjorn Tanti",
"Owen Vassallo"
};

#endregion

static IEnumerable<string> GetRandomStudents(){
    Random r = new Random(25);
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