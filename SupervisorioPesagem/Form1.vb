Public Class Form1
    Dim taraLedState As Char = "R"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try
        '    If Not SerialCOM4.IsOpen Then
        '        SerialCOM4.Open()
        '        Exit Sub
        '    End If
        'Catch
        '    MsgBox("Problemas ao abrir a porta serial COM4. Verifique.", MsgBoxStyle.Critical, "Erro de Comunicação")
        '    End
        'End Try
    End Sub

    Private Sub tmTara_Tick(sender As Object, e As EventArgs) Handles tmTara.Tick
        If tbTara.Text = "" Then
            If taraLedState = "R" Then
                pbLedTara.Image = My.Resources.LedAM
                taraLedState = "Y"
            Else
                pbLedTara.Image = My.Resources.LedVM
                taraLedState = "R"
            End If
        Else
            pbLedTara.Image = My.Resources.LedVD
            taraLedState = "G"
        End If
    End Sub
End Class
