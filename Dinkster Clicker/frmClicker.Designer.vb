<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmClicker
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClicker))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNumDinksters = New System.Windows.Forms.Label()
        Me.btnSupplies = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblDPS = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BgwAddDinks = New System.ComponentModel.BackgroundWorker()
        Me.btnCheats = New System.Windows.Forms.Button()
        Me.btnDink = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblComplete = New System.Windows.Forms.Label()
        Me.TimeKeeper = New System.ComponentModel.BackgroundWorker()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.lblControlTitle = New System.Windows.Forms.Label()
        Me.btnControlMinimize = New System.Windows.Forms.PictureBox()
        Me.btnControlExit = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnShowValues = New System.Windows.Forms.Button()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnControlMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnControlExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(30, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 63)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Did Somebody Ring The Dinkster"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 263)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Number of Rings: "
        '
        'lblNumDinksters
        '
        Me.lblNumDinksters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNumDinksters.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumDinksters.Location = New System.Drawing.Point(126, 257)
        Me.lblNumDinksters.Name = "lblNumDinksters"
        Me.lblNumDinksters.Size = New System.Drawing.Size(145, 23)
        Me.lblNumDinksters.TabIndex = 5
        Me.lblNumDinksters.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSupplies
        '
        Me.btnSupplies.Location = New System.Drawing.Point(12, 330)
        Me.btnSupplies.Name = "btnSupplies"
        Me.btnSupplies.Size = New System.Drawing.Size(75, 23)
        Me.btnSupplies.TabIndex = 1
        Me.btnSupplies.Text = "Store..."
        Me.btnSupplies.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(196, 330)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblDPS
        '
        Me.lblDPS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDPS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDPS.Location = New System.Drawing.Point(158, 225)
        Me.lblDPS.Name = "lblDPS"
        Me.lblDPS.Size = New System.Drawing.Size(113, 23)
        Me.lblDPS.TabIndex = 4
        Me.lblDPS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Rings Per Second (RPS)"
        '
        'BgwAddDinks
        '
        '
        'btnCheats
        '
        Me.btnCheats.Location = New System.Drawing.Point(105, 330)
        Me.btnCheats.Name = "btnCheats"
        Me.btnCheats.Size = New System.Drawing.Size(75, 23)
        Me.btnCheats.TabIndex = 2
        Me.btnCheats.Text = "Cheats..."
        Me.btnCheats.UseVisualStyleBackColor = True
        '
        'btnDink
        '
        Me.btnDink.BackgroundImage = Global.Dinkster_Clicker.My.Resources.Resources.dink
        Me.btnDink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDink.Location = New System.Drawing.Point(58, 94)
        Me.btnDink.Name = "btnDink"
        Me.btnDink.Size = New System.Drawing.Size(168, 128)
        Me.btnDink.TabIndex = 0
        Me.btnDink.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 302)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Percentage Complete:"
        '
        'lblComplete
        '
        Me.lblComplete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblComplete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComplete.Location = New System.Drawing.Point(158, 292)
        Me.lblComplete.Name = "lblComplete"
        Me.lblComplete.Size = New System.Drawing.Size(113, 23)
        Me.lblComplete.TabIndex = 10
        Me.lblComplete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimeKeeper
        '
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.PictureBox5.Image = Global.Dinkster_Clicker.My.Resources.Resources.dinklogo1
        Me.PictureBox5.Location = New System.Drawing.Point(3, 2)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(26, 21)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 18
        Me.PictureBox5.TabStop = False
        '
        'lblControlTitle
        '
        Me.lblControlTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.lblControlTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblControlTitle.Location = New System.Drawing.Point(36, -1)
        Me.lblControlTitle.Name = "lblControlTitle"
        Me.lblControlTitle.Size = New System.Drawing.Size(206, 23)
        Me.lblControlTitle.TabIndex = 17
        Me.lblControlTitle.Text = "Dinkster Clicker"
        Me.lblControlTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnControlMinimize
        '
        Me.btnControlMinimize.BackColor = System.Drawing.Color.Transparent
        Me.btnControlMinimize.BackgroundImage = Global.Dinkster_Clicker.My.Resources.Resources.controlbox
        Me.btnControlMinimize.Image = Global.Dinkster_Clicker.My.Resources.Resources.minimize
        Me.btnControlMinimize.Location = New System.Drawing.Point(245, 2)
        Me.btnControlMinimize.Name = "btnControlMinimize"
        Me.btnControlMinimize.Size = New System.Drawing.Size(16, 16)
        Me.btnControlMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnControlMinimize.TabIndex = 16
        Me.btnControlMinimize.TabStop = False
        '
        'btnControlExit
        '
        Me.btnControlExit.BackColor = System.Drawing.Color.Transparent
        Me.btnControlExit.BackgroundImage = Global.Dinkster_Clicker.My.Resources.Resources.controlbox
        Me.btnControlExit.Image = Global.Dinkster_Clicker.My.Resources.Resources._exit
        Me.btnControlExit.Location = New System.Drawing.Point(266, 2)
        Me.btnControlExit.Name = "btnControlExit"
        Me.btnControlExit.Size = New System.Drawing.Size(16, 16)
        Me.btnControlExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnControlExit.TabIndex = 15
        Me.btnControlExit.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImage = Global.Dinkster_Clicker.My.Resources.Resources.controlbox
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Image = Global.Dinkster_Clicker.My.Resources.Resources.controlbox
        Me.PictureBox4.Location = New System.Drawing.Point(-42, 357)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(368, 32)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 14
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Dinkster_Clicker.My.Resources.Resources.controlbox
        Me.PictureBox3.Location = New System.Drawing.Point(-10, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(18, 368)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Dinkster_Clicker.My.Resources.Resources.controlbox
        Me.PictureBox2.Location = New System.Drawing.Point(276, 7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(18, 450)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Dinkster_Clicker.My.Resources.Resources.controlbox
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.Dinkster_Clicker.My.Resources.Resources.controlbox
        Me.PictureBox1.Location = New System.Drawing.Point(-43, -7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(333, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'btnShowValues
        '
        Me.btnShowValues.Location = New System.Drawing.Point(15, 32)
        Me.btnShowValues.Name = "btnShowValues"
        Me.btnShowValues.Size = New System.Drawing.Size(14, 14)
        Me.btnShowValues.TabIndex = 19
        Me.btnShowValues.UseVisualStyleBackColor = True
        '
        'frmClicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 365)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnShowValues)
        Me.Controls.Add(Me.btnControlMinimize)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.lblControlTitle)
        Me.Controls.Add(Me.btnControlExit)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblComplete)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCheats)
        Me.Controls.Add(Me.lblDPS)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnSupplies)
        Me.Controls.Add(Me.lblNumDinksters)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDink)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmClicker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Dinkster Clicker"
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnControlMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnControlExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblNumDinksters As System.Windows.Forms.Label
    Friend WithEvents btnSupplies As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents lblDPS As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BgwAddDinks As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnCheats As Button
    Friend WithEvents btnDink As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblComplete As Label
    Friend WithEvents TimeKeeper As System.ComponentModel.BackgroundWorker
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents lblControlTitle As Label
    Friend WithEvents btnControlMinimize As PictureBox
    Friend WithEvents btnControlExit As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnShowValues As Button
End Class
