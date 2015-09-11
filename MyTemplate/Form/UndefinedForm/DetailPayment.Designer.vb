<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetailPayment
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataSetPayment = New MyTemplate.DataSetPayment()
        Me.PaymentDetailDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PaymentDetailTableAdapter = New MyTemplate.DataSetPaymentTableAdapters.PaymentDetailTableAdapter()
        Me.TableAdapterManager = New MyTemplate.DataSetPaymentTableAdapters.TableAdapterManager()
        Me.PaymentDetailDataTableGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDSubAccCOA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDEmployee = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDVendor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDProject = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidHeaderPayment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.TextEditIDHeaderPayment = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.SelectSubAccCOADataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SelectSubAccCOATableAdapter = New MyTemplate.DataSetPaymentTableAdapters.SelectSubAccCOATableAdapter()
        Me.SelectHeaderPaymentDetailDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SelectHeaderPaymentDetailTableAdapter = New MyTemplate.DataSetPaymentTableAdapters.SelectHeaderPaymentDetailTableAdapter()
        Me.SelectHeaderPaymentDetailDataTableBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SelectHeaderPaymentDetailDataTableBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SelectHeaderPaymentDetailDataTableBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SelectHeaderPaymentDetailDataTableBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SelectHeaderPaymentDetailDataTableBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataSetPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentDetailDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentDetailDataTableGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.TextEditIDHeaderPayment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.SelectSubAccCOADataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectHeaderPaymentDetailDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectHeaderPaymentDetailDataTableBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectHeaderPaymentDetailDataTableBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectHeaderPaymentDetailDataTableBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectHeaderPaymentDetailDataTableBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectHeaderPaymentDetailDataTableBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetPayment
        '
        Me.DataSetPayment.DataSetName = "DataSetPayment"
        Me.DataSetPayment.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PaymentDetailDataTableBindingSource
        '
        Me.PaymentDetailDataTableBindingSource.DataMember = "PaymentDetailDataTable"
        Me.PaymentDetailDataTableBindingSource.DataSource = Me.DataSetPayment
        '
        'PaymentDetailTableAdapter
        '
        Me.PaymentDetailTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.HeaderPaymentTableAdapter = Nothing
        Me.TableAdapterManager.PaymentDetailTableAdapter = Me.PaymentDetailTableAdapter
        Me.TableAdapterManager.UpdateOrder = MyTemplate.DataSetPaymentTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PaymentDetailDataTableGridControl
        '
        Me.PaymentDetailDataTableGridControl.DataSource = Me.PaymentDetailDataTableBindingSource
        Me.PaymentDetailDataTableGridControl.Location = New System.Drawing.Point(5, 23)
        Me.PaymentDetailDataTableGridControl.MainView = Me.GridView1
        Me.PaymentDetailDataTableGridControl.Name = "PaymentDetailDataTableGridControl"
        Me.PaymentDetailDataTableGridControl.Size = New System.Drawing.Size(735, 228)
        Me.PaymentDetailDataTableGridControl.TabIndex = 2
        Me.PaymentDetailDataTableGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colIDSubAccCOA, Me.colAmount, Me.colIDEmployee, Me.colIDVendor, Me.colIDProject, Me.colidHeaderPayment})
        Me.GridView1.GridControl = Me.PaymentDetailDataTableGridControl
        Me.GridView1.Name = "GridView1"
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.Visible = True
        Me.colID.VisibleIndex = 0
        '
        'colIDSubAccCOA
        '
        Me.colIDSubAccCOA.FieldName = "IDSubAccCOA"
        Me.colIDSubAccCOA.Name = "colIDSubAccCOA"
        Me.colIDSubAccCOA.Visible = True
        Me.colIDSubAccCOA.VisibleIndex = 1
        '
        'colAmount
        '
        Me.colAmount.FieldName = "Amount"
        Me.colAmount.Name = "colAmount"
        Me.colAmount.Visible = True
        Me.colAmount.VisibleIndex = 2
        '
        'colIDEmployee
        '
        Me.colIDEmployee.FieldName = "IDEmployee"
        Me.colIDEmployee.Name = "colIDEmployee"
        Me.colIDEmployee.Visible = True
        Me.colIDEmployee.VisibleIndex = 3
        '
        'colIDVendor
        '
        Me.colIDVendor.FieldName = "IDVendor"
        Me.colIDVendor.Name = "colIDVendor"
        Me.colIDVendor.Visible = True
        Me.colIDVendor.VisibleIndex = 4
        '
        'colIDProject
        '
        Me.colIDProject.FieldName = "IDProject"
        Me.colIDProject.Name = "colIDProject"
        Me.colIDProject.Visible = True
        Me.colIDProject.VisibleIndex = 5
        '
        'colidHeaderPayment
        '
        Me.colidHeaderPayment.FieldName = "idHeaderPayment"
        Me.colidHeaderPayment.Name = "colidHeaderPayment"
        Me.colidHeaderPayment.Visible = True
        Me.colidHeaderPayment.VisibleIndex = 6
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.TextEditIDHeaderPayment)
        Me.GroupControl2.Controls.Add(Me.LabelControl7)
        Me.GroupControl2.Controls.Add(Me.LabelControl9)
        Me.GroupControl2.Controls.Add(Me.LabelControl11)
        Me.GroupControl2.Controls.Add(Me.LabelControl12)
        Me.GroupControl2.Controls.Add(Me.LabelControl10)
        Me.GroupControl2.Controls.Add(Me.LabelControl8)
        Me.GroupControl2.Controls.Add(Me.LabelControl6)
        Me.GroupControl2.Controls.Add(Me.LabelControl5)
        Me.GroupControl2.Controls.Add(Me.LabelControl4)
        Me.GroupControl2.Controls.Add(Me.LabelControl3)
        Me.GroupControl2.Controls.Add(Me.LabelControl2)
        Me.GroupControl2.Controls.Add(Me.LabelControl1)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 2)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(620, 117)
        Me.GroupControl2.TabIndex = 5
        Me.GroupControl2.Text = "Edited Payment"
        '
        'TextEditIDHeaderPayment
        '
        Me.TextEditIDHeaderPayment.Location = New System.Drawing.Point(597, 81)
        Me.TextEditIDHeaderPayment.Name = "TextEditIDHeaderPayment"
        Me.TextEditIDHeaderPayment.Size = New System.Drawing.Size(11, 20)
        Me.TextEditIDHeaderPayment.TabIndex = 3
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectHeaderPaymentDetailDataTableBindingSource3, "Memo", True))
        Me.LabelControl7.Location = New System.Drawing.Point(451, 35)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(39, 17)
        Me.LabelControl7.TabIndex = 21
        Me.LabelControl7.Text = "Memo:"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectHeaderPaymentDetailDataTableBindingSource5, "Amount", True))
        Me.LabelControl9.Location = New System.Drawing.Point(451, 81)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(51, 17)
        Me.LabelControl9.TabIndex = 20
        Me.LabelControl9.Text = "Amount:"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectHeaderPaymentDetailDataTableBindingSource4, "ReceivedBy", True))
        Me.LabelControl11.Location = New System.Drawing.Point(451, 58)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(75, 17)
        Me.LabelControl11.TabIndex = 19
        Me.LabelControl11.Text = "Received By:"
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Location = New System.Drawing.Point(356, 34)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(39, 17)
        Me.LabelControl12.TabIndex = 18
        Me.LabelControl12.Text = "Memo:"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Location = New System.Drawing.Point(356, 80)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(51, 17)
        Me.LabelControl10.TabIndex = 16
        Me.LabelControl10.Text = "Amount:"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(356, 57)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(75, 17)
        Me.LabelControl8.TabIndex = 14
        Me.LabelControl8.Text = "Received By:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectHeaderPaymentDetailDataTableBindingSource2, "PaymentDate", True))
        Me.LabelControl6.Location = New System.Drawing.Point(109, 81)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(86, 17)
        Me.LabelControl6.TabIndex = 13
        Me.LabelControl6.Text = "Payment Date"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectHeaderPaymentDetailDataTableBindingSource1, "PaymentNo", True))
        Me.LabelControl5.Location = New System.Drawing.Point(109, 58)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(77, 17)
        Me.LabelControl5.TabIndex = 12
        Me.LabelControl5.Text = "Payment No:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectHeaderPaymentDetailDataTableBindingSource, "namaSubAccount", True))
        Me.LabelControl4.Location = New System.Drawing.Point(109, 35)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(63, 17)
        Me.LabelControl4.TabIndex = 11
        Me.LabelControl4.Text = "Paid From:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(14, 81)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(89, 17)
        Me.LabelControl3.TabIndex = 10
        Me.LabelControl3.Text = "Payment Date:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(14, 58)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(77, 17)
        Me.LabelControl2.TabIndex = 9
        Me.LabelControl2.Text = "Payment No:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(14, 35)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(63, 17)
        Me.LabelControl1.TabIndex = 8
        Me.LabelControl1.Text = "Paid From:"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.SimpleButton3)
        Me.GroupControl3.Controls.Add(Me.SimpleButton2)
        Me.GroupControl3.Controls.Add(Me.SimpleButton1)
        Me.GroupControl3.Location = New System.Drawing.Point(651, 7)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(106, 112)
        Me.GroupControl3.TabIndex = 6
        Me.GroupControl3.Text = "Command Center"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Location = New System.Drawing.Point(14, 81)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton3.TabIndex = 2
        Me.SimpleButton3.Text = "Delete"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(14, 52)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton2.TabIndex = 1
        Me.SimpleButton2.Text = "Save"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(14, 23)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "Add Detail"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.PaymentDetailDataTableGridControl)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 125)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(745, 293)
        Me.GroupControl1.TabIndex = 7
        Me.GroupControl1.Text = "List Of Detail Payment"
        '
        'SelectSubAccCOADataTableBindingSource
        '
        Me.SelectSubAccCOADataTableBindingSource.DataMember = "SelectSubAccCOADataTable"
        Me.SelectSubAccCOADataTableBindingSource.DataSource = Me.DataSetPayment
        '
        'SelectSubAccCOATableAdapter
        '
        Me.SelectSubAccCOATableAdapter.ClearBeforeFill = True
        '
        'SelectHeaderPaymentDetailDataTableBindingSource
        '
        Me.SelectHeaderPaymentDetailDataTableBindingSource.DataMember = "SelectHeaderPaymentDetailDataTable"
        Me.SelectHeaderPaymentDetailDataTableBindingSource.DataSource = Me.DataSetPayment
        '
        'SelectHeaderPaymentDetailTableAdapter
        '
        Me.SelectHeaderPaymentDetailTableAdapter.ClearBeforeFill = True
        '
        'SelectHeaderPaymentDetailDataTableBindingSource1
        '
        Me.SelectHeaderPaymentDetailDataTableBindingSource1.DataMember = "SelectHeaderPaymentDetailDataTable"
        Me.SelectHeaderPaymentDetailDataTableBindingSource1.DataSource = Me.DataSetPayment
        '
        'SelectHeaderPaymentDetailDataTableBindingSource2
        '
        Me.SelectHeaderPaymentDetailDataTableBindingSource2.DataMember = "SelectHeaderPaymentDetailDataTable"
        Me.SelectHeaderPaymentDetailDataTableBindingSource2.DataSource = Me.DataSetPayment
        '
        'SelectHeaderPaymentDetailDataTableBindingSource3
        '
        Me.SelectHeaderPaymentDetailDataTableBindingSource3.DataMember = "SelectHeaderPaymentDetailDataTable"
        Me.SelectHeaderPaymentDetailDataTableBindingSource3.DataSource = Me.DataSetPayment
        '
        'SelectHeaderPaymentDetailDataTableBindingSource4
        '
        Me.SelectHeaderPaymentDetailDataTableBindingSource4.DataMember = "SelectHeaderPaymentDetailDataTable"
        Me.SelectHeaderPaymentDetailDataTableBindingSource4.DataSource = Me.DataSetPayment
        '
        'SelectHeaderPaymentDetailDataTableBindingSource5
        '
        Me.SelectHeaderPaymentDetailDataTableBindingSource5.DataMember = "SelectHeaderPaymentDetailDataTable"
        Me.SelectHeaderPaymentDetailDataTableBindingSource5.DataSource = Me.DataSetPayment
        '
        'DetailPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 430)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl2)
        Me.Name = "DetailPayment"
        Me.Text = "DetailPayment"
        CType(Me.DataSetPayment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentDetailDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentDetailDataTableGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.TextEditIDHeaderPayment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.SelectSubAccCOADataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectHeaderPaymentDetailDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectHeaderPaymentDetailDataTableBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectHeaderPaymentDetailDataTableBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectHeaderPaymentDetailDataTableBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectHeaderPaymentDetailDataTableBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectHeaderPaymentDetailDataTableBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataSetPayment As MyTemplate.DataSetPayment
    Friend WithEvents PaymentDetailDataTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PaymentDetailTableAdapter As MyTemplate.DataSetPaymentTableAdapters.PaymentDetailTableAdapter
    Friend WithEvents TableAdapterManager As MyTemplate.DataSetPaymentTableAdapters.TableAdapterManager
    Friend WithEvents PaymentDetailDataTableGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEditIDHeaderPayment As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDSubAccCOA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDEmployee As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDVendor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDProject As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidHeaderPayment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SelectSubAccCOADataTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SelectSubAccCOATableAdapter As MyTemplate.DataSetPaymentTableAdapters.SelectSubAccCOATableAdapter
    Friend WithEvents SelectHeaderPaymentDetailDataTableBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents SelectHeaderPaymentDetailDataTableBindingSource5 As System.Windows.Forms.BindingSource
    Friend WithEvents SelectHeaderPaymentDetailDataTableBindingSource4 As System.Windows.Forms.BindingSource
    Friend WithEvents SelectHeaderPaymentDetailDataTableBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents SelectHeaderPaymentDetailDataTableBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents SelectHeaderPaymentDetailDataTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SelectHeaderPaymentDetailTableAdapter As MyTemplate.DataSetPaymentTableAdapters.SelectHeaderPaymentDetailTableAdapter
End Class
