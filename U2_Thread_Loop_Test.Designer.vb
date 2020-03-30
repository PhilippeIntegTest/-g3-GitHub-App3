<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class U2_Thread_Loop_Test
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Button_Thread = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button_Thread
        '
        Me.Button_Thread.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button_Thread.Location = New System.Drawing.Point(3, 3)
        Me.Button_Thread.Name = "Button_Thread"
        Me.Button_Thread.Size = New System.Drawing.Size(230, 23)
        Me.Button_Thread.TabIndex = 0
        Me.Button_Thread.Text = "Launch Loop with High Compute rate"
        Me.Button_Thread.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(94, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(363, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "General info at Startup of the process"
        '
        'U2_Thread_Loop_Test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button_Thread)
        Me.Name = "U2_Thread_Loop_Test"
        Me.Size = New System.Drawing.Size(460, 98)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_Thread As Button
    Friend WithEvents TextBox1 As TextBox
End Class
