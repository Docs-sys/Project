<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagerLoginForm
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtManagerPass = New System.Windows.Forms.TextBox()
        Me.btnManagerLoginForm = New System.Windows.Forms.Button()
        Me.btnAdminLogin = New System.Windows.Forms.Button()
        Me.btnLoginManager = New System.Windows.Forms.Button()
        Me.TxtManagerUser = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label3.Location = New System.Drawing.Point(473, 355)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 22)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Username :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label4.Location = New System.Drawing.Point(473, 404)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 22)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Password :"
        '
        'txtManagerPass
        '
        Me.txtManagerPass.Location = New System.Drawing.Point(603, 406)
        Me.txtManagerPass.Name = "txtManagerPass"
        Me.txtManagerPass.Size = New System.Drawing.Size(247, 22)
        Me.txtManagerPass.TabIndex = 3
        '
        'btnManagerLoginForm
        '
        Me.btnManagerLoginForm.BackColor = System.Drawing.Color.Beige
        Me.btnManagerLoginForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManagerLoginForm.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManagerLoginForm.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.btnManagerLoginForm.Location = New System.Drawing.Point(740, 239)
        Me.btnManagerLoginForm.Name = "btnManagerLoginForm"
        Me.btnManagerLoginForm.Size = New System.Drawing.Size(101, 42)
        Me.btnManagerLoginForm.TabIndex = 4
        Me.btnManagerLoginForm.Text = "Manager"
        Me.btnManagerLoginForm.UseVisualStyleBackColor = False
        '
        'btnAdminLogin
        '
        Me.btnAdminLogin.BackColor = System.Drawing.Color.Beige
        Me.btnAdminLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdminLogin.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminLogin.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.btnAdminLogin.Location = New System.Drawing.Point(539, 239)
        Me.btnAdminLogin.Name = "btnAdminLogin"
        Me.btnAdminLogin.Size = New System.Drawing.Size(102, 42)
        Me.btnAdminLogin.TabIndex = 5
        Me.btnAdminLogin.Text = "Admin"
        Me.btnAdminLogin.UseVisualStyleBackColor = False
        '
        'btnLoginManager
        '
        Me.btnLoginManager.BackColor = System.Drawing.Color.Beige
        Me.btnLoginManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoginManager.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoginManager.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.btnLoginManager.Location = New System.Drawing.Point(824, 512)
        Me.btnLoginManager.Name = "btnLoginManager"
        Me.btnLoginManager.Size = New System.Drawing.Size(102, 42)
        Me.btnLoginManager.TabIndex = 1
        Me.btnLoginManager.Text = "Log in"
        Me.btnLoginManager.UseVisualStyleBackColor = False
        '
        'TxtManagerUser
        '
        Me.TxtManagerUser.Location = New System.Drawing.Point(603, 357)
        Me.TxtManagerUser.Name = "TxtManagerUser"
        Me.TxtManagerUser.Size = New System.Drawing.Size(247, 22)
        Me.TxtManagerUser.TabIndex = 9
        '
        'ManagerLoginForm
        '
        Me.BackgroundImage = Global.Project.My.Resources.Resources.CONRADS_MANILA
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1508, 733)
        Me.Controls.Add(Me.TxtManagerUser)
        Me.Controls.Add(Me.btnLoginManager)
        Me.Controls.Add(Me.btnAdminLogin)
        Me.Controls.Add(Me.btnManagerLoginForm)
        Me.Controls.Add(Me.txtManagerPass)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.DoubleBuffered = True
        Me.Name = "ManagerLoginForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtManagerUsername As TextBox
    Friend WithEvents txtManagerPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnManagerLogin As Button
    Friend WithEvents btnlogin As Button
    Friend WithEvents AdminLogin As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtManagerPass As TextBox
    Friend WithEvents btnManagerLoginForm As Button
    Friend WithEvents btnAdminLogin As Button
    Friend WithEvents btnLoginManager As Button
    Friend WithEvents TxtManagerUser As TextBox
End Class
