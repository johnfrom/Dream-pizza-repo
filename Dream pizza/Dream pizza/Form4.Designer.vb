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
        Me.lblSummary = New System.Windows.Forms.Label()
        Me.btnSummaryBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblSummary
        '
        Me.lblSummary.Location = New System.Drawing.Point(91, 72)
        Me.lblSummary.Name = "lblSummary"
        Me.lblSummary.Size = New System.Drawing.Size(397, 271)
        Me.lblSummary.TabIndex = 0
        Me.lblSummary.Text = "summary"
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
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSummaryBack)
        Me.Controls.Add(Me.lblSummary)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblSummary As Label
    Friend WithEvents btnSummaryBack As Button
End Class
