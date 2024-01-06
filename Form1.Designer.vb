<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.BtnInst = New System.Windows.Forms.Button()
        Me.btnInputs = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.txtdisplay2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnInst
        '
        Me.BtnInst.Location = New System.Drawing.Point(12, 12)
        Me.BtnInst.Name = "BtnInst"
        Me.BtnInst.Size = New System.Drawing.Size(75, 23)
        Me.BtnInst.TabIndex = 0
        Me.BtnInst.Text = "Instantiate"
        Me.BtnInst.UseVisualStyleBackColor = True
        '
        'btnInputs
        '
        Me.btnInputs.Location = New System.Drawing.Point(12, 41)
        Me.btnInputs.Name = "btnInputs"
        Me.btnInputs.Size = New System.Drawing.Size(75, 23)
        Me.btnInputs.TabIndex = 1
        Me.btnInputs.Text = "Inputs"
        Me.btnInputs.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(12, 70)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(75, 23)
        Me.btnDisplay.TabIndex = 2
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(12, 99)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(12, 128)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(75, 23)
        Me.btnRead.TabIndex = 4
        Me.btnRead.Text = "Read"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(12, 157)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Button6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'txtDisplay
        '
        Me.txtDisplay.Location = New System.Drawing.Point(134, 12)
        Me.txtDisplay.Multiline = True
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.Size = New System.Drawing.Size(137, 168)
        Me.txtDisplay.TabIndex = 6
        '
        'txtdisplay2
        '
        Me.txtdisplay2.Location = New System.Drawing.Point(290, 12)
        Me.txtdisplay2.Multiline = True
        Me.txtdisplay2.Name = "txtdisplay2"
        Me.txtdisplay2.Size = New System.Drawing.Size(130, 168)
        Me.txtdisplay2.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtdisplay2)
        Me.Controls.Add(Me.txtDisplay)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.btnInputs)
        Me.Controls.Add(Me.BtnInst)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnInst As Button
    Friend WithEvents btnInputs As Button
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnRead As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents txtdisplay2 As TextBox
End Class
