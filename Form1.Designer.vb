<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StreetaddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZipcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhonenumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddtomailinglistDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OthernotesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Trial562DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New bakery.DataSet1()
        Me.CustomersTableAdapter = New bakery.DataSet1TableAdapters.customersTableAdapter()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.Judul = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtZipCode = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtStreetAddress = New System.Windows.Forms.TextBox()
        Me.cbConfirm = New System.Windows.Forms.ComboBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeight = 28
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.LastnameDataGridViewTextBoxColumn, Me.StreetaddressDataGridViewTextBoxColumn, Me.StateDataGridViewTextBoxColumn, Me.ZipcodeDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.PhonenumberDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.AddtomailinglistDataGridViewTextBoxColumn, Me.OthernotesDataGridViewTextBoxColumn, Me.Trial562DataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CustomersBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 365)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1178, 254)
        Me.DataGridView1.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.Width = 150
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name"
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "first_name"
        Me.FirstnameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        Me.FirstnameDataGridViewTextBoxColumn.Width = 150
        '
        'LastnameDataGridViewTextBoxColumn
        '
        Me.LastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name"
        Me.LastnameDataGridViewTextBoxColumn.HeaderText = "last_name"
        Me.LastnameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.LastnameDataGridViewTextBoxColumn.Name = "LastnameDataGridViewTextBoxColumn"
        Me.LastnameDataGridViewTextBoxColumn.Width = 150
        '
        'StreetaddressDataGridViewTextBoxColumn
        '
        Me.StreetaddressDataGridViewTextBoxColumn.DataPropertyName = "street_address"
        Me.StreetaddressDataGridViewTextBoxColumn.HeaderText = "street_address"
        Me.StreetaddressDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.StreetaddressDataGridViewTextBoxColumn.Name = "StreetaddressDataGridViewTextBoxColumn"
        Me.StreetaddressDataGridViewTextBoxColumn.Width = 150
        '
        'StateDataGridViewTextBoxColumn
        '
        Me.StateDataGridViewTextBoxColumn.DataPropertyName = "state"
        Me.StateDataGridViewTextBoxColumn.HeaderText = "state"
        Me.StateDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.StateDataGridViewTextBoxColumn.Name = "StateDataGridViewTextBoxColumn"
        Me.StateDataGridViewTextBoxColumn.Width = 150
        '
        'ZipcodeDataGridViewTextBoxColumn
        '
        Me.ZipcodeDataGridViewTextBoxColumn.DataPropertyName = "zip_code"
        Me.ZipcodeDataGridViewTextBoxColumn.HeaderText = "zip_code"
        Me.ZipcodeDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ZipcodeDataGridViewTextBoxColumn.Name = "ZipcodeDataGridViewTextBoxColumn"
        Me.ZipcodeDataGridViewTextBoxColumn.Width = 150
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.Width = 150
        '
        'PhonenumberDataGridViewTextBoxColumn
        '
        Me.PhonenumberDataGridViewTextBoxColumn.DataPropertyName = "phone_number"
        Me.PhonenumberDataGridViewTextBoxColumn.HeaderText = "phone_number"
        Me.PhonenumberDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PhonenumberDataGridViewTextBoxColumn.Name = "PhonenumberDataGridViewTextBoxColumn"
        Me.PhonenumberDataGridViewTextBoxColumn.Width = 150
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "city"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "city"
        Me.CityDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        Me.CityDataGridViewTextBoxColumn.Width = 150
        '
        'AddtomailinglistDataGridViewTextBoxColumn
        '
        Me.AddtomailinglistDataGridViewTextBoxColumn.DataPropertyName = "add_to_mailing_list_"
        Me.AddtomailinglistDataGridViewTextBoxColumn.HeaderText = "add_to_mailing_list_"
        Me.AddtomailinglistDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.AddtomailinglistDataGridViewTextBoxColumn.Name = "AddtomailinglistDataGridViewTextBoxColumn"
        Me.AddtomailinglistDataGridViewTextBoxColumn.Width = 150
        '
        'OthernotesDataGridViewTextBoxColumn
        '
        Me.OthernotesDataGridViewTextBoxColumn.DataPropertyName = "other_notes"
        Me.OthernotesDataGridViewTextBoxColumn.HeaderText = "other_notes"
        Me.OthernotesDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.OthernotesDataGridViewTextBoxColumn.Name = "OthernotesDataGridViewTextBoxColumn"
        Me.OthernotesDataGridViewTextBoxColumn.Width = 150
        '
        'Trial562DataGridViewTextBoxColumn
        '
        Me.Trial562DataGridViewTextBoxColumn.DataPropertyName = "trial562"
        Me.Trial562DataGridViewTextBoxColumn.HeaderText = "trial562"
        Me.Trial562DataGridViewTextBoxColumn.MinimumWidth = 8
        Me.Trial562DataGridViewTextBoxColumn.Name = "Trial562DataGridViewTextBoxColumn"
        Me.Trial562DataGridViewTextBoxColumn.Width = 150
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "customers"
        Me.CustomersBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(1105, 634)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(85, 38)
        Me.btnKeluar.TabIndex = 1
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'Judul
        '
        Me.Judul.AutoSize = True
        Me.Judul.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Judul.Location = New System.Drawing.Point(489, 9)
        Me.Judul.Name = "Judul"
        Me.Judul.Size = New System.Drawing.Size(242, 32)
        Me.Judul.TabIndex = 2
        Me.Judul.Text = "Customer's Form"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(86, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Last Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(625, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(116, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Street Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(625, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(35, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "City"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(48, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Email"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(55, 239)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(115, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Phone Number"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(625, 188)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(48, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "State"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(55, 295)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(141, 20)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Add to mailing list?"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(625, 239)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(73, 20)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Zip Code"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(253, 87)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(252, 26)
        Me.txtFirstName.TabIndex = 13
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(253, 138)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(252, 26)
        Me.txtLastName.TabIndex = 14
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(253, 188)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(292, 26)
        Me.txtEmail.TabIndex = 15
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(253, 239)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(230, 26)
        Me.txtPhoneNumber.TabIndex = 16
        '
        'txtZipCode
        '
        Me.txtZipCode.Location = New System.Drawing.Point(762, 239)
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.Size = New System.Drawing.Size(159, 26)
        Me.txtZipCode.TabIndex = 20
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(762, 188)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(159, 26)
        Me.txtState.TabIndex = 19
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(762, 138)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(159, 26)
        Me.txtCity.TabIndex = 18
        '
        'txtStreetAddress
        '
        Me.txtStreetAddress.Location = New System.Drawing.Point(762, 87)
        Me.txtStreetAddress.Name = "txtStreetAddress"
        Me.txtStreetAddress.Size = New System.Drawing.Size(252, 26)
        Me.txtStreetAddress.TabIndex = 17
        '
        'cbConfirm
        '
        Me.cbConfirm.FormattingEnabled = True
        Me.cbConfirm.Items.AddRange(New Object() {"Yes", "No"})
        Me.cbConfirm.Location = New System.Drawing.Point(253, 292)
        Me.cbConfirm.Name = "cbConfirm"
        Me.cbConfirm.Size = New System.Drawing.Size(121, 28)
        Me.cbConfirm.TabIndex = 21
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(877, 634)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(94, 38)
        Me.btnSimpan.TabIndex = 23
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(993, 634)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(94, 38)
        Me.btnDelete.TabIndex = 22
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1202, 684)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.cbConfirm)
        Me.Controls.Add(Me.txtZipCode)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtStreetAddress)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Judul)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents CustomersBindingSource As BindingSource
    Friend WithEvents CustomersTableAdapter As DataSet1TableAdapters.customersTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StreetaddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ZipcodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhonenumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddtomailinglistDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OthernotesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Trial562DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnKeluar As Button
    Friend WithEvents Judul As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtZipCode As TextBox
    Friend WithEvents txtState As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtStreetAddress As TextBox
    Friend WithEvents cbConfirm As ComboBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnDelete As Button
End Class
