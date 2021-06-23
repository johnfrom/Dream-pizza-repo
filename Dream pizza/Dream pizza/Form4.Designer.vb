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
        Me.lblSummary1 = New System.Windows.Forms.Label()
        Me.btnSummaryBack = New System.Windows.Forms.Button()
        Me.lblSummary2 = New System.Windows.Forms.Label()
        Me.lblSummary3 = New System.Windows.Forms.Label()
        Me.lblSummaryCustomer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblSummary1
        '
        Me.lblSummary1.Location = New System.Drawing.Point(241, 44)
        Me.lblSummary1.Name = "lblSummary1"
        Me.lblSummary1.Size = New System.Drawing.Size(157, 303)
        Me.lblSummary1.TabIndex = 0
        Me.lblSummary1.Text = "summary"
        '
        'btnSummaryBack
        '
        Me.btnSummaryBack.Location = New System.Drawing.Point(12, 377)
        Me.btnSummaryBack.Name = "btnSummaryBack"
        Me.btnSummaryBack.Size = New System.Drawing.Size(169, 61)
        Me.btnSummaryBack.TabIndex = 38
        Me.btnSummaryBack.Text = "Go Back"
        Me.btnSummaryBack.UseVisualStyleBackColor = True
        '
        'lblSummary2
        '
        Me.lblSummary2.Location = New System.Drawing.Point(404, 44)
        Me.lblSummary2.Name = "lblSummary2"
        Me.lblSummary2.Size = New System.Drawing.Size(157, 303)
        Me.lblSummary2.TabIndex = 39
        Me.lblSummary2.Text = "summary"
        '
        'lblSummary3
        '
        Me.lblSummary3.Location = New System.Drawing.Point(567, 44)
        Me.lblSummary3.Name = "lblSummary3"
        Me.lblSummary3.Size = New System.Drawing.Size(157, 303)
        Me.lblSummary3.TabIndex = 40
        Me.lblSummary3.Text = "summary"
        '
        'lblSummaryCustomer
        '
        Me.lblSummaryCustomer.Location = New System.Drawing.Point(12, 44)
        Me.lblSummaryCustomer.Name = "lblSummaryCustomer"
        Me.lblSummaryCustomer.Size = New System.Drawing.Size(129, 286)
        Me.lblSummaryCustomer.TabIndex = 41
        Me.lblSummaryCustomer.Text = "summary"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblSummaryCustomer)
        Me.Controls.Add(Me.lblSummary3)
        Me.Controls.Add(Me.lblSummary2)
        Me.Controls.Add(Me.btnSummaryBack)
        Me.Controls.Add(Me.lblSummary1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblSummary1 As Label
    Friend WithEvents btnSummaryBack As Button
    Friend WithEvents lblSummary2 As Label
    Friend WithEvents lblSummary3 As Label
    Friend WithEvents lblSummaryCustomer As Label
End Class
