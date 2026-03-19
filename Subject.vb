Imports System.Data.SqlClient
Public Class Subjecttext

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

  
    Dim conn As New SqlConnection("Data Source=LAPTOP-SHSHMKK1\SQLEXPRESS01;Initial Catalog=Record;Integrated Security=True")

    Private Sub Subjecttext_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        BindData()
        conn.Open()
        Dim strsql As New SqlCommand("select distinct SelectProgrammae from programdetails", conn)
        Dim myreader As SqlDataReader = strsql.ExecuteReader
        cmbprogrammae.Items.Clear()
        While myreader.Read()
            cmbprogrammae.Items.Add(myreader("SelectProgrammae"))
        End While
        conn.Close()
    End Sub

    Private Sub cmbprogrammae_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbprogrammae.SelectedIndexChanged
        conn.Open()
        Dim strsql2 As New SqlCommand("select Course from programdetails where Selectprogrammae='" + cmbprogrammae.Text + "'", conn)
        Dim myreader2 As SqlDataReader = strsql2.ExecuteReader
        cmbcourse.Text = ""
        cmbcourse.Items.Clear()
        While myreader2.Read()
            cmbcourse.Items.Add(myreader2("Course"))
        End While
        conn.Close()
    End Sub

   
   

    Private Sub btninsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btninsert.Click


        Dim Programmae As String = cmbprogrammae.Text
        Dim Course As String = cmbcourse.Text
        Dim Year As String = txtYear.Text
        Dim Semester As String = txtSem.Text
        Dim Subject As String = txtSubject.Text
        Dim SubjectCode As String = txtsubjectcode.Text
        Dim No_of_Hours As String = txtHours.Text

        Dim query As String = "Insert into Subject_Details values(@Programmae,@Course,@Year,@Semester,@Subject,@Subject_Code,@No_of_Hours)"
        Using conn As SqlConnection = New SqlConnection("Data Source=LAPTOP-SHSHMKK1\SQLEXPRESS01;Initial Catalog=Record;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, conn)

                If Programmae = "" Then
                    MessageBox.Show("Enter the Details", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                ElseIf Course = "" Then
                    MessageBox.Show("Enter the Details", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                ElseIf Year = "" Then
                    MessageBox.Show("Enter the Details", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                ElseIf Semester = "" Then
                    MessageBox.Show("Enter the Details", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                ElseIf Subject = "" Then
                    MessageBox.Show("Enter the Details", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                ElseIf SubjectCode = "" Then
                    MessageBox.Show("Enter the Details", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                ElseIf No_of_Hours = "" Then
                    MessageBox.Show("Enter the Details", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)

                Else
                    cmd.Parameters.AddWithValue("@Programmae", Programmae)
                    cmd.Parameters.AddWithValue("@Course", Course)
                    cmd.Parameters.AddWithValue("@Year", Year)
                    cmd.Parameters.AddWithValue("@Semester", Semester)
                    cmd.Parameters.AddWithValue("@Subject", Subject)
                    cmd.Parameters.AddWithValue("@Subject_Code", SubjectCode)
                    cmd.Parameters.AddWithValue("@No_of_Hours", No_of_Hours)



                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                    txtYear.Clear()
                    txtSem.Clear()
                    txtSubject.Clear()
                    txtsubjectcode.Clear()
                    txtHours.Clear()
                    MessageBox.Show("Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    BindData()

                End If
            End Using
        End Using

    End Sub
    Public Sub BindData()
        Dim query As String = "SELECT * FROM Subject_Details"
        Using conn As SqlConnection = New SqlConnection("Data Source=LAPTOP-SHSHMKK1\SQLEXPRESS01;Initial Catalog=Record;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, conn)
                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        GridSubjectdetails.DataSource = dt
                        GridSubjectdetails.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 8, FontStyle.Bold)
                    End Using
                End Using
            End Using
        End Using

    End Sub

   

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim SubjectCode As String = txtsubjectcode.Text

        Dim query As String = "Delete Subject_Details where Subject_Code = @Subject_Code"
        Using con As SqlConnection = New SqlConnection("Data Source=LAPTOP-SHSHMKK1\SQLEXPRESS01;Initial Catalog=Record;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                If SubjectCode = "" Then
                    MessageBox.Show("Enter the Subject Code", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Else

                    cmd.Parameters.AddWithValue("@Subject_Code", SubjectCode)

                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                    txtSubject.Clear()
                    txtsubjectcode.Clear()
                    txtSem.Clear()
                    txtHours.Clear()

                    MessageBox.Show("Deleted Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    BindData()

                End If
            End Using
        End Using
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim query As String = "SELECT * FROM Subject_Details where Subject_Code='" & txtsubjectcode.Text & "'"
        Using con As SqlConnection = New SqlConnection("Data Source=LAPTOP-SHSHMKK1\SQLEXPRESS01;Initial Catalog=Record;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        GridSubjectdetails.DataSource = dt
                        If txtsubjectcode.Text = "" Then
                            MessageBox.Show("Enter the Subject Code", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        ElseIf dt.Rows.Count > 0 Then
                            cmbprogrammae.Text = dt.Rows(0)(0).ToString()
                            cmbcourse.Text = dt.Rows(0)(1).ToString()
                            
                            txtYear.Text = dt.Rows(0)(2).ToString()
                            txtSem.Text = dt.Rows(0)(3).ToString()
                            txtSubject.Text = dt.Rows(0)(4).ToString()
                            txtsubjectcode.Text = dt.Rows(0)(5).ToString()
                            txtHours.Text = dt.Rows(0)(6).ToString()

                        Else
                            MessageBox.Show("No Details Found", "Information", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation)
                            txtsubjectcode.Text = ""
                        End If
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim Programmae As String = cmbprogrammae.Text
        Dim Course As String = cmbcourse.Text
        Dim Year As String = txtYear.Text
        Dim Semester As String = txtSem.Text
        Dim Subject As String = txtSubject.Text
        Dim SubjectCode As String = txtsubjectcode.Text
        Dim No_of_Hours As String = txtHours.Text

        Dim query As String = "Update  Subject_Details SET Programmae =@Programmae,Course =@Course,Years =@Years,Semester =@Semester,Subject =@Subject,No_of_Hours =@No_of_Hours WHERE Subject_Code =@Subject_Code"
        Using conn As SqlConnection = New SqlConnection("Data Source=LAPTOP-SHSHMKK1\SQLEXPRESS01;Initial Catalog=Record;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, conn)

                
                    If Programmae = "" Then
                        MessageBox.Show("Enter the Details", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ElseIf Course = "" Then
                        MessageBox.Show("Enter the Details", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ElseIf Year = "" Then
                        MessageBox.Show("Enter the Details", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ElseIf Semester = "" Then
                        MessageBox.Show("Enter the Details", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ElseIf Subject = "" Then
                        MessageBox.Show("Enter the Details", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ElseIf SubjectCode = "" Then
                    MessageBox.Show("Enter the Details ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ElseIf No_of_Hours = "" Then
                        MessageBox.Show("Enter the Details", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Else
                        cmd.Parameters.AddWithValue("@Programmae", Programmae)
                        cmd.Parameters.AddWithValue("@Course", Course)
                    cmd.Parameters.AddWithValue("@Years", Year)
                        cmd.Parameters.AddWithValue("@Semester", Semester)
                        cmd.Parameters.AddWithValue("@Subject", Subject)
                        cmd.Parameters.AddWithValue("@Subject_Code", SubjectCode)
                        cmd.Parameters.AddWithValue("@No_of_Hours", No_of_Hours)



                        conn.Open()
                        cmd.ExecuteNonQuery()
                        conn.Close()
                        txtYear.Clear()
                        txtSem.Clear()
                        txtSubject.Clear()
                        txtsubjectcode.Clear()
                        txtHours.Clear()
                        MessageBox.Show("Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        BindData()

                    End If
            End Using
        End Using

    End Sub
End Class