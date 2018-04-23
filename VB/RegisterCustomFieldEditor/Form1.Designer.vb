Namespace RegisterCustomFieldEditor
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.btnShowPreview = New System.Windows.Forms.Button()
            Me.btnShowDesigner = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            ' 
            ' btnShowPreview
            ' 
            Me.btnShowPreview.Location = New System.Drawing.Point(46, 52)
            Me.btnShowPreview.Name = "btnShowPreview"
            Me.btnShowPreview.Size = New System.Drawing.Size(195, 47)
            Me.btnShowPreview.TabIndex = 0
            Me.btnShowPreview.Text = "Show Print Preview"
            Me.btnShowPreview.UseVisualStyleBackColor = True
            ' 
            ' btnShowDesigner
            ' 
            Me.btnShowDesigner.Location = New System.Drawing.Point(46, 136)
            Me.btnShowDesigner.Name = "btnShowDesigner"
            Me.btnShowDesigner.Size = New System.Drawing.Size(195, 47)
            Me.btnShowDesigner.TabIndex = 1
            Me.btnShowDesigner.Text = "Show Report Designer"
            Me.btnShowDesigner.UseVisualStyleBackColor = True
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(284, 261)
            Me.Controls.Add(Me.btnShowDesigner)
            Me.Controls.Add(Me.btnShowPreview)
            Me.Name = "Form1"
            Me.Text = "Form1"
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private WithEvents btnShowPreview As System.Windows.Forms.Button
        Private WithEvents btnShowDesigner As System.Windows.Forms.Button
    End Class
End Namespace

