Console.Clear();
int counter = 0;
double balance = 5000;


bool CheckingInvite(){
    bool verify = false;
    int counter = 0;
    while (verify == false){
        Console.WriteLine ("Would you like to play?(y/n)");
        string? play = Console.ReadLine();
        if (play is "" || play?.ToLower() == "y") verify = true;
        if (play?.ToLower() == "n"){
            Console.WriteLine ("See you soon! :D");
            Environment.Exit(0);
        }
        if (play is not "" && play?.ToLower() != "y" && play?.ToLower() != "n"){ 
            Console.WriteLine ();
            Console.WriteLine ("Error, enter is acceptable answer");
            counter++;
        }
        if (counter >= 3){
           Console.Clear();
           counter = 0; 
        } 
    }
    return verify;
}

int CheckingBid(double bank){
    bool verify = false;
    int valueBet;
    while (verify == false){
        Console.Write ("Enter bet: ");
        string? bet = Console.ReadLine();
        bool checkType = int.TryParse(bet, out valueBet);
        Console.WriteLine(valueBet);
        if (checkType && valueBet >= 100 && valueBet <= bank){ 
            verify = true;
            return valueBet;
        }else{
            Console.WriteLine();
            Console.WriteLine("Enter as integer");
            valueBet = -1;
        }
        if (valueBet > bank ){
            Console.WriteLine();
            Console.WriteLine("The bet cannot exceed the balance");
        }
        if (valueBet <= 0 ){
            Console.WriteLine();
            Console.WriteLine("The bet cannot be less than zero");
        }
        if (valueBet < 100 && valueBet > 0){
            Console.WriteLine();
            Console.WriteLine("The minimum bet is 100");
        }
        if (bet is ""){
            Console.WriteLine();
            Console.WriteLine("You didn't enter a bet");
        }
    }
    return 0;
}
    

Console.WriteLine("The nickname must be no more than 15 characters long");
Console.Write ("Enter your nickname: ");
string? nickname = Console.ReadLine();
if (nickname is "") nickname = "Bass lover";
else nickname = nickname?.Substring(0, 10);
Console.Clear();

bool confirmationInvite = CheckingInvite();
while (confirmationInvite == true){
    if(counter > 0){
        CheckingInvite(); 
    }
    Console.Clear();
    Console.WriteLine("========== Welcome to Casino Bass Ground ==========");
    Console.Write($"Nickname: {nickname}            Balance: {balance}");

    Console.WriteLine();
    //Console.Write ("Enter bid: ");
    //int bid = Convert.ToInt32 (Console.ReadLine());
    int bid = CheckingBid(balance);

    Console.Write ("Enter digit 1 - 10: ");
    int digit = Convert.ToInt32 (Console.ReadLine());
    Console.WriteLine ();
    Console.WriteLine ("Wait...");
    int number = new Random().Next(1, 11);
    await Task.Delay(1000);
    Console.WriteLine ($"The dropped digit: {number}");
    Console.WriteLine ();
    await Task.Delay(500);

    if (digit == number){
        double prize = Math.Round((bid * 0.3), 2,MidpointRounding.AwayFromZero);
        balance += prize;
        Console.WriteLine($"Congratulations! Your prize: {prize}"); 
        Console.WriteLine("Wait 5 sec for restart");
        await Task.Delay(5000);
    }else{
        Console.WriteLine ("Unfortunately your bid didn't go in");
        Console.WriteLine("Wait 5 sec for restart");
        balance -= bid;
        await Task.Delay(5000);
    }   
counter++;
}
/*
Console.Write ("Enter your nickname: ");
string? nickname = Console.ReadLine();
if (nickname is "") nickname = "Unknown";
nickname = nickname.Substring(0, 10);
 Console.Write($"Nickname: {nickname}");
 
 while (true)
{
    Console.Write("Введите число: ");
    string text = Console.ReadLine();
    if (int.TryParse(text, out int number))
    {
        Console.WriteLine("Вы ввели число {0}", number);
        break;
    }
    Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
}

int i = 27;
Console.WriteLine(i is System.IFormattable);  // output: True

object iBoxed = i;
Console.WriteLine(iBoxed is int);  // output: True
Console.WriteLine(iBoxed is long);  // output: False
*/