Public Class Form1
    Dim basicn, dan, pfn, hran As Integer
    Dim ansd As Integer

    Private Sub calc_Click(sender As Object, e As EventArgs) Handles calc.Click
        basicn = Val(basic.Text)
        dan = Val(da.Text)
        pfn = Val(pf.Text)
        hran = Val(hra.Text)

        ansd = (basicn + (basicn * dan / 100) + (basicn * hran / 100) + (basicn * pfn / 100))
        ans.Text = ansd
    End Sub
End Class
