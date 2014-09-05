Public Class clsVendor




    'Class Name:            clsVendor
    'Purpose                A container to hold all properties and methods of a class    
    'Change Log             A Hoornbeek 10/28/13

    'Method Name:           DeleteRecord
    'Purpose:               Delete a record from the database for this entity 
    'Parameter:             The Primary key
    'Return:                Result (number of rows affected) - Integer
    'Change Log:            A Hoornbeek 10/31/13

    Public Shared Function DeleteRecord(ByVal aPrimaryKey As String) As Integer
        Try
            Return clsVendorDA.DeleteRecord(aPrimaryKey)


        Catch ex As Exception
            MessageBox.Show("Error occured in Class: clsVendorDA, Method: Deleterecord(String), Error: " _
                         & ex.Message)



            Return -9
        End Try
    End Function

    'Method Name:           GetRecords
    'Purpose:               Get all records from the database for this entity 
    'Parameter:             None 
    'Return:                All the records for this entity - Dataset
    'Change Log:            A Hoornbeek 10/28/13


    Public Shared Function GetRecords() As DataSet
        'error handling

        Try


            Return clsVendorDA.GetRecords()


        Catch ex As Exception


            MessageBox.Show("Error occured in Class: clsVendorDA, Method: GetRecords, Error: " _
                        & ex.Message)

            Return Nothing

        End Try




    End Function




    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    'Private attributes(properties) 
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Private intVendorID As Integer
    Private strVendorName As String
    Private strVendorAddress As String
    Private strVendorPhoneNumber As String
    Private strVendorEmail As String



    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    'Getter and Setters
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''



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




    Public Property VendorName() As String

        Get
            Return strVendorName
        End Get
        Set(value As String)
            If value <> String.Empty Then
                strVendorName = value
            Else
                strVendorName = "Null String"
            End If
        End Set
    End Property



    Public Property VendorAddress() As String
        Get
            Return strVendorAddress
        End Get
        Set(value As String)
            If value <> String.Empty Then
                strVendorAddress = value
            Else
                strVendorAddress = "Null String"
            End If
        End Set
    End Property




    Public Property VendorPhoneNumber() As String
        Get
            Return strVendorPhoneNumber
        End Get

        Set(value As String)
            If value <> String.Empty Then
                strVendorPhoneNumber = value
            Else
                strVendorPhoneNumber = "Null String"
            End If

        End Set
    End Property


    Public Property VendorEmail() As String
        Get
            Return strVendorEmail
        End Get

        Set(value As String)
            If value <> String.Empty Then
                strVendorEmail = value
            Else
                strVendorEmail = "Null String"
            End If

        End Set
    End Property





    '************************************************************************************************************
    'Constructors 
    '************************************************************************************************************

    'default constructor 
    Public Sub New()
        'assign a default value to each strtribute 
        intVendorID = 0
        strVendorName = ""
        strVendorAddress = ""
        strVendorPhoneNumber = ""
        strVendorEmail = ""
    End Sub

    'parameter based constructor 
    Public Sub New(ByVal aVendorID As Integer, aVendorName As String, aVendorAddress As String, aVendorPhoneNumber As String, aVendorEmail As String)
        intVendorID = aVendorID
        strVendorName = aVendorName
        strVendorAddress = aVendorAddress
        strVendorPhoneNumber = aVendorPhoneNumber
        strVendorEmail = aVendorEmail
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
        Return "The Vendor ID: " & VendorID() & vbCr & _
            "The Vendor Name: " & VendorName() & vbCr & _
            "The Vendor Address: " & VendorAddress() & vbCr & _
            "The Vendor Phone Number: " & VendorPhoneNumber() & vbCr & _
            "The Vendor Email: " & VendorEmail() & vbCr

    End Function


    'Method Name:   Add Record
    'Purpose:       To add a record to the database for this utility
    'Parameter:     Object-String
    'Return:        All the records of this entity - Dataset
    'Change Log:    Adam Hoornbeek 11/6/13
    Public Shared Function AddRecord(ByVal aVendor As clsVendor) As Integer
        Try
            Return clsVendorDA.AddRecord(aVendor)
        Catch ex As Exception
            MessageBox.Show("Error occurred in Class: clsVendor.  Method:  AddRecords(). Error" & ex.Message)
            Return -9
        End Try
    End Function

    'Method Name:   Update Record
    'Purpose:       To update a record to the database for this utility
    'Parameter:     Object-String
    'Return:        Number the records of this entity - Dataset
    'Change Log:    Adam Hoornbeek 11/8/13

    Public Shared Function UpdateRecord(ByVal aVendor As clsVendor) As Integer
        Try
            Return clsVendorDA.UpdateRecord(aVendor)
        Catch ex As Exception
            MessageBox.Show("Error occurred in Class: clsVendor.  Method:  UpdateRecords(). Error" & ex.Message)
            Return -9

        End Try
    End Function

End Class



