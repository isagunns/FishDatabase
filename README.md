Bu program, Ege Denizi'ndeki balıklara ait bilgileri toplamak ve çeşitli veri yapıları ile bu bilgileri işlemek için tasarlanmıştır. Kod, aşağıdaki başlıca bileşenlere ve işlevselliğe sahiptir:

Balık Verisi ve Ağaç Yapıları:

Balıkların bilgileri bir metin dosyasından alınır ve her balık için EgeDeniziB sınıfı kullanılarak nesneler oluşturulur.
BinaryTree sınıfı kullanılarak, bu balık nesneleri ikili ağaç yapısına yerleştirilir.
Balıkların ismi ve diğer bilgileri bir ağaca eklenir ve sıralı bir şekilde ekrana yazdırılır.
Kullanıcıya ağacın derinliği ve düğüm sayısı hakkında bilgi verilir.
Balıkların Harf Aralığında Arama:

Kullanıcıya belirli bir harf aralığındaki balıkları sorgulama imkanı tanınır. Kullanıcı, baş harfleri belirleyerek arama yapabilir ve bu harfler arasında kalan balıkları listeler.
Dengeli Ağaç Yapısı (Özyineli):

Balık nesneleri alfabetik sıraya göre sıralanır ve bir "dengeli ikili arama ağacı" oluşturulur. Bu ağacın sıralı bir biçimde yazdırılması sağlanır.
Hash Table (Sözlük) Kullanımı:

Balık bilgileri bir hash tablosuna (Dictionary) eklenir ve kullanıcıya balıkların bilgilerine hızlı erişim sağlanır.
Kullanıcı, hash tablosundaki balıkların bilgisini güncelleyebilir.
Max Heap (Öncelik Kuyruğu) Kullanımı:

Balıklar, MaxHeap sınıfı kullanılarak bir öncelik kuyruğunda saklanır. Heap yapısı, balıkları belirli bir düzende (en büyük öğe en üstte) saklamak için kullanılır.
Heap yapısındaki en büyük öğe (balık) alınır ve alt ağaçları yazdırılır.
Sıralama Algoritmaları:

Insertion Sort ve Merge Sort algoritmaları ile örnek diziler sıralanır.
Kullanıcıya her iki sıralama algoritmasının nasıl çalıştığı gösterilir.
Çalışma Zamanı Hesaplamaları:

Rastgele oluşturulmuş 100 elemanlı diziler üzerinde sıralama algoritmalarının çalışma süreleri ölçülür.
Her iki sıralama algoritmasının (Insertion Sort ve Merge Sort) sıralama süresi karşılaştırılır.
