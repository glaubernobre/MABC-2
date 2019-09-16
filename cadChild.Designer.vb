<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class cadChild
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cadChild))
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ChcodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChNameofchildDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChDateofBirthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gen_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChildBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Banco_de_dadosDataSet = New WindowsApplication1.Banco_de_dadosDataSet()
        Me.ageYears = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Namechild = New System.Windows.Forms.TextBox()
        Me.ageyearsmonthdyas = New System.Windows.Forms.Label()
        Me.databirth = New System.Windows.Forms.Label()
        Me.datatest = New System.Windows.Forms.Label()
        Me.Name_child = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Id_child = New System.Windows.Forms.NumericUpDown()
        Me.preferredHandCombox = New System.Windows.Forms.ComboBox()
        Me.PreferedhandBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.genderCombox = New System.Windows.Forms.ComboBox()
        Me.GeneroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Insertbtn = New System.Windows.Forms.Button()
        Me.updatebtn = New System.Windows.Forms.Button()
        Me.deletebtn = New System.Windows.Forms.Button()
        Me.Save = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.assesschildbtn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Save2 = New System.Windows.Forms.Button()
        Me.ChildTableAdapter = New WindowsApplication1.Banco_de_dadosDataSetTableAdapters.ChildTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LanguangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeneroTableAdapter = New WindowsApplication1.Banco_de_dadosDataSetTableAdapters.generoTableAdapter()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ageInteger = New System.Windows.Forms.Label()
        Me.BtChecklist = New System.Windows.Forms.Button()
        Me.Prefered_handTableAdapter = New WindowsApplication1.Banco_de_dadosDataSetTableAdapters.prefered_handTableAdapter()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChildBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Banco_de_dadosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Id_child, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreferedhandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ChcodigoDataGridViewTextBoxColumn, Me.ChNameofchildDataGridViewTextBoxColumn, Me.ChDateofBirthDataGridViewTextBoxColumn, Me.gen_codigo})
        Me.DataGridView1.DataSource = Me.ChildBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(11, 200)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(541, 260)
        Me.DataGridView1.TabIndex = 8
        '
        'ChcodigoDataGridViewTextBoxColumn
        '
        Me.ChcodigoDataGridViewTextBoxColumn.DataPropertyName = "Ch_codigo"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ChcodigoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.ChcodigoDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.ChcodigoDataGridViewTextBoxColumn.Name = "ChcodigoDataGridViewTextBoxColumn"
        Me.ChcodigoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ChcodigoDataGridViewTextBoxColumn.Width = 50
        '
        'ChNameofchildDataGridViewTextBoxColumn
        '
        Me.ChNameofchildDataGridViewTextBoxColumn.DataPropertyName = "Ch_Name_of_child"
        Me.ChNameofchildDataGridViewTextBoxColumn.HeaderText = "Name of child"
        Me.ChNameofchildDataGridViewTextBoxColumn.Name = "ChNameofchildDataGridViewTextBoxColumn"
        Me.ChNameofchildDataGridViewTextBoxColumn.ReadOnly = True
        Me.ChNameofchildDataGridViewTextBoxColumn.Width = 250
        '
        'ChDateofBirthDataGridViewTextBoxColumn
        '
        Me.ChDateofBirthDataGridViewTextBoxColumn.DataPropertyName = "Ch_Date_of_Birth"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ChDateofBirthDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.ChDateofBirthDataGridViewTextBoxColumn.HeaderText = "Date of Birth"
        Me.ChDateofBirthDataGridViewTextBoxColumn.Name = "ChDateofBirthDataGridViewTextBoxColumn"
        Me.ChDateofBirthDataGridViewTextBoxColumn.ReadOnly = True
        Me.ChDateofBirthDataGridViewTextBoxColumn.Width = 150
        '
        'gen_codigo
        '
        Me.gen_codigo.DataPropertyName = "gen_codigo"
        Me.gen_codigo.HeaderText = "Gender"
        Me.gen_codigo.Name = "gen_codigo"
        Me.gen_codigo.ReadOnly = True
        '
        'ChildBindingSource
        '
        Me.ChildBindingSource.DataMember = "Child"
        Me.ChildBindingSource.DataSource = Me.Banco_de_dadosDataSet
        '
        'Banco_de_dadosDataSet
        '
        Me.Banco_de_dadosDataSet.DataSetName = "Banco_de_dadosDataSet"
        Me.Banco_de_dadosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ageYears
        '
        Me.ageYears.AutoSize = True
        Me.ageYears.Location = New System.Drawing.Point(248, 70)
        Me.ageYears.Name = "ageYears"
        Me.ageYears.Size = New System.Drawing.Size(47, 13)
        Me.ageYears.TabIndex = 213
        Me.ageYears.Text = "DDDDD"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(447, 47)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(105, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'Namechild
        '
        Me.Namechild.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.ChildBindingSource, "Ch_codigo", True))
        Me.Namechild.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ChildBindingSource, "Ch_Name_of_child", True))
        Me.Namechild.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Namechild.Location = New System.Drawing.Point(79, 14)
        Me.Namechild.MaxLength = 45
        Me.Namechild.Name = "Namechild"
        Me.Namechild.Size = New System.Drawing.Size(275, 20)
        Me.Namechild.TabIndex = 206
        '
        'ageyearsmonthdyas
        '
        Me.ageyearsmonthdyas.AutoSize = True
        Me.ageyearsmonthdyas.Location = New System.Drawing.Point(213, 70)
        Me.ageyearsmonthdyas.Name = "ageyearsmonthdyas"
        Me.ageyearsmonthdyas.Size = New System.Drawing.Size(29, 13)
        Me.ageyearsmonthdyas.TabIndex = 210
        Me.ageyearsmonthdyas.Text = "Age:"
        '
        'databirth
        '
        Me.databirth.AutoSize = True
        Me.databirth.Location = New System.Drawing.Point(177, 46)
        Me.databirth.Name = "databirth"
        Me.databirth.Size = New System.Drawing.Size(66, 13)
        Me.databirth.TabIndex = 209
        Me.databirth.Text = "Date of Birth"
        '
        'datatest
        '
        Me.datatest.AutoSize = True
        Me.datatest.Location = New System.Drawing.Point(379, 50)
        Me.datatest.Name = "datatest"
        Me.datatest.Size = New System.Drawing.Size(62, 13)
        Me.datatest.TabIndex = 208
        Me.datatest.Text = "Date of test"
        '
        'Name_child
        '
        Me.Name_child.AutoSize = True
        Me.Name_child.Location = New System.Drawing.Point(8, 17)
        Me.Name_child.Name = "Name_child"
        Me.Name_child.Size = New System.Drawing.Size(72, 13)
        Me.Name_child.TabIndex = 207
        Me.Name_child.Text = "Name of child"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.ChildBindingSource, "Ch_codigo", True))
        Me.DateTimePicker2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ChildBindingSource, "Ch_Date_of_Birth", True))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(249, 41)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(105, 20)
        Me.DateTimePicker2.TabIndex = 214
        Me.DateTimePicker2.Value = New Date(2016, 5, 18, 21, 25, 18, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(38, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 215
        Me.Label7.Text = "Gender"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 216
        Me.Label1.Text = "Preferred hand"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Id_child)
        Me.Panel1.Controls.Add(Me.preferredHandCombox)
        Me.Panel1.Controls.Add(Me.genderCombox)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Controls.Add(Me.Namechild)
        Me.Panel1.Controls.Add(Me.databirth)
        Me.Panel1.Controls.Add(Me.ageYears)
        Me.Panel1.Controls.Add(Me.Name_child)
        Me.Panel1.Controls.Add(Me.ageyearsmonthdyas)
        Me.Panel1.Location = New System.Drawing.Point(12, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(361, 104)
        Me.Panel1.TabIndex = 217
        '
        'Id_child
        '
        Me.Id_child.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.ChildBindingSource, "Ch_codigo", True))
        Me.Id_child.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ChildBindingSource, "Ch_codigo", True))
        Me.Id_child.Enabled = False
        Me.Id_child.Location = New System.Drawing.Point(3, 46)
        Me.Id_child.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.Id_child.Name = "Id_child"
        Me.Id_child.Size = New System.Drawing.Size(36, 20)
        Me.Id_child.TabIndex = 230
        Me.Id_child.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'preferredHandCombox
        '
        Me.preferredHandCombox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ChildBindingSource, "pfh_codigo", True))
        Me.preferredHandCombox.DataSource = Me.PreferedhandBindingSource
        Me.preferredHandCombox.DisplayMember = "Pfh_descricao"
        Me.preferredHandCombox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.preferredHandCombox.FormattingEnabled = True
        Me.preferredHandCombox.Location = New System.Drawing.Point(79, 67)
        Me.preferredHandCombox.Name = "preferredHandCombox"
        Me.preferredHandCombox.Size = New System.Drawing.Size(93, 21)
        Me.preferredHandCombox.TabIndex = 218
        Me.preferredHandCombox.ValueMember = "Pfh_codigo"
        '
        'PreferedhandBindingSource
        '
        Me.PreferedhandBindingSource.DataMember = "prefered_hand"
        Me.PreferedhandBindingSource.DataSource = Me.Banco_de_dadosDataSet
        '
        'genderCombox
        '
        Me.genderCombox.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.GeneroBindingSource, "gen_codigo", True))
        Me.genderCombox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ChildBindingSource, "gen_codigo", True))
        Me.genderCombox.DataSource = Me.GeneroBindingSource
        Me.genderCombox.DisplayMember = "gen_descricao"
        Me.genderCombox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.genderCombox.FormattingEnabled = True
        Me.genderCombox.Location = New System.Drawing.Point(79, 40)
        Me.genderCombox.Name = "genderCombox"
        Me.genderCombox.Size = New System.Drawing.Size(93, 21)
        Me.genderCombox.TabIndex = 217
        Me.genderCombox.ValueMember = "gen_codigo"
        '
        'GeneroBindingSource
        '
        Me.GeneroBindingSource.DataMember = "genero"
        Me.GeneroBindingSource.DataSource = Me.Banco_de_dadosDataSet
        '
        'Insertbtn
        '
        Me.Insertbtn.BackColor = System.Drawing.Color.White
        Me.Insertbtn.Image = CType(resources.GetObject("Insertbtn.Image"), System.Drawing.Image)
        Me.Insertbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Insertbtn.Location = New System.Drawing.Point(4, 2)
        Me.Insertbtn.Name = "Insertbtn"
        Me.Insertbtn.Size = New System.Drawing.Size(75, 28)
        Me.Insertbtn.TabIndex = 2
        Me.Insertbtn.Text = "  Insert"
        Me.Insertbtn.UseVisualStyleBackColor = False
        '
        'updatebtn
        '
        Me.updatebtn.BackColor = System.Drawing.Color.White
        Me.updatebtn.Image = CType(resources.GetObject("updatebtn.Image"), System.Drawing.Image)
        Me.updatebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.updatebtn.Location = New System.Drawing.Point(81, 2)
        Me.updatebtn.Name = "updatebtn"
        Me.updatebtn.Size = New System.Drawing.Size(75, 28)
        Me.updatebtn.TabIndex = 3
        Me.updatebtn.Text = "  Edit"
        Me.updatebtn.UseVisualStyleBackColor = False
        '
        'deletebtn
        '
        Me.deletebtn.BackColor = System.Drawing.Color.White
        Me.deletebtn.Image = CType(resources.GetObject("deletebtn.Image"), System.Drawing.Image)
        Me.deletebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.deletebtn.Location = New System.Drawing.Point(161, 2)
        Me.deletebtn.Name = "deletebtn"
        Me.deletebtn.Size = New System.Drawing.Size(75, 28)
        Me.deletebtn.TabIndex = 220
        Me.deletebtn.Text = "    Delete"
        Me.deletebtn.UseVisualStyleBackColor = False
        '
        'Save
        '
        Me.Save.BackColor = System.Drawing.Color.White
        Me.Save.Image = CType(resources.GetObject("Save.Image"), System.Drawing.Image)
        Me.Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Save.Location = New System.Drawing.Point(19, 2)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(75, 28)
        Me.Save.TabIndex = 6
        Me.Save.Text = " Save"
        Me.Save.UseVisualStyleBackColor = False
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.Color.White
        Me.Cancel.Image = CType(resources.GetObject("Cancel.Image"), System.Drawing.Image)
        Me.Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cancel.Location = New System.Drawing.Point(102, 2)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 28)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "  Cancel"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'assesschildbtn
        '
        Me.assesschildbtn.BackColor = System.Drawing.Color.White
        Me.assesschildbtn.Image = CType(resources.GetObject("assesschildbtn.Image"), System.Drawing.Image)
        Me.assesschildbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.assesschildbtn.Location = New System.Drawing.Point(445, 78)
        Me.assesschildbtn.Name = "assesschildbtn"
        Me.assesschildbtn.Size = New System.Drawing.Size(107, 28)
        Me.assesschildbtn.TabIndex = 223
        Me.assesschildbtn.Text = "New Band"
        Me.assesschildbtn.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.deletebtn)
        Me.Panel2.Controls.Add(Me.updatebtn)
        Me.Panel2.Controls.Add(Me.Insertbtn)
        Me.Panel2.Location = New System.Drawing.Point(7, 143)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(247, 34)
        Me.Panel2.TabIndex = 224
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Save2)
        Me.Panel3.Controls.Add(Me.Cancel)
        Me.Panel3.Controls.Add(Me.Save)
        Me.Panel3.Location = New System.Drawing.Point(329, 144)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(184, 32)
        Me.Panel3.TabIndex = 225
        '
        'Save2
        '
        Me.Save2.BackColor = System.Drawing.Color.White
        Me.Save2.Image = CType(resources.GetObject("Save2.Image"), System.Drawing.Image)
        Me.Save2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Save2.Location = New System.Drawing.Point(7, 2)
        Me.Save2.Name = "Save2"
        Me.Save2.Size = New System.Drawing.Size(75, 28)
        Me.Save2.TabIndex = 4
        Me.Save2.Text = "    Confirm"
        Me.Save2.UseVisualStyleBackColor = False
        Me.Save2.Visible = False
        '
        'ChildTableAdapter
        '
        Me.ChildTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(564, 24)
        Me.MenuStrip1.TabIndex = 226
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.toolStripSeparator2, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.FileToolStripMenuItem.Text = "&Assessment"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = CType(resources.GetObject("OpenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(143, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomizeToolStripMenuItem, Me.OptionsToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'CustomizeToolStripMenuItem
        '
        Me.CustomizeToolStripMenuItem.Name = "CustomizeToolStripMenuItem"
        Me.CustomizeToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.CustomizeToolStripMenuItem.Text = "&Customize"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LanguangeToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.OptionsToolStripMenuItem.Text = "&Options"
        '
        'LanguangeToolStripMenuItem
        '
        Me.LanguangeToolStripMenuItem.Name = "LanguangeToolStripMenuItem"
        Me.LanguangeToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.LanguangeToolStripMenuItem.Text = "Languange"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem, Me.toolStripSeparator5, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.ContentsToolStripMenuItem.Text = "&Contents"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(119, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.AboutToolStripMenuItem.Text = "&About..."
        '
        'GeneroTableAdapter
        '
        Me.GeneroTableAdapter.ClearBeforeFill = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(396, 79)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(27, 33)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 228
        Me.PictureBox2.TabStop = False
        '
        'ageInteger
        '
        Me.ageInteger.AutoSize = True
        Me.ageInteger.Location = New System.Drawing.Point(500, 50)
        Me.ageInteger.Name = "ageInteger"
        Me.ageInteger.Size = New System.Drawing.Size(26, 13)
        Me.ageInteger.TabIndex = 229
        Me.ageInteger.Text = "Age"
        '
        'BtChecklist
        '
        Me.BtChecklist.BackColor = System.Drawing.Color.White
        Me.BtChecklist.Image = CType(resources.GetObject("BtChecklist.Image"), System.Drawing.Image)
        Me.BtChecklist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtChecklist.Location = New System.Drawing.Point(445, 113)
        Me.BtChecklist.Name = "BtChecklist"
        Me.BtChecklist.Size = New System.Drawing.Size(107, 28)
        Me.BtChecklist.TabIndex = 230
        Me.BtChecklist.Text = "      New check list"
        Me.BtChecklist.UseVisualStyleBackColor = False
        '
        'Prefered_handTableAdapter
        '
        Me.Prefered_handTableAdapter.ClearBeforeFill = True
        '
        'cadChild
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(564, 472)
        Me.Controls.Add(Me.BtChecklist)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.assesschildbtn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.datatest)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ageInteger)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "cadChild"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Child "
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChildBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Banco_de_dadosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Id_child, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreferedhandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ageYears As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Namechild As TextBox
    Friend WithEvents ageyearsmonthdyas As Label
    Friend WithEvents databirth As Label
    Friend WithEvents datatest As Label
    Friend WithEvents Name_child As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents preferredHandCombox As ComboBox
    Friend WithEvents genderCombox As ComboBox
    Friend WithEvents Insertbtn As Button
    Friend WithEvents updatebtn As Button
    Friend WithEvents deletebtn As Button
    Friend WithEvents Save As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents assesschildbtn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Banco_de_dadosDataSet As Banco_de_dadosDataSet
    Friend WithEvents ChildBindingSource As BindingSource
    Friend WithEvents ChildTableAdapter As Banco_de_dadosDataSetTableAdapters.ChildTableAdapter
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LanguangeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GeneroBindingSource As BindingSource
    Friend WithEvents GeneroTableAdapter As Banco_de_dadosDataSetTableAdapters.generoTableAdapter
    Friend WithEvents PreferedhandBindingSource As BindingSource
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ChcodigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ChNameofchildDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ChDateofBirthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents gen_codigo As DataGridViewTextBoxColumn
    Friend WithEvents ageInteger As Label
    Friend WithEvents Id_child As NumericUpDown
    Friend WithEvents Save2 As Button
    Friend WithEvents BtChecklist As Button
    Friend WithEvents Prefered_handTableAdapter As Banco_de_dadosDataSetTableAdapters.prefered_handTableAdapter
End Class
