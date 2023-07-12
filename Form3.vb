Imports System.Globalization
Imports System.Windows
Imports System.Windows.Forms.DataFormats
Imports System.Windows.Forms.Design.AxImporter
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports System.Windows.Forms
Imports System.Text

Public Class ConfirmationForm
    Inherits Form

    Public Property FirstName As String
    Public Property LastName As String
    Public Property Email As String
    Public Property Address As String
    Public Property TotalAmount As Decimal


    Public Sub New()
        InitializeComponent()

    End Sub

    Private Sub InitializeComponent()
        Label1 = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 30.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.DarkBlue
        Label1.Location = New Point(109, 142)
        Label1.Name = "Label1"
        Label1.Size = New Size(215, 54)
        Label1.TabIndex = 0
        Label1.Text = "Success !!!"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(186, 255)
        Button1.Name = "Button1"
        Button1.Size = New Size(48, 36)
        Button1.TabIndex = 1
        Button1.Text = "OK"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ConfirmationForm
        ' 
        ClientSize = New Size(484, 361)
        Controls.Add(Button1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "ConfirmationForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Confirmation"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents first_Name As TextBox

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim lunchForm As New Form1()
        lunchForm.Show()
        Me.Hide()
    End Sub
End Class