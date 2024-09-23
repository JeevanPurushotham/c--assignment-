using System;

namespace ArrayOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize the array
            int[] numbers = new int[10];
            int count = 0;

            while (true)
            {
                // Display menu options to the user
                Console.WriteLine("\nArray Operations Menu:");
                Console.WriteLine("1. View all numbers");
                Console.WriteLine("2. Add a number");
                Console.WriteLine("3. Remove a number");
                Console.WriteLine("4. Find the maximum number");
                Console.WriteLine("5. Find the minimum number");
                Console.WriteLine("6. Exit");

                Console.Write("Choose an option (1-6): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        // View all numbers
                        Console.WriteLine("\nList of numbers:");
                        if (count == 0)
                        {
                            Console.WriteLine("No numbers stored.");
                        }
                        else
                        {
                            for (int i = 0; i < count; i++)
                            {
                                Console.Write(numbers[i] + " ");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case "2":
                        // Add a number
                        if (count >= numbers.Length)
                        {
                            Console.WriteLine("The array is full. Cannot add more numbers.");
                        }
                        else
                        {
                            Console.Write("Enter a number to add: ");
                            int newNumber;
                            if (int.TryParse(Console.ReadLine(), out newNumber))
                            {
                                numbers[count] = newNumber;
                                count++;
                                Console.WriteLine("Number added.");
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid number.");
                            }
                        }
                        break;

                    case "3":
                        // Remove a number
                        if (count == 0)
                        {
                            Console.WriteLine("No numbers to remove.");
                        }
                        else
                        {
                            Console.Write("Enter the number to remove: ");
                            int removeNumber;
                            if (int.TryParse(Console.ReadLine(), out removeNumber))
                            {
                                int index = Array.IndexOf(numbers, removeNumber, 0, count);
                                if (index != -1)
                                {
                                    for (int i = index; i < count - 1; i++)
                                    {
                                        numbers[i] = numbers[i + 1];
                                    }
                                    count--;
                                    Console.WriteLine("Number removed.");
                                }
                                else
                                {
                                    Console.WriteLine("Number not found.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid number.");
                            }
                        }
                        break;

                    case "4":
                        // Find the maximum number
                        if (count == 0)
                        {
                            Console.WriteLine("No numbers stored.");
                        }
                        else
                        {
                            int max = numbers[0];
                            for (int i = 1; i < count; i++)
                            {
                                if (numbers[i] > max)
                                {
                                    max = numbers[i];
                                }
                            }
                            Console.WriteLine("Maximum number: " + max);
                        }
                        break;

                    case "5":
                        // Find the minimum number
                        if (count == 0)
                        {
                            Console.WriteLine("No numbers stored.");
                        }
                        else
                        {
                            int min = numbers[0];
                            for (int i = 1; i < count; i++)
                            {
                                if (numbers[i] < min)
                                {
                                    min = numbers[i];
                                }
                            }
                            Console.WriteLine("Minimum number: " + min);
                        }
                        break;

                    case "6":
                        // Exit the program
                        Console.WriteLine("Exiting the program...");
                        return;

                    default:
                        Console.WriteLine("Invalid option. Please choose a valid option (1-6).");
                        break;
                }
            }
        }
    }
}
