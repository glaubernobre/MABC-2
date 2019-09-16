Imports Microsoft.Office.Interop

Public Class Formulario_Banda_1
    Dim Dateborn As Date
    Dim Dateassessment As Date
    Dim Datet As TimeSpan
    Dim Diff As Double

    Public Property date_assesment As Date

    Public Property codigo_edit As Integer = 0

    Public Property child_id As Integer

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            PostcoinsprefehandsNumericUpDown.Value = -1
            PostcoinsprefehandsNumericUpDown.Enabled = False
        Else
            PostcoinsprefehandsNumericUpDown.Enabled = True
        End If
        HabilitaCalculo()
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            PostcoinsnonphandsNumericUpDown.Value = -1
            PostcoinsnonphandsNumericUpDown.Enabled = False
        Else
            PostcoinsnonphandsNumericUpDown.Enabled = True
        End If
        HabilitaCalculo()
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged

        If CheckBox3.Checked = True Then
            TheradbeadsNumericUpDown.Value = -1
            TheradbeadsNumericUpDown.Enabled = False
        Else
            TheradbeadsNumericUpDown.Enabled = True
        End If
        HabilitaCalculo()
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            Drawl1NumericUpDown.Value = -1
            Drawl1NumericUpDown.Enabled = False
        Else
            Drawl1NumericUpDown.Enabled = True
        End If
        HabilitaCalculo()
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            WalkingheelsNumericUpDown.Value = 15
            WalkingheelsNumericUpDown.Enabled = False
        Else
            WalkingheelsNumericUpDown.Value = -1
            WalkingheelsNumericUpDown.Enabled = True
        End If
    End Sub

    Private Sub JumponmatsNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles JumponmatsNumericUpDown.ValueChanged
        HabilitaCalculo()

        Dim scorebruto As Integer
        Dim idadecalculada As Double
        Dim valor As Integer

        valor = JumponmatsNumericUpDown.Value

        Dateborn = DateTimePicker2.Value.ToShortDateString
        Dateassessment = DateTimePicker1.Value.ToShortDateString
        Datet = (Dateassessment - Dateborn)
        Diff = Datet.Days
        idadecalculada = Diff / 365

        Select Case idadecalculada

            Case 3 To 3.49
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

            Case 3.5 To 3.99
                Select Case valor
                    Case 0
                        scorebruto = 3
                    Case 1
                        scorebruto = 4
                    Case 2
                        scorebruto = 5
                    Case 3
                        scorebruto = 6
                    Case 4
                        scorebruto = 8
                    Case 5
                        scorebruto = 12
                End Select

            Case 4.0 To 4.49
                Select Case valor
                    Case 0
                        scorebruto = 2
                    Case = 1
                        scorebruto = 3
                    Case = 2
                        scorebruto = 3
                    Case 3
                        scorebruto = 4
                    Case 4
                        scorebruto = 6
                    Case 5
                        scorebruto = 12
                End Select

            Case 4.5 To 4.99
                Select Case valor
                    Case 0
                        scorebruto = 1
                    Case = 1
                        scorebruto = 3
                    Case = 2
                        scorebruto = 3
                    Case 3
                        scorebruto = 4
                    Case 4
                        scorebruto = 6
                    Case 5
                        scorebruto = 12
                End Select

            Case 5.0 To 5.99
                Select Case valor
                    Case 0
                        scorebruto = 1
                    Case = 1
                        scorebruto = 3
                    Case = 2
                        scorebruto = 3
                    Case 3
                        scorebruto = 4
                    Case 4
                        scorebruto = 6
                    Case 5
                        scorebruto = 12
                End Select

            Case 6.0 To 6.99
                Select Case valor
                    Case = 0
                        scorebruto = 1
                    Case = 1
                        scorebruto = 1
                    Case = 2
                        scorebruto = 1
                    Case = 3
                        scorebruto = 2
                    Case 4
                        scorebruto = 6
                    Case 5
                        scorebruto = 11
                End Select
        End Select
        jumponmatsep.Value = scorebruto
        'Label2.Text = scorebruto

    End Sub
    Private Sub CalculaIdade()
        Dateborn = DateTimePicker2.Value.ToShortDateString
        Dateassessment = DateTimePicker1.Value.ToShortDateString
        Datet = (Dateassessment - Dateborn)
        Diff = Datet.Days
        Label3.Text = (Str(Int(Diff / 365)) + " years,")
        Diff = Diff Mod 365
        Label3.Text = Label3.Text + (Str(Int(Diff / 30)) + " month(s)")
        Diff = Diff Mod 30

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        CalculaIdade()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub WalkingheelsNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles WalkingheelsNumericUpDown.ValueChanged
        HabilitaCalculo()

        Dim scorebruto As Integer
        Dim idadecalculada As Double
        Dim valor As Integer

        valor = WalkingheelsNumericUpDown.Value

        Dateborn = DateTimePicker2.Value.ToShortDateString
        Dateassessment = DateTimePicker1.Value.ToShortDateString
        Datet = (Dateassessment - Dateborn)
        Diff = Datet.Days
        idadecalculada = Diff / 365

        Select Case idadecalculada

            Case 3 To 3.49
                Select Case valor
                    Case 0
                        scorebruto = 5
                    Case 1
                        scorebruto = 5
                    Case 2
                        scorebruto = 6
                    Case 3
                        scorebruto = 7
                    Case 4 To 5
                        scorebruto = 8
                    Case 6
                        scorebruto = 9
                    Case 7
                        scorebruto = 11
                    Case 8 To 9
                        scorebruto = 12
                    Case 10 To 11
                        scorebruto = 13
                    Case 12 To 14
                        scorebruto = 14
                    Case >= 15
                        scorebruto = 17
                End Select

            Case 3.5 To 3.99
                Select Case valor
                    Case 0 To 2
                        scorebruto = 5
                    Case 3
                        scorebruto = 6
                    Case 4 To 5
                        scorebruto = 7
                    Case 6
                        scorebruto = 8
                    Case 7 To 11
                        scorebruto = 9
                    Case 12 To 13
                        scorebruto = 11
                    Case 14
                        scorebruto = 12
                    Case 15
                        scorebruto = 13
                End Select

            Case 4.0 To 4.49
                Select Case valor
                    Case 0 To 1
                        scorebruto = 3
                    Case 2
                        scorebruto = 4
                    Case 3
                        scorebruto = 6
                    Case 4 To 5
                        scorebruto = 7
                    Case 6 To 8
                        scorebruto = 8
                    Case 9 To 13
                        scorebruto = 9
                    Case 14
                        scorebruto = 10
                    Case 15
                        scorebruto = 13
                End Select

            Case 4.5 To 4.99
                Select Case valor
                    Case 0 To 1
                        scorebruto = 3
                    Case 2 To 5
                        scorebruto = 4
                    Case 6
                        scorebruto = 5
                    Case 7
                        scorebruto = 7
                    Case 8 To 10
                        scorebruto = 8
                    Case 11 To 13
                        scorebruto = 9
                    Case 14
                        scorebruto = 10
                    Case 15
                        scorebruto = 13
                End Select

            Case 5.0 To 5.99
                Select Case valor
                    Case 0 To 1
                        scorebruto = 1
                    Case 2
                        scorebruto = 2
                    Case 3 To 4
                        scorebruto = 3
                    Case 5 To 6
                        scorebruto = 4
                    Case 7 To 10
                        scorebruto = 5
                    Case 11 To 12
                        scorebruto = 6
                    Case 13
                        scorebruto = 8
                    Case 14
                        scorebruto = 10
                    Case 15
                        scorebruto = 12
                End Select

            Case 6.0 To 6.99
                Select Case valor
                    Case 0 To 5
                        scorebruto = 1
                    Case 6 To 8
                        scorebruto = 4
                    Case 9 To 10
                        scorebruto = 5
                    Case 11 To 12
                        scorebruto = 6
                    Case 13
                        scorebruto = 8
                    Case 14
                        scorebruto = 10
                    Case 15
                        scorebruto = 11
                End Select
        End Select
        walkheelsraisedep.Value = scorebruto
    End Sub

    Private Sub OnebalanceotherlegNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles OnebalanceotherlegNumericUpDown.ValueChanged
        HabilitaCalculo()

        Dim scorebruto As Integer
        Dim idadecalculada As Double
        Dim valor As Integer

        valor = OnebalanceotherlegNumericUpDown.Value

        Dateborn = DateTimePicker2.Value.ToShortDateString
        Dateassessment = DateTimePicker1.Value.ToShortDateString
        Datet = (Dateassessment - Dateborn)
        Diff = Datet.Days
        idadecalculada = Diff / 365

        Select Case idadecalculada

            Case 3 To 3.49
                Select Case valor
                    Case 0
                        scorebruto = 5
                    Case 1
                        scorebruto = 7
                    Case 2
                        scorebruto = 9
                    Case 3
                        scorebruto = 11
                    Case 4
                        scorebruto = 12
                    Case 5
                        scorebruto = 13
                    Case 6 To 8
                        scorebruto = 14
                    Case 9
                        scorebruto = 15
                    Case 10
                        scorebruto = 16
                    Case 11 To 30
                        scorebruto = 19
                End Select

            Case 3.5 To 3.99
                Select Case valor
                    Case 0
                        scorebruto = 5
                    Case 1
                        scorebruto = 7
                    Case 2
                        scorebruto = 8
                    Case 3 To 4
                        scorebruto = 11
                    Case 5
                        scorebruto = 12
                    Case 6
                        scorebruto = 13
                    Case 7 To 8
                        scorebruto = 14
                    Case 9 To 11
                        scorebruto = 15
                    Case 12
                        scorebruto = 16
                    Case 13 To 14
                        scorebruto = 17
                    Case 15 To 30
                        scorebruto = 19
                End Select

            Case 4.0 To 4.49
                Select Case valor
                    Case 0 To 1
                        scorebruto = 6
                    Case 2
                        scorebruto = 7
                    Case 3
                        scorebruto = 8
                    Case 4 To 5
                        scorebruto = 10
                    Case 6 To 7
                        scorebruto = 11
                    Case 8 To 10
                        scorebruto = 12
                    Case 11 To 12
                        scorebruto = 13
                    Case 13 To 17
                        scorebruto = 14
                    Case 18 To 23
                        scorebruto = 15
                    Case 24 To 25
                        scorebruto = 17
                    Case 26 To 30
                        scorebruto = 19
                End Select

            Case 4.5 To 4.99
                Select Case valor
                    Case 0 To 1
                        scorebruto = 3
                    Case 2
                        scorebruto = 6
                    Case 3
                        scorebruto = 7
                    Case 4 To 5
                        scorebruto = 8
                    Case 6 To 8
                        scorebruto = 9
                    Case 9 To 12
                        scorebruto = 10
                    Case 13 To 14
                        scorebruto = 11
                    Case 15 To 16
                        scorebruto = 12
                    Case 17 To 19
                        scorebruto = 13
                    Case 20 To 26
                        scorebruto = 14
                    Case 27 To 28
                        scorebruto = 15
                    Case 29 To 30
                        scorebruto = 18
                End Select

            Case 5.0 To 5.99
                Select Case valor
                    Case 0 To 1
                        scorebruto = 3
                    Case 2
                        scorebruto = 5
                    Case 3
                        scorebruto = 6
                    Case 4
                        scorebruto = 7
                    Case 5 To 6
                        scorebruto = 8
                    Case 7 To 9
                        scorebruto = 9
                    Case 10 To 13
                        scorebruto = 10
                    Case 14 To 15
                        scorebruto = 11
                    Case 16 To 20
                        scorebruto = 12
                    Case 21 To 24
                        scorebruto = 13
                    Case 25 To 26
                        scorebruto = 14
                    Case 27 To 30
                        scorebruto = 15
                End Select

            Case 6.0 To 6.99
                Select Case valor
                    Case 0 To 1
                        scorebruto = 3
                    Case 2
                        scorebruto = 5
                    Case 3
                        scorebruto = 6
                    Case 4 To 6
                        scorebruto = 7
                    Case 7 To 13
                        scorebruto = 8
                    Case 14 To 17
                        scorebruto = 9
                    Case 18 To 23
                        scorebruto = 10
                    Case 24 To 28
                        scorebruto = 11
                    Case 29 To 30
                        scorebruto = 14
                End Select
        End Select
        Onebalanceotherlegep.Value = scorebruto

    End Sub

    Private Sub OnelegbalancebestlegNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles OnelegbalancebestlegNumericUpDown.ValueChanged
        HabilitaCalculo()

        Dim scorebruto As Integer
        Dim idadecalculada As Double
        Dim valor As Integer

        valor = OnelegbalancebestlegNumericUpDown.Value

        Dateborn = DateTimePicker2.Value.ToShortDateString
        Dateassessment = DateTimePicker1.Value.ToShortDateString
        Datet = (Dateassessment - Dateborn)
        Diff = Datet.Days
        idadecalculada = Diff / 365

        Select Case idadecalculada

            Case 3 To 3.49
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
                        scorebruto = 10
                    Case 5
                        scorebruto = 11
                    Case 6
                        scorebruto = 12
                    Case 7 To 8
                        scorebruto = 13
                    Case 9 To 13
                        scorebruto = 14
                    Case 14
                        scorebruto = 15
                    Case 15 To 16
                        scorebruto = 16
                    Case 17 To 30
                        scorebruto = 19
                End Select

            Case 3.5 To 3.99
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
                        scorebruto = 10
                    Case 5 To 6
                        scorebruto = 11
                    Case 7 To 9
                        scorebruto = 12
                    Case 10 To 13
                        scorebruto = 13
                    Case 14 To 17
                        scorebruto = 14
                    Case 18 To 19
                        scorebruto = 15
                    Case 20
                        scorebruto = 16
                    Case 21 To 23
                        scorebruto = 17
                    Case 24 To 30
                        scorebruto = 19
                End Select

            Case 4.0 To 4.49
                Select Case valor
                    Case 0
                        scorebruto = 4
                    Case 1
                        scorebruto = 5
                    Case 2 To 3
                        scorebruto = 6
                    Case 4
                        scorebruto = 7
                    Case 5
                        scorebruto = 8
                    Case 6 To 7
                        scorebruto = 9
                    Case 8
                        scorebruto = 10
                    Case 9 To 10
                        scorebruto = 11
                    Case 11 To 14
                        scorebruto = 12
                    Case 15 To 18
                        scorebruto = 13
                    Case 19 To 26
                        scorebruto = 14
                    Case 27 To 30
                        scorebruto = 16
                End Select

            Case 4.5 To 4.99
                Select Case valor
                    Case 0 To 2
                        scorebruto = 4
                    Case 3
                        scorebruto = 5
                    Case 4 To 5
                        scorebruto = 6
                    Case 6 To 7
                        scorebruto = 7
                    Case 8 To 9
                        scorebruto = 8
                    Case 10 To 13
                        scorebruto = 9
                    Case 14 To 17
                        scorebruto = 10
                    Case 18 To 21
                        scorebruto = 11
                    Case 22 To 25
                        scorebruto = 12
                    Case 26 To 28
                        scorebruto = 13
                    Case 29
                        scorebruto = 14
                    Case 30
                        scorebruto = 15
                End Select

            Case 5.0 To 5.99
                Select Case valor
                    Case 0 To 3
                        scorebruto = 3
                    Case 4
                        scorebruto = 4
                    Case 5
                        scorebruto = 6
                    Case 6 To 7
                        scorebruto = 7
                    Case 8 To 10
                        scorebruto = 8
                    Case 11 To 14
                        scorebruto = 9
                    Case 15 To 20
                        scorebruto = 10
                    Case 21 To 29
                        scorebruto = 11
                    Case 30
                        scorebruto = 14
                End Select

            Case 6.0 To 6.99
                Select Case valor
                    Case 0 To 3
                        scorebruto = 3
                    Case 4 To 5
                        scorebruto = 4
                    Case 6
                        scorebruto = 5
                    Case 7 To 10
                        scorebruto = 6
                    Case 11 To 14
                        scorebruto = 7
                    Case 15 To 23
                        scorebruto = 8
                    Case 24 To 27
                        scorebruto = 9
                    Case 28 To 29
                        scorebruto = 10
                    Case 30
                        scorebruto = 13
                End Select
        End Select
        Onelegbalancebestlegep.Value = scorebruto
    End Sub

    Private Sub ThrowingbeanNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles ThrowingbeanNumericUpDown.ValueChanged
        HabilitaCalculo()

        Dim scorebruto As Integer
        Dim idadecalculada As Double
        Dim valor As Integer

        valor = ThrowingbeanNumericUpDown.Value

        Dateborn = DateTimePicker2.Value.ToShortDateString
        Dateassessment = DateTimePicker1.Value.ToShortDateString
        Datet = (Dateassessment - Dateborn)
        Diff = Datet.Days
        idadecalculada = Diff / 365

        Select Case idadecalculada

            Case 3 To 3.49
                Select Case valor
                    Case 0
                        scorebruto = 6
                    Case 1
                        scorebruto = 7
                    Case 2
                        scorebruto = 8
                    Case 3
                        scorebruto = 9
                    Case 4
                        scorebruto = 11
                    Case 5
                        scorebruto = 14
                    Case 6
                        scorebruto = 15
                    Case 7 To 10
                        scorebruto = 19
                End Select

            Case 3.5 To 3.99
                Select Case valor
                    Case 0
                        scorebruto = 5
                    Case 1
                        scorebruto = 7
                    Case 2
                        scorebruto = 8
                    Case 3
                        scorebruto = 9
                    Case 4
                        scorebruto = 11
                    Case 5
                        scorebruto = 12
                    Case 6
                        scorebruto = 14
                    Case 7
                        scorebruto = 15
                    Case 8
                        scorebruto = 17
                    Case 9 To 10
                        scorebruto = 19
                End Select

            Case 4.0 To 4.49
                Select Case valor
                    Case 0
                        scorebruto = 5
                    Case 1
                        scorebruto = 6
                    Case 2
                        scorebruto = 7
                    Case 3
                        scorebruto = 8
                    Case 4
                        scorebruto = 9
                    Case 5
                        scorebruto = 11
                    Case 6
                        scorebruto = 12
                    Case 7
                        scorebruto = 14
                    Case 8
                        scorebruto = 17
                    Case 9 To 10
                        scorebruto = 19
                End Select

            Case 4.5 To 4.99
                Select Case valor
                    Case 0
                        scorebruto = 4
                    Case 1 To 2
                        scorebruto = 6
                    Case 3
                        scorebruto = 7
                    Case 4
                        scorebruto = 8
                    Case 5
                        scorebruto = 10
                    Case 6
                        scorebruto = 12
                    Case 7
                        scorebruto = 13
                    Case 8
                        scorebruto = 14
                    Case 9
                        scorebruto = 17
                    Case 10
                        scorebruto = 19
                End Select

            Case 5.0 To 5.99
                Select Case valor
                    Case 0
                        scorebruto = 1
                    Case 1
                        scorebruto = 3
                    Case 2
                        scorebruto = 4
                    Case 3
                        scorebruto = 5
                    Case 4
                        scorebruto = 8
                    Case 5
                        scorebruto = 10
                    Case 6
                        scorebruto = 11
                    Case 7
                        scorebruto = 12
                    Case 8
                        scorebruto = 13
                    Case 9
                        scorebruto = 14
                    Case 10
                        scorebruto = 19
                End Select

            Case 6.0 To 6.99
                Select Case valor
                    Case 0
                        scorebruto = 1
                    Case 1
                        scorebruto = 3
                    Case 2
                        scorebruto = 4
                    Case 3
                        scorebruto = 5
                    Case 4
                        scorebruto = 7
                    Case 5
                        scorebruto = 8
                    Case 6
                        scorebruto = 9
                    Case 7
                        scorebruto = 11
                    Case 8
                        scorebruto = 13
                    Case 9
                        scorebruto = 14
                    Case 10
                        scorebruto = 16
                End Select
        End Select
        Throwingbeanep.Value = scorebruto
    End Sub

    Private Sub CathbeangNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles CathbeangNumericUpDown.ValueChanged
        HabilitaCalculo()

        Dim scorebruto As Integer
        Dim idadecalculada As Double
        Dim valor As Integer

        valor = CathbeangNumericUpDown.Value

        Dateborn = DateTimePicker2.Value.ToShortDateString
        Dateassessment = DateTimePicker1.Value.ToShortDateString
        Datet = (Dateassessment - Dateborn)
        Diff = Datet.Days
        idadecalculada = Diff / 365

        Select Case idadecalculada

            Case 3 To 3.49
                Select Case valor
                    Case 0
                        scorebruto = 5
                    Case 1
                        scorebruto = 6
                    Case 2
                        scorebruto = 7
                    Case 3
                        scorebruto = 8
                    Case 4
                        scorebruto = 9
                    Case 5
                        scorebruto = 11
                    Case 6
                        scorebruto = 12
                    Case 7
                        scorebruto = 15
                    Case 8 To 10
                        scorebruto = 19
                End Select

            Case 3.5 To 3.99
                Select Case valor
                    Case 0
                        scorebruto = 3
                    Case 1
                        scorebruto = 4
                    Case 2
                        scorebruto = 5
                    Case 3
                        scorebruto = 6
                    Case 4
                        scorebruto = 7
                    Case 5
                        scorebruto = 8
                    Case 6
                        scorebruto = 10
                    Case 7 To 8
                        scorebruto = 12
                    Case 9
                        scorebruto = 15
                    Case 10
                        scorebruto = 19
                End Select

            Case 4.0 To 4.49
                Select Case valor
                    Case 0
                        scorebruto = 3
                    Case 1
                        scorebruto = 4
                    Case 2
                        scorebruto = 5
                    Case 3
                        scorebruto = 6
                    Case 4
                        scorebruto = 7
                    Case 5
                        scorebruto = 8
                    Case 6
                        scorebruto = 9
                    Case 7
                        scorebruto = 10
                    Case 8
                        scorebruto = 11
                    Case 9
                        scorebruto = 12
                    Case 10
                        scorebruto = 17
                End Select

            Case 4.5 To 4.99
                Select Case valor
                    Case 0 To 3
                        scorebruto = 3
                    Case 4
                        scorebruto = 5
                    Case 5
                        scorebruto = 7
                    Case 6
                        scorebruto = 8
                    Case 7
                        scorebruto = 9
                    Case 8
                        scorebruto = 10
                    Case 9
                        scorebruto = 12
                    Case 10
                        scorebruto = 16
                End Select

            Case 5.0 To 5.99
                Select Case valor
                    Case 0 To 1
                        scorebruto = 5
                    Case 2 To 3
                        scorebruto = 7
                    Case 4 To 5
                        scorebruto = 8
                    Case 6 To 7
                        scorebruto = 9
                    Case 8
                        scorebruto = 10
                    Case 9
                        scorebruto = 12
                    Case 10
                        scorebruto = 16
                End Select

            Case 6.0 To 6.99
                Select Case valor
                    Case 0 To 2
                        scorebruto = 3
                    Case 3
                        scorebruto = 4
                    Case 4
                        scorebruto = 5
                    Case 5
                        scorebruto = 6
                    Case 6 To 7
                        scorebruto = 7
                    Case 8
                        scorebruto = 8
                    Case 9
                        scorebruto = 9
                    Case 10
                        scorebruto = 14
                End Select
        End Select
        Cathbeangep.Value = scorebruto
    End Sub

    Private Sub Drawl1NumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles Drawl1NumericUpDown.ValueChanged
        HabilitaCalculo()

        Dim scorebruto As Integer
        Dim idadecalculada As Double
        Dim valor As Integer

        valor = Drawl1NumericUpDown.Value

        Dateborn = DateTimePicker2.Value.ToShortDateString
        Dateassessment = DateTimePicker1.Value.ToShortDateString
        Datet = (Dateassessment - Dateborn)
        Diff = Datet.Days
        idadecalculada = Diff / 365

        Select Case idadecalculada

            Case 3 To 3.49
                Select Case valor
                    Case 0 To 1
                        scorebruto = 16
                    Case 2
                        scorebruto = 14
                    Case 3
                        scorebruto = 13
                    Case 4
                        scorebruto = 12
                    Case 5
                        scorebruto = 11
                    Case 6
                        scorebruto = 10
                    Case 7 To 8
                        scorebruto = 9
                    Case 9
                        scorebruto = 8
                    Case 10 To 11
                        scorebruto = 7
                    Case 12 To 14
                        scorebruto = 6
                    Case 15
                        scorebruto = 5
                    Case 16 To 17
                        scorebruto = 5
                    Case > 17
                        scorebruto = 1
                End Select

            Case 3.5 To 3.99
                Select Case valor
                    Case 0
                        scorebruto = 14
                    Case 1 To 2
                        scorebruto = 13
                    Case 3 To 4
                        scorebruto = 12
                    Case 5
                        scorebruto = 11
                    Case 6
                        scorebruto = 10
                    Case 7
                        scorebruto = 9
                    Case 8
                        scorebruto = 8
                    Case 9
                        scorebruto = 7
                    Case 10 To 12
                        scorebruto = 6
                    Case 13 To 15
                        scorebruto = 5
                    Case 16 To 17
                        scorebruto = 4
                    Case > 17
                        scorebruto = 1
                End Select

            Case 4.0 To 4.49
                Select Case valor
                    Case 0
                        scorebruto = 13
                    Case 1
                        scorebruto = 12
                    Case 2
                        scorebruto = 11
                    Case 3 To 4
                        scorebruto = 10
                    Case 5 To 6
                        scorebruto = 9
                    Case 7 To 8
                        scorebruto = 8
                    Case 9
                        scorebruto = 7
                    Case 10 To 12
                        scorebruto = 6
                    Case 13 To 14
                        scorebruto = 5
                    Case 15 To 17
                        scorebruto = 4
                    Case > 17
                        scorebruto = 1
                End Select

            Case 4.5 To 4.99
                Select Case valor
                    Case 0
                        scorebruto = 13
                    Case 1
                        scorebruto = 12
                    Case 2
                        scorebruto = 9
                    Case 3
                        scorebruto = 7
                    Case 4
                        scorebruto = 6
                    Case 5
                        scorebruto = 4
                    Case 6
                        scorebruto = 3
                    Case > 6
                        scorebruto = 1
                End Select

            Case 5.0 To 5.99
                Select Case valor
                    Case 0 To 1
                        scorebruto = 11
                    Case 2
                        scorebruto = 9
                    Case 3
                        scorebruto = 4
                    Case 4
                        scorebruto = 3
                    Case > 4
                        scorebruto = 1
                End Select

            Case 6.0 To 6.99
                Select Case valor
                    Case 0
                        scorebruto = 11
                    Case 1
                        scorebruto = 7
                    Case 2
                        scorebruto = 3
                    Case > 2
                        scorebruto = 1
                End Select
        End Select
        If valor = -1 Then
            scorebruto = 1
        End If
        Drawl1ep.Value = scorebruto
    End Sub

    Private Sub TheradbeadsNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles TheradbeadsNumericUpDown.ValueChanged
        HabilitaCalculo()

        Dim scorebruto As Integer
        Dim idadecalculada As Double
        Dim valor As Integer

        valor = TheradbeadsNumericUpDown.Value

        Dateborn = DateTimePicker2.Value.ToShortDateString
        Dateassessment = DateTimePicker1.Value.ToShortDateString
        Datet = (Dateassessment - Dateborn)
        Diff = Datet.Days
        idadecalculada = Diff / 365

        Select Case idadecalculada

            Case 3 To 3.49
                Select Case valor
                    Case <= 26
                        scorebruto = 16
                    Case 27 To 32
                        scorebruto = 15
                    Case 33 To 35
                        scorebruto = 14
                    Case 36 To 40
                        scorebruto = 13
                    Case 41 To 47
                        scorebruto = 12
                    Case 48 To 52
                        scorebruto = 11
                    Case 53 To 56
                        scorebruto = 10
                    Case 57 To 65
                        scorebruto = 9
                    Case 66 To 70
                        scorebruto = 8
                    Case 71 To 78
                        scorebruto = 7
                    Case 79 To 83
                        scorebruto = 6
                    Case 84 To 87
                        scorebruto = 5
                    Case 88 To 96
                        scorebruto = 4
                    Case >= 97
                        scorebruto = 1
                End Select

            Case 3.5 To 3.99
                Select Case valor
                    Case <= 23
                        scorebruto = 15
                    Case 24 To 28
                        scorebruto = 14
                    Case 29 To 35
                        scorebruto = 13
                    Case 36 To 38
                        scorebruto = 12
                    Case 39 To 40
                        scorebruto = 11
                    Case 41 To 47
                        scorebruto = 10
                    Case 48 To 56
                        scorebruto = 9
                    Case 57 To 65
                        scorebruto = 8
                    Case 66 To 73
                        scorebruto = 7
                    Case 74 To 78
                        scorebruto = 6
                    Case 79 To 81
                        scorebruto = 5
                    Case 82 To 96
                        scorebruto = 4
                    Case >= 97
                        scorebruto = 1
                End Select

            Case 4.0 To 4.49
                Select Case valor
                    Case <= 21
                        scorebruto = 15
                    Case 22 To 24
                        scorebruto = 14
                    Case 25 To 26
                        scorebruto = 13
                    Case 27 To 29
                        scorebruto = 12
                    Case 30 To 31
                        scorebruto = 11
                    Case 32 To 36
                        scorebruto = 10
                    Case 37 To 39
                        scorebruto = 9
                    Case 40 To 48
                        scorebruto = 8
                    Case 49 To 55
                        scorebruto = 7
                    Case 56 To 63
                        scorebruto = 6
                    Case 64 To 77
                        scorebruto = 5
                    Case 78 To 79
                        scorebruto = 4
                    Case 80 To 86
                        scorebruto = 3
                    Case >= 87
                        scorebruto = 1
                End Select

            Case 4.5 To 4.99
                Select Case valor
                    Case <= 17
                        scorebruto = 15
                    Case 18 To 21
                        scorebruto = 14
                    Case 22 To 23
                        scorebruto = 13
                    Case 24 To 25
                        scorebruto = 12
                    Case 26 To 27
                        scorebruto = 11
                    Case 28 To 32
                        scorebruto = 10
                    Case 33 To 36
                        scorebruto = 9
                    Case 37 To 39
                        scorebruto = 8
                    Case 40 To 41
                        scorebruto = 7
                    Case 42 To 43
                        scorebruto = 6
                    Case 44 To 46
                        scorebruto = 5
                    Case 47 To 62
                        scorebruto = 4
                    Case 63
                        scorebruto = 3
                    Case >= 64
                        scorebruto = 1
                End Select

            Case 5.0 To 5.99
                Select Case valor
                    Case <= 24
                        scorebruto = 17
                    Case 25 To 29
                        scorebruto = 16
                    Case 30 To 35
                        scorebruto = 15
                    Case 36 To 38
                        scorebruto = 14
                    Case 39 To 40
                        scorebruto = 13
                    Case 41 To 43
                        scorebruto = 12
                    Case 44 To 47
                        scorebruto = 11
                    Case 48 To 49
                        scorebruto = 10
                    Case 50 To 53
                        scorebruto = 9
                    Case 54 To 55
                        scorebruto = 8
                    Case 56 To 60
                        scorebruto = 7
                    Case 61 To 66
                        scorebruto = 5
                    Case 67 To 96
                        scorebruto = 4
                    Case 97 To 121
                        scorebruto = 3
                    Case >= 122
                        scorebruto = 1
                End Select

            Case 6.0 To 6.99
                Select Case valor
                    Case <= 24
                        scorebruto = 17
                    Case 25 To 28
                        scorebruto = 16
                    Case 29 To 31
                        scorebruto = 15
                    Case 32 To 33
                        scorebruto = 14
                    Case 34 To 35
                        scorebruto = 13
                    Case 36 To 37
                        scorebruto = 12
                    Case 38 To 42
                        scorebruto = 11
                    Case 43 To 45
                        scorebruto = 10
                    Case 46 To 47
                        scorebruto = 9
                    Case 48 To 49
                        scorebruto = 8
                    Case 50 To 54
                        scorebruto = 7
                    Case 55 To 58
                        scorebruto = 6
                    Case 59 To 63
                        scorebruto = 5
                    Case 64
                        scorebruto = 4
                    Case 65 To 73
                        scorebruto = 3
                    Case >= 74
                        scorebruto = 1
                End Select
        End Select
        If valor = -1 Then
            scorebruto = 1
        End If
        Theradbeadsep.Value = scorebruto


    End Sub

    Private Sub PostcoinsnonphandsNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles PostcoinsnonphandsNumericUpDown.ValueChanged
        HabilitaCalculo()

        Dim scorebruto As Integer
        Dim idadecalculada As Double
        Dim valor As Integer

        valor = PostcoinsnonphandsNumericUpDown.Value

        Dateborn = DateTimePicker2.Value.ToShortDateString
        Dateassessment = DateTimePicker1.Value.ToShortDateString
        Datet = (Dateassessment - Dateborn)
        Diff = Datet.Days
        idadecalculada = Diff / 365

        Select Case idadecalculada

            Case 3 To 3.49
                Select Case valor
                    Case <= 9
                        scorebruto = 15
                    Case 10 To 11
                        scorebruto = 14
                    Case 12
                        scorebruto = 12
                    Case 13 To 14
                        scorebruto = 11
                    Case 15 To 16
                        scorebruto = 10
                    Case 17 To 18
                        scorebruto = 9
                    Case 19
                        scorebruto = 8
                    Case 20 To 21
                        scorebruto = 7
                    Case 22 To 23
                        scorebruto = 6
                    Case 24 To 28
                        scorebruto = 5
                    Case 29
                        scorebruto = 4
                    Case >= 30
                        scorebruto = 1
                End Select

            Case 3.5 To 3.99
                Select Case valor
                    Case <= 9
                        scorebruto = 15
                    Case 10
                        scorebruto = 13
                    Case 11 To 12
                        scorebruto = 12
                    Case 13
                        scorebruto = 11
                    Case 14
                        scorebruto = 10
                    Case 15
                        scorebruto = 9
                    Case 16
                        scorebruto = 8
                    Case 17 To 18
                        scorebruto = 7
                    Case 19 To 20
                        scorebruto = 6
                    Case 21
                        scorebruto = 5
                    Case 22
                        scorebruto = 4
                    Case 23 To 26
                        scorebruto = 3
                    Case >= 27
                        scorebruto = 1
                End Select

            Case 4.0 To 4.49
                Select Case valor
                    Case <= 8
                        scorebruto = 15
                    Case 9
                        scorebruto = 14
                    Case 10
                        scorebruto = 13
                    Case 11
                        scorebruto = 12
                    Case 12
                        scorebruto = 10
                    Case 13
                        scorebruto = 8
                    Case 14
                        scorebruto = 7
                    Case 15
                        scorebruto = 6
                    Case 16 To 19
                        scorebruto = 5
                    Case 20 To 21
                        scorebruto = 4
                    Case 22 To 25
                        scorebruto = 3
                    Case >= 26
                        scorebruto = 1
                End Select

            Case 4.5 To 4.99
                Select Case valor
                    Case <= 8
                        scorebruto = 15
                    Case 9
                        scorebruto = 13
                    Case 10
                        scorebruto = 12
                    Case 11
                        scorebruto = 10
                    Case 12
                        scorebruto = 9
                    Case 13
                        scorebruto = 8
                    Case 14
                        scorebruto = 6
                    Case 15
                        scorebruto = 5
                    Case 16
                        scorebruto = 4
                    Case 17 To 22
                        scorebruto = 3
                    Case >= 23
                        scorebruto = 1
                End Select

            Case 5.0 To 5.99
                Select Case valor
                    Case <= 11
                        scorebruto = 17
                    Case 12
                        scorebruto = 16
                    Case 13 To 15
                        scorebruto = 15
                    Case 16
                        scorebruto = 14
                    Case 17 To 18
                        scorebruto = 13
                    Case 19 To 20
                        scorebruto = 12
                    Case 21
                        scorebruto = 11
                    Case 22
                        scorebruto = 10
                    Case 23
                        scorebruto = 9
                    Case 24
                        scorebruto = 7
                    Case 25 To 26
                        scorebruto = 6
                    Case 27
                        scorebruto = 5
                    Case 28 To 29
                        scorebruto = 4
                    Case 30
                        scorebruto = 2
                    Case >= 23
                        scorebruto = 1
                End Select

            Case 6.0 To 6.99
                Select Case valor
                    Case <= 11
                        scorebruto = 17
                    Case 12
                        scorebruto = 16
                    Case 13 To 15
                        scorebruto = 15
                    Case 16
                        scorebruto = 14
                    Case 17
                        scorebruto = 13
                    Case 18
                        scorebruto = 12
                    Case 19
                        scorebruto = 11
                    Case 20
                        scorebruto = 9
                    Case 21
                        scorebruto = 7
                    Case 22 To 23
                        scorebruto = 6
                    Case 24 To 26
                        scorebruto = 5
                    Case 27
                        scorebruto = 4
                    Case >= 28
                        scorebruto = 1
                End Select
        End Select
        If valor = -1 Then
            scorebruto = 1
        End If
        Postcoinsnonphandsep.Value = scorebruto
    End Sub

    Private Sub PostcoinsprefehandsNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles PostcoinsprefehandsNumericUpDown.ValueChanged
        HabilitaCalculo()

        Dim scorebruto As Integer
        Dim idadecalculada As Double
        Dim valor As Integer

        valor = PostcoinsprefehandsNumericUpDown.Value

        Dateborn = DateTimePicker2.Value.ToShortDateString
        Dateassessment = DateTimePicker1.Value.ToShortDateString
        Datet = (Dateassessment - Dateborn)
        Diff = Datet.Days
        idadecalculada = Diff / 365

        Select Case idadecalculada

            Case 3 To 3.49
                Select Case valor
                    Case <= 9
                        scorebruto = 16
                    Case 10
                        scorebruto = 14
                    Case 11
                        scorebruto = 13
                    Case 12
                        scorebruto = 12
                    Case 13
                        scorebruto = 11
                    Case 14
                        scorebruto = 10
                    Case 15
                        scorebruto = 9
                    Case 16
                        scorebruto = 8
                    Case 17
                        scorebruto = 6
                    Case 18
                        scorebruto = 4
                    Case >= 19
                        scorebruto = 1
                End Select

            Case 3.5 To 3.99
                Select Case valor
                    Case <= 6
                        scorebruto = 16
                    Case 7 To 8
                        scorebruto = 15
                    Case 9
                        scorebruto = 13
                    Case 10
                        scorebruto = 12
                    Case 11
                        scorebruto = 11
                    Case 12
                        scorebruto = 10
                    Case 13
                        scorebruto = 9
                    Case 14
                        scorebruto = 8
                    Case 15
                        scorebruto = 7
                    Case 16
                        scorebruto = 6
                    Case 17
                        scorebruto = 5
                    Case 18
                        scorebruto = 4
                    Case >= 19
                        scorebruto = 1
                End Select

            Case 4.0 To 4.49
                Select Case valor
                    Case <= 6
                        scorebruto = 16
                    Case 7
                        scorebruto = 15
                    Case 8
                        scorebruto = 14
                    Case 9
                        scorebruto = 12
                    Case 10
                        scorebruto = 10
                    Case 11
                        scorebruto = 9
                    Case 12
                        scorebruto = 8
                    Case 13
                        scorebruto = 7
                    Case 14
                        scorebruto = 6
                    Case 15 To 16
                        scorebruto = 5
                    Case 17 To 18
                        scorebruto = 3
                    Case >= 19
                        scorebruto = 1
                End Select

            Case 4.5 To 4.99
                Select Case valor
                    Case <= 6
                        scorebruto = 16
                    Case 7
                        scorebruto = 15
                    Case 8
                        scorebruto = 14
                    Case 9
                        scorebruto = 11
                    Case 10
                        scorebruto = 10
                    Case 11
                        scorebruto = 9
                    Case 12
                        scorebruto = 7
                    Case 13 To 15
                        scorebruto = 5
                    Case 16
                        scorebruto = 3
                    Case >= 17
                        scorebruto = 1
                End Select

            Case 5.0 To 5.99
                Select Case valor
                    Case <= 9
                        scorebruto = 17
                    Case 10 To 12
                        scorebruto = 16
                    Case 13
                        scorebruto = 15
                    Case 14
                        scorebruto = 14
                    Case 15
                        scorebruto = 13
                    Case 16 To 17
                        scorebruto = 12
                    Case 18
                        scorebruto = 11
                    Case 19
                        scorebruto = 10
                    Case 20
                        scorebruto = 9
                    Case 21
                        scorebruto = 8
                    Case 22
                        scorebruto = 7
                    Case 23
                        scorebruto = 6
                    Case 24
                        scorebruto = 5
                    Case 25 To 26
                        scorebruto = 4
                    Case >= 27
                        scorebruto = 1
                End Select

            Case 6.0 To 6.99
                Select Case valor
                    Case <= 13
                        scorebruto = 15
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
                        scorebruto = 7
                    Case 21 To 22
                        scorebruto = 6
                    Case 23
                        scorebruto = 5
                    Case 24 To 25
                        scorebruto = 4
                    Case >= 26
                        scorebruto = 1
                End Select
        End Select
        If valor = -1 Then
            scorebruto = 1
        End If

        Postcoinsprefehandsep.Value = scorebruto
    End Sub

    Private Sub Calculatebutton_Click(sender As Object, e As EventArgs) Handles Calculatebutton.Click

        Dim postCoinsMedia As Double
        Dim postcoins As Integer

        postCoinsMedia = (Postcoinsprefehandsep.Value + Postcoinsnonphandsep.Value) / 2

        If postCoinsMedia > 10 Then
            postcoins = Math.Round(postCoinsMedia, 0)
        Else
            postcoins = postCoinsMedia 'Ao passar uma variavel Double para outra Integer, as casas decimais são suprimidas
        End If

        postcoinsep.Value = postcoins

        Dim oneBalanceLegmedia As Double
        Dim oneBalanceLegep As Integer

        oneBalanceLegmedia = (Onelegbalancebestlegep.Value + Onebalanceotherlegep.Value) / 2

        If oneBalanceLegmedia > 10 Then
            oneBalanceLegep = Math.Round(oneBalanceLegmedia)
        Else
            oneBalanceLegep = oneBalanceLegmedia
        End If

        onelegbalanceep.Value = oneBalanceLegep


        Dim componentescoreaimingcatching As Integer
        Dim stantardscoreAimingCatching As Integer
        Dim percentilaimingcatching As Double

        componentescoreaimingcatching = Throwingbeanep.Value + Cathbeangep.Value

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

        componentmanualdextery = Drawl1ep.Value + Theradbeadsep.Value + postcoinsep.Value

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

        componentescorebalance = onelegbalanceep.Value + walkheelsraisedep.Value + jumponmatsep.Value

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

        If (Band1_Codigo.Value = 0) Then

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

    Private Sub HabilitaCalculo()
        'Esse método HabilitaCalculo() deve ser chamado em todos os campos preenchiveis

        'Adicionar todos os campos no mesmo IF com AND

        If (PostcoinsprefehandsNumericUpDown.Value <> -1 Or CheckBox1.Checked) And (PostcoinsnonphandsNumericUpDown.Value <> -1 Or CheckBox2.Checked) And (TheradbeadsNumericUpDown.Value <> -1 Or CheckBox3.Checked) And (Drawl1NumericUpDown.Value <> -1 Or CheckBox4.Checked) And JumponmatsNumericUpDown.Value <> -1 And CathbeangNumericUpDown.Value <> -1 And ThrowingbeanNumericUpDown.Value <> -1 And OnelegbalancebestlegNumericUpDown.Value <> -1 And OnebalanceotherlegNumericUpDown.Value <> -1 And WalkingheelsNumericUpDown.Value <> -1 Then

            Calculatebutton.Enabled = True
        Else
            Calculatebutton.Enabled = False
        End If

        ' If PostcoinsprefehandsNumericUpDown.Value <> -1 Orelse CheckBox1.Checked and ...

        'TODO: temos que achar uma maneira de habilitar o Calculatebutton quando as checkbox estiverem habilitadas. O problema é que quando elas estão habilitadas retorna o valor -1.
    End Sub

    Private Sub Formulario_Banda_1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ChildTableAdapter.Fill(Banco_de_dadosDataSet.Child) 'tras os dados do banco

        SchoolTableAdapter.Fill(Banco_de_dadosDataSet.School)

        GeneroTableAdapter.Fill(Banco_de_dadosDataSet.genero)

        AdministerTableAdapter.Fill(Banco_de_dadosDataSet.Administer)

        Prefered_handTableAdapter.Fill(Banco_de_dadosDataSet.prefered_hand)

        BtnSaveEdit.Visible = False

        printpageBtm.Visible = False

        backCalculateBtm.Visible = False

        btnSave.Visible = False

        If codigo_edit <> 0 Then

            Band1BindingSource.Filter = "Band1_codigo =" & codigo_edit

            Band1TableAdapter.Fill(Banco_de_dadosDataSet.Band1)

            ChildBindingSource.Filter = "ch_codigo = " & Id_child_Band1.Value

        Else

            ChildBindingSource.Filter = "ch_codigo = " & child_id 'filtra dos dados

            DateTimePicker1.Value = date_assesment
        End If

        ChildBindingSource.ResetBindings(True) ' atualiza os dados nos campos

        'GeneroBindingSource.ResetBindings(True)

        'PreferedhandBindingSource.ResetBindings(True)

        CalculaIdade()

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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnSave.Click

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


            Band1TableAdapter.Insert(Id_child.Value,
                                 codeSchool.Value,
                                 codeAdm.Value,
                                 DateTimePicker1.Value,'TODO Band1TableAdapter.insert os campos text não recebem os valores das variáveis. Acho que temos que temos que converter essa variável em date
                                 idade,
                                 PostcoinsprefehandsNumericUpDown.Value,
                                 Postcoinsprefehandsep.Value,
                                 PostcoinsnonphandsNumericUpDown.Value,
                                 Postcoinsnonphandsep.Value,
                                 postcoinsep.Value,
                                 TheradbeadsNumericUpDown.Value,
                                 Theradbeadsep.Value,
                                 Drawl1NumericUpDown.Value,
                                 Drawl1ep.Value,
                                 CathbeangNumericUpDown.Value,
                                 Cathbeangep.Value,
                                 ThrowingbeanNumericUpDown.Value,
                                 Throwingbeanep.Value,
                                 OnelegbalancebestlegNumericUpDown.Value,
                                 Onelegbalancebestlegep.Value,
                                 OnebalanceotherlegNumericUpDown.Value,
                                 Onebalanceotherlegep.Value,
                                 onelegbalanceep.Value,
                                 WalkingheelsNumericUpDown.Value,
                                 walkheelsraisedep.Value,
                                 JumponmatsNumericUpDown.Value,
                                 jumponmatsep.Value,
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


            Band1TableAdapter.Update(Banco_de_dadosDataSet.Band1)

            Band1BindingSource.Sort = "Band1_codigo DESC"

            Band1TableAdapter.Fill(Banco_de_dadosDataSet.Band1)

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

        btnNewSchool.Enabled = True

        btnNewAdm.Enabled = True

    End Sub


    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles BtnSaveEdit.Click

        BtnSaveEdit.Visible = True
        Dim ask As MsgBoxResult

        ask = MsgBox("Are you sure save the edited data of the child?", MsgBoxStyle.YesNo)

        If ask = MsgBoxResult.Yes Then

            Band1BindingSource.EndEdit()
            Band1TableAdapter.Update(Banco_de_dadosDataSet.Band1)
            Band1TableAdapter.Fill(Banco_de_dadosDataSet.Band1)
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

    Private Sub printpageBtm_Click_1(sender As Object, e As EventArgs) Handles printpageBtm.Click
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

        filtro = "[Band1_codigo] = " & Band1_Codigo.Value


        appAccess.docmd.openreport(ReportName:="Band1", View:=Access.AcView.acViewPreview, WhereCondition:=filtro)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.Prefered_handTableAdapter.FillBy(Me.Banco_de_dadosDataSet.prefered_hand)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Id_child_Band1_ValueChanged(sender As Object, e As EventArgs) Handles Id_child_Band1.ValueChanged

    End Sub

    Private Sub Band1_Codigo_ValueChanged(sender As Object, e As EventArgs) Handles Band1_Codigo.ValueChanged

    End Sub
End Class