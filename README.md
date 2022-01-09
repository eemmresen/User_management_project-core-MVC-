# User_management_project-core-MVC-

.NET MVC Projesi

MVC üzerinde basit bir kullanıcı
yönetim projesi yapılacaktır.
Projede yeni kayıt, login, güncelleme, listeleme, ve silme işlemlerini gerçekleştirebilmeliyiz.
Kullanıcılar için user ve admin olarak 2 rol oluşturulacaktır. Roller enum üzerinden
yönetilmelidir.
Admin grubuna dahil olan kullanıcılar kayıt listeleme güncelleme ve silme sayfalarına
erişlebilmeli ve işlemleri yapabilmelidir.
User grubuna dahil olan kullanıcı kayıt ve listeleme ekranlarına erişebilmeli yeni kullanıcı
oluşturabilmedir.
Default bir admin kullanıcı öncelikli olarak tanımlı olmalıdır, default admin kullanıcısını
oluşturmak için ihtiyaç duyulacak sql script projeye eklenmelidir.
Login Ekranı:
• Kullanıcı adı ve şifresi ile login işlemi yapılmalı, alanların boş olması, kayıtlı olmayan
kullanıcı adı , yada şifre hatalı gibi hatalar kullanıcılara görüntülenmelidir, başarılı
login işlemi sonrasında, kullanıcı listeleme ekranına yönlendirme yapılmalıdır.
Kullanıcı Listeleme Ekranı:
• Sistemde kayıtlı olan kullanıcıların listelendiği ekrandır.
• Yeni kullanıcı kaydı için bir buton bulunmalıdır. ( Kullanıcı ekle )
• Kullanıcılar tablo görünümünde listelenmelidir.
• Admin rolüne ait biri ekranda ilgili kullanıcı satırlarının sonunda güncelle ve sil
butonları görmelidir.
Kayıt Ekranı:
• Kullanıcı girişinin yapılacağı ekrandır.
• Kullanıcı ekle butonu ile kayıt ekranı açılmalıdır.
• Kayıt işlemi ve İşlem yapmadan çıkabilmek için Kaydet ve İptal butonu olmalıdır.
• KullanıcıID, şifresi, adı, soyadı, email adresi, telefon numarası, doğum tarihi gibi
alanlar bulunmalı ve boş data girişi, mail, telefon numarası, doğum tarihi alanları
validasyondan geçirilmelidir. Hatalı girişler hakkında kullanıcıya hata mesajları
gösterilmelidir.
• Başarılı işlem sonrasında kullanıcı bir popup ile bilgilendirilmelidir.
• Kayıt işlemlerinde kullanıcıID unique olmalıdır.
Güncelleme Ekranı:
• Kullanıcı bilgilerinin güncelleneceği ekrandır.
• Güncelle butonuna basıldığında bir Modal Dialog (tercihen) çıkartılabilir veya yeni bir
ekrana yönlendirilebilir.
• KullanıcıID dışındaki diğer bilgiler istenirse güncellenebilmelidir, kullanıcı id
değiştirilemez olmalıdır.

• Güncelleme işlemi ve işlem yapmadan çıkabilmek için Güncelle ve İptal butonu
olmalıdır.
• Kayıt işlemi sırasında geçerli olan validasyonlar ve bilgilendirmeler bu ekranda da
yapılmalıdır.
Silme Ekranı/İşlemi:
• Kullanıcıların listelendiği tabloda bir butona basılarak kullanıcılar silinebilir.
• Bu butona basıldığında confirmation dialog ile onay sorulmalıdır ve ardından
kullanıcı datası db'den silinebilir.

Projede dikkat edilecek noktalar:
• Object Oriented prensiplerine uygun proje geliştirilmelidir.
• Data Access katmanında ORM araçlarından biri kullanılmalıdır.
• Veri tabanı olarak MsSQL veya MySQL kullanılabilir.
• Projede AJAX post yada get örnekleri olmalıdır (Tüm işlemlerini AJAX ile
yapmak zoruna değilsiniz). Client tarafında bir ajax isteği oluştuğunda bu işlemin
durumunu kullanıcıya bilgi veren bir loading box göstermelisiniz.
• CSS ve JS dosyaları ayrı dosyalar olarak yüklenmeli, inline css den kaçınılmalıdır.
Code Quality, Validations, Security, Design Patterns gibi genel kodlama pratikleri
değerlendirilecektir. Projeyi github üzerinden paylaşmalısınız.
