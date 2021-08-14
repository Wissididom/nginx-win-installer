<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cb_savetoworkingdirectory = New System.Windows.Forms.CheckBox()
        Me.txt_destination_folder = New System.Windows.Forms.TextBox()
        Me.btn_destination_folder = New System.Windows.Forms.Button()
        Me.btn_install = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cb_savetoworkingdirectory
        '
        Me.cb_savetoworkingdirectory.AutoSize = True
        Me.cb_savetoworkingdirectory.Checked = True
        Me.cb_savetoworkingdirectory.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_savetoworkingdirectory.Location = New System.Drawing.Point(12, 12)
        Me.cb_savetoworkingdirectory.Name = "cb_savetoworkingdirectory"
        Me.cb_savetoworkingdirectory.Size = New System.Drawing.Size(122, 17)
        Me.cb_savetoworkingdirectory.TabIndex = 0
        Me.cb_savetoworkingdirectory.Text = "Save to Working Dir"
        Me.cb_savetoworkingdirectory.UseVisualStyleBackColor = True
        '
        'txt_destination_folder
        '
        Me.txt_destination_folder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_destination_folder.Location = New System.Drawing.Point(12, 35)
        Me.txt_destination_folder.Name = "txt_destination_folder"
        Me.txt_destination_folder.ReadOnly = True
        Me.txt_destination_folder.Size = New System.Drawing.Size(344, 20)
        Me.txt_destination_folder.TabIndex = 1
        '
        'btn_destination_folder
        '
        Me.btn_destination_folder.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_destination_folder.Enabled = False
        Me.btn_destination_folder.Location = New System.Drawing.Point(362, 33)
        Me.btn_destination_folder.Name = "btn_destination_folder"
        Me.btn_destination_folder.Size = New System.Drawing.Size(37, 23)
        Me.btn_destination_folder.TabIndex = 2
        Me.btn_destination_folder.Text = "..."
        Me.btn_destination_folder.UseVisualStyleBackColor = True
        '
        'btn_install
        '
        Me.btn_install.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_install.Location = New System.Drawing.Point(168, 61)
        Me.btn_install.Name = "btn_install"
        Me.btn_install.Size = New System.Drawing.Size(75, 23)
        Me.btn_install.TabIndex = 3
        Me.btn_install.Text = "Install"
        Me.btn_install.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 96)
        Me.Controls.Add(Me.btn_install)
        Me.Controls.Add(Me.btn_destination_folder)
        Me.Controls.Add(Me.txt_destination_folder)
        Me.Controls.Add(Me.cb_savetoworkingdirectory)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "nginx-win-installer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cb_savetoworkingdirectory As CheckBox
    Friend WithEvents txt_destination_folder As TextBox
    Friend WithEvents btn_destination_folder As Button
    Friend WithEvents btn_install As Button
End Class
