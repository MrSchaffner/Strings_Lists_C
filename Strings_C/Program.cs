using System;
using System.Collections.Generic;
using System.Text;

    class Program
    {
        static void Main(string[] args)
        {

        ArrayProgram();
        
        ListProgram();

        endMessage();
        }

    private static void IterationProgram()
    {
        //int[] testScores = { 75, 99, 100, 99, 99, 92 };

        //for (byte i=0; i<testScores.Length; i++)
        //{
        //if (testScores[i] > 84)
        //    {
        //        Console.WriteLine(testScores[i] = "Passed");
        //    }


        //}
        //Console.ReadLine();

        string[] names = { "a", "b", "c" };
        for (int j = 0; j<names.Length; j++)
        {
            Console.WriteLine(names[j]);
        }
        Console.ReadLine();

    
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
        string[] animalsArray = { "flipper", "hopper", "buzzy", "stinger", "furry", "purry", "nutters" };
        int[] intArray = { 1,2,4,8,16,32};
        List<string> stringList = new List<string>();
        stringList.Add("red");
        stringList.Add("blue");
        stringList.Add("white");
        //strings
        Console.WriteLine("Enter a number between 0 and " + (animalsArray.Length - 1) + " to get an entry in the animal array");
        byte enteredNum = Convert.ToByte(Console.ReadLine());
        if (enteredNum <= animalsArray.Length - 1)
            Console.WriteLine(animalsArray[enteredNum]);
        else
            Console.WriteLine("Out of Range");
        //integers
        Console.WriteLine("Enter a number between 0 and " + (intArray.Length - 1) + " to get an entry in the integers array");
        byte enteredNum2 = Convert.ToByte(Console.ReadLine());
        if (enteredNum2 <= intArray.Length - 1)
            Console.WriteLine(intArray[enteredNum2]);
        else
            Console.WriteLine("Out of Range");
        //List of Strings
        Console.WriteLine("Enter a number between 0 and " + (stringList.Count - 1) + " to get an entry in the Colors List");
        byte enteredNum3 = Convert.ToByte(Console.ReadLine());
        if (enteredNum3 <= stringList.Count - 1)
            Console.WriteLine(stringList[enteredNum3]);
        else
            Console.WriteLine("Out of Range");


        ////this restarts the program to keep the fun going.
        //if (!running) {
        //    return;
        //}
        //else
        //{
        //    ArrayProgram();
        //}

    }

    private static void ListProgram()
    {
        //Lists

        List<int> testScores = new List<int>() { 94, 64, 84, 94, 88 };

        Console.WriteLine(testScores[0]);

        foreach (int score in testScores)
        {
            if (score > 85)
                Console.WriteLine("score passed: " + testScores[score]);
        }

    }

    private static void endMessage()
    {
        Console.WriteLine("=============================================================");
        Console.WriteLine("Hit enter to close this window.");
        Console.ReadLine();
    }
}
