Public Class Form1
    Dim trama As String = ""

    Dim Weight As Double = 0.0
    Dim TotalWeight As Double = 0.0

    Dim TruckOn As Boolean = False
    Dim CarregandoLedState As Boolean = False
    Dim ReadyLedState As Boolean = False
    Dim taraLedState As Char = "R"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If Not SerialCOM4.IsOpen Then
                SerialCOM4.Open()
                Exit Sub
            End If
        Catch
            MsgBox("Problemas ao abrir a porta serial COM4. Verifique.", MsgBoxStyle.Critical, "Erro de Comunicação")
            End
        End Try
    End Sub

    Private Sub GetPICData()
        If SerialCOM4.IsOpen Then
            trama = SerialCOM4.ReadExisting()
            TruckOn = trama.Split(",")(0)
            Weight = trama.Split(",")(1)
        End If
    End Sub

    Private Sub TmTara_Tick(sender As Object, e As EventArgs) Handles tmTara.Tick
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

    Private Sub BTnTara_Click(sender As Object, e As EventArgs) Handles btnTara.Click
        If TruckOn And tbTara.Text = "" Then
            tbTara.Text = Weight.ToString()
        End If
    End Sub

    Private Sub BTnCarr_Click(sender As Object, e As EventArgs) Handles btnCarr.Click
        If TruckOn And tbTara.Text <> "" Then
            If tbPesoDesejado.Text <> "" Then
                DisableControls()
                pbLedCarr.Image = My.Resources.LedVD
                While TotalWeight < Double.Parse(tbPesoDesejado.Text)
                    GetPICData()
                    TotalWeight = Weight - Double.Parse(tbTara.Text)
                    If TotalWeight < 0 Then TotalWeight = 0
                    tbPesoReal.Text = TotalWeight.ToString
                End While
                pbLedCarr.Image = My.Resources.LedVM
                pbLedLiberado.Image = My.Resources.LedVD
                EnableControls()
            End If
        End If
    End Sub

    Private Sub DisableControls()
        btnCarr.Enabled = False
        btnTara.Enabled = False
        btnReset.Enabled = False
    End Sub

    Private Sub EnableControls()
        btnCarr.Enabled = True
        btnTara.Enabled = True
        btnReset.Enabled = True
    End Sub

    Private Sub ResetState()

    End Sub


End Class
