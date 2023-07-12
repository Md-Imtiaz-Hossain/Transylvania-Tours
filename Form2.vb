Imports System.Globalization
Imports System.Windows
Imports System.Windows.Forms.DataFormats
Imports System.Windows.Forms.Design.AxImporter
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports System.Windows.Forms
Imports System.Text
Imports System.Security.Cryptography.X509Certificates

Public Class NextForm
    Inherits Form

    Public Property TotalAmount As Decimal

    Public Sub New(totalAmount As Decimal)
        InitializeComponent()
        Me.TotalAmount = totalAmount
        result.Text = totalAmount.ToString("C", CultureInfo.GetCultureInfo("en-GB"))
    End Sub

    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NextForm))
        Label2 = New Label()
        result = New TextBox()
        btnCalculateTotalCost = New Button()
        btnNextPage = New Button()
        resetButton = New Button()
        GroupBox3 = New Forms.GroupBox()
        Label5 = New Label()
        address = New RichTextBox()
        email = New TextBox()
        Label4 = New Label()
        lastName = New TextBox()
        Label3 = New Label()
        firstName = New TextBox()
        Label1 = New Label()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Lucida Calligraphy", 30F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label2.ForeColor = Color.Peru
        Label2.ImeMode = ImeMode.NoControl
        Label2.Location = New Point(244, 102)
        Label2.Name = "Label2"
        Label2.Size = New Size(734, 52)
        Label2.TabIndex = 43
        Label2.Text = "Welcome to Transylvania Tours"
        ' 
        ' result
        ' 
        result.BackColor = Color.White
        result.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point)
        result.Location = New Point(258, 527)
        result.Name = "result"
        result.ReadOnly = True
        result.Size = New Size(104, 27)
        result.TabIndex = 41
        ' 
        ' btnCalculateTotalCost
        ' 
        btnCalculateTotalCost.BackColor = Color.White
        btnCalculateTotalCost.FlatAppearance.BorderSize = 0
        btnCalculateTotalCost.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnCalculateTotalCost.ImeMode = ImeMode.NoControl
        btnCalculateTotalCost.Location = New Point(130, 527)
        btnCalculateTotalCost.Margin = New Padding(0)
        btnCalculateTotalCost.Name = "btnCalculateTotalCost"
        btnCalculateTotalCost.Size = New Size(122, 30)
        btnCalculateTotalCost.TabIndex = 40
        btnCalculateTotalCost.Text = "Total Cost = "
        btnCalculateTotalCost.UseVisualStyleBackColor = False
        ' 
        ' btnNextPage
        ' 
        btnNextPage.BackColor = Color.Lime
        btnNextPage.FlatAppearance.BorderSize = 0
        btnNextPage.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnNextPage.ImeMode = ImeMode.NoControl
        btnNextPage.Location = New Point(506, 527)
        btnNextPage.Margin = New Padding(0)
        btnNextPage.Name = "btnNextPage"
        btnNextPage.Size = New Size(104, 30)
        btnNextPage.TabIndex = 39
        btnNextPage.Text = "Pay Now"
        btnNextPage.UseVisualStyleBackColor = False
        ' 
        ' resetButton
        ' 
        resetButton.BackColor = Color.Orange
        resetButton.FlatAppearance.BorderSize = 0
        resetButton.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        resetButton.ImeMode = ImeMode.NoControl
        resetButton.Location = New Point(378, 527)
        resetButton.Margin = New Padding(0)
        resetButton.Name = "resetButton"
        resetButton.Size = New Size(104, 30)
        resetButton.TabIndex = 42
        resetButton.Text = "Back"
        resetButton.UseVisualStyleBackColor = False
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = Color.Transparent
        GroupBox3.Controls.Add(Label5)
        GroupBox3.Controls.Add(address)
        GroupBox3.Controls.Add(email)
        GroupBox3.Controls.Add(Label4)
        GroupBox3.Controls.Add(lastName)
        GroupBox3.Controls.Add(Label3)
        GroupBox3.Controls.Add(firstName)
        GroupBox3.Controls.Add(Label1)
        GroupBox3.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox3.Location = New Point(130, 248)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(480, 264)
        GroupBox3.TabIndex = 37
        GroupBox3.TabStop = False
        GroupBox3.Text = "Personal Information For Payment"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(88, 190)
        Label5.Name = "Label5"
        Label5.Size = New Size(78, 20)
        Label5.TabIndex = 7
        Label5.Text = "Address : "
        ' 
        ' address
        ' 
        address.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        address.Location = New Point(191, 190)
        address.Name = "address"
        address.Size = New Size(248, 61)
        address.TabIndex = 6
        address.Text = ""
        ' 
        ' email
        ' 
        email.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        email.Location = New Point(191, 142)
        email.Name = "email"
        email.Size = New Size(248, 25)
        email.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(107, 142)
        Label4.Name = "Label4"
        Label4.Size = New Size(59, 20)
        Label4.TabIndex = 4
        Label4.Text = "Email : "
        ' 
        ' lastName
        ' 
        lastName.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        lastName.Location = New Point(191, 94)
        lastName.Name = "lastName"
        lastName.Size = New Size(248, 25)
        lastName.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(74, 94)
        Label3.Name = "Label3"
        Label3.Size = New Size(92, 20)
        Label3.TabIndex = 2
        Label3.Text = "LastName : "
        ' 
        ' firstName
        ' 
        firstName.BackColor = SystemColors.ButtonFace
        firstName.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        firstName.Location = New Point(191, 47)
        firstName.Name = "firstName"
        firstName.Size = New Size(248, 25)
        firstName.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(72, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(94, 20)
        Label1.TabIndex = 0
        Label1.Text = "FirstName : "
        ' 
        ' NextForm
        ' 
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1109, 658)
        Controls.Add(Label2)
        Controls.Add(result)
        Controls.Add(btnCalculateTotalCost)
        Controls.Add(btnNextPage)
        Controls.Add(resetButton)
        Controls.Add(GroupBox3)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "NextForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Payment"
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents result As TextBox
    Friend WithEvents btnCalculateTotalCost As Button
    Friend WithEvents btnNextPage As Button
    Friend WithEvents resetButton As Button
    Friend WithEvents firstName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents address As RichTextBox
    Friend WithEvents email As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lastName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As Forms.GroupBox

    Private Sub resetButton_Click(sender As Object, e As EventArgs) Handles resetButton.Click
        Dim lunchForm As New Form1()
        lunchForm.Show()
        Me.Hide()
    End Sub



    Private Sub btnNextPage_Click(sender As Object, e As EventArgs) Handles btnNextPage.Click
        Dim lunchForm As New ConfirmationForm()
        lunchForm.Show()
        Me.Hide()
    End Sub



End Class