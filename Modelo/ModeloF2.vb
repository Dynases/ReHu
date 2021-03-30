
Public Class ModeloF2

#Region "METODOS PRIVADOS"
    Private Sub P_Moverenfoque()
        SendKeys.Send("{TAB}")
    End Sub
#End Region
#Region "EVENTOS"
    Private Sub ModeloF2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        e.KeyChar = e.KeyChar.ToString.ToUpper
        If (e.KeyChar = ChrW(Keys.Enter)) Then
            e.Handled = True
            P_Moverenfoque()
        End If
    End Sub

    Private Sub ModeloF2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
#End Region
End Class