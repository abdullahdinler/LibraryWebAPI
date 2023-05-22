# Kütüphane API
NLayerAPP kursunda işlenen konuları tekrarı ve pekiştirilmesi için oluşturulan Kütüphane API ptojesidir.

Kütüphane API, bir kütüphane sisteminde kitapları, yazarları, türleri, kullanıcıları, ödünç alınan kayıtları ve iade edilen kayıtları yönetmek için işlevsellik sağlayan bir web uygulamasıdır. Kullanıcılara kitapları, yazarları ve kullanıcıları eklemek, güncellemek ve silmek gibi çeşitli işlemleri gerçekleştirme imkanı sunar. Ayrıca kitap ödünç alma ve iade etme gibi işlemleri de gerçekleştirebilirsiniz.

API aşağıdaki teknolojiler ve çerçeveler kullanılarak oluşturulmuştur:

<li>ASP.NET Core: Web uygulamaları geliştirmek için çok platformlu bir çerçeve.</li>
<li>Entity Framework Core: Nesne-tabanlı bir eşleştirici (ORM) kullanarak veritabanı işlemlerini yönetir.</li>
<li>MS SQL Server: İlişkisel veritabanı yönetim sistemi olarak kullanılır.</li>
<li>AutoFac: .NET uygulamalarında yaygın olarak kullanılan bir bağımlılık enjeksiyonu konteyneri.</li>
<li>Uygulama, katmanlı mimariyi takip eder ve veritabanı işlemleri için Birim İşlem desenini kullanır. Ayrıca yaygın CRUD (oluşturma, okuma, güncelleme, silme) işlemleri için Generic Repository kullanılır. AutoMapper da kullanarak veri transfer nesneleri (DTO'lar) arasında veri dönüşümlerini kolaylaştırır.</li>


</br>

API Kullanımı
API'yi kullanmak için aşağıdaki adımları izleyebilirsiniz:

Bir API istemcisi (örneğin, Postman) kullanarak API endpoint'lerine istekler gönderin veya bir web tarayıcısı kullanarak doğrudan erişim sağlayın.

Kitaplarla ilgili işlemler için /books endpoint'ini kullanın. Örneğin:

<li>Tüm kitapları almak için GET /books</li>
<li>Bir kitabı almak için GET /books/{id}</li>
<li>Yeni bir kitap eklemek için POST /books</li>
<li>Bir kitabı güncellemek için PUT /books/{id}</li>
<li>Bir kitabı silmek için DELETE /books/{id}</li>
</br>

Yazarlarla ilgili işlemler için /authors endpoint'ini kullanın. Örneğin:

<li>Tüm yazarları almak için GET /authors</li>
<li>Bir yazarı almak için GET /authors/{id}</li>
<li>Yeni bir yazar eklemek için POST /authors</li>
<li>Bir yazarı güncellemek için PUT /authors/{id}</li>
<li>Bir yazarı silmek için DELETE /authors/{id}</li>
Diğer varlık türleri (örneğin, türler, kullanıcılar, ödünç alınan kayıtlar) için ilgili endpoint'leri kullanın ve ilgili işlemleri gerçekleştirin.

Api Görsel:
![Screenshot_1](https://github.com/abdullahdinler/LibraryWebAPI/assets/71527576/a655a3ea-6800-416d-8cfd-362481c66df3)

