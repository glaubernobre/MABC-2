Public Class cadChild
    Dim IdadeInteiro As Integer

    Private Sub cadChild_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Prefered_handTableAdapter.Fill(Banco_de_dadosDataSet.prefered_hand)

        Me.GeneroTableAdapter.Fill(Me.Banco_de_dadosDataSet.genero)

        Me.ChildTableAdapter.Fill(Me.Banco_de_dadosDataSet.Child)

        Panel1.Enabled = False
        Save.Visible = False
        Cancel.Visible = False

        If (DataGridView1.RowCount = 0) Then
            deletebtn.Enabled = False
            updatebtn.Enabled = False
        End If

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        Dim Dateborn As Date
        Dim Dateassessment As Date
        Dim Datet As TimeSpan
        Dim Diff As Double

        Dateborn = DateTimePicker2.Value.ToShortDateString
        Dateassessment = DateTimePicker1.Value.ToShortDateString
        Datet = (Dateassessment - Dateborn)
        Diff = Datet.Days
        IdadeInteiro = Int(Diff / 365)

        ageYears.Text = (Str(Int(Diff / 365)) + " years,")
        Diff = Diff Mod 365
        ageYears.Text = ageYears.Text + (Str(Int(Diff / 30)) + " month(s)")
        Diff = Diff Mod 30

        ageInteger.Text = "Age: " + Str(IdadeInteiro)

    End Sub

    Private Sub Insertbtn_Click(sender As Object, e As EventArgs) Handles Insertbtn.Click

        Panel2.Visible = False
        Save.Enabled = True
        Cancel.Enabled = True
        Save.Visible = True
        Cancel.Visible = True
        Panel1.Enabled = True
        Namechild.Clear()
        genderCombox.SelectedItem = Nothing
        preferredHandCombox.SelectedItem = Nothing
        DateTimePicker2.Value = Now.Date
        assesschildbtn.Visible = False
        BtChecklist.Visible = False

    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        If (IdadeInteiro < 3 Or IdadeInteiro > 16) Then
            MsgBox("Invalid date of birth at test date.")
        ElseIf (Namechild.Text = "") Then
            MsgBox("You must register the name of the child")
        ElseIf genderCombox.SelectedValue = False Then
            MsgBox("You must register the gender of the child")
        ElseIf (preferredHandCombox.SelectedValue = False) Then
            MsgBox("You must register the preferred hand of the child")
        Else
            ChildTableAdapter.Insert(Namechild.Text, DateTimePicker2.Value, genderCombox.SelectedValue, preferredHandCombox.SelectedValue)
            ChildTableAdapter.Update(Banco_de_dadosDataSet.Child)
            ChildBindingSource.Sort = "Ch_codigo DESC"
            ChildTableAdapter.Fill(Banco_de_dadosDataSet.Child)
            MsgBox("The child was registered")
            Cancel.PerformClick()
        End If
        deletebtn.Enabled = True
        updatebtn.Enabled = True
        assesschildbtn.Enabled = True
        BtChecklist.Visible = True
    End Sub

    Private Sub deletebtn_Click(sender As Object, e As EventArgs) Handles deletebtn.Click
        DataGridView1.Select()
        Dim ask As MsgBoxResult
        ask = MsgBox("Are you sure delete the child?", MsgBoxStyle.YesNo)
        If ask = MsgBoxResult.Yes Then
            ChildBindingSource.RemoveCurrent()
            ChildTableAdapter.Update(Banco_de_dadosDataSet.Child)
            If (DataGridView1.RowCount = 0) Then
                deletebtn.Enabled = False
                updatebtn.Enabled = False
                assesschildbtn.Enabled = False
                DateTimePicker1.Value = Date.Now
                DateTimePicker2.Value = Date.Now
            End If

        End If

    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Panel2.Visible = True
        Save.Visible = False
        Save2.Visible = False
        Cancel.Visible = False
        Panel1.Enabled = False
        ChildTableAdapter.Fill(Banco_de_dadosDataSet.Child)
        DataGridView1.Enabled = True
        assesschildbtn.Visible = True
        BtChecklist.Visible = True

    End Sub

    Private Sub updatebtn_Click(sender As Object, e As EventArgs) Handles updatebtn.Click
        DataGridView1.Enabled = False
        Panel1.Enabled = True
        Panel2.Visible = False
        Save2.Visible = True
        Cancel.Visible = True
        assesschildbtn.Visible = False
        BtChecklist.Visible = False
    End Sub

    Private Sub assesschildbtn_Click(sender As Object, e As EventArgs) Handles assesschildbtn.Click

        'If que redireciona para o formulário adequado de Banda relacionado com a idade

        Select Case IdadeInteiro 'linha de código para direcionar o formulário adequado a idade  
            Case 3 To 6
                'A maneira correta é assim, repetir nos demais cases. Não chamar Diretamento o formulário, mas criar ele dentro de uma variável
                Dim formulario As New Formulario_Banda_1

                formulario.child_id = Id_child.Value

                formulario.date_assesment = DateTimePicker1.Value

                formulario.Show()

            Case 7 To 10
                Dim formulario As New Formulario_Banda_2

                formulario.child_id = Id_child.Value

                formulario.date_assesment = DateTimePicker1.Value

                formulario.Show()

            Case 11 To 16

                Dim formulario As New Formulario_Banda_3

                formulario.child_id = Id_child.Value

                formulario.date_assesment = DateTimePicker1.Value

                formulario.Show()

            Case Else
                MsgBox("Invalid age for MBAC-2")
        End Select

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Save2.Click

        If (IdadeInteiro < 3 Or IdadeInteiro > 16) Then
            MsgBox("Invalid date of birth at test date")
        ElseIf (Namechild.Text = "") Then
            MsgBox("Insert the name of the child")
        Else
            ChildBindingSource.EndEdit()
            ChildTableAdapter.Update(Banco_de_dadosDataSet.Child)
            Cancel.PerformClick()
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim Dateborn As Date
        Dim Dateassessment As Date
        Dim Datet As TimeSpan
        Dim Diff As Double

        Dateborn = DateTimePicker2.Value.ToShortDateString
        Dateassessment = DateTimePicker1.Value.ToShortDateString
        Datet = (Dateassessment - Dateborn)
        Diff = Datet.Days
        IdadeInteiro = Int(Diff / 365)
        ageYears.Text = (Str(Int(Diff / 365)) + " years,")
        Diff = Diff Mod 365
        ageYears.Text = ageYears.Text + (Str(Int(Diff / 30)) + " month(s)")
        Diff = Diff Mod 30
        ageInteger.Text = "Age: " + Str(IdadeInteiro)
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click

        assesschildbtn.PerformClick()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtChecklist.Click
        'If que redireciona para o formulário adequado de Banda relacionado com a idade

        Select Case IdadeInteiro 'linha de código para direcionar o formulário adequado a idade  
            Case 3 To 11
                'A maneira correta é assim, repetir nos demais cases. Não chamar Diretamento o formulário, mas criar ele dentro de uma variável
                Dim formulario As New Checklist_MABC2

                'formulario.child_id = Id_child.Value

                'formulario.date_assesment = DateTimePicker1.Value

                formulario.Show()
            Case Else
                MsgBox("Invalid age for check list assessment")
        End Select
    End Sub

End Class