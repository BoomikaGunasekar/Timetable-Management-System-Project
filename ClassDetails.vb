Imports System.Data.SqlClient
Public Class ClassDetails
    Dim conn As New SqlConnection("Data Source=LAPTOP-SHSHMKK1\SQLEXPRESS01;Initial Catalog=Record;Integrated Security=True")

    Private Sub ClassDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BindData()
        conn.Open()
        Dim strsql As New SqlCommand("select distinct SelectProgrammae from programdetails", conn)
        Dim myreader As SqlDataReader = strsql.ExecuteReader
        cmbProgrammae.Items.Clear()
        While myreader.Read()
            cmbProgrammae.Items.Add(myreader("SelectProgrammae"))
        End While
        conn.Close()

      

    End Sub

    Private Sub cmbProgrammae_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbProgrammae.SelectedIndexChanged
        conn.Open()
        Dim strsql2 As New SqlCommand("select Course from programdetails where Selectprogrammae='" + cmbProgrammae.Text + "'", conn)
        Dim myreader2 As SqlDataReader = strsql2.ExecuteReader
        cmbCourse.Text = ""
        cmbCourse.Items.Clear()
        While myreader2.Read()
            cmbCourse.Items.Add(myreader2("Course"))
        End While
        conn.Close()

        conn.Open()
        Dim strsql As New SqlCommand("select distinct Years from Subject_Details where Programmae='" + cmbProgrammae.Text + "'", conn)
        Dim myreader As SqlDataReader = strsql.ExecuteReader
        cmbYear.Text = ""
        cmbYear.Items.Clear()
        While myreader.Read()
            cmbYear.Items.Add(myreader("Years"))
        End While
        conn.Close()
    End Sub

  
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        
        Dim Programmae As String = cmbProgrammae.Text
        Dim Course As String = cmbCourse.Text
        Dim Year As String = cmbYear.Text
        Dim Section As String = txtSection.Text



        Dim query As String = "Insert into Class_Details values(@Programmae,@Course,@Years,@Section)"
                Using con As SqlConnection = New SqlConnection("Data Source=LAPTOP-SHSHMKK1\SQLEXPRESS01;Initial Catalog=Record;Integrated Security=True")
                    Using cmd As SqlCommand = New SqlCommand(query, con)

                        If cmbProgrammae.Text = "" Then
                            MessageBox.Show("Enter the Details", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                        ElseIf cmbCourse.Text = "" Then
                            MessageBox.Show("Enter the Details", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                        ElseIf cmbYear.Text = "" Then
                            MessageBox.Show("Enter the Details", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                        ElseIf txtSection.Text = "" Then
                            MessageBox.Show("Enter the Details", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                       


                        Else
                            cmd.Parameters.AddWithValue("@Programmae", Programmae)
                            cmd.Parameters.AddWithValue("@Course", Course)
                    cmd.Parameters.AddWithValue("@Years", Year)
                            cmd.Parameters.AddWithValue("@Section", Section)




                            con.Open()
                            cmd.ExecuteNonQuery()
                            con.Close()

                    MessageBox.Show("Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                            BindData()

                        End If

                    End Using
                End Using
         
    End Sub
    Public Sub BindData()
        Dim query As String = "SELECT * FROM Class_Details"
        Using con As SqlConnection = New SqlConnection("Data Source=LAPTOP-SHSHMKK1\SQLEXPRESS01;Initial Catalog=Record;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        GridClassDetails.DataSource = dt
                        GridClassDetails.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 12, FontStyle.Bold)
                    End Using
                End Using
            End Using
        End Using

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim conn As String = "Data Source=LAPTOP-SHSHMKK1\SQLEXPRESS01;Initial Catalog=Record;Integrated Security=True"
        If GridClassDetails.SelectedRows.Count > 0 Then
            Dim SelectedRow As DataGridViewRow = GridClassDetails.SelectedRows(0)
            Dim Programmae As String = SelectedRow.Cells("Programmae").Value.ToString()
            Dim Course As String = SelectedRow.Cells("Course").Value.ToString()
            Dim Years As String = SelectedRow.Cells("Years").Value.ToString()
            Dim Section As String = SelectedRow.Cells("Section").Value.ToString()
            Dim confirmation As DialogResult = MessageBox.Show("Are you want to Delete the Row you have Selected?", "Selected Row Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If confirmation = DialogResult.Yes Then
                Using connection As New SqlConnection(conn)
                    connection.Open()
                    Dim deletequery As String = "DELETE FROM Class_Details WHERE Programmae=@Programmae AND Course=@Course AND Years=@Years AND Section=@Section"
                    Using Command As New SqlCommand(deletequery, connection)
                        Command.Parameters.AddWithValue("@Programmae", Programmae)
                        Command.Parameters.AddWithValue("@Course", Course)
                        Command.Parameters.AddWithValue("@Years", Years)
                        Command.Parameters.AddWithValue("@Section", Section)
                        Command.ExecuteNonQuery()
                    End Using
                End Using
                GridClassDetails.Rows.Remove(SelectedRow)
            End If
        Else
            MessageBox.Show("Select a Row below to Delete", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        End If
    End Sub
End Class