<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.lblLogIn = New System.Windows.Forms.Label()
        Me.txtUN = New System.Windows.Forms.TextBox()
        Me.txtPW = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.panelLogin = New System.Windows.Forms.Panel()
        Me.panelLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLogIn
        '
        Me.lblLogIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogIn.Location = New System.Drawing.Point(30, 9)
        Me.lblLogIn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLogIn.Name = "lblLogIn"
        Me.lblLogIn.Size = New System.Drawing.Size(317, 38)
        Me.lblLogIn.TabIndex = 0
        Me.lblLogIn.Text = "Logg inn"
        Me.lblLogIn.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtUN
        '
        Me.txtUN.Location = New System.Drawing.Point(102, 15)
        Me.txtUN.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUN.Name = "txtUN"
        Me.txtUN.Size = New System.Drawing.Size(209, 22)
        Me.txtUN.TabIndex = 1
        '
        'txtPW
        '
        Me.txtPW.Location = New System.Drawing.Point(102, 44)
        Me.txtPW.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPW.Name = "txtPW"
        Me.txtPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPW.Size = New System.Drawing.Size(209, 22)
        Me.txtPW.TabIndex = 2
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(102, 88)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(121, 37)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "Logg inn"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(54, 138)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(215, 17)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Glemt brukernavn eller passord?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 18)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Brukernavn"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 46)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Passord"
        '
        'panelLogin
        '
        Me.panelLogin.AccessibleDescription = "panelLogin"
        Me.panelLogin.BackColor = System.Drawing.SystemColors.Control
        Me.panelLogin.Controls.Add(Me.Label2)
        Me.panelLogin.Controls.Add(Me.LinkLabel1)
        Me.panelLogin.Controls.Add(Me.Label3)
        Me.panelLogin.Controls.Add(Me.txtUN)
        Me.panelLogin.Controls.Add(Me.txtPW)
        Me.panelLogin.Controls.Add(Me.btnLogin)
        Me.panelLogin.Location = New System.Drawing.Point(30, 55)
        Me.panelLogin.Name = "panelLogin"
        Me.panelLogin.Size = New System.Drawing.Size(317, 176)
        Me.panelLogin.TabIndex = 9
        '
        'logginn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 247)
        Me.Controls.Add(Me.panelLogin)
        Me.Controls.Add(Me.lblLogIn)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "logginn"
        Me.Text = "Logg inn"
        Me.panelLogin.ResumeLayout(False)
        Me.panelLogin.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblLogIn As System.Windows.Forms.Label
    Friend WithEvents txtUN As System.Windows.Forms.TextBox
    Friend WithEvents txtPW As System.Windows.Forms.TextBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents panelLogin As System.Windows.Forms.Panel
End Class
