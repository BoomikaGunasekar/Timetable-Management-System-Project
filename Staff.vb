Imports System.Data.SqlClient
Public Class Staff

    Private Sub Cancelbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Me.Close()
    End Sub
    Dim con As SqlConnection = New SqlConnection("Data Source=LAPTOP-SHSHMKK1\SQLEXPRESS01;Initial Catalog=Record;Integrated Security=True")
    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        con.Open()
        Dim cmd1 As New SqlCommand("Select Name,IDNumber,Gender,Department,Qualification,MobileNumber from Staff_Details where IDNumber=@IDNumber", con)
        cmd1.Parameters.AddWithValue("@IDNumber", txtID.Text)
        Dim myreader As SqlDataReader
        myreader = cmd1.ExecuteReader()

        If (myreader.Read()) Then
            con.Close()
            MessageBox.Show("ID Already Exists", "Error Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)

            con.Close()
        Else
            con.Close()


            Dim Name As String = txtName.Text
            Dim IDNumber As String = txtID.Text
            Dim Gender As String = ""
            If RbtnMale.Checked = True Then
                Gender = RbtnMale.Text
            ElseIf RBtnFemale.Checked = True Then
                Gender = RBtnFemale.Text
            End If
            Dim Department As String = txtDepartment.Text
            Dim Qualification As String = txtQualification.Text
            Dim MobileNumber As String = txtMobilenumber.Text

            Dim query As String = "Insert into Staff_Details values(@Name,@IDNumber,@Gender,@Department,@Qualification,@MobileNumber)"
            Using con As SqlConnection = New SqlConnection("Data Source=LAPTOP-SHSHMKK1\SQLEXPRESS01;Initial Catalog=Record;Integrated Security=True")
                Using cmd As SqlCommand = New SqlCommand(query, con)

                    If txtName.Text = "" Then
                        MessageBox.Show("Enter the Details", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ElseIf Gender = "" Then
                        MessageBox.Show("Enter the Details", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ElseIf IDNumber = "" Then
                        MessageBox.Show("Enter the Details", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ElseIf Department = "" Then
                        MessageBox.Show("Enter the Details", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ElseIf Qualification = "" Then
                        MessageBox.Show("Enter the Details", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ElseIf MobileNumber = "" Then
                        MessageBox.Show("Enter the Details", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)

                    Else
                        cmd.Parameters.AddWithValue("@Name", Name)
                        cmd.Parameters.AddWithValue("@IDNumber", IDNumber)
                        cmd.Parameters.AddWithValue("@Gender", Gender)
                        cmd.Parameters.AddWithValue("@Department", Department)
                        cmd.Parameters.AddWithValue("@Qualification", Qualification)
                        cmd.Parameters.AddWithValue("@MobileNumber", MobileNumber)



                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()
                        txtName.Clear()
                        txtID.Clear()
                        txtDepartment.Clear()
                        txtQualification.Clear()
                        txtMobilenumber.Clear()
                        MessageBox.Show("Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        BindData()

                    End If

                End Using
            End Using
        End If

    End Sub
    Public Sub BindData()
        Dim query As String = "SELECT * FROM Staff_Details"
        Using con As SqlConnection = New SqlConnection("Data Source=LAPTOP-SHSHMKK1\SQLEXPRESS01;Initial Catalog=Record;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        GridStaffdetails.DataSource = dt
                        GridStaffdetails.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 8, FontStyle.Bold)
                    End Using
                End Using
            End Using
        End Using

    End Sub


    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim query As String = "SELECT * FROM Staff_Details where IDNumber='" & txtIDNumber.Text & "'"
        Using con As SqlConnection = New SqlConnection("Data Source=LAPTOP-SHSHMKK1\SQLEXPRESS01;Initial Catalog=Record;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        GridStaffdetails.DataSource = dt
                        If txtIDNumber.Text = "" Then
                            MessageBox.Show("Enter the ID", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        ElseIf dt.Rows.Count > 0 Then
                            txtName.Text = dt.Rows(0)(0).ToString()
                            txtID.Text = dt.Rows(0)(1).ToString()
                            If dt.Rows(0)(2).ToString() = "Male" Then
                                RbtnMale.Checked = True
                            Else
                                RBtnFemale.Checked = True
                            End If
                            txtDepartment.Text = dt.Rows(0)(3).ToString()
                            txtQualification.Text = dt.Rows(0)(4).ToString()
                            txtMobilenumber.Text = dt.Rows(0)(5).ToString()
                            txtIDNumber.Text = ""
                        Else
                            MessageBox.Show("No Details Found", "Information", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation)
                            txtIDNumber.Text = ""
                        End If
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim Name As String = txtName.Text
        Dim IDNumber As String = txtID.Text
        Dim Gender As String = ""
        If RbtnMale.Checked = True Then
            Gender = RbtnMale.Text
        ElseIf RBtnFemale.Checked = True Then
            Gender = RBtnFemale.Text
        End If

        Dim Department As String = txtDepartment.Text
        Dim Qualification As String = txtQualification.Text
        Dim MobileNumber As String = txtMobilenumber.Text

        Dim query As String = "Update Staff_Details SET Name =@Name,Gender =@Gender,Department =@Department,Qualification =@Qualification,MobileNumber =@MobileNumber WHERE IDNumber=@IDNumber"
        Using con As SqlConnection = New SqlConnection("Data Source=LAPTOP-SHSHMKK1\SQLEXPRESS01;Initial Catalog=Record;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                
                    If txtName.Text = "" Then
                        MessageBox.Show("Enter the Details", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ElseIf Gender = "" Then
                        MessageBox.Show("Enter the Details", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ElseIf IDNumber = "" Then
                        MessageBox.Show("Enter the Details", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ElseIf Department = "" Then
                        MessageBox.Show("Enter the Details", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ElseIf Qualification = "" Then
                        MessageBox.Show("Enter the Details", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ElseIf MobileNumber = "" Then
                        MessageBox.Show("Enter the Details", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)


                    Else

                        cmd.Parameters.AddWithValue("@Name", Name)
                        cmd.Parameters.AddWithValue("@IDNumber", IDNumber)
                        cmd.Parameters.AddWithValue("@Gender", Gender)
                        cmd.Parameters.AddWithValue("@Department", Department)
                        cmd.Parameters.AddWithValue("@Qualification", Qualification)
                        cmd.Parameters.AddWithValue("@MobileNumber", MobileNumber)

                        con.Open()
                        cmd.ExecuteNonQuery()
                        con.Close()
                        txtName.Clear()
                        txtID.Clear()
                        txtDepartment.Clear()
                        txtQualification.Clear()
                        txtMobilenumber.Clear()
                        MessageBox.Show("Updated Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        BindData()
                    End If

            End Using
        End Using

    End Sub


    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        Dim IDNumber As String = txtID.Text

        Dim query As String = "Delete Staff_Details where IDNumber = @IDNumber"
        Using con As SqlConnection = New SqlConnection("Data Source=LAPTOP-SHSHMKK1\SQLEXPRESS01;Initial Catalog=Record;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                If IDNumber = "" Then
                    MessageBox.Show("Search the ID and then Delete", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Else

                    cmd.Parameters.AddWithValue("@IDNumber", IDNumber)

                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                    txtName.Clear()
                    txtID.Clear()
                    txtDepartment.Clear()
                    txtQualification.Clear()
                    txtMobilenumber.Clear()
                    MessageBox.Show("Deleted Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    BindData()

                End If
            End Using
        End Using

    End Sub

    Private Sub Staff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BindData()
    End Sub

    Private Sub txtMobilenumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMobilenumber.KeyPress
        If (Char.IsNumber(e.KeyChar) <> True And e.KeyChar <> ControlChars.Back) Then
            MessageBox.Show("Enter Only Mobile Number", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            e.Handled = True
        End If
    End Sub

    Private Sub txtMobilenumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMobilenumber.TextChanged
        If (txtMobilenumber.TextLength = 10) Then
            ErrorProvider1.SetError(txtMobilenumber, "")
        Else
            ErrorProvider1.SetError(txtMobilenumber, "Only 10 digits MobileNumber is Valid")
        End If
    End Sub
End Class