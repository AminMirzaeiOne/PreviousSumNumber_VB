Module Module1

    Sub Main()
        Dim x, sum As Integer
        System.Console.ForegroundColor = ConsoleColor.Cyan
        System.Console.Write("Pls Enter Number: ")
        System.Console.ForegroundColor = ConsoleColor.Yellow
        x = Convert.ToInt32(Console.ReadLine())

        sum = 0
        For index = 1 To x - 1
            sum += index
        Next
        System.Console.ForegroundColor = ConsoleColor.Blue
        System.Console.Write("Sum Is: ")
        System.Console.BackgroundColor = ConsoleColor.Blue
        System.Console.ForegroundColor = ConsoleColor.White
        System.Console.WriteLine(sum.ToString())
        System.Console.BackgroundColor = ConsoleColor.Black
        System.Console.ForegroundColor = ConsoleColor.Magenta
        System.Console.WriteLine("-----------------------")
        System.Console.ForegroundColor = ConsoleColor.Red
        System.Console.WriteLine("Programmer : Amin Mirzaei - Github(UserName) : AminMirzaeiOne")
        System.Console.ReadKey()

    End Sub

End Module
