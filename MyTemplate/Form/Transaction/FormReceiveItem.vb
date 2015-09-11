Public Class FormReceiveItem 

    Public Property IdHeaderPO As Integer

   Private Sub FormReceiveItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDataHeaderPO()
        LoadHeaderRI()
        'IDSpinEdit.Value = Me.DataSetRI.SelectHeaderPO_Detail.Rows(0).Item(3)
    End Sub

    Private Sub loadDataHeaderPO()
        Try
            Me.SelectHeaderPO_DetailTableAdapter.Fill(Me.DataSetRI.SelectHeaderPO_Detail, New System.Nullable(Of Integer)(CType(IdHeaderPO, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
    Sub SaveHeaderRI()
        Me.Validate()
        Me.HeaderRI_DataTableBindingSource.EndEdit()
        'Me.TableAdapterManagerHeaderRI.UpdateAll(Me.DataSetRI)

    End Sub

    Sub LoadHeaderRI()
        Try
            Me.HeaderRI_DataTableTableAdapter.Fill(Me.DataSetRI.HeaderRI_DataTable, New System.Nullable(Of Integer)(CType(IdHeaderPO, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)
        SaveHeaderRI()
    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.HeaderRI_DataTableTableAdapter.Fill(Me.DataSetRI.HeaderRI_DataTable, New System.Nullable(Of Integer)(CType(IdHeaderPoToolStripTextBox.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class