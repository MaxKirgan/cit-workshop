<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSwitch
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
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.btnProduct = New System.Windows.Forms.Button()
        Me.btnVendor = New System.Windows.Forms.Button()
        Me.btnTransaction = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCustomer
        '
        Me.btnCustomer.Location = New System.Drawing.Point(27, 24)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(75, 23)
        Me.btnCustomer.TabIndex = 0
        Me.btnCustomer.Text = "Customer"
        Me.btnCustomer.UseVisualStyleBackColor = True
        '
        'btnProduct
        '
        Me.btnProduct.Location = New System.Drawing.Point(199, 24)
        Me.btnProduct.Name = "btnProduct"
        Me.btnProduct.Size = New System.Drawing.Size(75, 23)
        Me.btnProduct.TabIndex = 1
        Me.btnProduct.Text = "Product"
        Me.btnProduct.UseVisualStyleBackColor = True
        '
        'btnVendor
        '
        Me.btnVendor.Location = New System.Drawing.Point(27, 118)
        Me.btnVendor.Name = "btnVendor"
        Me.btnVendor.Size = New System.Drawing.Size(75, 23)
        Me.btnVendor.TabIndex = 2
        Me.btnVendor.Text = "Vendor"
        Me.btnVendor.UseVisualStyleBackColor = True
        '
        'btnTransaction
        '
        Me.btnTransaction.Location = New System.Drawing.Point(199, 118)
        Me.btnTransaction.Name = "btnTransaction"
        Me.btnTransaction.Size = New System.Drawing.Size(75, 23)
        Me.btnTransaction.TabIndex = 3
        Me.btnTransaction.Text = "Transaction"
        Me.btnTransaction.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(253, 175)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmSwitch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 210)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnTransaction)
        Me.Controls.Add(Me.btnVendor)
        Me.Controls.Add(Me.btnProduct)
        Me.Controls.Add(Me.btnCustomer)
        Me.Name = "frmSwitch"
        Me.Text = "frmSwitch"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCustomer As System.Windows.Forms.Button
    Friend WithEvents btnProduct As System.Windows.Forms.Button
    Friend WithEvents btnVendor As System.Windows.Forms.Button
    Friend WithEvents btnTransaction As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
