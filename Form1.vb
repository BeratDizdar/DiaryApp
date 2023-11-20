Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Form1

    Dim userName As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HisYazısı.Text = "Kendini Nasıl Hissediyorsun?"
        userName = InputBox("Adın nedir?", "İsim Öğrenme", "O")
    End Sub
    Private Sub HisButon1_CheckedChanged(sender As Object, e As EventArgs) Handles HisButon1.CheckedChanged
        HisYazısı.Text = userName & " kendini çok iyi hissediyor"
    End Sub
    Private Sub HisButon2_CheckedChanged(sender As Object, e As EventArgs) Handles HisButon2.CheckedChanged
        HisYazısı.Text = userName & " kendini iyi hissediyor"
    End Sub
    Private Sub HisButon3_CheckedChanged(sender As Object, e As EventArgs) Handles HisButon3.CheckedChanged
        HisYazısı.Text = userName & " kendini fena hissetmiyor"
    End Sub
    Private Sub HisButon4_CheckedChanged(sender As Object, e As EventArgs) Handles HisButon4.CheckedChanged
        HisYazısı.Text = userName & " kendini kötü hissediyor :("
    End Sub
    Private Sub HisButon5_CheckedChanged(sender As Object, e As EventArgs) Handles HisButon5.CheckedChanged
        HisYazısı.Text = userName & " kendini çok kötü hissediyor :("
    End Sub

    Private Sub KaydetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KaydetToolStripMenuItem.Click
        Dim saveFileDialog1 As New SaveFileDialog With {
            .FileName = "GünlükDosyası",
            .Filter = "Metin Dosyaları|*.txt|Tüm Dosyalar|*.*"
        }
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim dosyaYolu As String = saveFileDialog1.FileName

            Dim dosya As System.IO.StreamWriter
            dosya = My.Computer.FileSystem.OpenTextFileWriter(dosyaYolu, True, System.Text.Encoding.UTF8)

            dosya.WriteLine(HisYazısı.Text & " bugün." & Environment.NewLine & "BUGUN NE OLDU: " & TextBox.Text)

            dosya.Close()

            MessageBox.Show("Metin dosyaya başarıyla kaydedildi!",
                            "Bilgi", MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        Else
            MessageBox.Show("Kayıt Başarısız", "Dikkat",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

End Class
