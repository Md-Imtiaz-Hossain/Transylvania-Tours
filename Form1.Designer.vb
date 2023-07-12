<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        GroupBox1 = New GroupBox()
        lunchBakedPotato = New RadioButton()
        lunchSoup = New RadioButton()
        lunchSandwich = New RadioButton()
        lunchSalad = New RadioButton()
        GroupBox2 = New GroupBox()
        extraActivityBungeeJumping = New CheckBox()
        extraActivityFalconry = New CheckBox()
        extraActivityArchery = New CheckBox()
        GroupBox3 = New GroupBox()
        visit29August = New RadioButton()
        visit22August = New RadioButton()
        visit15August = New RadioButton()
        visit8August = New RadioButton()
        GroupBox4 = New GroupBox()
        activitySkydiving = New RadioButton()
        activityHillWalking = New RadioButton()
        activityHorseRiding = New RadioButton()
        btnNextPage = New Button()
        btnCalculateTotalCost = New Button()
        Label1 = New Label()
        result = New TextBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(lunchBakedPotato)
        GroupBox1.Controls.Add(lunchSoup)
        GroupBox1.Controls.Add(lunchSandwich)
        GroupBox1.Controls.Add(lunchSalad)
        GroupBox1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox1.Location = New Point(302, 195)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(232, 140)
        GroupBox1.TabIndex = 24
        GroupBox1.TabStop = False
        GroupBox1.Text = "Lunch"
        ' 
        ' lunchBakedPotato
        ' 
        lunchBakedPotato.AutoSize = True
        lunchBakedPotato.FlatStyle = FlatStyle.System
        lunchBakedPotato.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
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
        lunchSoup.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
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
        lunchSandwich.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
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
        lunchSalad.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        lunchSalad.Location = New Point(27, 28)
        lunchSalad.Name = "lunchSalad"
        lunchSalad.Size = New Size(110, 24)
        lunchSalad.TabIndex = 12
        lunchSalad.Text = "Salad £5.00"
        lunchSalad.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.Transparent
        GroupBox2.Controls.Add(extraActivityBungeeJumping)
        GroupBox2.Controls.Add(extraActivityFalconry)
        GroupBox2.Controls.Add(extraActivityArchery)
        GroupBox2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox2.ForeColor = SystemColors.Desktop
        GroupBox2.Location = New Point(302, 341)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(232, 118)
        GroupBox2.TabIndex = 25
        GroupBox2.TabStop = False
        GroupBox2.Text = "Extra Activities : "
        ' 
        ' extraActivityBungeeJumping
        ' 
        extraActivityBungeeJumping.AutoSize = True
        extraActivityBungeeJumping.FlatStyle = FlatStyle.System
        extraActivityBungeeJumping.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
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
        extraActivityFalconry.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        extraActivityFalconry.Location = New Point(27, 52)
        extraActivityFalconry.Name = "extraActivityFalconry"
        extraActivityFalconry.Size = New Size(140, 24)
        extraActivityFalconry.TabIndex = 25
        extraActivityFalconry.Text = "Falconry £25.00"
        extraActivityFalconry.UseVisualStyleBackColor = True
        ' 
        ' extraActivityArchery
        ' 
        extraActivityArchery.AutoSize = True
        extraActivityArchery.FlatStyle = FlatStyle.System
        extraActivityArchery.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        extraActivityArchery.Location = New Point(27, 27)
        extraActivityArchery.Name = "extraActivityArchery"
        extraActivityArchery.Size = New Size(136, 24)
        extraActivityArchery.TabIndex = 24
        extraActivityArchery.Text = "Archery £20.00"
        extraActivityArchery.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = Color.Transparent
        GroupBox3.Controls.Add(visit29August)
        GroupBox3.Controls.Add(visit22August)
        GroupBox3.Controls.Add(visit15August)
        GroupBox3.Controls.Add(visit8August)
        GroupBox3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox3.Location = New Point(54, 195)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(232, 140)
        GroupBox3.TabIndex = 25
        GroupBox3.TabStop = False
        GroupBox3.Text = "Date of visit : "
        ' 
        ' visit29August
        ' 
        visit29August.AutoSize = True
        visit29August.FlatStyle = FlatStyle.System
        visit29August.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
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
        visit22August.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        visit22August.Location = New Point(35, 78)
        visit22August.Name = "visit22August"
        visit22August.Size = New Size(180, 24)
        visit22August.TabIndex = 9
        visit22August.TabStop = True
        visit22August.Text = "Saturday 22nd August"
        visit22August.UseVisualStyleBackColor = True
        ' 
        ' visit15August
        ' 
        visit15August.AutoSize = True
        visit15August.FlatStyle = FlatStyle.System
        visit15August.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
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
        visit8August.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        visit8August.Location = New Point(35, 28)
        visit8August.Name = "visit8August"
        visit8August.Size = New Size(168, 24)
        visit8August.TabIndex = 7
        visit8August.TabStop = True
        visit8August.Text = "Saturday 8th August"
        visit8August.UseVisualStyleBackColor = True
        ' 
        ' GroupBox4
        ' 
        GroupBox4.BackColor = Color.Transparent
        GroupBox4.Controls.Add(activitySkydiving)
        GroupBox4.Controls.Add(activityHillWalking)
        GroupBox4.Controls.Add(activityHorseRiding)
        GroupBox4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox4.ForeColor = SystemColors.Desktop
        GroupBox4.Location = New Point(54, 341)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(232, 118)
        GroupBox4.TabIndex = 27
        GroupBox4.TabStop = False
        GroupBox4.Text = "Activities : "
        ' 
        ' activitySkydiving
        ' 
        activitySkydiving.AutoSize = True
        activitySkydiving.FlatStyle = FlatStyle.System
        activitySkydiving.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point)
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
        activityHillWalking.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point)
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
        activityHorseRiding.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point)
        activityHorseRiding.Location = New Point(35, 28)
        activityHorseRiding.Name = "activityHorseRiding"
        activityHorseRiding.Size = New Size(172, 25)
        activityHorseRiding.TabIndex = 16
        activityHorseRiding.TabStop = True
        activityHorseRiding.Text = "Horse riding £25.00"
        activityHorseRiding.UseVisualStyleBackColor = True
        ' 
        ' btnNextPage
        ' 
        btnNextPage.BackColor = Color.Orange
        btnNextPage.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnNextPage.Location = New Point(302, 474)
        btnNextPage.Name = "btnNextPage"
        btnNextPage.Size = New Size(104, 38)
        btnNextPage.TabIndex = 29
        btnNextPage.Text = "Next"
        btnNextPage.UseVisualStyleBackColor = False
        ' 
        ' btnCalculateTotalCost
        ' 
        btnCalculateTotalCost.BackColor = Color.Orange
        btnCalculateTotalCost.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnCalculateTotalCost.Location = New Point(182, 474)
        btnCalculateTotalCost.Name = "btnCalculateTotalCost"
        btnCalculateTotalCost.Size = New Size(104, 38)
        btnCalculateTotalCost.TabIndex = 30
        btnCalculateTotalCost.Text = "Total Cost"
        btnCalculateTotalCost.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AllowDrop = True
        Label1.AutoSize = True
        Label1.BackColor = Color.AntiqueWhite
        Label1.FlatStyle = FlatStyle.System
        Label1.Font = New Font("Forte", 40F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(202, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(749, 60)
        Label1.TabIndex = 31
        Label1.Text = "Welcome to Transylvania Tours"
        Label1.UseMnemonic = False
        ' 
        ' result
        ' 
        result.Location = New Point(570, 485)
        result.Name = "result"
        result.Size = New Size(100, 23)
        result.TabIndex = 32
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1093, 619)
        Controls.Add(result)
        Controls.Add(btnCalculateTotalCost)
        Controls.Add(btnNextPage)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lunchBakedPotato As RadioButton
    Friend WithEvents lunchSoup As RadioButton
    Friend WithEvents lunchSandwich As RadioButton
    Friend WithEvents lunchSalad As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents extraActivityBungeeJumping As CheckBox
    Friend WithEvents extraActivityFalconry As CheckBox
    Friend WithEvents extraActivityArchery As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents visit29August As RadioButton
    Friend WithEvents visit22August As RadioButton
    Friend WithEvents visit15August As RadioButton
    Friend WithEvents visit8August As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents activitySkydiving As RadioButton
    Friend WithEvents activityHillWalking As RadioButton
    Friend WithEvents activityHorseRiding As RadioButton
    Friend WithEvents btnNextPage As Button
    Friend WithEvents btnCalculateTotalCost As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents result As TextBox
End Class
