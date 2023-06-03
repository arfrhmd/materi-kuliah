Module Module1

    Structure mhs
        Dim nim As String
        Dim nama As String
        Dim nilai As String
    End Structure

    Sub Main()
        Console.WriteLine("materi tentang record / struktur")
        Console.WriteLine("================================")
        Dim newmhs As mhs
        Console.Write("Ketik NIM" + Chr(9) + ": ")
        newmhs.nim = Console.ReadLine()
        Console.Write("Ketik nama" + Chr(9) + ": ")
        newmhs.nama = Console.ReadLine()
        Console.Write("Ketik nilai" + Chr(9) + ": ")
        newmhs.nilai = Console.ReadLine()
        Console.WriteLine()
        Console.WriteLine("Hasil data" + Chr(9) + ": " + newmhs.nim + " " + newmhs.nama + " " + newmhs.nilai)

        Console.Read()
    End Sub

End Module
