Public Class FormJabatan 



    Private Sub FormTemplate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetFormAttribute()

        CanClose = True
        LoadData()

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        SwitchMode(Me, True)
        IsNew = True
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        GetDetail()
        SwitchMode(Me, True)

    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        If oClassJabatan.id = 0 Then
            XtraMessageBox.Show("Pilih data yang akan di hapus terlebih dahulu")
        End If
        If XtraMessageBox.Show("Apakah anda yakin akan menghapus data ini", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

        End If
    End Sub

    Sub LoadData()
        GridControl1.SuspendLayout()
        GridControl1.DataSource = Nothing
        oClassJabatan.Get()
        GridControl1.DataSource = oClassJabatan.DataJabatan.Tables(0)
        GridControl1.Refresh()
        GridControl1.Refresh()
        GridView1.BestFitColumns(True)
        GridView1.Columns(0).Visible = False
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        SwitchMode(Me, False)
        oClassJabatan.Jabatan = textEditJabatan.Text
        oClassJabatan.Set(IsNew)


        If IsNew = True Then
            SetMessage("Data Berhasil Disimpan")
        Else
            SetMessage("Data Jabatan " & textEditJabatan.Text & " Berhasil diupdate")
        End If

        EmptyTxt(Me)
        LoadData()
        CanClose = True

        IsSaved = True
    End Sub

    Sub GetDetail()
        ID = Convert.ToInt32(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns(0)))
        IsNew = False
        textEditJabatan.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns(1))
        oClassJabatan.id = ID
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        SetFormAttribute()
        ID = 0
        EmptyTxt(Me)
    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs)
        SetMessage("A test Message")

    End Sub
End Class