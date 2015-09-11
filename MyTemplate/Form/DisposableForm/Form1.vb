Public Class Form1

    
  
    Private Sub SODetailDataTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SODetailDataTableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SODetailDataTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetSO)

    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs) Handles FillToolStripButton.Click
        Try
            Me.SODetailTableAdapter.Fill(Me.DataSetSO.SODetailDataTable, New System.Nullable(Of Integer)(CType(IdHeaderSOToolStripTextBox.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click

    End Sub
End Class