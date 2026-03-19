Imports System.Data
Imports System.Data.SqlClient
Public Class Login

    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim rdr As SqlDataReader
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtUsername.Text = "Username"
        txtUsername.ForeColor = Color.DarkGray
        txtPassword.Text = "Password"
        txtPassword.ForeColor = Color.DarkGray
    End Sub

    Private Sub txtUsername_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsername.GotFocus
        If txtUsername.Text = "Username" Then
            txtUsername.Text = ""
            txtUsername.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtUsername_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsername.LostFocus
        If txtUsername.Text = "" Then
            txtUsername.Text = "Username"
            txtUsername.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub txtPassword_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPassword.GotFocus
        If txtPassword.Text = "Password" Then
            txtPassword.Text = ""
            txtPassword.PasswordChar = "•"
            txtPassword.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtPassword_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPassword.LostFocus
        If txtPassword.Text = "" Then
            txtPassword.Text = "Password"
            txtPassword.PasswordChar = ""
            txtPassword.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If (txtUsername.Text = "") Then
            MsgBox("Enter the Username")
            txtUsername.Focus()
            Exit Sub
        End If
        If (txtPassword.Text = "") Then
            MsgBox("Enter the Password")
            txtPassword.Focus()
            Exit Sub
        End If
        Try
            con = New SqlConnection("Data Source=LAPTOP-SHSHMKK1\SQLEXPRESS01;Initial Catalog=Login;Integrated Security=True")
            con.Open()
            cmd = New SqlCommand("select*from New_Register where username='" & txtUsername.Text & "' and password='" & txtPassword.Text & "'")
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            If (rdr.Read()) Then
                framemenu.Show()
                Me.Hide()
            Else
                MessageBox.Show("Invalid Username And Password", "Error message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                txtUsername.Clear()
                txtPassword.Clear()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        End
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Register.Show()
    End Sub

End Class