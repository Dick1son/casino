Console.Clear();
int counter = 0;
double balance = 5000;
bool verify = false;

bool Invite(){
    while (verify == false){
        Console.WriteLine ("Would you like to play?(y/n)");
        string? play = Console.ReadLine();
        if (play is "" || play.ToLower() == "y") verify = true;
        if (play.ToLower() == "n"){
            Console.WriteLine ("See you soon! :D");
            Environment.Exit(0);
        }
        if (play is not "" && play.ToLower() != "y" && play.ToLower() != "n") 
            Console.WriteLine ("Error, enter is acceptable answer");
            //await Task.Delay(2000);
       // Console.Clear();
    }
    return verify;
}

Console.WriteLine("The nickname must be no more than 10 characters long");
Console.Write ("Enter your nickname: ");
string? nickname = Console.ReadLine();
if (nickname is "") nickname = "Unknown";
Console.Clear();

Invite();

if (verify == true){
    while (verify == true){
        if(counter > 0){
            Invite(); 
        }
        Console.Clear();
        Console.WriteLine("========== Welcome to Casino Bass Ground ==========");
        Console.Write($"Nickname: {nickname}            Balance: {balance}");
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