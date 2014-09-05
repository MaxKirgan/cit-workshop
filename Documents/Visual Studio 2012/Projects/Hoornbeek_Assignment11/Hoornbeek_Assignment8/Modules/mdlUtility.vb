' Module Name:          mdlUtilities
' Project Purpose:      to hold commonly used methods for the project 
' Change Log:           9/26/13

Module mdlUtility
    'Method Name:       IsPresent
    'Purpose:           To check if user entered anything
    'Parameter:         atextbox - Control, Name - String
    'Return:            T/F - Boolean

    Public Function IsPresent(ByVal aTextbox As Control, ByVal aName As String) As Boolean

        'check if user entered something 
        If (aTextbox.Text = "") Then
            MessageBox.Show(aName & "is a required field", "Null Input")
            aTextbox.Focus()
            Return False
        Else
            Return True
        End If

    End Function

    'Method Name:       IsValidNumber
    'Purpose:           To check if user entered a valid number 
    'Parameter:         atextbox - Control, Name - String
    'Return:            T/F - Boolean
    'Change Log:        10/1/13

    Public Function IsValidNumber(ByVal aTextbox As Control, ByVal aName As String) As Boolean

        'check if user entered anything 
        If IsPresent(aTextbox, aName) Then
            'check is its a number 
            If IsNumeric(aTextbox.Text.Trim) Then
                Return True
            Else
                MessageBox.Show("Please enter a number for" & aName, "Incorrect Input")
                aTextbox.Focus()
                Return False
            End If
        End If
        Return False
    End Function

    'Method Name:       IsValidText
    'Purpose:           To check if user input is not a number
    'Parameter:         atextbox - Control, Name - String
    'Return:            T/F - Boolean
    'Change Log:        10/1/13

    Public Function IsValidText(ByVal aTextbox As Control, ByVal aName As String) As Boolean

        'check if user entered anything 
        If IsPresent(aTextbox, aName) Then
            'check if the input is not a number 
            If Not IsNumeric(aTextbox.Text.Trim) Then
                Return True
            Else
                MessageBox.Show("Please enter a number for" & aName, "Incorrect Input")
                aTextbox.Focus()
                Return False
            End If
        End If
        Return False
    End Function
End Module
