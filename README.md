### SignalR
SignalR, ASP.NET Core için geliştirilmiş bir kütüphanedir ve web uygulamaları ile sunucular arasında gerçek zamanlı iletişim kurmayı sağlar. SignalR, sunucu ile istemci arasındaki bağlantıyı sürekli açık tutar ve sunucunun istemcilere anında bildirim gönderebilmesine olanak tanır. Bu özellik, anlık mesajlaşma uygulamaları, canlı sohbet sistemleri, gerçek zamanlı veri gösterimleri ve canlı güncellemeler gibi senaryolar için oldukça kullanışlıdır.

### SignalR'ın Temel Özellikleri

1. **Gerçek Zamanlı İletişim:** SignalR, sunucu ve istemci arasında gerçek zamanlı veri iletişimini destekler. Bu sayede, sunucu bir olay gerçekleştiğinde istemcilere anında bildirim gönderebilir.

2. **Transport Seçenekleri:** SignalR, tarayıcı uyumluluğunu artırmak için çeşitli veri iletim protokollerini destekler:
   - **WebSockets:** En hızlı ve en verimli protokol, desteklendiği her durumda kullanılır.
   - **Server-Sent Events:** WebSockets desteklenmiyorsa, modern tarayıcılarda kullanılabilir.
   - **Long Polling:** Daha eski tarayıcılar veya proxy sunucular için yedek bir yöntemdir.

3. **Grup ve Kullanıcı Tabanlı Mesajlaşma:** SignalR, istemcileri gruplara ekleyerek grup tabanlı mesajlaşma desteği sunar. Ayrıca, belirli bir kullanıcıya mesaj göndermeyi de destekler.

4. **Hub Yapısı:** SignalR, sunucu tarafında `Hub` adı verilen sınıflar kullanarak istemcilerle etkileşime girer. Hub sınıfı, istemciler tarafından çağrılabilecek yöntemler ve sunucu tarafında istemcilerin dinleyebileceği olaylar tanımlar.

5. **Bağlantı Yönetimi:** SignalR, istemci bağlantılarını yönetir, bağlantı durum değişikliklerini izler ve kullanıcı bağlantılarını kolayca yönetebilmenizi sağlar.

### SignalR'ın Kullanım Alanları

- **Canlı Sohbet Uygulamaları:** Kullanıcılar arasında anlık mesajlaşma.
- **Gerçek Zamanlı Oyunlar:** Oyunların gerçek zamanlı veri alışverişi yapması.
- **Gerçek Zamanlı Gösterge Panelleri:** Finansal piyasalar, spor skorları veya canlı veri gösterimleri.
- **Anında Bildirimler:** Bildirimlerin tarayıcı veya uygulama üzerinden kullanıcılara anında gönderilmesi.
- **İşbirliği Uygulamaları:** Gerçek zamanlı doküman düzenleme veya beyaz tahta uygulamaları.

SignalR, web uygulamalarında daha dinamik ve etkileşimli kullanıcı deneyimleri oluşturmanıza olanak tanıyan güçlü bir araçtır. Hem sunucu hem de istemci tarafında basit bir yapı sunar ve çok çeşitli platformlarla uyumlu çalışır.
Kaynak: [ChatCPT](https://chatgpt.com/)
# Ekran Görüntüsü

![info](https://github.com/user-attachments/assets/ac5d62af-488c-4f08-a549-db20d211c97f)

