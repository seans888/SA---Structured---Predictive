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
        Me.lblUN = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtUN = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUN
        '
        Me.lblUN.AutoSize = True
        Me.lblUN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUN.Location = New System.Drawing.Point(17, 155)
        Me.lblUN.Name = "lblUN"
        Me.lblUN.Size = New System.Drawing.Size(87, 20)
        Me.lblUN.TabIndex = 0
        Me.lblUN.Text = "Username:"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.Location = New System.Drawing.Point(17, 208)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(82, 20)
        Me.lblPass.TabIndex = 1
        Me.lblPass.Text = "Password:"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(110, 210)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(257, 20)
        Me.txtPass.TabIndex = 2
        '
        'txtUN
        '
        Me.txtUN.Location = New System.Drawing.Point(110, 157)
        Me.txtUN.Name = "txtUN"
        Me.txtUN.Size = New System.Drawing.Size(257, 20)
        Me.txtUN.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(139, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 330)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtUN)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblUN)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUN As Label
    Friend WithEvents lblPass As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtUN As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
