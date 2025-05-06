using System;

class Calculator
{
    static int Main() {

        string operation;

        while (true) {
            Console.WriteLine("Select an operation: Add/Subtract/Multiply/Split");
            operation = Console.ReadLine() ?? "";
            if (operation == "Add" || operation == "Subtract" || operation == "Multiply" || operation == "Split") {
                break;
            }
            Console.WriteLine("No descanses gil, hasta te los escribi en la seleccion");
        }

        int numA;

        while (true) {    
            Console.WriteLine("First number: int only");
            string input = Console.ReadLine() ?? "";
            if (int.TryParse(input, out numA)) {
                break;
            }
            Console.WriteLine("Salame manda bien las cosas");
        }

        int numB;

        while (true) {
            Console.WriteLine("Second number: int only");
            string input = Console.ReadLine() ?? "";
            if (int.TryParse(input, out numB)) {
                break;
            }
            Console.WriteLine("Salame manda bien las cosas");
        }

        int result;

        if (operation == "Add") {
            result = Operations.Add(numA, numB);
        }
        else if (operation == "Subtract") {
            result = Operations.Subtract(numA, numB);
        }
        else if (operation == "Multiply") {
            result = Operations.Multiply(numA, numB);
        }
        else if (operation == "Split") {
            result = Operations.Split(numA, numB);
        }
        else {
            Console.WriteLine("Invalid operation");
            return 1;
        }
        Console.WriteLine($"Result:\n{result}");
        return 0;
    }
}