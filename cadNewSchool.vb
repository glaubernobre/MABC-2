Public Class cadnewschool
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If descricaoTextBox.Text = "" Then
            MsgBox("Insert the name of school")
        Else
            SchoolTableAdapter1.Insert(descricaoTextBox.Text)
            SchoolTableAdapter1.Update(Banco_de_dadosDataSet1.School)
            MsgBox("The school was registered")
            Close()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub cadnewschool_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class