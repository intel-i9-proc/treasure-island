
Console.WriteLine(@"*******************************************************************************
          |                   |                  |                     |
 _________|________________.=""""_;=.______________|_____________________|_______
|                   |  ,-""_,=""""     `""=.|                  |
|___________________|__""=._o`""-._        `""=.______________|___________________
          |                `""=._o`""=._      _`""=._                     |
 _________|_____________________:=._o ""=._.""_.-=""'""=.__________________|_______
|                   |    __.--"" , ; `""=._o."" ,-""""""-._ "".   |
|___________________|_._""  ,. .` ` `` ,  `""-._""-._   "". '__|___________________
          |           |o`""=._` , ""` `; ."". ,  ""-._""-._; ;              |
 _________|___________| ;`-.o`""=._; ."" ` '`.""\` . ""-._ /_______________|_______
|                   | |o;    `""-.o`""=._``  '` "" ,__.--o;   |
|___________________|_| ;     (#) `-.o `""=.`_.--""_o.-; ;___|___________________
____/______/______/___|o;._    ""      `"".o|o_.--""    ;o;____/______/______/____
/______/______/______/_""=._o--._        ; | ;        ; ;/______/______/______/_
____/______/______/______/__""=._o--._   ;o|o;     _._;o;____/______/______/____
/______/______/______/______/____""=._o._; | ;_.--""o.--""_/______/______/______/_
____/______/______/______/______/_____""=.o|o_.--""""___/______/______/______/____
/______/______/______/______/______/______/______/______/______/______/[TomekK]
*******************************************************************************");

Console.WriteLine("***************************Welcome to Treasure Island!!!***************************");
string user_input;

/* First try
if (user_input == "left")
{
    Console.WriteLine("You've come to a lake. There is an island in the middle of the lake.\n" +
        "Type 'wait' to wait for a boat. Type 'swim' to swim across. ");
    if (user_input == "wait")
    {
        Console.WriteLine("You arrive at the island unharmed. There is a house with 3 doors. \n" +
            "One red, one yellow and one blue. Which colour do you choose?");
        if (user_input == "yellow")
        {
            Console.WriteLine("You have found the treasure!!!\n" +
                "Congratulations!");
        }
    }

}
else
{
    Console.WriteLine("You fell into a hole\n" +
    "Game Over!");
}
*/

// Second try

Console.WriteLine("You're on a mission to find the treasure.\n" +
"You're at a cross road. Where do you want to go? \n" + "Type 'left' or 'right'");

user_input = Console.ReadLine();

if (user_input == "left")
{
    Console.WriteLine("You've come to a lake. There is an island in the middle of the lake.\n" +
        "Type 'wait' to wait for a boat. Type 'swim' to swim across. ");
    user_input = Console.ReadLine();
    if (user_input == "wait")
    {
        Console.WriteLine("You've arrived at the island unharmed. There is a house with 3 doors. \n" +
            "One red, one yellow and one blue. Which colour do you choose?");
        user_input = Console.ReadLine();
        if (user_input == "yellow")
        {
            Console.WriteLine("You've found the treasure\n" +
                "Congratulations!!!");
        }
        else if (user_input == "red")
        {
            Console.WriteLine("You died due to TUNG TUNG SAHUR eating you!\n" +
                "Game over!");
        }
        else
        {
            Console.WriteLine("You've died, because of a snake eating you alive!\n" +
                "Game over!");
        }
    }
    else
    {
        Console.WriteLine("You've been eaten by shark!\n" +
            "Game over!");
    }
}
else
{
    Console.WriteLine("You've fell into a lake."); 
}




Console.ReadKey(); 