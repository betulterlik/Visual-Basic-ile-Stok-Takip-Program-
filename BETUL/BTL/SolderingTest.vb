Public Class SolderingTest
    Private Sub SolderingTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (cmb_Electrodechange.Items.Count = 0) Then
            cmb_Electrodechange.Items.Add("Please Select")
            cmb_Electrodechange.Items.Add("left electrode")
            cmb_Electrodechange.Items.Add("left side change")
            cmb_Electrodechange.Items.Add("right electrode")
            cmb_Electrodechange.Items.Add("right side change")

            cmb_Electrodechange.SelectedIndex = 0
        End If


    End Sub

    Private Sub btn_hesapla_Click(sender As Object, e As EventArgs) Handles btn_hesapla.Click

        If txt_TotalCrossSection.Text <> String.Empty Or txt_TotalCrossSection.Text = "0" Then

            'TotalCrossSection Değeri Kablo Çapı
            Dim totalcross As Double = txt_TotalCrossSection.Text
            totalcross = totalcross / 2 'yarıçap
            totalcross = Math.PI * totalcross * totalcross 'çemberin alanı
            txt_TotalCrossSection.Text = totalcross


            If 0.5 <= totalcross And totalcross <= 1.0 Then

                lbl_ssr.Text = "%40 Oneri"

            ElseIf 1.1 <= totalcross And totalcross <= 5.0 Then

                lbl_ssr.Text = "%50 Oneri"

            ElseIf 5.1 <= totalcross And totalcross <= 10.0 Then

                lbl_ssr.Text = "%55 Oneri"

            ElseIf 10.1 <= totalcross And totalcross <= 16.0 Then

                lbl_ssr.Text = "%60 Oneri"

            ElseIf 16.1 <= totalcross And totalcross <= 25.0 Then

                lbl_ssr.Text = "%65 Oneri"

            ElseIf 25.1 <= totalcross And totalcross <= 40.0 Then

                lbl_ssr.Text = "%70 Oneri"

            ElseIf 40.1 <= totalcross And totalcross <= 40.0 Then

                lbl_ssr.Text = "%80 Oneri"

            End If


        End If

    End Sub
End Class