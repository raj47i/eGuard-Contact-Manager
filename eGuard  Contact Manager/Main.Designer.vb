<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CLCategory = New System.Windows.Forms.ComboBox
        Me.B_TYPAdd = New System.Windows.Forms.Button
        Me.B_TYPDel = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.B_TYPView = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Restore = New System.Windows.Forms.Button
        Me.BtnPWD = New System.Windows.Forms.Button
        Me.Backup = New System.Windows.Forms.Button
        Me.BtnLOAD = New System.Windows.Forms.Button
        Me.txtPwd = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.BtnAbout = New System.Windows.Forms.Button
        Me.BtnHELP = New System.Windows.Forms.Button
        Me.BtnEXIT = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'CLCategory
        '
        Me.CLCategory.BackColor = System.Drawing.SystemColors.Info
        Me.CLCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CLCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CLCategory.FormattingEnabled = True
        Me.CLCategory.Location = New System.Drawing.Point(7, 19)
        Me.CLCategory.Name = "CLCategory"
        Me.CLCategory.Size = New System.Drawing.Size(170, 21)
        Me.CLCategory.TabIndex = 0
        '
        'B_TYPAdd
        '
        Me.B_TYPAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.B_TYPAdd.Location = New System.Drawing.Point(8, 46)
        Me.B_TYPAdd.Name = "B_TYPAdd"
        Me.B_TYPAdd.Size = New System.Drawing.Size(52, 23)
        Me.B_TYPAdd.TabIndex = 6
        Me.B_TYPAdd.Text = "Add"
        Me.B_TYPAdd.UseVisualStyleBackColor = True
        '
        'B_TYPDel
        '
        Me.B_TYPDel.Location = New System.Drawing.Point(66, 46)
        Me.B_TYPDel.Name = "B_TYPDel"
        Me.B_TYPDel.Size = New System.Drawing.Size(52, 23)
        Me.B_TYPDel.TabIndex = 8
        Me.B_TYPDel.Text = "Delete"
        Me.B_TYPDel.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CLCategory)
        Me.GroupBox1.Controls.Add(Me.B_TYPView)
        Me.GroupBox1.Controls.Add(Me.B_TYPAdd)
        Me.GroupBox1.Controls.Add(Me.B_TYPDel)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(12, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(185, 79)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Types"
        '
        'B_TYPView
        '
        Me.B_TYPView.Location = New System.Drawing.Point(125, 46)
        Me.B_TYPView.Name = "B_TYPView"
        Me.B_TYPView.Size = New System.Drawing.Size(52, 23)
        Me.B_TYPView.TabIndex = 11
        Me.B_TYPView.Text = "View"
        Me.B_TYPView.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Restore)
        Me.GroupBox2.Controls.Add(Me.BtnPWD)
        Me.GroupBox2.Controls.Add(Me.Backup)
        Me.GroupBox2.Controls.Add(Me.BtnLOAD)
        Me.GroupBox2.Controls.Add(Me.txtPwd)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(185, 98)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "My Contacts"
        '
        'Restore
        '
        Me.Restore.Enabled = False
        Me.Restore.Location = New System.Drawing.Point(94, 67)
        Me.Restore.Name = "Restore"
        Me.Restore.Size = New System.Drawing.Size(83, 23)
        Me.Restore.TabIndex = 8
        Me.Restore.Text = "Restore Data"
        Me.Restore.UseVisualStyleBackColor = True
        '
        'BtnPWD
        '
        Me.BtnPWD.Enabled = False
        Me.BtnPWD.Location = New System.Drawing.Point(8, 42)
        Me.BtnPWD.Name = "BtnPWD"
        Me.BtnPWD.Size = New System.Drawing.Size(108, 23)
        Me.BtnPWD.TabIndex = 15
        Me.BtnPWD.Text = "Change Password"
        Me.BtnPWD.UseVisualStyleBackColor = True
        '
        'Backup
        '
        Me.Backup.Enabled = False
        Me.Backup.Location = New System.Drawing.Point(8, 67)
        Me.Backup.Name = "Backup"
        Me.Backup.Size = New System.Drawing.Size(83, 23)
        Me.Backup.TabIndex = 7
        Me.Backup.Text = "Backup Data"
        Me.Backup.UseVisualStyleBackColor = True
        '
        'BtnLOAD
        '
        Me.BtnLOAD.Location = New System.Drawing.Point(119, 42)
        Me.BtnLOAD.Name = "BtnLOAD"
        Me.BtnLOAD.Size = New System.Drawing.Size(58, 23)
        Me.BtnLOAD.TabIndex = 12
        Me.BtnLOAD.Text = "Load"
        Me.BtnLOAD.UseVisualStyleBackColor = True
        '
        'txtPwd
        '
        Me.txtPwd.BackColor = System.Drawing.SystemColors.Info
        Me.txtPwd.Location = New System.Drawing.Point(76, 16)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.Size = New System.Drawing.Size(101, 20)
        Me.txtPwd.TabIndex = 3
        Me.txtPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPwd.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(8, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.BtnAbout)
        Me.GroupBox3.Controls.Add(Me.BtnHELP)
        Me.GroupBox3.Controls.Add(Me.BtnEXIT)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 199)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(185, 46)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Options"
        '
        'BtnAbout
        '
        Me.BtnAbout.Location = New System.Drawing.Point(8, 17)
        Me.BtnAbout.Name = "BtnAbout"
        Me.BtnAbout.Size = New System.Drawing.Size(52, 23)
        Me.BtnAbout.TabIndex = 18
        Me.BtnAbout.Text = "About"
        Me.BtnAbout.UseVisualStyleBackColor = True
        '
        'BtnHELP
        '
        Me.BtnHELP.Location = New System.Drawing.Point(66, 17)
        Me.BtnHELP.Name = "BtnHELP"
        Me.BtnHELP.Size = New System.Drawing.Size(52, 23)
        Me.BtnHELP.TabIndex = 17
        Me.BtnHELP.Text = "Help"
        Me.BtnHELP.UseVisualStyleBackColor = True
        '
        'BtnEXIT
        '
        Me.BtnEXIT.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnEXIT.Location = New System.Drawing.Point(124, 17)
        Me.BtnEXIT.Name = "BtnEXIT"
        Me.BtnEXIT.Size = New System.Drawing.Size(52, 23)
        Me.BtnEXIT.TabIndex = 16
        Me.BtnEXIT.Text = "Exit"
        Me.BtnEXIT.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AcceptButton = Me.BtnLOAD
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.eGuard__Contact_Manager.My.Resources.Resources.bk
        Me.CancelButton = Me.BtnEXIT
        Me.ClientSize = New System.Drawing.Size(208, 259)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "  Contact Manager"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CLCategory As System.Windows.Forms.ComboBox
    Public WithEvents B_TYPAdd As System.Windows.Forms.Button
    Friend WithEvents B_TYPDel As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents B_TYPView As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPwd As System.Windows.Forms.TextBox
    Friend WithEvents BtnLOAD As System.Windows.Forms.Button
    Friend WithEvents BtnPWD As System.Windows.Forms.Button
    Public WithEvents Restore As System.Windows.Forms.Button
    Public WithEvents Backup As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnAbout As System.Windows.Forms.Button
    Friend WithEvents BtnHELP As System.Windows.Forms.Button
    Friend WithEvents BtnEXIT As System.Windows.Forms.Button

End Class
