﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortune_Teller_with_Methods
{
    class Program
    {
        public static void Main(string[] args)
        {   Start:;        
            Console.WriteLine("Welcome to Fortune Teller! \nPlease follow the prompt. \nType \"quit\" or\"q\" and press enter to exit at anytime.\nType\"restart\" and press enter at anytime to restart.");
            Console.WriteLine("Type your first name, press enter: ");
            string firstName = Console.ReadLine();
            bool restart = (firstName.ToLower() == "restart");
            if (restart)
            {
                goto Start;
            }
            Exit(firstName);
            Console.WriteLine("Type your last name, press enter: ");
            string lastName = Console.ReadLine();
            restart = (lastName.ToLower() == "restart");
            if (restart)
            {
                goto Start;
            }
            Exit(lastName);
            Greeting(firstName, lastName);
            Console.WriteLine("Type your age, press enter: ");
            string ageString = Console.ReadLine();
            restart = (ageString.ToLower() == "restart");
            if (restart)
            {
                goto Start;
            }
            Exit(ageString);
            Console.WriteLine("Type your birth month (as a number), press enter: ");
            string birthMonthString = Console.ReadLine();
            restart = (birthMonthString.ToLower() == "restart");
            if (restart)
            {
                goto Start;
            }
            Exit(birthMonthString);
            Console.WriteLine("Type your favorite letter of the color spectrum ROYGBIV, or \nif you don't know what colors are in ROYGBIV, type help, then press enter:");
            string color = Console.ReadLine();
            restart = (color.ToLower() == "restart");
            if (restart)
            {
                goto Start;
            }
            Exit(color);
            string ride = Transportation(color);
            Console.WriteLine("Type your number of siblings, press enter: ");
            string sibling = Console.ReadLine();
            restart = (sibling.ToLower() == "restart");
            if (restart)
            {
                goto Start;
            }
            Exit(sibling);
            int yearsToRetirement=RetirementTime(ageString);
            string vacationLocation = RetirementLocation(sibling);
            double bankMoney = BankMoney(birthMonthString);            
            Console.WriteLine("\n\nYour Fortune:\n\n" + firstName + " " + lastName + " will retire in " + yearsToRetirement + " years with $" + bankMoney + " in the bank, a vacation\nhome in " + vacationLocation + " and a " + ride + ".");
            JudgeFortune();
        }
        
        static string Greeting(string fName,string lName)
        {
            Console.WriteLine("Greetings," + fName + " " + lName + ", I will tell you your fortune!");
            return ("Greetings," + fName + " " + lName + ", I will tell you your fortune!");
        }
        static int RetirementTime(string ageString)
        {
            int age = int.Parse(ageString);
            int retirement = 99;
            if (age % 2 == 0)
            {
                retirement = 2;
            }
            else
            {
                retirement = 3;
            }
            return retirement;
        }
        static string RetirementLocation(string sibling)
        {
            int siblings = int.Parse(sibling);
            string vacationLocation;
            if (siblings == 0)
            {
                vacationLocation = "Hawaii";
            }
            else if (siblings == 1)
            {
                vacationLocation = "Peru";
            }
            else if (siblings == 2)
            {
                vacationLocation = "New Zealand";
            }
            else if (siblings == 3)
            {
                vacationLocation = "California";
            }
            else if (siblings > 3)
            {
                vacationLocation = "Mexico";
            }
            else
            {
                vacationLocation = "Boondock, South Dakota";
            }
            return vacationLocation;
        }
        static string Transportation(string color)
        {
            string colorLower = color.ToLower();
            if (colorLower == "help")
            {
                Console.WriteLine(" R=red \n O=orange \n Y=yellow \n G=green \n B=blue \n I=indigo \n V=violet \n");
                Console.WriteLine("Enter your favorite letter of the color spectrum ROYGBIV, press enter: ");
                color = Console.ReadLine();
                Exit(color);
                colorLower = color.ToLower();
            }
            char colorChar = char.Parse(colorLower);
            string transportation = "walk";
            switch (colorChar)
            {
                case 'r':
                    transportation = "boat";
                    break;
                case 'o':
                    transportation = "jet";
                    break;
                case 'y':
                    transportation = "hot air balloon";
                    break;
                case 'g':
                    transportation = "sled dog team";
                    break;
                case 'b':
                    transportation = "jeep";
                    break;
                case 'i':
                    transportation = "submarine";
                    break;
                case 'v':
                    transportation = "helicopter";
                    break;
            }
            return transportation;
        }
        static double BankMoney(string birthMonthString)
        {
            int birthMonth = int.Parse(birthMonthString);
            double bankMoney;
            if (birthMonth >= 1 & birthMonth <= 12)
            {
                if (birthMonth <= 4)
                {
                    bankMoney = 10000000.00;
                }
                else if (birthMonth <= 8)
                {
                    bankMoney = 20000000.00;
                }
                else
                {
                    bankMoney = 30000000.00;
                }
            }
            else
            {
                bankMoney = 0.00;
            }
            return bankMoney;
        }
        static void JudgeFortune()
        {
            Console.WriteLine("\nExcellent fortune.  Your future looks bright young grasshopper.\n");
            return;
        }
        static void Exit(string input)
        {
            string input1 = input.ToLower();
            
            if (input1=="quit"||input1=="q")
            {
                Environment.Exit(0);        
            }
            
            return;
        }
    }
}
