
Imports System.Data.SqlTypes
Imports System.IO
Imports Microsoft.Office.Interop

Public Class Form1
    Public LocalDB As New SQLiteTools("C:\bold\Betül TERLİK\Source\Repos\Personel\Personel.db", True)
    Dim rs As New Resizer

    Dim Virtual As String(,) = Nothing
    Dim fileName As String = "\Personel.csv"


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        rs.FindAllControls(Me)


        Me.Text += " " & String.Format(" {0}", My.Application.Info.Version.ToString)
        grd_personel.DataSource = LocalDB.PopulateGrid("select * from Personel order by AdSoyad")

        If grd_personel.Rows.Count > 0 Then
            grd_personel.Rows(0).Selected = False
        End If

        txt_adsoyad.Select()


        If (cmb_cinsiyet.Items.Count = 0) Then
            cmb_cinsiyet.Items.Add("Seçiniz")
            cmb_cinsiyet.Items.Add("Bay")
            cmb_cinsiyet.Items.Add("Bayan")
            cmb_cinsiyet.SelectedIndex = 0
        End If
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub

    Private Sub grd_personel_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_personel.CellContentClick

        txt_adsoyad.Text = grd_personel.Item("AdSoyad", grd_personel.CurrentRow.Index).Value.ToString()
        txt_meslek.Text = grd_personel.Item("Meslek", grd_personel.CurrentRow.Index).Value.ToString()
        txt_dogumyeri.Text = grd_personel.Item("DogumYeri", grd_personel.CurrentRow.Index).Value.ToString()
        cmb_cinsiyet.SelectedItem = grd_personel.Item("Cinsiyet", grd_personel.CurrentRow.Index).Value.ToString()
    End Sub

    Private Sub btn_ekle_Click(sender As Object, e As EventArgs) Handles btn_ekle.Click

        If txt_adsoyad.Text <> String.Empty Then
            If txt_dogumyeri.Text <> String.Empty Then
                If cmb_cinsiyet.SelectedIndex <> 0 Then
                    If txt_meslek.Text <> String.Empty Then

                        LocalDB.ExecuteNonQuery("INSERT INTO Personel VALUES ('" & txt_adsoyad.Text & "','" & txt_dogumyeri.Text & "','" & cmb_cinsiyet.SelectedItem.ToString() & "','" & txt_meslek.Text & "') ")
                        grd_personel.DataSource = LocalDB.PopulateGrid("SELECT * FROM Personel ")

                        MsgBox("Eklendi !")


                    Else
                        MsgBox("Meslek ekleyiniz")
                        ' txt_meslek.Focus()
                    End If
                Else
                    MsgBox("Cinsiyet ekleyiniz")
                    '  txt_cinsiyet.Focus()
                End If
            Else
                MsgBox("Doğum Yeri ekleyiniz")
                ' txt_dogumyeri.Focus()
            End If
        Else
            MsgBox("Ad Soyad ekleyiniz")
            txt_adsoyad.Focus()
        End If

        temizle()


    End Sub

    Private Sub btn_guncelle_Click(sender As Object, e As EventArgs) Handles btn_guncelle.Click

        If txt_adsoyad.Text <> String.Empty Then
            If txt_dogumyeri.Text <> String.Empty Then
                If cmb_cinsiyet.SelectedIndex <> 0 Then

                    If Not LocalDB.isThere("Select * from Personel where Cinsiyet = '" & cmb_cinsiyet.SelectedItem.ToString & "' ") Then

                        LocalDB.ExecuteNonQuery("UPDATE Personel SET DogumYeri='" & txt_dogumyeri.Text.ToString & "', Cinsiyet='" & cmb_cinsiyet.SelectedItem.ToString & "', Meslek='" & txt_meslek.Text.ToString & "' where  AdSoyad = '" & txt_adsoyad.Text & "' ")

                        grd_personel.DataSource = LocalDB.PopulateGrid("SELECT * FROM Personel order by AdSoyad")

                        MsgBox("Güncellendi !")

                        temizle()
                    Else

                        LocalDB.ExecuteNonQuery("INSERT INTO Personel VALUES ('" & txt_adsoyad.Text & "','" & txt_dogumyeri.Text & "','" & cmb_cinsiyet.SelectedItem.ToString() & "','" & txt_meslek.Text & "') ")
                        grd_personel.DataSource = LocalDB.PopulateGrid("SELECT * FROM Personel order by AdSoyad")
                    End If

                End If
            End If
        End If
    End Sub

    Private Sub btn_sil_Click(sender As Object, e As EventArgs) Handles btn_sil.Click
        If (txt_adsoyad.Text <> String.Empty) Then
            If MsgBox(("Silmek istiyormusunuz"), MsgBoxStyle.YesNo) = Windows.Forms.DialogResult.Yes Then


                LocalDB.ExecuteNonQuery("DELETE FROM Personel WHERE ( AdSoyad='" & txt_adsoyad.Text.ToString & "') AND (DogumYeri='" & txt_dogumyeri.Text.ToString & "' ) ")

                grd_personel.DataSource = LocalDB.PopulateGrid("SELECT * FROM Personel order by AdSoyad")
                MsgBox("Silindi !")

                temizle()

            End If
        End If
    End Sub

    Private Sub btn_ara_Click(sender As Object, e As EventArgs) Handles btn_ara.Click

        'SELECT*FROM Personel P 
        'WHERE P.AdSoyad='d' AND 
        'P.Cinsiyet='Bayan' 
        'AND P.Meslek='a' 
        'AND P.DogumYeri='d'

        Dim sqlStr As String

        sqlStr = "select *  from [Personel]  WHERE "


        If txt_adsoyad.Text.ToString <> String.Empty Then
            sqlStr += "AdSoyad = '" & txt_adsoyad.Text & "' AND "
        End If

        If txt_dogumyeri.Text.ToString <> String.Empty Then
            sqlStr += "DogumYeri = '" & txt_dogumyeri.Text.ToString & "' AND "
        End If

        If cmb_cinsiyet.SelectedIndex <> 0 Then
            sqlStr += "Cinsiyet = '" & cmb_cinsiyet.SelectedItem.ToString() & "' AND "
        End If

        If txt_meslek.Text.ToString <> String.Empty Then
            sqlStr += "Meslek = '" & txt_meslek.Text.ToString & "'"
        End If

        If sqlStr.EndsWith("AND ") Then
            sqlStr = sqlStr.Substring(0, sqlStr.Length - 4)
        End If


        grd_personel.DataSource = LocalDB.PopulateGrid(sqlStr)
        If grd_personel.Rows.Count > 0 Then
            grd_personel.Rows(0).Selected = False
        End If

    End Sub

    Public Sub temizle()
        txt_adsoyad.Text = String.Empty
        txt_dogumyeri.Text = String.Empty
        txt_meslek.Text = String.Empty
        cmb_cinsiyet.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        temizle()
        grd_personel.DataSource = LocalDB.PopulateGrid("SELECT * FROM Personel ")
    End Sub

    Private Sub btn_Cancel_Login_Click(sender As Object, e As EventArgs)
        LoginPage.Activate()
        LoginPage.Show()
        Me.Close()
    End Sub

    Private Sub btn_excel_Click(sender As Object, e As EventArgs) Handles btn_excel.Click

        If RadBtn_xlsx.Checked Then

            Dim xlApp As Excel.Application
            Dim xlWorkBook As Excel.Workbook
            Dim xlWorkSheet As Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value
            Dim i As Integer
            Dim j As Integer

            SFD.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm"
            SFD.FilterIndex = 3
            SFD.FileName = String.Empty
            SFD.InitialDirectory = Path.Combine(Path.GetDirectoryName(Environment.GetFolderPath(Environment.SpecialFolder.Personal)), "Documents")

            If SFD.ShowDialog(Me) = DialogResult.OK Then

                xlApp = New Excel.Application
                xlWorkBook = xlApp.Workbooks.Add()
                xlWorkSheet = CType(xlWorkBook.Worksheets.Add(), Excel.Worksheet)

                xlWorkSheet.Name = "Personel"
                xlWorkSheet.Cells(1, 1) = "AdSoyad"
                xlWorkSheet.Cells(1, 2) = "DogumYeri"
                xlWorkSheet.Cells(1, 3) = "Cinsiyet"
                xlWorkSheet.Cells(1, 4) = "Meslek"

                For i = 0 To grd_personel.RowCount - 1
                    For j = 0 To grd_personel.ColumnCount - 1
                        xlWorkSheet.Cells(i + 2, j + 1) = grd_personel(j, i).Value.ToString()
                    Next
                Next
               

                xlWorkSheet.SaveAs(SFD.FileName)
                xlWorkBook.Close()
                xlApp.Quit()

                releaseObject(xlApp)
                releaseObject(xlWorkBook)
                releaseObject(xlWorkSheet)


                MsgBox("Excel file is saved.")
            End If

        End If

        If RadBtn_csv.Checked Then

            Dim csvFile As String = String.Empty

            SFD.Title = "Save .csv File" 'Başlık
            SFD.Filter = "Excel Files|*.csv" '.csv uzantılı dosya fitrelenir.
            SFD.FilterIndex = 1 '.csv bir tane tür seçildiğinden index 1 olur.
            SFD.FileName = "Name not important.csv"
            SFD.InitialDirectory = Path.Combine(Path.GetDirectoryName(Environment.GetFolderPath(Environment.SpecialFolder.Personal)), "Documents") 'dosya açma dialoğunun başlangıç dizini ayarlanabilir
            SFD.FileName = String.Empty

            If SFD.ShowDialog(Me) = DialogResult.OK Then


                ReDim Virtual(grd_personel.Rows.Count, 3)
                Virtual(0, 0) = "AdSoyad"
                Virtual(0, 1) = "DogumYeri"
                Virtual(0, 2) = "Cinsiyet"
                Virtual(0, 3) = "Meslek"

                For i = 0 To grd_personel.Rows.Count - 1 'Sutünları doldurma. Sırası: 
                    For j = 0 To grd_personel.Columns.Count - 1
                        Virtual(i + 1, j) = grd_personel.Item(j, i).Value.ToString()
                    Next
                Next

                For i = 0 To Virtual.GetLength(0) - 1 'GetLenght: Dizi uzunluğu
                    For j = 0 To Virtual.GetLength(1) - 1
                        csvFile = csvFile & Virtual(i, j).ToString() & ";"
                    Next
                    csvFile = csvFile.TrimEnd(";")
                    csvFile = csvFile & vbCr & vbLf

                Next
                System.IO.File.WriteAllText(SFD.FileName, csvFile)
                csvFile = String.Empty

                MsgBox("CSV file is saved.")
            End If
        End If

    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

End Class
