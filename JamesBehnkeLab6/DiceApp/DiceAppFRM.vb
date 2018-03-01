Option Strict On
Public Class DiceAppFRM
    Dim rand As New Random()
    Dim numDice As Integer
    Private Sub die1RBTN_Click(sender As Object, e As EventArgs) Handles die1RBTN.Click
        die2PBX.Visible = False
        die3PBX.Visible = False
        die1PBX.Location = New Point(96, 68)
        die1PBX.Size = New Drawing.Size(140, 129)
        numDice = 1
    End Sub

    Private Sub die2RBTN_Click(sender As Object, e As EventArgs) Handles die2RBTN.Click
        die3PBX.Visible = False
        die2PBX.Visible = True
        die1PBX.Location = New Point(70, 29)
        die1PBX.Size = New Drawing.Size(122, 120)
        die2PBX.Location = New Point(228, 120)
        die2PBX.Size = New Drawing.Size(122, 120)
        numDice = 2
    End Sub

    Private Sub die3RBTN_Click(sender As Object, e As EventArgs) Handles die3RBTN.Click
        die3PBX.Visible = True
        die1PBX.Location = New Point(27, 29)
        die1PBX.Size = New Drawing.Size(92, 94)
        die2PBX.Location = New Point(150, 68)
        die2PBX.Size = New Drawing.Size(100, 92)
        numDice = 3
    End Sub

    Function diceRoll(numDice As Integer) As Integer
        Dim dice1 As Integer = rand.Next(1, 7)
        Dim dice2 As Integer = rand.Next(1, 7)
        Dim dice3 As Integer = rand.Next(1, 7)

        die1PBX.Image = Image.FromFile("Images\die" & dice1.ToString() & ".png")
        die2PBX.Image = Image.FromFile("Images\die" & dice2.ToString() & ".png")
        die3PBX.Image = Image.FromFile("Images\die" & dice3.ToString() & ".png")

        Select Case numDice
            Case 1
                Return dice1
            Case 2
                Return dice1 + dice2
            Case 3
                Return dice1 + dice2 + dice3
        End Select

    End Function

    Private Sub rollBTN_Click(sender As Object, e As EventArgs) Handles rollBTN.Click
        diceGBX.Text = "You rolled a " & diceRoll(numDice)
    End Sub

    Sub ImageReset()
        die1PBX.Image = Image.FromFile("Images\dieFooBar.png")
        die2PBX.Image = Image.FromFile("Images\dieFooBar.png")
        die3PBX.Image = Image.FromFile("Images\dieFooBar.png")
        diceGBX.Text = "Roll the dice"

    End Sub

    Private Sub die1RBTN_CheckedChanged(sender As Object, e As EventArgs) Handles die1RBTN.CheckedChanged
        ImageReset()
    End Sub

    Private Sub die2RBTN_CheckedChanged(sender As Object, e As EventArgs) Handles die2RBTN.CheckedChanged
        ImageReset()
    End Sub

    Private Sub die3RBTN_CheckedChanged(sender As Object, e As EventArgs) Handles die3RBTN.CheckedChanged
        ImageReset()
    End Sub
End Class
