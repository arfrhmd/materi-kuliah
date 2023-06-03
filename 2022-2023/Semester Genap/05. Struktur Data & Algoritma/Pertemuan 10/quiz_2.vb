Public Class Form1

    Structure mhs
        Dim nim As String
        Dim nama As String
        Dim nilai As Integer
        Dim mutu As String
        Dim keterangan As String
    End Structure

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Sub rata2()
        On Error Resume Next
        Dim x As Integer
        For baris As Integer = 0 To dgv1.RowCount - 1
            x = x + dgv1.Rows(baris).Cells(2).Value
        Next
        txtAverage.Text = x
        txtAverage.Text = txtAverage.Text / (dgv1.RowCount - 1)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim newmhs As mhs
            newmhs.nim = txtNim.Text
            newmhs.nama = txtNama.Text
            newmhs.nilai = Convert.ToInt32(txtNilai.Text)

            If newmhs.nilai > 90 Then
                newmhs.mutu = "A"
            ElseIf newmhs.nilai > 75 Then
                newmhs.mutu = "B"
            ElseIf newmhs.nilai > 60 Then
                newmhs.mutu = "C"
            ElseIf newmhs.nilai > 50 Then
                newmhs.mutu = "D"
            Else
                newmhs.mutu = "E"
            End If

            If newmhs.mutu = "A" Or newmhs.mutu = "B" Or newmhs.mutu = "C" Then
                newmhs.keterangan = "Lulus"
            Else
                newmhs.keterangan = "Gagal"
            End If

            'Insert data to DataGridView
            dgv1.Rows.Add(newmhs.nim, newmhs.nama, newmhs.nilai, newmhs.mutu, newmhs.keterangan)

            'Clear data
            txtNim.Clear()
            txtNama.Clear()
            txtNilai.Clear()
            txtNim.Focus()

            'Memanggil fungsi rata2()
            Call rata2()
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        dgv1.Rows.Clear()
        txtAverage.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
