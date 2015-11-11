<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddServiceType
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
        Me.cbServices = New System.Windows.Forms.ComboBox()
        Me.ViewServiceTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MIYEDataset = New MIYE.MIYEDataset()
        Me.ViewServiceTypesTableAdapter = New MIYE.MIYEDatasetTableAdapters.viewServiceTypesTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTypeName = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.gvServiceTypes = New System.Windows.Forms.DataGridView()
        Me.ServiceIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ViewServiceTypesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblServicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblServicesTableAdapter = New MIYE.MIYEDatasetTableAdapters.tblServicesTableAdapter()
        CType(Me.ViewServiceTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MIYEDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvServiceTypes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewServiceTypesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblServicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbServices
        '
        Me.cbServices.DataSource = Me.TblServicesBindingSource
        Me.cbServices.DisplayMember = "ServiceName"
        Me.cbServices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbServices.FormattingEnabled = True
        Me.cbServices.Location = New System.Drawing.Point(206, 40)
        Me.cbServices.Name = "cbServices"
        Me.cbServices.Size = New System.Drawing.Size(171, 21)
        Me.cbServices.TabIndex = 0
        Me.cbServices.ValueMember = "ServiceID"
        '
        'ViewServiceTypesBindingSource
        '
        Me.ViewServiceTypesBindingSource.DataMember = "viewServiceTypes"
        Me.ViewServiceTypesBindingSource.DataSource = Me.MIYEDataset
        '
        'MIYEDataset
        '
        Me.MIYEDataset.DataSetName = "MIYEDataset"
        Me.MIYEDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ViewServiceTypesTableAdapter
        '
        Me.ViewServiceTypesTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(97, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select Service"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(97, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Type Name"
        '
        'txtTypeName
        '
        Me.txtTypeName.Location = New System.Drawing.Point(206, 78)
        Me.txtTypeName.Name = "txtTypeName"
        Me.txtTypeName.Size = New System.Drawing.Size(171, 20)
        Me.txtTypeName.TabIndex = 3
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(302, 104)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'gvServiceTypes
        '
        Me.gvServiceTypes.AllowUserToAddRows = False
        Me.gvServiceTypes.AllowUserToDeleteRows = False
        Me.gvServiceTypes.AutoGenerateColumns = False
        Me.gvServiceTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvServiceTypes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ServiceIDDataGridViewTextBoxColumn, Me.ServiceNameDataGridViewTextBoxColumn, Me.TypeNameDataGridViewTextBoxColumn})
        Me.gvServiceTypes.DataSource = Me.ViewServiceTypesBindingSource1
        Me.gvServiceTypes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gvServiceTypes.Location = New System.Drawing.Point(0, 166)
        Me.gvServiceTypes.Name = "gvServiceTypes"
        Me.gvServiceTypes.ReadOnly = True
        Me.gvServiceTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvServiceTypes.Size = New System.Drawing.Size(509, 229)
        Me.gvServiceTypes.TabIndex = 5
        '
        'ServiceIDDataGridViewTextBoxColumn
        '
        Me.ServiceIDDataGridViewTextBoxColumn.DataPropertyName = "ServiceID"
        Me.ServiceIDDataGridViewTextBoxColumn.HeaderText = "ServiceID"
        Me.ServiceIDDataGridViewTextBoxColumn.Name = "ServiceIDDataGridViewTextBoxColumn"
        Me.ServiceIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ServiceNameDataGridViewTextBoxColumn
        '
        Me.ServiceNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ServiceNameDataGridViewTextBoxColumn.DataPropertyName = "ServiceName"
        Me.ServiceNameDataGridViewTextBoxColumn.HeaderText = "ServiceName"
        Me.ServiceNameDataGridViewTextBoxColumn.Name = "ServiceNameDataGridViewTextBoxColumn"
        Me.ServiceNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TypeNameDataGridViewTextBoxColumn
        '
        Me.TypeNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TypeNameDataGridViewTextBoxColumn.DataPropertyName = "TypeName"
        Me.TypeNameDataGridViewTextBoxColumn.HeaderText = "TypeName"
        Me.TypeNameDataGridViewTextBoxColumn.Name = "TypeNameDataGridViewTextBoxColumn"
        Me.TypeNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ViewServiceTypesBindingSource1
        '
        Me.ViewServiceTypesBindingSource1.DataMember = "viewServiceTypes"
        Me.ViewServiceTypesBindingSource1.DataSource = Me.MIYEDataset
        '
        'TblServicesBindingSource
        '
        Me.TblServicesBindingSource.DataMember = "tblServices"
        Me.TblServicesBindingSource.DataSource = Me.MIYEDataset
        '
        'TblServicesTableAdapter
        '
        Me.TblServicesTableAdapter.ClearBeforeFill = True
        '
        'frmAddServiceType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 395)
        Me.Controls.Add(Me.gvServiceTypes)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtTypeName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbServices)
        Me.Name = "frmAddServiceType"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Service Type"
        CType(Me.ViewServiceTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MIYEDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvServiceTypes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewServiceTypesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblServicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbServices As System.Windows.Forms.ComboBox
    Friend WithEvents MIYEDataset As MIYE.MIYEDataset
    Friend WithEvents ViewServiceTypesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ViewServiceTypesTableAdapter As MIYE.MIYEDatasetTableAdapters.viewServiceTypesTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTypeName As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents gvServiceTypes As System.Windows.Forms.DataGridView
    Friend WithEvents ServiceIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServiceNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ViewServiceTypesBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TblServicesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblServicesTableAdapter As MIYE.MIYEDatasetTableAdapters.tblServicesTableAdapter
End Class
