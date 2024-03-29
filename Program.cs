﻿/*
 *    Author:     Christopher Lopez
 *    Course:     COMP-003A
 *    Purpose:    Code for a new patient for the health app.
 */
namespace HealthApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // User Input Section
            Console.WriteLine("********************************");
            Console.WriteLine("Avenal Clinic - New Patient Form");
            Console.WriteLine("********************************");

            // First Name
            string firstName;
            do
            {
                Console.Write("First Name: ");
                firstName = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(firstName) || ContainsNumberOrSpecialCharacter(firstName));

            // Last Name
            string lastName;
            do
            {
                Console.Write("Last Name: ");
                lastName = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(lastName) || ContainsNumberOrSpecialCharacter(lastName));

            // Birth Year
            int birthYear;
            do
            {
                Console.Write("Birth Year: ");
                string birthYearInput = Console.ReadLine();
                if (int.TryParse(birthYearInput, out birthYear) && birthYear >= 1900 && birthYear <= DateTime.Now.Year)
                {
                    break;
                }
                Console.WriteLine("Invalid birth year. Please enter a valid year.");
            } while (true);

            // Gender
            char gender;
            do
            {
                Console.Write("Gender (M/F/O): ");
                string genderInput = Console.ReadLine();
                if (char.TryParse(genderInput, out gender) && (gender == 'M' || gender == 'F' || gender == 'O'))
                {
                    break;
                }
                Console.WriteLine("Invalid gender. Please enter 'M', 'F', or 'O'.");
            } while (true);

            // Questionnaire
            List<string> responses = new List<string>();

            Console.WriteLine("");
            Console.WriteLine("******************************************");
            Console.WriteLine("Please answer the following questionnaire");
            Console.WriteLine("******************************************");

            // Question 1
            Console.Write("Date of appointment MM/DD/YYYY: ");
            string response1 = Console.ReadLine();
            responses.Add(response1);

            // Question 2
            Console.Write("Primary care provider (if applicable): ");
            string response2 = Console.ReadLine();
            responses.Add(response2);

            // Question 3
            Console.Write("Insurance provider (if applicable): ");
            string response3 = Console.ReadLine();
            responses.Add(response3);

            // Contact information title
            Console.WriteLine("");
            Console.WriteLine("******************************************");
            Console.WriteLine("            Contact information           ");
            Console.WriteLine("******************************************");

            // Question 4
            Console.Write("Housing address: ");
            string response4 = Console.ReadLine();
            responses.Add(response4);

            // Question 5
            Console.Write("Email address: ");
            string response5 = Console.ReadLine();
            responses.Add(response5);

            // Question 6
            Console.Write("Phone number: ");
            string response6 = Console.ReadLine();
            responses.Add(response6);

            // Emergency contact information title
            Console.WriteLine("");
            Console.WriteLine("******************************************");
            Console.WriteLine("       Emergency contact information      ");
            Console.WriteLine("******************************************");

            // Question 7
            Console.Write("Emergency contact first & last name: ");
            string response7 = Console.ReadLine();
            responses.Add(response7);

            // Question 8
            Console.Write("Emergency contact phone number: ");
            string response8 = Console.ReadLine();
            responses.Add(response8);

            // Symptoms title
            Console.WriteLine("");
            Console.WriteLine("******************************************");
            Console.WriteLine("                 Symptoms                 ");
            Console.WriteLine("******************************************");

            // Question 9
            Console.Write("Nausea Y/N: ");
            string response9 = Console.ReadLine();
            responses.Add(response9);

            // Question 10
            Console.Write("Stomach pain Y/N: ");
            string response10 = Console.ReadLine();
            responses.Add(response10);

            // Question 11
            Console.Write("Constipation Y/N: ");
            string response11 = Console.ReadLine();
            responses.Add(response11);

            // Question 12
            Console.Write("Blood in stool Y/N: ");
            string response12 = Console.ReadLine();
            responses.Add(response12);

            // Question 13
            Console.Write("Vomiting Y/N: ");
            string response13 = Console.ReadLine();
            responses.Add(response13);

            // Question 14
            Console.Write("Fever or chills Y/N: ");
            string response14 = Console.ReadLine();
            responses.Add(response14);

            // Question 15
            Console.Write("Fatigue or weakness Y/N: ");
            string response15 = Console.ReadLine();
            responses.Add(response15);

            // Question 16
            Console.Write("Unexplained weight loss or gain Y/N: ");
            string response16 = Console.ReadLine();
            responses.Add(response16);

            // Question 17
            Console.Write("Changes in appetite Y/N: ");
            string response17 = Console.ReadLine();
            responses.Add(response17);

            // Question 18
            Console.Write("Persistent pain or discomfort Y/N: ");
            string response18 = Console.ReadLine();
            responses.Add(response18);

            // Question 19
            Console.Write("Shortness of breath or difficulty breathing Y/N: ");
            string response19 = Console.ReadLine();
            responses.Add(response19);

            // Question 20
            Console.Write("Chest pain or tightness Y/N: ");
            string response20 = Console.ReadLine();
            responses.Add(response20);

            // Question 21
            Console.Write("Palpitations or irregular heartbeats Y/N: ");
            string response21 = Console.ReadLine();
            responses.Add(response21);

            // Question 22
            Console.Write("Dizziness or lightheadedness Y/N: ");
            string response22 = Console.ReadLine();
            responses.Add(response22);

            // Question 23
            Console.Write("Persistent cough or coughing up blood Y/N: ");
            string response23 = Console.ReadLine();
            responses.Add(response23);

            // Question 24
            Console.Write("Difficulty swallowing Y/N: ");
            string response24 = Console.ReadLine();
            responses.Add(response24);

            // Question 25
            Console.Write("Changes in urination (frequency, urgency, pain, blood in urine) Y/N: ");
            string response25 = Console.ReadLine();
            responses.Add(response25);

            // Question 26
            Console.Write("Skin rashes, lesions, or changes in moles Y/N: ");
            string response26 = Console.ReadLine();
            responses.Add(response26);

            // Question 27
            Console.Write("Swelling or lumps in the body Y/N: ");
            string response27 = Console.ReadLine();
            responses.Add(response27);

            // Question 28
            Console.Write("Joint pain or stiffness Y/N: ");
            string response28 = Console.ReadLine();
            responses.Add(response28);

            // Question 29
            Console.Write("Headaches or migraines Y/N: ");
            string response29 = Console.ReadLine();
            responses.Add(response29);

            // Question 30
            Console.Write("Changes in vision or hearing Y/N: ");
            string response30 = Console.ReadLine();
            responses.Add(response30);

            // Question 31
            Console.Write("Mood changes, depression, or anxiety Y/N: ");
            string response31 = Console.ReadLine();
            responses.Add(response31);

            // Question 32
            Console.Write("Sleep disturbances or insomnia Y/N: ");
            string response32 = Console.ReadLine();
            responses.Add(response32);

            // Profile Summary Section
            Console.WriteLine();
            Console.WriteLine("                           Profile Summary                         ");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("Full Name: " + lastName + ", " + firstName);
            Console.WriteLine("Age: " + CalculateAge(birthYear));
            Console.WriteLine("Gender: " + GetGenderDescription(gender));
            Console.WriteLine("                       Questionnaire Responses                     ");
            Console.WriteLine("-------------------------------------------------------------------");
            for (int i = 0; i < responses.Count; i++)
            {
                Console.WriteLine("Question " + (i + 1) + ": " + responses[i]);
            }

            Console.ReadLine();
        }

        // Checks if the input contains a number or special character
        static bool ContainsNumberOrSpecialCharacter(string input)
        {
            foreach (char c in input)
            {
                if (char.IsDigit(c) || char.IsPunctuation(c) || char.IsSymbol(c))
                {
                    return true;
                }
            }
            return false;
        }

        // Calculates the age based on the birth year and the current year
        static int CalculateAge(int birthYear)
        {
            int currentYear = DateTime.Now.Year;
            return currentYear - birthYear;
        }

        // Returns the gender description based on the gender code
        static string GetGenderDescription(char gender)
        {
            switch (gender)
            {
                case 'M':
                    return "Male";
                case 'F':
                    return "Female";
                case 'O':
                    return "Other";
                default:
                    return "Unknown";
            }
        }
    }
}