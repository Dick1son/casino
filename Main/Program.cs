int counter = 0;
double balance = 5000;

Console.Write ("Enter your nickname: ");
string? nickname = Console.ReadLine();
string nickname1 = nickname ?? "Unknown";
//if (nickname is null) nickname = ("Unknown");
Console.Clear();

Console.WriteLine ("Would you like to play?(y/n)");
string? play = Console.ReadLine();
if (play is null) play = ("y");
Console.Clear();

if (play.ToLower() == "y"){
    while (play.ToLower() == "y"){
        if(counter > 0){
            Console.Clear();
            Console.WriteLine ("Would you like to play?(y/n)");
            play = Console.ReadLine();
            if (play is null) play = ("y");
            if (play.ToLower() == "n"){
                Console.WriteLine ("See you soon! :P");
                Environment.Exit(0);
            }  
        }
        Console.Clear();
        Console.WriteLine("========== Welcome to Casino Bass Ground ==========");
        Console.Write($"Nickname: {nickname1}            Balance: {balance}");
        Console.WriteLine();
        Console.Write ("Enter bid: ");
        int stavka = Convert.ToInt32 (Console.ReadLine());
        Console.Write ("Enter digit 1 - 10: ");
        int digit = Convert.ToInt32 (Console.ReadLine());
        Console.WriteLine ();
        Console.WriteLine ("Wait...");
        int number = new Random().Next(1, 11);
        await Task.Delay(1000);
        Console.WriteLine ($"The dropped digit: {number}");
        await Task.Delay(1000);
        if (digit == number){
            double prize = Math.Round((stavka * 0.3), 2,MidpointRounding.AwayFromZero);
            balance += prize;
            Console.WriteLine($"Congratulations! Your prize: {prize}"); 
            Console.WriteLine("Wait 5 sec for restart");
            await Task.Delay(5000);
        }else{
            Console.WriteLine ("Unfortunately your bid didn't go in");
            Console.WriteLine("Wait 5 sec for restart");
            balance -= stavka;
            await Task.Delay(5000);
        }
    counter++;
    }
}


/*

 void PrintUpper(string? text)
{
    if (text is  null) return;
    Console.WriteLine(text.ToUpper());
}

    Console.WriteLine("Hello World");
    string text1 = Console.ReadLine();
    PrintUpper(text1);
*/