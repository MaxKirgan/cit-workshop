Public Class clsCustomer



    'Class Name:            clsCustomer
    'Purpose                A container to hold all properties and methods of a class    
    'Change Log             A Hoornbeek 10/28/13


    'Method Name:           DeleteRecord
    'Purpose:               Delete a record from the database for this entity 
    'Parameter:             The Primary key
    'Return:                Result (number of rows affected) - Integer
    'Change Log:            A Hoornbeek 10/31/13

    Public Shared Function DeleteRecord(ByVal aPrimaryKey As String) As Integer
        Try
            Return clsCustomerDA.DeleteRecord(aPrimaryKey)


        Catch ex As Exception
            MessageBox.Show("Error occured in Class: clsCustomerDA, Method: Deleterecord(String), Error: " _
                         & ex.Message)



            Return -9
        End Try
    End Function

    'Method Name:           GetRecords
    'Purpose:               Get all records from the database for this entity 
    'Parameter:             None 
    'Return:                All the recrds for this entity - Dataset
    'Change Log:            A Hoornbeek 10/24/13


    Public Shared Function GetRecords() As DataSet
        'error handling

        Try


            Return clsCustomerDA.GetRecords()


        Catch ex As Exception


            MessageBox.Show("Error occured in Class: clsCustomerDA, Method: GetRecords, Error: " _
                        & ex.Message)

            Return Nothing

        End Try




    End Function


    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    'Private attributes(properties) 
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Private intCustomerID As Integer
    Private strCustomerName As String
    Private strCustomerAddress As String
    Private strcustomerPhoneNumber As String
    Private strCustomerEmail As String



    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    'Getter and Setters
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''



    Public Property CustomerID() As Integer
        Get
            Return intCustomerID
        End Get
        Set(value As Integer)
            If value > 0 Then
                intCustomerID = value
            Else
                'you can do anything to indicate the data is bad 
                intCustomerID = 0
            End If
        End Set
    End Property




    Public Property CustomerName() As String

        Get
            Return strCustomerName
        End Get
        Set(value As String)
            If value <> String.Empty Then
                strCustomerName = value
            Else
                strCustomerName = "Null String"
            End If
        End Set
    End Property



    Public Property CustomerAddress() As String
        Get
            Return strCustomerAddress
        End Get
        Set(value As String)
            If value <> String.Empty Then
                strCustomerAddress = value
            Else
                strCustomerAddress = "Null String"
            End If
        End Set
    End Property




    Public Property CustomerPhoneNumber() As String
        Get
            Return strCustomerPhoneNumber
        End Get

        Set(value As String)
            If value <> String.Empty Then
                strCustomerPhoneNumber = value
            Else
                strCustomerPhoneNumber = "Null String"
            End If

        End Set
    End Property


    Public Property CustomerEmail() As String
        Get
            Return strCustomerEmail
        End Get

        Set(value As String)
            If value <> String.Empty Then
                strCustomerEmail = value
            Else
                strCustomerEmail = "Null String"
            End If

        End Set
    End Property





    '************************************************************************************************************
    'Constructors 
    '************************************************************************************************************

    'default constructor 
    Public Sub New()
        'assign a default value to each strtribute 
        intCustomerID = 0
        strCustomerName = ""
        strCustomerAddress = ""
        strCustomerPhoneNumber = ""
        strCustomerEmail = ""
    End Sub

    'parameter based constructor 
    Public Sub New(ByVal aCustomerID As Integer, aCustomerName As String, aCustomerAddress As String, aCustomerPhoneNumber As String, aCustomerEmail As String)
        intCustomerID = aCustomerID
        strCustomerName = aCustomerName
        strCustomerAddress = aCustomerAddress
        strCustomerPhoneNumber = aCustomerPhoneNumber
        strCustomerEmail = aCustomerEmail
    End Sub

    '*****************************************************************************************************************
    'Methods 
    '*****************************************************************************************************************

    'Method Name:   classInfo 
    'Purpose:       To display all the attributes of an object 
    'Paramaters:    None 
    'Return:        all the attributes = string 
    'change log:    A Hoornbeek 10/28/2013

    Public Function classInfo() As String
        Return "The Customer ID: " & CustomerID() & vbCr & _
            "The Customer Name: " & CustomerName() & vbCr & _
            "The Customer Address: " & CustomerAddress() & vbCr & _
            "The Customer Phone Number: " & CustomerPhoneNumber() & vbCr & _
            "The Customer Email: " & CustomerEmail() & vbCr

    End Function


    'Method Name:   Add Record
    'Purpose:       To add a record to the database for this utility
    'Parameter:     Object-String
    'Return:        All the records of this entity - Dataset
    'Change Log:    Adam Hoornbeek 11/6/13
    Public Shared Function AddRecord(ByVal aCustomer As clsCustomer) As Integer
        Try
            Return clsCustomerDA.AddRecord(aCustomer)
        Catch ex As Exception
            MessageBox.Show("Error occurred in Class: clsCustomer.  Method:  AddRecords(). Error" & ex.Message)
            Return -9
        End Try
    End Function

    'Method Name:   Update Record
    'Purpose:       To update a record to the database for this utility
    'Parameter:     Object-String
    'Return:        Number the records of this entity - Dataset
    'Change Log:    Adam Hoornbeek 11/8/13

    Public Shared Function UpdateRecord(ByVal aCustomer As clsCustomer) As Integer
        Try
            Return clsCustomerDA.UpdateRecord(aCustomer)
        Catch ex As Exception
            MessageBox.Show("Error occurred in Class: clsCustomer.  Method:  UpdateRecords(). Error" & ex.Message)
            Return -9

        End Try
    End Function


End Class
