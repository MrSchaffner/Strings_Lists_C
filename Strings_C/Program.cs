using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {

        ArrayProgram();

     


        }


    private static void StringsProgram()
    {
        //Strings
        string name = "Wilburton";
        string midName = "huey";
        string lastName = "Billowbee";

        string fullName = name + " " + midName + " " + lastName;

        string upperName = name.ToUpper();

        StringBuilder sb = new StringBuilder();

        sb.Append(fullName);
        sb.Append(" Is about to learn");
        sb.Append(" the meaning of love.");

        Console.WriteLine(sb);
        Console.Read();

        //name.EndsWith("n");
        //name.Contains("bur");
    }

    private static void ArrayProgram()
    {
        bool running = true;

        //Arrays
        string[] animalsArray = { "flipper", "hopper", "buzzy", "stinger", "furry", "purry", "nutters" }; //length must be declared

        Console.WriteLine("Enter a number between 0 and " + (animalsArray.Length - 1)+ " to get an entry in the array");
        byte enteredNum = Convert.ToByte(Console.ReadLine());
        if (enteredNum <= animalsArray.Length - 1)
            Console.WriteLine(animalsArray[enteredNum]);
        else
            Console.WriteLine("Out of Range");

        if (!running) {
            endMessage();
            return;
        }
        else
        {
            ArrayProgram();
        }

    }

    private static void ListProgram()
    {
        //Lists

        List<int> intList = new List<int>();
        intList.Add(4);
        intList.Add(5);
        intList.Add(4);
        intList.Remove(4);

        Console.WriteLine(intList[0]);

        endMessage();
    }

    private static void endMessage()
    {
        Console.WriteLine("=============================================================");
        Console.WriteLine("Hit enter to close this window.");
        Console.ReadLine();
    }
}
