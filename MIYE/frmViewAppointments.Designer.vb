﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewAppointments
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
        Me.gvAppointments = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtAppointmentID = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtGuestName = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtGuestNumber = New System.Windows.Forms.TextBox()
        Me.btnShowALl = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAppointmentID = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnCancelREservation = New System.Windows.Forms.Button()
        Me.ViewAppointmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MIYEDataset = New MIYE.MIYEDataset()
        Me.ViewAppointmentsTableAdapter = New MIYE.MIYEDatasetTableAdapters.viewAppointmentsTableAdapter()
        Me.AppointmentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GuestIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Expr1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfServiceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartingTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndingTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Timestamp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Expr2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.gvAppointments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ViewAppointmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MIYEDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gvAppointments
        '
        Me.gvAppointments.AllowUserToAddRows = False
        Me.gvAppointments.AllowUserToDeleteRows = False
        Me.gvAppointments.AutoGenerateColumns = False
        Me.gvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvAppointments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AppointmentIDDataGridViewTextBoxColumn, Me.GuestIDDataGridViewTextBoxColumn, Me.FNameDataGridViewTextBoxColumn, Me.LNameDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.Expr1DataGridViewTextBoxColumn, Me.ServiceIDDataGridViewTextBoxColumn, Me.DateOfServiceDataGridViewTextBoxColumn, Me.TypeNameDataGridViewTextBoxColumn, Me.StartingTimeDataGridViewTextBoxColumn, Me.EndingTimeDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.Timestamp, Me.Status, Me.TypeIDDataGridViewTextBoxColumn, Me.Expr2DataGridViewTextBoxColumn})
        Me.gvAppointments.DataSource = Me.ViewAppointmentsBindingSource
        Me.gvAppointments.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gvAppointments.Location = New System.Drawing.Point(0, 153)
        Me.gvAppointments.Name = "gvAppointments"
        Me.gvAppointments.ReadOnly = True
        Me.gvAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvAppointments.Size = New System.Drawing.Size(871, 344)
        Me.gvAppointments.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtAppointmentID)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(316, 58)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search By Appointment ID"
        '
        'txtAppointmentID
        '
        Me.txtAppointmentID.Location = New System.Drawing.Point(17, 19)
        Me.txtAppointmentID.Name = "txtAppointmentID"
        Me.txtAppointmentID.Size = New System.Drawing.Size(283, 20)
        Me.txtAppointmentID.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtGuestName)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 77)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(316, 58)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search By Guest Name"
        '
        'txtGuestName
        '
        Me.txtGuestName.Location = New System.Drawing.Point(17, 19)
        Me.txtGuestName.Name = "txtGuestName"
        Me.txtGuestName.Size = New System.Drawing.Size(283, 20)
        Me.txtGuestName.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtGuestNumber)
        Me.GroupBox3.Location = New System.Drawing.Point(344, 13)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(316, 58)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Search By Guest #"
        '
        'txtGuestNumber
        '
        Me.txtGuestNumber.Location = New System.Drawing.Point(17, 19)
        Me.txtGuestNumber.Name = "txtGuestNumber"
        Me.txtGuestNumber.Size = New System.Drawing.Size(283, 20)
        Me.txtGuestNumber.TabIndex = 0
        '
        'btnShowALl
        '
        Me.btnShowALl.Location = New System.Drawing.Point(585, 77)
        Me.btnShowALl.Name = "btnShowALl"
        Me.btnShowALl.Size = New System.Drawing.Size(75, 23)
        Me.btnShowALl.TabIndex = 4
        Me.btnShowALl.Text = "Show All"
        Me.btnShowALl.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(336, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Appointment ID"
        '
        'lblAppointmentID
        '
        Me.lblAppointmentID.AutoSize = True
        Me.lblAppointmentID.Location = New System.Drawing.Point(422, 122)
        Me.lblAppointmentID.Name = "lblAppointmentID"
        Me.lblAppointmentID.Size = New System.Drawing.Size(0, 13)
        Me.lblAppointmentID.TabIndex = 6
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(532, 116)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 7
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnCancelREservation
        '
        Me.btnCancelREservation.Location = New System.Drawing.Point(613, 117)
        Me.btnCancelREservation.Name = "btnCancelREservation"
        Me.btnCancelREservation.Size = New System.Drawing.Size(111, 23)
        Me.btnCancelREservation.TabIndex = 8
        Me.btnCancelREservation.Text = "Cancel Reservation"
        Me.btnCancelREservation.UseVisualStyleBackColor = True
        '
        'ViewAppointmentsBindingSource
        '
        Me.ViewAppointmentsBindingSource.DataMember = "viewAppointments"
        Me.ViewAppointmentsBindingSource.DataSource = Me.MIYEDataset
        '
        'MIYEDataset
        '
        Me.MIYEDataset.DataSetName = "MIYEDataset"
        Me.MIYEDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ViewAppointmentsTableAdapter
        '
        Me.ViewAppointmentsTableAdapter.ClearBeforeFill = True
        '
        'AppointmentIDDataGridViewTextBoxColumn
        '
        Me.AppointmentIDDataGridViewTextBoxColumn.DataPropertyName = "AppointmentID"
        Me.AppointmentIDDataGridViewTextBoxColumn.HeaderText = "AppointmentID"
        Me.AppointmentIDDataGridViewTextBoxColumn.Name = "AppointmentIDDataGridViewTextBoxColumn"
        Me.AppointmentIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GuestIDDataGridViewTextBoxColumn
        '
        Me.GuestIDDataGridViewTextBoxColumn.DataPropertyName = "GuestID"
        Me.GuestIDDataGridViewTextBoxColumn.HeaderText = "GuestID"
        Me.GuestIDDataGridViewTextBoxColumn.Name = "GuestIDDataGridViewTextBoxColumn"
        Me.GuestIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FNameDataGridViewTextBoxColumn
        '
        Me.FNameDataGridViewTextBoxColumn.DataPropertyName = "FName"
        Me.FNameDataGridViewTextBoxColumn.HeaderText = "FName"
        Me.FNameDataGridViewTextBoxColumn.Name = "FNameDataGridViewTextBoxColumn"
        Me.FNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LNameDataGridViewTextBoxColumn
        '
        Me.LNameDataGridViewTextBoxColumn.DataPropertyName = "LName"
        Me.LNameDataGridViewTextBoxColumn.HeaderText = "LName"
        Me.LNameDataGridViewTextBoxColumn.Name = "LNameDataGridViewTextBoxColumn"
        Me.LNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmailDataGridViewTextBoxColumn.Visible = False
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        Me.PhoneDataGridViewTextBoxColumn.ReadOnly = True
        Me.PhoneDataGridViewTextBoxColumn.Visible = False
        '
        'Expr1DataGridViewTextBoxColumn
        '
        Me.Expr1DataGridViewTextBoxColumn.DataPropertyName = "Expr1"
        Me.Expr1DataGridViewTextBoxColumn.HeaderText = "Expr1"
        Me.Expr1DataGridViewTextBoxColumn.Name = "Expr1DataGridViewTextBoxColumn"
        Me.Expr1DataGridViewTextBoxColumn.ReadOnly = True
        Me.Expr1DataGridViewTextBoxColumn.Visible = False
        '
        'ServiceIDDataGridViewTextBoxColumn
        '
        Me.ServiceIDDataGridViewTextBoxColumn.DataPropertyName = "ServiceID"
        Me.ServiceIDDataGridViewTextBoxColumn.HeaderText = "ServiceID"
        Me.ServiceIDDataGridViewTextBoxColumn.Name = "ServiceIDDataGridViewTextBoxColumn"
        Me.ServiceIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.ServiceIDDataGridViewTextBoxColumn.Visible = False
        '
        'DateOfServiceDataGridViewTextBoxColumn
        '
        Me.DateOfServiceDataGridViewTextBoxColumn.DataPropertyName = "DateOfService"
        Me.DateOfServiceDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateOfServiceDataGridViewTextBoxColumn.Name = "DateOfServiceDataGridViewTextBoxColumn"
        Me.DateOfServiceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TypeNameDataGridViewTextBoxColumn
        '
        Me.TypeNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TypeNameDataGridViewTextBoxColumn.DataPropertyName = "TypeName"
        Me.TypeNameDataGridViewTextBoxColumn.HeaderText = "Service"
        Me.TypeNameDataGridViewTextBoxColumn.Name = "TypeNameDataGridViewTextBoxColumn"
        Me.TypeNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StartingTimeDataGridViewTextBoxColumn
        '
        Me.StartingTimeDataGridViewTextBoxColumn.DataPropertyName = "StartingTime"
        Me.StartingTimeDataGridViewTextBoxColumn.HeaderText = "StartingTime"
        Me.StartingTimeDataGridViewTextBoxColumn.Name = "StartingTimeDataGridViewTextBoxColumn"
        Me.StartingTimeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EndingTimeDataGridViewTextBoxColumn
        '
        Me.EndingTimeDataGridViewTextBoxColumn.DataPropertyName = "EndingTime"
        Me.EndingTimeDataGridViewTextBoxColumn.HeaderText = "EndingTime"
        Me.EndingTimeDataGridViewTextBoxColumn.Name = "EndingTimeDataGridViewTextBoxColumn"
        Me.EndingTimeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Timestamp
        '
        Me.Timestamp.DataPropertyName = "Timestamp"
        Me.Timestamp.HeaderText = "Timestamp"
        Me.Timestamp.Name = "Timestamp"
        Me.Timestamp.ReadOnly = True
        '
        'Status
        '
        Me.Status.DataPropertyName = "Status"
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        '
        'TypeIDDataGridViewTextBoxColumn
        '
        Me.TypeIDDataGridViewTextBoxColumn.DataPropertyName = "TypeID"
        Me.TypeIDDataGridViewTextBoxColumn.HeaderText = "TypeID"
        Me.TypeIDDataGridViewTextBoxColumn.Name = "TypeIDDataGridViewTextBoxColumn"
        Me.TypeIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.TypeIDDataGridViewTextBoxColumn.Visible = False
        '
        'Expr2DataGridViewTextBoxColumn
        '
        Me.Expr2DataGridViewTextBoxColumn.DataPropertyName = "Expr2"
        Me.Expr2DataGridViewTextBoxColumn.HeaderText = "Expr2"
        Me.Expr2DataGridViewTextBoxColumn.Name = "Expr2DataGridViewTextBoxColumn"
        Me.Expr2DataGridViewTextBoxColumn.ReadOnly = True
        Me.Expr2DataGridViewTextBoxColumn.Visible = False
        '
        'frmViewAppointments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 497)
        Me.Controls.Add(Me.btnCancelREservation)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.lblAppointmentID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnShowALl)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gvAppointments)
        Me.Name = "frmViewAppointments"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Appointments"
        CType(Me.gvAppointments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ViewAppointmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MIYEDataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gvAppointments As System.Windows.Forms.DataGridView
    Friend WithEvents MIYEDataset As MIYE.MIYEDataset
    Friend WithEvents ViewAppointmentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ViewAppointmentsTableAdapter As MIYE.MIYEDatasetTableAdapters.viewAppointmentsTableAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtAppointmentID As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtGuestName As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtGuestNumber As System.Windows.Forms.TextBox
    Friend WithEvents btnShowALl As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblAppointmentID As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnCancelREservation As System.Windows.Forms.Button
    Friend WithEvents AppointmentIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GuestIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Expr1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServiceIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateOfServiceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StartingTimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EndingTimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Timestamp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Expr2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
