<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminLoginForm
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
        Me.btnAdminLogin = New System.Windows.Forms.Button()
        Me.btnOpenManager = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnAdminLogin
        '
        Me.btnAdminLogin.BackColor = System.Drawing.Color.Beige
        Me.btnAdminLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdminLogin.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminLogin.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.btnAdminLogin.Location = New System.Drawing.Point(547, 263)
        Me.btnAdminLogin.Name = "btnAdminLogin"
        Me.btnAdminLogin.Size = New System.Drawing.Size(102, 43)
        Me.btnAdminLogin.TabIndex = 0
        Me.btnAdminLogin.Text = "Admin"
        Me.btnAdminLogin.UseVisualStyleBackColor = False
        '
        'btnOpenManager
        '
        Me.btnOpenManager.BackColor = System.Drawing.Color.Beige
        Me.btnOpenManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpenManager.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenManager.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.btnOpenManager.Location = New System.Drawing.Point(742, 263)
        Me.btnOpenManager.Name = "btnOpenManager"
        Me.btnOpenManager.Size = New System.Drawing.Size(102, 43)
        Me.btnOpenManager.TabIndex = 1
        Me.btnOpenManager.Text = "Manager"
        Me.btnOpenManager.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label1.Location = New System.Drawing.Point(473, 385)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label2.Location = New System.Drawing.Point(473, 449)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password:"
        '
        'btnAdmin
        '
        Me.btnAdmin.BackColor = System.Drawing.Color.Beige
        Me.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdmin.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmin.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.btnAdmin.Location = New System.Drawing.Point(846, 524)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(102, 43)
        Me.btnAdmin.TabIndex = 1
        Me.btnAdmin.Text = "Log in"
        Me.btnAdmin.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(597, 449)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(247, 22)
        Me.txtPassword.TabIndex = 7
        '
        'TxtUsername
        '
        Me.TxtUsername.Location = New System.Drawing.Point(597, 385)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(247, 22)
        Me.TxtUsername.TabIndex = 8
        '
        'AdminLoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project.My.Resources.Resources.CONRADS_MANILA
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1515, 749)
        Me.Controls.Add(Me.TxtUsername)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.btnAdmin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnOpenManager)
        Me.Controls.Add(Me.btnAdminLogin)
        Me.DoubleBuffered = True
        Me.Name = "AdminLoginForm"
        Me.Text = "AdminLoginForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdminLogin As Button
    Friend WithEvents btnOpenManager As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAdmin As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents TxtUsername As TextBox
End Class
