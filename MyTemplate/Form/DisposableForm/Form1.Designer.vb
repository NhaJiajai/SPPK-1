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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.DataSetSO = New MyTemplate.DataSetSO()
        Me.SODetailDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SODetailTableAdapter = New MyTemplate.DataSetSOTableAdapters.SODetailTableAdapter()
        Me.TableAdapterManager = New MyTemplate.DataSetSOTableAdapters.TableAdapterManager()
        Me.SODetailDataTableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SODetailDataTableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FillToolStrip = New System.Windows.Forms.ToolStrip()
        Me.IdHeaderSOToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.IdHeaderSOToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SODetailDataTableGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.DataSetSO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SODetailDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SODetailDataTableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SODetailDataTableBindingNavigator.SuspendLayout()
        Me.FillToolStrip.SuspendLayout()
        CType(Me.SODetailDataTableGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetSO
        '
        Me.DataSetSO.DataSetName = "DataSetSO"
        Me.DataSetSO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SODetailDataTableBindingSource
        '
        Me.SODetailDataTableBindingSource.DataMember = "SODetailDataTable"
        Me.SODetailDataTableBindingSource.DataSource = Me.DataSetSO
        '
        'SODetailTableAdapter
        '
        Me.SODetailTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SODetailTableAdapter = Me.SODetailTableAdapter
        Me.TableAdapterManager.SOHeaderTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MyTemplate.DataSetSOTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SODetailDataTableBindingNavigator
        '
        Me.SODetailDataTableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SODetailDataTableBindingNavigator.BindingSource = Me.SODetailDataTableBindingSource
        Me.SODetailDataTableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SODetailDataTableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SODetailDataTableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SODetailDataTableBindingNavigatorSaveItem})
        Me.SODetailDataTableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SODetailDataTableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SODetailDataTableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SODetailDataTableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SODetailDataTableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SODetailDataTableBindingNavigator.Name = "SODetailDataTableBindingNavigator"
        Me.SODetailDataTableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SODetailDataTableBindingNavigator.Size = New System.Drawing.Size(810, 25)
        Me.SODetailDataTableBindingNavigator.TabIndex = 0
        Me.SODetailDataTableBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'SODetailDataTableBindingNavigatorSaveItem
        '
        Me.SODetailDataTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SODetailDataTableBindingNavigatorSaveItem.Image = CType(resources.GetObject("SODetailDataTableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SODetailDataTableBindingNavigatorSaveItem.Name = "SODetailDataTableBindingNavigatorSaveItem"
        Me.SODetailDataTableBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SODetailDataTableBindingNavigatorSaveItem.Text = "Save Data"
        '
        'FillToolStrip
        '
        Me.FillToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IdHeaderSOToolStripLabel, Me.IdHeaderSOToolStripTextBox, Me.FillToolStripButton})
        Me.FillToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.FillToolStrip.Name = "FillToolStrip"
        Me.FillToolStrip.Size = New System.Drawing.Size(810, 25)
        Me.FillToolStrip.TabIndex = 1
        Me.FillToolStrip.Text = "FillToolStrip"
        '
        'IdHeaderSOToolStripLabel
        '
        Me.IdHeaderSOToolStripLabel.Name = "IdHeaderSOToolStripLabel"
        Me.IdHeaderSOToolStripLabel.Size = New System.Drawing.Size(73, 22)
        Me.IdHeaderSOToolStripLabel.Text = "idHeaderSO:"
        '
        'IdHeaderSOToolStripTextBox
        '
        Me.IdHeaderSOToolStripTextBox.Name = "IdHeaderSOToolStripTextBox"
        Me.IdHeaderSOToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillToolStripButton
        '
        Me.FillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillToolStripButton.Name = "FillToolStripButton"
        Me.FillToolStripButton.Size = New System.Drawing.Size(26, 22)
        Me.FillToolStripButton.Text = "Fill"
        '
        'SODetailDataTableGridControl
        '
        Me.SODetailDataTableGridControl.DataSource = Me.SODetailDataTableBindingSource
        Me.SODetailDataTableGridControl.Location = New System.Drawing.Point(119, 201)
        Me.SODetailDataTableGridControl.MainView = Me.GridView2
        Me.SODetailDataTableGridControl.Name = "SODetailDataTableGridControl"
        Me.SODetailDataTableGridControl.Size = New System.Drawing.Size(300, 220)
        Me.SODetailDataTableGridControl.TabIndex = 2
        Me.SODetailDataTableGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.SODetailDataTableGridControl
        Me.GridView2.Name = "GridView2"
        '
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(810, 441)
        Me.Controls.Add(Me.SODetailDataTableGridControl)
        Me.Controls.Add(Me.FillToolStrip)
        Me.Controls.Add(Me.SODetailDataTableBindingNavigator)
        Me.Name = "Form1"
        CType(Me.DataSetSO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SODetailDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SODetailDataTableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SODetailDataTableBindingNavigator.ResumeLayout(False)
        Me.SODetailDataTableBindingNavigator.PerformLayout()
        Me.FillToolStrip.ResumeLayout(False)
        Me.FillToolStrip.PerformLayout()
        CType(Me.SODetailDataTableGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataSetRISelectItem As MyTemplate.DataSetRI
    Friend WithEvents SP_Select_Item_DetalRIBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SP_Select_Item_DetalRITableAdapter As MyTemplate.DataSetRITableAdapters.SP_Select_Item_DetalRITableAdapter
    Friend WithEvents TableAdapterManagerSelectItem As MyTemplate.DataSetRITableAdapters.TableAdapterManager
    Friend WithEvents SP_Select_Item_DetalRIGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DataSetSO As MyTemplate.DataSetSO
    Friend WithEvents SODetailDataTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SODetailTableAdapter As MyTemplate.DataSetSOTableAdapters.SODetailTableAdapter
    Friend WithEvents TableAdapterManager As MyTemplate.DataSetSOTableAdapters.TableAdapterManager
    Friend WithEvents SODetailDataTableBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SODetailDataTableBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents FillToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents IdHeaderSOToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents IdHeaderSOToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SODetailDataTableGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
