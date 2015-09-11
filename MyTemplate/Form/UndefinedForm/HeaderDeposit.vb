Public Class HeaderDeposit 
    Sub LoadData()
        Me.HeaderDepositTableAdapter.Fill(Me.DataSetDeposit.HeaderDepositDataTable)
    End Sub
    Sub SaveData()
        Me.Validate()
        Me.HeaderDepositDataTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetDeposit)
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        If XtraMessageBox.Show("Apakah anda yakin akan menghapus data ini", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim row() As Integer = GridView1.GetSelectedRows
            If row.Count > 0 Then
                HeaderDepositDataTableBindingSource.RemoveCurrent()
                SaveData()
                LoadData()
            End If
        End If
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        SaveData()
        SetMessage("Data Has Been Saved")
    End Sub

    Private Sub HeaderDeposit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetDeposit.SelectSubAccCOADataTable' table. You can move, or remove it, as needed.
        Me.SelectSubAccCOADataTableTableAdapter.Fill(Me.DataSetDeposit.SelectSubAccCOADataTable)

    End Sub
End Class