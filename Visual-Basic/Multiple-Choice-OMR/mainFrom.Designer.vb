﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.PrevButton = New System.Windows.Forms.Button()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.Label_PageNumber = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(471, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 38)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Choose PDF"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(450, 637)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ImageList2
        '
        Me.ImageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList2.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        '
        'PrevButton
        '
        Me.PrevButton.Location = New System.Drawing.Point(471, 56)
        Me.PrevButton.Name = "PrevButton"
        Me.PrevButton.Size = New System.Drawing.Size(55, 49)
        Me.PrevButton.TabIndex = 3
        Me.PrevButton.Text = "Prev"
        Me.PrevButton.UseVisualStyleBackColor = True
        '
        'NextButton
        '
        Me.NextButton.Location = New System.Drawing.Point(532, 56)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(55, 49)
        Me.NextButton.TabIndex = 4
        Me.NextButton.Text = "Next"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'Label_PageNumber
        '
        Me.Label_PageNumber.AutoSize = True
        Me.Label_PageNumber.Location = New System.Drawing.Point(468, 231)
        Me.Label_PageNumber.Name = "Label_PageNumber"
        Me.Label_PageNumber.Size = New System.Drawing.Size(0, 13)
        Me.Label_PageNumber.TabIndex = 5
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.Label_PageNumber)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.PrevButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "MainForm"
        Me.Text = "Multiple-Choice-OMR"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ImageList2 As ImageList
    Friend WithEvents PrevButton As Button
    Friend WithEvents NextButton As Button
    Friend WithEvents Label_PageNumber As Label
End Class
