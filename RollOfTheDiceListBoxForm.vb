﻿
'David Harmon
'RCET0265
'Spring 2020
'Roll of the Dice List Box Form
'

Option Strict On
Option Explicit On
Option Compare Text


Public Class RollOfTheDiceListBoxForm
    Private Sub RollTheDice()
        Dim diceArray(12) As Integer
        Dim randomNumber As Integer
        Dim value As Integer = 0
        Dim intI As Integer
        Dim iterations As Integer
        Dim userInput As String
        Dim Text As String
        Dim Text2 As String
        Dim dashLines As String





        Randomize()


            For i = 0 To 1000
                randomNumber = CInt((12 - 2 + 1) * Rnd() + 2)

                ' The way that the randomizer equastion works, there need to be code in there to make sure that everthing is rounded up. 
                'This ensures that the random number always falls into working order. 

                If diceArray(randomNumber - 2) < 2 Then
                    i = 2
                ElseIf (randomNumber - 2) > 13 Then
                    i = 12
                End If

                'End If

                diceArray(randomNumber - 2) += 1

            Next

        'This part of the code formats the code so that it is easy to understand by the user. 
        'Text and text2 needed to become variables so that they could be loaded into the list box.
        'When it was just a conslole app we were able to just write it to the console.  
        For i = 2 To 12
            Text = Text & String.Format($"{i} |{vbTab}")
        Next

        RollTheDiceBox.Items.Add("Numbers:          " & Text)

        dashLines = (StrDup(177, "-"))
        RollTheDiceBox.Items.Add(dashLines)



            For i = 0 To 10
            Text2 = (Text2 & String.Format($"{diceArray(i)} |{vbTab}"))
        Next

        RollTheDiceBox.Items.Add("TimesRolled      " & Text2)
        RollTheDiceBox.Items.Add(dashLines)
        RollTheDiceBox.Items.Add("")
        RollTheDiceBox.Items.Add("")








    End Sub
    'These handle all of the menue items and the button funtions. Some menu items do the exact thing that the buttons do. 
    Private Sub RollButton_Click(sender As Object, e As EventArgs) Handles RollButton.Click
        RollTheDice()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        RollTheDiceBox.Items.Clear()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub RollToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RollToolStripMenuItem.Click
        RollTheDice()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        RollTheDiceBox.Items.Clear()

    End Sub

    Private Sub MenuToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem1.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
