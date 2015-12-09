<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddGuest
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gvGuests = New System.Windows.Forms.DataGridView()
        Me.TblGuestsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MIYEDataset = New MIYE.MIYEDataset()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.TblGuestsTableAdapter = New MIYE.MIYEDatasetTableAdapters.tblGuestsTableAdapter()
        Me.cbStartMinutes = New System.Windows.Forms.ComboBox()
        Me.checkinDate = New System.Windows.Forms.DateTimePicker()
        Me.cbStartHrs = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbCheckoutMinute = New System.Windows.Forms.ComboBox()
        Me.checkoutDate = New System.Windows.Forms.DateTimePicker()
        Me.cbCheckoutHour = New System.Windows.Forms.ComboBox()
        Me.GuestIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckinTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckoutTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.gvGuests, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblGuestsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MIYEDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(324, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(403, 25)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(200, 20)
        Me.txtFirstName.TabIndex = 1
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(403, 51)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(200, 20)
        Me.txtLastName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(324, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Last Name"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(403, 77)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(200, 20)
        Me.txtEmail.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(324, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Email"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(403, 103)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(200, 20)
        Me.txtPhone.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(324, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Phone"
        '
        'gvGuests
        '
        Me.gvGuests.AllowUserToAddRows = False
        Me.gvGuests.AllowUserToDeleteRows = False
        Me.gvGuests.AutoGenerateColumns = False
        Me.gvGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvGuests.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GuestIDDataGridViewTextBoxColumn, Me.FNameDataGridViewTextBoxColumn, Me.LNameDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.CheckinTime, Me.DataGridViewTextBoxColumn2, Me.CheckoutTime})
        Me.gvGuests.DataSource = Me.TblGuestsBindingSource
        Me.gvGuests.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gvGuests.Location = New System.Drawing.Point(0, 299)
        Me.gvGuests.Name = "gvGuests"
        Me.gvGuests.ReadOnly = True
        Me.gvGuests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gvGuests.Size = New System.Drawing.Size(943, 152)
        Me.gvGuests.TabIndex = 8
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
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(403, 236)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(200, 23)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'TblGuestsTableAdapter
        '
        Me.TblGuestsTableAdapter.ClearBeforeFill = True
        '
        'cbStartMinutes
        '
        Me.cbStartMinutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStartMinutes.FormattingEnabled = True
        Me.cbStartMinutes.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        Me.cbStartMinutes.Location = New System.Drawing.Point(550, 153)
        Me.cbStartMinutes.Name = "cbStartMinutes"
        Me.cbStartMinutes.Size = New System.Drawing.Size(53, 21)
        Me.cbStartMinutes.TabIndex = 14
        '
        'checkinDate
        '
        Me.checkinDate.Location = New System.Drawing.Point(403, 129)
        Me.checkinDate.Name = "checkinDate"
        Me.checkinDate.Size = New System.Drawing.Size(200, 20)
        Me.checkinDate.TabIndex = 13
        '
        'cbStartHrs
        '
        Me.cbStartHrs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStartHrs.FormattingEnabled = True
        Me.cbStartHrs.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.cbStartHrs.Location = New System.Drawing.Point(491, 153)
        Me.cbStartHrs.Name = "cbStartHrs"
        Me.cbStartHrs.Size = New System.Drawing.Size(53, 21)
        Me.cbStartHrs.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(324, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Checkin"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(324, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Checkout"
        '
        'cbCheckoutMinute
        '
        Me.cbCheckoutMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCheckoutMinute.FormattingEnabled = True
        Me.cbCheckoutMinute.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        Me.cbCheckoutMinute.Location = New System.Drawing.Point(550, 204)
        Me.cbCheckoutMinute.Name = "cbCheckoutMinute"
        Me.cbCheckoutMinute.Size = New System.Drawing.Size(53, 21)
        Me.cbCheckoutMinute.TabIndex = 18
        '
        'checkoutDate
        '
        Me.checkoutDate.Location = New System.Drawing.Point(403, 180)
        Me.checkoutDate.Name = "checkoutDate"
        Me.checkoutDate.Size = New System.Drawing.Size(200, 20)
        Me.checkoutDate.TabIndex = 17
        '
        'cbCheckoutHour
        '
        Me.cbCheckoutHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCheckoutHour.FormattingEnabled = True
        Me.cbCheckoutHour.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.cbCheckoutHour.Location = New System.Drawing.Point(491, 204)
        Me.cbCheckoutHour.Name = "cbCheckoutHour"
        Me.cbCheckoutHour.Size = New System.Drawing.Size(53, 21)
        Me.cbCheckoutHour.TabIndex = 20
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
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        Me.PhoneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CheckinDate"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Checkin Date"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'CheckinTime
        '
        Me.CheckinTime.DataPropertyName = "CheckinTime"
        Me.CheckinTime.HeaderText = "Checkin Time"
        Me.CheckinTime.Name = "CheckinTime"
        Me.CheckinTime.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CheckoutDate"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Checkout Date"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'CheckoutTime
        '
        Me.CheckoutTime.DataPropertyName = "CheckoutTime"
        Me.CheckoutTime.HeaderText = "Checkout Time"
        Me.CheckoutTime.Name = "CheckoutTime"
        Me.CheckoutTime.ReadOnly = True
        '
        'frmAddGuest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 451)
        Me.Controls.Add(Me.cbCheckoutHour)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbCheckoutMinute)
        Me.Controls.Add(Me.checkoutDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbStartMinutes)
        Me.Controls.Add(Me.checkinDate)
        Me.Controls.Add(Me.cbStartHrs)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.gvGuests)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAddGuest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Guest"
        CType(Me.gvGuests, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblGuestsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MIYEDataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gvGuests As System.Windows.Forms.DataGridView
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents MIYEDataset As MIYE.MIYEDataset
    Friend WithEvents TblGuestsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblGuestsTableAdapter As MIYE.MIYEDatasetTableAdapters.tblGuestsTableAdapter
    Friend WithEvents cbStartMinutes As System.Windows.Forms.ComboBox
    Friend WithEvents checkinDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbStartHrs As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbCheckoutMinute As System.Windows.Forms.ComboBox
    Friend WithEvents checkoutDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbCheckoutHour As System.Windows.Forms.ComboBox
    Friend WithEvents GuestIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CheckinTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CheckoutTime As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
