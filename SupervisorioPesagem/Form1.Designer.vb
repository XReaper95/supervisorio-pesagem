﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pbTruck = New System.Windows.Forms.PictureBox()
        Me.pbSilo = New System.Windows.Forms.PictureBox()
        Me.pbLedTara = New System.Windows.Forms.PictureBox()
        Me.btnTara = New System.Windows.Forms.Button()
        Me.pbLedCarr = New System.Windows.Forms.PictureBox()
        Me.btnCarr = New System.Windows.Forms.Button()
        Me.tbTara = New System.Windows.Forms.TextBox()
        Me.tbPesoCarr = New System.Windows.Forms.TextBox()
        Me.tbPesoReal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gbControleis = New System.Windows.Forms.GroupBox()
        Me.nudPesoDesejado = New System.Windows.Forms.NumericUpDown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pbLedLiberado = New System.Windows.Forms.PictureBox()
        Me.SerialCOM4 = New System.IO.Ports.SerialPort(Me.components)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tmTara = New System.Windows.Forms.Timer(Me.components)
        Me.MainTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TramaBox = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.gbEstatisticas = New System.Windows.Forms.GroupBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TbMeanWeight = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tbTotalWeight = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tbTaraMean = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tbTruckAmount = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        CType(Me.pbTruck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSilo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLedTara, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLedCarr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbControleis.SuspendLayout()
        CType(Me.nudPesoDesejado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLedLiberado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbEstatisticas.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbTruck
        '
        Me.pbTruck.Image = Global.SupervisorioPesagem.My.Resources.Resources.CaminhaoOff
        Me.pbTruck.Location = New System.Drawing.Point(13, 270)
        Me.pbTruck.Name = "pbTruck"
        Me.pbTruck.Size = New System.Drawing.Size(304, 109)
        Me.pbTruck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbTruck.TabIndex = 0
        Me.pbTruck.TabStop = False
        '
        'pbSilo
        '
        Me.pbSilo.Image = Global.SupervisorioPesagem.My.Resources.Resources.SiloOff
        Me.pbSilo.Location = New System.Drawing.Point(105, 101)
        Me.pbSilo.Name = "pbSilo"
        Me.pbSilo.Size = New System.Drawing.Size(100, 151)
        Me.pbSilo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSilo.TabIndex = 1
        Me.pbSilo.TabStop = False
        '
        'pbLedTara
        '
        Me.pbLedTara.Image = Global.SupervisorioPesagem.My.Resources.Resources.LedVM
        Me.pbLedTara.Location = New System.Drawing.Point(13, 32)
        Me.pbLedTara.Name = "pbLedTara"
        Me.pbLedTara.Size = New System.Drawing.Size(57, 52)
        Me.pbLedTara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLedTara.TabIndex = 2
        Me.pbLedTara.TabStop = False
        '
        'btnTara
        '
        Me.btnTara.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTara.Location = New System.Drawing.Point(31, 18)
        Me.btnTara.Name = "btnTara"
        Me.btnTara.Size = New System.Drawing.Size(123, 51)
        Me.btnTara.TabIndex = 4
        Me.btnTara.Text = "Tarar"
        Me.btnTara.UseVisualStyleBackColor = True
        '
        'pbLedCarr
        '
        Me.pbLedCarr.Image = Global.SupervisorioPesagem.My.Resources.Resources.LedVM
        Me.pbLedCarr.Location = New System.Drawing.Point(126, 32)
        Me.pbLedCarr.Name = "pbLedCarr"
        Me.pbLedCarr.Size = New System.Drawing.Size(57, 52)
        Me.pbLedCarr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLedCarr.TabIndex = 5
        Me.pbLedCarr.TabStop = False
        '
        'btnCarr
        '
        Me.btnCarr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCarr.Location = New System.Drawing.Point(255, 19)
        Me.btnCarr.Name = "btnCarr"
        Me.btnCarr.Size = New System.Drawing.Size(123, 51)
        Me.btnCarr.TabIndex = 6
        Me.btnCarr.Text = "Carregar"
        Me.btnCarr.UseVisualStyleBackColor = True
        '
        'tbTara
        '
        Me.tbTara.BackColor = System.Drawing.SystemColors.Window
        Me.tbTara.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tbTara.Location = New System.Drawing.Point(31, 72)
        Me.tbTara.Name = "tbTara"
        Me.tbTara.ReadOnly = True
        Me.tbTara.Size = New System.Drawing.Size(123, 20)
        Me.tbTara.TabIndex = 7
        Me.tbTara.Text = "0.0"
        Me.tbTara.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbPesoCarr
        '
        Me.tbPesoCarr.BackColor = System.Drawing.SystemColors.Window
        Me.tbPesoCarr.Location = New System.Drawing.Point(184, 167)
        Me.tbPesoCarr.Name = "tbPesoCarr"
        Me.tbPesoCarr.ReadOnly = True
        Me.tbPesoCarr.Size = New System.Drawing.Size(135, 20)
        Me.tbPesoCarr.TabIndex = 8
        Me.tbPesoCarr.Text = "0.0"
        Me.tbPesoCarr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbPesoReal
        '
        Me.tbPesoReal.BackColor = System.Drawing.SystemColors.Window
        Me.tbPesoReal.Location = New System.Drawing.Point(184, 139)
        Me.tbPesoReal.Name = "tbPesoReal"
        Me.tbPesoReal.ReadOnly = True
        Me.tbPesoReal.Size = New System.Drawing.Size(135, 20)
        Me.tbPesoReal.TabIndex = 9
        Me.tbPesoReal.Text = "0.0"
        Me.tbPesoReal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Tara"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(112, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Carregando"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(101, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Peso real"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(74, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Tara"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 17)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Peso Carregamento"
        '
        'gbControleis
        '
        Me.gbControleis.Controls.Add(Me.nudPesoDesejado)
        Me.gbControleis.Controls.Add(Me.Label12)
        Me.gbControleis.Controls.Add(Me.Label11)
        Me.gbControleis.Controls.Add(Me.Label9)
        Me.gbControleis.Controls.Add(Me.Label8)
        Me.gbControleis.Controls.Add(Me.btnReset)
        Me.gbControleis.Controls.Add(Me.Label7)
        Me.gbControleis.Controls.Add(Me.btnTara)
        Me.gbControleis.Controls.Add(Me.Label5)
        Me.gbControleis.Controls.Add(Me.btnCarr)
        Me.gbControleis.Controls.Add(Me.Label4)
        Me.gbControleis.Controls.Add(Me.tbTara)
        Me.gbControleis.Controls.Add(Me.Label3)
        Me.gbControleis.Controls.Add(Me.tbPesoCarr)
        Me.gbControleis.Controls.Add(Me.tbPesoReal)
        Me.gbControleis.Location = New System.Drawing.Point(333, 82)
        Me.gbControleis.Name = "gbControleis"
        Me.gbControleis.Size = New System.Drawing.Size(414, 282)
        Me.gbControleis.TabIndex = 15
        Me.gbControleis.TabStop = False
        Me.gbControleis.Text = "Painel de controle"
        '
        'nudPesoDesejado
        '
        Me.nudPesoDesejado.DecimalPlaces = 1
        Me.nudPesoDesejado.Increment = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudPesoDesejado.Location = New System.Drawing.Point(258, 76)
        Me.nudPesoDesejado.Maximum = New Decimal(New Integer() {25000, 0, 0, 0})
        Me.nudPesoDesejado.Name = "nudPesoDesejado"
        Me.nudPesoDesejado.ReadOnly = True
        Me.nudPesoDesejado.Size = New System.Drawing.Size(120, 20)
        Me.nudPesoDesejado.TabIndex = 22
        Me.nudPesoDesejado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(325, 170)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(25, 17)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Kg"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(325, 142)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(25, 17)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Kg"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(383, 75)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(25, 17)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Kg"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(160, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 17)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Kg"
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(147, 225)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(123, 51)
        Me.btnReset.TabIndex = 15
        Me.btnReset.Text = "Reiniciar"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(265, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 17)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Peso Desejado"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(237, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 17)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Liberado"
        '
        'pbLedLiberado
        '
        Me.pbLedLiberado.Image = Global.SupervisorioPesagem.My.Resources.Resources.LedVM
        Me.pbLedLiberado.Location = New System.Drawing.Point(240, 32)
        Me.pbLedLiberado.Name = "pbLedLiberado"
        Me.pbLedLiberado.Size = New System.Drawing.Size(57, 52)
        Me.pbLedLiberado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLedLiberado.TabIndex = 16
        Me.pbLedLiberado.TabStop = False
        '
        'SerialCOM4
        '
        Me.SerialCOM4.PortName = "COM4"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Stencil", 42.0!, System.Drawing.FontStyle.Italic)
        Me.Label10.Location = New System.Drawing.Point(344, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(618, 67)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Balança Eletrônica"
        '
        'tmTara
        '
        Me.tmTara.Enabled = True
        Me.tmTara.Interval = 650
        '
        'MainTimer
        '
        Me.MainTimer.Enabled = True
        '
        'TramaBox
        '
        Me.TramaBox.BackColor = System.Drawing.SystemColors.Window
        Me.TramaBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TramaBox.Location = New System.Drawing.Point(410, 374)
        Me.TramaBox.Name = "TramaBox"
        Me.TramaBox.ReadOnly = True
        Me.TramaBox.Size = New System.Drawing.Size(287, 20)
        Me.TramaBox.TabIndex = 19
        Me.TramaBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(353, 374)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 17)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Trama"
        '
        'gbEstatisticas
        '
        Me.gbEstatisticas.Controls.Add(Me.Label21)
        Me.gbEstatisticas.Controls.Add(Me.TbMeanWeight)
        Me.gbEstatisticas.Controls.Add(Me.Label20)
        Me.gbEstatisticas.Controls.Add(Me.tbTotalWeight)
        Me.gbEstatisticas.Controls.Add(Me.Label19)
        Me.gbEstatisticas.Controls.Add(Me.tbTaraMean)
        Me.gbEstatisticas.Controls.Add(Me.Label18)
        Me.gbEstatisticas.Controls.Add(Me.tbTruckAmount)
        Me.gbEstatisticas.Controls.Add(Me.Label17)
        Me.gbEstatisticas.Controls.Add(Me.Label16)
        Me.gbEstatisticas.Controls.Add(Me.Label15)
        Me.gbEstatisticas.Controls.Add(Me.Label14)
        Me.gbEstatisticas.Location = New System.Drawing.Point(775, 82)
        Me.gbEstatisticas.Name = "gbEstatisticas"
        Me.gbEstatisticas.Size = New System.Drawing.Size(196, 282)
        Me.gbEstatisticas.TabIndex = 22
        Me.gbEstatisticas.TabStop = False
        Me.gbEstatisticas.Text = "Estatísticas"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(150, 240)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(25, 17)
        Me.Label21.TabIndex = 26
        Me.Label21.Text = "Kg"
        '
        'TbMeanWeight
        '
        Me.TbMeanWeight.Location = New System.Drawing.Point(43, 240)
        Me.TbMeanWeight.Name = "TbMeanWeight"
        Me.TbMeanWeight.ReadOnly = True
        Me.TbMeanWeight.Size = New System.Drawing.Size(101, 20)
        Me.TbMeanWeight.TabIndex = 25
        Me.TbMeanWeight.Text = "0.0"
        Me.TbMeanWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(150, 173)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(25, 17)
        Me.Label20.TabIndex = 24
        Me.Label20.Text = "Kg"
        '
        'tbTotalWeight
        '
        Me.tbTotalWeight.Location = New System.Drawing.Point(43, 173)
        Me.tbTotalWeight.Name = "tbTotalWeight"
        Me.tbTotalWeight.ReadOnly = True
        Me.tbTotalWeight.Size = New System.Drawing.Size(101, 20)
        Me.tbTotalWeight.TabIndex = 23
        Me.tbTotalWeight.Text = "0.0"
        Me.tbTotalWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(150, 115)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(25, 17)
        Me.Label19.TabIndex = 22
        Me.Label19.Text = "Kg"
        '
        'tbTaraMean
        '
        Me.tbTaraMean.Location = New System.Drawing.Point(43, 112)
        Me.tbTaraMean.Name = "tbTaraMean"
        Me.tbTaraMean.ReadOnly = True
        Me.tbTaraMean.Size = New System.Drawing.Size(101, 20)
        Me.tbTaraMean.TabIndex = 21
        Me.tbTaraMean.Text = "0.0"
        Me.tbTaraMean.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(150, 50)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(26, 17)
        Me.Label18.TabIndex = 20
        Me.Label18.Text = "Un"
        '
        'tbTruckAmount
        '
        Me.tbTruckAmount.Location = New System.Drawing.Point(43, 49)
        Me.tbTruckAmount.Name = "tbTruckAmount"
        Me.tbTruckAmount.ReadOnly = True
        Me.tbTruckAmount.Size = New System.Drawing.Size(101, 20)
        Me.tbTruckAmount.TabIndex = 19
        Me.tbTruckAmount.Text = "0"
        Me.tbTruckAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(16, 221)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(171, 17)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "Peso médio carregado"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(16, 153)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(150, 17)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Peso total de grãos"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(26, 86)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(145, 17)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Peso meio da Tara"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(21, 29)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(164, 17)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Quant. de Caminhões"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 406)
        Me.Controls.Add(Me.gbEstatisticas)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TramaBox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.pbLedLiberado)
        Me.Controls.Add(Me.gbControleis)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbLedCarr)
        Me.Controls.Add(Me.pbLedTara)
        Me.Controls.Add(Me.pbSilo)
        Me.Controls.Add(Me.pbTruck)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pbTruck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSilo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLedTara, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLedCarr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbControleis.ResumeLayout(False)
        Me.gbControleis.PerformLayout()
        CType(Me.nudPesoDesejado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLedLiberado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbEstatisticas.ResumeLayout(False)
        Me.gbEstatisticas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbTruck As PictureBox
    Friend WithEvents pbSilo As PictureBox
    Friend WithEvents pbLedTara As PictureBox
    Friend WithEvents btnTara As Button
    Friend WithEvents pbLedCarr As PictureBox
    Friend WithEvents btnCarr As Button
    Friend WithEvents tbTara As TextBox
    Friend WithEvents tbPesoCarr As TextBox
    Friend WithEvents tbPesoReal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents gbControleis As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents pbLedLiberado As PictureBox
    Friend WithEvents btnReset As Button
    Friend WithEvents SerialCOM4 As IO.Ports.SerialPort
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents tmTara As Timer
    Friend WithEvents MainTimer As Timer
    Friend WithEvents TramaBox As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents gbEstatisticas As GroupBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents TbMeanWeight As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents tbTotalWeight As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents tbTaraMean As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents tbTruckAmount As TextBox
    Friend WithEvents nudPesoDesejado As NumericUpDown
End Class
