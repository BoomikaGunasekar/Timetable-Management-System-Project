

Imports System.Data
Imports System.Data.SqlClient
Public Class Staff_Timetable
    Dim conn As New SqlConnection("Data Source=LAPTOP-SHSHMKK1\SQLEXPRESS01;Initial Catalog=Record;Integrated Security=True")
    Dim connectionstring As String = "Data Source=LAPTOP-SHSHMKK1\SQLEXPRESS01;Initial Catalog=Alotment;Integrated Security=True"

    Private Sub cancelbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub Staff_Timetable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GridStafftimetable.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 10, FontStyle.Bold)
        GridStafftimetable.RowsDefaultCellStyle.Font = New Font("Arial", 9, FontStyle.Bold)
        GridStafftimetable.RowTemplate.Height = 40
        GridStafftimetable.ColumnHeadersHeight = 40
        Dim newRow As DataGridViewRow = New DataGridViewRow()
        newRow.CreateCells(GridStafftimetable, "I")
        GridStafftimetable.Rows.Add(newRow)

        Dim newRow2 As DataGridViewRow = New DataGridViewRow()
        newRow2.CreateCells(GridStafftimetable, "II")
        GridStafftimetable.Rows.Add(newRow2)

        Dim newRow3 As DataGridViewRow = New DataGridViewRow()
        newRow3.CreateCells(GridStafftimetable, "III")
        GridStafftimetable.Rows.Add(newRow3)

        Dim newRow4 As DataGridViewRow = New DataGridViewRow()
        newRow4.CreateCells(GridStafftimetable, "IV")
        GridStafftimetable.Rows.Add(newRow4)

        Dim newRow5 As DataGridViewRow = New DataGridViewRow()
        newRow5.CreateCells(GridStafftimetable, "V")
        GridStafftimetable.Rows.Add(newRow5)

        conn.Open()
        Dim strsql As New SqlCommand("select distinct IDNumber from Staff_Details", conn)
        Dim myreader As SqlDataReader = strsql.ExecuteReader
        cmbSelectIDNumber.Items.Clear()
        While myreader.Read()
            cmbSelectIDNumber.Items.Add(myreader("IDNumber"))
        End While
        conn.Close()

        conn.Open()
        Dim strsql2 As New SqlCommand("select distinct Name from Staff_Details", conn)
        Dim myreader2 As SqlDataReader = strsql2.ExecuteReader
        cmbSelectStaff.Items.Clear()
        While myreader2.Read()
            cmbSelectStaff.Items.Add(myreader2("Name"))
        End While
        conn.Close()
    End Sub


    Private Sub cmbSelectIDNumber_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSelectIDNumber.SelectedIndexChanged
        conn.Open()
        Dim strsql As New SqlCommand("select Name from Staff_Details where IDNumber='" + cmbSelectIDNumber.Text + "'", conn)
        Dim myreader As SqlDataReader = strsql.ExecuteReader
        cmbSelectStaff.Text = ""
        cmbSelectStaff.Items.Clear()
        While myreader.Read()
            cmbSelectStaff.Items.Add(myreader("Name"))
        End While
        conn.Close()
    End Sub





    Private Sub btnview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnview.Click
        ' This code inserts rows into the "Timetable" table with IDNumber, DayOrder, only if they do not already exist.

        If cmbSelectIDNumber.SelectedItem IsNot Nothing Then
            Dim IDNumber As Integer = cmbSelectIDNumber.Text
            Dim DayOrders() As String = {"I", "II", "III", "IV", "V"}
            Dim connection As String = "Data Source=LAPTOP-SHSHMKK1\SQLEXPRESS01;Initial Catalog=Timetable;Integrated Security=True"

            Using con As New SqlConnection(connection)
                con.Open()

                For Each DayOrder As String In DayOrders
                    Dim checkquery As String = "SELECT COUNT(*) FROM Timetable WHERE IDNumber=@IDNumber AND DayOrder=@DayOrder"

                    Using checkcommand As New SqlCommand(checkquery, con)
                        checkcommand.Parameters.AddWithValue("@IDNumber", IDNumber)
                        checkcommand.Parameters.AddWithValue("@DayOrder", DayOrder)

                        Dim count As Integer = CInt(checkcommand.ExecuteScalar())

                        ' Check if the combination does not exist, then insert it
                        If count = 0 Then
                            Dim query As String = "INSERT INTO Timetable (IDNumber, DayOrder) VALUES (@IDNumber, @DayOrder)"

                            Using cmd As New SqlCommand(query, con)
                                cmd.Parameters.AddWithValue("@IDNumber", IDNumber)
                                cmd.Parameters.AddWithValue("@DayOrder", DayOrder)

                                cmd.ExecuteNonQuery()
                            End Using
                        End If
                    End Using
                Next

                ' Fetch records from Subject_Alotment table based on ID_Number
                Dim subjectQuery As String = "SELECT Subject_Name, Number_of_Hours FROM Subject_Alotment WHERE ID_Number = @IDNumber"

                Using subjectCmd As New SqlCommand(subjectQuery, con)
                    subjectCmd.Parameters.AddWithValue("@IDNumber", IDNumber)

                    Using reader As SqlDataReader = subjectCmd.ExecuteReader()
                        While reader.Read()
                            Dim subjectName As String = reader("Subject_Name").ToString()
                            Dim numberOfHours As Integer = CInt(reader("Number_of_Hours"))

                            ' Insert the subjectname into the "Timetable" table based on numberofhours
                            For i As Integer = 1 To numberOfHours
                                Dim insertQuery As String = "INSERT INTO Timetable (IDNumber, DayOrder, subjectname) VALUES (@IDNumber, @DayOrder, @subjectName)"

                                ' You can specify the DayOrder as needed, or leave it as NULL
                                Using insertCmd As New SqlCommand(insertQuery, con)
                                    insertCmd.Parameters.AddWithValue("@IDNumber", IDNumber)
                                    insertCmd.Parameters.AddWithValue("@Subject_Name", subjectName)
                                    ' You may need to specify the DayOrder value here

                                    insertCmd.ExecuteNonQuery()
                                End Using
                            Next
                        End While
                    End Using
                End Using

                con.Close()
            End Using

        Else
            MessageBox.Show("Select the IDNumber and StaffName")
        End If
    End Sub




End Class