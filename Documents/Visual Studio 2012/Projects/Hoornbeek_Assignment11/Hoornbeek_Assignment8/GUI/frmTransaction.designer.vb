<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransaction
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
        Me.txtPayment = New System.Windows.Forms.TextBox()
        Me.lblPayMeth = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblCurrent = New System.Windows.Forms.Label()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnprev = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.lblCustomerID = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblVendorID = New System.Windows.Forms.Label()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.txtVendorID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProductID = New System.Windows.Forms.TextBox()
        Me.lblProductID = New System.Windows.Forms.Label()
        Me.txtTransactionID = New System.Windows.Forms.TextBox()
        Me.lblTransactionID = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtPayment
        '
        Me.txtPayment.Location = New System.Drawing.Point(33, 325)
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Size = New System.Drawing.Size(100, 20)
        Me.txtPayment.TabIndex = 60
        '
        'lblPayMeth
        '
        Me.lblPayMeth.AutoSize = True
        Me.lblPayMeth.Location = New System.Drawing.Point(30, 304)
        Me.lblPayMeth.Name = "lblPayMeth"
        Me.lblPayMeth.Size = New System.Drawing.Size(90, 13)
        Me.lblPayMeth.TabIndex = 59
        Me.lblPayMeth.Text = "Payment Method:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(326, 437)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 13)
        Me.lblTotal.TabIndex = 58
        '
        'lblCurrent
        '
        Me.lblCurrent.AutoSize = True
        Me.lblCurrent.Location = New System.Drawing.Point(156, 437)
        Me.lblCurrent.Name = "lblCurrent"
        Me.lblCurrent.Size = New System.Drawing.Size(0, 13)
        Me.lblCurrent.TabIndex = 57
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(258, 437)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(48, 23)
        Me.btnLast.TabIndex = 56
        Me.btnLast.Text = ">|"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(204, 437)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(48, 23)
        Me.btnNext.TabIndex = 55
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnprev
        '
        Me.btnprev.Location = New System.Drawing.Point(84, 437)
        Me.btnprev.Name = "btnprev"
        Me.btnprev.Size = New System.Drawing.Size(48, 23)
        Me.btnprev.TabIndex = 54
        Me.btnprev.Text = "<"
        Me.btnprev.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(30, 437)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(48, 23)
        Me.btnFirst.TabIndex = 53
        Me.btnFirst.Text = "|<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Location = New System.Drawing.Point(33, 158)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomerID.TabIndex = 52
        '
        'lblCustomerID
        '
        Me.lblCustomerID.AutoSize = True
        Me.lblCustomerID.Location = New System.Drawing.Point(30, 141)
        Me.lblCustomerID.Name = "lblCustomerID"
        Me.lblCustomerID.Size = New System.Drawing.Size(71, 13)
        Me.lblCustomerID.TabIndex = 51
        Me.lblCustomerID.Text = "Customer ID: "
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(422, 437)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 50
        Me.btnExit.Text = "Home"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblVendorID
        '
        Me.lblVendorID.AutoSize = True
        Me.lblVendorID.Location = New System.Drawing.Point(30, 192)
        Me.lblVendorID.Name = "lblVendorID"
        Me.lblVendorID.Size = New System.Drawing.Size(58, 13)
        Me.lblVendorID.TabIndex = 49
        Me.lblVendorID.Text = "Vendor ID:"
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(315, 60)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(75, 23)
        Me.btnCreate.TabIndex = 48
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(33, 260)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(100, 20)
        Me.txtDate.TabIndex = 47
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(30, 244)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 46
        Me.lblDate.Text = "Date:"
        '
        'txtVendorID
        '
        Me.txtVendorID.Location = New System.Drawing.Point(30, 212)
        Me.txtVendorID.Name = "txtVendorID"
        Me.txtVendorID.Size = New System.Drawing.Size(100, 20)
        Me.txtVendorID.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 44
        '
        'txtProductID
        '
        Me.txtProductID.Location = New System.Drawing.Point(30, 111)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.Size = New System.Drawing.Size(100, 20)
        Me.txtProductID.TabIndex = 43
        '
        'lblProductID
        '
        Me.lblProductID.AutoSize = True
        Me.lblProductID.Location = New System.Drawing.Point(27, 95)
        Me.lblProductID.Name = "lblProductID"
        Me.lblProductID.Size = New System.Drawing.Size(61, 13)
        Me.lblProductID.TabIndex = 42
        Me.lblProductID.Text = "Product ID:"
        '
        'txtTransactionID
        '
        Me.txtTransactionID.Location = New System.Drawing.Point(27, 60)
        Me.txtTransactionID.Name = "txtTransactionID"
        Me.txtTransactionID.Size = New System.Drawing.Size(100, 20)
        Me.txtTransactionID.TabIndex = 41
        '
        'lblTransactionID
        '
        Me.lblTransactionID.AutoSize = True
        Me.lblTransactionID.Location = New System.Drawing.Point(24, 43)
        Me.lblTransactionID.Name = "lblTransactionID"
        Me.lblTransactionID.Size = New System.Drawing.Size(80, 13)
        Me.lblTransactionID.TabIndex = 40
        Me.lblTransactionID.Text = "Transaction ID:"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(30, 361)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(89, 13)
        Me.lblQuantity.TabIndex = 61
        Me.lblQuantity.Text = "Product Quantity:"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(33, 377)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantity.TabIndex = 62
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(315, 188)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 20)
        Me.btnDelete.TabIndex = 63
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(315, 108)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 64
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(315, 150)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 65
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'frmTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 487)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.txtPayment)
        Me.Controls.Add(Me.lblPayMeth)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblCurrent)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnprev)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.txtCustomerID)
        Me.Controls.Add(Me.lblCustomerID)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblVendorID)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.txtVendorID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtProductID)
        Me.Controls.Add(Me.lblProductID)
        Me.Controls.Add(Me.txtTransactionID)
        Me.Controls.Add(Me.lblTransactionID)
        Me.Name = "frmTransaction"
        Me.Text = "frmTransaction"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPayment As System.Windows.Forms.TextBox
    Friend WithEvents lblPayMeth As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblCurrent As System.Windows.Forms.Label
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnprev As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents txtCustomerID As System.Windows.Forms.TextBox
    Friend WithEvents lblCustomerID As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblVendorID As System.Windows.Forms.Label
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents txtVendorID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtProductID As System.Windows.Forms.TextBox
    Friend WithEvents lblProductID As System.Windows.Forms.Label
    Friend WithEvents txtTransactionID As System.Windows.Forms.TextBox
    Friend WithEvents lblTransactionID As System.Windows.Forms.Label
    Friend WithEvents lblQuantity As System.Windows.Forms.Label
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
End Class
