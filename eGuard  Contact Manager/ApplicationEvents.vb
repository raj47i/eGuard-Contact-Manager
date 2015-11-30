Namespace My

    ' The following events are availble for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        Private _DataPath As String
        Private _CODE As String = "#47#raj@eg&cmgr"

        Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
            _DataPath = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\My Contacts"
            If Not IO.File.Exists(_DataPath & "\Data.mdb") Then
                If Not IO.Directory.Exists(_DataPath) Then
                    IO.Directory.CreateDirectory(_DataPath)
                End If
                IO.File.Copy(Info.DirectoryPath & "\Data.src", _DataPath & "\Data.mdb", False)
                MsgBox("Your Password is [DEFAULT]", MsgBoxStyle.Information)
            End If
        End Sub

        Public ReadOnly Property zipPwd() As String
            Get
                Return _CODE
            End Get
        End Property

        Public Property DataDIR() As String
            Get
                Return _DataPath
            End Get
            Set(ByVal value As String)
                _DataPath = value
            End Set
        End Property


        Public ReadOnly Property DSN() As String
            Get
                Dim Str As New System.Text.StringBuilder("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=""")
                Str.Append(Me.DataDIR)
                Str.Append("\Data.mdb")
                Str.Append(""";Persist Security Info=True")
                If Not My.Forms.Main.txtPwd.Text = "" Then
                    Str.Append(";Jet OLEDB:Database Password=")
                    Str.Append(My.Forms.Main.txtPwd.Text)
                End If
                Return Str.ToString
            End Get
        End Property
    End Class
End Namespace

