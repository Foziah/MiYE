﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateServices
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
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtServiceName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MIYEDataset = New MIYE.MIYEDataset()
        Me.TblServicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblServicesTableAdapter = New MIYE.MIYEDatasetTableAdapters.tblServicesTableAdapter()
        Me.gvServices = New System.Windows.Forms.DataGridView()
        Me.ServiceIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.MIYEDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblServicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvServices, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(297, 106)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 9
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(218, 80)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(154, 20)
        Me.txtCost.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(138, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Cost"
        '
        'txtServiceName
        '
        Me.txtServiceName.Location = New System.Drawing.Point(218, 54)
        Me.txtServiceName.Name = "txtServiceName"
        Me.txtServiceName.Size = New System.Drawing.Size(154, 20)
        Me.txtServiceName.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(138, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Service Name"
        '
        'MIYEDataset
        '
        Me.MIYEDataset.DataSetName = "MIYEDataset"
        Me.MIYEDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'gvServices
        '
        Me.gvServices.AllowUserToAddRows = False
        Me.gvServices.AllowUserToDeleteRows = False
        Me.gvServices.AutoGenerateColumns = False
        Me.gvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvServices.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ServiceIDDataGridViewTextBoxColumn, Me.ServiceNameDataGridViewTextBoxColumn, Me.CostDataGridViewTextBoxColumn})
        Me.gvServices.DataSource = Me.TblServicesBindingSource
        Me.gvServices.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gvServices.Location = New System.Drawing.Point(0, 166)
        Me.gvServices.Name = "gvServices"
        Me.gvServices.ReadOnly = True
        Me.gvServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvServices.Size = New System.Drawing.Size(523, 231)
        Me.gvServices.TabIndex = 10
        '
        'ServiceIDDataGridViewTextBoxColumn
        '
        Me.ServiceIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ServiceIDDataGridViewTextBoxColumn.DataPropertyName = "ServiceID"
        Me.ServiceIDDataGridViewTextBoxColumn.HeaderText = "ServiceID"
        Me.ServiceIDDataGridViewTextBoxColumn.Name = "ServiceIDDataGridViewTextBoxColumn"
        Me.ServiceIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.ServiceIDDataGridViewTextBoxColumn.Width = 79
        '
        'ServiceNameDataGridViewTextBoxColumn
        '
        Me.ServiceNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ServiceNameDataGridViewTextBoxColumn.DataPropertyName = "ServiceName"
        Me.ServiceNameDataGridViewTextBoxColumn.HeaderText = "ServiceName"
        Me.ServiceNameDataGridViewTextBoxColumn.Name = "ServiceNameDataGridViewTextBoxColumn"
        Me.ServiceNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CostDataGridViewTextBoxColumn
        '
        Me.CostDataGridViewTextBoxColumn.DataPropertyName = "Cost"
        Me.CostDataGridViewTextBoxColumn.HeaderText = "Cost"
        Me.CostDataGridViewTextBoxColumn.Name = "CostDataGridViewTextBoxColumn"
        Me.CostDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmUpdateServices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 397)
        Me.Controls.Add(Me.gvServices)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtServiceName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmUpdateServices"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Serviecs"
        CType(Me.MIYEDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblServicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvServices, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents txtCost As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtServiceName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MIYEDataset As MIYE.MIYEDataset
    Friend WithEvents TblServicesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblServicesTableAdapter As MIYE.MIYEDatasetTableAdapters.tblServicesTableAdapter
    Friend WithEvents gvServices As System.Windows.Forms.DataGridView
    Friend WithEvents ServiceIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServiceNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
