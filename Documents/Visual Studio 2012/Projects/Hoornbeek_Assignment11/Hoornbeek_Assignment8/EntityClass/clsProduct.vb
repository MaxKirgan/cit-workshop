Public Class clsProduct
    'Class Name:            clsProduct  
    'Purpose                A container to hold all properties and methods of a class    
    'Change Log             A Hoornbeek 10/28/13




   


    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    'Private attributes(properties) 
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private intProductID As Integer
    Private dblProductPrice As Double
    Private strCardName As String
    Private strCardSet As String
    Private strCardType As String
    Private strCardColor As String



    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    'Getter and Setters
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
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


    Public Property ProductPrice() As Double

        Get
            Return dblProductPrice
        End Get

        Set(value As Double)
            If value > 0 Then
                dblProductPrice = value
            Else
                dblProductPrice = 0


            End If


        End Set
    End Property



    Public Property CardName() As String
        Get
            Return strCardName
        End Get
        Set(value As String)
            If value <> String.Empty Then
                strCardName = value
            Else
                strCardName = "Null String"
            End If
        End Set
    End Property




    Public Property CardSet() As String
        Get
            Return strCardSet
        End Get
        Set(value As String)
            If value <> String.Empty Then
                strCardSet = value
            Else
                strCardSet = "Null String"
            End If
        End Set
    End Property




    Public Property CardType() As String
        Get
            Return strCardType
        End Get
        Set(value As String)
            If value <> String.Empty Then
                strCardType = value
            Else
                strCardType = "Null String"
            End If
        End Set
    End Property




    Public Property CardColor() As String
        Get
            Return strCardColor
        End Get
        Set(value As String)
            If value <> String.Empty Then
                strCardColor = value
            Else
                strCardColor = "Null String"
            End If
        End Set
    End Property





    '************************************************************************************************************
    'Constructors 
    '************************************************************************************************************

    'default constructor 
    Public Sub New()
        'assign a default value to each strtribute 
        intProductID = 0
        dblProductPrice = 0
        strCardName = ""
        strCardSet = ""
        strCardColor = ""
        strCardType = ""
    End Sub

    'parameter based constructor 
    Public Sub New(ByVal aID As Integer, ByVal aPrice As Double, ByVal aName As String, aSet As String, aColor As String, aType As String)
        intProductID = aID
        dblProductPrice = aPrice
        strCardName = aName
        strCardSet = aSet
        strCardColor = aColor
        strCardType = aType
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
        Return "The Product ID: " & ProductID() & vbCr & _
            "The Product Price:" & ProductPrice() & vbCr & _
            "The card name:" & CardName() & vbCr & _
            "The card set:" & CardSet() & vbCr & _
            "The card color: " & CardColor() & vbCr & _
            "The card type: " & CardType() & vbCr

    End Function

    'Method Name:           GetRecords
    'Purpose:               Get all records from the database for this entity 
    'Parameter:             None 
    'Return:                All the records for this entity - Dataset
    'Change Log:            A Hoornbeek 10/28/13


    Public Shared Function GetRecords() As DataSet
        'error handling

        Try


            Return clsProductDA.GetRecords()


        Catch ex As Exception


            MessageBox.Show("Error occured in Class: clsProductDA, Method: GetRecords, Error: " _
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
        Try
            Return clsProductDA.DeleteRecord(aPrimaryKey)


        Catch ex As Exception
            MessageBox.Show("Error occured in Class: clsProductDA, Method: Deleterecord(String), Error: " _
                         & ex.Message)



            Return -9
        End Try
    End Function

    'Method Name:   Add Record
    'Purpose:       To add a record to the database for this utility
    'Parameter:     Object-String
    'Return:        All the records of this entity - Dataset
    'Change Log:    Adam Hoornbeek 11/6/13
    Public Shared Function AddRecord(ByVal aProduct As clsProduct) As Integer
        Try
            Return clsProductDA.AddRecord(aProduct)
        Catch ex As Exception
            MessageBox.Show("Error occurred in Class: clsProduct.  Method:  AddRecords(). Error" & ex.Message)
            Return -9
        End Try
    End Function

    'Method Name:   Update Record
    'Purpose:       To update a record to the database for this utility
    'Parameter:     Object-String
    'Return:        Number the records of this entity - Dataset
    'Change Log:    Adam Hoornbeek 11/8/13

    Public Shared Function UpdateRecord(ByVal aProduct As clsProduct) As Integer
        Try
            Return clsProductDA.UpdateRecord(aProduct)
        Catch ex As Exception
            MessageBox.Show("Error occurred in Class: clsProduct.  Method:  UpdateRecords(). Error" & ex.Message)
            Return -9

        End Try
    End Function

End Class
