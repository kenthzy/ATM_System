Module Module1
    ' THIS  DEFINE A PUBLIC CLASS NAMED ACCOUNT
    Public Class Account
        ' THIS DEFINE THE USERNAME, PIN, AND BALANCE PROPERTIES FOR THE ACCOUNT CLASS
        Public Property Username As String
        Public Property Pin As String
        Public Property Balance As Decimal
    End Class

    'OUR GROUP ANONYMOUS ATM SYSTEM ON CONSOLE USING VB.NET 

    'LEADER
    'KENNETH JEARL S. GONZALES

    'MEMBERS
    '1. HUAN, SEAN MICHAEL S
    '2. TAMAYO PRINCESS IACI T.
    '3. AMASAN, JAYBIE S.
    '4. FELIZARIO, JUSTIN
    '5. TABIOLA, ARTER
    ' WWE CREATE A PRIVATE LIST OF ACCOUNTS
    Private accounts As New List(Of Account)()

    ' MAIN SUBROUTINE
    Sub Main()
        Console.WriteLine(" ")
        Console.Clear()
        Console.ReadKey()
        Console.WriteLine(" ")
        Console.Clear()
        Console.ReadKey()
        'WELCOME PAGE 
        Console.ForegroundColor = ConsoleColor.DarkRed
        Console.WriteLine(" ")
        Console.WriteLine(" ")
        Console.WriteLine(" ")
        Console.WriteLine("                                           ▄▄▄▄▄▄▄▄                   ")
        Console.WriteLine("                                          ▄▄▄▄▄▄▄▄▄▄                   ")
        Console.WriteLine("                                         ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄                   ")
        Console.WriteLine("                                         ▄▄▄▄▄▄▄▄▄▄▄▄▄                   ")
        Console.WriteLine("                                         ▄▄▄▄▄▄▄▄▄▄▄                   ")
        Console.WriteLine("                                         ▄▄▄▄▄▄▄▄▄▄▄▄▄▄                   ")
        Console.WriteLine("                    ▄▄ ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ▄▄")
        Console.WriteLine("                       ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄")
        Console.WriteLine("                                 ▄▄▄▄▄ ▄▄▄▄▄▄▄▄▄ ▄▄▄▄▄▄▄▄▄ ▄▄▄▄▄          ")
        Console.WriteLine("                                   ▄▄▄ ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ▄▄▄          ")
        Console.WriteLine("                                          ▄▄ ▄▄ ▄▄ ▄▄                     ")
        Console.WriteLine("                                          ▄▄ ▄▄ ▄▄ ▄▄                     ")
        Console.WriteLine("                                       ▄▄ ▄▄▄ ▄ ▄ ▄▄▄ ▄▄                  ")
        Console.WriteLine("                                         ▄ ▄ ▄▄▄▄▄ ▄ ▄                   ")
        Console.WriteLine(" ")
        Console.WriteLine("                           ▄▄ ▄ ▄ ▄ ANONYMOUS ATM SYSTEM ▄▄ ▄ ▄ ▄ ")
        Console.WriteLine(" ")
        Console.WriteLine("                              << PRESS KEY ENTER TO CONTINUE >> ")
        Console.ReadKey()
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine(" ")
        Console.WriteLine(" ")
        Console.WriteLine(" ")
        Console.WriteLine("      ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄")
        Console.WriteLine("      ▄▄ Anonymous Bank is an innovative banking institution founded by engineers and technology experts.     ▄▄")
        Console.WriteLine("      ▄▄ Our Security and secrecy banking software leverage the latest technological advancements to provide  ▄▄")
        Console.WriteLine("      ▄▄ our customers with a seamless banking experience.                                                    ▄▄")
        Console.WriteLine("      ▄▄                                                                                                      ▄▄")
        Console.WriteLine("      ▄▄ We offer a range of personalized banking services for system that allows users to transact in a      ▄▄")
        Console.WriteLine("      ▄▄ secure and private manner without revealing their identities. and businesses and are committed       ▄▄")
        Console.WriteLine("      ▄▄ to delivering exceptional customer service. As engineers, we are dedicated to continuous             ▄▄")
        Console.WriteLine("      ▄▄ innovation and using technology to make banking more cryptoanonymous and convenient hackers bank.    ▄▄")
        Console.WriteLine("      ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄")
        Console.WriteLine(" ")
        Console.Write("         ▄▄ ▄ ▄ ▄ PRESS KEY ENTER TO CONTINUE ")
        Console.ReadKey()
        Dim choice As Integer

        ' LOADING BAR
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine(" ")
        Console.WriteLine(" ")
        Console.WriteLine(" ")
        Console.Write("     ENTERING SYSTEM ")
        For i As Integer = 1 To 30
            Console.Write("▄")
            Threading.Thread.Sleep(50) 'WITH A DELAY TO SIMULATE LOADING
        Next
        Console.WriteLine()

        ' MAIN LOOP
        Do
            Console.ForegroundColor = ConsoleColor.Blue
            Console.Clear()
            Console.WriteLine("      ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄")
            Console.WriteLine("      ▄                                                    ▄")
            Console.WriteLine("      ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ANONYMOUS ATM ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄")
            Console.WriteLine("      ▄                                                    ▄")
            Console.WriteLine("      ▄                                                    ▄")
            Console.WriteLine("      ▄    > PRESS 1 TO REGISTER                           ▄")
            Console.WriteLine("      ▄    > PRESS 2 TO LOG IN                             ▄")
            Console.WriteLine("      ▄    > PRESS 3 TO EXIT                               ▄")
            Console.WriteLine("      ▄                                                    ▄")
            Console.WriteLine("      ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄")
            Console.WriteLine(" ")
            Console.Write("          ENTER YOUR CHOICE ::>  ")

            choice = Integer.Parse(Console.ReadLine())

            ' THE SELECT STATEMENT FOR USER CHOICE
            Select Case choice
                Case 1
                    Register()
                Case 2
                    Login()
                Case 3
                    Exit Sub
            End Select
        Loop
    End Sub

    ' REGISTER SECTION
    Private Sub Register()
        Console.Clear()
        Console.WriteLine(" ")
        Console.WriteLine(" ")
        Console.WriteLine("    ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄  ")
        Console.WriteLine("    ▄                                            ▄ ")
        Console.WriteLine("    ▄          REGISTRATION SECTION                ▄")
        Console.WriteLine("    ▄                                            ▄ ")
        Console.WriteLine("    ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄")
        Console.WriteLine(" ")
        Console.Write("     TYPE YOUR USERNAME ::> ")
        Dim username As String = Console.ReadLine()
        Console.Write("     CREATE A PIN ::> ")
        Dim pin As String = Console.ReadLine()

        'LOADING BAR
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine(" ")
        Console.WriteLine(" ")
        Console.WriteLine(" ")
        Console.WriteLine(" ")
        Console.Write("      CREATING ACCOUNT ")
        For i As Integer = 1 To 30
            Console.Write("▄")
            Threading.Thread.Sleep(50) 'WITH A DELAY TO SIMULATE LOADING
        Next
        Console.WriteLine()

        ' THIS WILL CREATE A NEW ACCOUNT WITH THE PROVIDED USERNAME, PIN, AND INITIAL BALANCE
        Dim account As New Account With {
            .Username = username,
            .Pin = pin,
            .Balance = 0D
        }
        accounts.Add(account)
        Console.WriteLine(" ")
        Console.WriteLine("         ▄▄ ▄ ▄ ▄ ACCOUNT CREATED SUCCESSFULLY!")
        Console.WriteLine(" ")
        Console.Write("         ▄▄ ▄ ▄ ▄ PRESS ANY KEY TO RETURN ON MAIN MENU")
        Console.ReadKey()
    End Sub

    ' LOGIN SECTION
    Private Sub Login()
        Console.Clear()
        Console.WriteLine(" ")
        Console.WriteLine(" ")
        Console.WriteLine("   ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ")
        Console.WriteLine("   ▄                                    ▄")
        Console.WriteLine("   ▄        LOG IN YOUR ACCOUNT           ▄")
        Console.WriteLine("   ▄                                    ▄")
        Console.WriteLine("   ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ")
        Console.WriteLine(" ")
        Console.Write("   ENTER YOUR USERNAME ::> ")
        Dim username As String = Console.ReadLine()
        Console.Write("   ENTER YOUR PIN ::> ")
        Dim pin As String = Console.ReadLine()

        'LOADING BAR
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine(" ")
        Console.Write("   AUTHENTICATING PLEASE WAIT ")
        For i As Integer = 1 To 5
            Console.Write(" ▄")
            Threading.Thread.Sleep(1000) 'WITH A DELAY TO SIMULATE LOADING
        Next
        Console.WriteLine()

        'THIS WILL FIND THE ACCOUNT WITH THE PROVIDED USERNAME AND PIN
        Dim account As Account = accounts.Find(Function(a) a.Username = username AndAlso a.Pin = pin)

        'THIS WILL CHECK IF THE ACCOUNT EXISTS
        If account IsNot Nothing Then
            Console.WriteLine(" ")
            Console.WriteLine("         ▄▄ ▄ ▄ ▄ LOG IN SUCCESSFULL!")
            AccountMenu(account)
            Console.ReadKey()
        Else
            Console.WriteLine(" ")
            Console.WriteLine("         ▄▄ ▄ ▄ ▄ INVALID USERNAME or PIN!")
            Console.WriteLine(" ")
            Console.Write("         ▄▄ ▄ ▄ ▄ PRESS ANY KEY TO RETURN ON MAIN MENU")
            Console.ReadKey()
        End If
    End Sub

    ' ACCOUNT MENU SECTION
    Private Sub AccountMenu(account As Account)
        Dim choice As Integer
        ' ACCOUNT MENU LOOP
        Do
            Console.Clear()
            Console.WriteLine(" ")
            Console.WriteLine(" ")
            Console.WriteLine("     ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄")
            Console.WriteLine("     ▄                                                 ▄")
            Console.WriteLine("     ▄                  ACCOUNT MENU                   ▄")
            Console.WriteLine("     ▄                                                 ▄")
            Console.WriteLine("     ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄")
            Console.WriteLine("     ▄                                                 ▄")
            Console.WriteLine("     ▄       > PRESS 1 TO CHECK YOUR BALANCE           ▄ ")
            Console.WriteLine("     ▄       > PRESS 2 TO DEPOSIT                      ▄")
            Console.WriteLine("     ▄       > PRESS 3 TO WITHDRAW                     ▄")
            Console.WriteLine("     ▄       > PRESS 4 TO LOG OUT                      ▄")
            Console.WriteLine("     ▄                                                 ▄")
            Console.WriteLine("     ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄")
            Console.WriteLine(" ")
            Console.Write("   ENTER YOUR CHOICE ::> ")
            choice = Integer.Parse(Console.ReadLine())

            ' THE SELECT STATEMENT FOR ACCOUNT MENU CHOICE
            Select Case choice
                Case 1
                    CheckBalance(account)
                Case 2
                    Deposit(account)
                Case 3
                    Withdraw(account)
                Case 4
                    Exit Sub
            End Select
        Loop
    End Sub

    ' CHECK BALANCE SECTION
    Private Sub CheckBalance(account As Account)
        Console.Clear()
        Console.WriteLine(" ")
        Console.WriteLine(" ")
        Console.WriteLine("     ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄")
        Console.WriteLine("     ▄                                                   ▄")
        Console.WriteLine($"     ▄   THE TOTAL BALANCE IN YOUR ACCOUNT WAS: ${account.Balance}      ▄")
        Console.WriteLine("     ▄                                                   ▄")
        Console.WriteLine("     ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄")
        Console.WriteLine(" ")
        Console.Write("         ▄▄ ▄ ▄ ▄ PRESS ANY KEY TO RETURN TO MAIN MENU")
        Console.ReadKey()
    End Sub

    ' DEPOSIT SECTION
    Private Sub Deposit(account As Account)
        Console.Clear()
        Console.WriteLine(" ")
        Console.WriteLine(" ")
        Console.WriteLine(" ")
        Console.Write("         ▄▄ ▄ ▄ ▄ ENTER THE AMOUNT YOU WANT TO DEPOSIT ::> ")
        Dim amount As Decimal = Decimal.Parse(Console.ReadLine())
        account.Balance += amount
        Console.WriteLine(" ")
        Console.WriteLine("         ▄▄ ▄ ▄ ▄ DEPOSIT SUCCESSFULL!")
        Console.WriteLine(" ")
        Console.Write("         ▄▄ ▄ ▄ ▄ PRESS ANY KEY TO RETURN TO MAIN MENU")
        Console.ReadKey()
    End Sub

    ' WITHDRAW SECTION
    Private Sub Withdraw(account As Account)
        Console.Clear()
        Console.Write("       ▄▄ ▄ ▄ ▄ ENTER THE AMOUNT YOU WANT TO WITHDRAW ::> ")
        Dim amount As Decimal = Decimal.Parse(Console.ReadLine())

        'THIS WILL CHECK IF THE ACCOUNT HAS SUFFICIENT BALANCE
        If account.Balance >= amount Then
            account.Balance -= amount
            Console.WriteLine(" ")
            Console.WriteLine("       ▄▄ ▄ ▄ ▄ WITHDRAWAL SUCCESSFULLY!")

        Else
            Console.WriteLine(" ")
            Console.WriteLine("       ▄▄ ▄ ▄ ▄ INSUFFICIENT BALANCE!")
        End If

        Console.Write("       ▄▄ ▄ ▄ ▄ PRESS ANY KEY TO RETURN ON MAIN MENU")
        Console.WriteLine(" ")
        'LOADING BAR
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine(" ")
        Console.Write("   REDIRECTING TO MAIN MENU PLEASE WAIT! ")
        For i As Integer = 1 To 5
            Console.Write(" ▄")
            Threading.Thread.Sleep(1000) 'WITH DELAY TO SIMULATE LOADING
        Next
        Console.WriteLine()
        Console.ReadKey()

    End Sub
End Module