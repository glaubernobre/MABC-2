Imports Microsoft.Office.Interop 'Necessário para utilizar funções do Access
Public Class SearchForm
    Private Sub Search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Banco_de_dadosDataSet.Band3_Join' table. You can move, or remove it, as needed.
        Me.Band3_JoinTableAdapter.Fill(Me.Banco_de_dadosDataSet.Band3_Join)
        'TODO: This line of code loads data into the 'Banco_de_dadosDataSet.Band2_Join' table. You can move, or remove it, as needed.
        Me.Band2_JoinTableAdapter.Fill(Me.Banco_de_dadosDataSet.Band2_Join)
        'TODO: This line of code loads data into the 'Banco_de_dadosDataSet.Band1_Join' table. You can move, or remove it, as needed.
        Me.Band1_JoinTableAdapter.Fill(Me.Banco_de_dadosDataSet.Band1_Join)
        'TODO: This line of code loads data into the 'Banco_de_dadosDataSet.Child' table. You can move, or remove it, as needed.
        Me.ChildTableAdapter.Fill(Me.Banco_de_dadosDataSet.Child)
        'TODO: This line of code loads data into the 'Banco_de_dadosDataSet.Administer' table. You can move, or remove it, as needed.
        Me.AdministerTableAdapter.Fill(Me.Banco_de_dadosDataSet.Administer)
        'TODO: This line of code loads data into the 'Banco_de_dadosDataSet.School' table. You can move, or remove it, as needed.
        Me.SchoolTableAdapter.Fill(Me.Banco_de_dadosDataSet.School)
        'TODO: This line of code loads data into the 'Banco_de_dadosDataSet.Band1' table. You can move, or remove it, as needed.
        Me.Band1TableAdapter.Fill(Me.Banco_de_dadosDataSet.Band1)

        Lb_Band1.Text = "Band1 - N Selected rows " & Band1JoinBindingSource.Count
        Lb_Band2.Text = "Band2 - N Selected rows " & Band2JoinBindingSource.Count
        Lb_Band3.Text = "Band3 - N Selected rows " & Band3JoinBindingSource.Count

        For i = 0 To clboxShowBand.Items.Count - 1
            clboxShowBand.SetItemChecked(i, True)
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim filtro As String

        filtro = ""


        If ChBoxName.Checked Then

            filtro = "Ch_codigo = " & ComboBox1.SelectedValue

        End If

        If ChBoxSchool.Checked Then

            If filtro = "" Then

                filtro = "Sch_codigo = " & ComboBox2.SelectedValue
            Else

                filtro = filtro & " AND Sch_codigo = " & ComboBox2.SelectedValue

            End If

        End If

        If ChBoxAdminister.Checked Then

            If filtro = "" Then

                filtro = "Adm_codigo = " & ComboBox3.SelectedValue

            Else

                filtro = filtro & " AND Adm_codigo = " & ComboBox3.SelectedValue

            End If

        End If

        Band1JoinBindingSource.Filter = filtro
        Lb_Band1.Text = "Band1 - N Selected rows " & Band1JoinBindingSource.Count

        Band2JoinBindingSource.Filter = filtro
        Lb_Band2.Text = "Band2 - N Selected rows " & Band2JoinBindingSource.Count

        Band3JoinBindingSource.Filter = filtro
        Lb_Band3.Text = "Band3 - N Selected rows " & Band3JoinBindingSource.Count

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Band1JoinBindingSource.RemoveFilter()
        Band2JoinBindingSource.RemoveFilter()
        Band3JoinBindingSource.RemoveFilter()

        ChBoxName.Checked = False
        ChBoxSchool.Checked = False
        ChBoxAdminister.Checked = False

        Lb_Band1.Text = "Band1 - N Selected rows " & Band1JoinBindingSource.Count
        Lb_Band2.Text = "Band2 - N Selected rows " & Band2JoinBindingSource.Count
        Lb_Band3.Text = "Band3 - N Selected rows " & Band3JoinBindingSource.Count

    End Sub

    Private Sub ChBoxName_CheckedChanged(sender As Object, e As EventArgs) Handles ChBoxName.CheckedChanged

        ComboBox1.Enabled = ChBoxName.Checked

    End Sub

    Private Sub ChBoxSchool_CheckedChanged(sender As Object, e As EventArgs) Handles ChBoxSchool.CheckedChanged

        ComboBox2.Enabled = ChBoxSchool.Checked


    End Sub

    Private Sub ChBoxAdminister_CheckedChanged(sender As Object, e As EventArgs) Handles ChBoxAdminister.CheckedChanged

        ComboBox3.Enabled = ChBoxAdminister.Checked

    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click

        Dim appAccess As Object

        ' Funções para adiquirir a pasta atual da aplicação
        Dim pastaEXE As String

        Dim arquivoDB As String

        Dim arquivoPDF As String



        pastaEXE = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase) 'usa a função do VB para buscar o nome do diretório do aplicativo em execução
        pastaEXE = New Uri(pastaEXE).LocalPath 'Transforma em uma String compreensivel ao Explorer
        arquivoDB = pastaEXE & "\Banco de dados.accdb" 'Adiciona o nome do arquivo de banco de dados

        arquivoPDF = pastaEXE & "\relatorio.pdf"

        appAccess = CreateObject("Access.Application")
        appAccess.visible = False
        appAccess.opencurrentdatabase(arquivoDB)

        'Filtros

        Dim filtro As String

        filtro = ""

        If ChBoxName.Checked Then
            filtro = "Ch_codigo = " & ComboBox1.SelectedValue
        End If

        If ChBoxSchool.Checked Then

            If filtro = "" Then
                filtro = "Sch_codigo = " & ComboBox2.SelectedValue
            Else
                filtro = filtro & " AND Sch_codigo = " & ComboBox2.SelectedValue
            End If

        End If

        If ChBoxAdminister.Checked Then

            If filtro = "" Then
                filtro = "Adm_codigo = " & ComboBox3.SelectedValue
            Else
                filtro = filtro & " AND Adm_codigo = " & ComboBox3.SelectedValue
            End If

        End If

        'appAccess.docmd.openreport(ReportName:="Band1_geral", View:=Access.AcView.acViewPreview, WhereCondition:=filtro)

        'appAccess.DoCmd.SelectObject(Objecttype:=Access.AcObjectType.acReport, Objectname:="Band1_geral", imdatabasewindow:=True)

        appAccess.docmd.outputto(Objecttype:=Access.AcObjectType.acReport, Objectname:="Band1_geral", outputformat:="PDF Format (*.pdf)", outputfile:=arquivoPDF)

        Process.Start(arquivoPDF)


    End Sub

    Private Sub BtnexportExcel_Click(sender As Object, e As EventArgs) Handles BtnexportExcel.Click

        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        ' Funções para adiquirir a pasta atual da aplicação
        Dim pastaEXE As String
        Dim arquivoXLS As String
        Dim k As Integer

        pastaEXE = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase) 'usa a função do VB para buscar o nome do diretório do aplicativo em execução
        pastaEXE = New Uri(pastaEXE).LocalPath 'Transforma em uma String compreensivel ao Explorer


        xlApp = New Microsoft.Office.Interop.Excel.ApplicationClass
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkBook.Sheets.Add()
        xlWorkBook.Sheets.Add()

        xlWorkSheet = xlWorkBook.Sheets(1)
        xlWorkSheet.Name = "Age Band 1"
        For i = 0 To DaGrViewBand1.RowCount - 1
            For j = 0 To DaGrViewBand1.ColumnCount - 1
                k = j + 1
                xlWorkSheet.Cells(1, k) = DaGrViewBand1.Columns(j).HeaderText
                xlWorkSheet.Cells(i + 2, j + 1) = DaGrViewBand1(j, i).Value.ToString()

            Next
        Next

        releaseObject(xlWorkSheet)

        xlWorkSheet = xlWorkBook.Sheets(2)
        xlWorkSheet.Name = "Age Band 2"
        For i = 0 To DaGrViewBand2.RowCount - 1
            For j = 0 To DaGrViewBand2.ColumnCount - 1
                k = j + 1
                xlWorkSheet.Cells(1, k) = DaGrViewBand2.Columns(j).HeaderText
                xlWorkSheet.Cells(i + 2, j + 1) = DaGrViewBand2(j, i).Value.ToString()

            Next
        Next

        releaseObject(xlWorkSheet)

        xlWorkSheet = xlWorkBook.Sheets(3)
        xlWorkSheet.Name = "Age Band 3"
        For i = 0 To DaGrViewBand3.RowCount - 1
            For j = 0 To DaGrViewBand3.ColumnCount - 1
                k = j + 1
                xlWorkSheet.Cells(1, k) = DaGrViewBand3.Columns(j).HeaderText
                xlWorkSheet.Cells(i + 2, j + 1) = DaGrViewBand3(j, i).Value.ToString()

            Next
        Next

        arquivoXLS = pastaEXE & "\excel.xlsx"

        xlWorkSheet.SaveAs(arquivoXLS)

        xlWorkBook.Close()

        xlApp.Quit()

        releaseObject(xlApp)

        releaseObject(xlWorkBook)

        releaseObject(xlWorkSheet)

        Process.Start(arquivoXLS)
    End Sub


    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try

    End Sub

    Private Sub DaGrViewBand1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DaGrViewBand1.CellContentClick

    End Sub

    Private Sub clboxShowBand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clboxShowBand.SelectedIndexChanged

        If (clboxShowBand.GetItemCheckState(0)) Then
            TabPage1.Visible = True
        Else
            TabPage1.Visible = False
        End If

        If (clboxShowBand.GetItemCheckState(1)) Then
            TabPage2.Visible = True
        Else
            TabPage2.Visible = False
        End If

        If (clboxShowBand.GetItemCheckState(2)) Then
            TabPage3.Visible = True
        Else
            TabPage3.Visible = False
        End If
    End Sub

    Private Sub btn_Edit_Band1_Click(sender As Object, e As EventArgs) Handles btn_Edit_Band1.Click

        Dim formulario As New Formulario_Banda_1

        formulario.codigo_edit = DaGrViewBand1.Item(0, DaGrViewBand1.CurrentRow.Index).Value

        formulario.Show()

    End Sub
End Class