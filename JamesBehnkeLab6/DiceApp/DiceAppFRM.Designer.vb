<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DiceAppFRM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DiceAppFRM))
        Me.numDiceGBX = New System.Windows.Forms.GroupBox()
        Me.die3RBTN = New System.Windows.Forms.RadioButton()
        Me.die2RBTN = New System.Windows.Forms.RadioButton()
        Me.die1RBTN = New System.Windows.Forms.RadioButton()
        Me.die1PBX = New System.Windows.Forms.PictureBox()
        Me.die2PBX = New System.Windows.Forms.PictureBox()
        Me.die3PBX = New System.Windows.Forms.PictureBox()
        Me.diceGBX = New System.Windows.Forms.GroupBox()
        Me.rollBTN = New System.Windows.Forms.Button()
        Me.numDiceGBX.SuspendLayout()
        CType(Me.die1PBX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.die2PBX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.die3PBX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.diceGBX.SuspendLayout()
        Me.SuspendLayout()
        '
        'numDiceGBX
        '
        Me.numDiceGBX.Controls.Add(Me.die3RBTN)
        Me.numDiceGBX.Controls.Add(Me.die2RBTN)
        Me.numDiceGBX.Controls.Add(Me.die1RBTN)
        Me.numDiceGBX.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numDiceGBX.Location = New System.Drawing.Point(24, 34)
        Me.numDiceGBX.Margin = New System.Windows.Forms.Padding(6)
        Me.numDiceGBX.Name = "numDiceGBX"
        Me.numDiceGBX.Padding = New System.Windows.Forms.Padding(6)
        Me.numDiceGBX.Size = New System.Drawing.Size(166, 238)
        Me.numDiceGBX.TabIndex = 0
        Me.numDiceGBX.TabStop = False
        Me.numDiceGBX.Text = "Number Of Dice"
        '
        'die3RBTN
        '
        Me.die3RBTN.AutoSize = True
        Me.die3RBTN.Location = New System.Drawing.Point(10, 169)
        Me.die3RBTN.Name = "die3RBTN"
        Me.die3RBTN.Size = New System.Drawing.Size(123, 28)
        Me.die3RBTN.TabIndex = 2
        Me.die3RBTN.TabStop = True
        Me.die3RBTN.Text = "Three dice"
        Me.die3RBTN.UseVisualStyleBackColor = True
        '
        'die2RBTN
        '
        Me.die2RBTN.AutoSize = True
        Me.die2RBTN.Location = New System.Drawing.Point(10, 120)
        Me.die2RBTN.Name = "die2RBTN"
        Me.die2RBTN.Size = New System.Drawing.Size(109, 28)
        Me.die2RBTN.TabIndex = 1
        Me.die2RBTN.TabStop = True
        Me.die2RBTN.Text = "Two dice"
        Me.die2RBTN.UseVisualStyleBackColor = True
        '
        'die1RBTN
        '
        Me.die1RBTN.AutoSize = True
        Me.die1RBTN.Location = New System.Drawing.Point(10, 68)
        Me.die1RBTN.Name = "die1RBTN"
        Me.die1RBTN.Size = New System.Drawing.Size(99, 28)
        Me.die1RBTN.TabIndex = 0
        Me.die1RBTN.TabStop = True
        Me.die1RBTN.Text = "One die"
        Me.die1RBTN.UseVisualStyleBackColor = True
        '
        'die1PBX
        '
        Me.die1PBX.Image = CType(resources.GetObject("die1PBX.Image"), System.Drawing.Image)
        Me.die1PBX.InitialImage = CType(resources.GetObject("die1PBX.InitialImage"), System.Drawing.Image)
        Me.die1PBX.Location = New System.Drawing.Point(27, 29)
        Me.die1PBX.Name = "die1PBX"
        Me.die1PBX.Size = New System.Drawing.Size(92, 94)
        Me.die1PBX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.die1PBX.TabIndex = 1
        Me.die1PBX.TabStop = False
        '
        'die2PBX
        '
        Me.die2PBX.Image = CType(resources.GetObject("die2PBX.Image"), System.Drawing.Image)
        Me.die2PBX.Location = New System.Drawing.Point(150, 68)
        Me.die2PBX.Name = "die2PBX"
        Me.die2PBX.Size = New System.Drawing.Size(100, 92)
        Me.die2PBX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.die2PBX.TabIndex = 2
        Me.die2PBX.TabStop = False
        '
        'die3PBX
        '
        Me.die3PBX.Image = CType(resources.GetObject("die3PBX.Image"), System.Drawing.Image)
        Me.die3PBX.Location = New System.Drawing.Point(281, 120)
        Me.die3PBX.Name = "die3PBX"
        Me.die3PBX.Size = New System.Drawing.Size(95, 96)
        Me.die3PBX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.die3PBX.TabIndex = 3
        Me.die3PBX.TabStop = False
        '
        'diceGBX
        '
        Me.diceGBX.Controls.Add(Me.die2PBX)
        Me.diceGBX.Controls.Add(Me.die3PBX)
        Me.diceGBX.Controls.Add(Me.die1PBX)
        Me.diceGBX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.diceGBX.Location = New System.Drawing.Point(221, 34)
        Me.diceGBX.Name = "diceGBX"
        Me.diceGBX.Size = New System.Drawing.Size(404, 238)
        Me.diceGBX.TabIndex = 4
        Me.diceGBX.TabStop = False
        Me.diceGBX.Text = "Roll the dice"
        '
        'rollBTN
        '
        Me.rollBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rollBTN.Location = New System.Drawing.Point(430, 295)
        Me.rollBTN.Name = "rollBTN"
        Me.rollBTN.Size = New System.Drawing.Size(195, 46)
        Me.rollBTN.TabIndex = 5
        Me.rollBTN.Text = "Roll!"
        Me.rollBTN.UseVisualStyleBackColor = True
        '
        'DiceAppFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 367)
        Me.Controls.Add(Me.rollBTN)
        Me.Controls.Add(Me.diceGBX)
        Me.Controls.Add(Me.numDiceGBX)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "DiceAppFRM"
        Me.Text = "Dice Roller"
        Me.numDiceGBX.ResumeLayout(False)
        Me.numDiceGBX.PerformLayout()
        CType(Me.die1PBX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.die2PBX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.die3PBX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.diceGBX.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents numDiceGBX As GroupBox
    Friend WithEvents die1PBX As PictureBox
    Friend WithEvents die2PBX As PictureBox
    Friend WithEvents die3PBX As PictureBox
    Friend WithEvents diceGBX As GroupBox
    Friend WithEvents rollBTN As Button
    Friend WithEvents die3RBTN As RadioButton
    Friend WithEvents die2RBTN As RadioButton
    Friend WithEvents die1RBTN As RadioButton
End Class
