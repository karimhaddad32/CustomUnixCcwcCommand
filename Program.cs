﻿using CustomCcwc;
using System.IO;
using System.Runtime.ConstrainedExecution;
using System.Text;


while (true)
{
    string? userInput = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(userInput)) continue;

    var multipleInputs = userInput.Split('|');
    string? currentFilePath = null;

    foreach (var input in multipleInputs)
    {
        if (string.IsNullOrWhiteSpace(input)) continue;

        string cleanUserInput = TextCleaner.CleanText(input);

        var inputs = cleanUserInput.Split(' ');

        if (inputs[0] != "ccwc" && inputs[0] != "cat")
        {
            Console.WriteLine($"{inputs[0]} is unrecognized!");
            continue;
        }

        if (inputs.Length > 3)
        {
            Console.WriteLine($"Invalid Arguments");
            continue;
        }

        try
        {
            if (inputs[0] == "cat")
            {
                currentFilePath ??= inputs[1];
                continue;
            }

            ICcwcCalculator calculator = CalculatorFactory.CreateCalculator(inputs.Length > 1 ? inputs[1] : string.Empty);

            if (calculator is FileBytesLinesWordsCalculator)
            {
                currentFilePath ??= inputs[1];
            }
            else
            {
                currentFilePath ??= inputs[2];
            }

            string result = calculator.Calculate(currentFilePath);

            Console.WriteLine($"{result} {currentFilePath}");
        }
        catch (NotImplementedException)
        {
            Console.WriteLine("Invalid Arguments");
            continue;
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Please provide a file name");
            continue;
        }
        catch (FileNotFoundException)
        {
            Console.Write("Enter text: ");

            string? text = Console.ReadLine();

            if (text == null)
            {
                Console.WriteLine($"0 {currentFilePath}");
                continue;
            }

            File.AppendAllLines(currentFilePath!, [text]);

            ICcwcCalculator calculator = CalculatorFactory.CreateCalculator(inputs.Length > 1 ? inputs[1] : string.Empty);

            string result = calculator.Calculate(currentFilePath!);

            Console.WriteLine($"{result} {currentFilePath}");

            File.Delete(currentFilePath!);
        }

    }
}