<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProduct
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
        Me.txtCardName = New System.Windows.Forms.TextBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.txtCardType = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCardSet = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProductPrice = New System.Windows.Forms.TextBox()
        Me.lblfullname = New System.Windows.Forms.Label()
        Me.txtProductID = New System.Windows.Forms.TextBox()
        Me.lblpplID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCardColor = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(340, 398)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 13)
        Me.lblTotal.TabIndex = 37
        '
        'lblCurrent
        '
        Me.lblCurrent.AutoSize = True
        Me.lblCurrent.Location = New System.Drawing.Point(170, 398)
        Me.lblCurrent.Name = "lblCurrent"
        Me.lblCurrent.Size = New System.Drawing.Size(0, 13)
        Me.lblCurrent.TabIndex = 36
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(272, 398)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(48, 23)
        Me.btnLast.TabIndex = 35
        Me.btnLast.Text = ">|"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(218, 398)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(48, 23)
        Me.btnNext.TabIndex = 34
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnprev
        '
        Me.btnprev.Location = New System.Drawing.Point(98, 398)
        Me.btnprev.Name = "btnprev"
        Me.btnprev.Size = New System.Drawing.Size(48, 23)
        Me.btnprev.TabIndex = 33
        Me.btnprev.Text = "<"
        Me.btnprev.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(44, 398)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(48, 23)
        Me.btnFirst.TabIndex = 32
        Me.btnFirst.Text = "|<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'txtCardName
        '
        Me.txtCardName.Location = New System.Drawing.Point(47, 136)
        Me.txtCardName.Name = "txtCardName"
        Me.txtCardName.Size = New System.Drawing.Size(100, 20)
        Me.txtCardName.TabIndex = 31
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(44, 119)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(63, 13)
        Me.lblGender.TabIndex = 30
        Me.lblGender.Text = "Card Name:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(436, 398)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 29
        Me.btnExit.Text = "Home"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(44, 170)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(54, 13)
        Me.lblPhone.TabIndex = 28
        Me.lblPhone.Text = "Card Set: "
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(329, 38)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(75, 23)
        Me.btnCreate.TabIndex = 27
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'txtCardType
        '
        Me.txtCardType.Location = New System.Drawing.Point(47, 238)
        Me.txtCardType.Name = "txtCardType"
        Me.txtCardType.Size = New System.Drawing.Size(100, 20)
        Me.txtCardType.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Card Type:"
        '
        'txtCardSet
        '
        Me.txtCardSet.Location = New System.Drawing.Point(44, 190)
        Me.txtCardSet.Name = "txtCardSet"
        Me.txtCardSet.Size = New System.Drawing.Size(100, 20)
        Me.txtCardSet.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 23
        '
        'txtProductPrice
        '
        Me.txtProductPrice.Location = New System.Drawing.Point(44, 92)
        Me.txtProductPrice.Name = "txtProductPrice"
        Me.txtProductPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtProductPrice.TabIndex = 22
        '
        'lblfullname
        '
        Me.lblfullname.AutoSize = True
        Me.lblfullname.Location = New System.Drawing.Point(41, 75)
        Me.lblfullname.Name = "lblfullname"
        Me.lblfullname.Size = New System.Drawing.Size(74, 13)
        Me.lblfullname.TabIndex = 21
        Me.lblfullname.Text = "Product Price:"
        '
        'txtProductID
        '
        Me.txtProductID.Location = New System.Drawing.Point(41, 38)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.Size = New System.Drawing.Size(100, 20)
        Me.txtProductID.TabIndex = 20
        '
        'lblpplID
        '
        Me.lblpplID.AutoSize = True
        Me.lblpplID.Location = New System.Drawing.Point(38, 21)
        Me.lblpplID.Name = "lblpplID"
        Me.lblpplID.Size = New System.Drawing.Size(61, 13)
        Me.lblpplID.TabIndex = 19
        Me.lblpplID.Text = "Product ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 282)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Card Color:"
        '
        'txtCardColor
        '
        Me.txtCardColor.Location = New System.Drawing.Point(47, 303)
        Me.txtCardColor.Name = "txtCardColor"
        Me.txtCardColor.Size = New System.Drawing.Size(100, 20)
        Me.txtCardColor.TabIndex = 39
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(329, 151)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 40
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(329, 75)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 41
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(329, 114)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 42
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'frmProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 451)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.txtCardColor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblCurrent)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnprev)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.txtCardName)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.txtCardType)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCardSet)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtProductPrice)
        Me.Controls.Add(Me.lblfullname)
        Me.Controls.Add(Me.txtProductID)
        Me.Controls.Add(Me.lblpplID)
        Me.Name = "frmProduct"
        Me.Text = "frmProduct"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblCurrent As System.Windows.Forms.Label
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnprev As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents txtCardName As System.Windows.Forms.TextBox
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents txtCardType As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCardSet As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtProductPrice As System.Windows.Forms.TextBox
    Friend WithEvents lblfullname As System.Windows.Forms.Label
    Friend WithEvents txtProductID As System.Windows.Forms.TextBox
    Friend WithEvents lblpplID As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCardColor As System.Windows.Forms.TextBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button

End Class
