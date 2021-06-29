<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.lblSummaryPizzaNames = New System.Windows.Forms.Label()
        Me.btnSummaryBack = New System.Windows.Forms.Button()
        Me.lblSummaryQuantity = New System.Windows.Forms.Label()
        Me.lblSummaryPrice = New System.Windows.Forms.Label()
        Me.lblSummaryCustomer = New System.Windows.Forms.Label()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblSummaryPizzaNames
        '
        Me.lblSummaryPizzaNames.Location = New System.Drawing.Point(241, 44)
        Me.lblSummaryPizzaNames.Name = "lblSummaryPizzaNames"
        Me.lblSummaryPizzaNames.Size = New System.Drawing.Size(157, 303)
        Me.lblSummaryPizzaNames.TabIndex = 0
        Me.lblSummaryPizzaNames.Text = "summary"
        '
        'btnSummaryBack
        '
        Me.btnSummaryBack.Location = New System.Drawing.Point(12, 310)
        Me.btnSummaryBack.Name = "btnSummaryBack"
        Me.btnSummaryBack.Size = New System.Drawing.Size(169, 61)
        Me.btnSummaryBack.TabIndex = 38
        Me.btnSummaryBack.Text = "Go Back"
        Me.btnSummaryBack.UseVisualStyleBackColor = True
        '
        'lblSummaryQuantity
        '
        Me.lblSummaryQuantity.Location = New System.Drawing.Point(404, 44)
        Me.lblSummaryQuantity.Name = "lblSummaryQuantity"
        Me.lblSummaryQuantity.Size = New System.Drawing.Size(157, 303)
        Me.lblSummaryQuantity.TabIndex = 39
        Me.lblSummaryQuantity.Text = "summary"
        '
        'lblSummaryPrice
        '
        Me.lblSummaryPrice.Location = New System.Drawing.Point(567, 44)
        Me.lblSummaryPrice.Name = "lblSummaryPrice"
        Me.lblSummaryPrice.Size = New System.Drawing.Size(157, 303)
        Me.lblSummaryPrice.TabIndex = 40
        Me.lblSummaryPrice.Text = "summary"
        '
        'lblSummaryCustomer
        '
        Me.lblSummaryCustomer.Location = New System.Drawing.Point(12, 44)
        Me.lblSummaryCustomer.Name = "lblSummaryCustomer"
        Me.lblSummaryCustomer.Size = New System.Drawing.Size(129, 286)
        Me.lblSummaryCustomer.TabIndex = 41
        Me.lblSummaryCustomer.Text = "summary"
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(12, 377)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(169, 61)
        Me.btnQuit.TabIndex = 42
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSummaryBack)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.lblSummaryCustomer)
        Me.Controls.Add(Me.lblSummaryPrice)
        Me.Controls.Add(Me.lblSummaryQuantity)
        Me.Controls.Add(Me.lblSummaryPizzaNames)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblSummaryPizzaNames As Label
    Friend WithEvents btnSummaryBack As Button
    Friend WithEvents lblSummaryQuantity As Label
    Friend WithEvents lblSummaryPrice As Label
    Friend WithEvents lblSummaryCustomer As Label
    Friend WithEvents btnQuit As Button
End Class
