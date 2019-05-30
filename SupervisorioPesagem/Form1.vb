Public Class Form1
    Dim trama As String = ""

    Dim MAX_WEIGHT As Decimal = 25000.0

    Dim tara As Double = 0.0
    Dim targetWeight As Double = 0.0
    Dim readWeight As Double = 0.0
    Dim cargoWeight As Double = 0.0

    Dim truckAmount As Integer = 0
    Dim totalTara As Double = 0.0
    Dim totalWeight As Double = 0.0

    Dim truckOn As Boolean = False
    Dim loadReadyState As Boolean = False
    Dim loadingCargo As Boolean = False
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

    Private Sub MainTimer_Tick(sender As Object, e As EventArgs) Handles MainTimer.Tick
        If SerialCOM4.IsOpen Then
            SerialCOM4.Write("A")
            trama = SerialCOM4.ReadExisting()
            If trama.Length = 6 Then
                If trama.Split(",")(0) = 1 Then truckOn = True Else truckOn = False

                If loadingCargo = False Then
                    If truckOn Then
                        pbTruck.Image = My.Resources.CaminhaoON
                    Else
                        pbTruck.Image = My.Resources.CaminhaoOff
                    End If
                End If

                readWeight = trama.Split(",")(1) * 24.43792766

                    TramaBox.Text = trama
                End If
            Else
            TramaBox.Text = "Erro na trama"
        End If

        If loadingCargo Then StartLoading()
    End Sub

    Private Sub TmTara_Tick(sender As Object, e As EventArgs) Handles tmTara.Tick
        If tara = 0.0 Then
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
        If truckOn And tara = 0.0 Then
            tara = readWeight
            tbTara.Text = tara.ToString()
            nudPesoDesejado.Maximum = Decimal.Parse(MAX_WEIGHT - tara)
            nudPesoDesejado.Enabled = True
        Else
            TramaBox.Text = "Coloque o caminhão na balança"
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetState()

        truckAmount = 0
        totalTara = 0.0
        totalWeight = 0.0

        tbTruckAmount.Text = "0"
        tbTaraMean.Text = "0.0"
        tbTotalWeight.Text = "0.0"
        TbMeanWeight.Text = "0.0"
    End Sub

    Private Sub BTnCarr_Click(sender As Object, e As EventArgs) Handles btnCarr.Click
        If truckOn And tara > 0.0 Then
            targetWeight = Double.Parse(nudPesoDesejado.Value)
            If targetWeight > 0.0 Then
                DisableControls()
                loadingCargo = True
            Else
                TramaBox.Text = "Insira um peso objetivo"
            End If
        Else
            TramaBox.Text = "Tarar caminhão"
        End If
    End Sub

    Private Sub StartLoading()
        pbLedCarr.Image = My.Resources.LedVD
        pbSilo.Image = My.Resources.SinoOn
        If cargoWeight.CompareTo(targetWeight - 0.1) < 0 And loadingCargo Then
            DisableControls()
            cargoWeight = readWeight - tara
            tbPesoReal.Text = readWeight.ToString()
            If cargoWeight < 0 Then cargoWeight = 0
            tbPesoCarr.Text = cargoWeight.ToString()
        Else
            pbSilo.Image = My.Resources.SiloOff
            pbLedCarr.Image = My.Resources.LedVM
            pbLedLiberado.Image = My.Resources.LedVD
            loadReadyState = True
        End If

        If loadReadyState = True And truckOn = False Then
            loadingCargo = False
            EnableControls()
            CalculateStatistics()
            ResetState()
        End If
    End Sub

    Private Sub CalculateStatistics()
        truckAmount = truckAmount + 1
        totalTara = totalTara + tara
        totalWeight = totalWeight + cargoWeight

        Dim taraMean As Double = totalTara / truckAmount
        Dim weightMean As Double = totalWeight / truckAmount

        tbTruckAmount.Text = truckAmount.ToString()
        tbTaraMean.Text = FormatNumber(taraMean.ToString(), 2)
        tbTotalWeight.Text = FormatNumber(totalWeight.ToString(), 2)
        TbMeanWeight.Text = FormatNumber(weightMean.ToString(), 2)
    End Sub

    Private Sub DisableControls()
        btnCarr.Enabled = False
        btnTara.Enabled = False
        nudPesoDesejado.Enabled = False
    End Sub

    Private Sub EnableControls()
        btnCarr.Enabled = True
        btnTara.Enabled = True
        nudPesoDesejado.Enabled = True
    End Sub

    Private Sub ResetState()
        tara = 0.0
        targetWeight = 0.0
        readWeight = 0.0
        cargoWeight = 0.0

        EnableControls()

        truckOn = False
        loadingCargo = False
        loadReadyState = False
        taraLedState = "R"

        TramaBox.Text = ""

        tbTara.Text = "0.0"
        nudPesoDesejado.Value = 0
        tbPesoReal.Text = "0.0"
        tbPesoCarr.Text = "0.0"

        pbLedCarr.Image = My.Resources.LedVM
        pbSilo.Image = My.Resources.SiloOff
        pbLedLiberado.Image = My.Resources.LedVM
        pbTruck.Image = My.Resources.CaminhaoOff
    End Sub
End Class
