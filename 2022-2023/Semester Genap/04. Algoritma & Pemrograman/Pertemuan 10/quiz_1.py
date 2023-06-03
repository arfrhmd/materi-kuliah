def hitung_pecahan(jumlah_uang):
    uang_pecahan = [
        50000, 20000, 10000,
        5000, 2000, 1000
    ]
    hasil_pecahan = {}
    
    for pecahan in uang_pecahan:
        count = 0
        while jumlah_uang >= pecahan:
            count += 1
            jumlah_uang -= pecahan
        hasil_pecahan[pecahan] = count
    
    return hasil_pecahan
  
  
if __name__ == "__main__":
    uang = int(input("Masukkan jumlah uang : "))
    hasil_pecahan = hitung_pecahan(uang)
    
    for pecahan, jumlah in hasil_pecahan.items():
        print(f"Jumlah pecahan {pecahan} : {jumlah}")
