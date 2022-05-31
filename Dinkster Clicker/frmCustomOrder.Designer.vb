<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomOrder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomOrder))
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.lblControlTitle = New System.Windows.Forms.Label()
        Me.btnControlExit = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.comAmount = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.radSkimMilk = New System.Windows.Forms.RadioButton()
        Me.radCows = New System.Windows.Forms.RadioButton()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.lblTotalRPS = New System.Windows.Forms.Label()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnControlExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.PictureBox5.Image = Global.Dinkster_Clicker.My.Resources.Resources.dinklogo1
        Me.PictureBox5.Location = New System.Drawing.Point(5, 4)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(26, 21)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 16
        Me.PictureBox5.TabStop = False
        '
        'lblControlTitle
        '
        Me.lblControlTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.lblControlTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblControlTitle.Location = New System.Drawing.Point(40, 4)
        Me.lblControlTitle.Name = "lblControlTitle"
        Me.lblControlTitle.Size = New System.Drawing.Size(380, 23)
        Me.lblControlTitle.TabIndex = 15
        Me.lblControlTitle.Text = "High Noon Shipping Company"
        Me.lblControlTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnControlExit
        '
        Me.btnControlExit.BackColor = System.Drawing.Color.Transparent
        Me.btnControlExit.BackgroundImage = Global.Dinkster_Clicker.My.Resources.Resources.controlbox
        Me.btnControlExit.Image = Global.Dinkster_Clicker.My.Resources.Resources._exit
        Me.btnControlExit.Location = New System.Drawing.Point(426, 5)
        Me.btnControlExit.Name = "btnControlExit"
        Me.btnControlExit.Size = New System.Drawing.Size(16, 16)
        Me.btnControlExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnControlExit.TabIndex = 14
        Me.btnControlExit.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImage = Global.Dinkster_Clicker.My.Resources.Resources.controlbox
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Image = Global.Dinkster_Clicker.My.Resources.Resources.controlbox
        Me.PictureBox4.Location = New System.Drawing.Point(-8, 238)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(467, 32)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 13
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Dinkster_Clicker.My.Resources.Resources.controlbox
        Me.PictureBox3.Location = New System.Drawing.Point(-9, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(18, 291)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 12
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Dinkster_Clicker.My.Resources.Resources.controlbox
        Me.PictureBox2.Location = New System.Drawing.Point(441, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(18, 291)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Dinkster_Clicker.My.Resources.Resources.controlbox
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.Dinkster_Clicker.My.Resources.Resources.controlbox
        Me.PictureBox1.Location = New System.Drawing.Point(-9, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(468, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'comAmount
        '
        Me.comAmount.FormatString = "N0"
        Me.comAmount.FormattingEnabled = True
        Me.comAmount.Items.AddRange(New Object() {"250", "500", "750", "1,000", "5,000", "10,000", "50,000", "100,000", "500,000", "1,000,000", "5,000,000", "10,000,000", "50,000,000", "100,000,000"})
        Me.comAmount.Location = New System.Drawing.Point(24, 160)
        Me.comAmount.Name = "comAmount"
        Me.comAmount.Size = New System.Drawing.Size(144, 21)
        Me.comAmount.TabIndex = 17
        Me.comAmount.Text = "1,000"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(15, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(420, 57)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = resources.GetString("Label1.Text")
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.Dinkster_Clicker.My.Resources.Resources.High_Noon_Shipping_Button
        Me.PictureBox6.Location = New System.Drawing.Point(33, 38)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(382, 52)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox6.TabIndex = 19
        Me.PictureBox6.TabStop = False
        '
        'lblTotalCost
        '
        Me.lblTotalCost.Location = New System.Drawing.Point(174, 159)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(150, 21)
        Me.lblTotalCost.TabIndex = 20
        Me.lblTotalCost.Text = "Total Cost: "
        Me.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnOrder
        '
        Me.btnOrder.Location = New System.Drawing.Point(177, 204)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(147, 23)
        Me.btnOrder.TabIndex = 21
        Me.btnOrder.Text = "Place Yer Order"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'radSkimMilk
        '
        Me.radSkimMilk.AutoSize = True
        Me.radSkimMilk.Checked = True
        Me.radSkimMilk.Location = New System.Drawing.Point(24, 200)
        Me.radSkimMilk.Name = "radSkimMilk"
        Me.radSkimMilk.Size = New System.Drawing.Size(70, 17)
        Me.radSkimMilk.TabIndex = 22
        Me.radSkimMilk.TabStop = True
        Me.radSkimMilk.Text = "Skim Milk"
        Me.radSkimMilk.UseVisualStyleBackColor = True
        '
        'radCows
        '
        Me.radCows.AutoSize = True
        Me.radCows.Location = New System.Drawing.Point(117, 200)
        Me.radCows.Name = "radCows"
        Me.radCows.Size = New System.Drawing.Size(51, 17)
        Me.radCows.TabIndex = 23
        Me.radCows.Text = "Cows"
        Me.radCows.UseVisualStyleBackColor = True
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.Dinkster_Clicker.My.Resources.Resources.dink
        Me.PictureBox7.Location = New System.Drawing.Point(330, 164)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(105, 68)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 24
        Me.PictureBox7.TabStop = False
        '
        'lblTotalRPS
        '
        Me.lblTotalRPS.Location = New System.Drawing.Point(174, 180)
        Me.lblTotalRPS.Name = "lblTotalRPS"
        Me.lblTotalRPS.Size = New System.Drawing.Size(150, 21)
        Me.lblTotalRPS.TabIndex = 25
        Me.lblTotalRPS.Text = "Total RPS: "
        Me.lblTotalRPS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmCustomOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 247)
        Me.Controls.Add(Me.lblTotalRPS)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.radCows)
        Me.Controls.Add(Me.radSkimMilk)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.comAmount)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.lblControlTitle)
        Me.Controls.Add(Me.btnControlExit)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCustomOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "High Noon Shipping Company"
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnControlExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents lblControlTitle As Label
    Friend WithEvents btnControlExit As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents comAmount As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents btnOrder As Button
    Friend WithEvents radSkimMilk As RadioButton
    Friend WithEvents radCows As RadioButton
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents lblTotalRPS As Label
End Class
