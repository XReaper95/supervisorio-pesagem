<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbPesoDesejado = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pbLedLiberado = New System.Windows.Forms.PictureBox()
        Me.SerialCOM4 = New System.IO.Ports.SerialPort(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.pbTruck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSilo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLedTara, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLedCarr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbControleis.SuspendLayout()
        CType(Me.pbLedLiberado, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pbLedTara.Image = Global.SupervisorioPesagem.My.Resources.Resources.PilotoVM
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
        Me.pbLedCarr.Image = Global.SupervisorioPesagem.My.Resources.Resources.PilotoVM
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
        Me.gbControleis.Controls.Add(Me.Label12)
        Me.gbControleis.Controls.Add(Me.Label11)
        Me.gbControleis.Controls.Add(Me.Label9)
        Me.gbControleis.Controls.Add(Me.Label8)
        Me.gbControleis.Controls.Add(Me.btnReset)
        Me.gbControleis.Controls.Add(Me.Label7)
        Me.gbControleis.Controls.Add(Me.tbPesoDesejado)
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
        'tbPesoDesejado
        '
        Me.tbPesoDesejado.Location = New System.Drawing.Point(255, 72)
        Me.tbPesoDesejado.Name = "tbPesoDesejado"
        Me.tbPesoDesejado.Size = New System.Drawing.Size(123, 20)
        Me.tbPesoDesejado.TabIndex = 15
        Me.tbPesoDesejado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.pbLedLiberado.Image = Global.SupervisorioPesagem.My.Resources.Resources.PilotoVM
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
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Stencil", 24.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(357, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(360, 39)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Balança Eletrônica"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 406)
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
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pbTruck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSilo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLedTara, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLedCarr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbControleis.ResumeLayout(False)
        Me.gbControleis.PerformLayout()
        CType(Me.pbLedLiberado, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents tbPesoDesejado As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents pbLedLiberado As PictureBox
    Friend WithEvents btnReset As Button
    Friend WithEvents SerialCOM4 As IO.Ports.SerialPort
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
End Class
