Public Class Form1
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub
    Private Sub Label23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label23.Click
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
    End Sub
    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label16.Click
    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Me.TextBox3.Text = "F"
            TextBox3.Enabled = False
        Else
            TextBox3.Text = ""
            TextBox3.Enabled = True
        End If
    End Sub
    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            Me.TextBox4.Text = "F"
            TextBox4.Enabled = False
        Else
            TextBox4.Text = ""
            TextBox4.Enabled = True
        End If
    End Sub
    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            Me.TextBox5.Text = "F"
            TextBox5.Enabled = False
        Else
            TextBox5.Text = ""
            TextBox5.Enabled = True
        End If
    End Sub
    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            Me.TextBox6.Text = "F"
            TextBox6.Enabled = False
        Else
            TextBox6.Text = ""
            TextBox6.Enabled = True
        End If
    End Sub

    Private Sub MaskedTextBox4_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs)

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Label24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected
        Dim datadeavaliação As Date
        Dim datadenascimento As Date

        datadeavaliação = TextBox1.Text
        datadenascimento = TextBox2.Text

    End Sub
    Private Sub TextBox7_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.Leave
        Dim CatchingtwoHands As Integer
        CatchingtwoHands = TextBox7.Text
        If CatchingtwoHands > 10 Then
            MsgBox("Error value. Insert value up 10", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub

    Private Sub TextBox8_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.Leave
        Dim ThrowingBeanbagontomat As Integer
        ThrowingBeanbagontomat = TextBox8.Text
        If ThrowingBeanbagontomat > 10 Then
            MsgBox("Erro value. Insert value up 10", MsgBoxStyle.OkOnly, "Erro")
        Else
            TextBox8.Text = ""
        End If

    End Sub

    Private Sub TextBox9_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.Leave
        Dim OneboardBalancebestleg As Integer
        OneboardBalancebestleg = TextBox9.Text
        If OneboardBalancebestleg > 30 Then
            MsgBox("Error value. Insert value up 30", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub

    Private Sub TextBox10_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox10.Leave
        Dim OneboardBalanceotherleg As Integer
        OneboardBalanceotherleg = TextBox10.Text
        If OneboardBalanceotherleg > 30 Then
            MsgBox("Error value. Insert value up 30", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub

    Private Sub TextBox11_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox11.Leave
        Dim WalkingToetoHellForwards As Integer
        WalkingToetoHellForwards = TextBox11.Text
        If WalkingToetoHellForwards > 15 Then
            MsgBox("Error value. Insert value up 15", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

    End Sub

    Private Sub MaskedTextBox2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaskedTextBox2.Leave

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub

    Private Sub TextBox3_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.Leave

    End Sub

    Private Sub textbox4_leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.Leave


    End Sub
End Class
