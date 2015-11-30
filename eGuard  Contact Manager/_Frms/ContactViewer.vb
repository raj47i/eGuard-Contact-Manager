Public Class ContactViewer
    Private _Type As String = Nothing
    Private WithEvents _Table As New Data.DataTable("Contacts")
    Private _ModeADD As Boolean = False
    Private _curRecord As Integer = 0
    Private _ID As Integer = 0
    Private _PhotoSET As Boolean = False


#Region "Photo ..."

    Private Function DecodedPhoto(ByVal ID As Integer) As Image
        If IO.File.Exists(My.Application.DataDIR & "\" & _Type & "\P" & ID & ".cpb") Then
            Dim zF As New ICSharpCode.SharpZipLib.Zip.ZipInputStream(IO.File.OpenRead(My.Application.DataDIR & "\" & _Type & "\P" & ID & ".cpb"))
            zF.Password = My.Application.zipPwd
            Dim cS As New IO.MemoryStream()
            Dim zEntry As ICSharpCode.SharpZipLib.Zip.ZipEntry = zF.GetNextEntry
            Dim Buffer(512) As Byte
            If zEntry.Name = "DATA" Then
                Dim nZ As Integer = zF.Read(Buffer, 0, 512)
                While nZ > 0
                    cS.Write(Buffer, 0, nZ)
                    nZ = zF.Read(Buffer, 0, 512)
                End While
            End If
            zF.Close()
            Dim tmp As Image = Image.FromStream(cS)
            cS.Close()
            cS.Dispose()
            Return tmp
        End If
        Return My.Resources.NO_PHOTO
    End Function

    Private Sub setNewPhoto(ByVal Name As String)
        If Not IO.Directory.Exists(My.Application.DataDIR & "\" & _Type) Then
            IO.Directory.CreateDirectory(My.Application.DataDIR & "\" & _Type)
        End If
        Dim zF As ICSharpCode.SharpZipLib.Zip.ZipOutputStream
        If IO.File.Exists(Name & ".cpb") Then
            zF = New ICSharpCode.SharpZipLib.Zip.ZipOutputStream(IO.File.OpenWrite(My.Application.DataDIR & "\" & _Type & "\" & Name & ".cpb"))
        Else
            zF = New ICSharpCode.SharpZipLib.Zip.ZipOutputStream(IO.File.Create(My.Application.DataDIR & "\" & _Type & "\" & Name & ".cpb"))
        End If
        zF.Password = My.Application.zipPwd
        zF.SetLevel(6)
        Dim tmpName As String = IO.Path.GetTempFileName
        PhotoBox.Image.Save(tmpName)
        Dim cF As New IO.FileStream(tmpName, IO.FileMode.Open, IO.FileAccess.Read)
        Dim Buffer(cF.Length - 1) As Byte
        cF.Read(Buffer, 0, Buffer.Length)
        cF.Close()
        cF.Dispose()
        IO.File.Delete(tmpName)
        Dim cE As New ICSharpCode.SharpZipLib.Zip.ZipEntry("DATA")
        cE.DateTime = Date.Now
        cE.Size = Buffer.Length
        Dim crc32 As New ICSharpCode.SharpZipLib.Checksums.Crc32
        crc32.Reset()
        crc32.Update(Buffer)
        cE.Crc = crc32.Value
        zF.PutNextEntry(cE)
        zF.Write(Buffer, 0, Buffer.Length)
        zF.Finish()
        zF.Close()
    End Sub

#End Region




#Region "Display Record"

    Private Sub Display_Record(ByVal ID As Integer)
        If ID >= 0 AndAlso ID < _Table.Rows.Count Then
            _curRecord = ID
            _ID = _Table.Rows(ID).Item("ID")
            Number.Text = ID + 1
            'Load Personal Info...
            FName.Text = _Table.Rows(ID).Item("FName").ToString
            LName.Text = _Table.Rows(ID).Item("LName").ToString
            NName.Text = _Table.Rows(ID).Item("NName").ToString
            Sex.Checked = _Table.Rows(ID).Item("Sex")
            RadioButton4.Checked = Not Sex.Checked
            DOB.Value = Date.Parse(_Table.Rows(ID).Item("DOB"))
            Nation.Text = _Table.Rows(ID).Item("Nation").ToString
            Notes.Text = _Table.Rows(ID).Item("Notes").ToString
            'Load Contact Information...
            EMail.Text = _Table.Rows(ID).Item("EMail").ToString
            Mobile.Text = _Table.Rows(ID).Item("Mobile").ToString
            Phone.Text = _Table.Rows(ID).Item("Phone").ToString
            Address.Text = _Table.Rows(ID).Item("Address").ToString
            PIN.Text = _Table.Rows(ID).Item("PIN").ToString
            State.Text = _Table.Rows(ID).Item("State").ToString
            'Load Office Information...
            Job.Text = _Table.Rows(ID).Item("Job").ToString
            Company.Text = _Table.Rows(ID).Item("Company").ToString
            CEmail.Text = _Table.Rows(ID).Item("CEmail").ToString
            CFone.Text = _Table.Rows(ID).Item("CFone").ToString
            CFax.Text = _Table.Rows(ID).Item("CFax").ToString
            CAddress.Text = _Table.Rows(ID).Item("CAddress").ToString
            'Load Photograph...
            PhotoBox.Image = DecodedPhoto(_ID)
        End If

        'Setup Buttons For Each Cases...
        If _curRecord = 0 Then
            FirstRec.Enabled = False
            PreviousRec.Enabled = False
        Else
            FirstRec.Enabled = True
            PreviousRec.Enabled = True
        End If
        If _curRecord = _Table.Rows.Count - 1 Then
            NextRec.Enabled = False
            LastRec.Enabled = False
        Else
            NextRec.Enabled = True
            LastRec.Enabled = True
        End If
        If _Table.Rows.Count <= 1 Then
            Number.Text = _Table.Rows.Count
            FirstRec.Enabled = False
            PreviousRec.Enabled = False
            NextRec.Enabled = False
            LastRec.Enabled = False
        End If
    End Sub

#End Region

#Region "Save Changes to the Record..."

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If _ModeADD Then
            Add_New_Record()
        Else
            Update_Record(_ID)
        End If
    End Sub

#End Region

#Region "Add New Record.."

    Private Function getID(Optional ByVal i As Integer = 1) As Integer
        Dim r As Data.DataRow
        For Each r In _Table.Rows
            If Val(r.Item("ID")) = i Then
                Return getID(i + 1)
            End If
        Next
        Return i
    End Function

    Private Sub Add_New_Record()
        If Not (FName.Text = "" And LName.Text = "") Then
            Dim ID As Integer = getID()
            Try
                Dim sql As New System.Text.StringBuilder("INSERT INTO Contacts VALUES(" & ID & ",")
                Dim cd As New Data.OleDb.OleDbCommand("", New Data.OleDb.OleDbConnection(My.Application.DSN))
                sql.Append("'" & _Type & "',")
                sql.Append("'" & FName.Text & "',")
                sql.Append("'" & LName.Text & "',")
                sql.Append("'" & NName.Text & "',")
                sql.Append(Sex.Checked & ",")
                sql.Append("'" & DOB.Value.ToString("MMMM  dd, yyyy") & "',")
                sql.Append("'" & Nation.Text & "',")
                sql.Append("'" & Notes.Text & "',")
                sql.Append("'" & EMail.Text & "',")
                sql.Append("'" & Mobile.Text & "',")
                sql.Append("'" & Phone.Text & "',")
                sql.Append("'" & Address.Text & "',")
                sql.Append("'" & PIN.Text & "',")
                sql.Append("'" & State.Text & "',")
                sql.Append("'" & Job.Text & "',")
                sql.Append("'" & Company.Text & "',")
                sql.Append("'" & CEmail.Text & "',")
                sql.Append("'" & CFone.Text & "',")
                sql.Append("'" & CFax.Text & "',")
                sql.Append("'" & CAddress.Text & "')")
                cd.CommandText = sql.ToString
                If Not cd.Connection.State = ConnectionState.Open Then
                    cd.Connection.Open()
                End If
                cd.ExecuteNonQuery()
                cd.Connection.Close()
                If _PhotoSET Then
                    setNewPhoto("P" & ID)
                End If
                lockAll(True)
                ReLoad_Records()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else
            MsgBox("Name cannot be empty..", MsgBoxStyle.Critical)
        End If
    End Sub
#End Region

#Region "Upadte A Record..."

    Private Sub Update_Record(ByVal id As Integer)
        Try
            Dim sql As New System.Text.StringBuilder("UPDATE Contacts SET ")
            Dim cd As New Data.OleDb.OleDbCommand("", New Data.OleDb.OleDbConnection(My.Application.DSN))
            sql.Append("FName='" & FName.Text & "', ")
            sql.Append("LName='" & LName.Text & "', ")
            sql.Append("NName='" & NName.Text & "', ")
            sql.Append("Sex=" & Sex.Checked & ", ")
            sql.Append("DOB='" & DOB.Value.ToString("MMMM  dd, yyyy") & "', ")
            sql.Append("Nation='" & Nation.Text & "', ")
            sql.Append("Notes='" & Notes.Text & "', ")
            sql.Append("EMail='" & EMail.Text & "', ")
            sql.Append("Mobile='" & Mobile.Text & "', ")
            sql.Append("Phone='" & Phone.Text & "', ")
            sql.Append("Address='" & Address.Text & "', ")
            sql.Append("PIN='" & PIN.Text & "', ")
            sql.Append("State='" & State.Text & "', ")
            sql.Append("Job='" & Job.Text & "', ")
            sql.Append("Company='" & Company.Text & "', ")
            sql.Append("CEmail='" & CEmail.Text & "', ")
            sql.Append("CFone='" & CFone.Text & "', ")
            sql.Append("CFax='" & CFax.Text & "', ")
            sql.Append("CAddress='" & CAddress.Text & "'")
            sql.Append(" WHERE Type='" & _Type & "' ")
            sql.Append("AND ID=" & id)
            cd.CommandText = sql.ToString
            If Not cd.Connection.State = ConnectionState.Open Then
                cd.Connection.Open()
            End If
            cd.ExecuteNonQuery()
            cd.Connection.Close()
            If _PhotoSET Then
                setNewPhoto("P" & id)
            Else
                'Delete if Exists
            End If
            lockAll(True)
            ReLoad_Records()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

#End Region

#Region "Load Records From Database..."

    Private Sub ReLoad_Records()
        Try
            _Table.Clear()
            Dim da As New Data.OleDb.OleDbDataAdapter("SELECT * FROM Contacts WHERE Type='" & _Type & "' ORDER BY FName, LName ASC", New OleDb.OleDbConnection(My.Application.DSN))
            da.Fill(_Table)
            da.Dispose()
            TSRecs.Text = "of {" & _Table.Rows.Count & "}"
            If _Table.Rows.Count = 0 Then
                Number.Text = 0
                FirstRec.Enabled = False
                PreviousRec.Enabled = False
                NextRec.Enabled = False
                LastRec.Enabled = False
                DelRec.Enabled = False
            Else
                Display_Record(0)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region

#Region "Move to Record..."

    Private Sub FirstRec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FirstRec.Click
        Display_Record(0)
    End Sub

    Private Sub LastRec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LastRec.Click
        Display_Record(_Table.Rows.Count - 1)
    End Sub

    Private Sub PreviousRec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreviousRec.Click
        Display_Record(_curRecord - 1)
    End Sub

    Private Sub NextRec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextRec.Click
        Display_Record(_curRecord + 1)
    End Sub

    Private Sub Number_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number.Leave
        Dim i As Integer = Val(Number.Text) - 1
        If i > 0 AndAlso i < _Table.Rows.Count Then
            Display_Record(i)
        Else
            Display_Record(0)
        End If
    End Sub

#End Region

#Region "Delete and goto 1st Record..."

    Private Sub DelRec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelRec.Click
        If MsgBox("Are you Sure ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim c As New Data.OleDb.OleDbCommand("DELETE FROM Contacts WHERE Type='" & _Type & "' AND ID=" & _Table.Rows(_curRecord).Item("ID"), New Data.OleDb.OleDbConnection(My.Application.DSN))
            If Not c.Connection.State = ConnectionState.Open Then
                c.Connection.Open()
            End If
            c.ExecuteNonQuery()
            c.Connection.Close()
            c.Dispose()
            ReLoad_Records()
        End If
    End Sub

#End Region

#Region "Change View / Edit and ADD Modes"

    Private Sub lockAll(ByVal b As Boolean)
        FName.ReadOnly = b
        LName.ReadOnly = b
        NName.ReadOnly = b
        Nation.ReadOnly = b
        Notes.ReadOnly = b
        'Load Contact Information...
        EMail.ReadOnly = b
        Mobile.ReadOnly = b
        Phone.ReadOnly = b
        Address.ReadOnly = b
        PIN.ReadOnly = b
        State.ReadOnly = b
        'Load Office Information...
        Job.ReadOnly = b
        Company.ReadOnly = b
        CEmail.ReadOnly = b
        CFone.ReadOnly = b
        CFax.ReadOnly = b
        CAddress.ReadOnly = b
        'Load Photograph...
        DOB.Enabled = Not b
        PhotoBox.Enabled = Not b
        Button1.Enabled = Not b
        Button2.Enabled = Not b
        Button4.Enabled = Not b
        Button6.Enabled = Not b
        ToolStrip1.Enabled = b
        _PhotoSET = False
    End Sub

    Private Sub ClearAll()
        FName.Text = ""
        LName.Text = ""
        NName.Text = ""
        Nation.Text = ""
        Notes.Text = ""
        'Load Contact Information...
        EMail.Text = ""
        Mobile.Text = ""
        Phone.Text = ""
        Address.Text = ""
        PIN.Text = ""
        State.Text = ""
        'Load Office Information...
        Job.Text = ""
        Company.Text = ""
        CEmail.Text = ""
        CFone.Text = ""
        CFax.Text = ""
        CAddress.Text = ""
        'Load Photograph...
        DOB.Text = ""
        PhotoBox.Image = My.Resources.NO_PHOTO
        _PhotoSET = False
    End Sub

#End Region

    Private Sub ContactViewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _Type = My.Forms.Main.CLCategory.Text
        ReLoad_Records()
    End Sub

    Private Sub AddRec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddRec.Click
        _ModeADD = True
        ClearAll()
        lockAll(False)
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        lockAll(True)
        If _Table.Rows.Count > 0 Then
            Display_Record(0)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Dispose()
    End Sub

    Private Sub EditRec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditRec.Click
        _ModeADD = False
        lockAll(False)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim oFile As New OpenFileDialog
        oFile.CheckFileExists = True
        oFile.CheckPathExists = True
        oFile.Filter = "BMP Images(*.bmp)|*.bmp|JPG Images(*.jpg)|*.jpg|GIF Images(*.gif)|.gif"
        oFile.Multiselect = False
        oFile.Title = "Select Photograph..."
        oFile.ShowDialog()
        If Not oFile.FileName = "" Then
            Dim newBMP As New Bitmap(125, 150)
            Dim tmpGRAPHIC As Graphics = Graphics.FromImage(newBMP)
            tmpGRAPHIC.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBilinear
            tmpGRAPHIC.DrawImage(Image.FromFile(oFile.FileName), 0, 0, 125, 150)
            PhotoBox.Image = newBMP
            _PhotoSET = True
        Else
            PhotoBox.Image = My.Resources.NO_PHOTO
            _PhotoSET = False
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        PhotoBox.Image = My.Resources.NO_PHOTO
        _PhotoSET = False
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim sF As New SaveFileDialog
        sF.AddExtension = True
        sF.CheckFileExists = False
        sF.CheckPathExists = True
        sF.CreatePrompt = False
        sF.OverwritePrompt = True
        sF.Filter = "Bitmap Image(*.bmp)|*.bmp"
        sF.Title = "Save Photograph as..."
        sF.ShowDialog()
        If Not sF.FileName = "" Then
            PhotoBox.Image.Save(sF.FileName)
        End If
    End Sub
End Class
