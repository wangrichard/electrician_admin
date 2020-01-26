<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class o_project_detail
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
        Me.ProjectaddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WorkhoursDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HourlyrateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecorddateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProjectidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QmanpowereffortBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SourceDataSet = New admin.sourceDataSet()
        Me.Q_manpower_effortTableAdapter = New admin.sourceDataSetTableAdapters.q_manpower_effortTableAdapter()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ProjectaddressDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialcategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialtypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitpriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecorddateDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProjectidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialcategoryidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialtypeidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QmaterialoutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Q_material_outTableAdapter = New admin.sourceDataSetTableAdapters.q_material_outTableAdapter()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.ProjectaddressDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IncometypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecorddateDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProjectidDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IncometypeidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QincomeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Q_incomeTableAdapter = New admin.sourceDataSetTableAdapters.q_incomeTableAdapter()
        Me.cmb_project = New System.Windows.Forms.ComboBox()
        Me.RprojectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.R_projectTableAdapter = New admin.sourceDataSetTableAdapters.r_projectTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.t_work_hour = New System.Windows.Forms.TextBox()
        Me.t_payment = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.t_cost = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.t_income = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.t_customer_name = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.t_start_date = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.t_profit = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QmanpowereffortBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SourceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QmaterialoutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QincomeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RprojectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProjectaddressDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.WorkhoursDataGridViewTextBoxColumn, Me.HourlyrateDataGridViewTextBoxColumn, Me.PaymentDataGridViewTextBoxColumn, Me.RecorddateDataGridViewTextBoxColumn, Me.EmployeeidDataGridViewTextBoxColumn, Me.ProjectidDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.QmanpowereffortBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(41, 78)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(719, 141)
        Me.DataGridView1.TabIndex = 0
        '
        'ProjectaddressDataGridViewTextBoxColumn
        '
        Me.ProjectaddressDataGridViewTextBoxColumn.DataPropertyName = "project_address"
        Me.ProjectaddressDataGridViewTextBoxColumn.HeaderText = "project_address"
        Me.ProjectaddressDataGridViewTextBoxColumn.Name = "ProjectaddressDataGridViewTextBoxColumn"
        Me.ProjectaddressDataGridViewTextBoxColumn.Visible = False
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
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
        'QmanpowereffortBindingSource
        '
        Me.QmanpowereffortBindingSource.DataMember = "q_manpower_effort"
        Me.QmanpowereffortBindingSource.DataSource = Me.SourceDataSet
        '
        'SourceDataSet
        '
        Me.SourceDataSet.DataSetName = "sourceDataSet"
        Me.SourceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Q_manpower_effortTableAdapter
        '
        Me.Q_manpower_effortTableAdapter.ClearBeforeFill = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProjectaddressDataGridViewTextBoxColumn1, Me.MaterialcategoryDataGridViewTextBoxColumn, Me.MaterialtypeDataGridViewTextBoxColumn, Me.UnitpriceDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.CostDataGridViewTextBoxColumn, Me.RecorddateDataGridViewTextBoxColumn1, Me.ProjectidDataGridViewTextBoxColumn1, Me.MaterialcategoryidDataGridViewTextBoxColumn, Me.MaterialtypeidDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.QmaterialoutBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(41, 275)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(719, 138)
        Me.DataGridView2.TabIndex = 1
        '
        'ProjectaddressDataGridViewTextBoxColumn1
        '
        Me.ProjectaddressDataGridViewTextBoxColumn1.DataPropertyName = "project_address"
        Me.ProjectaddressDataGridViewTextBoxColumn1.HeaderText = "project_address"
        Me.ProjectaddressDataGridViewTextBoxColumn1.Name = "ProjectaddressDataGridViewTextBoxColumn1"
        Me.ProjectaddressDataGridViewTextBoxColumn1.Visible = False
        '
        'MaterialcategoryDataGridViewTextBoxColumn
        '
        Me.MaterialcategoryDataGridViewTextBoxColumn.DataPropertyName = "material_category"
        Me.MaterialcategoryDataGridViewTextBoxColumn.HeaderText = "material_category"
        Me.MaterialcategoryDataGridViewTextBoxColumn.Name = "MaterialcategoryDataGridViewTextBoxColumn"
        '
        'MaterialtypeDataGridViewTextBoxColumn
        '
        Me.MaterialtypeDataGridViewTextBoxColumn.DataPropertyName = "material_type"
        Me.MaterialtypeDataGridViewTextBoxColumn.HeaderText = "material_type"
        Me.MaterialtypeDataGridViewTextBoxColumn.Name = "MaterialtypeDataGridViewTextBoxColumn"
        '
        'UnitpriceDataGridViewTextBoxColumn
        '
        Me.UnitpriceDataGridViewTextBoxColumn.DataPropertyName = "unit_price"
        Me.UnitpriceDataGridViewTextBoxColumn.HeaderText = "unit_price"
        Me.UnitpriceDataGridViewTextBoxColumn.Name = "UnitpriceDataGridViewTextBoxColumn"
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        '
        'CostDataGridViewTextBoxColumn
        '
        Me.CostDataGridViewTextBoxColumn.DataPropertyName = "cost"
        Me.CostDataGridViewTextBoxColumn.HeaderText = "cost"
        Me.CostDataGridViewTextBoxColumn.Name = "CostDataGridViewTextBoxColumn"
        '
        'RecorddateDataGridViewTextBoxColumn1
        '
        Me.RecorddateDataGridViewTextBoxColumn1.DataPropertyName = "record_date"
        Me.RecorddateDataGridViewTextBoxColumn1.HeaderText = "record_date"
        Me.RecorddateDataGridViewTextBoxColumn1.Name = "RecorddateDataGridViewTextBoxColumn1"
        '
        'ProjectidDataGridViewTextBoxColumn1
        '
        Me.ProjectidDataGridViewTextBoxColumn1.DataPropertyName = "project_id"
        Me.ProjectidDataGridViewTextBoxColumn1.HeaderText = "project_id"
        Me.ProjectidDataGridViewTextBoxColumn1.Name = "ProjectidDataGridViewTextBoxColumn1"
        Me.ProjectidDataGridViewTextBoxColumn1.Visible = False
        '
        'MaterialcategoryidDataGridViewTextBoxColumn
        '
        Me.MaterialcategoryidDataGridViewTextBoxColumn.DataPropertyName = "material_category_id"
        Me.MaterialcategoryidDataGridViewTextBoxColumn.HeaderText = "material_category_id"
        Me.MaterialcategoryidDataGridViewTextBoxColumn.Name = "MaterialcategoryidDataGridViewTextBoxColumn"
        Me.MaterialcategoryidDataGridViewTextBoxColumn.Visible = False
        '
        'MaterialtypeidDataGridViewTextBoxColumn
        '
        Me.MaterialtypeidDataGridViewTextBoxColumn.DataPropertyName = "material_type_id"
        Me.MaterialtypeidDataGridViewTextBoxColumn.HeaderText = "material_type_id"
        Me.MaterialtypeidDataGridViewTextBoxColumn.Name = "MaterialtypeidDataGridViewTextBoxColumn"
        Me.MaterialtypeidDataGridViewTextBoxColumn.Visible = False
        '
        'QmaterialoutBindingSource
        '
        Me.QmaterialoutBindingSource.DataMember = "q_material_out"
        Me.QmaterialoutBindingSource.DataSource = Me.SourceDataSet
        '
        'Q_material_outTableAdapter
        '
        Me.Q_material_outTableAdapter.ClearBeforeFill = True
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProjectaddressDataGridViewTextBoxColumn2, Me.IncometypeDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn, Me.RecorddateDataGridViewTextBoxColumn2, Me.CommentDataGridViewTextBoxColumn, Me.ProjectidDataGridViewTextBoxColumn2, Me.IncometypeidDataGridViewTextBoxColumn})
        Me.DataGridView3.DataSource = Me.QincomeBindingSource
        Me.DataGridView3.Location = New System.Drawing.Point(41, 473)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(719, 127)
        Me.DataGridView3.TabIndex = 2
        '
        'ProjectaddressDataGridViewTextBoxColumn2
        '
        Me.ProjectaddressDataGridViewTextBoxColumn2.DataPropertyName = "project_address"
        Me.ProjectaddressDataGridViewTextBoxColumn2.HeaderText = "project_address"
        Me.ProjectaddressDataGridViewTextBoxColumn2.Name = "ProjectaddressDataGridViewTextBoxColumn2"
        Me.ProjectaddressDataGridViewTextBoxColumn2.Visible = False
        '
        'IncometypeDataGridViewTextBoxColumn
        '
        Me.IncometypeDataGridViewTextBoxColumn.DataPropertyName = "income_type"
        Me.IncometypeDataGridViewTextBoxColumn.HeaderText = "income_type"
        Me.IncometypeDataGridViewTextBoxColumn.Name = "IncometypeDataGridViewTextBoxColumn"
        '
        'AmountDataGridViewTextBoxColumn
        '
        Me.AmountDataGridViewTextBoxColumn.DataPropertyName = "amount"
        Me.AmountDataGridViewTextBoxColumn.HeaderText = "amount"
        Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
        '
        'RecorddateDataGridViewTextBoxColumn2
        '
        Me.RecorddateDataGridViewTextBoxColumn2.DataPropertyName = "record_date"
        Me.RecorddateDataGridViewTextBoxColumn2.HeaderText = "record_date"
        Me.RecorddateDataGridViewTextBoxColumn2.Name = "RecorddateDataGridViewTextBoxColumn2"
        '
        'CommentDataGridViewTextBoxColumn
        '
        Me.CommentDataGridViewTextBoxColumn.DataPropertyName = "comment"
        Me.CommentDataGridViewTextBoxColumn.HeaderText = "comment"
        Me.CommentDataGridViewTextBoxColumn.Name = "CommentDataGridViewTextBoxColumn"
        '
        'ProjectidDataGridViewTextBoxColumn2
        '
        Me.ProjectidDataGridViewTextBoxColumn2.DataPropertyName = "project_id"
        Me.ProjectidDataGridViewTextBoxColumn2.HeaderText = "project_id"
        Me.ProjectidDataGridViewTextBoxColumn2.Name = "ProjectidDataGridViewTextBoxColumn2"
        Me.ProjectidDataGridViewTextBoxColumn2.Visible = False
        '
        'IncometypeidDataGridViewTextBoxColumn
        '
        Me.IncometypeidDataGridViewTextBoxColumn.DataPropertyName = "income_type_id"
        Me.IncometypeidDataGridViewTextBoxColumn.HeaderText = "income_type_id"
        Me.IncometypeidDataGridViewTextBoxColumn.Name = "IncometypeidDataGridViewTextBoxColumn"
        Me.IncometypeidDataGridViewTextBoxColumn.Visible = False
        '
        'QincomeBindingSource
        '
        Me.QincomeBindingSource.DataMember = "q_income"
        Me.QincomeBindingSource.DataSource = Me.SourceDataSet
        '
        'Q_incomeTableAdapter
        '
        Me.Q_incomeTableAdapter.ClearBeforeFill = True
        '
        'cmb_project
        '
        Me.cmb_project.DataSource = Me.RprojectBindingSource
        Me.cmb_project.DisplayMember = "project_address"
        Me.cmb_project.FormattingEnabled = True
        Me.cmb_project.Location = New System.Drawing.Point(41, 40)
        Me.cmb_project.Name = "cmb_project"
        Me.cmb_project.Size = New System.Drawing.Size(136, 21)
        Me.cmb_project.TabIndex = 3
        Me.cmb_project.ValueMember = "ID"
        '
        'RprojectBindingSource
        '
        Me.RprojectBindingSource.DataMember = "r_project"
        Me.RprojectBindingSource.DataSource = Me.SourceDataSet
        '
        'R_projectTableAdapter
        '
        Me.R_projectTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Project"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(175, 242)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Work Hours"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(468, 242)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Payment"
        '
        't_work_hour
        '
        Me.t_work_hour.Location = New System.Drawing.Point(240, 242)
        Me.t_work_hour.Name = "t_work_hour"
        Me.t_work_hour.Size = New System.Drawing.Size(104, 20)
        Me.t_work_hour.TabIndex = 20
        '
        't_payment
        '
        Me.t_payment.Location = New System.Drawing.Point(522, 242)
        Me.t_payment.Name = "t_payment"
        Me.t_payment.Size = New System.Drawing.Size(104, 20)
        Me.t_payment.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(463, 436)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Cost"
        '
        't_cost
        '
        Me.t_cost.Location = New System.Drawing.Point(517, 436)
        Me.t_cost.Name = "t_cost"
        Me.t_cost.Size = New System.Drawing.Size(104, 20)
        Me.t_cost.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(464, 616)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Income"
        '
        't_income
        '
        Me.t_income.Location = New System.Drawing.Point(518, 616)
        Me.t_income.Name = "t_income"
        Me.t_income.Size = New System.Drawing.Size(104, 20)
        Me.t_income.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(231, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Customer Name"
        '
        't_customer_name
        '
        Me.t_customer_name.Location = New System.Drawing.Point(234, 39)
        Me.t_customer_name.Name = "t_customer_name"
        Me.t_customer_name.Size = New System.Drawing.Size(104, 20)
        Me.t_customer_name.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(401, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Start Date"
        '
        't_start_date
        '
        Me.t_start_date.Location = New System.Drawing.Point(404, 39)
        Me.t_start_date.Name = "t_start_date"
        Me.t_start_date.Size = New System.Drawing.Size(104, 20)
        Me.t_start_date.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(577, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Profit"
        '
        't_profit
        '
        Me.t_profit.Location = New System.Drawing.Point(580, 39)
        Me.t_profit.Name = "t_profit"
        Me.t_profit.Size = New System.Drawing.Size(104, 20)
        Me.t_profit.TabIndex = 31
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(38, 242)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Manpower"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(38, 436)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Material Out"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(38, 616)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Income"
        '
        'o_project_detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 647)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.t_profit)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.t_start_date)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.t_customer_name)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.t_income)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.t_cost)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.t_work_hour)
        Me.Controls.Add(Me.t_payment)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_project)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "o_project_detail"
        Me.Text = "Project Detail"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QmanpowereffortBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SourceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QmaterialoutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QincomeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RprojectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SourceDataSet As sourceDataSet
    Friend WithEvents QmanpowereffortBindingSource As BindingSource
    Friend WithEvents Q_manpower_effortTableAdapter As sourceDataSetTableAdapters.q_manpower_effortTableAdapter
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents QmaterialoutBindingSource As BindingSource
    Friend WithEvents Q_material_outTableAdapter As sourceDataSetTableAdapters.q_material_outTableAdapter
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents QincomeBindingSource As BindingSource
    Friend WithEvents Q_incomeTableAdapter As sourceDataSetTableAdapters.q_incomeTableAdapter
    Friend WithEvents cmb_project As ComboBox
    Friend WithEvents RprojectBindingSource As BindingSource
    Friend WithEvents R_projectTableAdapter As sourceDataSetTableAdapters.r_projectTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents t_work_hour As TextBox
    Friend WithEvents t_payment As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents t_cost As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents t_income As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents t_customer_name As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents t_start_date As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents t_profit As TextBox
    Friend WithEvents ProjectaddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WorkhoursDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HourlyrateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaymentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RecorddateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProjectidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProjectaddressDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents MaterialcategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaterialtypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnitpriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RecorddateDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ProjectidDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents MaterialcategoryidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaterialtypeidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProjectaddressDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents IncometypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RecorddateDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents CommentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProjectidDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents IncometypeidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
