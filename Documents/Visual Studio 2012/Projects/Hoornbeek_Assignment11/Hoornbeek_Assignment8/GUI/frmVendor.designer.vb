<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVendor
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
        Me.txtVendorAddress = New System.Windows.Forms.TextBox()
        Me.lblVendorAddress = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblVendorPhoneNumber = New System.Windows.Forms.Label()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.txtVendorEmail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtVendorName = New System.Windows.Forms.TextBox()
        Me.lblVendorName = New System.Windows.Forms.Label()
        Me.txtVendorID = New System.Windows.Forms.TextBox()
        Me.lblVendorID = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(331, 422)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 13)
        Me.lblTotal.TabIndex = 58
        '
        'lblCurrent
        '
        Me.lblCurrent.AutoSize = True
        Me.lblCurrent.Location = New System.Drawing.Point(161, 422)
        Me.lblCurrent.Name = "lblCurrent"
        Me.lblCurrent.Size = New System.Drawing.Size(0, 13)
        Me.lblCurrent.TabIndex = 57
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(263, 422)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(48, 23)
        Me.btnLast.TabIndex = 56
        Me.btnLast.Text = ">|"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(209, 422)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(48, 23)
        Me.btnNext.TabIndex = 55
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnprev
        '
        Me.btnprev.Location = New System.Drawing.Point(89, 422)
        Me.btnprev.Name = "btnprev"
        Me.btnprev.Size = New System.Drawing.Size(48, 23)
        Me.btnprev.TabIndex = 54
        Me.btnprev.Text = "<"
        Me.btnprev.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(35, 422)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(48, 23)
        Me.btnFirst.TabIndex = 53
        Me.btnFirst.Text = "|<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'txtVendorAddress
        '
        Me.txtVendorAddress.Location = New System.Drawing.Point(38, 160)
        Me.txtVendorAddress.Name = "txtVendorAddress"
        Me.txtVendorAddress.Size = New System.Drawing.Size(100, 20)
        Me.txtVendorAddress.TabIndex = 52
        '
        'lblVendorAddress
        '
        Me.lblVendorAddress.AutoSize = True
        Me.lblVendorAddress.Location = New System.Drawing.Point(35, 143)
        Me.lblVendorAddress.Name = "lblVendorAddress"
        Me.lblVendorAddress.Size = New System.Drawing.Size(85, 13)
        Me.lblVendorAddress.TabIndex = 51
        Me.lblVendorAddress.Text = "Vendor Address:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(427, 422)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 50
        Me.btnExit.Text = "Home"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblVendorPhoneNumber
        '
        Me.lblVendorPhoneNumber.AutoSize = True
        Me.lblVendorPhoneNumber.Location = New System.Drawing.Point(35, 194)
        Me.lblVendorPhoneNumber.Name = "lblVendorPhoneNumber"
        Me.lblVendorPhoneNumber.Size = New System.Drawing.Size(118, 13)
        Me.lblVendorPhoneNumber.TabIndex = 49
        Me.lblVendorPhoneNumber.Text = "Vendor Phone Number:"
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(320, 62)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(75, 23)
        Me.btnCreate.TabIndex = 48
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'txtVendorEmail
        '
        Me.txtVendorEmail.Location = New System.Drawing.Point(38, 262)
        Me.txtVendorEmail.Name = "txtVendorEmail"
        Me.txtVendorEmail.Size = New System.Drawing.Size(100, 20)
        Me.txtVendorEmail.TabIndex = 47
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Vendor Email:"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(35, 214)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(100, 20)
        Me.txtPhone.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 44
        '
        'txtVendorName
        '
        Me.txtVendorName.Location = New System.Drawing.Point(35, 116)
        Me.txtVendorName.Name = "txtVendorName"
        Me.txtVendorName.Size = New System.Drawing.Size(100, 20)
        Me.txtVendorName.TabIndex = 43
        '
        'lblVendorName
        '
        Me.lblVendorName.AutoSize = True
        Me.lblVendorName.Location = New System.Drawing.Point(32, 99)
        Me.lblVendorName.Name = "lblVendorName"
        Me.lblVendorName.Size = New System.Drawing.Size(75, 13)
        Me.lblVendorName.TabIndex = 42
        Me.lblVendorName.Text = "Vendor Name:"
        '
        'txtVendorID
        '
        Me.txtVendorID.Location = New System.Drawing.Point(32, 62)
        Me.txtVendorID.Name = "txtVendorID"
        Me.txtVendorID.Size = New System.Drawing.Size(100, 20)
        Me.txtVendorID.TabIndex = 41
        '
        'lblVendorID
        '
        Me.lblVendorID.AutoSize = True
        Me.lblVendorID.Location = New System.Drawing.Point(29, 45)
        Me.lblVendorID.Name = "lblVendorID"
        Me.lblVendorID.Size = New System.Drawing.Size(58, 13)
        Me.lblVendorID.TabIndex = 40
        Me.lblVendorID.Text = "Vendor ID:"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(320, 175)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 59
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(320, 99)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 60
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(320, 138)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 61
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'frmVendor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 471)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblCurrent)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnprev)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.txtVendorAddress)
        Me.Controls.Add(Me.lblVendorAddress)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblVendorPhoneNumber)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.txtVendorEmail)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtVendorName)
        Me.Controls.Add(Me.lblVendorName)
        Me.Controls.Add(Me.txtVendorID)
        Me.Controls.Add(Me.lblVendorID)
        Me.Name = "frmVendor"
        Me.Text = "frmVendor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblCurrent As System.Windows.Forms.Label
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnprev As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents txtVendorAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblVendorAddress As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblVendorPhoneNumber As System.Windows.Forms.Label
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents txtVendorEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtVendorName As System.Windows.Forms.TextBox
    Friend WithEvents lblVendorName As System.Windows.Forms.Label
    Friend WithEvents txtVendorID As System.Windows.Forms.TextBox
    Friend WithEvents lblVendorID As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
End Class
