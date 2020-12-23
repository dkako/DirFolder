<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TheForm
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
		Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
		Me.LoadButton = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.DontCheckBox = New System.Windows.Forms.CheckBox()
		Me.UseBackSlashBox = New System.Windows.Forms.CheckBox()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'SaveFileDialog1
		'
		Me.SaveFileDialog1.FileName = "output.csv"
		Me.SaveFileDialog1.Filter = "CSV Files (*.csv)|*.csv|All files|*.*"
		'
		'LoadButton
		'
		Me.LoadButton.Location = New System.Drawing.Point(398, 2)
		Me.LoadButton.Name = "LoadButton"
		Me.LoadButton.Size = New System.Drawing.Size(75, 63)
		Me.LoadButton.TabIndex = 1
		Me.LoadButton.Text = "Load..."
		Me.LoadButton.UseVisualStyleBackColor = True
		'
		'Label2
		'
		Me.Label2.Location = New System.Drawing.Point(12, 2)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(380, 63)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "Not run yet."
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.DontCheckBox)
		Me.GroupBox1.Controls.Add(Me.UseBackSlashBox)
		Me.GroupBox1.Location = New System.Drawing.Point(12, 68)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(454, 112)
		Me.GroupBox1.TabIndex = 4
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Options"
		'
		'DontCheckBox
		'
		Me.DontCheckBox.AutoSize = True
		Me.DontCheckBox.Enabled = False
		Me.DontCheckBox.Location = New System.Drawing.Point(6, 42)
		Me.DontCheckBox.Name = "DontCheckBox"
		Me.DontCheckBox.Size = New System.Drawing.Size(245, 17)
		Me.DontCheckBox.TabIndex = 0
		Me.DontCheckBox.Text = "Do not check again files found in dir output file"
		Me.DontCheckBox.UseVisualStyleBackColor = True
		'
		'UseBackSlashBox
		'
		Me.UseBackSlashBox.AutoSize = True
		Me.UseBackSlashBox.Enabled = False
		Me.UseBackSlashBox.Location = New System.Drawing.Point(6, 19)
		Me.UseBackSlashBox.Name = "UseBackSlashBox"
		Me.UseBackSlashBox.Size = New System.Drawing.Size(288, 17)
		Me.UseBackSlashBox.TabIndex = 0
		Me.UseBackSlashBox.Text = "Use backslash for <fullpath> output (mysql compatibility)"
		Me.UseBackSlashBox.UseVisualStyleBackColor = True
		'
		'TheForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(478, 185)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.LoadButton)
		Me.MaximizeBox = False
		Me.Name = "TheForm"
		Me.Text = "DirFolder"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents SaveFileDialog1 As SaveFileDialog
	Friend WithEvents LoadButton As Button
	Friend WithEvents Label2 As Label
	Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents DontCheckBox As CheckBox
	Friend WithEvents UseBackSlashBox As CheckBox
End Class
