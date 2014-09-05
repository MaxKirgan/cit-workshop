Public Class frmVendor



    Private dsVendor As DataSet

    'Method Name:           DisplayRecords
    'Purpose:               To display a record from the database for this entity 
    'Parameter:             Index - Integer 
    'Return:                None
    'Change Log:            A Hoornbeek 10/24/13


    Public Sub DisplayRecords(ByVal aIndex As Integer)

        'error handling 

        Try
            'check if there is any record
            If dsVendor.Tables("tblVendor").Rows.Count = 0 Then


                Exit Sub


            End If

            '


            ''Display the form with data
            txtVendorID.Text = dsVendor.Tables("tblVendor").Rows(aIndex).Item(0).ToString
            txtVendorName.Text = dsVendor.Tables("tblVendor").Rows(aIndex).Item(1).ToString
            txtVendorAddress.Text = dsVendor.Tables("tblVendor").Rows(aIndex).Item(2).ToString
            txtPhone.Text = dsVendor.Tables("tblVendor").Rows(aIndex).Item(3).ToString
            txtVendorEmail.Text = dsVendor.Tables("tblVendor").Rows(aIndex).Item(4).ToString
            



        Catch ex As Exception
            MessageBox.Show("Error occured in Form: frmVendor, Method: DisplayRecord(Index), Error: " _
                        & ex.Message)
        End Try




    End Sub


    Private Sub frmVendor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmSwitch.Hide()

        dsVendor = clsVendor.GetRecords()

        ' call displayrecord 
        DisplayRecords(0)
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        'error handling

        Try
            ' call displayrecord and go to the first record 
            DisplayRecords(0)



        Catch ex As Exception


            MessageBox.Show("Error occured in Form: frmVendor, Method: DisplayRecord(Index), Error: " _
                        & ex.Message)

        End Try
    End Sub

    Private Sub btnprev_Click(sender As Object, e As EventArgs) Handles btnprev.Click
        Try

            'check if the record is already the first record 
            If lblCurrent.Text = "1" Then

                'you can display a message to the user to indicate the first record
                Exit Sub

            End If
            ' go to the previous record and display the record 
            DisplayRecords(CInt(lblCurrent.Text) - 2)

        Catch ex As Exception
            MessageBox.Show("Error occured in Form: frmVendor, Method: DisplayRecord(Index), Error: " _
                        & ex.Message)
        End Try

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Try

            'check if the record is already the last record 
            If (CInt(lblCurrent.Text) = dsVendor.Tables("tblVendor").Rows.Count) Then

                'you can display a message to the user to indicate the first record


                'can display a message to indicate if its the last record
                Exit Sub


            End If
            ' go to the previous record and display the record 
            DisplayRecords(CInt(lblCurrent.Text))

        Catch ex As Exception
            MessageBox.Show("Error occured in Form: frmVendor, Method: DisplayRecord(Index), Error: " _
                        & ex.Message)

        End Try
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        'error handling

        Try
            ' call displayrecord and go to the first record 
            DisplayRecords(dsVendor.Tables("tblVendor").Rows.Count - 1)



        Catch ex As Exception


            MessageBox.Show("Error occured in Form: frmVendor, Method: DisplayRecord(Index), Error: " _
                        & ex.Message)

        End Try
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'declare a variable to hold user confirmation 
        Dim intResponse As Integer


        Try
            intResponse = MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, _
                                           MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)

            'check the response
            If intResponse = vbNo Then
                'do nothing
                Exit Sub
            ElseIf txtVendorID.Text.Length = 0 Or Not IsNumeric(txtVendorID.Text.Trim) Then
                MessageBox.Show("You must enter a valid ID for record deletion. ")
                Exit Sub

            Else 'now the data is ok
                'proceed with data deletion 
                'declare a variable to hold the result of delete 
                Dim intResult As Integer

                intResult = clsVendor.DeleteRecord(txtVendorID.Text.Trim)

                'evaluate result
                If intResult = 0 Then
                    MessageBox.Show("Delete Failed!")
                ElseIf intResult = 1 Then
                    MessageBox.Show("Record Deleted!")
                Else
                    MessageBox.Show("Something is wrong, prepare for debugging!")
                End If


            End If


            'get a new snapshot of the database
            dsVendor = clsVendor.GetRecords()


            'refresh the display
            DisplayRecords(0)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim aVendor As clsVendor
        Try
            'validate user input
            If IsValidNumber(txtVendorID, "Vendor ID") Then
                If IsValidText(txtVendorName, "Vendor Name") Then
                    If IsValidNumber(txtVendorAddress, "Vendor Address") Then
                        If IsValidText(txtPhone, "Vendor Phone Number") Then
                            If IsValidText(txtVendorEmail, "Vendor Email") Then

                                'get all valid input can create object now
                                aVendor = New clsVendor(CInt(txtVendorID.Text.Trim), txtVendorName.Text, txtVendorAddress.Text.Trim, txtPhone.Text.Trim, txtVendorEmail.Text.Trim)


                                'declare variable to hold the result
                                Dim intResult As Integer
                                'call the function to add a record
                                intResult = clsVendor.AddRecord(aVendor)


                                'evaluate the result
                                If intResult = 1 Then
                                    MessageBox.Show("A record has been successfully added.")
                                ElseIf intResult = 0 Then
                                    MessageBox.Show("Add failed")
                                Else
                                    MessageBox.Show("Start debugging.")


                                End If
                            End If
                        End If
                    End If
                End If
            End If

            'get the updated dataset
            dsVendor = clsVendor.GetRecords()
            'display the first record
            DisplayRecords(0)

        Catch ex As Exception
            MessageBox.Show("Error occurred in From: frmVendor. Method:  btnAdd_Click(). Error:" & ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim aVendor As clsVendor
        Try
            'declare an object

            'validate user input

            If IsValidNumber(txtVendorID, "Vendor ID") Then
                If IsValidText(txtVendorName, "Vendor Name") Then
                    If IsValidText(txtVendorAddress, "Vendor Address") Then
                        If IsValidText(txtPhone, "Vendor Phone Number") Then
                            If IsValidText(txtVendorEmail, "Vendor Email") Then

                                'get all valid input can create object now
                                aVendor = New clsVendor(CInt(txtVendorID.Text.Trim), txtVendorName.Text, txtVendorAddress.Text, txtPhone.Text.Trim, txtVendorEmail.Text.Trim)


                                'declare variable to hold the result
                                Dim intResult As Integer
                                'call the function to add a record
                                intResult = clsVendor.UpdateRecord(aVendor)


                                'evaluate the result
                                If intResult = 1 Then
                                    MessageBox.Show("The record has been successfully updated.")
                                ElseIf intResult = 0 Then
                                    MessageBox.Show("Update failed")
                                Else
                                    MessageBox.Show("Start debugging.")

                                End If
                            End If
                        End If
                    End If
                End If
            End If



            'get the updated dataset 
            dsVendor = clsVendor.GetRecords()
            'display the first record
            DisplayRecords(0)
        Catch ex As Exception
            MessageBox.Show("Error occurred in From: frmVendor. Method:  btnUpdate_Click(). Error:" & ex.Message)
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        frmSwitch.Show()
    End Sub
End Class