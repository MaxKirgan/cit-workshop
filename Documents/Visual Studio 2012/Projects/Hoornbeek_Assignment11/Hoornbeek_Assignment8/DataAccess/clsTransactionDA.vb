Imports System.Data.OleDb


'Class Name:            clsTransactionDA  
'Purpose                A class that is responible for database manipulation    
'Change Log             A Hoornbeek 10/22/13

Public Class clsTransactionDA

    'Method Name:           GetRecords
    'Purpose:               Get all records from the database for this entity 
    'Parameter:             None 
    'Return:                All the recrds for this entity - Dataset
    'Change Log:            A Hoornbeek 10/24/13


    Public Shared Function GetRecords() As DataSet
        'error handling 
        Try
            Dim dbConnection As OleDBConnection
            dbConnection = ConnectToDb()

            'check the status of the connection
            If dbConnection Is Nothing Then

                Return Nothing
            End If

            'create a SQL string 
            Dim strQuery As String
            strQuery = "SELECT * FROM tblTransaction ORDER BY TransactionID"


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
            dbDataAdapter.Fill(ds, "tblTransaction")

            Return ds



        Catch ex As Exception
            MessageBox.Show("Error occured in Class: clsTransactionDA, Method: GetRecords, Error: " _
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
            strQuery = "DELETE FROM tblTransaction WHERE TransactionID = ?"


            'Set up the ADO components 
            'create data adapter object 
            Dim dbDataAdapter As New OleDbDataAdapter

            'create a command object for the data adapter
            Dim dbCommand As New OleDbCommand

            'add a parameter for ? in the SQL string 
            dbCommand.Parameters.Add(New OleDbParameter("@TransactionID", aPrimaryKey))

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



            MessageBox.Show("Error occured in Class: clsTransactionDA, Method: Deleterecord(String), Error: " _
                         & ex.Message)



            Return -9
            'Finally
            'disconnect from database
            'CloseDB(dbConnection)

        End Try






    End Function

    'Method Name:           AddRecord
    'Purpose:               Add a record from the database for this entity 
    'Parameter:             object (a Transaction) - clsTransaction
    'Return:                Result (number of rows affected) - Integer
    'Change Log:            A Hoornbeek 11/7/13



    Public Shared Function AddRecord(ByVal aTransaction As clsTransaction) As Integer

        Dim dbConnection As OleDbConnection = Nothing


        Try


            dbConnection = ConnectToDb()
            If dbConnection Is Nothing Then
                Return Nothing
            End If


            'create a SQL string 
            Dim strQuery As String
            strQuery = "INSERT INTO tblTransaction (TransactionID, ProductID, CustomerID, VendorID, ProductPrice, TransactionDate, PaymentMethod, ProductQuantity) VALUES (?, ?, ?,?, ?,?, ?,?)"


            'Set up the ADO components 
            'create data adapter object 
            Dim dbDataAdapter As New OleDbDataAdapter

            'create a command object for the data adapter
            Dim dbCommand As New OleDbCommand

            'add a parameters for ? in the SQL string 
            dbCommand.Parameters.AddWithValue("@TransactionID", aTransaction.TransactionID)
            dbCommand.Parameters.AddWithValue("@ProductID", aTransaction.ProductID)
            dbCommand.Parameters.AddWithValue("@CustomerID", aTransaction.CustomerID)
            dbCommand.Parameters.AddWithValue("@VendorID", aTransaction.VendorID)
            dbCommand.Parameters.AddWithValue("@ProductPrice", aTransaction.ProductPrice)
            dbCommand.Parameters.AddWithValue("@TransactionDate", aTransaction.TransactionDate)
            dbCommand.Parameters.AddWithValue("@PaymentMethod", aTransaction.PaymentMethod)
            dbCommand.Parameters.AddWithValue("@ProductQuantity", aTransaction.ProductQuantity)

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



            MessageBox.Show("Error occured in Class: clsTransactionDA, Method: AddRecord(object), Error: " _
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

    Public Shared Function UpdateRecord(ByVal aTransaction As clsTransaction) As Integer
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
            strQuery = "UPDATE tblTransaction SET ProductID = ?, CustomerID = ?, VendorID = ?, ProductPrice=? TransactionDate=?, WHERE TransactionID = ?"

            'left off here!!!!


            'set up ADO component= activex data object
            'create a data adapter object
            Dim dbDataAdapter As New OleDbDataAdapter
            'create command object for the data adapter
            Dim dbCommand As New OleDbCommand




            'add parameters for ? in the SQL string

            dbCommand.Parameters.AddWithValue("@CustomerID", aTransaction.CustomerID)
            dbCommand.Parameters.AddWithValue("@VendorID", aTransaction.VendorID)
            dbCommand.Parameters.AddWithValue("@ProductPrice", aTransaction.ProductPrice)
            dbCommand.Parameters.AddWithValue("@TransactionDate", aTransaction.TransactionDate)
            dbCommand.Parameters.AddWithValue("@PaymentMethod", aTransaction.PaymentMethod)
            dbCommand.Parameters.AddWithValue("@ProductQuantity", aTransaction.ProductQuantity)
            'add the primary key last
            dbCommand.Parameters.AddWithValue("@ProductID", aTransaction.ProductID)

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
            MessageBox.Show("Error occurred in Class: TransactionDA.  Method:  UpdateRecords(Object). Error" & ex.Message)
            Return -9
        Finally
            CloseDB(dbConnection)
        End Try
    End Function
End Class
