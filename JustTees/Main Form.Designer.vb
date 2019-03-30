<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.menRadio = New System.Windows.Forms.RadioButton()
        Me.womenRadio = New System.Windows.Forms.RadioButton()
        Me.smallRadio = New System.Windows.Forms.RadioButton()
        Me.mediumRadio = New System.Windows.Forms.RadioButton()
        Me.largeRadio = New System.Windows.Forms.RadioButton()
        Me.pictureBox = New System.Windows.Forms.CheckBox()
        Me.nameBox = New System.Windows.Forms.CheckBox()
        Me.numOrdersTextbox = New System.Windows.Forms.TextBox()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.totalPriceTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gBoxSize = New System.Windows.Forms.GroupBox()
        Me.gBoxSize.SuspendLayout()
        Me.SuspendLayout()
        '
        'menRadio
        '
        Me.menRadio.AutoSize = True
        Me.menRadio.Location = New System.Drawing.Point(26, 43)
        Me.menRadio.Name = "menRadio"
        Me.menRadio.Size = New System.Drawing.Size(46, 17)
        Me.menRadio.TabIndex = 0
        Me.menRadio.TabStop = True
        Me.menRadio.Text = "Men"
        Me.menRadio.UseVisualStyleBackColor = True
        '
        'womenRadio
        '
        Me.womenRadio.AutoSize = True
        Me.womenRadio.Location = New System.Drawing.Point(26, 70)
        Me.womenRadio.Name = "womenRadio"
        Me.womenRadio.Size = New System.Drawing.Size(62, 17)
        Me.womenRadio.TabIndex = 1
        Me.womenRadio.TabStop = True
        Me.womenRadio.Text = "Women"
        Me.womenRadio.UseVisualStyleBackColor = True
        '
        'smallRadio
        '
        Me.smallRadio.AutoSize = True
        Me.smallRadio.Location = New System.Drawing.Point(17, 19)
        Me.smallRadio.Name = "smallRadio"
        Me.smallRadio.Size = New System.Drawing.Size(32, 17)
        Me.smallRadio.TabIndex = 2
        Me.smallRadio.TabStop = True
        Me.smallRadio.Text = "S"
        Me.smallRadio.UseVisualStyleBackColor = True
        '
        'mediumRadio
        '
        Me.mediumRadio.AutoSize = True
        Me.mediumRadio.Location = New System.Drawing.Point(17, 46)
        Me.mediumRadio.Name = "mediumRadio"
        Me.mediumRadio.Size = New System.Drawing.Size(34, 17)
        Me.mediumRadio.TabIndex = 3
        Me.mediumRadio.TabStop = True
        Me.mediumRadio.Text = "M"
        Me.mediumRadio.UseVisualStyleBackColor = True
        '
        'largeRadio
        '
        Me.largeRadio.AutoSize = True
        Me.largeRadio.Location = New System.Drawing.Point(17, 74)
        Me.largeRadio.Name = "largeRadio"
        Me.largeRadio.Size = New System.Drawing.Size(31, 17)
        Me.largeRadio.TabIndex = 4
        Me.largeRadio.TabStop = True
        Me.largeRadio.Text = "L"
        Me.largeRadio.UseVisualStyleBackColor = True
        '
        'pictureBox
        '
        Me.pictureBox.AutoSize = True
        Me.pictureBox.Location = New System.Drawing.Point(269, 37)
        Me.pictureBox.Name = "pictureBox"
        Me.pictureBox.Size = New System.Drawing.Size(59, 17)
        Me.pictureBox.TabIndex = 5
        Me.pictureBox.Text = "Picture"
        Me.pictureBox.UseVisualStyleBackColor = True
        '
        'nameBox
        '
        Me.nameBox.AutoSize = True
        Me.nameBox.Location = New System.Drawing.Point(269, 70)
        Me.nameBox.Name = "nameBox"
        Me.nameBox.Size = New System.Drawing.Size(54, 17)
        Me.nameBox.TabIndex = 6
        Me.nameBox.Text = "Name"
        Me.nameBox.UseVisualStyleBackColor = True
        '
        'numOrdersTextbox
        '
        Me.numOrdersTextbox.Location = New System.Drawing.Point(149, 184)
        Me.numOrdersTextbox.Name = "numOrdersTextbox"
        Me.numOrdersTextbox.Size = New System.Drawing.Size(85, 20)
        Me.numOrdersTextbox.TabIndex = 7
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(253, 184)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(75, 23)
        Me.calculateButton.TabIndex = 8
        Me.calculateButton.Text = "Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(253, 225)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 9
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'totalPriceTextBox
        '
        Me.totalPriceTextBox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.totalPriceTextBox.Location = New System.Drawing.Point(149, 225)
        Me.totalPriceTextBox.Name = "totalPriceTextBox"
        Me.totalPriceTextBox.Size = New System.Drawing.Size(85, 20)
        Me.totalPriceTextBox.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 187)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Number ordered:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(83, 230)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Total price:"
        '
        'gBoxSize
        '
        Me.gBoxSize.Controls.Add(Me.smallRadio)
        Me.gBoxSize.Controls.Add(Me.mediumRadio)
        Me.gBoxSize.Controls.Add(Me.largeRadio)
        Me.gBoxSize.Location = New System.Drawing.Point(133, 24)
        Me.gBoxSize.Name = "gBoxSize"
        Me.gBoxSize.Size = New System.Drawing.Size(78, 116)
        Me.gBoxSize.TabIndex = 13
        Me.gBoxSize.TabStop = False
        Me.gBoxSize.Text = "Size"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 263)
        Me.Controls.Add(Me.gBoxSize)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.totalPriceTextBox)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.numOrdersTextbox)
        Me.Controls.Add(Me.nameBox)
        Me.Controls.Add(Me.pictureBox)
        Me.Controls.Add(Me.womenRadio)
        Me.Controls.Add(Me.menRadio)
        Me.Name = "MainForm"
        Me.Text = "Just Tees"
        Me.gBoxSize.ResumeLayout(False)
        Me.gBoxSize.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menRadio As RadioButton
    Friend WithEvents womenRadio As RadioButton
    Friend WithEvents smallRadio As RadioButton
    Friend WithEvents mediumRadio As RadioButton
    Friend WithEvents largeRadio As RadioButton
    Friend WithEvents pictureBox As CheckBox
    Friend WithEvents nameBox As CheckBox
    Friend WithEvents numOrdersTextbox As TextBox
    Friend WithEvents calculateButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents totalPriceTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents gBoxSize As GroupBox
End Class
