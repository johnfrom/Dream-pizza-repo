<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkDelivery = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtPhone = New System.Windows.Forms.MaskedTextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("MV Boli", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(505, 73)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(236, 46)
        Me.lblTitle.TabIndex = 13
        Me.lblTitle.Text = "Dream Pizza"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = Global.Dream_pizza.My.Resources.Resources.pizza_png_3
        Me.PictureBox1.Location = New System.Drawing.Point(46, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(392, 356)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(510, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Customer Name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(601, 182)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(165, 20)
        Me.txtName.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(510, 223)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Phone Number:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(510, 261)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Address:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(510, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Delivery:"
        '
        'chkDelivery
        '
        Me.chkDelivery.AutoSize = True
        Me.chkDelivery.Location = New System.Drawing.Point(601, 147)
        Me.chkDelivery.Name = "chkDelivery"
        Me.chkDelivery.Size = New System.Drawing.Size(56, 17)
        Me.chkDelivery.TabIndex = 21
        Me.chkDelivery.Text = "$3 fee"
        Me.chkDelivery.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(600, 330)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(165, 72)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Continue"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(601, 220)
        Me.txtPhone.Mask = "(999) 000-0000"
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(165, 20)
        Me.txtPhone.TabIndex = 23
        '
        'txtAddress
        '
        Me.txtAddress.Enabled = False
        Me.txtAddress.Location = New System.Drawing.Point(601, 258)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(165, 20)
        Me.txtAddress.TabIndex = 19
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.chkDelivery)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents chkDelivery As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtPhone As MaskedTextBox
    Friend WithEvents txtAddress As TextBox
End Class
