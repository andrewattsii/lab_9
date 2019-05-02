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

               


                beg:
                Console.WriteLine("Welcome to out C# class. 1.)Would you like to add another student or 2.) learn about current students ?");
                int num1 = int.Parse(Console.ReadLine());
                string char1 = Console.ReadLine();
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
                        }
                        else
                        {
                            Console.WriteLine("Please re-enter information.");
                        }

                    }
                }
                else if (char1 == "b")
                {


                    try
                    {
                        lab_9.GetFirstNumber(num1);

                    }
                    catch (Exception LessMoreThan)
                    {
                        Console.WriteLine(LessMoreThan.Message);

                    }




                    //1[0]
                    if (num1 == 1)
                    {
                        Console.WriteLine($" Student 1 is {peopleList[0]} \nWhat would you like to know about {peopleList[0]} (type food or homewtown)");
                        string word = Console.ReadLine();


                        do
                        {
                            if (word.ToLower() == "hometown")
                            {
                                Console.WriteLine($"{peopleList[0]}'s  hometown is {homeTown[0]}.\n Would you like to know more ? (y/n)");
                                string yesno = Console.ReadLine();
                                if (yesno == "y")
                                {
                                    goto beg;
                                }
                            }
                            else if (word.ToLower() == "food")
                            {
                                Console.WriteLine($" {peopleList[0]}'s favorite food is {faveFood[0]}. \n Would you like to know more ?");
                                string yesno = Console.ReadLine();
                                if (yesno == "y")
                                {
                                    goto beg;
                                }
                            }

                            Console.WriteLine("the data does not exist please try again . enter food or hometown.");

                        }
                        while (word != "hometown" || word != "food");
                        {


                        }

                    }



                    //2[1]


                    else if (num1 == 2)
                    {
                        Console.WriteLine($" Student 2 is {peopleList[1]} \nWhat would you like to know about {peopleList[1]}");
                        string word = Console.ReadLine();


                        if (word == "hometown")
                        {
                            Console.WriteLine($"{peopleList[1]}'s  hometown is {homeTown[1]}");
                        }
                        else if (word == "food")
                        {
                            Console.WriteLine($"{peopleList[1]}'s favorite food is {faveFood[1]}. Would you like to know more (y/n)");
                            string yesno = Console.ReadLine();
                            if (yesno == "y")
                            {
                                goto beg;
                            }
                        }
                    }
                    //3[2]
                    else if (num1 == 3)
                    {
                        Console.WriteLine($" Student 1 is {peopleList[2]} \nWhat would you like to know about {peopleList[2]}");
                        string word = Console.ReadLine();


                        if (word == "hometown")
                        {
                            Console.WriteLine($"{peopleList[2]}'s  hometown is {homeTown[2]}");
                        }
                        else if (word == "food")
                        {
                            Console.WriteLine($"{peopleList[2]}'s favorite food is {faveFood[2]}. Would you like to know more (y/n) ?");
                            string yesno = Console.ReadLine();
                            if (yesno == "y")
                            {
                                goto beg;
                            }
                        }
                    }
                    //4[3]
                    else if (num1 == 4)
                    {
                        Console.WriteLine($" Student 1 is {peopleList[3]} \nWhat would you like to know about {peopleList[3]}");
                        string word = Console.ReadLine();


                        if (word == "hometown")
                        {
                            Console.WriteLine($"{peopleList[3]}'s  hometown is {homeTown[3]}");
                        }
                        else if (word == "food")
                        {
                            Console.WriteLine($"{peopleList[3]}'s favorite food is {faveFood[3]}. Would you like to know more (y/n) ?");
                            string yesno = Console.ReadLine();
                            if (yesno == "y")
                            {
                                goto beg;
                            }
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
