using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace lab_9
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> peopleList = new List<string> {"Andre", "Tywin", "Maria", "Mike"};
            List<string> homeTown = new List<string> { "Ann Arbor", "Jackson", "Benton Harbor", "Saline" };
            List<string> faveFood = new List<string> { "Taco", "Pho", "Peppers", "BBQ" };
            List<string> faveColor = new List<string> { "Blue", "Green", "Yellow", "Orange"};
            


            bool keepGoing = true;
            //call for number
            while(keepGoing == true)
            {

               


                
                Console.WriteLine("Welcome to out C# class. 1.)Would you like to add another student or 2.) learn about current students ?");
                int num1 = int.Parse(Console.ReadLine());
                
                //1
                if(num1== 1)
                {


                    bool doThis = true;
                    while (doThis)
                    {
                        Console.WriteLine("What is the name of the student you wish to enter ?");
                        string newName = Console.ReadLine();
                        //try catch must go after each input because the program runs top to bottom
                        try
                        {
                            lab_9.CheckChar(newName);
                            doThis = false;
                        }
                        catch (Exception NotValid)
                        {

                            {
                                Console.WriteLine(NotValid.Message);
                                doThis = true;
                            }
                        }

                        
                        Console.WriteLine("Where is there hometown ?");
                        string newName1 = Console.ReadLine();
                        try
                        {
                            lab_9.CheckChar(newName1);
                        }
                        catch (Exception NotValid)
                        {
                            Console.WriteLine(NotValid.Message);
                        }

                        Console.WriteLine($"What is {newName}'s favorite food");
                        string newName2 = Console.ReadLine();
                        try
                        {
                            lab_9.CheckChar(newName2);
                        }
                        catch (Exception NotValid)
                        {
                            Console.WriteLine(NotValid.Message);
                        }

                        Console.WriteLine($" Lastly what is {newName}'s favorite color?");
                        string newName3 = Console.ReadLine();
                        faveColor.Add(newName3);
                        try
                        {
                            lab_9.CheckChar(newName3);
                        }
                        catch (Exception NotValid)
                        {
                            Console.WriteLine(NotValid.Message);
                        }

                        Console.WriteLine("Is this information correct? (y/n): ");
                        Console.WriteLine($" Student name: {newName}\nHomeTown: {newName1}\nFavorite Food: {newName2}\nFavorite Color: {newName3}");
                        string answer = Console.ReadLine();

                        if (answer.ToLower() == "y")
                        {
                            peopleList.Add(newName);
                            homeTown.Add(newName1);
                            faveFood.Add(newName2);
                            faveColor.Add(newName3);
                            doThis = false;
                        }
                        else
                        {
                            Console.WriteLine("Please re-enter information.");
                        }
                        
                    }
                }
                else if (num1 == 2)
                {

                    Console.WriteLine("What student would you like to learn about ?");
                    num1 = int.Parse(Console.ReadLine());

                    try
                    {
                        lab_9.GetFirstNumber(num1);

                    }
                    catch (Exception LessMoreThan)
                    {
                        Console.WriteLine(LessMoreThan.Message);

                    }

                        Console.WriteLine($" Student 1 is {peopleList[num1 -1]} \nWhat would you like to know about {peopleList[num1 -1]} (type food or homewtown)");
                        string word = Console.ReadLine();

                        
                        while(word.ToLower() != "hometown" || word.ToLower() != "food")
                        {
                            Console.WriteLine("the data does not exist please try again . enter food or hometown.");
                            word = Console.ReadLine();
                        }
                    if (word.ToLower() == "hometown")
                    {
                        Console.WriteLine($"{peopleList[num1 - 1]}'s  hometown is {homeTown[num1 - 1]}.\n Would you like to know more ? (y/n)");
                        string yesno = Console.ReadLine();
                        if (yesno == "y")
                        {

                        }
                    }
                    else if (word.ToLower() == "food")
                    {
                        Console.WriteLine($" {peopleList[num1 - 1]}'s favorite food is {faveFood[num1 - 1]}. \n Would you like to know more ?");
                        string yesno = Console.ReadLine();
                        if (yesno == "y")
                        {

                        }
                    }
                    
                }
                Console.WriteLine("Do you want to continue ? (y/n)");
                string response = Console.ReadLine();
                if(response.ToLower() == "n")
                {
                    keepGoing = false;
                }

            }
        }
    }
}
