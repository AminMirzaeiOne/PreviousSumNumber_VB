' This line declares a module named Module1
Module Module1

    ' This line defines a subroutine named Main, which is the entry point of the program
    Sub Main()

        ' Declare two variables: x and sum, both of type Integer (whole numbers)
        Dim x, sum As Integer

        ' Set the foreground color of the console output to Cyan
        System.Console.ForegroundColor = ConsoleColor.Cyan

        ' Prompt the user to enter a number using a colored message
        System.Console.Write("Pls Enter Number: ")

        ' Set the foreground color of the user input prompt to Yellow
        System.Console.ForegroundColor = ConsoleColor.Yellow

        ' Read the user's input, convert it to an integer, and store it in the variable x
        x = Convert.ToInt32(Console.ReadLine())

        ' Initialize the sum variable to 0
        sum = 0

        ' This loop iterates from 1 to x-1 (excluding x)
        ' In each iteration, the value of the index is added to the sum variable
        For index = 1 To x - 1
            sum += index
        Next

        ' Set the foreground color of the output to Blue
        System.Console.ForegroundColor = ConsoleColor.Blue

        ' Display a message "Sum Is:" with a colored background
        System.Console.Write("Sum Is: ")

        ' Set the background color to Blue, foreground color to White, and write the value of sum
        System.Console.BackgroundColor = ConsoleColor.Blue
        System.Console.ForegroundColor = ConsoleColor.White
        System.Console.WriteLine(sum.ToString())

        ' Reset the background color to Black
        System.Console.BackgroundColor = ConsoleColor.Black

        ' Set the foreground color to Magenta and display a separator line
        System.Console.ForegroundColor = ConsoleColor.Magenta
        System.Console.WriteLine("-----------------------")

        ' Set the foreground color to Red and display programmer information
        System.Console.ForegroundColor = ConsoleColor.Red
        System.Console.WriteLine("Programmer : Amin Mirzaei - Github(UserName) : AminMirzaeiOne")

        ' Pause the console window until the user presses any key
        System.Console.ReadKey()

    End Sub

End Module
