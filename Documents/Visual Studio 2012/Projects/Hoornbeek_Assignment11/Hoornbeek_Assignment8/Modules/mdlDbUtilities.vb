Imports System.Data.OleDb

' Module Name:          mdlDbUtilities
' Project Purpose:      to hold commonly used methods for database connection
' Change Log:           A Hoornbeek 10/24/13

Module mdlDbUtilities




    'Method Name:           ConnectToDB
    'Purpose:               To connect to a database
    'Parameter:             None 
    'Return:                Database connection - oleDbConnection Object
    'Change Log:            A Hoornbeek 10/24/13

    Public Function ConnectToDb() As OleDbConnection
        'error handling 

        Try

            'try to connect to database
            'declare and create a database connection object
            Dim dbConnection As New OleDbConnection

            'configure the connection object 
            Dim strConnectionString As String
            strConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../Database/Database.accdb"


            dbConnection.ConnectionString = strConnectionString


            'open the database connection
            dbConnection.Open()

            'return the connection
            Return dbConnection


        Catch ex As Exception
            MessageBox.Show("Error occured in Modules: mdlDBUtilities, Method: ConnectToDb, Error: " _
                         & ex.Message)
            Return Nothing



        End Try



    End Function



    'Method Name:           CloseDB
    'Purpose:               To close database connection
    'Parameter:             None 
    'Return:                Database connection - oleDbConnection Object
    'Change Log:            A Hoornbeek 10/24/13


    Public Sub CloseDB(ByVal aConnection As OleDbConnection)
        'error handling


        Try

            aConnection.Close()



        Catch ex As Exception

            MessageBox.Show("Error occured in Modules: mdlDBUtilities, Method: CloseDb, Error: " _
                         & ex.Message)

        End Try


    End Sub



End Module