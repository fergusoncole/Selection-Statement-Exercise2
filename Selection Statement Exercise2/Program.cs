Console.WriteLine("Hello! Please tell me your favorite school subject!");
var userInput = Console.ReadLine();

switch (userInput.ToLower())
{
    case "math":
    case "algebra":
    case "mathmatics":
        Console.WriteLine("Math!?!... That's just crazy...But that's awesome!");
        break;

    case "history":
    case "social studies":
        Console.WriteLine("History the most well known mystery.");
        break;

    case "english":
    case "ela":
        Console.WriteLine("English is one of my personal favorites too!");
        break;

    case "writing":
    case "penmanship":
        Console.WriteLine("Writing, my first true love. Writing is where creativity grows.");
        break;

    case "science":
    case "biology":
    case "forensics":
        Console.WriteLine("Ah science, I remember watching so many Bill Nye videos in class.");
        break;
    default: 
            Console.WriteLine("Sorry I didn't include that wonderful subject!");

        break;
}
