<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAppointment
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
        Me.cbGuestID = New System.Windows.Forms.ComboBox()
        Me.TblGuestsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MIYEDataset = New MIYE.MIYEDataset()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbGuestName = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblEndTime = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbStartMinutes = New System.Windows.Forms.ComboBox()
        Me.cbServiceDuration = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbStartHrs = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbServiceType = New System.Windows.Forms.ComboBox()
        Me.TblServiceTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbServices = New System.Windows.Forms.ComboBox()
        Me.TblServicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblServicesTableAdapter = New MIYE.MIYEDatasetTableAdapters.tblServicesTableAdapter()
        Me.ViewServiceTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ViewServiceTypesTableAdapter = New MIYE.MIYEDatasetTableAdapters.viewServiceTypesTableAdapter()
        Me.TblServiceTypesTableAdapter = New MIYE.MIYEDatasetTableAdapters.tblServiceTypesTableAdapter()
        Me.TblGuestsTableAdapter = New MIYE.MIYEDatasetTableAdapters.tblGuestsTableAdapter()
        Me.btnMakeAppointment = New System.Windows.Forms.Button()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        CType(Me.TblGuestsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MIYEDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.TblServiceTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblServicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewServiceTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbGuestID
        '
        Me.cbGuestID.FormattingEnabled = True
        Me.cbGuestID.Location = New System.Drawing.Point(107, 33)
        Me.cbGuestID.Name = "cbGuestID"
        Me.cbGuestID.Size = New System.Drawing.Size(200, 21)
        Me.cbGuestID.TabIndex = 0
        '
        'TblGuestsBindingSource
        '
        Me.TblGuestsBindingSource.DataMember = "tblGuests"
        Me.TblGuestsBindingSource.DataSource = Me.MIYEDataset
        '
        'MIYEDataset
        '
        Me.MIYEDataset.DataSetName = "MIYEDataset"
        Me.MIYEDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Guest ID"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbGuestName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbGuestID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(327, 107)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Guest"
        '
        'cbGuestName
        '
        Me.cbGuestName.FormattingEnabled = True
        Me.cbGuestName.Location = New System.Drawing.Point(107, 60)
        Me.cbGuestName.Name = "cbGuestName"
        Me.cbGuestName.Size = New System.Drawing.Size(200, 21)
        Me.cbGuestName.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Guest Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblEndTime)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cbStartMinutes)
        Me.GroupBox2.Controls.Add(Me.cbServiceDuration)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.cbStartHrs)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cbServiceType)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cbServices)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 127)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(326, 208)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Services Info."
        '
        'lblEndTime
        '
        Me.lblEndTime.AutoSize = True
        Me.lblEndTime.Location = New System.Drawing.Point(104, 166)
        Me.lblEndTime.Name = "lblEndTime"
        Me.lblEndTime.Size = New System.Drawing.Size(0, 13)
        Me.lblEndTime.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 166)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "End"
        '
        'cbStartMinutes
        '
        Me.cbStartMinutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStartMinutes.FormattingEnabled = True
        Me.cbStartMinutes.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        Me.cbStartMinutes.Location = New System.Drawing.Point(166, 109)
        Me.cbStartMinutes.Name = "cbStartMinutes"
        Me.cbStartMinutes.Size = New System.Drawing.Size(53, 21)
        Me.cbStartMinutes.TabIndex = 11
        '
        'cbServiceDuration
        '
        Me.cbServiceDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbServiceDuration.FormattingEnabled = True
        Me.cbServiceDuration.Location = New System.Drawing.Point(107, 136)
        Me.cbServiceDuration.Name = "cbServiceDuration"
        Me.cbServiceDuration.Size = New System.Drawing.Size(112, 21)
        Me.cbServiceDuration.TabIndex = 12
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(107, 85)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Type"
        '
        'cbStartHrs
        '
        Me.cbStartHrs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStartHrs.FormattingEnabled = True
        Me.cbStartHrs.Items.AddRange(New Object() {"08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.cbStartHrs.Location = New System.Drawing.Point(107, 109)
        Me.cbStartHrs.Name = "cbStartHrs"
        Me.cbStartHrs.Size = New System.Drawing.Size(53, 21)
        Me.cbStartHrs.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Start"
        '
        'cbServiceType
        '
        Me.cbServiceType.DataSource = Me.TblServiceTypesBindingSource
        Me.cbServiceType.DisplayMember = "TypeName"
        Me.cbServiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbServiceType.FormattingEnabled = True
        Me.cbServiceType.Location = New System.Drawing.Point(107, 57)
        Me.cbServiceType.Name = "cbServiceType"
        Me.cbServiceType.Size = New System.Drawing.Size(200, 21)
        Me.cbServiceType.TabIndex = 6
        Me.cbServiceType.Tag = "Cost"
        Me.cbServiceType.ValueMember = "TypeID"
        '
        'TblServiceTypesBindingSource
        '
        Me.TblServiceTypesBindingSource.DataMember = "tblServiceTypes"
        Me.TblServiceTypesBindingSource.DataSource = Me.MIYEDataset
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Service"
        '
        'cbServices
        '
        Me.cbServices.DataSource = Me.TblServicesBindingSource
        Me.cbServices.DisplayMember = "ServiceName"
        Me.cbServices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbServices.FormattingEnabled = True
        Me.cbServices.Location = New System.Drawing.Point(107, 30)
        Me.cbServices.Name = "cbServices"
        Me.cbServices.Size = New System.Drawing.Size(200, 21)
        Me.cbServices.TabIndex = 4
        Me.cbServices.ValueMember = "ServiceID"
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
        'ViewServiceTypesBindingSource
        '
        Me.ViewServiceTypesBindingSource.DataMember = "viewServiceTypes"
        Me.ViewServiceTypesBindingSource.DataSource = Me.MIYEDataset
        '
        'ViewServiceTypesTableAdapter
        '
        Me.ViewServiceTypesTableAdapter.ClearBeforeFill = True
        '
        'TblServiceTypesTableAdapter
        '
        Me.TblServiceTypesTableAdapter.ClearBeforeFill = True
        '
        'TblGuestsTableAdapter
        '
        Me.TblGuestsTableAdapter.ClearBeforeFill = True
        '
        'btnMakeAppointment
        '
        Me.btnMakeAppointment.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnMakeAppointment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMakeAppointment.Location = New System.Drawing.Point(196, 341)
        Me.btnMakeAppointment.Name = "btnMakeAppointment"
        Me.btnMakeAppointment.Size = New System.Drawing.Size(143, 47)
        Me.btnMakeAppointment.TabIndex = 4
        Me.btnMakeAppointment.Text = "Make Appointment"
        Me.btnMakeAppointment.UseVisualStyleBackColor = False
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPrice.Location = New System.Drawing.Point(13, 342)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblTotalPrice.Size = New System.Drawing.Size(177, 46)
        Me.lblTotalPrice.TabIndex = 5
        Me.lblTotalPrice.Text = "$0"
        '
        'frmAppointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 413)
        Me.Controls.Add(Me.lblTotalPrice)
        Me.Controls.Add(Me.btnMakeAppointment)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAppointment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Appointment"
        CType(Me.TblGuestsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MIYEDataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.TblServiceTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblServicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewServiceTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbGuestID As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbServices As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbServiceType As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbStartHrs As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents MIYEDataset As MIYE.MIYEDataset
    Friend WithEvents TblServicesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblServicesTableAdapter As MIYE.MIYEDatasetTableAdapters.tblServicesTableAdapter
    Friend WithEvents ViewServiceTypesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ViewServiceTypesTableAdapter As MIYE.MIYEDatasetTableAdapters.viewServiceTypesTableAdapter
    Friend WithEvents TblServiceTypesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblServiceTypesTableAdapter As MIYE.MIYEDatasetTableAdapters.tblServiceTypesTableAdapter
    Friend WithEvents TblGuestsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblGuestsTableAdapter As MIYE.MIYEDatasetTableAdapters.tblGuestsTableAdapter
    Friend WithEvents cbStartMinutes As System.Windows.Forms.ComboBox
    Friend WithEvents cbServiceDuration As System.Windows.Forms.ComboBox
    Friend WithEvents btnMakeAppointment As System.Windows.Forms.Button
    Friend WithEvents cbGuestName As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblEndTime As System.Windows.Forms.Label
    Friend WithEvents lblTotalPrice As System.Windows.Forms.Label
End Class
