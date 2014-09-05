Imports System.Data.OleDb


'Class Name:            clsCustomerDA  
'Purpose                A class that is responible for database manipulation    
'Change Log             A Hoornbeek 10/22/13

Public Class clsCustomerDA

    'Method Name:           GetRecords
    'Purpose:               Get all records from the database for this entity 
    'Parameter:             None 
    'Return:                All the recrds for this entity - Dataset
    'Change Log:            A Hoornbeek 10/24/13


    Public Shared Function GetRecords() As DataSet
        'error handling 
        Try
            Dim dbConnection As OleDbConnection
            dbConnection = ConnectToDb()

            'check the status of the connection
            If dbConnection Is Nothing Then

                Return Nothing
            End If

            'create a SQL string 
            Dim strQuery As String
            strQuery = "SELECT * FROM tblCustomer ORDER BY CustomerName"


            'Set up the ADO components 
            'create data adapter object 
            Dim dbDataAdapter As New OleDbDataAdapter

            'create a command object for the data adapter
            Dim dbCommand As New OleDbCommand


            'configure the components 
            dbCommand.CommandText = strQuery
            dbCommand.Connection = dbConnection



            dbDataAdapter.SelectCommand = dbCommand

            'declare a dataset
            Dim ds As New DataSet

            'fill the dataset (get the database image) 
            dbDataAdapter.Fill(ds, "tblCustomer")

            Return ds



        Catch ex As Exception
            MessageBox.Show("Error occured in Class: clsCustomerDA, Method: GetRecords, Error: " _
                         & ex.Message)

            Return Nothing



        End Try





    End Function



    'Method Name:           DeleteRecord
    'Purpose:               Delete a record from the database for this entity 
    'Parameter:             The Primary key
    'Return:                Result (number of rows affected) - Integer
    'Change Log:            A Hoornbeek 10/31/13

    Public Shared Function DeleteRecord(ByVal aPrimaryKey As String) As Integer




        Dim dbConnection As OleDbConnection = Nothing


        Try


            dbConnection = ConnectToDb()
            If dbConnection Is Nothing Then
                Return Nothing
            End If


            'create a SQL string 
            Dim strQuery As String
            strQuery = "DELETE FROM tblCustomer WHERE CustomerID = ?"


            'Set up the ADO components 
            'create data adapter object 
            Dim dbDataAdapter As New OleDbDataAdapter

            'create a command object for the data adapter
            Dim dbCommand As New OleDbCommand

            'add a parameter for ? in the SQL string 
            dbCommand.Parameters.Add(New OleDbParameter("@CustomerID", aPrimaryKey))

            'configure the components 
            dbCommand.CommandText = strQuery
            dbCommand.Connection = dbConnection



            dbDataAdapter.SelectCommand = dbCommand

            'Declare a variable to hold the result
            Dim intResult As Integer
            intResult = dbCommand.ExecuteNonQuery

            'return the result
            Return intResult

        Catch ex As Exception



            MessageBox.Show("Error occured in Class: clsCustomerDA, Method: Deleterecord(String), Error: " _
                         & ex.Message)



            Return -9
            'Finally
            'disconnect from database
            'CloseDB(dbConnection)

        End Try






    End Function

    'Method Name:           AddRecord
    'Purpose:               Add a record from the database for this entity 
    'Parameter:             object (a Person) - clsPeople
    'Return:                Result (number of rows affected) - Integer
    'Change Log:            A Hoornbeek 11/7/13



    Public Shared Function AddRecord(ByVal aCustomer As clsCustomer) As Integer

        Dim dbConnection As OleDbConnection = Nothing


        Try


            dbConnection = ConnectToDb()
            If dbConnection Is Nothing Then
                Return Nothing
            End If


            'create a SQL string 
            Dim strQuery As String
            strQuery = "INSERT INTO tblCustomer (CustomerID, CustomerName, CustomerAddress, CustomerPhoneNumber, CustomerEmail) VALUES (?, ?, ?, ?,?)"


            'Set up the ADO components 
            'create data adapter object 
            Dim dbDataAdapter As New OleDbDataAdapter

            'create a command object for the data adapter
            Dim dbCommand As New OleDbCommand

            'add a parameters for ? in the SQL string 
            dbCommand.Parameters.AddWithValue("@CustomerID", aCustomer.CustomerID)
            dbCommand.Parameters.AddWithValue("@CustomerName", aCustomer.CustomerName)
            dbCommand.Parameters.AddWithValue("@CustomerAddress", aCustomer.CustomerAddress)
            dbCommand.Parameters.AddWithValue("@CustomerPhoneNumber", aCustomer.CustomerPhoneNumber)
            dbCommand.Parameters.AddWithValue("@CustomerEmail", aCustomer.CustomerEmail)

            'configure the components 
            dbCommand.CommandText = strQuery
            dbCommand.Connection = dbConnection



            dbDataAdapter.SelectCommand = dbCommand

            'Declare a variable to hold the result
            Dim intResult As Integer
            intResult = dbCommand.ExecuteNonQuery

            'return the result
            Return intResult

        Catch ex As Exception



            MessageBox.Show("Error occured in Class: clsCustomerDA, Method: AddRecord(object), Error: " _
                         & ex.Message)



            Return -9
            'Finally
            'disconnect from database
            CloseDB(dbConnection)

        End Try



    End Function

    'Method Name:   Update Record
    'Purpose:       To update a record to the database for this utility
    'Parameter:     Object-String
    'Return:        Number the records of this entity - Dataset
    'Change Log:    Adam Hoornbeek 11/8/13

    Public Shared Function UpdateRecord(ByVal aCustomer As clsCustomer) As Integer
        Dim dbConnection As OleDbConnection = Nothing
        Try
            dbConnection = ConnectToDb()
            'check the return of the connection

            If dbConnection Is Nothing Then
                MessageBox.Show("Connection Failed!")

                Return Nothing
            End If

            'the connection is made
            'create a SQL string
            Dim strQuery As String
            strQuery = "UPDATE tblCustomer SET CustomerName = ?, CustomerAddress = ?,  CustomerPhoneNumber = ?, CustomerEmail = ? WHERE CustomerID = ?"



            'set up ADO component= activex data object
            'create a data adapter object
            Dim dbDataAdapter As New OleDbDataAdapter
            'create command object for the data adapter
            Dim dbCommand As New OleDbCommand




            'add parameters for ? in the SQL string

            dbCommand.Parameters.AddWithValue("@CustomerName", aCustomer.CustomerName)
            dbCommand.Parameters.AddWithValue("@CustomerAddress", aCustomer.CustomerAddress)
            dbCommand.Parameters.AddWithValue("@CustomerPhoneNumber", aCustomer.CustomerPhoneNumber)
            dbCommand.Parameters.AddWithValue("@CustomerEmail", aCustomer.CustomerEmail)
            'add primary key last
            dbCommand.Parameters.AddWithValue("@CustomerID", aCustomer.CustomerID)

            'configure the components
            dbCommand.CommandText = strQuery
            dbCommand.Connection = dbConnection
            dbDataAdapter.SelectCommand = dbCommand

            'declare a variable to hold result
            Dim intResult As Integer
            'call the method to get result
            intResult = dbCommand.ExecuteNonQuery

            'return result
            Return intResult

        Catch ex As Exception
            MessageBox.Show("Error occurred in Class: CustomerDA.  Method:  UpdateRecords(Object). Error" & ex.Message)
            Return -9
        Finally
            CloseDB(dbConnection)
        End Try
    End Function

End Class
