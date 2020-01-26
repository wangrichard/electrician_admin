<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class o_manpower_effort
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
        Me.cmb_employee = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.d_to_date = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.d_from_date = New System.Windows.Forms.DateTimePicker()
        Me.t_payment = New System.Windows.Forms.TextBox()
        Me.t_work_hour = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SourceDataSet = New admin.sourceDataSet()
        Me.QmanpowereffortBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Q_manpower_effortTableAdapter = New admin.sourceDataSetTableAdapters.q_manpower_effortTableAdapter()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProjectaddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WorkhoursDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HourlyrateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecorddateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProjectidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LemployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.L_employeeTableAdapter = New admin.sourceDataSetTableAdapters.l_employeeTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SourceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QmanpowereffortBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LemployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_employee
        '
        Me.cmb_employee.DataSource = Me.LemployeeBindingSource
        Me.cmb_employee.DisplayMember = "name"
        Me.cmb_employee.FormattingEnabled = True
        Me.cmb_employee.Location = New System.Drawing.Point(64, 370)
        Me.cmb_employee.Name = "cmb_employee"
        Me.cmb_employee.Size = New System.Drawing.Size(135, 21)
        Me.cmb_employee.TabIndex = 1
        Me.cmb_employee.ValueMember = "ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 344)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Employee"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(611, 344)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "To Date"
        '
        'd_to_date
        '
        Me.d_to_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.d_to_date.Location = New System.Drawing.Point(614, 370)
        Me.d_to_date.Name = "d_to_date"
        Me.d_to_date.Size = New System.Drawing.Size(108, 20)
        Me.d_to_date.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(383, 346)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "From Date"
        '
        'd_from_date
        '
        Me.d_from_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.d_from_date.Location = New System.Drawing.Point(386, 372)
        Me.d_from_date.Name = "d_from_date"
        Me.d_from_date.Size = New System.Drawing.Size(108, 20)
        Me.d_from_date.TabIndex = 10
        '
        't_payment
        '
        Me.t_payment.Location = New System.Drawing.Point(482, 301)
        Me.t_payment.Name = "t_payment"
        Me.t_payment.Size = New System.Drawing.Size(104, 20)
        Me.t_payment.TabIndex = 15
        '
        't_work_hour
        '
        Me.t_work_hour.Location = New System.Drawing.Point(200, 301)
        Me.t_work_hour.Name = "t_work_hour"
        Me.t_work_hour.Size = New System.Drawing.Size(104, 20)
        Me.t_work_hour.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(428, 301)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Payment"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(135, 301)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Work Hours"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn, Me.ProjectaddressDataGridViewTextBoxColumn, Me.WorkhoursDataGridViewTextBoxColumn, Me.HourlyrateDataGridViewTextBoxColumn, Me.PaymentDataGridViewTextBoxColumn, Me.RecorddateDataGridViewTextBoxColumn, Me.EmployeeidDataGridViewTextBoxColumn, Me.ProjectidDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.QmanpowereffortBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(47, 36)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(706, 247)
        Me.DataGridView1.TabIndex = 19
        '
        'SourceDataSet
        '
        Me.SourceDataSet.DataSetName = "sourceDataSet"
        Me.SourceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'QmanpowereffortBindingSource
        '
        Me.QmanpowereffortBindingSource.DataMember = "q_manpower_effort"
        Me.QmanpowereffortBindingSource.DataSource = Me.SourceDataSet
        '
        'Q_manpower_effortTableAdapter
        '
        Me.Q_manpower_effortTableAdapter.ClearBeforeFill = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'ProjectaddressDataGridViewTextBoxColumn
        '
        Me.ProjectaddressDataGridViewTextBoxColumn.DataPropertyName = "project_address"
        Me.ProjectaddressDataGridViewTextBoxColumn.HeaderText = "project_address"
        Me.ProjectaddressDataGridViewTextBoxColumn.Name = "ProjectaddressDataGridViewTextBoxColumn"
        '
        'WorkhoursDataGridViewTextBoxColumn
        '
        Me.WorkhoursDataGridViewTextBoxColumn.DataPropertyName = "work_hours"
        Me.WorkhoursDataGridViewTextBoxColumn.HeaderText = "work_hours"
        Me.WorkhoursDataGridViewTextBoxColumn.Name = "WorkhoursDataGridViewTextBoxColumn"
        '
        'HourlyrateDataGridViewTextBoxColumn
        '
        Me.HourlyrateDataGridViewTextBoxColumn.DataPropertyName = "hourly_rate"
        Me.HourlyrateDataGridViewTextBoxColumn.HeaderText = "hourly_rate"
        Me.HourlyrateDataGridViewTextBoxColumn.Name = "HourlyrateDataGridViewTextBoxColumn"
        '
        'PaymentDataGridViewTextBoxColumn
        '
        Me.PaymentDataGridViewTextBoxColumn.DataPropertyName = "payment"
        Me.PaymentDataGridViewTextBoxColumn.HeaderText = "payment"
        Me.PaymentDataGridViewTextBoxColumn.Name = "PaymentDataGridViewTextBoxColumn"
        '
        'RecorddateDataGridViewTextBoxColumn
        '
        Me.RecorddateDataGridViewTextBoxColumn.DataPropertyName = "record_date"
        Me.RecorddateDataGridViewTextBoxColumn.HeaderText = "record_date"
        Me.RecorddateDataGridViewTextBoxColumn.Name = "RecorddateDataGridViewTextBoxColumn"
        '
        'EmployeeidDataGridViewTextBoxColumn
        '
        Me.EmployeeidDataGridViewTextBoxColumn.DataPropertyName = "employee_id"
        Me.EmployeeidDataGridViewTextBoxColumn.HeaderText = "employee_id"
        Me.EmployeeidDataGridViewTextBoxColumn.Name = "EmployeeidDataGridViewTextBoxColumn"
        Me.EmployeeidDataGridViewTextBoxColumn.Visible = False
        '
        'ProjectidDataGridViewTextBoxColumn
        '
        Me.ProjectidDataGridViewTextBoxColumn.DataPropertyName = "project_id"
        Me.ProjectidDataGridViewTextBoxColumn.HeaderText = "project_id"
        Me.ProjectidDataGridViewTextBoxColumn.Name = "ProjectidDataGridViewTextBoxColumn"
        Me.ProjectidDataGridViewTextBoxColumn.Visible = False
        '
        'LemployeeBindingSource
        '
        Me.LemployeeBindingSource.DataMember = "l_employee"
        Me.LemployeeBindingSource.DataSource = Me.SourceDataSet
        '
        'L_employeeTableAdapter
        '
        Me.L_employeeTableAdapter.ClearBeforeFill = True
        '
        'o_manpower_effort
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 418)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.t_work_hour)
        Me.Controls.Add(Me.t_payment)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.d_to_date)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.d_from_date)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_employee)
        Me.Name = "o_manpower_effort"
        Me.Text = "Manpower Effort"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SourceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QmanpowereffortBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LemployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmb_employee As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents t_payment As TextBox
    Friend WithEvents t_work_hour As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Public WithEvents d_to_date As DateTimePicker
    Public WithEvents d_from_date As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SourceDataSet As sourceDataSet
    Friend WithEvents QmanpowereffortBindingSource As BindingSource
    Friend WithEvents Q_manpower_effortTableAdapter As sourceDataSetTableAdapters.q_manpower_effortTableAdapter
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProjectaddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WorkhoursDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HourlyrateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaymentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RecorddateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProjectidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LemployeeBindingSource As BindingSource
    Friend WithEvents L_employeeTableAdapter As sourceDataSetTableAdapters.l_employeeTableAdapter
End Class
