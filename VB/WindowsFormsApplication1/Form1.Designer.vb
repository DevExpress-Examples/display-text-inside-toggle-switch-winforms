Namespace WindowsFormsApplication1

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.customToggle1 = New WindowsFormsApplication1.CustomToggle()
            CType((Me.customToggle1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' customToggle1
            ' 
            Me.customToggle1.Location = New System.Drawing.Point(149, 136)
            Me.customToggle1.Name = "customToggle1"
            Me.customToggle1.Properties.AllowThumbAnimation = False
            Me.customToggle1.Properties.OffText = "Off"
            Me.customToggle1.Properties.OnText = "On"
            Me.customToggle1.Size = New System.Drawing.Size(91, 24)
            Me.customToggle1.TabIndex = 0
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(436, 534)
            Me.Controls.Add(Me.customToggle1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType((Me.customToggle1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

'#End Region
        Private customToggle1 As WindowsFormsApplication1.CustomToggle
    End Class
End Namespace
