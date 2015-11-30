Public Class TypeEditor
    Public Key As String
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If Not TextBox1.Text = "" AndAlso Not TextBox1.Text = "[Enter New Type]" Then
                Dim c As New Data.OleDb.OleDbCommand("INSERT INTO Types VALUES('" & TextBox1.Text & "')", New Data.OleDb.OleDbConnection(My.Application.DSN))
                If Not c.Connection.State = ConnectionState.Open Then
                    c.Connection.Open()
                End If
                Try
                    c.ExecuteNonQuery()
                Catch ex1 As Exception
                    MsgBox("Already there is a Contact Type in this Name.")
                End Try
                c.Connection.Close()
                Me.Dispose()
            End If
        Catch ex As Exception
            MsgBox("Could not Access the database .." & vbCrLf & "Or it is not a valid [Contacts] database..!", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub TextBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.Click
        If TextBox1.Text = "[Enter New Type]" Then
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub TypeEditor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class