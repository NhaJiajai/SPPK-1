Public Class DetailPayment 
    Public Property idHeaderPayment As Integer
    Sub SaveData()
        Me.Validate()
        Me.PaymentDetailDataTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetPayment)
    End Sub
    Sub LoadDetailPayment()
        Try
            Me.PaymentDetailTableAdapter.Fill(Me.DataSetPayment.PaymentDetailDataTable, New System.Nullable(Of Integer)(CType(idHeaderPayment, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub LoadHeaderPayment()
        Try
            Me.PaymentDetailTableAdapter.Fill(Me.DataSetPayment.PaymentDetailDataTable, New System.Nullable(Of Integer)(CType(idHeaderPayment, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub SaveDetailSO()
        Me.Validate()
        Me.PaymentDetailDataTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetPayment)
    End Sub
    Sub DeleteDataDetail()
        Dim Row() As Integer = GridView1.GetSelectedRows
        If Row.Count > 0 Then
            PaymentDetailDataTableBindingSource.RemoveCurrent()
            SaveData()
        End If
    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        GridView1.SetFocusedRowCellValue(colidHeaderPayment, TextEditIDHeaderPayment.Text)
        GridView1.AddNewRow()
    End Sub
    Private Sub GridView1_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GridView1.InitNewRow
        GridView1.SetFocusedRowCellValue(colidHeaderPayment, TextEditIDHeaderPayment.Text)
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        SaveDetailSO()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        DeleteDataDetail()
    End Sub

    Private Sub DetailPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetPayment.SelectSubAccCOADataTable' table. You can move, or remove it, as needed.
        Me.SelectSubAccCOATableAdapter.Fill(Me.DataSetPayment.SelectSubAccCOADataTable)

    End Sub
End Class