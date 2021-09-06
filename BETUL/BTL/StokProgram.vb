Imports System.IO

Public Class StokProgram

    Public LocalDB As New SQLiteTools("C:\Users\Betül TERLİK\AppData\Roaming\ELOPAR\BetulDB\BetulDB.db", True)

    Private Sub StokProgram_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text += " " & String.Format(" {0}", My.Application.Info.Version.ToString)

        grdStok.DataSource = LocalDB.PopulateGrid("SELECT*FROM STOK ORDER BY AD")

        'If grdStok.Rows.Count > 0 Then
        '    grdStok.Rows(0).Selected = False
        'End If
        Me.MaximizeBox = False
        Me.MinimumSize = Me.Size
    End Sub

    Private Sub btnStokEkle_Click(sender As Object, e As EventArgs) Handles btnStokEkle.Click


        If txt_ad.Text <> String.Empty Then
            If txt_model.Text <> String.Empty Then
                If txt_serino.Text <> String.Empty Then
                    If txt_adet.Text <> String.Empty Then
                        If dt_tarih.Text <> String.Empty Then
                            If txt_kayit.Text <> String.Empty Then

                                LocalDB.ExecuteNonQuery("INSERT INTO STOK VALUES ('" & txt_ad.Text & "','" & txt_model.Text & "','" & txt_serino.Text & "','" & txt_adet.Text & "','" & dt_tarih.Text & "','" & txt_kayit.Text & "','NULL') ")

                                If Not pictureBox1.Image Is Nothing Then
                                    LocalDB.SetImage("UPDATE STOK SET RESIM=@RESIM1 WHERE SERINO='" & txt_serino.Text & "'", "@RESIM1", pictureBox1.Image)
                                End If

                                grdStok.DataSource = LocalDB.PopulateGrid("SELECT*FROM STOK ORDER BY AD")

                                MsgBox("Eklendi !")

                            End If
                        End If

                    End If

                End If

            End If

            txt_ad.Focus()
        End If

        temizle()

    End Sub
    Public Sub temizle()
        txt_ad.Text = String.Empty
        txt_model.Text = String.Empty
        txt_serino.Text = String.Empty
        txt_adet.Text = String.Empty
        dt_tarih.Text = String.Empty
        txt_kayit.Text = String.Empty
        pictureBox1.Image = Nothing
    End Sub

    Private Sub btnStokSil_Click(sender As Object, e As EventArgs) Handles btnStokSil.Click
        If (txt_ad.Text <> String.Empty) Then
            If MsgBox(("Silmek istiyormusunuz"), MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then


                LocalDB.ExecuteNonQuery("DELETE FROM STOK WHERE ( AD='" & txt_ad.Text.ToString & "') AND (MODEL='" & txt_model.Text.ToString & "' ) AND (SERINO='" & txt_serino.Text.ToString & "' ) ")

                grdStok.DataSource = LocalDB.PopulateGrid("SELECT*FROM STOK ORDER BY AD")

                MsgBox("Silindi !")

                temizle()

            End If
        End If
    End Sub

    Private Sub btnCikis_Click(sender As Object, e As EventArgs) Handles btnCikis.Click
        Me.Close()
    End Sub


    Private Sub grdStok_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdStok.CellContentClick

        txt_ad.Text = grdStok.Item("AD", grdStok.CurrentRow.Index).Value.ToString()

        txt_model.Text = grdStok.Item("MODEL", grdStok.CurrentRow.Index).Value.ToString()

        txt_serino.Text = grdStok.Item("SERINO", grdStok.CurrentRow.Index).Value.ToString()

        txt_adet.Text = grdStok.Item("ADET", grdStok.CurrentRow.Index).Value.ToString()

        dt_tarih.Value = grdStok.Item("TARIH", grdStok.CurrentRow.Index).Value.ToString()

        txt_kayit.Text = grdStok.Item("KAYITYAPAN", grdStok.CurrentRow.Index).Value.ToString()

        'pictureBox1.Text = grdStok.Item("RESIM", grdStok.CurrentRow.Index).Value()

        ' Show pics
        If Not IsDBNull(grdStok.Item("RESIM", grdStok.CurrentRow.Index).Value) Then
            Dim pic1 As [Byte]() = grdStok.Item("RESIM", grdStok.CurrentRow.Index).Value
            Dim ms As New MemoryStream(pic1)
            pictureBox1.Image = Image.FromStream(ms)
        Else
            pictureBox1.Image = Nothing
        End If

        'Dim dgBtnCol As DataGridViewButtonColumn = New DataGridViewButtonColumn
        'grdStok.Columns.Add(dgBtnCol)
        'dgBtnCol.HeaderText = "Resim"
        'dgBtnCol.Text = "Resim"
        'dgBtnCol.Name = "btn"
        'dgBtnCol.UseColumnTextForButtonValue = True

    End Sub

    Private Sub btnStokAdiAra_Click(sender As Object, e As EventArgs) Handles btnStokAdiAra.Click

        Dim sqlStr As String

        sqlStr = "SELECT * FROM STOK  WHERE "


        If txt_stokadiara.Text.ToString <> String.Empty Then
            sqlStr += "AD = '" & txt_stokadiara.Text & "'"
        End If

        'If txt_model.Text.ToString <> String.Empty Then
        '    sqlStr += "MODEL = '" & txt_model.Text.ToString & "' AND "
        'End If

        'If txt_serino.Text.ToString <> String.Empty Then
        '    sqlStr += "SERINO = '" & txt_serino.Text.ToString & "'"
        'End If

        'If txt_adet.Text.ToString <> String.Empty Then
        '    sqlStr += "ADET = '" & txt_adet.Text.ToString & "'"
        'End If

        'If dt_tarih.Text.ToString <> String.Empty Then
        '    sqlStr += "TARIH = '" & dt_tarih.Text.ToString & "'"
        'End If

        'If txt_kayit.Text.ToString <> String.Empty Then
        '    sqlStr += "KAYITYAPAN = '" & txt_kayit.Text.ToString & "'"
        'End If


        grdStok.DataSource = LocalDB.PopulateGrid(sqlStr)
        If grdStok.Rows.Count > 0 Then
            grdStok.Rows(0).Selected = False
        End If
    End Sub

    Private Sub btnStokModelAra_Click(sender As Object, e As EventArgs) Handles btnStokModelAra.Click
        Dim sqlStr As String

        sqlStr = "SELECT * FROM STOK  WHERE "


        If txt_modelara.Text.ToString <> String.Empty Then
            sqlStr += " MODEL = '" & txt_modelara.Text & "'"
        End If

        grdStok.DataSource = LocalDB.PopulateGrid(sqlStr)

        'If grdStok.Rows.Count > 0 Then
        '    grdStok.Rows(0).Selected = False
        'End If

        grdStok.DataSource = LocalDB.PopulateGrid(sqlStr)
        If grdStok.Rows.Count > 0 Then
            grdStok.Rows(0).Selected = False
        End If

    End Sub

    Private Sub btnResimEkle_Click(sender As Object, e As EventArgs) Handles btnResimEkle.Click

        Try

            Dim opf As New OpenFileDialog
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"

            If opf.ShowDialog = DialogResult.OK Then
                pictureBox1.Image = Image.FromFile(opf.FileName)
            End If

            Dim ms As New MemoryStream
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat)
            ' Dim img As Byte()
            ' img = ms.ToArray()
            ' grdStok.Rows.Add(img)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try


    End Sub

    Private Sub btnResimSil_Click(sender As Object, e As EventArgs) Handles btnResimSil.Click
        pictureBox1.Image = Nothing
    End Sub

    Private Sub grdStok_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles grdStok.DataError
        e.Cancel = True
    End Sub

    Private Sub btnStokGuncelle_Click(sender As Object, e As EventArgs) Handles btnStokGuncelle.Click


        If txt_ad.Text <> String.Empty Then
            If txt_model.Text <> String.Empty Then
                If txt_serino.Text <> String.Empty Then
                    If txt_adet.Text <> String.Empty Then
                        If dt_tarih.Text <> String.Empty Then
                            If txt_kayit.Text <> String.Empty Then

                                If Not LocalDB.isThere("SELECT * FROM STOK WHERE SERINO = '" & txt_serino.Text.ToString & "' ") Then

                                    LocalDB.ExecuteNonQuery("UPDATE STOK SET AD='" & txt_ad.Text.ToString & "', MODEL='" & txt_model.Text.ToString & "', SERINO='" & txt_serino.Text.ToString & "', ADET='" & txt_adet.Text.ToString & "', TARIH='" & dt_tarih.Text.ToString & "', KAYITYAPAN='" & txt_kayit.Text.ToString & "', RESIM='NULL'  WHERE SERINO = '" & txt_serino.Text & "' ")

                                    If Not pictureBox1.Image Is Nothing Then
                                        LocalDB.SetImage("UPDATE STOK SET RESIM=@RESIM1 WHERE SERINO='" & txt_serino.Text & "'", "@RESIM1", pictureBox1.Image)
                                    End If

                                    grdStok.DataSource = LocalDB.PopulateGrid("SELECT * FROM STOK ORDER BY AD")

                                    MsgBox("Güncellendi !")

                                    temizle()
                                Else

                                    LocalDB.ExecuteNonQuery("INSERT INTO STOK VALUES ('" & txt_ad.Text & "','" & txt_model.Text & "','" & txt_serino.Text & "','" & txt_adet.Text & "','" & dt_tarih.Text & "','" & txt_kayit.Text & "','NULL') ")

                                    If Not pictureBox1.Image Is Nothing Then
                                        LocalDB.SetImage("UPDATE STOK SET RESIM=@RESIM1 WHERE SERINO='" & txt_serino.Text & "'", "@RESIM1", pictureBox1.Image)
                                    End If
                                    grdStok.DataSource = LocalDB.PopulateGrid("SELECT * FROM STOK ORDER BY AD")
                                    temizle()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If


    End Sub

    Private Sub txt_stokadiara_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_stokadiara.KeyPress

        Dim sqlStr As String


        sqlStr = "SELECT * FROM STOK  WHERE "


        If txt_stokadiara.Text.ToString <> String.Empty Then
            sqlStr += "AD = '" & txt_stokadiara.Text & "'"
        End If

        grdStok.DataSource = LocalDB.PopulateGrid(sqlStr)
        If grdStok.Rows.Count > 0 Then
            grdStok.Rows(0).Selected = False
        End If

    End Sub

End Class