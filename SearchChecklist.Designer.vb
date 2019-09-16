<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchChecklist
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchChecklist))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ChBoxAdminister = New System.Windows.Forms.CheckBox()
        Me.ChBoxSchool = New System.Windows.Forms.CheckBox()
        Me.ChBoxName = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.BtnChecklistEdit = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.BtnexportExcel = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Lb_Band1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.ChBoxAdminister)
        Me.GroupBox1.Controls.Add(Me.ChBoxSchool)
        Me.GroupBox1.Controls.Add(Me.ChBoxName)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.ComboBox3)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(232, 261)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(19, 143)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(18, 21)
        Me.PictureBox3.TabIndex = 249
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(17, 25)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(22, 21)
        Me.PictureBox2.TabIndex = 248
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(17, 84)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(23, 21)
        Me.PictureBox1.TabIndex = 247
        Me.PictureBox1.TabStop = False
        '
        'ChBoxAdminister
        '
        Me.ChBoxAdminister.AutoSize = True
        Me.ChBoxAdminister.Location = New System.Drawing.Point(43, 148)
        Me.ChBoxAdminister.Name = "ChBoxAdminister"
        Me.ChBoxAdminister.Size = New System.Drawing.Size(74, 17)
        Me.ChBoxAdminister.TabIndex = 16
        Me.ChBoxAdminister.Text = "Administer"
        Me.ChBoxAdminister.UseVisualStyleBackColor = True
        '
        'ChBoxSchool
        '
        Me.ChBoxSchool.AutoSize = True
        Me.ChBoxSchool.Location = New System.Drawing.Point(45, 89)
        Me.ChBoxSchool.Name = "ChBoxSchool"
        Me.ChBoxSchool.Size = New System.Drawing.Size(59, 17)
        Me.ChBoxSchool.TabIndex = 15
        Me.ChBoxSchool.Text = "School"
        Me.ChBoxSchool.UseVisualStyleBackColor = True
        '
        'ChBoxName
        '
        Me.ChBoxName.AutoSize = True
        Me.ChBoxName.Location = New System.Drawing.Point(45, 29)
        Me.ChBoxName.Name = "ChBoxName"
        Me.ChBoxName.Size = New System.Drawing.Size(54, 17)
        Me.ChBoxName.TabIndex = 14
        Me.ChBoxName.Text = "Name"
        Me.ChBoxName.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(96, 218)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 28)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = " Clear"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(15, 218)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 28)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "   Search"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ComboBox3
        '
        Me.ComboBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox3.DisplayMember = "Adm_descricao"
        Me.ComboBox3.Enabled = False
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(16, 171)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(173, 21)
        Me.ComboBox3.TabIndex = 8
        Me.ComboBox3.ValueMember = "Adm_codigo"
        '
        'ComboBox2
        '
        Me.ComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox2.DisplayMember = "Sch_descricao"
        Me.ComboBox2.Enabled = False
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ComboBox2.Location = New System.Drawing.Point(16, 111)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(172, 21)
        Me.ComboBox2.TabIndex = 7
        Me.ComboBox2.ValueMember = "Sch_codigo"
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.DisplayMember = "Ch_Name_of_child"
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(17, 52)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(172, 21)
        Me.ComboBox1.TabIndex = 6
        Me.ComboBox1.ValueMember = "Ch_codigo"
        '
        'BtnChecklistEdit
        '
        Me.BtnChecklistEdit.BackColor = System.Drawing.Color.White
        Me.BtnChecklistEdit.Image = CType(resources.GetObject("BtnChecklistEdit.Image"), System.Drawing.Image)
        Me.BtnChecklistEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnChecklistEdit.Location = New System.Drawing.Point(6, 19)
        Me.BtnChecklistEdit.Name = "BtnChecklistEdit"
        Me.BtnChecklistEdit.Size = New System.Drawing.Size(133, 28)
        Me.BtnChecklistEdit.TabIndex = 231
        Me.BtnChecklistEdit.Text = "Edit check list"
        Me.BtnChecklistEdit.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnPrint)
        Me.GroupBox2.Controls.Add(Me.BtnexportExcel)
        Me.GroupBox2.Controls.Add(Me.BtnChecklistEdit)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 299)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(232, 253)
        Me.GroupBox2.TabIndex = 232
        Me.GroupBox2.TabStop = False
        '
        'BtnPrint
        '
        Me.BtnPrint.BackColor = System.Drawing.Color.White
        Me.BtnPrint.Image = CType(resources.GetObject("BtnPrint.Image"), System.Drawing.Image)
        Me.BtnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPrint.Location = New System.Drawing.Point(105, 178)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(84, 28)
        Me.BtnPrint.TabIndex = 243
        Me.BtnPrint.Text = " Print"
        Me.BtnPrint.UseVisualStyleBackColor = False
        '
        'BtnexportExcel
        '
        Me.BtnexportExcel.BackColor = System.Drawing.Color.White
        Me.BtnexportExcel.Image = CType(resources.GetObject("BtnexportExcel.Image"), System.Drawing.Image)
        Me.BtnexportExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnexportExcel.Location = New System.Drawing.Point(19, 178)
        Me.BtnexportExcel.Name = "BtnexportExcel"
        Me.BtnexportExcel.Size = New System.Drawing.Size(75, 28)
        Me.BtnexportExcel.TabIndex = 232
        Me.BtnexportExcel.Text = "      Export"
        Me.BtnexportExcel.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(276, 31)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(836, 521)
        Me.DataGridView1.TabIndex = 233
        '
        'Lb_Band1
        '
        Me.Lb_Band1.AutoSize = True
        Me.Lb_Band1.Location = New System.Drawing.Point(278, 13)
        Me.Lb_Band1.Name = "Lb_Band1"
        Me.Lb_Band1.Size = New System.Drawing.Size(56, 13)
        Me.Lb_Band1.TabIndex = 234
        Me.Lb_Band1.Text = "Check list:"
        '
        'SearchChecklist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1143, 587)
        Me.Controls.Add(Me.Lb_Band1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SearchChecklist"
        Me.Text = "Search check list"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ChBoxAdminister As CheckBox
    Friend WithEvents ChBoxSchool As CheckBox
    Friend WithEvents ChBoxName As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents BtnChecklistEdit As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Lb_Band1 As Label
    Friend WithEvents BtnexportExcel As Button
    Friend WithEvents BtnPrint As Button
End Class
