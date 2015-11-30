Public Class Main

#Region "ADD_VIEW_DEL TYPES"

    Private Sub Delete_Types(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_TYPDel.Click
        If MsgBox("Are you sure to Delete [" & CLCategory.Text & "] ?" & vbCrLf & "All Contacts in [" & CLCategory.Text & "] will be lost...", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                Dim c As New Data.OleDb.OleDbCommand("DELETE FROM Types WHERE Type ='" & CLCategory.Text & "'", New Data.OleDb.OleDbConnection(My.Application.DSN))
                If Not c.Connection.State = ConnectionState.Open Then
                    c.Connection.Open()
                End If
                c.ExecuteNonQuery()
                c.Connection.Close()
            Catch ex As Exception
                MsgBox("Cannot Access Database...")
            End Try
            If IO.Directory.Exists(My.Application.DataDIR & "\" & CLCategory.Text) Then
                Try
                    IO.Directory.Delete(My.Application.DataDIR & "\" & CLCategory.Text, True)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            ReLoad()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_TYPAdd.Click
        My.Forms.TypeEditor.TextBox1.Text = "[Enter New Type]"
        My.Forms.TypeEditor.ShowDialog()
        ReLoad()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_TYPView.Click
        My.Forms.ContactViewer.Text = "  Contacts @ " & CLCategory.Text
        My.Forms.ContactViewer.ShowDialog()
    End Sub

#End Region

#Region "Set Position of Form"

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = New Point(25, Me.Location.Y)
    End Sub

#End Region

#Region "Reload Data"


    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLOAD.Click
        ReLoad()
    End Sub
    Private Sub ReLoad()
        Try
            Dim c As New Data.OleDb.OleDbCommand("SELECT * FROM Types ORDER BY Type ", New Data.OleDb.OleDbConnection(My.Application.DSN))
            If Not c.Connection.State = ConnectionState.Open Then
                c.Connection.Open()
            End If
            Dim r As Data.OleDb.OleDbDataReader = c.ExecuteReader
            CLCategory.Items.Clear()
            While r.Read
                CLCategory.Items.Add(r.Item("Type"))
            End While
            c.Connection.Close()
            c.Dispose()
            If CLCategory.Items.Count = 0 Then
                'Disable all Options...
                Backup.Enabled = False
                B_TYPDel.Enabled = False
                B_TYPView.Enabled = False
                CLCategory.Enabled = False
            Else
                CLCategory.SelectedIndex = 0
                Backup.Enabled = True
                B_TYPDel.Enabled = True
                B_TYPView.Enabled = True
                CLCategory.Enabled = True
            End If
            GroupBox1.Enabled = True
            'BtnPWD.Enabled = True
            Restore.Enabled = True
            txtPwd.Enabled = False
            BtnLOAD.Enabled = False
        Catch ex As Exception
            GroupBox1.Enabled = False
            BtnPWD.Enabled = False
            CLCategory.Items.Clear()
            If ex.Message = "Not a valid password." Then
                MsgBox("Incorrect Password..", MsgBoxStyle.Critical)
            Else
                MsgBox("Could not Access the database .." & vbCrLf & "Or it is not a valid [Contacts] database..!", MsgBoxStyle.Critical)
            End If
        End Try
    End Sub

#End Region

#Region "HELP-ABOUT-EXIT"

    Private Sub Button9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEXIT.Click
        Me.Close()
    End Sub
    Private Sub BtnHELP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHELP.Click
        Help.ShowHelp(sender, My.Application.Info.DirectoryPath & "/Manual.CHM", HelpNavigator.TableOfContents)
    End Sub

    Private Sub BtnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAbout.Click
        My.Forms.AboutBox1.ShowDialog()
    End Sub
#End Region

#Region "BACKUP / RESTORE"
    Private Sub BackupZIP(ByVal DIR As String, ByVal zipFile As String, Optional ByVal Password As String = Nothing)
        Dim zF As New ICSharpCode.SharpZipLib.Zip.ZipOutputStream(IO.File.OpenWrite(zipFile))
        zF.Password = Password
        Dim cFile As String
        For Each cFile In IO.Directory.GetFiles(DIR, "*", IO.SearchOption.AllDirectories)
            AddthisFile(zF, cFile, cFile.Remove(0, My.Application.DataDIR.Length))
        Next
        zF.Finish()
        zF.Close()
    End Sub

    Private Sub AddthisFile(ByVal xF As ICSharpCode.SharpZipLib.Zip.ZipOutputStream, ByVal File As String, ByVal EntryName As String)
        Dim Buf(512) As Byte
        Dim cF As IO.FileStream = New IO.FileStream(File, IO.FileMode.Open, IO.FileAccess.Read)
        Dim cE As New ICSharpCode.SharpZipLib.Zip.ZipEntry(EntryName)
        cE.DateTime = Date.Now
        xF.PutNextEntry(cE)
        Dim nSize As Integer = cF.Read(Buf, 0, 512)
        While nSize > 0
            xF.Write(Buf, 0, nSize)
            nSize = cF.Read(Buf, 0, 512)
        End While
        cF.Close()
        cF.Dispose()
    End Sub

    Private Sub RestoreZIP(ByVal DIR As String, ByVal zipFile As String, Optional ByVal Password As String = Nothing)
        Dim zF As New ICSharpCode.SharpZipLib.Zip.ZipInputStream(IO.File.OpenRead(zipFile))
        zF.Password = Password
        Dim cE As ICSharpCode.SharpZipLib.Zip.ZipEntry = zF.GetNextEntry
        While Not cE Is Nothing
            ExtactFile(DIR, zF, cE)
            cE = zF.GetNextEntry
        End While
        zF.Close()
        zF.Dispose()
    End Sub

    Private Sub ExtactFile(ByVal DIR As String, ByVal xF As ICSharpCode.SharpZipLib.Zip.ZipInputStream, _
                                                                  ByVal cE As ICSharpCode.SharpZipLib.Zip.ZipEntry)
        Dim FileName As String = DIR & cE.Name
        Dim fn As String = Nothing
        For Each fn In cE.Name.Split("\".ToCharArray, System.StringSplitOptions.RemoveEmptyEntries)
            DIR = DIR & "\" & fn
            If Not IO.Directory.Exists(DIR) And Not DIR.EndsWith(".mdb") And Not DIR.EndsWith(".cpb") Then
                IO.Directory.CreateDirectory(DIR)
            End If
        Next
        '
        Dim buf(512) As Byte
        Dim cF As IO.FileStream = New IO.FileStream(FileName, IO.FileMode.Create, IO.FileAccess.Write)
        Dim nSize As Integer = xF.Read(buf, 0, 512)
        While nSize > 0
            cF.Write(buf, 0, nSize)
            nSize = xF.Read(buf, 0, 512)
        End While
        cF.Close()
        cF.Dispose()
    End Sub
#End Region

    Private Sub BtnPWD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPWD.Click
        My.Forms.FrmChangePwd.ShowDialog()
    End Sub

    Private Sub Restore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Restore.Click
        If MsgBox("Are you sure that you want to Restore Data ?" & vbCrLf & "All Current Data will be lost", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim oz As New OpenFileDialog
            oz.Title = "Select Backup File.."
            oz.AddExtension = True
            oz.DefaultExt = ".ecf"
            oz.Filter = "eGuard Contact Files(*.ecf)|*.ecf"
            oz.CheckFileExists = True
            oz.Multiselect = False
            oz.ShowDialog()
            If IO.File.Exists(oz.FileName) Then
                '
                Dim ci As String
                For Each ci In IO.Directory.GetFiles(My.Application.DataDIR)
                    IO.File.Delete(ci)
                Next
                For Each ci In IO.Directory.GetDirectories(My.Application.DataDIR)
                    IO.Directory.Delete(ci, True)
                Next
                '
                RestoreZIP(My.Application.DataDIR, oz.FileName, My.Application.zipPwd)
                MsgBox("Restore Successfull..." & vbCrLf & My.Application.Info.Title & " will exit now..", MsgBoxStyle.Information)
                Application.Exit()
            End If
        End If
    End Sub

    Private Sub Backup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Backup.Click
        Dim sf As New SaveFileDialog
        sf.Title = "Export Data as.."
        sf.AddExtension = True
        sf.CheckFileExists = False
        sf.CheckPathExists = True
        sf.CreatePrompt = False
        sf.DefaultExt = ".ecf"
        sf.Filter = "eGuard Contact Files(*.ecf)|*.ecf"
        sf.OverwritePrompt = True
        sf.SupportMultiDottedExtensions = False
        sf.ValidateNames = True
        sf.ShowDialog()
        If Not sf.FileName = "" Then
            BackupZIP(My.Application.DataDIR, sf.FileName, My.Application.zipPwd)
        End If
    End Sub
End Class
