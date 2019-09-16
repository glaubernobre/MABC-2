Imports Microsoft.Office.Interop

Public Class Formulario_Banda_2
    Dim Dateborn As Date
    Dim Dateassessment As Date
    Dim Datet As TimeSpan
    Dim Diff As Double

    Public Property date_assesment As Date

    Public Property child_id As Integer


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            PlacingPegspreferredhandNumericUpDown.Value = -1
            PlacingPegspreferredhandNumericUpDown.Enabled = False
        Else
            PlacingPegspreferredhandNumericUpDown.Enabled = True
        End If
        HabilitaCalculo()
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            PlacingPegsnonpreferredhandNumericUpDown.Value = -1
            PlacingPegsnonpreferredhandNumericUpDown.Enabled = False
        Else
            PlacingPegsnonpreferredhandNumericUpDown.Enabled = True
        End If
        HabilitaCalculo()
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            ThreadingLaceNumericUpDown.Value = -1
            ThreadingLaceNumericUpDown.Enabled = False
        Else
            ThreadingLaceNumericUpDown.Enabled = True
        End If
        HabilitaCalculo()
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            Drawl2NumericUpDown.Value = -1
            Drawl2NumericUpDown.Enabled = False
        Else
            Drawl2NumericUpDown.Enabled = True
        End If
        HabilitaCalculo()
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            WalkingToetoHellForwardsNumericUpDown.Value = 15
            WalkingToetoHellForwardsNumericUpDown.Enabled = False
        Else
            WalkingToetoHellForwardsNumericUpDown.Value = -1
            WalkingToetoHellForwardsNumericUpDown.Enabled = True
        End If
    End Sub

    Private Sub PlacingPegspreferredhandNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles PlacingPegspreferredhandNumericUpDown.ValueChanged

        HabilitaCalculo()

        Dim scorebruto As Integer
        Dim idadecalculada As Double
        Dim valor As Integer

        valor = PlacingPegspreferredhandNumericUpDown.Value

        Dateborn = DateTimePicker2.Value.ToShortDateString
        Dateassessment = DateTimePicker1.Value.ToShortDateString
        Datet = (Dateassessment - Dateborn)
        Diff = Datet.Days
        idadecalculada = Diff / 365

        Select Case idadecalculada

            Case 7 To 7.99
                Select Case valor
                    Case <= 21
                        scorebruto = 16
                    Case 22 To 23
                        scorebruto = 15
                    Case 24 To 25
                        scorebruto = 14
                    Case 26
                        scorebruto = 13
                    Case 27 To 28
                        scorebruto = 12
                    Case 29
                        scorebruto = 11
                    Case 30
                        scorebruto = 10
                    Case 31 To 32
                        scorebruto = 9
                    Case 33 To 35
                        scorebruto = 8
                    Case 36
                        scorebruto = 7
                    Case 37 To 42
                        scorebruto = 4
                    Case 43 To 47
                        scorebruto = 3
                    Case >= 48
                        scorebruto = 4
                End Select

            Case 8 To 8.99
                Select Case valor
                    Case <= 19
                        scorebruto = 16
                    Case 20
                        scorebruto = 15
                    Case 21
                        scorebruto = 14
                    Case 22
                        scorebruto = 13
                    Case 23 To 24
                        scorebruto = 12
                    Case 25 To 26
                        scorebruto = 11
                    Case 27
                        scorebruto = 10
                    Case 28
                        scorebruto = 9
                    Case 29
                        scorebruto = 8
                    Case 30 To 32
                        scorebruto = 7
                    Case 33 To 34
                        scorebruto = 6
                    Case 35
                        scorebruto = 5
                    Case 36
                        scorebruto = 4
                    Case >= 37
                        scorebruto = 3
                End Select

            Case 9 To 9.99
                Select Case valor
                    Case <= 19
                        scorebruto = 16
                    Case 20
                        scorebruto = 15
                    Case 21
                        scorebruto = 14
                    Case 22
                        scorebruto = 13
                    Case 23 To 24
                        scorebruto = 12
                    Case 25
                        scorebruto = 11
                    Case 26
                        scorebruto = 10
                    Case 27
                        scorebruto = 9
                    Case 28
                        scorebruto = 8
                    Case 29 To 30
                        scorebruto = 7
                    Case 31 To 34
                        scorebruto = 6
                    Case 35
                        scorebruto = 5
                    Case 36
                        scorebruto = 4
                    Case >= 37
                        scorebruto = 3
                End Select

            Case 10 To 10.99
                Select Case valor
                    Case <= 18
                        scorebruto = 16
                    Case 19
                        scorebruto = 15
                    Case 20 To 21
                        scorebruto = 14
                    Case 22
                        scorebruto = 13
                    Case 23
                        scorebruto = 12
                    Case 24
                        scorebruto = 11
                    Case 25
                        scorebruto = 10
                    Case 26
                        scorebruto = 9
                    Case 27 To 28
                        scorebruto = 8
                    Case 29
                        scorebruto = 7
                    Case 30
                        scorebruto = 6
                    Case 31 To 32
                        scorebruto = 5
                    Case 33
                        scorebruto = 4
                    Case >= 34
                        scorebruto = 3
                End Select
        End Select
        If valor = -1 Then
            scorebruto = 1
        End If
        Placepegsprefehandsep.Value = scorebruto
    End Sub

    Private Sub PlacingPegsnonpreferredhandNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles PlacingPegsnonpreferredhandNumericUpDown.ValueChanged

        HabilitaCalculo()

        Dim scorebruto As Integer
        Dim idadecalculada As Double
        Dim valor As Integer

        valor = PlacingPegsnonpreferredhandNumericUpDown.Value

        Dateborn = DateTimePicker2.Value.ToShortDateString
        Dateassessment = DateTimePicker1.Value.ToShortDateString
        Datet = (Dateassessment - Dateborn)
        Diff = Datet.Days
        idadecalculada = Diff / 365

        Select Case idadecalculada

            Case 7 To 7.99
                Select Case valor
                    Case <= 20
                        scorebruto = 17
                    Case 21
                        scorebruto = 16
                    Case 22 To 26
                        scorebruto = 15
                    Case 27
                        scorebruto = 14
                    Case 28 To 30
                        scorebruto = 13
                    Case 31 To 32
                        scorebruto = 12
                    Case 33 To 34
                        scorebruto = 11
                    Case 35 To 36
                        scorebruto = 10
                    Case 37 To 38
                        scorebruto = 9
                    Case 39 To 41
                        scorebruto = 8
                    Case 42 To 47
                        scorebruto = 7
                    Case 48 To 51
                        scorebruto = 6
                    Case >= 52
                        scorebruto = 4
                End Select

            Case 8 To 8.99
                Select Case valor
                    Case <= 21
                        scorebruto = 16
                    Case 22 To 23
                        scorebruto = 15
                    Case 24 To 25
                        scorebruto = 14
                    Case 26
                        scorebruto = 13
                    Case 27
                        scorebruto = 12
                    Case 28 To 29
                        scorebruto = 11
                    Case 30 To 32
                        scorebruto = 10
                    Case 33
                        scorebruto = 9
                    Case 34 To 35
                        scorebruto = 8
                    Case 36 To 39
                        scorebruto = 7
                    Case 40 To 43
                        scorebruto = 6
                    Case 44
                        scorebruto = 5
                    Case >= 45
                        scorebruto = 4
                End Select

            Case 9 To 9.99
                Select Case valor
                    Case <= 21
                        scorebruto = 16
                    Case 22 To 23
                        scorebruto = 15
                    Case 24 To 25
                        scorebruto = 14
                    Case 26
                        scorebruto = 13
                    Case 27
                        scorebruto = 12
                    Case 28 To 29
                        scorebruto = 11
                    Case 30
                        scorebruto = 10
                    Case 31 To 32
                        scorebruto = 9
                    Case 33 To 34
                        scorebruto = 8
                    Case 35 To 36
                        scorebruto = 7
                    Case 37 To 40
                        scorebruto = 6
                    Case 41 To 44
                        scorebruto = 5
                    Case >= 45
                        scorebruto = 4
                End Select

            Case 10 To 10.99
                Select Case valor
                    Case <= 20
                        scorebruto = 16
                    Case 21 To 22
                        scorebruto = 15
                    Case 23
                        scorebruto = 14
                    Case 24
                        scorebruto = 13
                    Case 25 To 26
                        scorebruto = 12
                    Case 27
                        scorebruto = 11
                    Case 28
                        scorebruto = 10
                    Case 29
                        scorebruto = 9
                    Case 30
                        scorebruto = 8
                    Case 31 To 33
                        scorebruto = 7
                    Case 34 To 38
                        scorebruto = 6
                    Case 39 To 40
                        scorebruto = 5
                    Case >= 41
                        scorebruto = 4
                End Select
        End Select
        If valor = -1 Then
            scorebruto = 1
        End If
        placinspegsnonphandsep.Value = scorebruto
    End Sub

    Private Sub ThreadingLaceNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles ThreadingLaceNumericUpDown.ValueChanged

        HabilitaCalculo()

        Dim scorebruto As Integer
        Dim idadecalculada As Double
        Dim valor As Integer

        valor = ThreadingLaceNumericUpDown.Value

        Dateborn = DateTimePicker2.Value.ToShortDateString
        Dateassessment = DateTimePicker1.Value.ToShortDateString
        Datet = (Dateassessment - Dateborn)
        Diff = Datet.Days
        idadecalculada = Diff / 365

        Select Case idadecalculada

            Case 7 To 7.99
                Select Case valor
                    Case <= 20
                        scorebruto = 16
                    Case 21
                        scorebruto = 15
                    Case 22
                        scorebruto = 14
                    Case 23 To 24
                        scorebruto = 13
                    Case 25 To 26
                        scorebruto = 12
                    Case 27 To 29
                        scorebruto = 11
                    Case 30
                        scorebruto = 10
                    Case 31 To 32
                        scorebruto = 9
                    Case 33 To 34
                        scorebruto = 8
                    Case 35 To 36
                        scorebruto = 7
                    Case 37 To 40
                        scorebruto = 6
                    Case 41 To 48
                        scorebruto = 5
                    Case >= 49
                        scorebruto = 3
                End Select

            Case 8 To 8.99
                Select Case valor
                    Case <= 17
                        scorebruto = 15
                    Case 18
                        scorebruto = 14
                    Case 19 To 20
                        scorebruto = 13
                    Case 21 To 24
                        scorebruto = 12
                    Case 25
                        scorebruto = 11
                    Case 26
                        scorebruto = 10
                    Case 27 To 28
                        scorebruto = 9
                    Case 29 To 31
                        scorebruto = 8
                    Case 32 To 33
                        scorebruto = 7
                    Case 34 To 35
                        scorebruto = 6
                    Case 36 To 41
                        scorebruto = 5
                    Case 42 To 45
                        scorebruto = 4
                    Case >= 46
                        scorebruto = 3
                End Select

            Case 9 To 9.99
                Select Case valor
                    Case <= 16
                        scorebruto = 15
                    Case 17
                        scorebruto = 14
                    Case 18 To 19
                        scorebruto = 13
                    Case 20
                        scorebruto = 12
                    Case 21
                        scorebruto = 11
                    Case 22 To 24
                        scorebruto = 10
                    Case 25 To 26
                        scorebruto = 9
                    Case 27
                        scorebruto = 8
                    Case 28 To 29
                        scorebruto = 7
                    Case 30 To 32
                        scorebruto = 6
                    Case 33
                        scorebruto = 5
                    Case 34 To 36
                        scorebruto = 4
                    Case 37 To 44
                        scorebruto = 3
                    Case >= 45
                        scorebruto = 2
                End Select

            Case 10 To 10.99
                Select Case valor
                    Case <= 15
                        scorebruto = 15
                    Case 16
                        scorebruto = 14
                    Case 17 To 18
                        scorebruto = 13
                    Case 19
                        scorebruto = 12
                    Case 20 To 21
                        scorebruto = 11
                    Case 22
                        scorebruto = 10
                    Case 23
                        scorebruto = 9
                    Case 24
                        scorebruto = 8
                    Case 25 To 27
                        scorebruto = 7
                    Case 28 To 32
                        scorebruto = 6
                    Case 33
                        scorebruto = 5
                    Case 34 To 36
                        scorebruto = 4
                    Case 37 To 44
                        scorebruto = 3
                    Case >= 45
                        scorebruto = 2
                End Select
        End Select
        If valor = -1 Then
            scorebruto = 1
        End If
        Threadinglaceep.Value = scorebruto
    End Sub

    Private Sub Drawl2NumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles Drawl2NumericUpDown.ValueChanged

        HabilitaCalculo()

        Dim scorebruto As Integer
        Dim idadecalculada As Double
        Dim valor As Integer

        valor = Drawl2NumericUpDown.Value

        Dateborn = DateTimePicker2.Value.ToShortDateString
        Dateassessment = DateTimePicker1.Value.ToShortDateString
        Datet = (Dateassessment - Dateborn)
        Diff = Datet.Days
        idadecalculada = Diff / 365

        Select Case idadecalculada

            Case 7 To 7.99
                Select Case valor
                    Case 0
                        scorebruto = 12
                    Case 1
                        scorebruto = 10
                    Case 2
                        scorebruto = 8
                    Case 3
                        scorebruto = 5
                    Case 4
                        scorebruto = 3
                    Case 5
                        scorebruto = 2
                    Case >= 6
                        scorebruto = 1
                End Select

            Case 8 To 8.99
                Select Case valor
                    Case 0
                        scorebruto = 12
                    Case 1
                        scorebruto = 6
                    Case 2
                        scorebruto = 5
                    Case 3
                        scorebruto = 4
                    Case >= 4
                        scorebruto = 1
                End Select

            Case 9 To 9.99
                Select Case valor
                    Case 0
                        scorebruto = 11
                    Case 1
                        scorebruto = 6
                    Case 2
                        scorebruto = 4
                    Case 3
                        scorebruto = 3
                    Case >= 4
                        scorebruto = 1
                End Select

            Case 10 To 10.99
                Select Case valor
                    Case 0
                        scorebruto = 11
                    Case 1
                        scorebruto = 6
                    Case 2
                        scorebruto = 4
                    Case 3
                        scorebruto = 3
                    Case >= 4
                        scorebruto = 1
                End Select
        End Select
        If valor = -1 Then
            scorebruto = 1
        End If
        Drawl2ep.Value = scorebruto
    End Sub

    Private Sub CatchingwithtwoHandsNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles CatchingwithtwoHandsNumericUpDown.ValueChanged

        HabilitaCalculo()

        Dim scorebruto As Integer
        Dim idadecalculada As Double
        Dim valor As Integer

        valor = CatchingwithtwoHandsNumericUpDown.Value

        Dateborn = DateTimePicker2.Value.ToShortDateString
        Dateassessment = DateTimePicker1.Value.ToShortDateString
        Datet = (Dateassessment - Dateborn)
        Diff = Datet.Days
        idadecalculada = Diff / 365

        Select Case idadecalculada

            Case 7 To 7.99
                Select Case valor
                    Case 0
                        scorebruto = 5
                    Case 1
                        scorebruto = 6
                    Case 2 To 3
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
                        scorebruto = 15
                    Case 10
                        scorebruto = 17
                End Select

            Case 8 To 8.99
                Select Case valor
                    Case 0
                        scorebruto = 4
                    Case 1 To 2
                        scorebruto = 5
                    Case 3
                        scorebruto = 6
                    Case 4 To 5
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
                        scorebruto = 15
                End Select

            Case 9 To 9.99
                Select Case valor
                    Case 0
                        scorebruto = 5
                    Case 1
                        scorebruto = 8
                    Case 2 To 5
                        scorebruto = 9
                    Case 6 To 8
                        scorebruto = 10
                    Case 9
                        scorebruto = 12
                    Case 10
                        scorebruto = 15
                End Select

            Case 10 To 10.99
                Select Case valor
                    Case 0
                        scorebruto = 5
                    Case 1 To 2
                        scorebruto = 6
                    Case 3 To 4
                        scorebruto = 7
                    Case 5 To 6
                        scorebruto = 8
                    Case 7 To 8
                        scorebruto = 9
                    Case 9
                        scorebruto = 12
                    Case 10
                        scorebruto = 14
                End Select
        End Select
        If valor = -1 Then
            scorebruto = 1
        End If
        CathWithTwoHandsep.Value = scorebruto

    End Sub

    Private Sub ThrowingBeanbagontomatNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles ThrowingBeanbagontomatNumericUpDown.ValueChanged

        HabilitaCalculo()

        Dim scorebruto As Integer
        Dim idadecalculada As Double
        Dim valor As Integer

        valor = ThrowingBeanbagontomatNumericUpDown.Value

        Dateborn = DateTimePicker2.Value.ToShortDateString
        Dateassessment = DateTimePicker1.Value.ToShortDateString
        Datet = (Dateassessment - Dateborn)
        Diff = Datet.Days
        idadecalculada = Diff / 365

        Select Case idadecalculada

            Case 7 To 7.99
                Select Case valor
                    Case 0 To 1
                        scorebruto = 3
                    Case 2 To 3
                        scorebruto = 5
                    Case 4
                        scorebruto = 7
                    Case 5 To 6
                        scorebruto = 9
                    Case 7
                        scorebruto = 11
                    Case 8
                        scorebruto = 12
                    Case 9
                        scorebruto = 15
                    Case 10
                        scorebruto = 17
                End Select

            Case 8 To 8.99
                Select Case valor
                    Case 0 To 2
                        scorebruto = 3
                    Case 3
                        scorebruto = 4
                    Case 4
                        scorebruto = 5
                    Case 5
                        scorebruto = 6
                    Case 6
                        scorebruto = 8
                    Case 7 To 8
                        scorebruto = 11
                    Case 9
                        scorebruto = 14
                    Case 10
                        scorebruto = 17
                End Select

            Case 9 To 9.99
                Select Case valor
                    Case 0 To 2
                        scorebruto = 3
                    Case 3
                        scorebruto = 4
                    Case 4
                        scorebruto = 5
                    Case 5
                        scorebruto = 6
                    Case 6
                        scorebruto = 8
                    Case 7 To 8
                        scorebruto = 11
                    Case 9
                        scorebruto = 12
                    Case 10
                        scorebruto = 14
                End Select

            Case 10 To 10.99
                Select Case valor
                    Case 0 To 2
                        scorebruto = 3
                    Case 3
                        scorebruto = 4
                    Case 4 To 5
                        scorebruto = 5
                    Case 6
                        scorebruto = 7
                    Case 7
                        scorebruto = 8
                    Case 8
                        scorebruto = 11
                    Case 9
                        scorebruto = 12
                    Case 10
                        scorebruto = 14
                End Select
        End Select
        If valor = -1 Then
            scorebruto = 1
        End If
        throwingBeanbagep.Value = scorebruto

    End Sub

    Private Sub OneboardBalancebestlegNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles OneboardBalancebestlegNumericUpDown.ValueChanged

        HabilitaCalculo()

        Dim scorebruto As Integer
        Dim idadecalculada As Double
        Dim valor As Integer

        valor = OneboardBalancebestlegNumericUpDown.Value

        Dateborn = DateTimePicker2.Value.ToShortDateString
        Dateassessment = DateTimePicker1.Value.ToShortDateString
        Datet = (Dateassessment - Dateborn)
        Diff = Datet.Days
        idadecalculada = Diff / 365

        Select Case idadecalculada

            Case 7.0 To 7.99
                Select Case valor
                    Case 0 To 1
                        scorebruto = 3
                    Case 2 To 3
                        scorebruto = 4
                    Case 4
                        scorebruto = 5
                    Case 5
                        scorebruto = 6
                    Case 6 To 7
                        scorebruto = 7
                    Case 8 To 10
                        scorebruto = 8
                    Case 11 To 15
                        scorebruto = 9
                    Case 16 To 19
                        scorebruto = 10
                    Case 20 To 24
                        scorebruto = 11
                    Case 25 To 27
                        scorebruto = 12
                    Case 28 To 30
                        scorebruto = 14
                End Select

            Case 8.0 To 8.99
                Select Case valor
                    Case 0 To 3
                        scorebruto = 3
                    Case 4 To 5
                        scorebruto = 4
                    Case 6
                        scorebruto = 5
                    Case 7 To 8
                        scorebruto = 6
                    Case 9 To 10
                        scorebruto = 7
                    Case 11 To 12
                        scorebruto = 8
                    Case 13 To 18
                        scorebruto = 9
                    Case 19 To 21
                        scorebruto = 10
                    Case 22 To 25
                        scorebruto = 11
                    Case 26 To 28
                        scorebruto = 12
                    Case 29 To 30
                        scorebruto = 13
                End Select

            Case 9.0 To 9.99
                Select Case valor
                    Case 0 To 3
                        scorebruto = 3
                    Case 4 To 5
                        scorebruto = 4
                    Case 6 To 7
                        scorebruto = 5
                    Case 8 To 9
                        scorebruto = 6
                    Case 10 To 14
                        scorebruto = 7
                    Case 15 To 18
                        scorebruto = 8
                    Case 19 To 22
                        scorebruto = 9
                    Case 23 To 25
                        scorebruto = 10
                    Case 26 To 28
                        scorebruto = 11
                    Case 29
                        scorebruto = 12
                    Case 30
                        scorebruto = 13
                End Select

            Case 10.0 To 10.99
                Select Case valor
                    Case 0 To 3
                        scorebruto = 3
                    Case 4 To 5
                        scorebruto = 4
                    Case 6 To 9
                        scorebruto = 5
                    Case 10 To 13
                        scorebruto = 6
                    Case 14 To 15
                        scorebruto = 7
                    Case 16 To 18
                        scorebruto = 8
                    Case 19 To 26
                        scorebruto = 9
                    Case 27 To 29
                        scorebruto = 10
                    Case 30
                        scorebruto = 13
                End Select
        End Select
        Oneboardbalancebestlegep.Value = scorebruto
    End Sub

    Private Sub OneboardBalanceotherlegNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles OneboardBalanceotherlegNumericUpDown.ValueChanged

        HabilitaCalculo()

        Dim scorebruto As Integer
        Dim idadecalculada As Double
        Dim valor As Integer

        valor = OneboardBalanceotherlegNumericUpDown.Value

        Dateborn = DateTimePicker2.Value.ToShortDateString
        Dateassessment = DateTimePicker1.Value.ToShortDateString
        Datet = (Dateassessment - Dateborn)
        Diff = Datet.Days
        idadecalculada = Diff / 365

        Select Case idadecalculada

            Case 7.0 To 7.99
                Select Case valor
                    Case 0 To 1
                        scorebruto = 4
                    Case 2
                        scorebruto = 5
                    Case 3
                        scorebruto = 7
                    Case 4
                        scorebruto = 8
                    Case 5
                        scorebruto = 9
                    Case 6 To 7
                        scorebruto = 10
                    Case 8 To 11
                        scorebruto = 11
                    Case 12 To 15
                        scorebruto = 12
                    Case 16 To 19
                        scorebruto = 13
                    Case 20 To 22
                        scorebruto = 14
                    Case 23 To 29
                        scorebruto = 15
                    Case 30
                        scorebruto = 16
                End Select

            Case 8.0 To 8.99
                Select Case valor
                    Case 0 To 1
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
                    Case 7 To 8
                        scorebruto = 10
                    Case 9 To 14
                        scorebruto = 11
                    Case 15 To 18
                        scorebruto = 12
                    Case 19 To 24
                        scorebruto = 13
                    Case 25 To 26
                        scorebruto = 14
                    Case 27 To 30
                        scorebruto = 15
                End Select

            Case 9.0 To 9.99
                Select Case valor
                    Case 0 To 1
                        scorebruto = 3
                    Case 2
                        scorebruto = 4
                    Case 3
                        scorebruto = 5
                    Case 4
                        scorebruto = 7
                    Case 5
                        scorebruto = 8
                    Case 6 To 7
                        scorebruto = 9
                    Case 8 To 9
                        scorebruto = 10
                    Case 10 To 16
                        scorebruto = 11
                    Case 17 To 24
                        scorebruto = 12
                    Case 25 To 30
                        scorebruto = 13
                End Select

            Case 10.0 To 10.99
                Select Case valor
                    Case 0 To 2
                        scorebruto = 3
                    Case 3
                        scorebruto = 4
                    Case 4
                        scorebruto = 6
                    Case 5
                        scorebruto = 7
                    Case 6
                        scorebruto = 8
                    Case 7 To 9
                        scorebruto = 9
                    Case 10 To 16
                        scorebruto = 10
                    Case 17 To 23
                        scorebruto = 11
                    Case 24
                        scorebruto = 12
                    Case 25 To 30
                        scorebruto = 13
                End Select
        End Select
        Oneboardbalanceotherlegep.Value = scorebruto
    End Sub

    Private Sub WalkingToetoHellForwardsNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles WalkingToetoHellForwardsNumericUpDown.ValueChanged

        HabilitaCalculo()

        Dim scorebruto As Integer
        Dim idadecalculada As Double
        Dim valor As Integer

        valor = WalkingToetoHellForwardsNumericUpDown.Value

        Dateborn = DateTimePicker2.Value.ToShortDateString
        Dateassessment = DateTimePicker1.Value.ToShortDateString
        Datet = (Dateassessment - Dateborn)
        Diff = Datet.Days
        idadecalculada = Diff / 365

        Select Case idadecalculada

            Case 7.0 To 7.99
                Select Case valor
                    Case 0 To 1
                        scorebruto = 2
                    Case 2 To 7
                        scorebruto = 3
                    Case 8 To 9
                        scorebruto = 4
                    Case 10
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

            Case 8.0 To 8.99
                Select Case valor
                    Case 0 To 1
                        scorebruto = 2
                    Case 2 To 7
                        scorebruto = 3
                    Case 8 To 9
                        scorebruto = 4
                    Case 10
                        scorebruto = 5
                    Case 11 To 12
                        scorebruto = 6
                    Case 13 To 14
                        scorebruto = 7
                    Case 15
                        scorebruto = 11
                End Select

            Case 9.0 To 9.99
                Select Case valor
                    Case 0 To 7
                        scorebruto = 1
                    Case 8 To 10
                        scorebruto = 2
                    Case 11 To 12
                        scorebruto = 3
                    Case 13
                        scorebruto = 4
                    Case 14
                        scorebruto = 7
                    Case 15
                        scorebruto = 11
                End Select

            Case 10.0 To 10.99
                Select Case valor
                    Case 0 To 7
                        scorebruto = 1
                    Case 8 To 10
                        scorebruto = 2
                    Case 11 To 13
                        scorebruto = 3
                    Case 14
                        scorebruto = 4
                    Case 15
                        scorebruto = 11
                End Select
        End Select
        walkingToetoHellForwardsep.Value = scorebruto
    End Sub

    Private Sub HoppingonmatsbestlegNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles HoppingonmatsbestlegNumericUpDown.ValueChanged

        HabilitaCalculo()

        Dim scorebruto As Integer
        Dim idadecalculada As Double
        Dim valor As Integer

        valor = HoppingonmatsbestlegNumericUpDown.Value

        Dateborn = DateTimePicker2.Value.ToShortDateString
        Dateassessment = DateTimePicker1.Value.ToShortDateString
        Datet = (Dateassessment - Dateborn)
        Diff = Datet.Days
        idadecalculada = Diff / 365

        Select Case idadecalculada

            Case 7 To 7.99
                Select Case valor
                    Case 0 To 1
                        scorebruto = 1
                    Case 2 To 3
                        scorebruto = 3
                    Case 4
                        scorebruto = 4
                    Case 5
                        scorebruto = 11
                End Select

            Case 8.0 To 8.99
                Select Case valor
                    Case 0 To 1
                        scorebruto = 1
                    Case 2 To 3
                        scorebruto = 3
                    Case 4
                        scorebruto = 4
                    Case 5
                        scorebruto = 11
                End Select

            Case 9.0 To 9.99
                Select Case valor
                    Case 0 To 1
                        scorebruto = 1
                    Case 2 To 3
                        scorebruto = 2
                    Case 4
                        scorebruto = 3
                    Case 5
                        scorebruto = 11
                End Select

            Case 10.0 To 10.99
                Select Case valor
                    Case 0 To 4
                        scorebruto = 1
                    Case 5
                        scorebruto = 11
                End Select

        End Select
        HoppingOnMatsbestlegep.Value = scorebruto
    End Sub

    Private Sub HoppingonmatsotherlegNumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles HoppingonmatsotherlegNumericUpDown.ValueChanged

        HabilitaCalculo()

        Dim scorebruto As Integer
        Dim idadecalculada As Double
        Dim valor As Integer

        valor = HoppingonmatsotherlegNumericUpDown.Value

        Dateborn = DateTimePicker2.Value.ToShortDateString
        Dateassessment = DateTimePicker1.Value.ToShortDateString
        Datet = (Dateassessment - Dateborn)
        Diff = Datet.Days
        idadecalculada = Diff / 365

        Select Case idadecalculada

            Case 7 To 7.99
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
                        scorebruto = 9
                    Case 5
                        scorebruto = 13
                End Select

            Case 8.0 To 8.99
                Select Case valor
                    Case 0
                        scorebruto = 2
                    Case 1
                        scorebruto = 3
                    Case 2
                        scorebruto = 4
                    Case 3
                        scorebruto = 5
                    Case 4
                        scorebruto = 6
                    Case 5
                        scorebruto = 12
                End Select

            Case 9.0 To 9.99
                Select Case valor
                    Case 0
                        scorebruto = 2
                    Case 1
                        scorebruto = 3
                    Case 2
                        scorebruto = 4
                    Case 3
                        scorebruto = 5
                    Case 4
                        scorebruto = 6
                    Case 5
                        scorebruto = 12
                End Select

            Case 10.0 To 10.99
                Select Case valor
                    Case 0
                        scorebruto = 2
                    Case 1
                        scorebruto = 3
                    Case 2
                        scorebruto = 4
                    Case 3
                        scorebruto = 5
                    Case 4
                        scorebruto = 6
                    Case 5
                        scorebruto = 12
                End Select

        End Select
        HoppingOnMatsOtherlegep.Value = scorebruto
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        Dateborn = DateTimePicker2.Value.ToShortDateString
        Dateassessment = DateTimePicker1.Value.ToShortDateString
        Datet = (Dateassessment - Dateborn)
        Diff = Datet.Days
        Label5.Text = (Str(Int(Diff / 365)) + " years,")
        Diff = Diff Mod 365
        Label5.Text = Label5.Text + (Str(Int(Diff / 30)) + " month(s)")
        Diff = Diff Mod 30
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Formulario_Banda_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Band2TableAdapter.Fill(Banco_de_dadosDataSet.Band2)

        AdministerTableAdapter.Fill(Banco_de_dadosDataSet.Administer)

        SchoolTableAdapter.Fill(Banco_de_dadosDataSet.School)

        Prefered_handTableAdapter.Fill(Banco_de_dadosDataSet.prefered_hand)

        GeneroTableAdapter.Fill(Banco_de_dadosDataSet.genero)

        ChildTableAdapter.Fill(Banco_de_dadosDataSet.Child)

        ChildBindingSource.Filter = "ch_codigo = " & child_id 'filtra dos dados

        ChildBindingSource.ResetBindings(True) ' atualiza os dados nos campos

        btnSaveEdit.Visible = False

        printpageBtm.Visible = False

        backCalculateBtm.Visible = False

        btnSave.Visible = False

        DateTimePicker1.Value = date_assesment

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnNewSchool.Click
        cadnewschool.ShowDialog()
        ' Comando abaixo completa os dados no Combobox
        SchoolTableAdapter.Fill(Banco_de_dadosDataSet.School)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnNewAdm.Click
        cadNewAdm.ShowDialog()
        ' Comando abaixo completa os dados no Combobox - Salva os dados no banco
        AdministerTableAdapter.Fill(Banco_de_dadosDataSet.Administer)
    End Sub

    Private Sub Calculatebutton_Click(sender As Object, e As EventArgs) Handles Calculatebutton.Click

        Dim placePegsmedia As Double
        Dim placePegs As Integer

        placePegsmedia = (Placepegsprefehandsep.Value + placinspegsnonphandsep.Value) / 2

        If placePegsmedia > 10 Then
            placePegs = Math.Round(placePegsmedia, 0)

        Else
            placePegs = placePegsmedia 'Ao passar uma variavel Double para outra Integer, as casas decimais são suprimidas
        End If

        placePegsep.Value = placePegs

        Dim OneBoardBalancemedia As Double
        Dim OneBoardBalance As Integer

        OneBoardBalancemedia = (Oneboardbalancebestlegep.Value + Oneboardbalanceotherlegep.Value) / 2

        If OneBoardBalancemedia > 10 Then
            OneBoardBalance = Math.Round(OneBoardBalancemedia)
        Else
            OneBoardBalance = OneBoardBalancemedia
        End If

        oneboardbalanceep.Value = OneBoardBalance

        Dim HoppingOnMatsepmedia As Double
        Dim HoppingOnMats As Integer

        HoppingOnMatsepmedia = (HoppingOnMatsbestlegep.Value + HoppingOnMatsOtherlegep.Value) / 2

        If HoppingOnMatsepmedia > 10 Then
            HoppingOnMats = Math.Round(HoppingOnMatsepmedia)
        Else
            HoppingOnMats = HoppingOnMatsepmedia
        End If

        HoppingOnMatsep.Value = HoppingOnMats

        Dim componentescoreaimingcatching As Integer
        Dim stantardscoreAimingCatching As Integer
        Dim percentilaimingcatching As Double

        componentescoreaimingcatching = CathWithTwoHandsep.Value + throwingBeanbagep.Value

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

        componentmanualdextery = Drawl2ep.Value + placePegsep.Value + Threadinglaceep.Value

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


        componentescorebalance = oneboardbalanceep.Value + walkingToetoHellForwardsep.Value + HoppingOnMatsep.Value

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

        If (Band2_Codigo.Value = 1) Then

            btnSave.Visible = True
        Else
            btnSaveEdit.Visible = True
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

        If (CheckBox1.Checked Or PlacingPegspreferredhandNumericUpDown.Value <> -1) And (CheckBox2.Checked Or PlacingPegsnonpreferredhandNumericUpDown.Value <> -1) And (ThreadingLaceNumericUpDown.Value <> -1 Or CheckBox3.Checked) And (Drawl2NumericUpDown.Value <> -1 Or CheckBox4.Checked) And CatchingwithtwoHandsNumericUpDown.Value <> -1 And ThrowingBeanbagontomatNumericUpDown.Value <> -1 And OneboardBalancebestlegNumericUpDown.Value <> -1 And OneboardBalanceotherlegNumericUpDown.Value <> -1 And WalkingToetoHellForwardsNumericUpDown.Value <> -1 And HoppingonmatsbestlegNumericUpDown.Value <> -1 And HoppingonmatsotherlegNumericUpDown.Value <> -1 Then

            Calculatebutton.Enabled = True
        Else
            Calculatebutton.Enabled = False
        End If

        ' If PostcoinsprefehandsNumericUpDown.Value <> -1 Orelse CheckBox1.Checked and ...

        'temos que achar uma maneira de habilitar o Calculatebutton quando as checkbox estiverem habilitadas. O problema é que quando elas estão habilitadas retorna o valor -1.
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSaveEdit.Click

        btnSaveEdit.Visible = True
        Dim ask As MsgBoxResult

        ask = MsgBox("Are you sure save the edited data of the child?", MsgBoxStyle.YesNo)

        If ask = MsgBoxResult.Yes Then

            Band2BindingSource.EndEdit()
            Band2TableAdapter.Update(Banco_de_dadosDataSet.Band2)
            Band2TableAdapter.Fill(Banco_de_dadosDataSet.Band2)
        End If


        btnNewSchool.Visible = False

        btnSaveEdit.Visible = False

        btnSave.Visible = False

        btnNewAdm.Visible = False

        DateTimePicker1.Enabled = False

        SchoolCbx.Enabled = False

        administerCbx.Enabled = False

        printpageBtm.Visible = True


    End Sub

    Private Sub backCalculateBtm_Click(sender As Object, e As EventArgs) Handles backCalculateBtm.Click


        btnSave.Visible = False

        btnSaveEdit.Visible = False

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


            Band2TableAdapter.Insert(Id_child.Value,
                                     codeSchool.Value,
                                 codeAdm.Value,
                                 DateTimePicker1.Value,
                                     idade,
                                     PlacingPegspreferredhandNumericUpDown.Value,
                                     Placepegsprefehandsep.Value,
                                     PlacingPegsnonpreferredhandNumericUpDown.Value,
                                     placinspegsnonphandsep.Value,
                                     placePegsep.Value,
                                     ThreadingLaceNumericUpDown.Value,
                                     Threadinglaceep.Value,
                                     Drawl2NumericUpDown.Value,
                                     Drawl2ep.Value,
                                     CatchingwithtwoHandsNumericUpDown.Value,
                                     CathWithTwoHandsep.Value,
                                     ThrowingBeanbagontomatNumericUpDown.Value,
                                     throwingBeanbagep.Value,
                                     OneboardBalancebestlegNumericUpDown.Value,
                                     Oneboardbalancebestlegep.Value,
                                     OneboardBalanceotherlegNumericUpDown.Value,
                                     Oneboardbalanceotherlegep.Value,
                                     oneboardbalanceep.Value,
                                     WalkingToetoHellForwardsNumericUpDown.Value,
                                     walkingToetoHellForwardsep.Value,
                                     HoppingonmatsbestlegNumericUpDown.Value,
                                     HoppingOnMatsbestlegep.Value,
                                     HoppingonmatsotherlegNumericUpDown.Value,
                                     HoppingOnMatsOtherlegep.Value,
                                     HoppingOnMatsep.Value,
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

            Band2TableAdapter.Update(Banco_de_dadosDataSet.Band2)

            Band2BindingSource.Sort = "Band2_codigo DESC"

            Band2TableAdapter.Fill(Banco_de_dadosDataSet.Band2)

            MsgBox("Sucessfull")

            btnSaveEdit.Visible = False
            btnNewSchool.Enabled = False
            btnNewAdm.Enabled = False
            btnSave.Visible = False
            DateTimePicker1.Enabled = False
            SchoolCbx.Enabled = False
            administerCbx.Enabled = False
            printpageBtm.Visible = True
        End If

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

        filtro = "[Band2_codigo] = " & Band2_Codigo.Value

        appAccess.docmd.openreport(ReportName:="Band2", View:=Access.AcView.acViewPreview, WhereCondition:=filtro)

    End Sub
End Class


