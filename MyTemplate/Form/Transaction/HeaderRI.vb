Public Class HeaderRI
    Public Property IDHeaderPO As Integer = 0
    'Sub SaveHeader()
    '    Me.Validate()
    '    Me.RIHeaderDataTableBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.DataSetRI)
    'End Sub
    'Sub LoadHeader()
    '    Try
    '        Me.RIHeaderTableAdapter.Fill(Me.DataSetRI.RIHeaderDataTable, New System.Nullable(Of Integer)(CType(IDHeaderPO, Integer)))
    '    Catch ex As System.Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    '    End Try
    'End Sub

    'Private Sub HeaderRI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    LoadHeader()
    'End Sub
End Class