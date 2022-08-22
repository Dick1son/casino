string y_play ("y");
string n_play ("n");
int balance = 5000;
int stavka, number, prize, drop;
int counter = 0;
//int a = 1; 
int i;
bool verify = false;
Random rnd = new Random();

Console.Write ("Enter your nickname: ");
string? nickname = Console.ReadLine();
if (nickname != null){
    Console.Clear();
    Console.Write ("Would you like to play?(y/n)");
    string? play = Console.ReadLine();
        if (play != null) verify = true;
        else
            Console.WriteLine("You didn't answer");
}else
    Console.WriteLine("You didn't enter a nickname");


cin >> play;
cout << ("\e[1;1H\e[2J");
/*
while(play == y_play)
    {
        if(counter >= 1){
            cout << ("\e[1;1H\e[2J");
            cout << "Would you like to play more?(y/n)" << endl;
            cin >> play;
        }
        cout << ("\e[1;1H\e[2J");
        cout << "========== Welcome to Casino Bass Ground ==========" << endl;
        cout << "Nickname: " << nick << "    " << "Balance: " << balance << "$" << endl;
        if(play == y_play){
            cout << "Enter bid: ";
            cin >> stavka;
            
            while(stavka > balance){
            cout << "Error" << endl;
            cout << "Enter bid: ";
            cin >> stavka;
            }
        
            cout << "Enter drop 1 - 10: ";
            cin >> drop;
            cout << endl; 
            cout << "Wait..." << endl;
            number = GetRandomNumber(0, 10);
            cout << "Drop: " << number << endl;
            if (drop == number){
                prize = stavka * 0.3;
                cout << "Congratulations! Your prize: " << prize << endl << "Wait 5 sec for restart" << endl;
                balance += prize;
                this_thread::sleep_for(chrono::seconds(3));
            }else{
                cout << "Unfortunately your bid didn't go in \nWait 5 sec for restart" << endl;
                balance -= stavka;
                this_thread::sleep_for(chrono::seconds(3));
            }
            
        }
        counter++;
    }
    while(play == n_play){
        cout << "See you soon :)";
        return 0;
    }
}
