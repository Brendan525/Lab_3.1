using System;

namespace Lab_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool redo = true, redo2 = true;
            string entry, entry2, entry3;
            int inout;

            string[,] students =
            {
                {"Brendan", "Starburst", "Closing Coordinator" },
                {"Xavier", "Skittles", "VA Assignor" },
                {"Charles", "Nerds", "Software Engineer" }
            };

             Console.WriteLine("Which student do you want to know about? Enter a number between 1 and 3 or enter 4 to see all the names");

                entry = Console.ReadLine();

                int input = int.Parse(entry);

                do
                {
                if (input == 1)
                {
                    Console.WriteLine($"Student 1 is {students[0, 0]}. What would you like to know about {students[0, 0]}? (Enter \"favorite candy\" or \"previous title\" ");

                    entry2 = Console.ReadLine();

                    if (entry2 == "favorite candy")
                    {
                        Console.WriteLine($"{students[0, 0]}'s favorite candy is {students[0, 1]}");

                        Console.WriteLine("Would you like to learn more about the current student, another student or quit? Please enter \"current\", \"another\", or quit");

                        entry3 = Console.ReadLine();

                        if (entry3 == "another")
                        {
                            Console.WriteLine("Which student do you want to know about? Enter a number between 1 and 3");

                            entry = Console.ReadLine();

                            input = int.Parse(entry);
                        }

                        else if (entry3 == "quit")
                        {
                            Console.WriteLine("Thanks!");
                            break;
                        }

                        else if (entry3 == "current")
                        {
                            Console.WriteLine($"{students[0, 0]}'s previous title was {students[0, 2]}");
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Invalid input. I am closing down. Thanks");
                        }
                    }

                    else if (entry2 == "previous title")
                    {
                        Console.WriteLine($"{students[0, 0]}'s previous title was {students[0, 2]}");

                        Console.WriteLine("Would you like to learn more about the current student, another student or quit? Please enter \"current\", \"another\", or quit");

                        entry3 = Console.ReadLine();

                        if (entry3 == "another")
                        {
                            Console.WriteLine("Which student do you want to know about? Enter a number between 1 and 3");

                            entry = Console.ReadLine();

                            input = int.Parse(entry);
                        }

                        else if (entry3 == "quit")
                        {
                            Console.WriteLine("Thanks!");
                            break;
                        }

                        else if (entry3 == "current")
                        {
                            Console.WriteLine($"{students[0, 0]}'s favorite candy is {students[0, 1]}");
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Invalid input. I am closing down. Thanks");
                        }
                    }

                    else if (entry2 != "favorite candy" | entry2 != "previous title")
                    {
                        Console.WriteLine("That data does not exist. Please try again. (Enter \"favorite candy\" or \"previous title\" ");
                        redo = false;
                    }
                }

                else if (input == 2)
                {
                    Console.WriteLine($"Student 2 is {students[1, 0]}. What would you like to know about {students[1, 0]}? (Enter \"favorite candy\" or \"previous title\" ");

                    entry2 = Console.ReadLine();

                    if (entry2 == "favorite candy")
                    {
                        Console.WriteLine($"{students[1, 0]}'s favorite candy is {students[1, 1]}");

                        Console.WriteLine("Would you like to learn more about the current student, another student or quit? Please enter \"current\", \"another\", or quit");

                        entry3 = Console.ReadLine();

                        if (entry3 == "another")
                        {
                            Console.WriteLine("Which student do you want to know about? Enter a number between 1 and 3");

                            entry = Console.ReadLine();

                            input = int.Parse(entry);
                        }

                        else if (entry3 == "quit")
                        {
                            Console.WriteLine("Thanks!");
                            break;
                        }

                        else if (entry3 == "current")
                        {
                            Console.WriteLine($"{students[1, 0]}'s previous title was {students[1, 2]}");
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Invalid input. I am closing down. Thanks");
                        }
                    }

                    else if (entry2 == "previous title")
                    {
                        Console.WriteLine($"{students[1, 0]}'s previous title was {students[1, 2]}");

                        Console.WriteLine("Would you like to learn more about the current student, another student or quit? Please enter \"current\", \"another\", or quit");

                        entry3 = Console.ReadLine();

                        if (entry3 == "another")
                        {
                            Console.WriteLine("Which student do you want to know about? Enter a number between 1 and 3");

                            entry = Console.ReadLine();

                            input = int.Parse(entry);
                        }

                        else if (entry3 == "quit")
                        {
                            Console.WriteLine("Thanks!");
                            break;
                        }

                        else if (entry3 == "current")
                        {
                            Console.WriteLine($"{students[1, 0]}'s favorite candy is {students[1, 1]}");
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Invalid input. I am closing down. Thanks");
                        }
                    }

                    else if (entry2 != "favorite candy" | entry2 != "previous title")
                    {
                        Console.WriteLine("That data does not exist. Please try again. (Enter \"favorite candy\" or \"previous title\" ");
                        redo = false;
                    }
                }

                else if (input == 3)
                {
                    Console.WriteLine($"Student 3 is {students[2, 0]}. What would you like to know about {students[2, 0]}? (Enter \"favorite candy\" or \"previous title\" ");

                    entry2 = Console.ReadLine();

                    if (entry2 == "favorite candy")
                    {
                        Console.WriteLine($"{students[2, 0]}'s favorite candy is {students[2, 1]}");

                        Console.WriteLine("Would you like to learn more about the current student, another student or quit? Please enter \"current\", \"another\", or quit");

                        entry3 = Console.ReadLine();

                        if (entry3 == "another")
                        {
                            Console.WriteLine("Which student do you want to know about? Enter a number between 1 and 3");

                            entry = Console.ReadLine();

                            input = int.Parse(entry);
                        }

                        else if (entry3 == "quit")
                        {
                            Console.WriteLine("Thanks!");
                            break;
                        }

                        else if (entry3 == "current")
                        {
                            Console.WriteLine($"{students[2, 0]}'s previous title was {students[2, 2]}");
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Invalid input. I am closing down. Thanks");
                        }
                    }

                    else if (entry2 == "previous title")
                    {
                        Console.WriteLine($"{students[2, 0]}'s previous title was {students[2, 2]}");

                        Console.WriteLine("Would you like to learn more about the current student, another student or quit? Please enter \"current\", \"another\", or quit");

                        entry3 = Console.ReadLine();

                        if (entry3 == "another")
                        {
                            Console.WriteLine("Which student do you want to know about? Enter a number between 1 and 3");

                            entry = Console.ReadLine();

                            input = int.Parse(entry);
                        }

                        else if (entry3 == "quit")
                        {
                            Console.WriteLine("Thanks!");
                            break;
                        }

                        else if (entry3 == "current")
                        {
                            Console.WriteLine($"{students[2, 0]}'s favorite candy is {students[2, 1]}");
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Invalid input. I am closing down. Thanks");
                        }
                    }

                    else if (entry2 != "favorite candy" | entry2 != "previous title")
                    {
                        Console.WriteLine("That data does not exist. Please try again. (Enter \"favorite candy\" or \"previous title\" ");
                        redo = false;
                    }
                }

                else if (input == 4)
                {
                    Console.WriteLine("Student 1 is " + students[0,0]);
                    Console.WriteLine("Student 2 is " + students[1, 0]);
                    Console.WriteLine("Student 3 is " + students[2, 0]);
                    break;
                }

            } while (redo = true);

        }

    }
}
