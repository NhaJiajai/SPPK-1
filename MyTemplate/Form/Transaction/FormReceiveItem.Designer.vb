<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReceiveItem
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
        Dim NamaLabel As System.Windows.Forms.Label
        Dim TglPOLabel As System.Windows.Forms.Label
        Dim DescriptionPOLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Me.SelectHeaderPO_DetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetRI = New MyTemplate.DataSetRI()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.SelectHeaderPO_DetailTableAdapter = New MyTemplate.DataSetRITableAdapters.SelectHeaderPO_DetailTableAdapter()
        Me.TableAdapterManager = New MyTemplate.DataSetRITableAdapters.TableAdapterManager()
        Me.HeaderRI_DataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HeaderRI_DataTableTableAdapter = New MyTemplate.DataSetRITableAdapters.HeaderRI_DataTableTableAdapter()
        NamaLabel = New System.Windows.Forms.Label()
        TglPOLabel = New System.Windows.Forms.Label()
        DescriptionPOLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.SelectHeaderPO_DetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetRI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.HeaderRI_DataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NamaLabel
        '
        NamaLabel.AutoSize = True
        NamaLabel.Location = New System.Drawing.Point(12, 38)
        NamaLabel.Name = "NamaLabel"
        NamaLabel.Size = New System.Drawing.Size(89, 13)
        NamaLabel.TabIndex = 0
        NamaLabel.Text = "Company Name :"
        '
        'TglPOLabel
        '
        TglPOLabel.AutoSize = True
        TglPOLabel.Location = New System.Drawing.Point(256, 38)
        TglPOLabel.Name = "TglPOLabel"
        TglPOLabel.Size = New System.Drawing.Size(40, 13)
        TglPOLabel.TabIndex = 2
        TglPOLabel.Text = "tgl PO:"
        '
        'DescriptionPOLabel
        '
        DescriptionPOLabel.AutoSize = True
        DescriptionPOLabel.Location = New System.Drawing.Point(521, 38)
        DescriptionPOLabel.Name = "DescriptionPOLabel"
        DescriptionPOLabel.Size = New System.Drawing.Size(81, 13)
        DescriptionPOLabel.TabIndex = 4
        DescriptionPOLabel.Text = "Description PO:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectHeaderPO_DetailBindingSource, "nama", True))
        Label1.Location = New System.Drawing.Point(100, 38)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(37, 13)
        Label1.TabIndex = 5
        Label1.Text = "nama:"
        '
        'SelectHeaderPO_DetailBindingSource
        '
        Me.SelectHeaderPO_DetailBindingSource.DataMember = "SelectHeaderPO_Detail"
        Me.SelectHeaderPO_DetailBindingSource.DataSource = Me.DataSetRI
        '
        'DataSetRI
        '
        Me.DataSetRI.DataSetName = "DataSetRI"
        Me.DataSetRI.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectHeaderPO_DetailBindingSource, "tglPO", True))
        Label2.Location = New System.Drawing.Point(302, 38)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(37, 13)
        Label2.TabIndex = 6
        Label2.Text = "nama:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SelectHeaderPO_DetailBindingSource, "DescriptionPO", True))
        Label3.Location = New System.Drawing.Point(596, 38)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(37, 13)
        Label3.TabIndex = 7
        Label3.Text = "nama:"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Label3)
        Me.GroupControl1.Controls.Add(Label2)
        Me.GroupControl1.Controls.Add(Label1)
        Me.GroupControl1.Controls.Add(DescriptionPOLabel)
        Me.GroupControl1.Controls.Add(TglPOLabel)
        Me.GroupControl1.Controls.Add(NamaLabel)
        Me.GroupControl1.Location = New System.Drawing.Point(0, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(940, 173)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "GroupControl1"
        '
        'SelectHeaderPO_DetailTableAdapter
        '
        Me.SelectHeaderPO_DetailTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.HeaderRI_DataTableTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MyTemplate.DataSetRITableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'HeaderRI_DataTableBindingSource
        '
        Me.HeaderRI_DataTableBindingSource.DataMember = "HeaderRI_DataTable"
        Me.HeaderRI_DataTableBindingSource.DataSource = Me.DataSetRI
        '
        'HeaderRI_DataTableTableAdapter
        '
        Me.HeaderRI_DataTableTableAdapter.ClearBeforeFill = True
        '
        'FormReceiveItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 482)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "FormReceiveItem"
        Me.Text = "FormReceiveItem"
        CType(Me.SelectHeaderPO_DetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetRI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.HeaderRI_DataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents DataSetRI As MyTemplate.DataSetRI
    Friend WithEvents SelectHeaderPO_DetailBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SelectHeaderPO_DetailTableAdapter As MyTemplate.DataSetRITableAdapters.SelectHeaderPO_DetailTableAdapter
    Friend WithEvents TableAdapterManager As MyTemplate.DataSetRITableAdapters.TableAdapterManager
    Friend WithEvents HeaderRI_DataTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HeaderRI_DataTableTableAdapter As MyTemplate.DataSetRITableAdapters.HeaderRI_DataTableTableAdapter
End Class
