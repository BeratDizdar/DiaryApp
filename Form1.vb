Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Newtonsoft.Json

Public Class Form1
    Private Class HisDurumu
        Public Property His As String
        Public Property Metin As String
        Public Property Tarih As DateTime
    End Class

    Private Sub KaydetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KaydetToolStripMenuItem.Click
        Dim saveFileDialog1 As New SaveFileDialog With {
            .FileName = "GünlükDosyası",
            .Filter = "JSON dosyaları|*.json"
        }
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim dosyaYolu As String = saveFileDialog1.FileName
            Dim secilenHis As String = ""

            If HisButon1.Checked Then
                secilenHis = "Çok İyi"
            ElseIf HisButon2.Checked Then
                secilenHis = "İyi"
            ElseIf HisButon3.Checked Then
                secilenHis = "Fena Değil"
            ElseIf HisButon4.Checked Then
                secilenHis = "Kötü"
            ElseIf HisButon5.Checked Then
                secilenHis = "Çok kötü"
            End If

            Dim hisBilgi As New HisDurumu With {
                .Tarih = Takvim.Value,
                .Metin = DiaryBox.Text,
                .His = secilenHis
            }

            File.WriteAllText(dosyaYolu, JsonConvert.SerializeObject(hisBilgi))

            MessageBox.Show("Günlük başarıyla kaydedildi.")
        End If
    End Sub

    Private Sub AçToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AçToolStripMenuItem.Click
        Dim openFileDialog1 As New OpenFileDialog With {
            .FileName = "GünlükDosyası",
            .Filter = "JSON dosyaları|*.json"
        }
        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim dosyaYolu As String = openFileDialog1.FileName

            If File.Exists(dosyaYolu) Then
                Dim jsonVeri As String = File.ReadAllText(dosyaYolu)

                Dim okunanHisBilgisi As HisDurumu = JsonConvert.DeserializeObject(Of HisDurumu)(jsonVeri)

                DiaryBox.Text = okunanHisBilgisi.Metin

                Takvim.Value = okunanHisBilgisi.Tarih

                Select Case okunanHisBilgisi.His
                    Case "Çok İyi"
                        HisButon1.Checked = True
                    Case "İyi"
                        HisButon2.Checked = True
                    Case "Fena Değil"
                        HisButon3.Checked = True
                    Case "Kötü"
                        HisButon4.Checked = True
                    Case "Çok kötü"
                        HisButon5.Checked = True
                End Select

                MessageBox.Show($"Günlük içeriği ve his durumu başarıyla açıldı.", "Günlük Aç", MessageBoxButtons.OK)
            Else
                MessageBox.Show("Dosya bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using fontDialog As New FontDialog()
            ' Kullanıcıya font seçme penceresini göster
            If fontDialog.ShowDialog() = DialogResult.OK Then
                ' Seçilen fontu metin kutusuna uygula
                DiaryBox.Font = fontDialog.Font
            End If
        End Using
    End Sub
End Class

