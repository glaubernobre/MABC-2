Public Class cadNewAdm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If descricaoTextBox.Text = "" Then
            MsgBox("Insert the name of new administer")
        Else
            AdministerTableAdapter1.Insert(descricaoTextBox.Text)
            AdministerTableAdapter1.Update(Banco_de_dadosDataSet1.Administer)
            MsgBox("The administer was registered")
            Close()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub cadNewAdm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        descricaoTextBox.Clear()
    End Sub
End Class