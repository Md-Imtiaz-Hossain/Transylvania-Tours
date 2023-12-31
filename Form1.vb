﻿Imports System.Globalization
Imports System.Windows
Imports System.Windows.Forms.DataFormats
Imports System.Windows.Forms.Design.AxImporter
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports System.Windows.Forms
Imports System.Text

Public Class Form1

    Dim totalAmount As Decimal = 0

    Private Sub btnCalculateTotalCost_Click(sender As Object, e As EventArgs) Handles btnCalculateTotalCost.Click

        ' Reset the total amount
        totalAmount = 0

        ' Check which visit is selected and add the same amount for all places
        If visit8August.Checked Then
            totalAmount += 80
        ElseIf visit15August.Checked Then
            totalAmount += 80
        ElseIf visit22August.Checked Then
            totalAmount += 80
        ElseIf visit29August.Checked Then
            totalAmount += 80
        End If

        ' Check which lunch option is selected and add the corresponding amount
        If lunchSalad.Checked Then
            totalAmount += 5.0
        ElseIf lunchSandwich.Checked Then
            totalAmount += 3.5
        ElseIf lunchSoup.Checked Then
            totalAmount += 2.75
        ElseIf lunchBakedPotato.Checked Then
            totalAmount += 4.15
        End If

        ' Check which activity option is selected and add the corresponding amount
        If activityHorseRiding.Checked Then
            totalAmount += 25.0
        ElseIf activityHillWalking.Checked Then
            totalAmount += 15.0
        ElseIf activitySkydiving.Checked Then
            totalAmount += 30.0
        End If

        ' Check the extra activities and add the corresponding amounts
        If extraActivityArchery.Checked Then
            totalAmount += 20.0
        End If
        If extraActivityFalconry.Checked Then
            totalAmount += 25.0
        End If
        If extraActivityBungeeJumping.Checked Then
            totalAmount += 30.0
        End If

        ' Assign the total amount to the result text box
        result.Text = totalAmount.ToString("C", CultureInfo.GetCultureInfo("en-GB"))


    End Sub

    Private Sub resetButton_Click(sender As Object, e As EventArgs) Handles resetButton.Click
        ResetForm()
    End Sub


    Private Sub ResetForm()
        visit8August.Checked = False
        visit15August.Checked = False
        visit22August.Checked = False
        visit29August.Checked = False

        lunchSalad.Checked = False
        lunchSandwich.Checked = False
        lunchSoup.Checked = False
        lunchBakedPotato.Checked = False

        activityHorseRiding.Checked = False
        activityHillWalking.Checked = False
        activitySkydiving.Checked = False

        extraActivityArchery.Checked = False
        extraActivityFalconry.Checked = False
        extraActivityBungeeJumping.Checked = False

        totalAmount = 0
        result.Text = ""
    End Sub

    Private Sub btnNextPage_Click(sender As Object, e As EventArgs) Handles btnNextPage.Click
        Dim lunchForm As New NextForm(totalAmount)
        lunchForm.Show()
        Me.Hide()
    End Sub
    
    
    

End Class
