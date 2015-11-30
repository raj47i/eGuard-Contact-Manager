<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContactViewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ContactViewer))
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.FirstRec = New System.Windows.Forms.ToolStripButton
        Me.PreviousRec = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.Number = New System.Windows.Forms.ToolStripTextBox
        Me.TSRecs = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.NextRec = New System.Windows.Forms.ToolStripButton
        Me.LastRec = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.AddRec = New System.Windows.Forms.ToolStripButton
        Me.EditRec = New System.Windows.Forms.ToolStripButton
        Me.DelRec = New System.Windows.Forms.ToolStripButton
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage6 = New System.Windows.Forms.TabPage
        Me.Tp1 = New System.Windows.Forms.TableLayoutPanel
        Me.Label19 = New System.Windows.Forms.Label
        Me.Nation = New System.Windows.Forms.TextBox
        Me.NName = New System.Windows.Forms.TextBox
        Me.LName = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.FName = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel
        Me.Sex = New System.Windows.Forms.RadioButton
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.DOB = New System.Windows.Forms.DateTimePicker
        Me.Notes = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.Tp2 = New System.Windows.Forms.TableLayoutPanel
        Me.State = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.PIN = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Phone = New System.Windows.Forms.TextBox
        Me.Mobile = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.EMail = New System.Windows.Forms.TextBox
        Me.Address = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.Tp3 = New System.Windows.Forms.TableLayoutPanel
        Me.Label26 = New System.Windows.Forms.Label
        Me.CFone = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.CFax = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.CEmail = New System.Windows.Forms.TextBox
        Me.Company = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Job = New System.Windows.Forms.TextBox
        Me.CAddress = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.PhotoBox = New System.Windows.Forms.PictureBox
        Me.GroupBox4.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.Tp1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.Tp2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Tp3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.PhotoBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(61, 328)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(60, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(124, 328)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button3.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button3.Location = New System.Drawing.Point(187, 328)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(60, 23)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Close"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.ToolStrip1)
        Me.GroupBox4.Controls.Add(Me.TabControl1)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(296, 319)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Record Details"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FirstRec, Me.PreviousRec, Me.ToolStripSeparator1, Me.Number, Me.TSRecs, Me.ToolStripSeparator2, Me.NextRec, Me.LastRec, Me.ToolStripSeparator3, Me.AddRec, Me.EditRec, Me.DelRec})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 291)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(290, 25)
        Me.ToolStrip1.TabIndex = 10
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'FirstRec
        '
        Me.FirstRec.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FirstRec.Image = CType(resources.GetObject("FirstRec.Image"), System.Drawing.Image)
        Me.FirstRec.Name = "FirstRec"
        Me.FirstRec.RightToLeftAutoMirrorImage = True
        Me.FirstRec.Size = New System.Drawing.Size(23, 22)
        Me.FirstRec.Text = "Move first"
        '
        'PreviousRec
        '
        Me.PreviousRec.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PreviousRec.Image = CType(resources.GetObject("PreviousRec.Image"), System.Drawing.Image)
        Me.PreviousRec.Name = "PreviousRec"
        Me.PreviousRec.RightToLeftAutoMirrorImage = True
        Me.PreviousRec.Size = New System.Drawing.Size(23, 22)
        Me.PreviousRec.Text = "Move previous"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'Number
        '
        Me.Number.AccessibleName = "Position"
        Me.Number.AutoSize = False
        Me.Number.Name = "Number"
        Me.Number.Size = New System.Drawing.Size(45, 21)
        Me.Number.Text = "0"
        Me.Number.ToolTipText = "Current position"
        '
        'TSRecs
        '
        Me.TSRecs.Name = "TSRecs"
        Me.TSRecs.Size = New System.Drawing.Size(36, 22)
        Me.TSRecs.Text = "of {0}"
        Me.TSRecs.ToolTipText = "Total number of items"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'NextRec
        '
        Me.NextRec.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NextRec.Image = CType(resources.GetObject("NextRec.Image"), System.Drawing.Image)
        Me.NextRec.Name = "NextRec"
        Me.NextRec.RightToLeftAutoMirrorImage = True
        Me.NextRec.Size = New System.Drawing.Size(23, 22)
        Me.NextRec.Text = "Move next"
        '
        'LastRec
        '
        Me.LastRec.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LastRec.Image = CType(resources.GetObject("LastRec.Image"), System.Drawing.Image)
        Me.LastRec.Name = "LastRec"
        Me.LastRec.RightToLeftAutoMirrorImage = True
        Me.LastRec.Size = New System.Drawing.Size(23, 22)
        Me.LastRec.Text = "Move last"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'AddRec
        '
        Me.AddRec.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddRec.Image = CType(resources.GetObject("AddRec.Image"), System.Drawing.Image)
        Me.AddRec.Name = "AddRec"
        Me.AddRec.RightToLeftAutoMirrorImage = True
        Me.AddRec.Size = New System.Drawing.Size(23, 22)
        Me.AddRec.Text = "Add new"
        '
        'EditRec
        '
        Me.EditRec.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.EditRec.Image = CType(resources.GetObject("EditRec.Image"), System.Drawing.Image)
        Me.EditRec.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditRec.Name = "EditRec"
        Me.EditRec.Size = New System.Drawing.Size(32, 22)
        Me.EditRec.Text = "Edit "
        Me.EditRec.ToolTipText = "Edit Contact"
        '
        'DelRec
        '
        Me.DelRec.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DelRec.Image = CType(resources.GetObject("DelRec.Image"), System.Drawing.Image)
        Me.DelRec.Name = "DelRec"
        Me.DelRec.RightToLeftAutoMirrorImage = True
        Me.DelRec.Size = New System.Drawing.Size(23, 22)
        Me.DelRec.Text = "Delete"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Location = New System.Drawing.Point(3, 16)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(290, 272)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.Tp1)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(282, 246)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Personal"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'Tp1
        '
        Me.Tp1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tp1.AutoSize = True
        Me.Tp1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Tp1.ColumnCount = 2
        Me.Tp1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.04255!))
        Me.Tp1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.95745!))
        Me.Tp1.Controls.Add(Me.Label19, 0, 5)
        Me.Tp1.Controls.Add(Me.Nation, 1, 5)
        Me.Tp1.Controls.Add(Me.NName, 1, 2)
        Me.Tp1.Controls.Add(Me.LName, 1, 1)
        Me.Tp1.Controls.Add(Me.Label8, 0, 4)
        Me.Tp1.Controls.Add(Me.Label9, 0, 3)
        Me.Tp1.Controls.Add(Me.Label10, 0, 2)
        Me.Tp1.Controls.Add(Me.Label11, 0, 1)
        Me.Tp1.Controls.Add(Me.FName, 1, 0)
        Me.Tp1.Controls.Add(Me.Label12, 0, 0)
        Me.Tp1.Controls.Add(Me.FlowLayoutPanel2, 1, 3)
        Me.Tp1.Controls.Add(Me.DOB, 1, 4)
        Me.Tp1.Controls.Add(Me.Notes, 1, 6)
        Me.Tp1.Controls.Add(Me.Label7, 0, 6)
        Me.Tp1.Location = New System.Drawing.Point(6, 9)
        Me.Tp1.Name = "Tp1"
        Me.Tp1.RowCount = 7
        Me.Tp1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.Tp1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.Tp1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.Tp1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.Tp1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.Tp1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.Tp1.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.Tp1.Size = New System.Drawing.Size(223, 216)
        Me.Tp1.TabIndex = 4
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(3, 138)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(69, 13)
        Me.Label19.TabIndex = 7
        Me.Label19.Text = "Nationality"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Nation
        '
        Me.Nation.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Nation.Location = New System.Drawing.Point(78, 135)
        Me.Nation.Name = "Nation"
        Me.Nation.ReadOnly = True
        Me.Nation.Size = New System.Drawing.Size(142, 20)
        Me.Nation.TabIndex = 9
        '
        'NName
        '
        Me.NName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NName.Location = New System.Drawing.Point(78, 55)
        Me.NName.Name = "NName"
        Me.NName.ReadOnly = True
        Me.NName.Size = New System.Drawing.Size(142, 20)
        Me.NName.TabIndex = 8
        '
        'LName
        '
        Me.LName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LName.Location = New System.Drawing.Point(78, 29)
        Me.LName.Name = "LName"
        Me.LName.ReadOnly = True
        Me.LName.Size = New System.Drawing.Size(142, 20)
        Me.LName.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Date of Birth"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 85)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Sex"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 58)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Nick Name"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 13)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Last Name"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FName
        '
        Me.FName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FName.Location = New System.Drawing.Point(78, 3)
        Me.FName.Name = "FName"
        Me.FName.ReadOnly = True
        Me.FName.Size = New System.Drawing.Size(142, 20)
        Me.FName.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 6)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "First Name"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.Sex)
        Me.FlowLayoutPanel2.Controls.Add(Me.RadioButton4)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(78, 81)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(142, 22)
        Me.FlowLayoutPanel2.TabIndex = 10
        '
        'Sex
        '
        Me.Sex.AutoSize = True
        Me.Sex.Location = New System.Drawing.Point(3, 3)
        Me.Sex.Name = "Sex"
        Me.Sex.Size = New System.Drawing.Size(48, 17)
        Me.Sex.TabIndex = 11
        Me.Sex.Text = "Male"
        Me.Sex.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Checked = True
        Me.RadioButton4.Location = New System.Drawing.Point(57, 3)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(59, 17)
        Me.RadioButton4.TabIndex = 12
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Female"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'DOB
        '
        Me.DOB.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DOB.CalendarMonthBackground = System.Drawing.SystemColors.Info
        Me.DOB.CalendarTitleForeColor = System.Drawing.SystemColors.Info
        Me.DOB.CustomFormat = "MMMM  dd, yyyy"
        Me.DOB.Enabled = False
        Me.DOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DOB.Location = New System.Drawing.Point(78, 109)
        Me.DOB.Name = "DOB"
        Me.DOB.Size = New System.Drawing.Size(142, 20)
        Me.DOB.TabIndex = 11
        Me.DOB.Value = New Date(1985, 3, 1, 0, 0, 0, 0)
        '
        'Notes
        '
        Me.Notes.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Notes.Location = New System.Drawing.Point(78, 161)
        Me.Notes.Multiline = True
        Me.Notes.Name = "Notes"
        Me.Notes.ReadOnly = True
        Me.Notes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Notes.Size = New System.Drawing.Size(142, 52)
        Me.Notes.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 58)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Notes"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.Tp2)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(282, 246)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Contact"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Tp2
        '
        Me.Tp2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tp2.AutoSize = True
        Me.Tp2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Tp2.ColumnCount = 2
        Me.Tp2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.37037!))
        Me.Tp2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.62963!))
        Me.Tp2.Controls.Add(Me.State, 1, 5)
        Me.Tp2.Controls.Add(Me.Label15, 0, 5)
        Me.Tp2.Controls.Add(Me.PIN, 1, 4)
        Me.Tp2.Controls.Add(Me.Label14, 0, 4)
        Me.Tp2.Controls.Add(Me.Label18, 0, 0)
        Me.Tp2.Controls.Add(Me.Phone, 1, 2)
        Me.Tp2.Controls.Add(Me.Mobile, 1, 1)
        Me.Tp2.Controls.Add(Me.Label16, 0, 2)
        Me.Tp2.Controls.Add(Me.Label17, 0, 1)
        Me.Tp2.Controls.Add(Me.EMail, 1, 0)
        Me.Tp2.Controls.Add(Me.Address, 1, 3)
        Me.Tp2.Controls.Add(Me.Label13, 0, 3)
        Me.Tp2.Location = New System.Drawing.Point(6, 11)
        Me.Tp2.Name = "Tp2"
        Me.Tp2.RowCount = 6
        Me.Tp2.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.Tp2.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.Tp2.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.Tp2.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.Tp2.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.Tp2.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.Tp2.Size = New System.Drawing.Size(270, 222)
        Me.Tp2.TabIndex = 5
        '
        'State
        '
        Me.State.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.State.Location = New System.Drawing.Point(85, 199)
        Me.State.Name = "State"
        Me.State.ReadOnly = True
        Me.State.Size = New System.Drawing.Size(182, 20)
        Me.State.TabIndex = 10
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 202)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 13)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "City / State"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PIN
        '
        Me.PIN.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PIN.Location = New System.Drawing.Point(85, 173)
        Me.PIN.Name = "PIN"
        Me.PIN.ReadOnly = True
        Me.PIN.Size = New System.Drawing.Size(182, 20)
        Me.PIN.TabIndex = 9
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(3, 176)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 13)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Postal Code"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(3, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(76, 48)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "E Mail (s)"
        '
        'Phone
        '
        Me.Phone.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Phone.Location = New System.Drawing.Point(85, 77)
        Me.Phone.Name = "Phone"
        Me.Phone.ReadOnly = True
        Me.Phone.Size = New System.Drawing.Size(182, 20)
        Me.Phone.TabIndex = 8
        '
        'Mobile
        '
        Me.Mobile.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Mobile.Location = New System.Drawing.Point(85, 51)
        Me.Mobile.Name = "Mobile"
        Me.Mobile.ReadOnly = True
        Me.Mobile.Size = New System.Drawing.Size(182, 20)
        Me.Mobile.TabIndex = 9
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(3, 80)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(76, 13)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Phone"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(3, 54)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(76, 13)
        Me.Label17.TabIndex = 7
        Me.Label17.Text = "Mobile"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EMail
        '
        Me.EMail.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EMail.Location = New System.Drawing.Point(85, 3)
        Me.EMail.Multiline = True
        Me.EMail.Name = "EMail"
        Me.EMail.ReadOnly = True
        Me.EMail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.EMail.Size = New System.Drawing.Size(182, 42)
        Me.EMail.TabIndex = 0
        '
        'Address
        '
        Me.Address.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Address.Location = New System.Drawing.Point(85, 103)
        Me.Address.Multiline = True
        Me.Address.Name = "Address"
        Me.Address.ReadOnly = True
        Me.Address.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Address.Size = New System.Drawing.Size(182, 64)
        Me.Address.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 100)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 70)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Address"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Tp3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(282, 246)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Office"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Tp3
        '
        Me.Tp3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tp3.AutoSize = True
        Me.Tp3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Tp3.ColumnCount = 2
        Me.Tp3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.4717!))
        Me.Tp3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.52831!))
        Me.Tp3.Controls.Add(Me.Label26, 0, 3)
        Me.Tp3.Controls.Add(Me.CFone, 1, 3)
        Me.Tp3.Controls.Add(Me.Label22, 0, 0)
        Me.Tp3.Controls.Add(Me.CFax, 1, 4)
        Me.Tp3.Controls.Add(Me.Label21, 0, 4)
        Me.Tp3.Controls.Add(Me.CEmail, 1, 2)
        Me.Tp3.Controls.Add(Me.Company, 1, 1)
        Me.Tp3.Controls.Add(Me.Label23, 0, 2)
        Me.Tp3.Controls.Add(Me.Label24, 0, 1)
        Me.Tp3.Controls.Add(Me.Job, 1, 0)
        Me.Tp3.Controls.Add(Me.CAddress, 1, 5)
        Me.Tp3.Controls.Add(Me.Label25, 0, 5)
        Me.Tp3.Location = New System.Drawing.Point(9, 12)
        Me.Tp3.Name = "Tp3"
        Me.Tp3.RowCount = 6
        Me.Tp3.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.Tp3.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.Tp3.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.Tp3.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.Tp3.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.Tp3.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.Tp3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.Tp3.Size = New System.Drawing.Size(228, 190)
        Me.Tp3.TabIndex = 6
        '
        'Label26
        '
        Me.Label26.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(3, 84)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(74, 13)
        Me.Label26.TabIndex = 9
        Me.Label26.Text = "Phone"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CFone
        '
        Me.CFone.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CFone.Location = New System.Drawing.Point(83, 81)
        Me.CFone.Name = "CFone"
        Me.CFone.ReadOnly = True
        Me.CFone.Size = New System.Drawing.Size(142, 20)
        Me.CFone.TabIndex = 9
        '
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(3, 6)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(74, 13)
        Me.Label22.TabIndex = 8
        Me.Label22.Text = "Job Title"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CFax
        '
        Me.CFax.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CFax.Location = New System.Drawing.Point(83, 107)
        Me.CFax.Name = "CFax"
        Me.CFax.ReadOnly = True
        Me.CFax.Size = New System.Drawing.Size(142, 20)
        Me.CFax.TabIndex = 9
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(3, 110)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(74, 13)
        Me.Label21.TabIndex = 7
        Me.Label21.Text = "Fax"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CEmail
        '
        Me.CEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CEmail.Location = New System.Drawing.Point(83, 55)
        Me.CEmail.Name = "CEmail"
        Me.CEmail.ReadOnly = True
        Me.CEmail.Size = New System.Drawing.Size(142, 20)
        Me.CEmail.TabIndex = 8
        '
        'Company
        '
        Me.Company.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Company.Location = New System.Drawing.Point(83, 29)
        Me.Company.Name = "Company"
        Me.Company.ReadOnly = True
        Me.Company.Size = New System.Drawing.Size(142, 20)
        Me.Company.TabIndex = 9
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(3, 58)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(74, 13)
        Me.Label23.TabIndex = 6
        Me.Label23.Text = "E Mail"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(3, 26)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(74, 26)
        Me.Label24.TabIndex = 7
        Me.Label24.Text = "Company Name"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Job
        '
        Me.Job.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Job.Location = New System.Drawing.Point(83, 3)
        Me.Job.Name = "Job"
        Me.Job.ReadOnly = True
        Me.Job.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Job.Size = New System.Drawing.Size(142, 20)
        Me.Job.TabIndex = 0
        '
        'CAddress
        '
        Me.CAddress.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CAddress.Location = New System.Drawing.Point(83, 133)
        Me.CAddress.Multiline = True
        Me.CAddress.Name = "CAddress"
        Me.CAddress.ReadOnly = True
        Me.CAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.CAddress.Size = New System.Drawing.Size(142, 54)
        Me.CAddress.TabIndex = 5
        '
        'Label25
        '
        Me.Label25.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(3, 130)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(74, 60)
        Me.Label25.TabIndex = 5
        Me.Label25.Text = "Address"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Button6)
        Me.TabPage4.Controls.Add(Me.Button5)
        Me.TabPage4.Controls.Add(Me.Button4)
        Me.TabPage4.Controls.Add(Me.PhotoBox)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(282, 246)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Photo"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Enabled = False
        Me.Button6.Location = New System.Drawing.Point(147, 73)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(55, 23)
        Me.Button6.TabIndex = 3
        Me.Button6.Text = "Clear"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(146, 44)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(55, 23)
        Me.Button5.TabIndex = 2
        Me.Button5.Text = "Export"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Location = New System.Drawing.Point(147, 15)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(55, 23)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "Import"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'PhotoBox
        '
        Me.PhotoBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PhotoBox.Enabled = False
        Me.PhotoBox.ErrorImage = Global.eGuard__Contact_Manager.My.Resources.Resources.NO_PHOTO
        Me.PhotoBox.Location = New System.Drawing.Point(16, 15)
        Me.PhotoBox.Name = "PhotoBox"
        Me.PhotoBox.Size = New System.Drawing.Size(125, 150)
        Me.PhotoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PhotoBox.TabIndex = 0
        Me.PhotoBox.TabStop = False
        '
        'ContactViewer
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.eGuard__Contact_Manager.My.Resources.Resources.bk
        Me.CancelButton = Me.Button3
        Me.ClientSize = New System.Drawing.Size(309, 358)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ContactViewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ContactViewer"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.Tp1.ResumeLayout(False)
        Me.Tp1.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.Tp2.ResumeLayout(False)
        Me.Tp2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.Tp3.ResumeLayout(False)
        Me.Tp3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.PhotoBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents FirstRec As System.Windows.Forms.ToolStripButton
    Friend WithEvents PreviousRec As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Number As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents TSRecs As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NextRec As System.Windows.Forms.ToolStripButton
    Friend WithEvents LastRec As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddRec As System.Windows.Forms.ToolStripButton
    Friend WithEvents DelRec As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents Tp1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Nation As System.Windows.Forms.TextBox
    Friend WithEvents NName As System.Windows.Forms.TextBox
    Friend WithEvents LName As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents FName As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Sex As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents DOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents Notes As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents Tp2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents State As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents PIN As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Phone As System.Windows.Forms.TextBox
    Friend WithEvents Mobile As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents EMail As System.Windows.Forms.TextBox
    Friend WithEvents Address As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Tp3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents CFone As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents CFax As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents CEmail As System.Windows.Forms.TextBox
    Friend WithEvents Company As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Job As System.Windows.Forms.TextBox
    Friend WithEvents CAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents PhotoBox As System.Windows.Forms.PictureBox
    Friend WithEvents EditRec As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
End Class
