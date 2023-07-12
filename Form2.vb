Imports System.Globalization
Imports System.Windows
Imports System.Windows.Forms.DataFormats
Imports System.Windows.Forms.Design.AxImporter
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports System.Windows.Forms
Imports System.Text

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
        activitySkydiving = New Forms.RadioButton()
        activityHillWalking = New Forms.RadioButton()
        activityHorseRiding = New Forms.RadioButton()
        resetButton = New Button()
        GroupBox4 = New Forms.GroupBox()
        visit29August = New Forms.RadioButton()
        visit22August = New Forms.RadioButton()
        extraActivityArchery = New Forms.CheckBox()
        visit15August = New Forms.RadioButton()
        visit8August = New Forms.RadioButton()
        extraActivityBungeeJumping = New Forms.CheckBox()
        extraActivityFalconry = New Forms.CheckBox()
        GroupBox2 = New Forms.GroupBox()
        lunchBakedPotato = New Forms.RadioButton()
        lunchSoup = New Forms.RadioButton()
        lunchSandwich = New Forms.RadioButton()
        lunchSalad = New Forms.RadioButton()
        GroupBox3 = New Forms.GroupBox()
        GroupBox1 = New Forms.GroupBox()
        GroupBox4.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox1.SuspendLayout()
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
        btnCalculateTotalCost.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
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
        btnNextPage.BackColor = Color.Orange
        btnNextPage.FlatAppearance.BorderSize = 0
        btnNextPage.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnNextPage.ImeMode = ImeMode.NoControl
        btnNextPage.Location = New Point(506, 527)
        btnNextPage.Margin = New Padding(0)
        btnNextPage.Name = "btnNextPage"
        btnNextPage.Size = New Size(104, 30)
        btnNextPage.TabIndex = 39
        btnNextPage.Text = "Next"
        btnNextPage.UseVisualStyleBackColor = False
        ' 
        ' activitySkydiving
        ' 
        activitySkydiving.AutoSize = True
        activitySkydiving.FlatStyle = FlatStyle.System
        activitySkydiving.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold, GraphicsUnit.Point)
        activitySkydiving.ImeMode = ImeMode.NoControl
        activitySkydiving.Location = New Point(35, 78)
        activitySkydiving.Name = "activitySkydiving"
        activitySkydiving.Size = New Size(153, 25)
        activitySkydiving.TabIndex = 18
        activitySkydiving.TabStop = True
        activitySkydiving.Text = "Skydiving £30.00"
        activitySkydiving.UseVisualStyleBackColor = True
        ' 
        ' activityHillWalking
        ' 
        activityHillWalking.AutoSize = True
        activityHillWalking.FlatStyle = FlatStyle.System
        activityHillWalking.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold, GraphicsUnit.Point)
        activityHillWalking.ImeMode = ImeMode.NoControl
        activityHillWalking.Location = New Point(35, 53)
        activityHillWalking.Name = "activityHillWalking"
        activityHillWalking.Size = New Size(167, 25)
        activityHillWalking.TabIndex = 17
        activityHillWalking.TabStop = True
        activityHillWalking.Text = "Hill walking £15.00"
        activityHillWalking.UseVisualStyleBackColor = True
        ' 
        ' activityHorseRiding
        ' 
        activityHorseRiding.AutoSize = True
        activityHorseRiding.FlatStyle = FlatStyle.System
        activityHorseRiding.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold, GraphicsUnit.Point)
        activityHorseRiding.ImeMode = ImeMode.NoControl
        activityHorseRiding.Location = New Point(35, 28)
        activityHorseRiding.Name = "activityHorseRiding"
        activityHorseRiding.Size = New Size(172, 25)
        activityHorseRiding.TabIndex = 16
        activityHorseRiding.TabStop = True
        activityHorseRiding.Text = "Horse riding £25.00"
        activityHorseRiding.UseVisualStyleBackColor = True
        ' 
        ' resetButton
        ' 
        resetButton.BackColor = Color.Orange
        resetButton.FlatAppearance.BorderSize = 0
        resetButton.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        resetButton.ImeMode = ImeMode.NoControl
        resetButton.Location = New Point(378, 527)
        resetButton.Margin = New Padding(0)
        resetButton.Name = "resetButton"
        resetButton.Size = New Size(104, 30)
        resetButton.TabIndex = 42
        resetButton.Text = "Reset"
        resetButton.UseVisualStyleBackColor = False
        ' 
        ' GroupBox4
        ' 
        GroupBox4.BackColor = Color.Transparent
        GroupBox4.Controls.Add(activitySkydiving)
        GroupBox4.Controls.Add(activityHillWalking)
        GroupBox4.Controls.Add(activityHorseRiding)
        GroupBox4.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox4.ForeColor = SystemColors.Desktop
        GroupBox4.Location = New Point(130, 394)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(232, 118)
        GroupBox4.TabIndex = 38
        GroupBox4.TabStop = False
        GroupBox4.Text = "Activities : "
        ' 
        ' visit29August
        ' 
        visit29August.AutoSize = True
        visit29August.FlatStyle = FlatStyle.System
        visit29August.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        visit29August.ImeMode = ImeMode.NoControl
        visit29August.Location = New Point(35, 103)
        visit29August.Name = "visit29August"
        visit29August.Size = New Size(176, 24)
        visit29August.TabIndex = 10
        visit29August.TabStop = True
        visit29August.Text = "Saturday 29th August"
        visit29August.UseVisualStyleBackColor = True
        ' 
        ' visit22August
        ' 
        visit22August.AutoSize = True
        visit22August.FlatStyle = FlatStyle.System
        visit22August.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        visit22August.ImeMode = ImeMode.NoControl
        visit22August.Location = New Point(35, 78)
        visit22August.Name = "visit22August"
        visit22August.Size = New Size(180, 24)
        visit22August.TabIndex = 9
        visit22August.TabStop = True
        visit22August.Text = "Saturday 22nd August"
        visit22August.UseVisualStyleBackColor = True
        ' 
        ' extraActivityArchery
        ' 
        extraActivityArchery.AutoSize = True
        extraActivityArchery.FlatStyle = FlatStyle.System
        extraActivityArchery.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        extraActivityArchery.ImeMode = ImeMode.NoControl
        extraActivityArchery.Location = New Point(27, 27)
        extraActivityArchery.Name = "extraActivityArchery"
        extraActivityArchery.Size = New Size(136, 24)
        extraActivityArchery.TabIndex = 24
        extraActivityArchery.Text = "Archery £20.00"
        extraActivityArchery.UseVisualStyleBackColor = True
        ' 
        ' visit15August
        ' 
        visit15August.AutoSize = True
        visit15August.FlatStyle = FlatStyle.System
        visit15August.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        visit15August.ImeMode = ImeMode.NoControl
        visit15August.Location = New Point(35, 53)
        visit15August.Name = "visit15August"
        visit15August.Size = New Size(176, 24)
        visit15August.TabIndex = 8
        visit15August.TabStop = True
        visit15August.Text = "Saturday 15th August"
        visit15August.UseVisualStyleBackColor = True
        ' 
        ' visit8August
        ' 
        visit8August.AutoSize = True
        visit8August.FlatStyle = FlatStyle.System
        visit8August.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        visit8August.ImeMode = ImeMode.NoControl
        visit8August.Location = New Point(35, 28)
        visit8August.Name = "visit8August"
        visit8August.Size = New Size(168, 24)
        visit8August.TabIndex = 7
        visit8August.TabStop = True
        visit8August.Text = "Saturday 8th August"
        visit8August.UseVisualStyleBackColor = True
        ' 
        ' extraActivityBungeeJumping
        ' 
        extraActivityBungeeJumping.AutoSize = True
        extraActivityBungeeJumping.FlatStyle = FlatStyle.System
        extraActivityBungeeJumping.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        extraActivityBungeeJumping.ImeMode = ImeMode.NoControl
        extraActivityBungeeJumping.Location = New Point(27, 77)
        extraActivityBungeeJumping.Name = "extraActivityBungeeJumping"
        extraActivityBungeeJumping.Size = New Size(191, 24)
        extraActivityBungeeJumping.TabIndex = 26
        extraActivityBungeeJumping.Text = "Bungee jumping £30.00"
        extraActivityBungeeJumping.UseVisualStyleBackColor = True
        ' 
        ' extraActivityFalconry
        ' 
        extraActivityFalconry.AutoSize = True
        extraActivityFalconry.FlatStyle = FlatStyle.System
        extraActivityFalconry.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        extraActivityFalconry.ImeMode = ImeMode.NoControl
        extraActivityFalconry.Location = New Point(27, 52)
        extraActivityFalconry.Name = "extraActivityFalconry"
        extraActivityFalconry.Size = New Size(140, 24)
        extraActivityFalconry.TabIndex = 25
        extraActivityFalconry.Text = "Falconry £25.00"
        extraActivityFalconry.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.Transparent
        GroupBox2.Controls.Add(extraActivityBungeeJumping)
        GroupBox2.Controls.Add(extraActivityFalconry)
        GroupBox2.Controls.Add(extraActivityArchery)
        GroupBox2.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox2.ForeColor = SystemColors.Desktop
        GroupBox2.Location = New Point(378, 394)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(232, 118)
        GroupBox2.TabIndex = 36
        GroupBox2.TabStop = False
        GroupBox2.Text = "Extra Activities : "
        ' 
        ' lunchBakedPotato
        ' 
        lunchBakedPotato.AutoSize = True
        lunchBakedPotato.FlatStyle = FlatStyle.System
        lunchBakedPotato.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        lunchBakedPotato.ImeMode = ImeMode.NoControl
        lunchBakedPotato.Location = New Point(27, 103)
        lunchBakedPotato.Name = "lunchBakedPotato"
        lunchBakedPotato.Size = New Size(164, 24)
        lunchBakedPotato.TabIndex = 15
        lunchBakedPotato.Text = "Baked potato £4.15"
        lunchBakedPotato.UseVisualStyleBackColor = True
        ' 
        ' lunchSoup
        ' 
        lunchSoup.AutoSize = True
        lunchSoup.FlatStyle = FlatStyle.System
        lunchSoup.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        lunchSoup.ImeMode = ImeMode.NoControl
        lunchSoup.Location = New Point(27, 78)
        lunchSoup.Name = "lunchSoup"
        lunchSoup.Size = New Size(107, 24)
        lunchSoup.TabIndex = 14
        lunchSoup.Text = "Soup £2.75"
        lunchSoup.UseVisualStyleBackColor = True
        ' 
        ' lunchSandwich
        ' 
        lunchSandwich.AutoSize = True
        lunchSandwich.FlatStyle = FlatStyle.System
        lunchSandwich.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        lunchSandwich.ImeMode = ImeMode.NoControl
        lunchSandwich.Location = New Point(27, 53)
        lunchSandwich.Name = "lunchSandwich"
        lunchSandwich.Size = New Size(136, 24)
        lunchSandwich.TabIndex = 13
        lunchSandwich.Text = "Sandwich £3.50"
        lunchSandwich.UseVisualStyleBackColor = True
        ' 
        ' lunchSalad
        ' 
        lunchSalad.AutoSize = True
        lunchSalad.FlatStyle = FlatStyle.System
        lunchSalad.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        lunchSalad.ImeMode = ImeMode.NoControl
        lunchSalad.Location = New Point(27, 28)
        lunchSalad.Name = "lunchSalad"
        lunchSalad.Size = New Size(110, 24)
        lunchSalad.TabIndex = 12
        lunchSalad.Text = "Salad £5.00"
        lunchSalad.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = Color.Transparent
        GroupBox3.Controls.Add(visit29August)
        GroupBox3.Controls.Add(visit22August)
        GroupBox3.Controls.Add(visit15August)
        GroupBox3.Controls.Add(visit8August)
        GroupBox3.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox3.Location = New Point(130, 248)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(232, 140)
        GroupBox3.TabIndex = 37
        GroupBox3.TabStop = False
        GroupBox3.Text = "Date of visit : "
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(lunchBakedPotato)
        GroupBox1.Controls.Add(lunchSoup)
        GroupBox1.Controls.Add(lunchSandwich)
        GroupBox1.Controls.Add(lunchSalad)
        GroupBox1.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox1.Location = New Point(378, 248)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(232, 140)
        GroupBox1.TabIndex = 35
        GroupBox1.TabStop = False
        GroupBox1.Text = "Lunch"
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
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "NextForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Next Form"
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents result As TextBox
    Friend WithEvents btnCalculateTotalCost As Button
    Friend WithEvents btnNextPage As Button
    Friend WithEvents activitySkydiving As Forms.RadioButton
    Friend WithEvents activityHillWalking As Forms.RadioButton
    Friend WithEvents activityHorseRiding As Forms.RadioButton
    Friend WithEvents resetButton As Button
    Friend WithEvents GroupBox4 As Forms.GroupBox
    Friend WithEvents visit29August As Forms.RadioButton
    Friend WithEvents visit22August As Forms.RadioButton
    Friend WithEvents extraActivityArchery As Forms.CheckBox
    Friend WithEvents visit15August As Forms.RadioButton
    Friend WithEvents visit8August As Forms.RadioButton
    Friend WithEvents extraActivityBungeeJumping As Forms.CheckBox
    Friend WithEvents extraActivityFalconry As Forms.CheckBox
    Friend WithEvents GroupBox2 As Forms.GroupBox
    Friend WithEvents lunchBakedPotato As Forms.RadioButton
    Friend WithEvents lunchSoup As Forms.RadioButton
    Friend WithEvents lunchSandwich As Forms.RadioButton
    Friend WithEvents lunchSalad As Forms.RadioButton
    Friend WithEvents GroupBox3 As Forms.GroupBox
    Friend WithEvents GroupBox1 As Forms.GroupBox


End Class