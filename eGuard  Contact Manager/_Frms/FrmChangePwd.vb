Public Class FrmChangePwd

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtCur.Text = My.Forms.Main.txtPwd.Text Then
            If txtNew.Text = txtConfirm.Text Then
                Dim SQL As New System.Text.StringBuilder("ALTER DATABASE PASSWORD ")
                'Dim SQL As New System.Text.StringBuilder("ALTER USER Admin ")
                SQL.Append("'" & txtNew.Text & "' ")
                SQL.Append("'" & txtCur.Text & "'")
                Try
                    Dim c As New Data.OleDb.OleDbCommand(SQL.ToString, New Data.OleDb.OleDbConnection(My.Application.DSN & ";exclusive=1"))
                    If Not c.Connection.State = ConnectionState.Open Then
                        c.Connection.Open()
                    End If
                    c.ExecuteNonQuery()
                    c.Connection.Close()
                    c.Dispose()
                    MsgBox("Password updated Successfully", MsgBoxStyle.Information)
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                End Try
            Else
                MsgBox("New Passwords mismatch..", MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("Incorrect Password..", MsgBoxStyle.Critical)
        End If
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub FrmChangePwd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtConfirm.Text = ""
        txtCur.Text = ""
        txtNew.Text = ""
    End Sub
End Class