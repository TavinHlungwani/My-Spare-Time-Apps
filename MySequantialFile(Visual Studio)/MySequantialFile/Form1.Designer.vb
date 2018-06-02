<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSeq
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.btnWrite = New System.Windows.Forms.Button()
        Me.txtShowStuff = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(12, 12)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(139, 27)
        Me.btnCreate.TabIndex = 0
        Me.btnCreate.Text = "Create file"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 45)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(139, 28)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Capture"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(12, 110)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(139, 23)
        Me.btnRead.TabIndex = 2
        Me.btnRead.Text = "Read file"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'btnWrite
        '
        Me.btnWrite.Location = New System.Drawing.Point(12, 79)
        Me.btnWrite.Name = "btnWrite"
        Me.btnWrite.Size = New System.Drawing.Size(139, 25)
        Me.btnWrite.TabIndex = 3
        Me.btnWrite.Text = "Write file"
        Me.btnWrite.UseVisualStyleBackColor = True
        '
        'txtShowStuff
        '
        Me.txtShowStuff.Location = New System.Drawing.Point(157, 12)
        Me.txtShowStuff.Multiline = True
        Me.txtShowStuff.Name = "txtShowStuff"
        Me.txtShowStuff.Size = New System.Drawing.Size(185, 121)
        Me.txtShowStuff.TabIndex = 4
        '
        'frmSeq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 138)
        Me.Controls.Add(Me.txtShowStuff)
        Me.Controls.Add(Me.btnWrite)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnCreate)
        Me.Name = "frmSeq"
        Me.Text = "Sequantial"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCreate As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnRead As Button
    Friend WithEvents btnWrite As Button
    Friend WithEvents txtShowStuff As TextBox
End Class
