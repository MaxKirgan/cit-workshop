<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblCurrent = New System.Windows.Forms.Label()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnprev = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.txtCustomerAddress = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblCustomerPhoneNumber = New System.Windows.Forms.Label()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.txtCustomerEmail = New System.Windows.Forms.TextBox()
        Me.lblCustomerEmail = New System.Windows.Forms.Label()
        Me.txtCustomerPhoneNumber = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.lblCustomerID = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(323, 400)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 13)
        Me.lblTotal.TabIndex = 58
        '
        'lblCurrent
        '
        Me.lblCurrent.AutoSize = True
        Me.lblCurrent.Location = New System.Drawing.Point(153, 400)
        Me.lblCurrent.Name = "lblCurrent"
        Me.lblCurrent.Size = New System.Drawing.Size(0, 13)
        Me.lblCurrent.TabIndex = 57
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(255, 400)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(48, 23)
        Me.btnLast.TabIndex = 56
        Me.btnLast.Text = ">|"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(201, 400)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(48, 23)
        Me.btnNext.TabIndex = 55
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnprev
        '
        Me.btnprev.Location = New System.Drawing.Point(81, 400)
        Me.btnprev.Name = "btnprev"
        Me.btnprev.Size = New System.Drawing.Size(48, 23)
        Me.btnprev.TabIndex = 54
        Me.btnprev.Text = "<"
        Me.btnprev.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(27, 400)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(48, 23)
        Me.btnFirst.TabIndex = 53
        Me.btnFirst.Text = "|<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'txtCustomerAddress
        '
        Me.txtCustomerAddress.Location = New System.Drawing.Point(30, 138)
        Me.txtCustomerAddress.Name = "txtCustomerAddress"
        Me.txtCustomerAddress.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomerAddress.TabIndex = 52
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(419, 400)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 50
        Me.btnExit.Text = "Home"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblCustomerPhoneNumber
        '
        Me.lblCustomerPhoneNumber.AutoSize = True
        Me.lblCustomerPhoneNumber.Location = New System.Drawing.Point(27, 172)
        Me.lblCustomerPhoneNumber.Name = "lblCustomerPhoneNumber"
        Me.lblCustomerPhoneNumber.Size = New System.Drawing.Size(128, 13)
        Me.lblCustomerPhoneNumber.TabIndex = 49
        Me.lblCustomerPhoneNumber.Text = "Customer Phone Number:"
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(312, 40)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(75, 23)
        Me.btnCreate.TabIndex = 48
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'txtCustomerEmail
        '
        Me.txtCustomerEmail.Location = New System.Drawing.Point(30, 240)
        Me.txtCustomerEmail.Name = "txtCustomerEmail"
        Me.txtCustomerEmail.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomerEmail.TabIndex = 47
        '
        'lblCustomerEmail
        '
        Me.lblCustomerEmail.AutoSize = True
        Me.lblCustomerEmail.Location = New System.Drawing.Point(27, 224)
        Me.lblCustomerEmail.Name = "lblCustomerEmail"
        Me.lblCustomerEmail.Size = New System.Drawing.Size(79, 13)
        Me.lblCustomerEmail.TabIndex = 46
        Me.lblCustomerEmail.Text = "Customer Email"
        '
        'txtCustomerPhoneNumber
        '
        Me.txtCustomerPhoneNumber.Location = New System.Drawing.Point(27, 192)
        Me.txtCustomerPhoneNumber.Name = "txtCustomerPhoneNumber"
        Me.txtCustomerPhoneNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomerPhoneNumber.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 44
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(27, 94)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomerName.TabIndex = 43
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Location = New System.Drawing.Point(27, 78)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(85, 13)
        Me.lblCustomerName.TabIndex = 42
        Me.lblCustomerName.Text = "Customer Name:"
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Location = New System.Drawing.Point(24, 40)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomerID.TabIndex = 41
        '
        'lblCustomerID
        '
        Me.lblCustomerID.AutoSize = True
        Me.lblCustomerID.Location = New System.Drawing.Point(27, 24)
        Me.lblCustomerID.Name = "lblCustomerID"
        Me.lblCustomerID.Size = New System.Drawing.Size(68, 13)
        Me.lblCustomerID.TabIndex = 40
        Me.lblCustomerID.Text = "Customer ID:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Customer Address: "
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(312, 167)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 62
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(312, 78)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 63
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(312, 122)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 64
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'frmCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 444)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblCurrent)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnprev)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.txtCustomerAddress)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblCustomerPhoneNumber)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.txtCustomerEmail)
        Me.Controls.Add(Me.lblCustomerEmail)
        Me.Controls.Add(Me.txtCustomerPhoneNumber)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.lblCustomerName)
        Me.Controls.Add(Me.txtCustomerID)
        Me.Controls.Add(Me.lblCustomerID)
        Me.Name = "frmCustomer"
        Me.Text = "frmCustomer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblCurrent As System.Windows.Forms.Label
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnprev As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents txtCustomerAddress As System.Windows.Forms.TextBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblCustomerPhoneNumber As System.Windows.Forms.Label
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents txtCustomerEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblCustomerEmail As System.Windows.Forms.Label
    Friend WithEvents txtCustomerPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents lblCustomerName As System.Windows.Forms.Label
    Friend WithEvents txtCustomerID As System.Windows.Forms.TextBox
    Friend WithEvents lblCustomerID As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
End Class
