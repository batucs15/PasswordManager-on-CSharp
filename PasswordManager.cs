using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
class Program
{
    static void Main()
    {
        List<string> Passwords = new List<string>();
        string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "password.txt");

        while (true)
        {
            
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("""
                

                

                 ________  ________  _________  ___  ___  ________  ________    _____  ________      
                |\   __  \|\   __  \|\___   ___\\  \|\  \|\   ____\|\   ____\  / __  \|\   ____\     
                \ \  \|\ /\ \  \|\  \|___ \  \_\ \  \\\  \ \  \___|\ \  \___|_|\/_|\  \ \  \___|_    
                 \ \   __  \ \   __  \   \ \  \ \ \  \\\  \ \  \    \ \_____  \|/ \ \  \ \_____  \   
                  \ \  \|\  \ \  \ \  \   \ \  \ \ \  \\\  \ \  \____\|____|\  \   \ \  \|____|\  \  
                   \ \_______\ \__\ \__\   \ \__\ \ \_______\ \_______\____\_\  \   \ \__\____\_\  \ 
                    \|_______|\|__|\|__|    \|__|  \|_______|\|_______|\_________\   \|__|\_________\
                                                                      \|_________|       \|_________|

                









                """);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Welcome to Password Manager.");
            Console.WriteLine("Type 1 to add a password");
            Console.WriteLine("Type 2 to view saved passwords.");
            Console.WriteLine("Type 3 to exit.");

            char choice = Convert.ToChar(Console.ReadLine());
            Console.Clear();

            if (choice == '1')
            {
                Console.Clear();
                Console.WriteLine("Enter the password");
                string PassAdder = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Enter the purpose of the password ex: discord password");
                string Purpose = Console.ReadLine();
                Passwords.Add(PassAdder + "-" + Purpose);
                Console.Clear();
                string lineToSave = $"Password: {PassAdder} - Purpose: {Purpose}";
                File.AppendAllText(filePath, lineToSave + Environment.NewLine);
                Console.WriteLine("Added to your saved passwords.");
            }
            else if (choice == '2')
            {
                Console.Clear();
                if (Passwords.Count == 0)
                {
                    Console.WriteLine("No passwords saved yet.");
                }
                else
                {
                    Console.Clear();
                    string[] allPasswds = File.ReadAllLines(filePath);
                    foreach (string passwordLine in allPasswds)
                    {
                        Console.WriteLine(passwordLine);
                    }
                    Console.ForegroundColor= ConsoleColor.DarkRed;
                    Console.WriteLine("It Will Be Updated Soon");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("\nPress any key to return to the menu...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            else if (choice == '3')
            {
                Console.Clear();
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Enter a valid choice.");
            }
        }
    }
}
