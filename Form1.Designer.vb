﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtBoton = New Button()
        txtMostrar = New ListBox()
        SuspendLayout()
        ' 
        ' txtBoton
        ' 
        txtBoton.Location = New Point(483, 216)
        txtBoton.Name = "txtBoton"
        txtBoton.Size = New Size(368, 304)
        txtBoton.TabIndex = 0
        txtBoton.Text = "EjecutarAlgoritmo"
        txtBoton.UseVisualStyleBackColor = True
        ' 
        ' txtMostrar
        ' 
        txtMostrar.FormattingEnabled = True
        txtMostrar.Location = New Point(43, 7)
        txtMostrar.Name = "txtMostrar"
        txtMostrar.Size = New Size(241, 836)
        txtMostrar.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1060, 872)
        Controls.Add(txtMostrar)
        Controls.Add(txtBoton)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents txtBoton As Button
    Friend WithEvents txtMostrar As ListBox

End Class
