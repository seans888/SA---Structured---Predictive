<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.picSM2 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnGet5 = New System.Windows.Forms.Button()
        Me.btnCpr5 = New System.Windows.Forms.Button()
        Me.btnMcr5 = New System.Windows.Forms.Button()
        Me.btnHome5 = New System.Windows.Forms.Button()
        CType(Me.picSM2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picSM2
        '
        Me.picSM2.Image = CType(resources.GetObject("picSM2.Image"), System.Drawing.Image)
        Me.picSM2.Location = New System.Drawing.Point(318, 12)
        Me.picSM2.Name = "picSM2"
        Me.picSM2.Size = New System.Drawing.Size(69, 58)
        Me.picSM2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSM2.TabIndex = 9
        Me.picSM2.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(33, 145)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(330, 100)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'btnGet5
        '
        Me.btnGet5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnGet5.Location = New System.Drawing.Point(295, 81)
        Me.btnGet5.Name = "btnGet5"
        Me.btnGet5.Size = New System.Drawing.Size(98, 40)
        Me.btnGet5.TabIndex = 18
        Me.btnGet5.Text = "Get Reports"
        Me.btnGet5.UseVisualStyleBackColor = False
        '
        'btnCpr5
        '
        Me.btnCpr5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.btnCpr5.Location = New System.Drawing.Point(105, 81)
        Me.btnCpr5.Name = "btnCpr5"
        Me.btnCpr5.Size = New System.Drawing.Size(98, 40)
        Me.btnCpr5.TabIndex = 17
        Me.btnCpr5.Text = "Create Prediction Report"
        Me.btnCpr5.UseVisualStyleBackColor = True
        '
        'btnMcr5
        '
        Me.btnMcr5.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnMcr5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMcr5.Location = New System.Drawing.Point(200, 81)
        Me.btnMcr5.Name = "btnMcr5"
        Me.btnMcr5.Size = New System.Drawing.Size(98, 40)
        Me.btnMcr5.TabIndex = 16
        Me.btnMcr5.Text = "Manage Created Report"
        Me.btnMcr5.UseVisualStyleBackColor = False
        '
        'btnHome5
        '
        Me.btnHome5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnHome5.Location = New System.Drawing.Point(8, 81)
        Me.btnHome5.Name = "btnHome5"
        Me.btnHome5.Size = New System.Drawing.Size(98, 40)
        Me.btnHome5.TabIndex = 15
        Me.btnHome5.Text = "Home"
        Me.btnHome5.UseVisualStyleBackColor = False
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 330)
        Me.Controls.Add(Me.btnGet5)
        Me.Controls.Add(Me.btnCpr5)
        Me.Controls.Add(Me.btnMcr5)
        Me.Controls.Add(Me.btnHome5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.picSM2)
        Me.Name = "Form6"
        Me.Text = " "
        CType(Me.picSM2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picSM2 As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnGet5 As Button
    Friend WithEvents btnCpr5 As Button
    Friend WithEvents btnMcr5 As Button
    Friend WithEvents btnHome5 As Button
End Class
