//Lab 4 - Wagner Loves Triangles (Acute triangles are my favorite :) Because they are the cutest ones! Ehehehe get it?)

//start main
int userChoice = GetUserChoice(); //priming read

while(userChoice != 3){ //condition check
    RouteEm(userChoice);
    userChoice = GetUserChoice(); //update read
}
//end main

static int GetUserChoice() {
    DisplayMenu();
    string userChoice = Console.ReadLine();
    if(ValidChoice(userChoice)){
        return int.Parse(userChoice);
    }
    else return 0;
}

static void DisplayMenu() {
    Console.Clear();
    System.Console.WriteLine(@"█░╦ ╦╔╗╔╗╔╗╦╔╗╔╗ ─ ╦─╔╗╦–-╦╔╗╔╗—  *────░█ 
█░║║║╠╣║╗║║║╠ ╠-╣ ─║─║║║--║╠ ╚╗—- ***──░█ 
█░╚╩╝╩╩╚╝╩╚╝╚╝╩-╚ ─╚╝╚╝ ╚╝ ╚╝╚╝—--*****░█ 

           ---The Game---
 ");
    System.Console.WriteLine("Enter 1 to Display Full Triangle \nEnter 2 to Display Partial Triangle \nEnter 3 to Exit");

}

static bool ValidChoice(string userInput) {
    if(userInput == "1" || userInput == "2" || userInput == "3") {
        return true;
    }
    else return false;
}

static void GetFull( ){
    //Triangle Size
    Random rnd1 = new Random();
    int num = rnd1.Next(3, 9);

    //Printing the Pattern
    int x, y;
    Console.Clear();
    for (x = 1; x <= num; x++){
        for (y = 1; y <= x; y++){
            Console.Write("o");
        }
        Console.WriteLine("");
    }
    Thread.Sleep(1000);
    PauseMessage();
    Console.ReadLine();
}

static void GetPartial(){
    //Triangle Size
    Random rnd1 = new Random();
    int num = rnd1.Next(3, 9);

    //Blank Spaces
    Random rnd2 = new Random();
    int blank = rnd2.Next(2);

    //Printing the Pattern
    int x, y;
    Console.Clear();
    for (x = 1; x <= num; x++){
        for (y = 1; y <= x; y++){
            if(blank == 1){
            Console.Write("o");
            }
            else{
                Console.Write(" ");
            }
            blank = rnd2.Next(2);
        }
        Console.WriteLine("");
    }
    Thread.Sleep(1000);
    PauseMessage();
    Console.ReadLine();
}

static void sayInvalid(){
    System.Console.WriteLine("Invalid!");
    Thread.Sleep(1000);
}

static void RouteEm(int menuChoice){
    if(menuChoice==1){
        GetFull();
    }
    else if(menuChoice==2){
        GetPartial();
    }
    else if(menuChoice!=3){
        sayInvalid();
}
}

static void PauseMessage(){
    System.Console.WriteLine("Press Enter to Return to Main Menu...");
}