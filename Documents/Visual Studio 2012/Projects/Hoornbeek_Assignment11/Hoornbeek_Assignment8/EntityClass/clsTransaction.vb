'Class Name:            clsTransaction
'Purpose                A container to hold all properties and methods of a class    
'Change Log             A Hoornbeek 10/28/13



Public Class clsTransaction


    'Method Name:           DeleteRecord
    'Purpose:               Delete a record from the database for this entity 
    'Parameter:             The Primary key
    'Return:                Result (number of rows affected) - Integer
    'Change Log:            A Hoornbeek 10/31/13

    Public Shared Function DeleteRecord(ByVal aPrimaryKey As String) As Integer
        Try
            Return clsTransactionDA.DeleteRecord(aPrimaryKey)


        Catch ex As Exception
            MessageBox.Show("Error occured in Class: clsTransaction, Method: Deleterecord(String), Error: " _
                         & ex.Message)



            Return -9
        End Try
    End Function

    'Method Name:   Add Record
    'Purpose:       To add a record to the database for this utility
    'Parameter:     Object-String
    'Return:        All the records of this entity - Dataset
    'Change Log:    Adam Hoornbeek 11/6/13
    Public Shared Function AddRecord(ByVal aTransaction As clsTransaction) As Integer
        Try
            Return clsTransactionDA.AddRecord(aTransaction)
        Catch ex As Exception
            MessageBox.Show("Error occurred in Class: clsTransaction.  Method:  AddRecords(). Error" & ex.Message)
            Return -9
        End Try
    End Function

    'Method Name:   Update Record
    'Purpose:       To update a record to the database for this utility
    'Parameter:     Object-String
    'Return:        Number the records of this entity - Dataset
    'Change Log:    Adam Hoornbeek 11/8/13

    Public Shared Function UpdateRecord(ByVal aTransaction As clsTransaction) As Integer
        Try
            Return clsTransactionDA.UpdateRecord(aTransaction)
        Catch ex As Exception
            MessageBox.Show("Error occurred in Class: clsTransaction.  Method:  UpdateRecords(). Error" & ex.Message)
            Return -9

        End Try
    End Function

    'Method Name:           GetRecords
    'Purpose:               Get all records from the database for this entity 
    'Parameter:             None 
    'Return:                All the records for this entity - Dataset
    'Change Log:            A Hoornbeek 10/24/13


    Public Shared Function GetRecords() As DataSet
        'error handling

        Try


            Return clsTransactionDA.GetRecords()


        Catch ex As Exception


            MessageBox.Show("Error occured in Class: clsTransaction, Method: GetRecords, Error: " _
                        & ex.Message)

            Return Nothing

        End Try




    End Function






    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    'Private attributes(properties) 
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private intTransactionID As Integer
    Private intProductID As Integer
    Private intCustomerID As Integer
    Private intVendorID As Integer

    Private dblProductPrice As Double
    Private strTransactionDate As String
    Private strPaymentMethod As String
    Private intProductQuantity As Integer



    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    'Getter and Setters
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Property TransactionID() As Integer
        Get
            Return intTransactionID
        End Get
        Set(value As Integer)
            If value > 0 Then
                intTransactionID = value
            Else
                'you can do anything to indicate the data is bad 
                intTransactionID = 0
            End If
        End Set
    End Property


    Public Property ProductID() As Integer
        Get
            Return intProductID
        End Get
        Set(value As Integer)
            If value > 0 Then
                intProductID = value
            Else
                'you can do anything to indicate the data is bad 
                intProductID = 0
            End If
        End Set
    End Property


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

    Public Property VendorID() As Integer
        Get
            Return intVendorID
        End Get
        Set(value As Integer)
            If value > 0 Then
                intVendorID = value
            Else
                'you can do anything to indicate the data is bad 
                intVendorID = 0
            End If
        End Set
    End Property

    Public Property ProductPrice() As Double
        Get
            Return dblProductPrice
        End Get
        Set(value As Double)
            If value > 0 Then
                dblProductPrice = CInt(value)
            Else
                'you can do anything to indicate the data is bad 
                dblProductPrice = 0
            End If
        End Set
    End Property



    Public Property TransactionDate() As String
        Get
            Return strTransactionDate
        End Get
        Set(value As String)
            If value <> String.Empty Then
                strTransactionDate = value
            Else
                strTransactionDate = "Null String"
            End If
        End Set
    End Property


    Public Property PaymentMethod() As String
        Get
            Return strPaymentMethod
        End Get
        Set(value As String)
            If value <> String.Empty Then
                strPaymentMethod = value
            Else
                strPaymentMethod = "Null String"
            End If
        End Set
    End Property




    Public Property ProductQuantity() As Integer
        Get
            Return intProductQuantity
        End Get
        Set(value As Integer)
            If value > 0 Then
                intProductQuantity = value
            Else
                intProductQuantity = 0
            End If
        End Set
    End Property






    '************************************************************************************************************
    'Constructors 
    '************************************************************************************************************

    'default constructor 
    Public Sub New()
        'assign a default value to each strtribute 
        intTransactionID = 0
        intProductID = 0
        intTransactionID = 0
        intVendorID = 0
        TransactionDate = ""
        strPaymentMethod = ""
        intProductQuantity = 0

    End Sub

    'parameter based constructor 
    Public Sub New(ByVal aTransactionID As Integer, ByVal aProductID As Integer, aCustomerID As Integer, aVendorID As Integer, aTransactionDate As String, aPaymentMethod As String, aProductQuantity As Integer)
        intTransactionID = aTransactionID
        intProductID = aProductID
        intCustomerID = aCustomerID
        intVendorID = aVendorID
        TransactionDate = aTransactionDate
        strPaymentMethod = aPaymentMethod
        intProductQuantity = aProductQuantity
    End Sub

    '*****************************************************************************************************************
    'Methods 
    '*****************************************************************************************************************

    'Method Name:   classInfo 
    'Purpose:       To display all the attributes of an object 
    'Paramaters:    None 
    'Return:        all the attributes = string 
    'change log:    A Hoornbeek 10/17/2013

    Public Function classInfo() As String
        Return "The Transaction ID: " & TransactionID() & vbCr & _
            "The Product ID: " & ProductID() & vbCr & _
            "The Customer ID: " & TransactionID() & vbCr & _
            "The Vendor ID: " & VendorID() & vbCr & _
            "The Transaction Date: " & TransactionDate() & vbCr & _
            "The Payment Method: " & PaymentMethod() & vbCr & _
            "The Product Quantity: " & ProductQuantity() & vbCr

    End Function








End Class
