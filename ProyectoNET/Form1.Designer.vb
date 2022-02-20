<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SuiteApp
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
        Me.Correo = New System.Windows.Forms.Button()
        Me.Periodico = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Correo
        '
        Me.Correo.Location = New System.Drawing.Point(76, 52)
        Me.Correo.Name = "Correo"
        Me.Correo.Size = New System.Drawing.Size(75, 23)
        Me.Correo.TabIndex = 0
        Me.Correo.Text = "Correo"
        Me.Correo.UseVisualStyleBackColor = True
        '
        'Periodico
        '
        Me.Periodico.Location = New System.Drawing.Point(212, 52)
        Me.Periodico.Name = "Periodico"
        Me.Periodico.Size = New System.Drawing.Size(75, 23)
        Me.Periodico.TabIndex = 1
        Me.Periodico.Text = "Periodico"
        Me.Periodico.UseVisualStyleBackColor = True
        '
        'SuiteApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 436)
        Me.Controls.Add(Me.Periodico)
        Me.Controls.Add(Me.Correo)
        Me.Name = "SuiteApp"
        Me.Text = "SuiteApp"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Correo As Button
    Friend WithEvents Periodico As Button
End Class
