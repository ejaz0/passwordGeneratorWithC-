using System;

namespace passwordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Skriv med siffror hur långt ditt lösenord ska vara!");
            int antal = Convert.ToInt32(Console.ReadLine());

            
            string password = Generator(antal);
            Console.WriteLine("Ditt lösenord är: " + password);
            Console.ReadLine();
            
        }

        //Funktion för att generera ett lösenord med nummer, bokstäver och special teken
        static string Generator(int antal)
        {

            string password = "";
            
            //Variabel för alla karakäkter möjliga för lösenordet
            char[] letters = "@#!&£$€?ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890".ToCharArray();
            Random r = new Random();

            //Slumpar ihop lösenord, att det ska vara längden som användaren angett
            for(int i = 0; i < antal; i++)
            {
                password += letters[r.Next(0, letters.Length - 1)].ToString();
             
            }

            //Returnar lösenordet
            return password;
        }

            
    
        
    }
}
