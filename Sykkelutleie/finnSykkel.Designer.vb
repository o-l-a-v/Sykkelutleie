<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class finnSykkel
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.boxFinnSykkel = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtSok = New System.Windows.Forms.TextBox()
        Me.boxFinnSykkel.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(342, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 31)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Sykkel"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Terrengsykkel", "Racer", "Hybrid", "Tandem", "BMX"})
        Me.ComboBox1.Location = New System.Drawing.Point(6, 53)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(160, 24)
        Me.ComboBox1.TabIndex = 4
        Me.ComboBox1.Text = "Sykkeltype"
        '
        'boxFinnSykkel
        '
        Me.boxFinnSykkel.AutoSize = True
        Me.boxFinnSykkel.Controls.Add(Me.txtSok)
        Me.boxFinnSykkel.Controls.Add(Me.DataGridView1)
        Me.boxFinnSykkel.Controls.Add(Me.Label1)
        Me.boxFinnSykkel.Controls.Add(Me.ComboBox1)
        Me.boxFinnSykkel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.boxFinnSykkel.Location = New System.Drawing.Point(0, 0)
        Me.boxFinnSykkel.Name = "boxFinnSykkel"
        Me.boxFinnSykkel.Size = New System.Drawing.Size(825, 402)
        Me.boxFinnSykkel.TabIndex = 5
        Me.boxFinnSykkel.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 84)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(814, 316)
        Me.DataGridView1.TabIndex = 5
        '
        'txtSok
        '
        Me.txtSok.AccessibleDescription = "txtSok"
        Me.txtSok.AccessibleName = "txtSok"
        Me.txtSok.Location = New System.Drawing.Point(173, 53)
        Me.txtSok.Name = "txtSok"
        Me.txtSok.Size = New System.Drawing.Size(150, 22)
        Me.txtSok.TabIndex = 6
        Me.txtSok.Text = "Frisøk.."
        '
        'finnSykkel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 402)
        Me.Controls.Add(Me.boxFinnSykkel)
        Me.Name = "finnSykkel"
        Me.Text = "finnSykkel"
        Me.boxFinnSykkel.ResumeLayout(False)
        Me.boxFinnSykkel.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents boxFinnSykkel As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtSok As System.Windows.Forms.TextBox
End Class
