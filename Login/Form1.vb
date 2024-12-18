Imports MySql.Data.MySqlClient
Imports MySql
Imports Mysqlx

Public Class Form1
    ' Connection string to MySQL database
    Dim connectionString As String = "server=127.0.0.1;userid=muringatoadmin;password=alloh8&7;database=muringato;"
    Dim connection As MySqlConnection

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New MySqlConnection(connectionString)
    End Sub

    ' Login Button Click Event
    Private WithEvents btnLogin As System.Windows.Forms.Button

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim txtUsername As Object = Nothing
        Dim username As String = txtUsername.Text.Trim()
        Dim txtPassword As Object = Nothing
        Dim password As String = txtPassword.Text.Trim()

        If username = "" Or password = "" Then
            MessageBox.Show("Please enter both Username and Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            connection.Open()
            Dim query As String = "SELECT * FROM users WHERE username = @username AND password = @password"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password)

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

    ' Forgot Password Button Click Event
    Private WithEvents btnForgotPassword As System.Windows.Forms.Button

    Private Sub BtnForgotPassword_Click(sender As Object, e As EventArgs) Handles btnForgotPassword.Click
        MessageBox.Show("Contact the Database Administrator for password recovery.", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
