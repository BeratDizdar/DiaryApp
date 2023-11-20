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
        Me.TextBox = New System.Windows.Forms.TextBox()
        Me.HisYazısı = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.HisButon1 = New System.Windows.Forms.RadioButton()
        Me.HisButon2 = New System.Windows.Forms.RadioButton()
        Me.HisButon3 = New System.Windows.Forms.RadioButton()
        Me.HisButon4 = New System.Windows.Forms.RadioButton()
        Me.HisButon5 = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DosyaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(622, 30)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DosyaToolStripMenuItem
        '
        Me.DosyaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KaydetToolStripMenuItem})
        Me.DosyaToolStripMenuItem.Name = "DosyaToolStripMenuItem"
        Me.DosyaToolStripMenuItem.Size = New System.Drawing.Size(64, 26)
        Me.DosyaToolStripMenuItem.Text = "Dosya"
        '
        'KaydetToolStripMenuItem
        '
        Me.KaydetToolStripMenuItem.Name = "KaydetToolStripMenuItem"
        Me.KaydetToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.KaydetToolStripMenuItem.Text = "Kaydet"
        '
        'TextBox
        '
        Me.TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox.Font = New System.Drawing.Font("Cascadia Mono SemiBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBox.Location = New System.Drawing.Point(298, 69)
        Me.TextBox.Multiline = True
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Size = New System.Drawing.Size(312, 369)
        Me.TextBox.TabIndex = 1
        Me.TextBox.Text = "Gününü burada not alabilirsin."
        Me.ToolTip1.SetToolTip(Me.TextBox, "Günlük Not Yeri")
        '
        'HisYazısı
        '
        Me.HisYazısı.AutoSize = True
        Me.HisYazısı.Font = New System.Drawing.Font("Cascadia Mono SemiBold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.HisYazısı.Location = New System.Drawing.Point(12, 42)
        Me.HisYazısı.Name = "HisYazısı"
        Me.HisYazısı.Size = New System.Drawing.Size(43, 24)
        Me.HisYazısı.TabIndex = 2
        Me.HisYazısı.Text = "His"
        '
        'HisButon1
        '
        Me.HisButon1.AutoSize = True
        Me.HisButon1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.HisButon1.Font = New System.Drawing.Font("Cascadia Mono SemiBold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.HisButon1.Location = New System.Drawing.Point(12, 69)
        Me.HisButon1.Name = "HisButon1"
        Me.HisButon1.Size = New System.Drawing.Size(117, 29)
        Me.HisButon1.TabIndex = 3
        Me.HisButon1.TabStop = True
        Me.HisButon1.Text = "Çok İyi"
        Me.HisButon1.UseVisualStyleBackColor = True
        '
        'HisButon2
        '
        Me.HisButon2.AutoSize = True
        Me.HisButon2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.HisButon2.Font = New System.Drawing.Font("Cascadia Mono SemiBold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.HisButon2.Location = New System.Drawing.Point(12, 104)
        Me.HisButon2.Name = "HisButon2"
        Me.HisButon2.Size = New System.Drawing.Size(73, 29)
        Me.HisButon2.TabIndex = 4
        Me.HisButon2.TabStop = True
        Me.HisButon2.Text = "İyi"
        Me.HisButon2.UseVisualStyleBackColor = True
        '
        'HisButon3
        '
        Me.HisButon3.AutoSize = True
        Me.HisButon3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.HisButon3.Font = New System.Drawing.Font("Cascadia Mono SemiBold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.HisButon3.Location = New System.Drawing.Point(12, 139)
        Me.HisButon3.Name = "HisButon3"
        Me.HisButon3.Size = New System.Drawing.Size(150, 29)
        Me.HisButon3.TabIndex = 5
        Me.HisButon3.TabStop = True
        Me.HisButon3.Text = "Fena Değil"
        Me.HisButon3.UseVisualStyleBackColor = True
        '
        'HisButon4
        '
        Me.HisButon4.AutoSize = True
        Me.HisButon4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.HisButon4.Font = New System.Drawing.Font("Cascadia Mono SemiBold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.HisButon4.Location = New System.Drawing.Point(12, 174)
        Me.HisButon4.Name = "HisButon4"
        Me.HisButon4.Size = New System.Drawing.Size(84, 29)
        Me.HisButon4.TabIndex = 6
        Me.HisButon4.TabStop = True
        Me.HisButon4.Text = "Kötü"
        Me.HisButon4.UseVisualStyleBackColor = True
        '
        'HisButon5
        '
        Me.HisButon5.AutoSize = True
        Me.HisButon5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.HisButon5.Font = New System.Drawing.Font("Cascadia Mono SemiBold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.HisButon5.Location = New System.Drawing.Point(12, 209)
        Me.HisButon5.Name = "HisButon5"
        Me.HisButon5.Size = New System.Drawing.Size(128, 29)
        Me.HisButon5.TabIndex = 7
        Me.HisButon5.TabStop = True
        Me.HisButon5.Text = "Çok Kötü"
        Me.HisButon5.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(622, 450)
        Me.Controls.Add(Me.HisButon5)
        Me.Controls.Add(Me.HisButon4)
        Me.Controls.Add(Me.HisButon3)
        Me.Controls.Add(Me.HisButon2)
        Me.Controls.Add(Me.HisButon1)
        Me.Controls.Add(Me.HisYazısı)
        Me.Controls.Add(Me.TextBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(640, 497)
        Me.MinimumSize = New System.Drawing.Size(640, 497)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DiaryApp"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DosyaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KaydetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox As TextBox
    Friend WithEvents HisYazısı As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents HisButon1 As RadioButton
    Friend WithEvents HisButon2 As RadioButton
    Friend WithEvents HisButon3 As RadioButton
    Friend WithEvents HisButon4 As RadioButton
    Friend WithEvents HisButon5 As RadioButton
End Class
