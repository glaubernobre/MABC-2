Imports Microsoft.Office.Interop

Public Class Formulario_Banda_3
    Dim Dateborn As Date
    Dim Dateassessment As Date
    Dim Datet As TimeSpan
    Dim Diff As Double

    Public Property date_assesment As Date

    Public Property child_id As Integer
    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TurningPegspreferredhandNumericUpDown.Value = -1
            TurningPegspreferredhandNumericUpDown.Enabled = False
        Else
            TurningPegspreferredhandNumericUpDown.Enabled = True
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            TurningPegsnonpreferredhandNumericUpDown.Value = -1
            TurningPegsnonpreferredhandNumericUpDown.Enabled = False
        Else
            TurningPegsnonpreferredhandNumericUpDown.Enabled = True
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            TrianglewithNutsandboltsNumericUpDown.Value = -1
            TrianglewithNutsandboltsNumericUpDown.Enabled = False
        Else
            TrianglewithNutsandboltsNumericUpDown.Enabled = True
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            Drawl3NumericUpDown.Value = -1
            Drawl3NumericUpDown.Enabled = False
        Else
            Drawl3NumericUpDown.Enabled = True
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            WalkingheelsbackNumericUpDown.Value = 15
            WalkingheelsbackNumericUpDown.Enabled = False
        Else
            WalkingheelsbackNumericUpDown.Enabled = True
        End If
    End Sub


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        Me.Close()
    End Sub
    Private Sub Formulario_Banda_3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GeneroTableAdapter.Fill(Banco_de_dadosDataSet.genero)
        Prefered_handTableAdapter.Fill(Banco_de_dadosDataSet.prefered_hand)


        GeneroBindingSource.ResetBindings(True)
        PreferedhandBindingSource.ResetBindings(True)


        ChildTableAdapter.Fill(Banco_de_dadosDataSet.Child)

        ChildBindingSource.Filter = "ch_codigo = " & child_id 'filtra dos dados

        ChildBindingSource.ResetBindings(True) ' atualiza os dados nos campos

        SchoolTableAdapter.Fill(Banco_de_dadosDataSet.School)



        AdministerTableAdapter.Fill(Banco_de_dadosDataSet.Administer)

        'TODO: 'Este comando abaixo não está funcionando. Acusa erro no "value" da datetimepicker1

        DateTimePicker1.Value = date_assesment

        BtnSaveEdit.Visible = False

        printpageBtm.Visible = False

        backCalculateBtm.Visible = False

        btnSave.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNewSchool.Click
        cadnewschool.ShowDialog()
        'Comando abaixo completa os dados no Combobox
        SchoolTableAdapter.Fill(Banco_de_dadosDataSet.School)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnNewAdm.Click
        cadNewAdm.ShowDialog()
        ' Comando abaixo completa os dados no Combobox - Salva os dados no banco
        AdministerTableAdapter.Fill(Banco_de_dadosDataSet.Administer)
    End Sub

    Private Sub HabilitaCalculo()
        'Esse método HabilitaCalculo() deve ser chamado em todos os campos preenchiveis

        'Adicionar todos os campos no mesmo IF com AND

        If (TurningPegspreferredhandNumericUpDown.Value <> -1 Or CheckBox1.Checked) And (TurningPegsnonpreferredhandNumericUpDown.Value <> -1 Or CheckBox2.Checked) And (TrianglewithNutsandboltsNumericUpDown.Value <> -1 Or CheckBox3.Checked) And (Drawl3NumericUpDown.Value <> -1 Or CheckBox4.Checked) And CatchingwithonebesthandNumericUpDown.Value <> -1 And CatchingoneotherhandNumericUpDown.Value <> -1 And ThrowingatWallTargetNumericUpDown.Value <> -1 And TwobordbalanceNumericUpDown.Value <> -1 And WalkingheelsbackNumericUpDown.Value <> -1 And ZigzaghpobestlegNumericUpDown.Value <> -1 And ZigzaghoppotherlrgNumericUpDown.Value Then

            Calculatebutton.Enabled = True
        Else
            Calculatebutton.Enabled = False
        End If
    End Sub

    Private Sub TurningPegspreferredhandNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles TurningPegspreferredhandNumericUpDown.ValueChanged
        HabilitaCalculo()

        Dim scorebruto As Integer
        Dim idadecalculada As Double
        Dim valor As Integer

        valor = TurningPegspreferredhandNumericUpDown.Value

        Dateborn = DateTimePicker2.Value.ToShortDateString
        Dateassessment = DateTimePicker1.Value.ToShortDateString
        Datet = (Dateassessment - Dateborn)
        Diff = Datet.Days
        idadecalculada = Diff / 365

        Select Case idadecalculada
            Case 11.0 To 11.99
                Select Case valor
                    Case <= 15
                        scorebruto = 16
                    Case 16
                        scorebruto = 14
                    Case 17
                        scorebruto = 12
                    Case 18 To 19
                        scorebruto = 11
                    Case 20 To 21
                        scorebruto = 10
                    Case 22
                        scorebruto = 9
                    Case 23
                        scorebruto = 8
                    Case 24
                        scorebruto = 7
                    Case 25
                        scorebruto = 6
                    Case 26
                        scorebruto = 5
                    Case 27
                        scorebruto = 4
                    Case >= 28
                        scorebruto = 2
                End Select

            Case 12 To 12.99
                Select Case valor
                    Case <= 13
                        scorebruto = 16
                    Case 14
                        scorebruto = 15
                    Case 15
                        scorebruto = 14
                    Case 16
                        scorebruto = 13
                    Case 17 To 18
                        scorebruto = 11
                    Case 19
                        scorebruto = 10
                    Case 20
                        scorebruto = 9
                    Case 21
                        scorebruto = 8
                    Case 22
                        scorebruto = 7
                    Case 23 To 24
                        scorebruto = 6
                    Case 25 To 26
                        scorebruto = 5
                    Case 27
                        scorebruto = 3
                    Case 28 To 29
                        scorebruto = 2
                    Case >= 30
                        scorebruto = 1
                End Select

            Case 13 To 13.99
                Select Case valor
                    Case <= 13
                        scorebruto = 16
                    Case 14
                        scorebruto = 14
                    Case 15
                        scorebruto = 13
                    Case 16
                        scorebruto = 12
                    Case 17 To 18
                        scorebruto = 11
                    Case 19
                        scorebruto = 10
                    Case 20
                        scorebruto = 9
                    Case 21
                        scorebruto = 7
                    Case 22 To 24
                        scorebruto = 6
                    Case 25
                        scorebruto = 4
                    Case 26
                        scorebruto = 3
                    Case >= 27
                        scorebruto = 1
                End Select
            Case 14 To 14.99
                Select Case valor
                    Case <= 13
                        scorebruto = 16
                    Case 14
                        scorebruto = 14
                    Case 15
                        scorebruto = 13
                    Case 16
                        scorebruto = 12
                    Case 17
                        scorebruto = 11
                    Case 18 To 19
                        scorebruto = 10
                    Case 20
                        scorebruto = 9
                    Case 21
                        scorebruto = 7
                    Case 22 To 23
                        scorebruto = 6
                    Case 24
                        scorebruto = 5
                    Case 25
                        scorebruto = 4
                    Case >= 26
                        scorebruto = 1
                End Select
            Case 15 To 15.99
                Select Case valor
                    Case <= 13
                        scorebruto = 16
                    Case 14
                        scorebruto = 14
                    Case 15
                        scorebruto = 13
                    Case 16
                        scorebruto = 12
                    Case 17
                        scorebruto = 11
                    Case 18
                        scorebruto = 10
                    Case 19
                        scorebruto = 9
                    Case 20
                        scorebruto = 8
                    Case 21
                        scorebruto = 7
                    Case 22 To 23
                        scorebruto = 6
                    Case 24
                        scorebruto = 5
                    Case 25
                        scorebruto = 4
                    Case >= 26
                        scorebruto = 1
                End Select
            Case 16 To 16.99
                Select Case valor
                    Case <= 13
                        scorebruto = 15
                    Case 14 To 15
                        scorebruto = 13
                    Case 16
                        scorebruto = 12
                    Case 17
                        scorebruto = 10
                    Case 18
                        scorebruto = 9
                    Case 19
                        scorebruto = 8
                    Case 20
                        scorebruto = 7
                    Case 21 To 23
                        scorebruto = 6
                    Case 24
                        scorebruto = 5
                    Case 25
                        scorebruto = 4
                    Case >= 26
                        scorebruto = 1
                End Select
        End Select
        If valor = -1 Then
            scorebruto = 1
        End If
        TurningPegspreferredhandep.Value = scorebruto
    End Sub

    Private Sub TurningPegsnonpreferredhandNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles TurningPegsnonpreferredhandNumericUpDown.ValueChanged
        HabilitaCalculo()

        Dim scorebruto As Integer
        Dim idadecalculada As Double
        Dim valor As Integer

        valor = TurningPegsnonpreferredhandNumericUpDown.Value

        Dateborn = DateTimePicker2.Value.ToShortDateString
        Dateassessment = DateTimePicker1.Value.ToShortDateString
        Datet = (Dateassessment - Dateborn)
        Diff = Datet.Days
        idadecalculada = Diff / 365

        Select Case idadecalculada
            Case 11.0 To 11.99
                Select Case valor
                    Case <= 14
                        scorebruto = 17
                    Case 15
                        scorebruto = 16
                    Case 16
                        scorebruto = 15
                    Case 17
                        scorebruto = 14
                    Case 18
                        scorebruto = 13
                    Case 19 To 20
                        scorebruto = 12
                    Case 21
                        scorebruto = 11
                    Case 22 To 23
                        scorebruto = 10
                    Case 24 To 25
                        scorebruto = 9
                    Case 26 To 27
                        scorebruto = 8
                    Case 28 To 30
                        scorebruto = 7
                    Case 31 To 32
                        scorebruto = 6
                    Case 33 To 37
                        scorebruto = 5
                    Case 38
                        scorebruto = 4
                    Case 39 To 40
                        scorebruto = 3
                    Case >= 41
                        scorebruto = 1
                End Select

            Case 12 To 12.99
                Select Case valor
                    Case <= 15
                        scorebruto = 16
                    Case 16
                        scorebruto = 14
                    Case 17
                        scorebruto = 13
                    Case 18
                        scorebruto = 12
                    Case 19 To 20
                        scorebruto = 11
                    Case 21
                        scorebruto = 10
                    Case 22
                        scorebruto = 9
                    Case 23 To 24
                        scorebruto = 8
                    Case 25
                        scorebruto = 7
                    Case 26 To 27
                        scorebruto = 6
                    Case 28 To 30
                        scorebruto = 5
                    Case 31 To 33
                        scorebruto = 4
                    Case 34 To 39
                        scorebruto = 3
                    Case >= 40
                        scorebruto = 1
                End Select

            Case 13 To 13.99
                Select Case valor
                    Case <= 15
                        scorebruto = 16
                    Case 16
                        scorebruto = 14
                    Case 17
                        scorebruto = 13
                    Case 18
                        scorebruto = 12
                    Case 19
                        scorebruto = 11
                    Case 20 To 21
                        scorebruto = 10
                    Case 22
                        scorebruto = 9
                    Case 23 To 24
                        scorebruto = 8
                    Case 25
                        scorebruto = 7
                    Case 26 To 27
                        scorebruto = 6
                    Case 28
                        scorebruto = 5
                    Case 29
                        scorebruto = 4
                    Case 30
                        scorebruto = 3
                    Case >= 31
                        scorebruto = 1
                End Select
            Case 14 To 14.99
                Select Case valor
                    Case <= 15
                        scorebruto = 16
                    Case 16
                        scorebruto = 14
                    Case 17
                        scorebruto = 13
                    Case 18 To 19
                        scorebruto = 11
                    Case 20 To 21
                        scorebruto = 10
                    Case 22
                        scorebruto = 9
                    Case 23 To 24
                        scorebruto = 8
                    Case 25
                        scorebruto = 7
                    Case 26 To 27
                        scorebruto = 6
                    Case 28
                        scorebruto = 5
                    Case >= 29
                        scorebruto = 1
                End Select
            Case 15 To 15.99
                Select Case valor
                    Case <= 14
                        scorebruto = 16
                    Case 15
                        scorebruto = 14
                    Case 16 To 17
                        scorebruto = 13
                    Case 18 To 19
                        scorebruto = 11
                    Case 20 To 21
                        scorebruto = 10
                    Case 22
                        scorebruto = 8
                    Case 23 To 24
                        scorebruto = 7
                    Case 25 To 27
                        scorebruto = 6
                    Case 28
                        scorebruto = 5
                    Case >= 29
                        scorebruto = 1
                End Select
            Case 16 To 16.99
                Select Case valor
                    Case <= 14
                        scorebruto = 16
                    Case 15
                        scorebruto = 14
                    Case 16
                        scorebruto = 13
                    Case 17
                        scorebruto = 12
                    Case 18
                        scorebruto = 11
                    Case 19
                        scorebruto = 10
                    Case 20 To 21
                        scorebruto = 9
                    Case 22
                        scorebruto = 8
                    Case 23 To 24
                        scorebruto = 7
                    Case 25 To 26
                        scorebruto = 5
                    Case 27
                        scorebruto = 4
                    Case 28
                        scorebruto = 3
                    Case >= 29
                        scorebruto = 1
                End Select
        End Select
        If valor = -1 Then
            scorebruto = 1
        End If
        TurningPegsnonpreferredhandep.Value = scorebruto
    End Sub

    Private Sub TrianglewithNutsandboltsNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles TrianglewithNutsandboltsNumericUpDown.ValueChanged
        HabilitaCalculo()

        Dim scorebruto As Integer
        Dim idadecalculada As Double
        Dim valor As Integer

        valor = TrianglewithNutsandboltsNumericUpDown.Value

        Dateborn = DateTimePicker2.Value.ToShortDateString
        Dateassessment = DateTimePicker1.Value.ToShortDateString
        Datet = (Dateassessment - Dateborn)
        Diff = Datet.Days
        idadecalculada = Diff / 365

        Select Case idadecalculada
            Case 11.0 To 11.99
                Select Case valor
                    Case <= 23
                        scorebruto = 17
                    Case 24
                        scorebruto = 16
                    Case 25 To 26
                        scorebruto = 15
                    Case 27
                        scorebruto = 14
                    Case 28 To 30
                        scorebruto = 13
                    Case 31 To 34
                        scorebruto = 12
                    Case 35 To 38
                        scorebruto = 11
                    Case 39 To 42
                        scorebruto = 10
                    Case 43 To 44
                        scorebruto = 9
                    Case 45 To 47
                        scorebruto = 8
                    Case 48 To 53
                        scorebruto = 7
                    Case 54 To 59
                        scorebruto = 6
                    Case 60 To 66
                        scorebruto = 5
                    Case 67 To 91
                        scorebruto = 4
                    Case >= 92
                        scorebruto = 1
                End Select

            Case 12 To 12.99
                Select Case valor
                    Case <= 21
                        scorebruto = 17
                    Case 22
                        scorebruto = 15
                    Case 23 To 26
                        scorebruto = 14
                    Case 27
                        scorebruto = 13
                    Case 28 To 29
                        scorebruto = 12
                    Case 30 To 34
                        scorebruto = 11
                    Case 35 To 40
                        scorebruto = 10
                    Case 41 To 42
                        scorebruto = 9
                    Case 43 To 44
                        scorebruto = 8
                    Case 45 To 47
                        scorebruto = 7
                    Case 48 To 51
                        scorebruto = 6
                    Case 52 To 62
                        scorebruto = 5
                    Case 63 To 68
                        scorebruto = 4
                    Case 69 To 70
                        scorebruto = 3
                    Case >= 71
                        scorebruto = 1
                End Select

            Case 13 To 13.99
                Select Case valor
                    Case <= 19
                        scorebruto = 17
                    Case 20 To 21
                        scorebruto = 16
                    Case 22
                        scorebruto = 15
                    Case 23 To 25
                        scorebruto = 14
                    Case 26 To 27
                        scorebruto = 13
                    Case 28 To 29
                        scorebruto = 12
                    Case 30 To 34
                        scorebruto = 11
                    Case 35 To 38
                        scorebruto = 10
                    Case 39 To 40
                        scorebruto = 9
                    Case 41 To 44
                        scorebruto = 8
                    Case 45 To 47
                        scorebruto = 7
                    Case 48 To 51
                        scorebruto = 6
                    Case 52 To 60
                        scorebruto = 5
                    Case 61 To 62
                        scorebruto = 4
                    Case 63 To 64
                        scorebruto = 3
                    Case >= 65
                        scorebruto = 1
                End Select
            Case 14 To 14.99
                Select Case valor
                    Case <= 19
                        scorebruto = 17
                    Case 20 To 21
                        scorebruto = 16
                    Case 22
                        scorebruto = 15
                    Case 33
                        scorebruto = 14
                    Case 24
                        scorebruto = 13
                    Case 25 To 27
                        scorebruto = 12
                    Case 28 To 29
                        scorebruto = 11
                    Case 30 To 36
                        scorebruto = 10
                    Case 37 To 38
                        scorebruto = 9
                    Case 39 To 41
                        scorebruto = 8
                    Case 42 To 47
                        scorebruto = 7
                    Case 48 To 51
                        scorebruto = 6
                    Case 52 To 58
                        scorebruto = 5
                    Case 59 To 60
                        scorebruto = 4
                    Case 61 To 64
                        scorebruto = 3
                    Case >= 65
                        scorebruto = 1
                End Select
            Case 15 To 15.99
                Select Case valor
                    Case <= 20
                        scorebruto = 16
                    Case 21
                        scorebruto = 15
                    Case 22 To 23
                        scorebruto = 14
                    Case 24
                        scorebruto = 13
                    Case 25 To 27
                        scorebruto = 12
                    Case 28 To 29
                        scorebruto = 11
                    Case 30 To 32
                        scorebruto = 10
                    Case 33 To 34
                        scorebruto = 9
                    Case 35 To 36
                        scorebruto = 8
                    Case 37 To 38
                        scorebruto = 7
                    Case 39 To 49
                        scorebruto = 6
                    Case 50 To 58
                        scorebruto = 5
                    Case 59 To 60
                        scorebruto = 4
                    Case 61 To 64
                        scorebruto = 3
                    Case >= 65
                        scorebruto = 1
                End Select
            Case 16 To 16.99
                Select Case valor
                    Case <= 20
                        scorebruto = 16
                    Case 21
                        scorebruto = 15
                    Case 22 To 23
                        scorebruto = 14
                    Case 24
                        scorebruto = 13
                    Case 25 To 26
                        scorebruto = 12
                    Case 27 To 28
                        scorebruto = 11
                    Case 29 To 31
                        scorebruto = 10
                    Case 32 To 34
                        scorebruto = 9
                    Case 35 To 36
                        scorebruto = 8
                    Case 37 To 38
                        scorebruto = 7
                    Case 39 To 43
                        scorebruto = 6
                    Case 44 To 48
                        scorebruto = 5
                    Case 49 To 51
                        scorebruto = 4
                    Case 52 To 56
                        scorebruto = 3
                    Case >= 57
                        scorebruto = 1
                End Select
        End Select
        If valor = -1 Then
            scorebruto = 1
        End If
        TrianglewithNutsandboltsep.Value = scorebruto
    End Sub

    Private Sub Drawl3NumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles Drawl3NumericUpDown.ValueChanged
        HabilitaCalculo()

        Dim scorebruto As Integer
        Dim idadecalculada As Double
        Dim valor As Integer

        valor = Drawl3NumericUpDown.Value

        Dateborn = DateTimePicker2.Value.ToShortDateString
        Dateassessment = DateTimePicker1.Value.ToShortDateString
        Datet = (Dateassessment - Dateborn)
        Diff = Datet.Days
        idadecalculada = Diff / 365

        Select Case idadecalculada
            Case 11.0 To 11.99
                Select Case valor
                    Case 0
                        scorebruto = 13
                    Case 1
                        scorebruto = 10
                    Case 2 To 3
                        scorebruto = 8
                    Case 4
                        scorebruto = 7
                    Case 5
                        scorebruto = 6
                    Case 6
                        scorebruto = 5
                    Case 7 To 9
                        scorebruto = 4
                    Case 10
                        scorebruto = 3
                    Case >= 11
                        scorebruto = 1
                End Select

            Case 12 To 12.99
                Select Case valor
                    Case 0
                        scorebruto = 13
                    Case 1
                        scorebruto = 9
                    Case 2
                        scorebruto = 8
                    Case 3
                        scorebruto = 7
                    Case 4
                        scorebruto = 6
                    Case 5
                        scorebruto = 5
                    Case 6 To 10
                        scorebruto = 3
                    Case >= 11
                        scorebruto = 1
                End Select

            Case 13 To 13.99
                Select Case valor
                    Case 0
                        scorebruto = 13
                    Case 1
                        scorebruto = 9
                    Case 2 To 3
                        scorebruto = 7
                    Case 4
                        scorebruto = 6
                    Case 5
                        scorebruto = 5
                    Case 6 To 7
                        scorebruto = 3
                    Case >= 8
                        scorebruto = 1
                End Select
            Case 14 To 14.99
                Select Case valor
                    Case 0
                        scorebruto = 12
                    Case 1
                        scorebruto = 8
                    Case 2
                        scorebruto = 7
                    Case 3
                        scorebruto = 4
                    Case >= 4
                        scorebruto = 1
                End Select
            Case 15 To 15.99
                Select Case valor
                    Case 0
                        scorebruto = 12
                    Case 1 To 2
                        scorebruto = 7
                    Case 3
                        scorebruto = 4
                    Case >= 4
                        scorebruto = 1
                End Select
            Case 16 To 16.99
                Select Case valor
                    Case 0
                        scorebruto = 12
                    Case 1 To 2
                        scorebruto = 6
                    Case >= 3
                        scorebruto = 1
                End Select

        End Select
        If valor = -1 Then
            scorebruto = 1
        End If
        Drawl3ep.Value = scorebruto
    End Sub

    Private Sub CatchingwithonebesthandNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles CatchingwithonebesthandNumericUpDown.ValueChanged
        HabilitaCalculo()

        Dim scorebruto As Integer
        Dim idadecalculada As Double
        Dim valor As Integer

        valor = CatchingwithonebesthandNumericUpDown.Value

        Dateborn = DateTimePicker2.Value.ToShortDateString
        Dateassessment = DateTimePicker1.Value.ToShortDateString
        Datet = (Dateassessment - Dateborn)
        Diff = Datet.Days
        idadecalculada = Diff / 365

        Select Case idadecalculada
            Case 11.0 To 11.99
                Select Case valor
                    Case 0
                        scorebruto = 4
                    Case 1
                        scorebruto = 5
                    Case 2 To 3
                        scorebruto = 6
                    Case 4 To 5
                        scorebruto = 7
                    Case 6
                        scorebruto = 8
                    Case 7
                        scorebruto = 10
                    Case 8 To 9
                        scorebruto = 11
                    Case 10
                        scorebruto = 14
                End Select

            Case 12 To 12.99
                Select Case valor
                    Case 0
                        scorebruto = 4
                    Case 1 To 2
                        scorebruto = 5
                    Case 3 To 4
                        scorebruto = 6
                    Case 5 To 6
                        scorebruto = 7
                    Case 7
                        scorebruto = 8
                    Case 8
                        scorebruto = 9
                    Case 9
                        scorebruto = 11
                    Case 10
                        scorebruto = 14
                End Select

            Case 13 To 13.99
                Select Case valor
                    Case 0
                        scorebruto = 4
                    Case 1 To 3
                        scorebruto = 5
                    Case 4 To 5
                        scorebruto = 6
                    Case 6
                        scorebruto = 7
                    Case 7
                        scorebruto = 8
                    Case 8
                        scorebruto = 9
                    Case 9
                        scorebruto = 11
                    Case 10
                        scorebruto = 13
                End Select
            Case 14 To 14.99
                Select Case valor
                    Case 0 To 1
                        scorebruto = 2
                    Case 2 To 3
                        scorebruto = 4
                    Case 4 To 5
                        scorebruto = 6
                    Case 6
                        scorebruto = 7
                    Case 7 To 8
                        scorebruto = 8
                    Case 9
                        scorebruto = 9
                    Case 10
                        scorebruto = 13
                End Select
            Case 15 To 15.99
                Select Case valor
                    Case 0 To 1
                        scorebruto = 2
                    Case 2 To 3
                        scorebruto = 4
                    Case 4 To 6
                        scorebruto = 6
                    Case 7
                        scorebruto = 7
                    Case 8
                        scorebruto = 8
                    Case 9
                        scorebruto = 9
                    Case 10
                        scorebruto = 13
                End Select
            Case 16 To 16.99
                Select Case valor
                    Case 0 To 1
                        scorebruto = 2
                    Case 2 To 4
                        scorebruto = 3
                    Case 5
                        scorebruto = 4
                    Case 6
                        scorebruto = 5
                    Case 7
                        scorebruto = 7
                    Case 8
                        scorebruto = 8
                    Case 9
                        scorebruto = 9
                    Case 10
                        scorebruto = 13
                End Select
        End Select
        Catchingwithonebesthandep.Value = scorebruto
    End Sub

    Private Sub CatchingoneotherhandNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles CatchingoneotherhandNumericUpDown.ValueChanged
        HabilitaCalculo()

        Dim scorebruto As Integer
        Dim idadecalculada As Double
        Dim valor As Integer

        valor = CatchingoneotherhandNumericUpDown.Value

        Dateborn = DateTimePicker2.Value.ToShortDateString
        Dateassessment = DateTimePicker1.Value.ToShortDateString
        Datet = (Dateassessment - Dateborn)
        Diff = Datet.Days
        idadecalculada = Diff / 365

        Select Case idadecalculada
            Case 11.0 To 11.99
                Select Case valor
                    Case 0
                        scorebruto = 4
                    Case 1
                        scorebruto = 6
                    Case 2
                        scorebruto = 7
                    Case 3
                        scorebruto = 8
                    Case 4
                        scorebruto = 9
                    Case 5
                        scorebruto = 10
                    Case 6
                        scorebruto = 11
                    Case 7 To 8
                        scorebruto = 12
                    Case 9
                        scorebruto = 13
                    Case 9
                        scorebruto = 15
                End Select

            Case 12 To 12.99
                Select Case valor
                    Case 0
                        scorebruto = 3
                    Case 1
                        scorebruto = 4
                    Case 2
                        scorebruto = 6
                    Case 3
                        scorebruto = 7
                    Case 4
                        scorebruto = 8
                    Case 5
                        scorebruto = 9
                    Case 6
                        scorebruto = 10
                    Case 7 To 8
                        scorebruto = 11
                    Case 9
                        scorebruto = 13
                    Case 10
                        scorebruto = 15
                End Select

            Case 13 To 13.99

                Select Case valor
                    Case 0
                        scorebruto = 3
                    Case 1
                        scorebruto = 4
                    Case 2
                        scorebruto = 6
                    Case 3
                        scorebruto = 7
                    Case 4
                        scorebruto = 8
                    Case 5
                        scorebruto = 9
                    Case 6 To 7
                        scorebruto = 10
                    Case 8
                        scorebruto = 11
                    Case 9
                        scorebruto = 12
                    Case 10
                        scorebruto = 14
                End Select

            Case 14 To 14.99
                Select Case valor
                    Case 0 To 1
                        scorebruto = 3
                    Case 2 To 3
                        scorebruto = 5
                    Case 4 To 5
                        scorebruto = 6
                    Case 6
                        scorebruto = 9
                    Case 7
                        scorebruto = 10
                    Case 8
                        scorebruto = 11
                    Case 9
                        scorebruto = 12
                    Case 10
                        scorebruto = 14
                End Select

            Case 15 To 15.99
                Select Case valor
                    Case 0 To 1
                        scorebruto = 3
                    Case 2 To 3
                        scorebruto = 5
                    Case 4 To 5
                        scorebruto = 6
                    Case 6
                        scorebruto = 9
                    Case 7
                        scorebruto = 10
                    Case 8
                        scorebruto = 11
                    Case 9
                        scorebruto = 12
                    Case 10
                        scorebruto = 14
                End Select
            Case 16 To 16.99
                Select Case valor
                    Case 0 To 2
                        scorebruto = 3
                    Case 3 To 4
                        scorebruto = 4
                    Case 5
                        scorebruto = 6
                    Case 6 To 7
                        scorebruto = 9
                    Case 8
                        scorebruto = 10
                    Case 9
                        scorebruto = 12
                    Case 10
                        scorebruto = 13
                End Select
            Case 17 To 17.99
                Select Case valor
                    Case 0
                        scorebruto = 4
                    Case 1
                        scorebruto = 6
                    Case 2
                        scorebruto = 7
                    Case 3
                        scorebruto = 9
                    Case 4
                        scorebruto = 11
                    Case 5
                        scorebruto = 14
                End Select
        End Select
        Catchingoneotherhandep.Value = scorebruto
    End Sub

    Private Sub ThrowingatWallTargetNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles ThrowingatWallTargetNumericUpDown.ValueChanged
        HabilitaCalculo()

        Dim scorebruto As Integer
        Dim idadecalculada As Double
        Dim valor As Integer

        valor = ThrowingatWallTargetNumericUpDown.Value

        Dateborn = DateTimePicker2.Value.ToShortDateString
        Dateassessment = DateTimePicker1.Value.ToShortDateString
        Datet = (Dateassessment - Dateborn)
        Diff = Datet.Days
        idadecalculada = Diff / 365

        Select Case idadecalculada
            Case 11.0 To 11.99
                Select Case valor
                    Case 0
                        scorebruto = 3
                    Case 1
                        scorebruto = 5
                    Case 2 To 3
                        scorebruto = 6
                    Case 4
                        scorebruto = 7
                    Case 5
                        scorebruto = 10
                    Case 6
                        scorebruto = 11
                    Case 7
                        scorebruto = 13
                    Case 8
                        scorebruto = 15
                    Case 9 To 10
                        scorebruto = 17
                End Select

            Case 12 To 12.99
                Select Case valor
                    Case 0
                        scorebruto = 3
                    Case 1
                        scorebruto = 4
                    Case 2 To 3
                        scorebruto = 6
                    Case 4
                        scorebruto = 7
                    Case 5
                        scorebruto = 9
                    Case 6
                        scorebruto = 10
                    Case 7
                        scorebruto = 13
                    Case 8
                        scorebruto = 14
                    Case 9 To 10
                        scorebruto = 16
                End Select

            Case 13 To 13.99
                Select Case valor
                    Case 0
                        scorebruto = 3
                    Case 1 To 2
                        scorebruto = 4
                    Case 3
                        scorebruto = 6
                    Case 4
                        scorebruto = 7
                    Case 5
                        scorebruto = 9
                    Case 6
                        scorebruto = 10
                    Case 7
                        scorebruto = 11
                    Case 8
                        scorebruto = 12
                    Case 9
                        scorebruto = 15
                    Case 10
                        scorebruto = 16
                End Select

            Case 14 To 14.99
                Select Case valor
                    Case 0
                        scorebruto = 3
                    Case 1 To 2
                        scorebruto = 4
                    Case 3
                        scorebruto = 5
                    Case 4
                        scorebruto = 7
                    Case 5
                        scorebruto = 8
                    Case 6
                        scorebruto = 10
                    Case 7
                        scorebruto = 11
                    Case 8
                        scorebruto = 12
                    Case 9
                        scorebruto = 15
                    Case 10
                        scorebruto = 16
                End Select

            Case 15 To 15.99
                Select Case valor
                    Case 0
                        scorebruto = 3
                    Case 1 To 2
                        scorebruto = 4
                    Case 3
                        scorebruto = 5
                    Case 4
                        scorebruto = 7
                    Case 5
                        scorebruto = 8
                    Case 6
                        scorebruto = 10
                    Case 7
                        scorebruto = 11
                    Case 8
                        scorebruto = 12
                    Case 9
                        scorebruto = 15
                    Case 10
                        scorebruto = 16
                End Select

            Case 16 To 16.99
                Select Case valor
                    Case 0 To 3
                        scorebruto = 3
                    Case 4
                        scorebruto = 5
                    Case 5
                        scorebruto = 7
                    Case 6
                        scorebruto = 9
                    Case 7
                        scorebruto = 10
                    Case 8
                        scorebruto = 12
                    Case 9
                        scorebruto = 14
                    Case 10
                        scorebruto = 15
                End Select
        End Select
        ThrowingatWallTargetep.Value = scorebruto
    End Sub

    Private Sub TwobordbalanceNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles TwobordbalanceNumericUpDown.ValueChanged
        HabilitaCalculo()

        Dim scorebruto As Integer
        Dim idadecalculada As Double
        Dim valor As Integer

        valor = TwobordbalanceNumericUpDown.Value

        Dateborn = DateTimePicker2.Value.ToShortDateString
        Dateassessment = DateTimePicker1.Value.ToShortDateString
        Datet = (Dateassessment - Dateborn)
        Diff = Datet.Days
        idadecalculada = Diff / 365

        Select Case idadecalculada
            Case 11.0 To 11.99
                Select Case valor
                    Case 0
                        scorebruto = 2
                    Case 1 To 2
                        scorebruto = 3
                    Case 3
                        scorebruto = 4
                    Case 4 To 5
                        scorebruto = 5
                    Case 6
                        scorebruto = 6
                    Case 7 To 10
                        scorebruto = 7
                    Case 11 To 17
                        scorebruto = 8
                    Case 18 To 22
                        scorebruto = 9
                    Case 23 To 26
                        scorebruto = 10
                    Case 27 To 28
                        scorebruto = 11
                    Case 29 To 30
                        scorebruto = 13
                End Select

            Case 12 To 12.99
                Select Case valor
                    Case 0
                        scorebruto = 2
                    Case 1 To 2
                        scorebruto = 3
                    Case 3
                        scorebruto = 4
                    Case 4 To 5
                        scorebruto = 5
                    Case 6
                        scorebruto = 6
                    Case 7 To 10
                        scorebruto = 7
                    Case 11 To 17
                        scorebruto = 8
                    Case 18 To 22
                        scorebruto = 9
                    Case 23 To 26
                        scorebruto = 10
                    Case 27 To 28
                        scorebruto = 11
                    Case 29 To 30
                        scorebruto = 13
                End Select

            Case 13 To 13.99
                Select Case valor
                    Case 0
                        scorebruto = 2
                    Case 1 To 2
                        scorebruto = 3
                    Case 3
                        scorebruto = 4
                    Case 4 To 5
                        scorebruto = 5
                    Case 6
                        scorebruto = 6
                    Case 7 To 10
                        scorebruto = 7
                    Case 11 To 17
                        scorebruto = 8
                    Case 18 To 22
                        scorebruto = 9
                    Case 23 To 26
                        scorebruto = 10
                    Case 27 To 28
                        scorebruto = 11
                    Case 29 To 30
                        scorebruto = 13
                End Select
            Case 14 To 14.99
                Select Case valor
                    Case 0
                        scorebruto = 2
                    Case 1 To 2
                        scorebruto = 3
                    Case 3
                        scorebruto = 4
                    Case 4 To 6
                        scorebruto = 5
                    Case 7
                        scorebruto = 6
                    Case 8 To 10
                        scorebruto = 7
                    Case 11 To 17
                        scorebruto = 8
                    Case 18 To 22
                        scorebruto = 9
                    Case 23 To 27
                        scorebruto = 10
                    Case 28
                        scorebruto = 11
                    Case 29 To 30
                        scorebruto = 13
                End Select
            Case 15 To 15.99
                Select Case valor
                    Case 0
                        scorebruto = 2
                    Case 1 To 3
                        scorebruto = 3
                    Case 4 To 5
                        scorebruto = 4
                    Case 6
                        scorebruto = 5
                    Case 7
                        scorebruto = 6
                    Case 8 To 10
                        scorebruto = 7
                    Case 11 To 17
                        scorebruto = 8
                    Case 18 To 22
                        scorebruto = 9
                    Case 23 To 27
                        scorebruto = 10
                    Case 28
                        scorebruto = 11
                    Case 29 To 30
                        scorebruto = 13
                End Select
            Case 16 To 16.99
                Select Case valor
                    Case 0
                        scorebruto = 2
                    Case 1 To 3
                        scorebruto = 3
                    Case 4 To 5
                        scorebruto = 4
                    Case 6
                        scorebruto = 5
                    Case 7
                        scorebruto = 6
                    Case 8 To 10
                        scorebruto = 7
                    Case 11 To 17
                        scorebruto = 8
                    Case 18 To 22
                        scorebruto = 9
                    Case 23 To 27
                        scorebruto = 10
                    Case 28
                        scorebruto = 11
                    Case 29 To 30
                        scorebruto = 13
                End Select
        End Select
        Twobordbalanceep.Value = scorebruto
    End Sub

    Private Sub WalkingheelsbackNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles WalkingheelsbackNumericUpDown.ValueChanged
        HabilitaCalculo()

        Dim scorebruto As Integer
        Dim idadecalculada As Double
        Dim valor As Integer

        valor = WalkingheelsbackNumericUpDown.Value

        Dateborn = DateTimePicker2.Value.ToShortDateString
        Dateassessment = DateTimePicker1.Value.ToShortDateString
        Datet = (Dateassessment - Dateborn)
        Diff = Datet.Days
        idadecalculada = Diff / 365

        Select Case idadecalculada
            Case 11.0 To 11.99
                Select Case valor
                    Case 0 To 3
                        scorebruto = 3
                    Case 4
                        scorebruto = 4
                    Case 5
                        scorebruto = 5
                    Case 6
                        scorebruto = 7
                    Case 7
                        scorebruto = 8
                    Case 8 To 10
                        scorebruto = 9
                    Case 11 To 12
                        scorebruto = 10
                    Case 13
                        scorebruto = 11
                    Case 14 To 15
                        scorebruto = 12
                End Select

            Case 12 To 12.99
                Select Case valor
                    Case 0 To 4
                        scorebruto = 3
                    Case 5
                        scorebruto = 5
                    Case 6
                        scorebruto = 7
                    Case 7
                        scorebruto = 8
                    Case 8 To 10
                        scorebruto = 9
                    Case 11 To 12
                        scorebruto = 10
                    Case 13
                        scorebruto = 11
                    Case 14 To 15
                        scorebruto = 12
                End Select

            Case 13 To 13.99
                Select Case valor
                    Case 0 To 4
                        scorebruto = 3
                    Case 5
                        scorebruto = 5
                    Case 6
                        scorebruto = 6
                    Case 7
                        scorebruto = 7
                    Case 8 To 10
                        scorebruto = 9
                    Case 11 To 12
                        scorebruto = 10
                    Case 13
                        scorebruto = 11
                    Case 14 To 15
                        scorebruto = 12
                End Select

            Case 14 To 14.99
                Select Case valor
                    Case 0 To 1
                        scorebruto = 2
                    Case 2 To 4
                        scorebruto = 3
                    Case 5
                        scorebruto = 4
                    Case 6 To 7
                        scorebruto = 5
                    Case 8 To 10
                        scorebruto = 6
                    Case 11 To 12
                        scorebruto = 7
                    Case 13 To 14
                        scorebruto = 8
                    Case 15
                        scorebruto = 12
                End Select

            Case 15 To 15.99
                Select Case valor
                    Case 0 To 1
                        scorebruto = 2
                    Case 2 To 4
                        scorebruto = 3
                    Case 5
                        scorebruto = 4
                    Case 6 To 7
                        scorebruto = 5
                    Case 8 To 10
                        scorebruto = 6
                    Case 11 To 12
                        scorebruto = 7
                    Case 13 To 14
                        scorebruto = 8
                    Case 15
                        scorebruto = 12
                End Select
            Case 16 To 16.99
                Select Case valor
                    Case 0 To 1
                        scorebruto = 2
                    Case 2 To 4
                        scorebruto = 3
                    Case 5
                        scorebruto = 4
                    Case 6 To 7
                        scorebruto = 5
                    Case 8 To 10
                        scorebruto = 6
                    Case 11 To 12
                        scorebruto = 7
                    Case 13 To 14
                        scorebruto = 8
                    Case 15
                        scorebruto = 12
                End Select
        End Select
        Walkingheelsbackep.Value = scorebruto
    End Sub

    Private Sub ZigzaghpobestlegNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles ZigzaghpobestlegNumericUpDown.ValueChanged
        HabilitaCalculo()

        Dim scorebruto As Integer
        Dim idadecalculada As Double
        Dim valor As Integer

        valor = ZigzaghpobestlegNumericUpDown.Value

        Dateborn = DateTimePicker2.Value.ToShortDateString
        Dateassessment = DateTimePicker1.Value.ToShortDateString
        Datet = (Dateassessment - Dateborn)
        Diff = Datet.Days
        idadecalculada = Diff / 365

        Select Case idadecalculada
            Case 11.0 To 11.99
                Select Case valor
                    Case 0 To 4
                        scorebruto = 1
                    Case 5
                        scorebruto = 11
                End Select

            Case 12 To 12.99
                Select Case valor
                    Case 0 To 4
                        scorebruto = 1
                    Case 5
                        scorebruto = 11
                End Select

            Case 13 To 13.99
                Select Case valor
                    Case 0 To 4
                        scorebruto = 1
                    Case 5
                        scorebruto = 11
                End Select
            Case 14 To 14.99
                Select Case valor
                    Case 0 To 4
                        scorebruto = 1
                    Case 5
                        scorebruto = 11
                End Select
            Case 15 To 15.99
                Select Case valor
                    Case 0 To 4
                        scorebruto = 1
                    Case 5
                        scorebruto = 11
                End Select
            Case 16 To 16.99
                Select Case valor
                    Case 0 To 4
                        scorebruto = 1
                    Case 5
                        scorebruto = 11
                End Select
        End Select
        Zigzaghpobestlegep.Value = scorebruto
    End Sub

    Private Sub ZigzaghoppotherlrgNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles ZigzaghoppotherlrgNumericUpDown.ValueChanged
        HabilitaCalculo()

        Dim scorebruto As Integer
        Dim idadecalculada As Double
        Dim valor As Integer

        valor = ZigzaghoppotherlrgNumericUpDown.Value

        Dateborn = DateTimePicker2.Value.ToShortDateString
        Dateassessment = DateTimePicker1.Value.ToShortDateString
        Datet = (Dateassessment - Dateborn)
        Diff = Datet.Days
        idadecalculada = Diff / 365

        Select Case idadecalculada
            Case 11.0 To 11.99
                Select Case valor
                    Case 0 To 1
                        scorebruto = 2
                    Case 2
                        scorebruto = 3
                    Case 3
                        scorebruto = 4
                    Case 4
                        scorebruto = 10
                    Case 5
                        scorebruto = 11
                End Select

            Case 12 To 12.99
                Select Case valor
                    Case 0 To 1
                        scorebruto = 1
                    Case 2
                        scorebruto = 2
                    Case 3
                        scorebruto = 3
                    Case 4
                        scorebruto = 10
                    Case 5
                        scorebruto = 11
                End Select

            Case 13 To 13.99
                Select Case valor
                    Case 0 To 1
                        scorebruto = 1
                    Case 2
                        scorebruto = 2
                    Case 3
                        scorebruto = 3
                    Case 4
                        scorebruto = 10
                    Case 5
                        scorebruto = 11
                End Select
            Case 14 To 14.99
                Select Case valor
                    Case 0 To 1
                        scorebruto = 1
                    Case 2
                        scorebruto = 2
                    Case 3
                        scorebruto = 3
                    Case 4
                        scorebruto = 10
                    Case 5
                        scorebruto = 11
                End Select
            Case 15 To 15.99
                Select Case valor
                    Case 0 To 1
                        scorebruto = 1
                    Case 2
                        scorebruto = 2
                    Case 3
                        scorebruto = 3
                    Case 4
                        scorebruto = 10
                    Case 5
                        scorebruto = 11
                End Select
            Case 16 To 16.99
                Select Case valor
                    Case 0 To 1
                        scorebruto = 1
                    Case 2 To 3
                        scorebruto = 2
                    Case 4
                        scorebruto = 4
                    Case 5
                        scorebruto = 11
                End Select
        End Select
        Zigzaghoppotherlrgep.Value = scorebruto
    End Sub

    Private Sub BtnSaveEdit_Click(sender As Object, e As EventArgs) Handles BtnSaveEdit.Click

        BtnSaveEdit.Visible = True

        Dim ask As MsgBoxResult

        ask = MsgBox("Are you sure save the edited data of the child?", MsgBoxStyle.YesNo)

        If ask = MsgBoxResult.Yes Then

            Band3BindingSource.EndEdit()

            Band3TableAdapter.Update(Banco_de_dadosDataSet.Band3)

            Band3TableAdapter.Fill(Banco_de_dadosDataSet.Band3)

        End If

        BtnSaveEdit.Visible = False

        btnNewSchool.Enabled = False

        btnNewAdm.Enabled = False

        btnSave.Visible = False

        DateTimePicker1.Enabled = False

        SchoolCbx.Enabled = False

        administerCbx.Enabled = False

        printpageBtm.Visible = True

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim ask As MsgBoxResult

        ask = MsgBox("Are you sure save the data of the child?", MsgBoxStyle.YesNo)

        If ask = MsgBoxResult.Yes Then

            Dateborn = DateTimePicker2.Value.ToShortDateString
            Dateassessment = DateTimePicker1.Value.ToShortDateString
            Datet = (Dateassessment - Dateborn)
            Diff = Datet.Days

            Dim idade As Decimal

            idade = Math.Round(Convert.ToDecimal(Diff / 365), 2)

            Dim standardscoreMDint As Integer
            standardscoreMDint = Int(standardscoreMD.Text)

            Dim percentilMDint As Decimal
            percentilMDint = Convert.ToDecimal(percentilMD.Text)

            Dim standardscoreAMint As Integer
            standardscoreAMint = Int(standardscoreAM.Text)

            Dim percentilAMint As Decimal
            percentilAMint = Convert.ToDecimal(percentilAM.Text)

            Dim standardscoreBAint As Integer
            standardscoreBAint = Int(standardscoreBA.Text)

            Dim percentilBAint As Decimal
            percentilBAint = Convert.ToDecimal(percentilBA.Text)

            Dim somastandardscoretotalint As Integer
            somastandardscoretotalint = Int(somastandardscoretotal.Text)

            Dim percentiltotalint As Decimal
            percentiltotalint = Convert.ToDecimal(percentiltotal.Text)

            Band3TableAdapter.Insert(Id_child.Value,
                                     codeSchool.Value,
                                     codeAdm.Value,
                                     DateTimePicker1.Value,'TODO Band3TableAdapter.insert os campos text não recebem os valores das variáveis. Acho que temos que temos que converter essa variável em date
                                     idade,
                                     TurningPegspreferredhandNumericUpDown.Value,
                                     TurningPegspreferredhandep.Value,
                                     TurningPegsnonpreferredhandNumericUpDown.Value,
                                     TurningPegsnonpreferredhandep.Value,
                                     TurningPegsep.Value,
                                     TrianglewithNutsandboltsNumericUpDown.Value,
                                     TrianglewithNutsandboltsep.Value,
                                     Drawl3NumericUpDown.Value,
                                     Drawl3ep.Value,
                                     CatchingwithonebesthandNumericUpDown.Value,
                                     Catchingwithonebesthandep.Value,
                                     CatchingoneotherhandNumericUpDown.Value,
                                     Catchingoneotherhandep.Value,
                                     Catchingonehandep.Value,
                                     ThrowingatWallTargetNumericUpDown.Value,
                                     ThrowingatWallTargetep.Value,
                                     TwobordbalanceNumericUpDown.Value,
                                     Twobordbalanceep.Value,
                                     WalkingheelsbackNumericUpDown.Value,
                                     Walkingheelsbackep.Value,
                                     ZigzaghpobestlegNumericUpDown.Value,
                                     Zigzaghpobestlegep.Value,
                                     ZigzaghoppotherlrgNumericUpDown.Value,
                                     Zigzaghoppotherlrgep.Value,
                                     Zigzaghoppep.Value,
                                     standardscoreMDint,
                                     percentilMDint,
                                     standardscoreAMint,
                                     percentilAMint,
                                     standardscoreBAint,
                                     percentilBAint,
                                     somastandardscoretotalint,
                                     percentiltotalint,
                                     resultMabc.Text,
                                     RichTextBox1.Text)

            Band3TableAdapter.Update(Banco_de_dadosDataSet.Band3)

            Band3BindingSource.Sort = "Band3_codigo DESC"

            Band3TableAdapter.Fill(Banco_de_dadosDataSet.Band3)

            MsgBox("Sucessfull")

            BtnSaveEdit.Visible = False
            btnNewSchool.Enabled = False
            btnNewAdm.Enabled = False
            btnSave.Visible = False
            DateTimePicker1.Enabled = False
            SchoolCbx.Enabled = False
            administerCbx.Enabled = False
            printpageBtm.Visible = True

        End If

    End Sub

    Private Sub Calculatebutton_Click(sender As Object, e As EventArgs) Handles Calculatebutton.Click
        Dim TurningPegsmedia As Double
        Dim TurningPegs As Integer

        TurningPegsmedia = (TurningPegspreferredhandep.Value + TurningPegsnonpreferredhandep.Value) / 2

        If TurningPegsmedia > 10 Then
            TurningPegs = Math.Round(TurningPegsmedia, 0)
        Else
            TurningPegs = TurningPegsmedia 'Ao passar uma variavel Double para outra Integer, as casas decimais são suprimidas
        End If

        TurningPegsep.Value = TurningPegs

        Dim Catchingwithandmedia As Double
        Dim Catchingwithandep As Integer

        Catchingwithandmedia = (Catchingwithonebesthandep.Value + Catchingoneotherhandep.Value) / 2

        If Catchingwithandmedia > 10 Then
            Catchingwithandep = Math.Round(Catchingwithandmedia, 0)
        Else
            Catchingwithandep = Catchingwithandmedia
        End If

        Catchingonehandep.Value = Catchingwithandep

        Dim Zigzaghpomedia As Double
        Dim Zigzaghpo As Integer

        Zigzaghpomedia = (Zigzaghpobestlegep.Value + Zigzaghoppotherlrgep.Value) / 2

        If Zigzaghpomedia > 10 Then
            Zigzaghpo = Math.Round(Zigzaghpomedia, 0)
        Else
            Zigzaghpo = Zigzaghpomedia

        End If

        Zigzaghoppep.Value = Zigzaghpo


        Dim componentescoreaimingcatching As Integer
        Dim stantardscoreAimingCatching As Integer
        Dim percentilaimingcatching As Double

        componentescoreaimingcatching = Catchingonehandep.Value + ThrowingatWallTargetep.Value

        Select Case componentescoreaimingcatching
            Case <= 6
                stantardscoreAimingCatching = 1
            Case 7 To 8
                stantardscoreAimingCatching = 2
            Case 9
                stantardscoreAimingCatching = 3
            Case 10
                stantardscoreAimingCatching = 4
            Case 11 To 12
                stantardscoreAimingCatching = 5
            Case 13
                stantardscoreAimingCatching = 6
            Case 14
                stantardscoreAimingCatching = 7
            Case 15 To 16
                stantardscoreAimingCatching = 8
            Case 17 To 18
                stantardscoreAimingCatching = 9
            Case 19 To 20
                stantardscoreAimingCatching = 10
            Case 21
                stantardscoreAimingCatching = 11
            Case 22 To 23
                stantardscoreAimingCatching = 12
            Case 24 To 25
                stantardscoreAimingCatching = 13
            Case 26
                stantardscoreAimingCatching = 14
            Case 27 To 28
                stantardscoreAimingCatching = 15
            Case 29
                stantardscoreAimingCatching = 16
            Case 30
                stantardscoreAimingCatching = 17
            Case 31 To 32
                stantardscoreAimingCatching = 18
            Case >= 33
                stantardscoreAimingCatching = 19

        End Select

        Select Case componentescoreaimingcatching
            Case <= 6
                percentilaimingcatching = 0.1
            Case 7 To 8
                percentilaimingcatching = 0.5
            Case 9
                percentilaimingcatching = 1
            Case 10
                percentilaimingcatching = 2
            Case 11 To 12
                percentilaimingcatching = 5
            Case 13
                percentilaimingcatching = 9
            Case 14
                percentilaimingcatching = 16
            Case 15 To 16
                percentilaimingcatching = 25
            Case 17 To 18
                percentilaimingcatching = 37
            Case 19 To 20
                percentilaimingcatching = 50
            Case 21
                percentilaimingcatching = 63
            Case 22 To 23
                percentilaimingcatching = 75
            Case 24 To 25
                percentilaimingcatching = 84
            Case 26
                percentilaimingcatching = 91
            Case 27 To 28
                percentilaimingcatching = 95
            Case 29
                percentilaimingcatching = 98
            Case 30
                percentilaimingcatching = 99
            Case 31 To 32
                percentilaimingcatching = 99.5
            Case >= 33
                percentilaimingcatching = 99.9
        End Select

        componentscoreAM.Text = componentescoreaimingcatching
        standardscoreAM.Text = stantardscoreAimingCatching
        percentilAM.Text = percentilaimingcatching

        Dim componentmanualdextery As Integer
        Dim standardscoremanualdextery As Integer
        Dim percentilmanualdexteryscore As Double

        componentmanualdextery = Drawl3ep.Value + TrianglewithNutsandboltsep.Value + TurningPegsep.Value

        Select Case componentmanualdextery
            Case <= 3
                standardscoremanualdextery = 1
            Case 4 To 8
                standardscoremanualdextery = 2
            Case 9 To 12
                standardscoremanualdextery = 3
            Case 13 To 15
                standardscoremanualdextery = 4
            Case 16 To 19
                standardscoremanualdextery = 5
            Case 19 To 21
                standardscoremanualdextery = 6
            Case 22 To 23
                standardscoremanualdextery = 7
            Case 24 To 25
                standardscoremanualdextery = 8
            Case 26 To 28
                standardscoremanualdextery = 9
            Case 29 To 30
                standardscoremanualdextery = 10
            Case 31 To 32
                standardscoremanualdextery = 11
            Case 33 To 34
                standardscoremanualdextery = 12
            Case 35 To 36
                standardscoremanualdextery = 13
            Case 37
                standardscoremanualdextery = 14
            Case 38 To 39
                standardscoremanualdextery = 15
            Case 40
                standardscoremanualdextery = 16
            Case 41
                standardscoremanualdextery = 17
            Case 42
                standardscoremanualdextery = 18
            Case >= 43
                standardscoremanualdextery = 19
        End Select

        Select Case componentmanualdextery
            Case <= 3
                percentilmanualdexteryscore = 0.1
            Case 4 To 8
                percentilmanualdexteryscore = 0.5
            Case 9 To 12
                percentilmanualdexteryscore = 1
            Case 13 To 15
                percentilmanualdexteryscore = 2
            Case 16 To 18
                percentilmanualdexteryscore = 5
            Case 19 To 21
                percentilmanualdexteryscore = 9
            Case 22 To 23
                percentilmanualdexteryscore = 16
            Case 24 To 25
                percentilmanualdexteryscore = 25
            Case 26 To 28
                percentilmanualdexteryscore = 37
            Case 29 To 30
                percentilmanualdexteryscore = 50
            Case 31 To 32
                percentilmanualdexteryscore = 63
            Case 33 To 34
                percentilmanualdexteryscore = 75
            Case 35 To 36
                percentilmanualdexteryscore = 84
            Case 37
                percentilmanualdexteryscore = 91
            Case 38 To 39
                percentilmanualdexteryscore = 95
            Case 40
                percentilmanualdexteryscore = 98
            Case 41
                percentilmanualdexteryscore = 99
            Case 42
                percentilmanualdexteryscore = 99.5
            Case >= 43
                percentilmanualdexteryscore = 99.9
        End Select

        componentmMD.Text = componentmanualdextery
        standardscoreMD.Text = standardscoremanualdextery
        percentilMD.Text = percentilmanualdexteryscore


        Dim componentescorebalance As Integer
        Dim standardscorebalance As Integer
        Dim percentilbalance As Double

        componentescorebalance = Twobordbalanceep.Value + Walkingheelsbackep.Value + Zigzaghoppep.Value

        Select Case componentescorebalance
            Case <= 8
                standardscorebalance = 2
            Case 9 To 10
                standardscorebalance = 3
            Case 11 To 12
                standardscorebalance = 4
            Case 13 To 14
                standardscorebalance = 5
            Case 15 To 18
                standardscorebalance = 6
            Case 19 To 22
                standardscorebalance = 7
            Case 23 To 24
                standardscorebalance = 8
            Case 25 To 27
                standardscorebalance = 9
            Case 28 To 30
                standardscorebalance = 10
            Case 31 To 32
                standardscorebalance = 11
            Case 33 To 34
                standardscorebalance = 12
            Case 35
                standardscorebalance = 12
            Case 36
                standardscorebalance = 14
            Case 37
                standardscorebalance = 15
            Case 38 To 39
                standardscorebalance = 16
            Case 40 To 41
                standardscorebalance = 17
            Case 42 To 43
                standardscorebalance = 18
            Case >= 44
                standardscorebalance = 19

        End Select

        Select Case componentescorebalance
            Case <= 8
                percentilbalance = 0.1
            Case 9 To 10
                percentilbalance = 0.5
            Case 11 To 12
                percentilbalance = 1
            Case 13 To 14
                percentilbalance = 2
            Case 15 To 18
                percentilbalance = 5
            Case 19 To 22
                percentilbalance = 9
            Case 23 To 24
                percentilbalance = 16
            Case 25 To 27
                percentilbalance = 25
            Case 28 To 30
                percentilbalance = 37
            Case 31 To 32
                percentilbalance = 50
            Case 33 To 34
                percentilbalance = 63
            Case 35
                percentilbalance = 75
            Case 36
                percentilbalance = 91
            Case 37
                percentilbalance = 95
            Case 38 To 39
                percentilbalance = 98
            Case 40 To 41
                percentilbalance = 99
            Case 42 To 43
                percentilbalance = 99.5
            Case >= 44
                percentilbalance = 99.9

        End Select

        componentscoreBA.Text = componentescorebalance
        standardscoreBA.Text = standardscorebalance
        percentilBA.Text = percentilbalance

        Dim totalescore As Integer
        Dim standardscoretotal As Integer
        Dim totalpercentile As Double

        totalescore = componentescoreaimingcatching + componentescorebalance + componentmanualdextery
        somatoriopadraoMDACBA.Value = totalescore

        Select Case totalescore
            Case <= 29
                standardscoretotal = 1
            Case 30 To 37
                standardscoretotal = 2
            Case 38 To 43
                standardscoretotal = 3
            Case 44 To 49
                standardscoretotal = 4
            Case 50 To 56
                standardscoretotal = 5
            Case 57 To 62
                standardscoretotal = 6
            Case 63 To 67
                standardscoretotal = 7
            Case 68 To 72
                standardscoretotal = 8
            Case 73 To 77
                standardscoretotal = 9
            Case 78 To 81
                standardscoretotal = 10
            Case 82 To 85
                standardscoretotal = 11
            Case 86 To 89
                standardscoretotal = 12
            Case 90 To 92
                standardscoretotal = 12
            Case 93 To 95
                standardscoretotal = 14
            Case 96 To 98
                standardscoretotal = 15
            Case 99 To 101
                standardscoretotal = 16
            Case 102 To 104
                standardscoretotal = 17
            Case 105 To 107
                standardscoretotal = 18
            Case >= 108
                standardscoretotal = 19
        End Select

        Select Case totalescore
            Case <= 29
                totalpercentile = 0.1
            Case 30 To 37
                totalpercentile = 0.5
            Case 38 To 43
                totalpercentile = 1
            Case 44 To 49
                totalpercentile = 2
            Case 50 To 56
                totalpercentile = 5
            Case 57 To 62
                totalpercentile = 9
            Case 63 To 67
                totalpercentile = 16
            Case 68 To 72
                totalpercentile = 25
            Case 73 To 77
                totalpercentile = 37
            Case 78 To 81
                totalpercentile = 50
            Case 82 To 85
                totalpercentile = 63
            Case 86 To 89
                totalpercentile = 75
            Case 90 To 92
                totalpercentile = 84
            Case 93 To 95
                totalpercentile = 91
            Case 96 To 98
                totalpercentile = 95
            Case 99 To 101
                totalpercentile = 98
            Case 102 To 104
                totalpercentile = 99
            Case 105 To 107
                totalpercentile = 99.5
            Case >= 108
                totalpercentile = 99.9
        End Select

        somastandardscoretotal.Text = standardscoretotal
        percentiltotal.Text = totalpercentile

        Select Case totalpercentile
            Case 0 To 5.99
                resultMabc.Text = "The child showed a significant difficulty of movement."
            Case 6.0 To 15.99
                resultMabc.Text = "The child showed to be at risk of significant difficulty of movement."
            Case 16.0 To 100
                resultMabc.Text = "The child do not showed a significant difficulty of movement."
        End Select

        If (Band3_Codigo.Value = 0) Then

            btnSave.Visible = True
        Else
            BtnSaveEdit.Visible = True
        End If

        GroupBox1.Enabled = False

        Calculatebutton.Visible = False

        backCalculateBtm.Visible = True

        DateTimePicker1.Enabled = False

        SchoolCbx.Enabled = False

        administerCbx.Enabled = False

        btnNewSchool.Enabled = False

        btnNewAdm.Enabled = False

    End Sub

    Private Sub printpageBtm_Click(sender As Object, e As EventArgs) Handles printpageBtm.Click
        Dim appAccess As Object

        ' Funções para adiquirir a pasta atual da aplicação
        Dim pastaEXE As String
        Dim arquivoDB As String

        pastaEXE = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase) 'usa a função do VB para buscar o nome do diretório do aplicativo em execução
        pastaEXE = New Uri(pastaEXE).LocalPath 'Transforma em uma String compreensivel ao Explorer
        arquivoDB = pastaEXE & "\Banco de dados.accdb" 'Adiciona o nome do arquivo de banco de dados

        appAccess = CreateObject("Access.Application")
        appAccess.visible = True
        appAccess.opencurrentdatabase(arquivoDB)

        'Filtros

        Dim filtro As String

        filtro = "[Band3_codigo] = " & Band3_Codigo.Value

        appAccess.docmd.openreport(ReportName:="Band3", View:=Access.AcView.acViewPreview, WhereCondition:=filtro)

    End Sub

    Private Sub backCalculateBtm_Click(sender As Object, e As EventArgs) Handles backCalculateBtm.Click

        btnSave.Visible = False

        BtnSaveEdit.Visible = False

        printpageBtm.Visible = False

        GroupBox1.Enabled = True

        Calculatebutton.Visible = True

        backCalculateBtm.Visible = False

        DateTimePicker1.Enabled = True

        SchoolCbx.Enabled = True

        administerCbx.Enabled = True

        btnNewAdm.Enabled = True

        btnNewSchool.Enabled = True

    End Sub
End Class