<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class cadNewAdm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cadNewAdm))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.descricaoTextBox = New System.Windows.Forms.TextBox()
        Me.AdministerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Banco_de_dadosDataSet1 = New WindowsApplication1.Banco_de_dadosDataSet()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdministerTableAdapter1 = New WindowsApplication1.Banco_de_dadosDataSetTableAdapters.AdministerTableAdapter()
        CType(Me.AdministerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Banco_de_dadosDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 133
        Me.Label8.Text = "Administer"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(202, 50)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 132
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(104, 50)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 131
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'descricaoTextBox
        '
        Me.descricaoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.AdministerBindingSource, "Adm_codigo", True))
        Me.descricaoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdministerBindingSource, "Adm_descricao", True))
        Me.descricaoTextBox.Location = New System.Drawing.Point(67, 15)
        Me.descricaoTextBox.Name = "descricaoTextBox"
        Me.descricaoTextBox.Size = New System.Drawing.Size(266, 20)
        Me.descricaoTextBox.TabIndex = 130
        '
        'AdministerBindingSource
        '
        Me.AdministerBindingSource.DataMember = "Administer"
        Me.AdministerBindingSource.DataSource = Me.Banco_de_dadosDataSet1
        '
        'Banco_de_dadosDataSet1
        '
        Me.Banco_de_dadosDataSet1.DataSetName = "Banco_de_dadosDataSet"
        Me.Banco_de_dadosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AdministerTableAdapter1
        '
        Me.AdministerTableAdapter1.ClearBeforeFill = True
        '
        'cadNewAdm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.ClientSize = New System.Drawing.Size(353, 87)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.descricaoTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(369, 126)
        Me.MinimumSize = New System.Drawing.Size(369, 126)
        Me.Name = "cadNewAdm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register new Administer"
        CType(Me.AdministerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Banco_de_dadosDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents descricaoTextBox As TextBox
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Banco_de_dadosDataSet1 As Banco_de_dadosDataSet
    Friend WithEvents AdministerTableAdapter1 As Banco_de_dadosDataSetTableAdapters.AdministerTableAdapter
    Friend WithEvents AdministerBindingSource As BindingSource
End Class
