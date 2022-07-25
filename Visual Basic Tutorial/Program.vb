Imports System
Imports OOPVBLibrary

'https://www.tutorialspoint.com/vb.net/vb.net_classes_objects.htm

'https://docs.microsoft.com/en-us/dotnet/visual-basic/programming-guide/program-structure/me-my-mybase-And-myclass

'https://docs.microsoft.com/en-us/dotnet/visual-basic/programming-guide/language-features/objects-And-classes/inheritance-basics

'https://www.informit.com/articles/article.aspx?p=25857&seqNum=5#:~:text = Inheritance%20Is%20the%20Idea%20that,a%20collie%20Is%20a%20Dog.

'https://stackoverflow.com/questions/3279106/how-to-implement-class-constructor-in-visual-basic

'informit.com/articles/article.aspx?p=25857&seqNum=3#:~:text=Encapsulation%20is%20the%20exposure%20of,understand%20how%20it%20actually%20works.

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World")

        Dim result As New Rectangle(1, 5)
        'Using Functions / Voids
        result.SaySomething()
        Console.WriteLine(result.SaySomethingWithParameters(7))

        'Using from Another folder
        Dim sampleFolder As New Shape("Square")
        sampleFolder.TellMyName()

        'Using Inheritance
        Dim Parent As New Parent()
        Parent.sampleVariable = "Sample Variable with Value"
        Dim Child As New Child()
        Child.UseSampleVariable()
        Child.SaySomething()

        'Using Constants
        Constants.Example1()
        Constants.Example2()
        Constants.Example3()
    End Sub
End Module

'How to create a class
Public Class Rectangle
    'How to declare private variables
    Private length As Double

    Private width As Double

    Public Sub New(Length As Double, Width As Double)
        Me.length = Length
        Me.width = Width
    End Sub

    'How to create class methods (void)
    Public Sub SaySomething()
        Console.WriteLine("This is a sample method")
    End Sub

    'How to create class methods with a specific return type
    Public Function SaySomethingWithParameters(additionalValue As Double) As Double
        Return (length * width) + additionalValue
    End Function
End Class




'https://riptutorial.com/vb-net/learn/100010/module-statement
Public Module Constants
    Public Sub Example1()
        Const DaysInYear = 365
        Const WorkDays = 250

        Console.WriteLine(DaysInYear)
        Console.WriteLine(WorkDays)
    End Sub

    Public Sub Example2()
        Const MyInteger As Integer = 42
        Const DaysInWeek As Short = 7
        Const Sunday As String = "Sunday"

        Console.WriteLine(MyInteger)
        Console.WriteLine(DaysInWeek)
        Console.WriteLine(Sunday)
    End Sub

    Public Sub Example3()
        Const num1 As Integer = 4, num2 As Integer = 5, str1 As String = "Test String"

        Console.WriteLine(num1)
        Console.WriteLine(num2)
        Console.WriteLine(str1)
    End Sub
End Module