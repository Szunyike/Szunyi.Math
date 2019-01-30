Public Class Operators
    Public Property LogicalOperators As New List(Of LogicalOperator)
    Public Property MathematicalOperators As New List(Of LogicalOperator)
    Public Property AggregateOperators As New List(Of LogicalOperator)
    Public Property BinaryOperators As New List(Of LogicalOperator)
    Public Sub New()
        LogicalOperators.Add(New LogicalOperator With {.Name = "AND", .Symbol = "&", .Description = "1,1 = True else False"})
        LogicalOperators.Add(New LogicalOperator With {.Name = "OR", .Symbol = "|", .Description = "0,0 = False else True"})
        LogicalOperators.Add(New LogicalOperator With {.Name = "XOR", .Symbol = "(+)", .Description = "0,1 and 1,0 = True else False"})
        LogicalOperators.Add(New LogicalOperator With {.Name = "NOR", .Symbol = "~|", .Description = "0,0  = True else False"})
        LogicalOperators.Add(New LogicalOperator With {.Name = "NAND", .Symbol = "~&", .Description = "1,1  = False else True"})

        MathematicalOperators.Add(New LogicalOperator With {.Name = "Add", .Symbol = "+", .Description = "Addition"})
        MathematicalOperators.Add(New LogicalOperator With {.Name = "Minus", .Symbol = "-", .Description = "Subtraction"})
        MathematicalOperators.Add(New LogicalOperator With {.Name = "Multiply", .Symbol = "*", .Description = "Multiplication"})
        MathematicalOperators.Add(New LogicalOperator With {.Name = "Division", .Symbol = "/", .Description = "Division"})
        MathematicalOperators.Add(New LogicalOperator With {.Name = "Exponentiation", .Symbol = "^", .Description = "Exponentiation"})
        MathematicalOperators.Add(New LogicalOperator With {.Name = "Factorial", .Symbol = "!", .Description = "Factorial"})
        MathematicalOperators.Add(New LogicalOperator With {.Name = "Mod", .Symbol = "#", .Description = "Modulo function"})

        AggregateOperators.Add(New LogicalOperator With {.Name = "Sum", .Symbol = "sum", .Description = "Summation operator"})
        AggregateOperators.Add(New LogicalOperator With {.Name = "Average", .Symbol = "avg", .Description = "Average operator"})
        AggregateOperators.Add(New LogicalOperator With {.Name = "Minimum value", .Symbol = "mini", .Description = "Minimum value operator"})
        AggregateOperators.Add(New LogicalOperator With {.Name = "Maximum value", .Symbol = "maxi", .Description = "Maximum value operator"})

        BinaryOperators.Add(New LogicalOperator With {.Name = "=", .Symbol = "=", .Description = "Equality"})
        BinaryOperators.Add(New LogicalOperator With {.Name = "<>", .Symbol = "<>", .Description = "Inequation"})
        BinaryOperators.Add(New LogicalOperator With {.Name = "<", .Symbol = "<", .Description = "Lower than"})
        BinaryOperators.Add(New LogicalOperator With {.Name = ">", .Symbol = ">", .Description = "Greater than"})
        BinaryOperators.Add(New LogicalOperator With {.Name = "<=", .Symbol = "<", .Description = "Lower or equal"})
        BinaryOperators.Add(New LogicalOperator With {.Name = ">=", .Symbol = ">=", .Description = "Greater or equal"})

    End Sub
End Class
Public Class LogicalOperator
    Public Property Name As String
    Public Property Description As String
    Public Property Symbol As String
End Class
