<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnEntrar = New Button()
        txtUsuario = New TextBox()
        txtContra = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' btnEntrar
        ' 
        btnEntrar.Location = New Point(201, 329)
        btnEntrar.Margin = New Padding(3, 4, 3, 4)
        btnEntrar.Name = "btnEntrar"
        btnEntrar.Size = New Size(86, 31)
        btnEntrar.TabIndex = 3
        btnEntrar.Text = "Entrar"
        btnEntrar.UseVisualStyleBackColor = True
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Location = New Point(225, 129)
        txtUsuario.Margin = New Padding(3, 4, 3, 4)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(114, 27)
        txtUsuario.TabIndex = 1
        ' 
        ' txtContra
        ' 
        txtContra.Location = New Point(225, 236)
        txtContra.Margin = New Padding(3, 4, 3, 4)
        txtContra.Name = "txtContra"
        txtContra.Size = New Size(114, 27)
        txtContra.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(134, 136)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 20)
        Label1.TabIndex = 0
        Label1.Text = "Usuario"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(134, 240)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 20)
        Label2.TabIndex = 0
        Label2.Text = "Contraseña"
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(487, 452)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtContra)
        Controls.Add(txtUsuario)
        Controls.Add(btnEntrar)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(3, 4, 3, 4)
        Name = "Login"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnEntrar As Button
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtContra As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
