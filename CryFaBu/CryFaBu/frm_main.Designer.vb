<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_main
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_start = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.SuspendLayout()
        '
        'btn_start
        '
        Me.btn_start.Location = New System.Drawing.Point(280, 253)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(317, 154)
        Me.btn_start.TabIndex = 0
        Me.btn_start.Text = "Start"
        Me.btn_start.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(136, 390)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(62, 17)
        Me.CheckBox1.TabIndex = 1
        Me.CheckBox1.Text = "Sicher?"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(673, 156)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(8, 4)
        Me.CheckedListBox1.TabIndex = 2
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 419)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.btn_start)
        Me.Name = "frm_main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "^^"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_start As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckedListBox1 As CheckedListBox
End Class
