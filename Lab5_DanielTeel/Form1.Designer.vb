<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.trckPower = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblVolt = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCurrent = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.picIn = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.txtR1 = New System.Windows.Forms.TextBox()
        Me.txtR3 = New System.Windows.Forms.TextBox()
        Me.txtV3 = New System.Windows.Forms.TextBox()
        Me.txtV2 = New System.Windows.Forms.TextBox()
        Me.txtR2 = New System.Windows.Forms.TextBox()
        Me.txtV1 = New System.Windows.Forms.TextBox()
        Me.chkRemove = New System.Windows.Forms.CheckBox()
        Me.picEx = New System.Windows.Forms.PictureBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.trckPower, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picIn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'trckPower
        '
        Me.trckPower.Location = New System.Drawing.Point(12, 220)
        Me.trckPower.Name = "trckPower"
        Me.trckPower.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.trckPower.Size = New System.Drawing.Size(114, 682)
        Me.trckPower.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(123, 509)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Source Voltage:"
        '
        'lblVolt
        '
        Me.lblVolt.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblVolt.Location = New System.Drawing.Point(188, 550)
        Me.lblVolt.Name = "lblVolt"
        Me.lblVolt.Size = New System.Drawing.Size(62, 43)
        Me.lblVolt.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(500, 239)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 32)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "I:"
        '
        'lblCurrent
        '
        Me.lblCurrent.BackColor = System.Drawing.Color.Yellow
        Me.lblCurrent.Location = New System.Drawing.Point(552, 239)
        Me.lblCurrent.Name = "lblCurrent"
        Me.lblCurrent.Size = New System.Drawing.Size(102, 32)
        Me.lblCurrent.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(854, 223)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 32)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "R1:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(855, 271)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 32)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "V1:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(1292, 469)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 32)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "R2:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(1292, 515)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 32)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "V2:"
        '
        'picIn
        '
        Me.picIn.Image = CType(resources.GetObject("picIn.Image"), System.Drawing.Image)
        Me.picIn.Location = New System.Drawing.Point(357, 323)
        Me.picIn.Name = "picIn"
        Me.picIn.Size = New System.Drawing.Size(911, 506)
        Me.picIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picIn.TabIndex = 12
        Me.picIn.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Red
        Me.TextBox1.Location = New System.Drawing.Point(646, 509)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 38)
        Me.TextBox1.TabIndex = 13
        Me.TextBox1.Text = "R3: "
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox2.Location = New System.Drawing.Point(646, 574)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 38)
        Me.TextBox2.TabIndex = 14
        Me.TextBox2.Text = "V3:"
        '
        'txtR1
        '
        Me.txtR1.Location = New System.Drawing.Point(964, 220)
        Me.txtR1.Multiline = True
        Me.txtR1.Name = "txtR1"
        Me.txtR1.Size = New System.Drawing.Size(100, 38)
        Me.txtR1.TabIndex = 15
        '
        'txtR3
        '
        Me.txtR3.Location = New System.Drawing.Point(771, 509)
        Me.txtR3.Multiline = True
        Me.txtR3.Name = "txtR3"
        Me.txtR3.Size = New System.Drawing.Size(100, 38)
        Me.txtR3.TabIndex = 16
        '
        'txtV3
        '
        Me.txtV3.Location = New System.Drawing.Point(771, 574)
        Me.txtV3.Multiline = True
        Me.txtV3.Name = "txtV3"
        Me.txtV3.ReadOnly = True
        Me.txtV3.Size = New System.Drawing.Size(100, 38)
        Me.txtV3.TabIndex = 17
        '
        'txtV2
        '
        Me.txtV2.Location = New System.Drawing.Point(1387, 512)
        Me.txtV2.Multiline = True
        Me.txtV2.Name = "txtV2"
        Me.txtV2.ReadOnly = True
        Me.txtV2.Size = New System.Drawing.Size(100, 38)
        Me.txtV2.TabIndex = 18
        '
        'txtR2
        '
        Me.txtR2.Location = New System.Drawing.Point(1387, 466)
        Me.txtR2.Multiline = True
        Me.txtR2.Name = "txtR2"
        Me.txtR2.Size = New System.Drawing.Size(100, 38)
        Me.txtR2.TabIndex = 19
        '
        'txtV1
        '
        Me.txtV1.Location = New System.Drawing.Point(964, 268)
        Me.txtV1.Multiline = True
        Me.txtV1.Name = "txtV1"
        Me.txtV1.ReadOnly = True
        Me.txtV1.Size = New System.Drawing.Size(100, 38)
        Me.txtV1.TabIndex = 20
        '
        'chkRemove
        '
        Me.chkRemove.AutoSize = True
        Me.chkRemove.Location = New System.Drawing.Point(670, 853)
        Me.chkRemove.Name = "chkRemove"
        Me.chkRemove.Size = New System.Drawing.Size(354, 36)
        Me.chkRemove.TabIndex = 21
        Me.chkRemove.Text = "Remove R3 from circuit."
        Me.chkRemove.UseVisualStyleBackColor = True
        '
        'picEx
        '
        Me.picEx.Image = CType(resources.GetObject("picEx.Image"), System.Drawing.Image)
        Me.picEx.Location = New System.Drawing.Point(357, 323)
        Me.picEx.Name = "picEx"
        Me.picEx.Size = New System.Drawing.Size(921, 506)
        Me.picEx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picEx.TabIndex = 22
        Me.picEx.TabStop = False
        Me.picEx.Visible = False
        '
        'btnCalc
        '
        Me.btnCalc.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCalc.Location = New System.Drawing.Point(214, 907)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(1165, 106)
        Me.btnCalc.TabIndex = 23
        Me.btnCalc.Text = "CALCULATE"
        Me.btnCalc.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(214, 1010)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(580, 63)
        Me.btnClear.TabIndex = 24
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(800, 1010)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(579, 63)
        Me.btnClose.TabIndex = 25
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1549, 1104)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.picEx)
        Me.Controls.Add(Me.chkRemove)
        Me.Controls.Add(Me.txtV1)
        Me.Controls.Add(Me.txtR2)
        Me.Controls.Add(Me.txtV2)
        Me.Controls.Add(Me.txtV3)
        Me.Controls.Add(Me.txtR3)
        Me.Controls.Add(Me.txtR1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.picIn)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblCurrent)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblVolt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.trckPower)
        Me.Name = "Form1"
        Me.Text = "Circuit Calculator"
        CType(Me.trckPower, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picIn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents trckPower As TrackBar
    Friend WithEvents Label1 As Label
    Friend WithEvents lblVolt As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblCurrent As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Public WithEvents picIn As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents txtR1 As TextBox
    Friend WithEvents txtR3 As TextBox
    Friend WithEvents txtV3 As TextBox
    Friend WithEvents txtV2 As TextBox
    Friend WithEvents txtR2 As TextBox
    Friend WithEvents txtV1 As TextBox
    Friend WithEvents chkRemove As CheckBox
    Friend WithEvents picEx As PictureBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnClose As Button
End Class
