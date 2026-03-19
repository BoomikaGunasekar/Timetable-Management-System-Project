Imports System.Data.SqlClient

Public Class Course

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub
    
   
    Dim con As SqlConnection = New SqlConnection("Data Source=LAPTOP-SHSHMKK1\SQLEXPRESS01;Initial Catalog=Record;Integrated Security=True")
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        con.Open()
        Dim cmd1 As New SqlCommand("Select SelectProgrammae,Course from programdetails where Course=@Course", con)
        cmd1.Parameters.AddWithValue("@Course", txtcourse.Text)
        Dim myreader As SqlDataReader
        myreader = cmd1.ExecuteReader()

        If (myreader.Read()) Then
            con.Close()
            MessageBox.Show("Course Already Exists", "Error Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            txtcourse.Clear()

            con.Close()
        Else
            con.Close()

            Dim SelectProgrammae As String = ""
            If RbtnUG.Checked = True Then
                SelectProgrammae = RbtnUG.Text
            ElseIf RbtnPG.Checked = True Then
                SelectProgrammae = RbtnPG.Text
            End If

            Dim Course As String = txtcourse.Text

            Dim query As String = "Insert into programdetails values(@SelectProgrammae,@Course)"
            Using con As SqlConnection = New SqlConnection("Data Source=LAPTOP-SHSHMKK1\SQLEXPRESS01;Initial Catalog=Record;Integrated Security=True")
                Using cmd As SqlCommand = New SqlCommand(query, con)

                    If txtcourse.Text = "" Then
                        MessageBox.Show("Enter the Details", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)

                    ElseIf SelectProgrammae = "" Then
                        MessageBox.Show("Select The Programmae", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)

                    Else
                        cmd.Parameters.AddWithValue("@SelectProgrammae", SelectProgrammae)
                        cmd.Parameters.AddWithValue("@Course", Course)
                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()
                        MessageBox.Show("Added Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        txtcourse.Clear()

                    End If

                End Using
            End Using
        End If
    End Sub

  
End Class