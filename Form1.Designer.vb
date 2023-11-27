<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DosyaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KaydetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiaryBox = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.HisButon1 = New System.Windows.Forms.RadioButton()
        Me.HisButon2 = New System.Windows.Forms.RadioButton()
        Me.HisButon3 = New System.Windows.Forms.RadioButton()
        Me.HisButon4 = New System.Windows.Forms.RadioButton()
        Me.HisButon5 = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AçToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Takvim = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DosyaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(582, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DosyaToolStripMenuItem
        '
        Me.DosyaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AçToolStripMenuItem, Me.KaydetToolStripMenuItem})
        Me.DosyaToolStripMenuItem.Name = "DosyaToolStripMenuItem"
        Me.DosyaToolStripMenuItem.Size = New System.Drawing.Size(64, 24)
        Me.DosyaToolStripMenuItem.Text = "Dosya"
        '
        'KaydetToolStripMenuItem
        '
        Me.KaydetToolStripMenuItem.Name = "KaydetToolStripMenuItem"
        Me.KaydetToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.KaydetToolStripMenuItem.Text = "Kaydet"
        '
        'DiaryBox
        '
        Me.DiaryBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DiaryBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DiaryBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DiaryBox.Font = New System.Drawing.Font("Cascadia Mono SemiBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.DiaryBox.Location = New System.Drawing.Point(276, 43)
        Me.DiaryBox.Multiline = True
        Me.DiaryBox.Name = "DiaryBox"
        Me.DiaryBox.Size = New System.Drawing.Size(294, 295)
        Me.DiaryBox.TabIndex = 1
        Me.DiaryBox.Text = "Gününü burada not alabilirsin."
        Me.ToolTip1.SetToolTip(Me.DiaryBox, "Günlük Not Yeri")
        '
        'HisButon1
        '
        Me.HisButon1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HisButon1.AutoSize = True
        Me.HisButon1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.HisButon1.Font = New System.Drawing.Font("Cascadia Mono SemiBold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.HisButon1.Location = New System.Drawing.Point(3, 6)
        Me.HisButon1.Name = "HisButon1"
        Me.HisButon1.Size = New System.Drawing.Size(117, 29)
        Me.HisButon1.TabIndex = 3
        Me.HisButon1.TabStop = True
        Me.HisButon1.Text = "Çok İyi"
        Me.HisButon1.UseVisualStyleBackColor = True
        '
        'HisButon2
        '
        Me.HisButon2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HisButon2.AutoSize = True
        Me.HisButon2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.HisButon2.Font = New System.Drawing.Font("Cascadia Mono SemiBold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.HisButon2.Location = New System.Drawing.Point(3, 41)
        Me.HisButon2.Name = "HisButon2"
        Me.HisButon2.Size = New System.Drawing.Size(73, 29)
        Me.HisButon2.TabIndex = 4
        Me.HisButon2.TabStop = True
        Me.HisButon2.Text = "İyi"
        Me.HisButon2.UseVisualStyleBackColor = True
        '
        'HisButon3
        '
        Me.HisButon3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HisButon3.AutoSize = True
        Me.HisButon3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.HisButon3.Font = New System.Drawing.Font("Cascadia Mono SemiBold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.HisButon3.Location = New System.Drawing.Point(3, 76)
        Me.HisButon3.Name = "HisButon3"
        Me.HisButon3.Size = New System.Drawing.Size(150, 29)
        Me.HisButon3.TabIndex = 5
        Me.HisButon3.TabStop = True
        Me.HisButon3.Text = "Fena Değil"
        Me.HisButon3.UseVisualStyleBackColor = True
        '
        'HisButon4
        '
        Me.HisButon4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HisButon4.AutoSize = True
        Me.HisButon4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.HisButon4.Font = New System.Drawing.Font("Cascadia Mono SemiBold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.HisButon4.Location = New System.Drawing.Point(3, 111)
        Me.HisButon4.Name = "HisButon4"
        Me.HisButon4.Size = New System.Drawing.Size(84, 29)
        Me.HisButon4.TabIndex = 6
        Me.HisButon4.TabStop = True
        Me.HisButon4.Text = "Kötü"
        Me.HisButon4.UseVisualStyleBackColor = True
        '
        'HisButon5
        '
        Me.HisButon5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HisButon5.AutoSize = True
        Me.HisButon5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.HisButon5.Font = New System.Drawing.Font("Cascadia Mono SemiBold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.HisButon5.Location = New System.Drawing.Point(3, 146)
        Me.HisButon5.Name = "HisButon5"
        Me.HisButon5.Size = New System.Drawing.Size(128, 29)
        Me.HisButon5.TabIndex = 7
        Me.HisButon5.TabStop = True
        Me.HisButon5.Text = "Çok Kötü"
        Me.HisButon5.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Takvim)
        Me.Panel1.Controls.Add(Me.HisButon5)
        Me.Panel1.Controls.Add(Me.HisButon1)
        Me.Panel1.Controls.Add(Me.HisButon2)
        Me.Panel1.Controls.Add(Me.HisButon3)
        Me.Panel1.Controls.Add(Me.HisButon4)
        Me.Panel1.Location = New System.Drawing.Point(8, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(262, 201)
        Me.Panel1.TabIndex = 8
        '
        'AçToolStripMenuItem
        '
        Me.AçToolStripMenuItem.Name = "AçToolStripMenuItem"
        Me.AçToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.AçToolStripMenuItem.Text = "Aç"
        '
        'Takvim
        '
        Me.Takvim.Location = New System.Drawing.Point(3, 176)
        Me.Takvim.Name = "Takvim"
        Me.Takvim.Size = New System.Drawing.Size(200, 22)
        Me.Takvim.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(69, 258)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 76)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Fontu Değiştir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(582, 353)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DiaryBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 600)
        Me.MinimumSize = New System.Drawing.Size(600, 400)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DiaryApp"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DosyaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KaydetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DiaryBox As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents HisButon1 As RadioButton
    Friend WithEvents HisButon2 As RadioButton
    Friend WithEvents HisButon3 As RadioButton
    Friend WithEvents HisButon4 As RadioButton
    Friend WithEvents HisButon5 As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents AçToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Takvim As DateTimePicker
    Friend WithEvents Button1 As Button
End Class
