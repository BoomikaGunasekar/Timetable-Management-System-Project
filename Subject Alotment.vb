Imports System.Data.SqlClient
Public Class Subject_Alotment
    Dim conn As New SqlConnection("Data Source=LAPTOP-SHSHMKK1\SQLEXPRESS01;Initial Catalog=Record;Integrated Security=True")
    Dim con As New SqlConnection("Data Source=LAPTOP-SHSHMKK1\SQLEXPRESS01;Initial Catalog=Alotment;Integrated Security=True")
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub Subject_Alotment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BindData()
        conn.Open()
        Dim strsql As New SqlCommand("select distinct SelectProgrammae from programdetails", conn)
        Dim myreader As SqlDataReader = strsql.ExecuteReader
        cmbProgrammae.Items.Clear()
        While myreader.Read()
            cmbProgrammae.Items.Add(myreader("SelectProgrammae"))
        End While
        conn.Close()

        conn.Open()
        Dim strsql2 As New SqlCommand("select distinct Course from programdetails", conn)
        Dim myreader2 As SqlDataReader = strsql2.ExecuteReader
        cmbCourse.Items.Clear()
        While myreader2.Read()
            cmbCourse.Items.Add(myreader2("Course"))
        End While
        conn.Close()

        conn.Open()
        Dim strsql3 As New SqlCommand("select distinct Years from Subject_Details", conn)
        Dim myreader3 As SqlDataReader = strsql3.ExecuteReader
        cmbYear.Items.Clear()
        While myreader3.Read()
            cmbYear.Items.Add(myreader3("Years"))
        End While
        conn.Close()

        conn.Open()
        Dim strsql4 As New SqlCommand("select distinct Semester from Subject_Details", conn)
        Dim myreader4 As SqlDataReader = strsql4.ExecuteReader
        cmbSemester.Items.Clear()
        While myreader4.Read()
            cmbSemester.Items.Add(myreader4("Semester"))
        End While
        conn.Close()

        conn.Open()
        Dim strsql5 As New SqlCommand("select distinct Subject_Code from Subject_Details", conn)
        Dim myreader5 As SqlDataReader = strsql5.ExecuteReader
        cmbSubjectCode.Items.Clear()
        While myreader5.Read()
            cmbSubjectCode.Items.Add(myreader5("Subject_Code"))
        End While
        conn.Close()

  


        conn.Open()
        Dim strsql9 As New SqlCommand("select distinct IDNumber from Staff_Details", conn)
        Dim myreader9 As SqlDataReader = strsql9.ExecuteReader
        cmbIDNumber.Items.Clear()
        While myreader9.Read()
            cmbIDNumber.Items.Add(myreader9("IDNumber"))
        End While
        conn.Close()


    End Sub

    

    Private connection As String = "Data Source=LAPTOP-SHSHMKK1\SQLEXPRESS01;Initial Catalog=Alotment;Integrated Security=True"
    Private Sub btnAlot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlot.Click
        If cmbProgrammae.Text = "" Then
            MessageBox.Show("Enter the Details", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        ElseIf cmbCourse.Text = "" Then
            MessageBox.Show("Enter the Details", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        ElseIf cmbYear.Text = "" Then
            MessageBox.Show("Enter the Details", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        ElseIf cmbSemester.Text = "" Then
            MessageBox.Show("Enter the Details", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        ElseIf cmbSection.Text = "" Then
            MessageBox.Show("Enter the Details", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        ElseIf cmbIDNumber.Text = "" Then
            MessageBox.Show("Enter the Details", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        ElseIf cmbStaffName.Text = "" Then
            MessageBox.Show("Enter the Details", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        ElseIf cmbSubjectName.Text = "" Then
            MessageBox.Show("Enter the Details", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        ElseIf cmbSubjectCode.Text = "" Then
            MessageBox.Show("Enter the Details", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        ElseIf cmbNumberofHours.Text = "" Then
            MessageBox.Show("Enter the Details", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)


        Else


            Dim query As String = "SELECT COUNT(*) FROM Subject_Alotment WHERE Programmae=@Programmae AND Course=@Course AND Years=@Years AND Semester=@Semester AND Section=@Section AND Staff_Name=@Staff_Name AND Subject_Name=@Subject_Name AND Number_of_Hours=@Number_of_Hours AND (ID_Number=@ID_Number OR Subject_Code=@Subject_Code)"
            Dim SubjectCodeExistsQuery As String = "SELECT COUNT(*) FROM Subject_Alotment WHERE Programmae=@Programmae AND Course=@Course AND Years=@Years AND Semester=@Semester AND Section=@Section AND Subject_Code=@Subject_Code AND ID_Number<>@ID_Number"
            Using con As New SqlConnection(connection)
                con.Open()
                Using cmd As New SqlCommand(query, con)

                    cmd.Parameters.AddWithValue("@Programmae", cmbProgrammae.Text)
                    cmd.Parameters.AddWithValue("@Course", cmbCourse.Text)
                    cmd.Parameters.AddWithValue("@Years", cmbYear.Text)
                    cmd.Parameters.AddWithValue("@Semester", cmbSemester.Text)
                    cmd.Parameters.AddWithValue("@Section", cmbSection.Text)
                    cmd.Parameters.AddWithValue("@ID_Number", cmbIDNumber.Text)
                    cmd.Parameters.AddWithValue("@Staff_Name", cmbStaffName.Text)
                    cmd.Parameters.AddWithValue("@Subject_Name", cmbSubjectName.Text)
                    cmd.Parameters.AddWithValue("@Subject_Code", cmbSubjectCode.Text)
                    cmd.Parameters.AddWithValue("@Number_of_Hours", cmbNumberofHours.Text)


                    Dim count As Integer = CInt(cmd.ExecuteScalar())
                    If count > 0 Then
                        MessageBox.Show("This Subject Alotment Already Exists", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)


                    Else

                        Using Subjectcodecommand As New SqlCommand(SubjectCodeExistsQuery, con)
                            Subjectcodecommand.Parameters.AddWithValue("@Programmae", cmbProgrammae.Text)
                            Subjectcodecommand.Parameters.AddWithValue("@Course", cmbCourse.Text)
                            Subjectcodecommand.Parameters.AddWithValue("@Years", cmbYear.Text)
                            Subjectcodecommand.Parameters.AddWithValue("@Semester", cmbSemester.Text)
                            Subjectcodecommand.Parameters.AddWithValue("@Section", cmbSection.Text)
                            Subjectcodecommand.Parameters.AddWithValue("@Subject_Code", cmbSubjectCode.Text)
                            Subjectcodecommand.Parameters.AddWithValue("@ID_Number", cmbIDNumber.Text)
                            Dim SubjectCodeRecordCount As Integer = Convert.ToInt32(Subjectcodecommand.ExecuteScalar())
                            If SubjectCodeRecordCount > 0 Then
                                MessageBox.Show("Can't Insert! This Subject is Already Allotted for Another Staff", "Information", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                            Else


                                Dim insertQuery As String = "INSERT INTO Subject_Alotment(Programmae,Course,Years,Semester,Section,ID_Number,Staff_Name,Subject_Name,Subject_Code,Number_of_Hours)" & "VALUES(@Programmae,@Course,@Years,@Semester,@Section,@ID_Number,@Staff_Name,@Subject_Name,@Subject_Code,@Number_of_Hours)"
                                Dim insertcommand As New SqlCommand(insertQuery, con)
                                insertcommand.Parameters.AddWithValue("@Programmae", cmbProgrammae.Text)
                                insertcommand.Parameters.AddWithValue("@Course", cmbCourse.Text)
                                insertcommand.Parameters.AddWithValue("@Years", cmbYear.Text)
                                insertcommand.Parameters.AddWithValue("@Semester", cmbSemester.Text)
                                insertcommand.Parameters.AddWithValue("@Section", cmbSection.Text)
                                insertcommand.Parameters.AddWithValue("@ID_Number", cmbIDNumber.Text)
                                insertcommand.Parameters.AddWithValue("@Staff_Name", cmbStaffName.Text)
                                insertcommand.Parameters.AddWithValue("@Subject_Name", cmbSubjectName.Text)
                                insertcommand.Parameters.AddWithValue("@Subject_Code", cmbSubjectCode.Text)
                                insertcommand.Parameters.AddWithValue("@Number_of_Hours", cmbNumberofHours.Text)

                                insertcommand.ExecuteNonQuery()
                                MessageBox.Show("Subject Alotted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                                BindData()
                                cmbProgrammae.SelectedIndex = -1
                                cmbCourse.SelectedIndex = -1
                                cmbYear.SelectedIndex = -1
                                cmbSemester.SelectedIndex = -1
                                cmbSection.SelectedIndex = -1
                                cmbIDNumber.SelectedIndex = -1
                                cmbStaffName.SelectedIndex = -1
                                cmbSubjectCode.SelectedIndex = -1
                                cmbSubjectName.SelectedIndex = -1
                                cmbNumberofHours.SelectedIndex = -1
                            End If
                        End Using
                    End If
                End Using

            End Using
        End If
    End Sub



    Public Sub BindData()
        Dim query As String = "SELECT * FROM Subject_Alotment"
        Using con As SqlConnection = New SqlConnection("Data Source=LAPTOP-SHSHMKK1\SQLEXPRESS01;Initial Catalog=Alotment;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        GridSubjectAlotment.DataSource = dt
                        GridSubjectAlotment.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 9, FontStyle.Bold)
                    End Using
                End Using
            End Using
        End Using

    End Sub


    Private Sub cmbSubjectName_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSubjectName.SelectedIndexChanged
        cmbSubjectCode.Items.Clear()
        If cmbSubjectName.SelectedItem Is Nothing Then
            Return
        End If
        Dim selectedSubjectName As String = cmbSubjectName.SelectedItem.ToString()
        Dim query As String = "SELECT Subject_Code from Subject_Details WHERE Subject=@Subject"
        Using cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("Subject", selectedSubjectName)
            conn.Open()
            Dim Subject_Code As Object = cmd.ExecuteScalar()
            cmbSubjectCode.Text = ""
            If Subject_Code IsNot Nothing Then

                cmbSubjectCode.Items.Add(Subject_Code.ToString())
            
            End If
            conn.Close()
        End Using

        conn.Open()
        Dim strsql5 As New SqlCommand("select distinct No_of_Hours from Subject_Details where Subject='" + cmbSubjectName.Text + "'", conn)
        Dim myreader5 As SqlDataReader = strsql5.ExecuteReader
        cmbNumberofHours.Text = ""
        cmbNumberofHours.Items.Clear()
        While myreader5.Read()
            cmbNumberofHours.Items.Add(myreader5("No_of_Hours"))
        End While
        conn.Close()
    End Sub





    Private Sub cmbIDNumber_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbIDNumber.SelectedIndexChanged
        conn.Open()
        Dim strsql3 As New SqlCommand("select Name from Staff_Details where IDNumber='" + cmbIDNumber.Text + "'", conn)
        Dim myreader3 As SqlDataReader = strsql3.ExecuteReader
        cmbStaffName.Text = ""
        cmbStaffName.Items.Clear()
        While myreader3.Read()
            cmbStaffName.Items.Add(myreader3("Name"))
        End While
        conn.Close()
    End Sub


    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim conn As String = "Data Source=LAPTOP-SHSHMKK1\SQLEXPRESS01;Initial Catalog=Alotment;Integrated Security=True"
        If GridSubjectAlotment.SelectedRows.Count > 0 Then
            Dim SelectedRow As DataGridViewRow = GridSubjectAlotment.SelectedRows(0)
            Dim Programmae As String = SelectedRow.Cells("Programmae").Value.ToString()

            Dim Course As String = SelectedRow.Cells("Course").Value.ToString()
            Dim Years As String = SelectedRow.Cells("Years").Value.ToString()
            Dim Semester As String = SelectedRow.Cells("Semester").Value.ToString()
            Dim Section As String = SelectedRow.Cells("Section").Value.ToString()
            Dim IDNumber As String = SelectedRow.Cells("ID_Number").Value.ToString()
            Dim StaffName As String = SelectedRow.Cells("Staff_Name").Value.ToString()
            Dim SubjectName As String = SelectedRow.Cells("Subject_Name").Value.ToString()
            Dim SubjectCode As String = SelectedRow.Cells("Subject_Code").Value.ToString()
            Dim NumberofHours As String = SelectedRow.Cells("Number_of_Hours").Value.ToString()
            Dim confirmation As DialogResult = MessageBox.Show("Are you want to Delete the Row you have Selected?", "Selected Row Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If confirmation = DialogResult.Yes Then
                Using connection As New SqlConnection(conn)
                    connection.Open()
                    Dim deletequery As String = "DELETE FROM Subject_Alotment WHERE Programmae=@Programmae AND Course=@Course AND Years=@Years AND Semester=@Semester AND Section=@Section AND ID_Number=@IDNumber AND Staff_Name=@StaffName AND Subject_Name=@SubjectName AND Subject_Code=@SubjectCode AND Number_of_Hours=@NumberofHours"
                    Using Command As New SqlCommand(deletequery, connection)
                        Command.Parameters.AddWithValue("@Programmae", Programmae)
                        Command.Parameters.AddWithValue("@Course", Course)
                        Command.Parameters.AddWithValue("@Years", Years)
                        Command.Parameters.AddWithValue("@Semester", Semester)
                        Command.Parameters.AddWithValue("@Section", Section)
                        Command.Parameters.AddWithValue("@IDNumber", IDNumber)
                        Command.Parameters.AddWithValue("@StaffName", StaffName)
                        Command.Parameters.AddWithValue("@SubjectName", SubjectName)
                        Command.Parameters.AddWithValue("@SubjectCode", SubjectCode)
                        Command.Parameters.AddWithValue("@NumberofHours", NumberofHours)
                        Command.ExecuteNonQuery()
                    End Using
                End Using
                GridSubjectAlotment.Rows.Remove(SelectedRow)
            End If
        Else
            MessageBox.Show("Select a Row below to Delete", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim query As String = "SELECT * FROM Subject_Alotment where ID_Number='" & cmbIDNumber.Text & "'"
        Using con As SqlConnection = New SqlConnection("Data Source=LAPTOP-SHSHMKK1\SQLEXPRESS01;Initial Catalog=Alotment;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        GridSubjectAlotment.DataSource = dt
                        If cmbIDNumber.Text = "" Then
                            MessageBox.Show("Select the IDNumber then Search", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        ElseIf dt.Rows.Count > 0 Then
                            cmbProgrammae.Text = dt.Rows(0)(0).ToString()
                            cmbCourse.Text = dt.Rows(0)(1).ToString()

                            cmbYear.Text = dt.Rows(0)(2).ToString()
                            cmbSemester.Text = dt.Rows(0)(3).ToString()
                            cmbSection.Text = dt.Rows(0)(4).ToString()
                            cmbIDNumber.Text = dt.Rows(0)(5).ToString()
                            cmbStaffName.Text = dt.Rows(0)(6).ToString()
                            cmbSubjectName.Text = dt.Rows(0)(7).ToString()
                            cmbSubjectCode.Text = dt.Rows(0)(8).ToString()
                            cmbNumberofHours.Text = dt.Rows(0)(9).ToString()
                            cmbIDNumber.Text = ""

                        Else
                            MessageBox.Show("No Details Found", "Information", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation)
                            cmbIDNumber.Text = ""
                            cmbProgrammae.Text = ""
                            cmbCourse.Text = ""
                            cmbYear.Text = ""
                            cmbSemester.Text = ""
                            cmbSection.Text = ""
                            cmbStaffName.Text = ""
                            cmbSubjectName.Text = ""
                            cmbSubjectCode.Text = ""
                            cmbNumberofHours.Text = ""
                        End If
                    End Using
                End Using
            End Using
        End Using
    End Sub


    Private Sub cmbCourse_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCourse.SelectedIndexChanged
        conn.Open()
        Dim strsql As New SqlCommand("select distinct Section from Class_Details where Course='" + cmbCourse.Text + "'", conn)
        Dim myreader As SqlDataReader = strsql.ExecuteReader
        cmbSection.Text = ""
        cmbSection.Items.Clear()
        While myreader.Read()
            cmbSection.Items.Add(myreader("Section"))
        End While
        conn.Close()

        conn.Open()
        Dim strsql2 As New SqlCommand("select distinct Subject from Subject_Details where Course='" + cmbCourse.Text + "'", conn)
        Dim myreader2 As SqlDataReader = strsql2.ExecuteReader
        cmbSubjectName.Text = ""
        cmbSubjectName.Items.Clear()
        While myreader2.Read()
            cmbSubjectName.Items.Add(myreader2("Subject"))
        End While
        conn.Close()

        conn.Open()
        Dim strsql3 As New SqlCommand("select distinct Years from Subject_Details where Course='" + cmbCourse.Text + "'", conn)
        Dim myreader3 As SqlDataReader = strsql3.ExecuteReader
        cmbYear.Text = ""
        cmbYear.Items.Clear()
        While myreader3.Read()
            cmbYear.Items.Add(myreader3("Years"))
        End While
        conn.Close()

        



    End Sub

    Private Sub cmbSubjectCode_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSubjectCode.SelectedIndexChanged
        conn.Open()
        Dim strsql As New SqlCommand("select distinct No_of_Hours from Subject_Details where Subject_Code='" + cmbSubjectCode.Text + "'", conn)
        Dim myreader As SqlDataReader = strsql.ExecuteReader

        cmbNumberofHours.Text = ""
        cmbNumberofHours.Items.Clear()
        While myreader.Read()
            cmbNumberofHours.Items.Add(myreader("No_of_Hours"))
        End While
        conn.Close()
    End Sub

    Private Sub cmbYear_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbYear.SelectedIndexChanged
        conn.Open()
        Dim strsql4 As New SqlCommand("select distinct Semester from Subject_Details where Years='" + cmbYear.Text + "'", conn)
        Dim myreader4 As SqlDataReader = strsql4.ExecuteReader
        cmbSemester.Text = ""
        cmbSemester.Items.Clear()
        While myreader4.Read()
            cmbSemester.Items.Add(myreader4("Semester"))
        End While
        conn.Close()
    End Sub

    Private Sub cmbProgrammae_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbProgrammae.SelectedIndexChanged, cmbCourse.SelectedIndexChanged, cmbYear.SelectedIndexChanged, cmbSemester.SelectedIndexChanged
      

        If cmbProgrammae.SelectedItem Is Nothing OrElse
            cmbCourse.SelectedItem Is Nothing OrElse
            cmbYear.SelectedItem Is Nothing OrElse
            cmbSemester.SelectedItem Is Nothing Then
            Return
        End If

        Dim selectedProgrammae As String = cmbProgrammae.SelectedItem.ToString()
        Dim selectedCourse As String = cmbCourse.SelectedItem.ToString()
        Dim selectedYears As String = cmbYear.SelectedItem.ToString()
        Dim selectedSemester As String = cmbSemester.SelectedItem.ToString()

        Dim query As String = "SELECT Subject from Subject_Details WHERE Programmae=@Programmae AND Course=@Course AND Years=@Years AND Semester=@Semester"
        Using cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@Programmae", selectedProgrammae)
            cmd.Parameters.AddWithValue("@Course", selectedCourse)
            cmd.Parameters.AddWithValue("@Years", selectedYears)
            cmd.Parameters.AddWithValue("@Semester", selectedSemester)
            conn.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            cmbSubjectName.Items.Clear()
            While reader.Read()
                cmbSubjectName.Items.Add(reader("Subject").ToString())
            End While
            reader.Close()
            conn.Close()
           
        End Using
        conn.Close()
    End Sub
End Class
