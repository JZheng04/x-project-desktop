﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAyudaPoliticas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAyudaPoliticas))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnVolver = New FontAwesome.Sharp.IconButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(272, 58)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(487, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Preguntas Frecuentes sobre Politicas"
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft
        Me.btnVolver.IconColor = System.Drawing.Color.Black
        Me.btnVolver.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnVolver.IconSize = 30
        Me.btnVolver.Location = New System.Drawing.Point(16, 15)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(180, 59)
        Me.btnVolver.TabIndex = 6
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(31, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(303, 91)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "¿Dónde puedo encontrar las políticas detalladas de la empresa, incluyendo término" &
    "s de servicio y políticas de privacidad?"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(374, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(303, 91)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "¿Cuáles son las políticas de seguridad en el manejo de información de usuarios y " &
    "transacciones?"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(721, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(303, 91)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "¿Cómo puedo presentar sugerencias o quejas sobre el servicio y esperar una respue" &
    "sta?"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(31, 237)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(303, 138)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = resources.GetString("Label6.Text")
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(374, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(303, 138)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = resources.GetString("Label5.Text")
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(721, 248)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(303, 138)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = resources.GetString("Label7.Text")
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmAyudaPoliticas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmAyudaPoliticas"
        Me.Text = "frmAyudaPoliticas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnVolver As FontAwesome.Sharp.IconButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
End Class
