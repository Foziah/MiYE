<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateServiceTypes
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
        Me.components = New System.ComponentModel.Container()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtTypeName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbServices = New System.Windows.Forms.ComboBox()
        Me.TblServicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MIYEDataset = New MIYE.MIYEDataset()
        Me.ViewServiceTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ViewServiceTypesTableAdapter = New MIYE.MIYEDatasetTableAdapters.viewServiceTypesTableAdapter()
        Me.ViewServiceTypesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblServicesTableAdapter = New MIYE.MIYEDatasetTableAdapters.tblServicesTableAdapter()
        Me.gvServiceTypes = New System.Windows.Forms.DataGridView()
        Me.TypeID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.TblServicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MIYEDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewServiceTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewServiceTypesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvServiceTypes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(293, 91)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 10
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'txtTypeName
        '
        Me.txtTypeName.Location = New System.Drawing.Point(197, 65)
        Me.txtTypeName.Name = "txtTypeName"
        Me.txtTypeName.Size = New System.Drawing.Size(171, 20)
        Me.txtTypeName.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(88, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Type Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(88, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Select Service"
        '
        'cbServices
        '
        Me.cbServices.DataSource = Me.TblServicesBindingSource
        Me.cbServices.DisplayMember = "ServiceName"
        Me.cbServices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbServices.FormattingEnabled = True
        Me.cbServices.Location = New System.Drawing.Point(197, 34)
        Me.cbServices.Name = "cbServices"
        Me.cbServices.Size = New System.Drawing.Size(171, 21)
        Me.cbServices.TabIndex = 6
        Me.cbServices.ValueMember = "ServiceID"
        '
        'TblServicesBindingSource
        '
        Me.TblServicesBindingSource.DataMember = "tblServices"
        Me.TblServicesBindingSource.DataSource = Me.MIYEDataset
        '
        'MIYEDataset
        '
        Me.MIYEDataset.DataSetName = "MIYEDataset"
        Me.MIYEDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ViewServiceTypesBindingSource
        '
        Me.ViewServiceTypesBindingSource.DataMember = "viewServiceTypes"
        Me.ViewServiceTypesBindingSource.DataSource = Me.MIYEDataset
        '
        'ViewServiceTypesTableAdapter
        '
        Me.ViewServiceTypesTableAdapter.ClearBeforeFill = True
        '
        'ViewServiceTypesBindingSource1
        '
        Me.ViewServiceTypesBindingSource1.DataMember = "viewServiceTypes"
        Me.ViewServiceTypesBindingSource1.DataSource = Me.MIYEDataset
        '
        'TblServicesTableAdapter
        '
        Me.TblServicesTableAdapter.ClearBeforeFill = True
        '
        'gvServiceTypes
        '
        Me.gvServiceTypes.AllowUserToAddRows = False
        Me.gvServiceTypes.AllowUserToDeleteRows = False
        Me.gvServiceTypes.AutoGenerateColumns = False
        Me.gvServiceTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvServiceTypes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ServiceIDDataGridViewTextBoxColumn, Me.ServiceNameDataGridViewTextBoxColumn, Me.TypeNameDataGridViewTextBoxColumn, Me.TypeID})
        Me.gvServiceTypes.DataSource = Me.ViewServiceTypesBindingSource1
        Me.gvServiceTypes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gvServiceTypes.Location = New System.Drawing.Point(0, 146)
        Me.gvServiceTypes.Name = "gvServiceTypes"
        Me.gvServiceTypes.ReadOnly = True
        Me.gvServiceTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvServiceTypes.Size = New System.Drawing.Size(474, 229)
        Me.gvServiceTypes.TabIndex = 11
        '
        'TypeID
        '
        Me.TypeID.DataPropertyName = "TypeID"
        Me.TypeID.HeaderText = "TypeID"
        Me.TypeID.Name = "TypeID"
        Me.TypeID.ReadOnly = True
        Me.TypeID.Visible = False
        '
        'TypeNameDataGridViewTextBoxColumn
        '
        Me.TypeNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.TypeNameDataGridViewTextBoxColumn.DataPropertyName = "TypeName"
        Me.TypeNameDataGridViewTextBoxColumn.Frozen = True
        Me.TypeNameDataGridViewTextBoxColumn.HeaderText = "TypeName"
        Me.TypeNameDataGridViewTextBoxColumn.Name = "TypeNameDataGridViewTextBoxColumn"
        Me.TypeNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.TypeNameDataGridViewTextBoxColumn.Width = 165
        '
        'ServiceNameDataGridViewTextBoxColumn
        '
        Me.ServiceNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ServiceNameDataGridViewTextBoxColumn.DataPropertyName = "ServiceName"
        Me.ServiceNameDataGridViewTextBoxColumn.Frozen = True
        Me.ServiceNameDataGridViewTextBoxColumn.HeaderText = "ServiceName"
        Me.ServiceNameDataGridViewTextBoxColumn.Name = "ServiceNameDataGridViewTextBoxColumn"
        Me.ServiceNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.ServiceNameDataGridViewTextBoxColumn.Width = 166
        '
        'ServiceIDDataGridViewTextBoxColumn
        '
        Me.ServiceIDDataGridViewTextBoxColumn.DataPropertyName = "ServiceID"
        Me.ServiceIDDataGridViewTextBoxColumn.Frozen = True
        Me.ServiceIDDataGridViewTextBoxColumn.HeaderText = "ServiceID"
        Me.ServiceIDDataGridViewTextBoxColumn.Name = "ServiceIDDataGridViewTextBoxColumn"
        Me.ServiceIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmUpdateServiceTypes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 375)
        Me.Controls.Add(Me.gvServiceTypes)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtTypeName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbServices)
        Me.Name = "frmUpdateServiceTypes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Service Type"
        CType(Me.TblServicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MIYEDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewServiceTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewServiceTypesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvServiceTypes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents txtTypeName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbServices As System.Windows.Forms.ComboBox
    Friend WithEvents TblServicesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MIYEDataset As MIYE.MIYEDataset
    Friend WithEvents ViewServiceTypesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ViewServiceTypesTableAdapter As MIYE.MIYEDatasetTableAdapters.viewServiceTypesTableAdapter
    Friend WithEvents ViewServiceTypesBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TblServicesTableAdapter As MIYE.MIYEDatasetTableAdapters.tblServicesTableAdapter
    Friend WithEvents gvServiceTypes As System.Windows.Forms.DataGridView
    Friend WithEvents ServiceIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServiceNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeID As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
