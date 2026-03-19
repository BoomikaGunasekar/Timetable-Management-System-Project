Imports System.Data.SqlClient
Public Class Register
    Dim conn1 As New SqlConnection("Data Source=LAPTOP-SHSHMKK1\SQLEXPRESS01;initial catalog=Login;integrated security=true;")
    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click

        conn1.Open()
        Dim cmd As New SqlCommand("Select Username,Password from New_register where Username=@Username", conn1)
        cmd.Parameters.AddWithValue("Username", txtUser.Text)
        Dim myreader As SqlDataReader
        myreader = cmd.ExecuteReader()

        If (myreader.Read()) Then
            conn1.Close()
            MessageBox.Show("Username Already Exists", "Error Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            txtUser.Clear()
            txtPass.Clear()
            conn1.Close()
        Else
            conn1.Close()
            Dim con As New SqlCommand("insert into New_Register(Username,Password) values('" & txtUser.Text & "','" & txtPass.Text & "')", conn1)

            If txtUser.Text = "" Then
                MessageBox.Show("Enter the Username And Password", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            ElseIf txtPass.Text = "" Then
                MessageBox.Show("Enter the Username And Password", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Else

                conn1.Open()
                con.ExecuteNonQuery()
                conn1.Close()
                MessageBox.Show("Registered Successfully!", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Login.Show()
                Me.Hide()

            End If
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class