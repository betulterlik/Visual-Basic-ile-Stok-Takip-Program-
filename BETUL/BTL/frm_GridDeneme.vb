Public Class frm_GridDeneme
    Private Sub frm_GridDeneme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grd.Rows.Add("H1","H2","H3","H4")
        grd.Rows.Add("H5","H6","H7","H8")
        grd.Rows.Add("H9","H10","H11","H12")
        grd.Rows.Add("H13","H14","H15","H16")

        'txt.Text = "Bu sadece text"
        txt.AppendText("Grid row count:" & grd.Rows.Count.ToString & vbCrLf)
        txt.AppendText("İlk eleman:" & grd.Item(0,0).Value.ToString & vbCrLf)
        txt.AppendText("İkinci eleman:" & grd.Item(1,0).Value.ToString & vbCrLf)
        txt.AppendText("ucncu eleman:" & grd.Item(2,0).Value.ToString & vbCrLf)
        txt.AppendText("dort eleman:" & grd.Item(3,0).Value.ToString & vbCrLf)

        For i As Integer = -1 To grd.Rows.Count-1
            txt.AppendText("Row ekle:" & grd.Item(0,i).Value & vbCrLf)
        Next

    End Sub
End Class