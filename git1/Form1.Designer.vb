Imports MySql.Data.MySqlClient
Imports MySql
Imports Mysqlx
Imports System.Security.Cryptography
Imports System.Text

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Button1 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        PictureBox1 = New PictureBox()
        MenuStrip1 = New MenuStrip()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        ContactFormToolStripMenuItem = New ToolStripMenuItem()
        BackgroundToolStripMenuItem = New ToolStripMenuItem()
        EducationAsAPillarToolStripMenuItem = New ToolStripMenuItem()
        CommunityToolStripMenuItem = New ToolStripMenuItem()
        HistoryToolStripMenuItem = New ToolStripMenuItem()
        AcademicsToolStripMenuItem = New ToolStripMenuItem()
        KCPEToolStripMenuItem = New ToolStripMenuItem()
        KPSEAToolStripMenuItem = New ToolStripMenuItem()
        Grade6ToolStripMenuItem = New ToolStripMenuItem()
        CoCurricularToolStripMenuItem = New ToolStripMenuItem()
        AbstractToolStripMenuItem = New ToolStripMenuItem()
        VisionToolStripMenuItem = New ToolStripMenuItem()
        MissionToolStripMenuItem = New ToolStripMenuItem()
        AchievementsToolStripMenuItem = New ToolStripMenuItem()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Button1.Image = My.Resources.Resources.muringato
        Button1.ImageAlign = ContentAlignment.MiddleRight
        Button1.Location = New Point(311, 544)
        Button1.Name = "Button1"
        Button1.Size = New Size(79, 42)
        Button1.TabIndex = 0
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.Teal
        Button2.Image = My.Resources.Resources.cree
        Button2.ImageAlign = ContentAlignment.BottomLeft
        Button2.Location = New Point(471, 544)
        Button2.Name = "Button2"
        Button2.Size = New Size(192, 42)
        Button2.TabIndex = 1
        Button2.Text = "Forgot Password?"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI Variable Text Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Navy
        Label1.Image = My.Resources.Resources.muringato
        Label1.Location = New Point(34, 328)
        Label1.Name = "Label1"
        Label1.Size = New Size(113, 31)
        Label1.TabIndex = 2
        Label1.Text = "USERNAME"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI Variable Text Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Navy
        Label2.Image = My.Resources.Resources.muringato
        Label2.Location = New Point(34, 397)
        Label2.Name = "Label2"
        Label2.Size = New Size(113, 31)
        Label2.TabIndex = 3
        Label2.Text = "PASSWORD"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TextBox1
        ' 
        TextBox1.AcceptsReturn = True
        TextBox1.AcceptsTab = True
        TextBox1.BackColor = SystemColors.InactiveCaption
        TextBox1.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(192))
        TextBox1.Location = New Point(254, 328)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(424, 23)
        TextBox1.TabIndex = 4
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox2
        ' 
        TextBox2.AcceptsReturn = True
        TextBox2.AcceptsTab = True
        TextBox2.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        TextBox2.Location = New Point(254, 397)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(424, 23)
        TextBox2.TabIndex = 5
        TextBox2.TextAlign = HorizontalAlignment.Center
        TextBox2.UseSystemPasswordChar = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.logo2
        PictureBox1.Image = My.Resources.Resources.logo2
        PictureBox1.Location = New Point(293, 31)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(328, 212)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackgroundImage = My.Resources.Resources.cree
        MenuStrip1.Items.AddRange(New ToolStripItem() {AboutToolStripMenuItem, CommunityToolStripMenuItem, HistoryToolStripMenuItem, AcademicsToolStripMenuItem, CoCurricularToolStripMenuItem, VisionToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1029, 24)
        MenuStrip1.TabIndex = 7
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ContactFormToolStripMenuItem, BackgroundToolStripMenuItem, EducationAsAPillarToolStripMenuItem})
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(52, 20)
        AboutToolStripMenuItem.Text = "About"
        ' 
        ' ContactFormToolStripMenuItem
        ' 
        ContactFormToolStripMenuItem.Name = "ContactFormToolStripMenuItem"
        ContactFormToolStripMenuItem.Size = New Size(181, 22)
        ContactFormToolStripMenuItem.Text = "Contact Form"
        ' 
        ' BackgroundToolStripMenuItem
        ' 
        BackgroundToolStripMenuItem.Name = "BackgroundToolStripMenuItem"
        BackgroundToolStripMenuItem.Size = New Size(181, 22)
        BackgroundToolStripMenuItem.Text = "Background"
        ' 
        ' EducationAsAPillarToolStripMenuItem
        ' 
        EducationAsAPillarToolStripMenuItem.Name = "EducationAsAPillarToolStripMenuItem"
        EducationAsAPillarToolStripMenuItem.Size = New Size(181, 22)
        EducationAsAPillarToolStripMenuItem.Text = "Education As a Pillar"
        ' 
        ' CommunityToolStripMenuItem
        ' 
        CommunityToolStripMenuItem.Name = "CommunityToolStripMenuItem"
        CommunityToolStripMenuItem.Size = New Size(83, 20)
        CommunityToolStripMenuItem.Text = "Community"
        ' 
        ' HistoryToolStripMenuItem
        ' 
        HistoryToolStripMenuItem.Name = "HistoryToolStripMenuItem"
        HistoryToolStripMenuItem.Size = New Size(57, 20)
        HistoryToolStripMenuItem.Text = "History"
        ' 
        ' AcademicsToolStripMenuItem
        ' 
        AcademicsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {KCPEToolStripMenuItem, KPSEAToolStripMenuItem, Grade6ToolStripMenuItem})
        AcademicsToolStripMenuItem.Name = "AcademicsToolStripMenuItem"
        AcademicsToolStripMenuItem.Size = New Size(77, 20)
        AcademicsToolStripMenuItem.Text = "Academics"
        ' 
        ' KCPEToolStripMenuItem
        ' 
        KCPEToolStripMenuItem.Name = "KCPEToolStripMenuItem"
        KCPEToolStripMenuItem.Size = New Size(114, 22)
        KCPEToolStripMenuItem.Text = "KCPE"
        ' 
        ' KPSEAToolStripMenuItem
        ' 
        KPSEAToolStripMenuItem.Name = "KPSEAToolStripMenuItem"
        KPSEAToolStripMenuItem.Size = New Size(114, 22)
        KPSEAToolStripMenuItem.Text = "KPSEA"
        ' 
        ' Grade6ToolStripMenuItem
        ' 
        Grade6ToolStripMenuItem.Name = "Grade6ToolStripMenuItem"
        Grade6ToolStripMenuItem.Size = New Size(114, 22)
        Grade6ToolStripMenuItem.Text = "Grade 6"
        ' 
        ' CoCurricularToolStripMenuItem
        ' 
        CoCurricularToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AbstractToolStripMenuItem})
        CoCurricularToolStripMenuItem.Name = "CoCurricularToolStripMenuItem"
        CoCurricularToolStripMenuItem.Size = New Size(91, 20)
        CoCurricularToolStripMenuItem.Text = "Co-Curricular"
        ' 
        ' AbstractToolStripMenuItem
        ' 
        AbstractToolStripMenuItem.Name = "AbstractToolStripMenuItem"
        AbstractToolStripMenuItem.Size = New Size(118, 22)
        AbstractToolStripMenuItem.Text = "Abstract"
        ' 
        ' VisionToolStripMenuItem
        ' 
        VisionToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {MissionToolStripMenuItem, AchievementsToolStripMenuItem})
        VisionToolStripMenuItem.Name = "VisionToolStripMenuItem"
        VisionToolStripMenuItem.Size = New Size(51, 20)
        VisionToolStripMenuItem.Text = "Vision"
        ' 
        ' MissionToolStripMenuItem
        ' 
        MissionToolStripMenuItem.Name = "MissionToolStripMenuItem"
        MissionToolStripMenuItem.Size = New Size(149, 22)
        MissionToolStripMenuItem.Text = "Mission"
        ' 
        ' AchievementsToolStripMenuItem
        ' 
        AchievementsToolStripMenuItem.Name = "AchievementsToolStripMenuItem"
        AchievementsToolStripMenuItem.Size = New Size(149, 22)
        AchievementsToolStripMenuItem.Text = "Achievements"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.muringato
        ClientSize = New Size(1029, 687)
        Controls.Add(PictureBox1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Muringato"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Dim connectionString As String = "server=127.0.0.1;userid=muringatoadmin;password=alloh8&7;database=muringato;"
    Dim connection As MySqlConnection

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New MySqlConnection(connectionString)
    End Sub

    Private WithEvents BtnButton1 As System.Windows.Forms.Button
    Private Sub BtnButton1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim txtUsername As Object = Me.Controls("TextBox1")
        Dim username As String = txtUsername.Text
        Dim txtPassword As Object = Me.Controls("TextBox2")
        Dim password As String = txtPassword.Text

        If username = "" Or password = "" Then
            MessageBox.Show("Please enter both Username and Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim md5 As MD5 = MD5.Create()
        Dim inputBytes As Byte() = Encoding.ASCII.GetBytes(password)
        Dim hashBytes As Byte() = md5.ComputeHash(inputBytes)
        Dim hashedPassword As String = BitConverter.ToString(hashBytes).Replace("-", "").ToLower()

        Try
            connection.Open()
            Dim query As String = "SELECT * FROM users WHERE user = @user AND password = @password"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@user", username)
            cmd.Parameters.AddWithValue("@password", hashedPassword)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.HasRows Then
                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Open Main Form
                Dim mainForm As New MainForm()
                mainForm.Show()
                Me.Hide()
            Else
                MessageBox.Show("Invalid Username or Password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try
    End Sub
    Private Sub BtnForgotPassword_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("Contact the Database Administrator for password recovery.", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CommunityToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcademicsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KCPEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KPSEAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CoCurricularToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbstractToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VisionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MissionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AchievementsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackgroundToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EducationAsAPillarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Grade6ToolStripMenuItem As ToolStripMenuItem


End Class
