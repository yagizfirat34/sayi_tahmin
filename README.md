<div align="center">

# 🎯 Sayı Tahmin Oyunu

### *1-100 arası sayıyı 7 hak ile tahmin et!*

<img src="https://readme-typing-svg.herokuapp.com?font=Fira+Code&size=22&duration=3000&pause=1000&color=FFD700&center=true&vCenter=true&width=435&lines=7+Hakk%C4%B1n+Var!;1-100+Aras%C4%B1+Say%C4%B1+Tahmin+Et;Ak%C4%B1ll%C4%B1+Tahmin+Sistemi;Ses+Efektleri+%26+M%C3%BCzik;Windows+Forms+Oyunu" alt="Typing SVG" />

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=.net&logoColor=white)
![Windows](https://img.shields.io/badge/Windows-0078D6?style=for-the-badge&logo=windows&logoColor=white)
![Game](https://img.shields.io/badge/Game-FF6B6B?style=for-the-badge&logo=gamepad&logoColor=white)

</div>

---

## 🎮 Nedir?

Klasik sayı tahmin oyununun **modern** ve **eğlenceli** Windows Forms versiyonu! Bilgisayar 1-100 arasında bir sayı tutar, sen de **7 hak** içinde tahmin etmeye çalışırsın.

<div align="center">

### ⚡ Hızlı Bakış

| 🎯 Özellik | 📝 Açıklama |
|-----------|------------|
| **7 Can Sistemi** | Her yanlış tahminde 1 can kaybedersin |
| **Akıllı İpuçları** | "Daha büyük ↑" veya "Daha küçük ↓" yönlendirmesi |
| **Tahmin Geçmişi** | Tüm tahminlerin listede görünür |
| **Ses Efektleri** | Arka plan müziği ve oyun sesleri |
| **Görsel Canlar** | Can durumunu görsel olarak takip et |
| **Kazanma/Kaybetme Ekranları** | Özel sonuç ekranları |

</div>

---

## 🌟 Özellikler

```
🎯 1-100 Arası Tahmin        ❤️ 7 Can Sistemi
📊 Tahmin Geçmişi            🎵 Müzik & Ses Efektleri  
⬆️ Akıllı Yönlendirme        🎨 Modern Arayüz
🏆 Kazanma Ekranı            💀 Kaybetme Ekranı
🔄 Tekrar Oynama             ⌨️ Enter Tuşu Desteği
```

---

## 🎮 Nasıl Oynanır?

<div align="center">

```mermaid
graph TD
    A[🏠 Ana Menü] -->|Oyna| B[🎯 Oyun Başla]
    B -->|Sayı Gir| C{Doğru mu?}
    C -->|✅ Evet| D[🏆 Kazandın!]
    C -->|❌ Hayır| E{Can Kaldı mı?}
    E -->|Evet| F[💡 İpucu Ver]
    F -->|Tekrar Tahmin| C
    E -->|Hayır| G[💀 Kaybettin!]
    D -->|Tekrar Oyna| B
    G -->|Tekrar Oyna| B
    style A fill:#FFD700
    style D fill:#4CAF50
    style G fill:#F44336
    style C fill:#2196F3
```

</div>

### 📋 Adım Adım

1. **🎬 Oyunu Başlat** → Ana menüden "Oyna" butonuna tıkla
2. **🎲 Başla** → "Başla" butonuna basarak oyunu başlat
3. **🔢 Tahmin Et** → 1-100 arası bir sayı gir
4. **💡 İpuçlarını Takip Et** 
   - ↑ **Daha büyük** → Tuttuğum sayı senin tahminden büyük
   - ↓ **Daha küçük** → Tuttuğum sayı senin tahminden küçük
5. **❤️ Canlarını Koru** → 7 yanlış hakkın var!
6. **🏆 Kazan veya 💀 Kaybet** → Sonuç ekranında tekrar oynayabilirsin

---

## 🎯 Oyun Mekanikleri

<div align="center">

### 🧠 Akıllı Özellikler

| Özellik | Açıklama |
|---------|----------|
| **🚫 Tekrar Kontrol** | Aynı sayıyı iki kez giremezsin |
| **✅ Geçerlilik Kontrolü** | Sadece 1-100 arası sayılar kabul edilir |
| **📝 Tahmin Listesi** | Tüm tahminlerin ok işaretleriyle gösterilir |
| **⌨️ Enter Desteği** | Enter tuşuyla hızlı tahmin |
| **🎵 Dinamik Müzik** | Her ekranın kendi müziği var |
| **🔄 Kolay Reset** | Sonuç ekranından hızlıca tekrar oyna |

</div>

---

## 🛠️ Teknik Detaylar

<div align="center">

![Tech Stack](https://skillicons.dev/icons?i=cs,dotnet,visualstudio,windows)

</div>

### 💻 Teknolojiler

- **Dil:** C# 
- **Framework:** .NET Framework 4.7.2
- **UI:** Windows Forms
- **Ses:** System.Media.SoundPlayer
- **IDE:** Visual Studio

### 📁 Proje Yapısı

```
sayi_tahmin/
│
├── 📄 Form1.cs                    # Ana oyun ekranı
├── 📄 mainMenu.cs                 # Ana menü ekranı
├── 📄 KazanmaEkrani.cs           # Kazanma ekranı
├── 📄 son_EkranKaybet.cs         # Kaybetme ekranı
├── 📄 global.cs                   # Global değişkenler
├── 🎵 sesler/                     # Ses dosyaları klasörü
│   ├── Guessing-Grid.wav         # Oyun müziği
│   └── Pixel-Guess-Parade.wav    # Menü müziği
└── 📄 README.md                   # Bu dosya
```







## 📸 Ekran Görüntüleri

<div align="center">

### 🏠 Ana Menü
*Oyuna hoş geldin! Müzik eşliğinde başla*

![Ana Menü](https://via.placeholder.com/600x400/FFD700/000000?text=ANA+MEN%C3%9C+-+OYNA+BUTONU)

---

### 🎯 Oyun Ekranı
*7 can, tahmin listesi ve ipuçları*

![Oyun Ekranı](https://via.placeholder.com/600x400/2196F3/FFFFFF?text=OYUN+EKRANI+-+7+CAN+S%C4%B0STEM%C4%B0)

---

### 🏆 Kazanma Ekranı
*Tebrikler! Sayıyı buldun!*

![Kazanma](https://via.placeholder.com/600x400/4CAF50/FFFFFF?text=KAZANDIN!+%F0%9F%8F%86)

---

### 💀 Kaybetme Ekranı
*Canların bitti! Tekrar dene*

![Kaybetme](https://via.placeholder.com/600x400/F44336/FFFFFF?text=KAYBETT%C4%B0N!+%F0%9F%92%80)

</div>

---

## 🎓 Öğrenme Kaynakları

Bu projede kullanılan kavramlar:

- ✅ **Windows Forms** → GUI oluşturma
- ✅ **Random Sınıfı** → Rastgele sayı üretimi
- ✅ **List<T>** → Tahmin geçmişi saklama
- ✅ **SoundPlayer** → Ses dosyası oynatma
- ✅ **Event Handling** → Buton tıklama, klavye olayları
- ✅ **Form Geçişleri** → Ekranlar arası navigasyon
- ✅ **Global Variables** → Ekranlar arası veri paylaşımı

---


---

## 🐛 Bilinen Özellikler

- ✅ Aynı sayı tekrar girilemez
- ✅ Sadece 1-100 arası sayılar kabul edilir
- ✅ Geçersiz giriş kontrolü (harf, sembol vb.)
- ✅ Can sistemi görsel olarak takip edilebilir
- ✅ Müzik otomatik döngüde çalar

---




<div align="center">
