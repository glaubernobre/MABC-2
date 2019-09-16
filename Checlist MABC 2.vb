Public Class Checklist_MABC2
    Dim Dateborn As Date
    Dim Dateassessment As Date
    Dim Datet As TimeSpan
    Dim Diff As Double

    Public Property date_assesment As Date

    Public Property child_id As Integer

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs)
        Dateborn = Me.DateTimePicker2.Value.ToShortDateString
        Dateassessment = Me.DateTimePicker1.Value.ToShortDateString
        Datet = (Dateassessment - Dateborn)
        Diff = Datet.Days
        Me.ageyearsmonthdyas.Text = (Str(Int(Diff / 365)) + " years,")
        Diff = Diff Mod 365
        Me.ageyearsmonthdyas.Text = Me.ageyearsmonthdyas.Text + (Str(Int(Diff / 30)) + " month(s)")
        Diff = Diff Mod 30
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub Checklist_MABC2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ChildTableAdapter.Fill(Banco_de_dadosDataSet.Child)

        ChildBindingSource.Filter = "ch_codigo = " & child_id 'filtra dos dados

        ChildBindingSource.ResetBindings(True) ' atualiza os dados nos campos

        GeneroTableAdapter.Fill(Banco_de_dadosDataSet.genero)

        SchoolTableAdapter.Fill(Banco_de_dadosDataSet.School)

        Prefered_handTableAdapter.Fill(Banco_de_dadosDataSet.prefered_hand)

        AdministerTableAdapter.Fill(Banco_de_dadosDataSet.Administer)

        'TODO: 'Este comando abaixo não está funcionando. Acusa erro no "value" da datetimepicker1

        'DateTimePicker1.Value = date_assesment

        CbxAprendSalaAula.Enabled = False
        CbxAtivRecre.Enabled = False
        CbxAutoestima.Enabled = False


    End Sub

    Private Sub RadioButton62_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton62.CheckedChanged

        CbxAprendSalaAula.Enabled = True
        CbxAtivRecre.Enabled = True
        CbxAutoestima.Enabled = True

    End Sub

    Private Sub RadioButton61_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton61.CheckedChanged

        CbxAprendSalaAula.Enabled = False
        CbxAprendSalaAula.SelectedValue = ""
        CbxAtivRecre.Enabled = False
        CbxAtivRecre.SelectedValue = ""
        CbxAutoestima.Enabled = False
        CbxAutoestima.SelectedValue = ""

    End Sub

    Private Sub AdministerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AdministerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Banco_de_dadosDataSet)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        cadnewschool.ShowDialog()
        'Comando abaixo completa os dados no Combobox
        SchoolTableAdapter.Fill(Banco_de_dadosDataSet.School)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        cadNewAdm.ShowDialog()
        AdministerTableAdapter.Fill(Banco_de_dadosDataSet.Administer)
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

        Dateborn = DateTimePicker2.Value.ToShortDateString
        Dateassessment = DateTimePicker1.Value.ToShortDateString
        Datet = (Dateassessment - Dateborn)
        Diff = Datet.Days
        Label3.Text = (Str(Int(Diff / 365)) + " years,")
        Diff = Diff Mod 365
        Label3.Text = Label3.Text + (Str(Int(Diff / 30)) + " month(s)")
        Diff = Diff Mod 30

    End Sub

    Private Sub Calculatebutton_Click(sender As Object, e As EventArgs) Handles Calculatebutton.Click

        Dim totalSecA As Integer
        Dim totalSecB As Integer
        Dim somaAB As Integer

        totalSecA = (CbxA11.SelectedValue + CbxA12 + CbxA13 + CbxA14 + CbxA15 + CbxA21 + CbxA22 + CbxA23 + CbxA24 + CbxA25 + CbxA31 + CbxA32 + CbxA33 + CbxA34 + CbxA35)

        TotSecA.Text = secA.Value

        totalSecB = (CbxB11.SelectedValue + CbxB12 + CbxB13 + CbxB14 + CbxB15 + CbxB21 + CbxB22 + CbxB23 + CbxB24 + CbxB25 + CbxB31 + CbxB32 + CbxB33 + CbxB34 + CbxB35)

        TotSecB.Text = secB.Value

        somaAB = secA.Value + secB.Value



        Dim scorebruto As Integer
        Dim idadecalculada As Double
        Dim valor As Integer

        valor = totalSomaAB.Value

        Dateborn = DateTimePicker2.Value.ToShortDateString
        Dateassessment = DateTimePicker1.Value.ToShortDateString
        Datet = (Dateassessment - Dateborn)
        Diff = Datet.Days
        idadecalculada = Diff / 365

        Select Case idadecalculada
            Case 5 To 5.99
                Select Case valor
                    Case <= 33
                        scorebruto = "Green Zone"
                    Case 34 To 31
                        scorebruto = "Amber Zone"
                    Case >= 42
                        scorebruto = "Red Zone"
                End Select

            Case 6 To 6.99
                Select Case valor
                    Case <= 19
                        scorebruto = "Green Zone"
                    Case 24 To 20
                        scorebruto = "Amber Zone"
                    Case >= 25
                        scorebruto = "Red Zone"
                End Select

            Case 7 To 7.99
                Select Case valor
                    Case <= 11
                        scorebruto = "Green Zone"
                    Case 12 To 16
                        scorebruto = "Amber Zone"
                    Case >= 17
                        scorebruto = "Red Zone"
                End Select
            Case 8 To 8.99
                Select Case valor
                    Case <= 8
                        scorebruto = "Green Zone"
                    Case 9 To 12
                        scorebruto = "Amber Zone"
                    Case >= 13
                        scorebruto = "Red Zone"
                End Select
            Case 9 To 9.99
                Select Case valor
                    Case <= 5
                        scorebruto = "Green Zone"
                    Case 6 To 9
                        scorebruto = "Amber Zone"
                    Case >= 10
                        scorebruto = "Red Zone"
                End Select

            Case 10 To 10.99
                Select Case valor
                    Case <= 3
                        scorebruto = "Green Zone"
                    Case 4 To 6
                        scorebruto = "Amber Zone"
                    Case >= 7
                        scorebruto = "Red Zone"
                End Select

            Case 11 To 11.99
                Select Case valor
                    Case 0
                        scorebruto = "Green Zone"
                    Case 1 To 2
                        scorebruto = "Amber Zone"
                    Case >= 3
                        scorebruto = "Red Zone"
                End Select

            Case 12 To 12.99
                Select Case valor
                    Case 0
                        scorebruto = "Green Zone"
                    Case 1
                        scorebruto = "Amber Zone"
                    Case >= 2
                        scorebruto = "Red Zone"
                End Select

        End Select

        Label18.Text = scorebruto



    End Sub

    Private Sub Namechild_TextChanged(sender As Object, e As EventArgs) Handles Namechild.TextChanged

    End Sub

    Private Sub DateTimePicker2_ValueChanged_1(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged

    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged

    End Sub
End Class