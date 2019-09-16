Public Class Formulario_inicial
    Private Sub Formulario_inicial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Checklist_MABC2_Click(sender As Object, e As EventArgs) Handles Checklist_MABC2.Click

        SearchChecklist.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SearchForm.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        cadChild.Show()
    End Sub

    Private Sub CadChildToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadChildToolStripMenuItem.Click
        cadChild.Show()
    End Sub

    Private Sub AgeBandToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgeBandToolStripMenuItem.Click
        SearchForm.Show()
    End Sub
End Class