<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class cadnewschool
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cadnewschool))
        Me.descricaoTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SchoolTableAdapter1 = New WindowsApplication1.Banco_de_dadosDataSetTableAdapters.SchoolTableAdapter()
        Me.Banco_de_dadosDataSet1 = New WindowsApplication1.Banco_de_dadosDataSet()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.Banco_de_dadosDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'descricaoTextBox
        '
        Me.descricaoTextBox.Location = New System.Drawing.Point(58, 20)
        Me.descricaoTextBox.Name = "descricaoTextBox"
        Me.descricaoTextBox.Size = New System.Drawing.Size(266, 20)
        Me.descricaoTextBox.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(95, 59)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(193, 59)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 129
        Me.Label8.Text = "School"
        '
        'SchoolTableAdapter1
        '
        Me.SchoolTableAdapter1.ClearBeforeFill = True
        '
        'Banco_de_dadosDataSet1
        '
        Me.Banco_de_dadosDataSet1.DataSetName = "Banco_de_dadosDataSet"
        Me.Banco_de_dadosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cadnewschool
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 94)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.descricaoTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(374, 133)
        Me.MinimumSize = New System.Drawing.Size(374, 133)
        Me.Name = "cadnewschool"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register new School"
        CType(Me.Banco_de_dadosDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents descricaoTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents SchoolTableAdapter1 As Banco_de_dadosDataSetTableAdapters.SchoolTableAdapter
    Friend WithEvents Banco_de_dadosDataSet1 As Banco_de_dadosDataSet
    Friend WithEvents BindingSource1 As BindingSource
End Class
