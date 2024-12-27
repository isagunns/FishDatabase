using System.Xml.Linq;
using System.Diagnostics;

namespace proje3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //balık bilgileri olan metin
            string metin =
                """
                1. Akya Balıgı
                Carangida familyasının bir üyesi olan akya balığı, boyutları ve zevkli avcılığı ile olta balıkçılarının avlanırken en çok heyecanlandığı deniz balıklarından biridir. Akya olarak bilinen bu tür, aynı zamanda liça balığı olarak da adlandırılır.

                Maksimum yetişkin boyutları, 200 cm uzunluk ve 50 kg ağırlıktır. Ancak, genellikle Ege denizinde bulunanların 120 cm civarına kadar büyüdükleri görülmüştür.

                Üreme dönemleri olan Mayıs ve Ağustos arasında yumurtlamak için gittikleri nehir birleşimlerinde kefaller ve sardalyaları yiyerek güç toplarlar. Ana besinleri kefal yavrularıdır.

                Nehir ağızlarına yakın alanlarda daha küçük boyuttakiler bulunurken büyük boyutlu akyalar, 40-50 metre derinlikte ve kıyıya uzak olmayan alanlarda yaşar.
                $
                2. Yaygin Aslan Balıgı (Şeytan ateş balığı)

                Hint-Pasifik bölgesine özgü bir aslan balığı varyantı olan bu tür, bilimsel olarak Pterois miles olarak adlandırılmıştır. Benzerlikleri dolayısıyla kırmızı aslan balığı ile karışıtırılırlar.

                Hint-Pasifik bölgesinin yanı sıra ülkemiz sularından Ege denizinde de yaşadıkları biliniyor. Genel aslan balığı çeşitleri gibi bu tür de zehirli bir türdür.

                Sırtında toplamda 13 adet diken bulunur. Renkleri kırmızı, gri veya ten rengi tonlarındadır. Geceleri avlandıklarından gündüzleri pek aktif bir tür değillerdir. Küçük kabuklular ve balıklar ile beslenirler.

                Yetişkin boyutları 35 cm’ye kadar ulaşabilir. Ege balıkları arasında olsalar da yaygın olarak Kızıldeniz’de ve Endenozya sularında görülürler.
                $
                3. Barbunya (Barbun)

                Gerçek adı Barbunya balığı olsa da halk arasında Barbun adı ile bilinir. Mullidae familyasından olan bu türe Mullus barbatus bilimsel adı verilmiştir.

                Ege denizi gibi sıcak ve ılıman suların kıyıya yakın kumlu ve çamurlu bölgelerinde yaşarlar. Nadiren de olsa kayalık alanlarda görülmektedirler. Tekir balığına benzerlikleri ile bilinirler. Aradaki farkı anlamak için burun, göz altı ve sırt yüzgecine bakılmalıdır.

                Maksimum boyutları 40 cm’dir ancak, Ege Denizi bölgesindekiler genellikle 18-20 cm civarında olurlar. Ege balıkları arasında ticari öneme sahip, eti lezzetli balıklardandır.
                $
                4. Cipura

                Çipura balığı diğer adıyla Çupra, Ege denizi balık türleri arasında yer alsa da aslında Akdeniz bölgesinde de yaşarlar.

                Ilıman sulara sahip bölgelerin, kumlu ve çamurlu bölgelerinde yaşarlar. Zaman zaman nehir ağızları ve lagünlerde bulundukları da olur.

                200 gr ve üzeri olanlar Çipura, bunun altında olanlar ise Lidaki olarak isimlendirilir. Kuvvetli bir çeneye sahiptir ve bu sayede kabukluları kolayca yiyebilir.

                Avlanmak isteniyorsa yaz aylarında kıyıya yakın, kış aylarında 30-40 metre derinlikte avlanabilirler. Kışın boyut olarak daha iri Çipuralar daha derin noktalara inerler. Ticari değeri yüksek ve eti oldukça lezzetli ege denizi balıklarındandır.
                $
                5. Citari (Sarpa)

                Görüntü olarak Çipura balığına çok benzerdir. Halk arasında Sarpa balığı olarak bilinirler. Yüzeyden 70 metre derinliğe kadar uzanan yaşam alanları vardır.

                Maviye çalan gri renkli üst kısımları, gümüş renkli yan kısımları vardır. Maksimum olarak 51 cm uzunluk ölçülmüş olup, genellikle 15-30 cm civarında görülürler.

                Ege denizi balık türleri arasında ticari değeri yoktur. Yapılan araştırmalarda tam olarak tespit edilemese de balığın tükettiği bir alg neticesinde, sarpa yiyen insanlarda halüsinojenik balık sarhoşluğu denilen rahatsızlığa sebep olur.
                $
                6. Cizgili Hani Balıgı (Yazılı Hani)

                Hani balığı, Orfoz’un da içinde bulunduğu Serranidae familyasından ve Levreğin içinde bulunduğu Serraninae alt türünden bir balıktır. Bilimsel adı Serranus scriba’dır. Çizgili hani balığı Ege denizi balıkları arasında yer almaktadır ancak hani balıkları genel olarak Akdeniz ve Karadeniz’de yaygındırar.

                Ülkemiz denizlerinden Ege Denizi’ne özgü Çizgili hani, 5 ila 150 metre arasında yaşam alanına sahiptir. Gündüzleri kayalıkların oluşturduğu mağaralarda geçirirken, alacakaranlık ve geceleri avlanmak için ortaya çıkar.

                Genellikle yalnız yaşadıkları görülse de küçük sürüler halinde yüzdüklerine de rastlanmaktadır. Uzunlukları en fazla 25 cm’ye ulaşır. Kabuklular, kafadanbacaklılar ve küçük balıklar ile beslenir. Ticari değeri olmayan, eti lezzetli Ege balıklarından biridir.
                $
                7. Dikenli Vatoz

                Dikenli vatoz, Dasyatidae familyasından bir vatoz balığı türüdür. Akdeniz ve Karadeniz bölgelerimizde de görülen bu tür, daha fazla görülmesi sebebiyle Ege Denizi balık türleri arasında bulunmalıdır.

                Çok derin sularda değil, genellikle 60 metre civarı derinlikte ve çamurlu alanlarda yaşarlar. Ana besinleri dipte yaşayan kabuklu türleridir. Ek olarak yumuşakçalar, solucanlar ve küçük balıklarla da beslenir.

                Ege denizinde bulunan dikenli vatozlar, genellikle 40-45 cm civarında veya daha küçük boyuttadır. Tırtırlı kuyruk ve iğneleri yüzünden insanlar için tehlikeli balık türleri arasındadır. Ticari değeri yoktur.
                $
                8. Eskina

                Eşina balığı, Sciaenidae familyasından bir deniz balığı türüdür. Bilimsel adı Sciaena umbra olan bu tür, Akdeniz ve Ege Denizi bölgelerimizde bulunmaktadır. Eşkina balığı amatör avcılık yapanların sıklıkla karşılaştığı bir türdür.
                Yavru eşkinalar kıyı şeritlere yakın nehir ağızlarında yaşarken, yetişkinler 5 metre ile 200 metre arasında yaşarlar. Ege balıkları listemize dahil ettiğimiz eşkina, en fazla 60 cm boyuta ulaşabilir ancak, ülkemiz sularında genellikle 30-40 cm civarında görülürler.

                Bu balığı sıradışı kılan bir özelliği de vardır. Balığın kafasından, alın bölgesinden 1 cm çapında taş çıkar. Bilimsel olarak kanıtlanmamış olsa da bu taş limon ile eritilerek tüketildiğinde böbrek taşı rahatsızlığına iyi geldiği düşünülür.

                Ticari değer açısından orta seviyelerdedir. Genellikle balık lokanlarında servis edilen, lezzetli bir türdür.
                $
                9. Horozbina Balıgı

                Horozbina, Blenniidae familyasından 900 civarı alt türe sahip, hem tuzlu hem de tatlı sularda (küçük bir bölümü) yaşayan alt varyantlara sahip balık türlerinin ortak adıdır.

                Horozbina tür adı altında 150 farklı cins ve 900 civarı da varyant tanımlanmıştır. Tatlı su blennysi olarak bilinen bir türü, nadiren de olsa akvaryumlarda beslenmektedir.

                Genellikle küçük boyutlara sahip olabilen bu balığın, yılan balığına benzer varyantlarıyla 55 cm boyutuna ulaştığı görülmüştür. İri bir göz ve ağız yapısına sahiptir.

                Zamanlarının büyük kısmını deniz tabanında ve kayalık yarıklarında geçirirler. Ticari değeri olmayan, Akdeniz ve Ege Denizi balıklarından biridir.
                $
                10. Iskaroz (Papağan Balığı)

                Genellikle ılıman ve sıcak sulara sahip denizlerde yaşarlar. Bilimsel adı Sparisoma cretense olan tür Scaridae familyasındandır.

                Parlak renklere sahip bir balıktır. Görünüşü itibariyle sazan balığının tropik halini andırır. Papağan isminin verilmesi ağızlarının papağan gagasına benzemesindendir.

                Erkekler daha koyu tondaki renklere sahipken dişiler, kırmızı-turuncu tonlarındadır. Zamanlarının çoğu mercan resiflerinde geçer. Burada deniz yosunu ile beslenirler.

                Yetişkin dönemlerinde en fazla 50 cm olabilirler ancak, ülkemizdeki iskaroz balıkları 20-30 cm civarındadır. Ticari değeri bulunmayan iskarozun eti orta lezzettedir.
                $
                11. Iskorpit Balıgı

                İskorpit, Ege balıkları arasında zehirli türlerden biridir. Yüzgeçlerinde bulunan dikenlere dokunulduğunda kişiyi zehirler ve bölgede kızarıklık, şişlik görülür.

                Bu etki 2-3 gün devam eder. Amonyak kullanılarak tedavi edilebilir. Özellikle amatör balıkçılar tarafından kırlangıç balığı ile karıştırılıp yaralanmalara sebep olmaktadır. Tutulduğunda dikenlerine dokunmamaya dikkat edilmelidir.

                Kayıt edilmiş maksimum uzunluk 37 cm iken, ülkemiz sularında yetişkin olanları 20-25 cm civarında görülürler. Akdeniz, Karadeniz ve Ege denizi balık türlerinden biridir.

                İskorpit, zehirli balıklardan biri olsa da eti lezzetli olan ve barındırdığı vitamin ve yağlar ile insan sağlığına çok yararlı bir balıktır.
                $
                12. Isparoz (İspari Balığı)

                Sparidae familyasından olan isparinin bilimsel adı Diplodus annularis’dir. Bu balık genellikle ılıman sahil bölgelerine yakın alanlarda yaşar. Ege balıklarından biridir ve diğer denizlerimizde de bulunur.

                Maksimum 25 cm uzunluğa erişebilirler. Ülkemiz sularında 15-18 cm civarında ispariler bulunur. Sportif balıkçılıkta sevilen bir balık türüdür. Genç olanları kışın lagünlere giderek beslenirler. Karides, yavru balıklar ve kurtçuklar ana besinleridir.

                Ticari değeri düşüktür ve genellikle olta balıkçılığı ile avlanırlar. Eti lezzetli ve az kılçıklı bir balıktır.
                $
                13. Izmarit Balığı (İstrongilos)

                İzmarit balığı, Ege denizi balık türleri arasında yer alıyor ancak Akdeniz bölgelemizde daha yaygın bulunur. Bilimsel adı Spicara smaris olan izmarit, Sparidae familyasından bir deniz balığı türüdür.

                Ilık sulara sahip bölgelerin kayalık, çamurlu dip kısımlarında yaşamaktadır. En fazla 25 cm boyutuna (erkekler) ulaşan bu tür, ülkemizde genellikle 15 cm civarında görülür.

                Ülkemiz sularında iki tür izmarit yaşamaktadır; İstargilos ve Menekşe izmarit. Eti lezzetli bir balıktır ve genellikle önce pişirilip sonra ayıklanır.

                $
                14. Kalkan Balıgı

                Kalkan balığı (Scophthalmus maximus), gözleri vücudunun solunda olan, Scophthalmidae familyasından bir deniz balığı türüdür. Vücudunun sağını deniz tabanına yatmak için kullanır.

                Ülkemizin tüm denizlerinde yaşayan bir türdür. Yaşam alanları 20 metre ile 70 metre arasındadır. Tipik balık türlerinden farklı olarak yuvarlak bir vücuda sahiptir. Maksimum 1 metre uzunluğa erişebilirler. Ülkemiz denizlerinde ise yetişkinler 60-70 cm civarında görülür.

                Henüz yavruyken gözleri sağda ve solda ayrı durmaktadır. 8-10 cm civarına ulaştıklarında sağ göz vücutlarının sol tarafına kaymaya başlar.

                Ticari değeri yüksek, eti çok lezzetli ege balıkları arasındadır.

                $
                15. Karagoz Balıgı

                Karagöz balığının Çipura ile yakın akrabalığı bulunmaktadır. Sarmos, mırmır, sivri gaga gibi birkaç çeşidi vardır.

                Maksimum 50 cm boyutuna ulaşabilir. Ülkemizde Akdeniz, Karadeniz ve Ege Denizi bölgelerimizde yaşarlar. Bu bölgelerde yaygın olarak 25 cm civarında görülür. Kayalık, kumlu alanlarda yaşarlar.

                Görünüşü ile Çupra balığına benzemesinin yanı sıra lezzet olarak da benzerdir. Serin dönemlerde tüketimesi tavsiye edilir bu dönemlerde eti daha yağlı ve lezzetli olmaktadır.
                $
                16. Kolyoz Balıgı

                Uskumsugillerden olan kolyoz, Scombridae familyasından bir deniz balığıdır. Uskumruya çok benzeyen bir balıktır. Kuyruk yüzgecine bakılarak ayırt edilebilir. Bu türün kuyruk yüzgecinin ucu daha sivridir.

                Genç olanlar kıyılara yakın kumlu alanlar ve yosun yataklarında yaşarken, yetişkin olanlar daha açıkta derin sularda yaşar.

                Sürüler halinde yaşamlarını sürdürürler. En fazla 50 cm uzunluğa kadar büyüyebilir ancak ülkemiz sularında görülen yetişkinler ortalama 20-25 cm civarındadır. Eti lezzetli ege balıkları arasındadır.
                $
                17. Kirma Mercan

                Kırma mercan balığı (Pagellus erythrinus) çipura ailesinden, Sparidae familyası mensubu, Akdeniz ve Ege balıklarından biridir. Özellikle Akdeniz ülkelerinde bolca tüketilen lezzetli bir balık türüdür.

                İnce, oval yapıda bir vücuda sahip olan kırma mercan en fazla 50 cm boyutuna ulaşabilir. Genel olarak 15-30 cm arasında görülürler. Bu tür bir hermafrodittir; sonradan cinsiyet değiştirebilirler.

                Genellikle hayatlarının ilk yıllarında dişi, sonraki yıllarında ise erkek olurlar. Hepçil bir balıktır ve ana besinleri küçük balıklar ve omurgasızlardan oluşur. Akdeniz ülkelerinde ticari değere sahip, lezzetli bir balıktır.
                $
                18. Lahoz Balıgı (Grida balığı)

                Lahoz balığı Hani balıkları ailesinden, Ege ve Akdeniz bölgelerinde bulunan bir türdür. Bu tür iri ege balıkları arasındadır. En fazla 125 cm uzunluk ve 25 kg ağırlığa ulaşabilirler.
                Yaşam alanları 20-250 metre arasında kayalık, çakıllı ve taşlı alanlardır. Son derece yırtıcı etçil balıklardan biridir. Yiyebileceği her türlü balık, omurgasız ve kabuklu türleri ile beslenir.

                Orfoz balığı ile yakından akrabadır ve ticari değeri bulunduğu bölgeye göre değişir. Özellikle Akdeniz bölgesinde etinin lezzetli ile bilinir.

                Bu tür birkaç farklı isimle bilinir.
                $
                19. Levrek

                Birçoğumuzun da yakından tanıdığı Levrek balığı, Dicentrarchus familyasından bir balık türüdür. Bilimsel olarak ilk kez 1758 yılında Dicentrarchus labrax olarak tanımlanmıştır.

                Şimdiye kadar kayıt altına alınan en büyük boyutları 1m ve 12 kg olsa da yaygın olarak 50 cm ve 5 kg civarında görülürler. Akdeniz ve Ege başta olmak üzere tüm denizlerimizde yaşadıkları biliniyor.

                Haliçler, lagünler, akarsuların denize döküldüğü yerler ana yaşam alanlarıdır. Kısa bir süreliğine tatlı sulara geçtikleri de bilinmektedir (tatlı su levreklerinin dışında).

                Ticari değeri yüksek, etinin lezzetini kanıtlamış Ege denizi balık türlerinden biridir.
                $
                20. Lipsoz Balıgı

                Lipsoz balığı, görünümü ile iskorpit balığına benzeyen Scorpaenidae familyasından bir balık türüdür. Lipsos ismiyle de bilinen bu türün bilimsel adı Scorpaena scrofa’dır.

                Ülkemiz sularında Akdeniz ve Ege Denizi türlerinden biridir, Karadeniz bölgesinde bulunmaz. S. porcus türü Karadeniz bölgesinde görülebilir. İskorpit balığı gibi bu balık da zehirli balıklardan biridir.

                Vücut rengi kiremit rengi tonlarından, pembemsi tonlara kadar değişebilir. En fazla 50 cm ve 3 kg ağırlığa ulaştığı biliniyor ancak, sularımızdaki yetişkin lipsoz balıkları genellikle 25-30 cm civarındadır.

                Yenilebilir balıklardan biridir, en çok çorba ve buğulama yapıldığında lezzetlidir.
               
                $
                21. Lüfer Balıgı

                Lüfer,  Pomatomidae familyasından bir balık türüdür. Ege balıkları arasında ekonomik değeri yüksek ve çok lezzetli bir balıktır. Bilimsel adı Pomatomus saltatrix olan lüfer, ülkemizin tüm denizlerinde bulunmaktadır.

                Maksimum ölçülen boyutları 120 cm ve 14 kg’dır. Bölgemizde yaşayan yetişkin lüferler 30-60 cm arasında bulunurlar. Lüfer, gevşek ve küçük gruplar halinde yaşayan yırtıcı deniz balıklarından balıklardan biridir.

                Lüfer çeşitli boyutlara göre farklı isimler almıştır:

                Sarıkanat: 18 – 25 cm boyutlarında olan lüfer yavrusudur. 18 cm altının avlanması veya satılması yasaktır.
                Lüfer: 28 – 35 cm boyutlarına ulaştığında lüfer adı verilir. Avlamak ve satış serbesttir.
                Kofana: 35 cm üzerine çıkan lüferlere bu ad verilmiştir. Avlanması ve satılması serbesttir.
                Sırtıkara: 50 cm’nin üzerindeki lüferlere verilmiş isimdir. Ülkemiz denizlerinde uzun süredir görülmemiştir. Avlamak ve satışını yapmak serbesttir.
                Lüfer bir dönem koruma altına alınarak avlanılması ve satışı yapılması yasaklanmış balık türlerindendir. Ancak, günümüzde yasak bitirilerek 18 cm ve üzeri olanların avlanması ve satılması serbest bırakılmıştır. 
                $
                22. Mahmuzlu camgöz köpek balıgı

                Mahmuzlu camgöz Squalidae familyasından, Akdeniz ve Ege Denizi başta olmak üzere ülkemiz sularında bulunmaktadır. Ülkemizde tüketilmese de Avrupa ülkelerinde tüketildiği bilinmektedir.

                Ana besinleri balık sürüleri ve ahtapotlar olan bu türün, profesyonel balıkçıların ağlarına ciddi hasar verdiği biliniyor. Nadiren de olsa dip balıklarını avlayan amatör balıkçıların oltasına takıldığı görülmektedir.

                En fazla 150 cm ve 10 kg boyutlarına eriştikleri tespit edilmiştir ancak, genellikle 80 cm ve 4 kg civarlarına ulaşırlar. Ticari değeri yoktur.
                $
                23. Mandagöz Mercan Balıgı

                Kırmızı (kızıl) çipura olarak da bilinen mandagöz mercan (Pagellus bogaraveo) Sparidae familyasından bir deniz balığıdır.

                Akdeniz başta olmak üzere ılıman ve sıcak denizleri tercih eden bir türdür, ılıman ısısıyla Ege balıklarından da biridir. Bulunduğu bölgeye göre en fazla 400 ila 700 metre derine inebilen bir balıktır.

                Kaydedilen en büyük uzunluk 70 cm, yaygın olarak da 30 cm ve 4 kg’dır. Eti lezzetli, ızgarada pişilmesi tercih edilen bir mercan varyantıdır.
                $
                24. Melanur Balıgı (Melanurya)

                Melanur diğer adıyla Melanurya, Sparidae familyasından bir deniz türüdür. Ülkemizde Akdeniz, Marmara ve Ege bölgerinde bulunur. Bilimsel adı Oblada melanura olan melanur, Ege denizi balık türleri arasında yer alıyor.

                Çok iri boyutlara ulaşabilen bir tür değildir. Kaydedilen maksimum boyutları, 38 cm ve 930 gr’dır. Ülkemiz sularında yaygın olarak 20 cm civarında görülürler. Hepçil olan türün ana besini omurgasızlardır.

                Eti lezzetli türlerden biri olan melanurun ticari değeri orta seviyelerdedir.
                $
                25. Mersin Balıgı

                Mersin balığı birçok farklı türün ortak adıdır. Mersin balığı adı altında 19 farklı cins balık bulunmaktadır. Görünümlerindeki ufak farklılar ile ayrılırlar. Bu balıklar Acipenseridae familyasına aittir. Akdeniz bölgemizde daha yaygın olan tür, Ege balıkları arasında da bulunmaktadır.

                Türe göre boyutları farketmektedir. Yetişkin mersin balıkları ortalama 140 ila 300 cm uzunluğa, 100 ila 200 kg ağırlığa ulaşabilirler. Şimdiye kadarki ölçülen en büyük boyutlar; 7.2 metre ve 1571 kilogramdır.

                Mersin balığı altında bulunan 19 farklı tür şu şekildedir:

                Sibirya mersini
                Kısa burunlu mersin balığı
                Yangtze mersin balığı
                Göl mersin balığı
                Rus mersin balığı
                Yeşil mersin balığı
                Sakhalin mersin balığı
                Japon mersin balığı
                Adriyatik mersin balığı
                Şip balığı
                Körfez mersinbalığı
                Atlantik mersin balığı
                İran mersin balığı
                Çuka balığı
                Amur mersin balığı
                Çin mersin balığı
                Yıldızlı mersin balığı
                Kolan balığı
                Beyaz mersin balığı
                $
                26. Mürekkepbalıgı

                Mürekkepbalığı Cephalopoda (Kafadanbacaklılar) sınıfından, deniz türleri arasında olan bir yumuşakça türüdür. İkisi diğerlerinden daha uzun olan toplam 10 adet kolları vardır ve iç bölgelerinde çok sayıda vantuz bulunur.

                Ege denizi balıkları arasında yer alan mürekkepbalığı, sıcak sularda yaşayan bir türdür. Bu türün boyutları çok değişkendir. Cinse göre 20 cm ile 17 metre arasında değişen çeşitleri vardır. Yaygın olarak yetişkin olanları 50-60 cm arasındadır.

                Ticari değeri olan, eti lezzetli bir yumuşakça türüdür.
                $
                27. Mırmır Balıgı

                Sparidae familyasından olan mırmır balığı, ekonomik değeri yüksek lezzetli balık türlerinden biridir. Denizin diplerinde ve kumlu kısımlarda yaşayan mırmır balığı sıklıkla avlanan Ege balıkları arasındadır.
                Ülkemizde Ege, Akdeniz ve Marmara bölgelerinde bolca bulunurlar. Ana besinlerini kabuklular, solucanlar ve yumuşakçalar oluşturur.

                En fazla 55 cm ve 1 kg ağırlığa ulaşmaktadırlar ancak, yaygın boyutları 30 cm civarındadır. Ticari değeri yüksek Ege denizi balık türlerinden biridir.
                $
                28. Orfoz Balıgı

                Serranidae familyasından Orfoz, Taş hanisi adıyla da bilinir. Bilimsel adı Epinephelus marginatus’dur. Orfozlar hermafrodit (çift cinsiyetli) deniz balıkları arasındadır.

                Orfoz balığı neslinin tükenmesiyle karşı karşıya olduğu için avlanması yasak türlerdendir. Ülkemizde Akdeniz ve Ege denizlerinin güney kısımlarında yaşarlar.

                En fazla 140 cm ve 60 kg boyutlarına ulaşabilirler. Boyutları ile iri ege balıklarından biridir. Ülkemiz denizlerinde yaygın görülen boyutları ortalama 60 cm ve 15 kg’dır.
                $
                29. Orkinos (Ton balığı)

                Çoğumuzun marketlerde konserve içerinde gördüğü Orkinos, Uskumrugiller (Scombridae) ailesinin üyesidir. Kendi aralarında farklı türlere sahip olan, Orkinos ortak adı verilen bu balık denizlerdeki en iri balıklardan biridir.

                Ege denizi balıkları arasında en büyük türlerden biridir. Yetişkin bir ton balığı, 6 metre uzunluğa ve 1 ton ağırlığa ulaşmaktadır. Ancak, bu boyutlarda Orkinos bulma ihtimali çok düşüktür genellikle 3-4 metre ve 400-600 kg arasında avlanırlar.

                Ekonomik değeri çok yüksek ve son deree lezzetli balıklardandır.
                $
                30. Pisi Balıgı

                Pisi balığı kalkan ile karıştırılabilir ancak resimlerine bakıldığında kolayca ayırt edilebilir. Pleuronectidae familyasından olan pisi balığının vücudu kalkana göre daha elips şeklindedir ve kalkanın sırtında olan düğme diye tabir edilen kemikli yapılar yoktur.

                Yine pisi balığının gözleri de vücudun sağ tarafındadır. En fazla 60 cm boyut ölçülmüştür ancak, yaygın boyutları 30 cm civarındadır.

                Ülkemizde Akdeniz, Ege, Karadeniz ve Marmara bölgelerimizde bulunur.
                $
                31. Sardalya Balıgı

                Saldalya hamsi ile yakından akraba, Clupeinae familyasından bir balık türüdür. Sürüler halinde kıyıya yakın geçerek göç ederek yaşamlarını sürdürürler.

                Akdeniz ve Karadeniz’de daha yaygın görülen sardalya, Ege denizi balık türleri arasında da yer almaktadır. Denizlerimizde 15-20 cm boyutlara ulaşırlar ancak okyanus bölgelerindeki sardalyalar 30 cm uzunluğa kadar büyümektedir.

                Ticari değeri çok yüksek, lezzetli balık türlerindendir.
                $
                32. Sargan Balıgı (Zargana)

                Tipik balık görünümünün dışında uzun ve ince bir vücuda sahip sargan (Belone belone), Belonidae familyasının üyesidir. Vücut yapıları sayesinde hızlı ve çevik deniz balıklarındandır.

                Yaşadıkları bölgeye göre 1 metre uzunluğa erişmektedirler ancak Akdeniz ve Ege denizlerimizde 60 cm civarına kadar büyümektedirler.

                Ana besinleri küçük balıklardır ve hamsi, çaça gibi balık türleri ile beslenir. Ticari değeri yüksek, lezzetli Akdeniz ve Ege balıkları arasındadır.
                $
                33. Sargoz Balıgı

                Sargoz, Akdeniz ve Ege bölgelerinde sıklıkla Karagöz ile karıştırılır. Diplodus sargus bilimsel adı verilmiştir ve Sparidae ailesinden bir deniz balığı türüdür.

                Bu balık bölgeye göre farklı isimler almıştır. Baltabaş, Sargos ve Ak Karagöz olarak da bilinirler. Ülkemizde Akdeniz ve Ege bölgelerimizde yaygındır.

                Güçlü çeneye sahiptirler ana besinleri; kabuklular, yumuşakçalar ve deniz yosunları. Ekonomik değeri yüksek, lezzetli bir balıktır.
                $
                34. Sinarit Balıgı

                Sparidae familyasından olan Sinarit’in bilimsel adı Dentex dentex’dir. Akdeniz’de yaygındır ancak Karadeniz, Marmara ve Ege balıkları arasında da yer alırlar.

                Taşlı ve kumlu bölgelerde 200 metre derinliğe kadar yaşarlar. Ana besinleri kafadanbacaklılar ve yumuşakçalardır. Genellikle yalnız yaşarlar ancak üreme dönemlerinde küçük sürüler halinde görülmektedirler.

                1 metre uzunluğa, 20 kg ağırlığa ulaşırlar. Olta avcılığı son derece zevkli, eti lezzetli ama az bulunan bir balıktır.
                $
                35. Tekir Balıgı

                Bilimsel adı Mullus surmuletus olan Tekir, Mullidae familyasından bir deniz balığıdır. Akdeniz, Karadeniz ve Ege denizi balık türleri arasındadır.

                5 metrelik sığ sulardan 400 metre derinlikteki sulara kadar uzanan yaşam alanları vardır. Kaydedilmiş en büyük boyutları 40 cm ve 1 kg’dır ancak sularımızda yaygın olarak 25 cm civarında görülürler. Ticari değeri olan bir balıktır ve av balığı olarak da kullanılmaktadır.
                $
                36. Trakonya Balıgı

                Trakonya balığı halk arasında dragon balığı olarak da bilinmektedir. Trachinidae ailesinden olan balığın bilimsel adı Trachinus draco’dur.

                Vücudunda zehirli dikenlere sahiptir ve dokunulduğunda toksik bir madde salgılar. Zehirli Ege balıkları arasındadır. Zehri kuvvetlidir, uzuv kaybı veya kalp krizine neden olabilmektedir.

                1 metre ile 150 metre arasında kumlu, çakıllı alanlarda yaşamaktadır. Küçük balıklar, omurgasızlar ve kabuklular ana besinleridir. En fazla 55 cm boyuta ulaşabilirler ve genellikle 25 cm civarında görülürler. Ticari değer yoktur.
                $
                37. Trança

                Ege balıkları arasında meşhurlaşmış türlerden biridir. Bölgede Çavuş, Antenli mercan, Altınkaş isimleri ile de bilinir. Bilimsel adı Pagrus caeruleostictus’dur ve mercan familyasından bir türdür.

                Sığ ve sıcak sularda tek olarak yaşayan iri bir balıktır. Etçil bir balıktır ve kafadanbacaklılar, küçük balıklar ana besinleridir. Okyanuslara ve farklı denizlere sürekli göç eden balıklardandır.

                Yetişkin boyutları 60-75 cm civarındadır ancak 1 metre üzerine de çıkabilmektedir. Ekonomik değeri yüksek, lezzetli bir balıktır.
                $
                38. Zurna Balıgı

                Zurna balığı (Scomberesox saurus), Scomberesocidae familyasından bir deniz balığıdır. Açık denizlerde yaşayan bu tür, Süveyş kanalının açılmasından sonra Akdeniz ve Ege denizlerinde görülmüştür.

                En fazla 50 cm, ortamala 35 cm boyutlarındadır. Balık yavruları ve plankton ile beslenir. Avlanmadıkları için herhangi bir ticari değeri yoktur.
                """;
            //balık nesnelerini tutan generic list
            List<EgeDeniziB> egeBaliklari = new List<EgeDeniziB>();
            var tree = new BinaryTree();

            //metni her balık için bölüyorum
            string[] parcalanmisMetin = metin.Split("$", StringSplitOptions.RemoveEmptyEntries);
            int p = 1;
            foreach (string veri in parcalanmisMetin)
            {
                string[] satirlar = veri.Trim().Split("\n", StringSplitOptions.RemoveEmptyEntries);
                string tamAd = (satirlar[0].Trim()).Substring(p<10?3:4);
                string balikAdi;
                string digerAdi;
                if (tamAd.Contains('('))
                {
                    balikAdi = tamAd.Split('(')[0].Trim();
                    digerAdi = tamAd.Split('(')[1].Replace(")", "").Trim();
                }
                else
                {
                    balikAdi = tamAd;
                    digerAdi = null;
                }
                //Console.WriteLine(balikAdi);
                //Console.WriteLine(digerAdi);

                string boyut = "";
                string bilgi = "";
                List<string> ortam = new List<string>();

                foreach (string satir in satirlar)
                {

                    if (satir.Contains("cm"))
                        boyut = satir.Trim();
                    if (satir.Contains("Karadeniz"))
                        ortam.Add("Karadeniz");
                    if (satir.Contains("Akdeniz"))
                        ortam.Add("Akdeniz");
                    if (satir.Contains("Kızıldeniz"))
                        ortam.Add("Kızıldeniz");
                    if (satir.Contains("Marmara"))
                        ortam.Add("Marmara Denizi");
                    bilgi += satir + " ";

                }
                ortam.Add("Ege Denizi");
                //objeyi oluşturma
                EgeDeniziB balik = new EgeDeniziB(balikAdi, digerAdi, boyut, bilgi, ortam);
                //balık nesneklerini listeye atma
                egeBaliklari.Add(balik);
                //balıkları tree ye atma
                tree.Insert(balik);
                p++;
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("1.a EgeDeniziB Ağacının Oluşturulması ve Sıralı Olarak Ekrana Listelenmesi");
            Console.WriteLine("1.b Derinlik Bulma, Ağacı Listeleme, Düğüm Sayısı Buldurma, Dengeli Ağaç Derinliği Hesaplama\t4");
            Console.WriteLine("Görmek İçin Herhangi Bir tuşa basın...");
            Console.ReadKey();
            //ağacı yazdırma
            tree.PrintTree();
            //ana ağacın derinliği
            Console.WriteLine($"Ana Ağacın Derinliği: {tree.GetDepth()}");
            //(iç ağacın derinliği / node sayısı)/balık sayısı
            Console.WriteLine($"Tüm Kelimeler Ağaçlarının Ortalama Derinliklerinin Ortalaması: {tree.GetAverageDepthOfAllSubTrees():F2}");

            // Binary Tree düğüm ve derinlik hesaplama
            int binaryTreeNodeCount = tree.GetNodeCount();
            int binaryTreeBalancedDepth = tree.GetBalancedTreeDepth();

            Console.WriteLine($"Binary Tree'deki Düğüm Sayısı: {binaryTreeNodeCount}");
            Console.WriteLine($"Dengeli Bir Binary Tree'nin Derinliği: {binaryTreeBalancedDepth}");
            //belli harf aralığındaki balıkların ağacını yazdırma
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("1.c Arama Listeleme");
            Console.WriteLine("Harf Aralığındaki Balıkları Görmek için Harfleri Yazınız");
            while (true)
            {
                Console.Write("Başlangıç harfini giriniz: ");
                char start = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                Console.Write("Bitiş harfini giriniz: ");
                char end = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                if (start > end)
                {
                    Console.WriteLine("Başlangıç harfi bitiş harfinden büyük olamaz.");
                }
                else
                {
                    var result = new List<string>();
                    tree.GetFishNamesInRange(tree.Root, start, end, result);

                    if (result.Count > 0)
                    {
                        Console.WriteLine($"Baş harfleri {start} ile {end} arasında olan balık isimleri:");
                        foreach (var name in result)
                        {
                            Console.WriteLine(name);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Baş harfleri {start} ile {end} arasında balık ismi bulunamadı.");
                    }
                    break;
                }
               
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("1.d Özyineli olarak Dengeli Bir Ağaç Oluşturulması");
            Console.WriteLine("Görmek İçin Herhangi Bir tuşa basın...");
            Console.ReadKey();


            // Balıkları alfabetik sıraya göre sıralama
            egeBaliklari.Sort((x, y) => string.Compare(x.balik_Adi, y.balik_Adi, StringComparison.OrdinalIgnoreCase));

            // Sıralı ağacı oluşturma
            TreeNode root = BuildBalancedTree(egeBaliklari, 0, egeBaliklari.Count - 1);

            // Ağacı yazdırma 
            PrintInOrder(root);

            //dengeli ağacı oluşturan metod
            static TreeNode BuildBalancedTree(List<EgeDeniziB> sortedList, int start, int end)
            {
                if (start > end)
                    return null;

                // Ortadaki elemanı seç ve kök yap
                int mid = (start + end) / 2;
                TreeNode node = new TreeNode(sortedList[mid].balik_Adi, sortedList[mid].bilgi);

                // Sol ve sağ alt ağaçları oluştur
                node.Left = BuildBalancedTree(sortedList, start, mid - 1);
                node.Right = BuildBalancedTree(sortedList, mid + 1, end);

                return node;
            }
            //yazdırma metodu
            static void PrintInOrder(TreeNode node)
            {
                if (node == null) return;

                PrintInOrder(node.Left);
                Console.WriteLine(node.Name);
                PrintInOrder(node.Right);
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("2.a EgeDeniziB Nesnelerini Hash Table’a Yerleştirme");
            Console.WriteLine("Görmek İçin Herhangi Bir tuşa basın...");
            Console.ReadKey();
            //--------------------------------------------------------------------------------------------------------------
            // Hash Table oluşturma kısmı (Dictionary kullanıyoruz)
            List<TreeNode> treeNodesList = tree.GetTreeNodesInOrder();
            var fishHashTable = new Dictionary<string, TreeNode>();

            // Balıkları hash tablosuna ekle (BalikAdi anahtar olarak kullanılıyor)
            foreach (var treenode in treeNodesList)
            {
                fishHashTable[treenode.Name] = treenode;
            }

            // Hash Tablosundan balık bilgilerini al ve yazdır
            Console.WriteLine("Hash Table'daki balık bilgileri:");



            // Tüm balıkları hash tablosundan yazdırma
            foreach (var keyValuePair in fishHashTable)
            {
                Console.WriteLine($"{keyValuePair.Key}:");
                keyValuePair.Value.PrintNodeSubTree();
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("2.b Hash Table Güncelleme");
            while (true)
            {
                // Kullanıcıdan balık adı al ve yeni bilgi güncellemesi yap
                Console.WriteLine("Hangi balığın bilgisini güncellemek istersiniz?");
       
                string arananBalik = Console.ReadLine();

                if (fishHashTable.ContainsKey(arananBalik))
                {

                    var arananBalikNode = fishHashTable[arananBalik];


                    // Yeni bilgi al
                    Console.WriteLine("Yeni Balık Bilgisini Girin:");
                    string yeniBilgi = Console.ReadLine();



                    // Yeni bilgi ve kelime ağacını güncelle
                    arananBalikNode = new TreeNode(arananBalik, yeniBilgi);

                    // Hash tablosundaki balık bilgisini güncelle
                    fishHashTable[arananBalik] = arananBalikNode;

                    Console.WriteLine($"\n{arananBalik} balığının yeni bilgisi güncellendi.");

                    // Güncellenen balığı yazdır
                    Console.WriteLine("\nGüncellenen Balık Bilgileri:");
                    arananBalikNode.PrintNodeSubTree();
                    break;
                }
                else
                {
                    Console.WriteLine("Bu balık adı hash tablosunda bulunamadı.");
                }
            }
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("3) HEAP VERİ YAPISI (SINIFI)");
            Console.WriteLine("Görmek İçin Herhangi Bir tuşa basın...");
            Console.ReadKey();
            //Max Heap
            MaxHeap heap = new MaxHeap();
            foreach (var balik in egeBaliklari)
            {
                heap.Add(balik);
            }

            Console.WriteLine("Max Heap içeriği:");
            heap.PrintHeap();

            Console.WriteLine("\nEn büyük eleman (root):");
            Console.WriteLine(heap.Peek().balik_Adi);
            
            var treeNode1=new TreeNode(heap.Pop().balik_Adi,heap.Pop().bilgi);

            var treeNode2 = new TreeNode(heap.Pop().balik_Adi, heap.Pop().bilgi);
            var treeNode3 = new TreeNode(heap.Pop().balik_Adi, heap.Pop().bilgi);
            treeNode1.PrintNodeSubTree();
            treeNode2.PrintNodeSubTree();
            treeNode3.PrintNodeSubTree();
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("4.a Sıralama Algoritmaları");
            Console.WriteLine("Görmek İçin Herhangi Bir tuşa basın...");
            Console.ReadKey();
            //Insertion Sort
            int[] data = {16,11,7,8,20,4,14};
            Console.WriteLine("Sıralanmamış dizi: " + string.Join(", ", data));
            Console.WriteLine();

            InsertionSortExample.InsertionSort(data);
            Console.WriteLine("Insertion Sort ile sıralanmış dizi: " + string.Join(", ", data));

            //Merge Sort
            int[] array = { 12, 11, 13, 5, 6, 7,15,9};

            Console.WriteLine("Sıralanmamış dizi: " + string.Join(", ", array));

            MergeSortExample.MergeSort(array, 0, array.Length - 1);

            Console.WriteLine("Merge Sort ile sıralanmış dizi: " + string.Join(", ", array));

            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("4.c Çalışma Zamanının HesaplanmasI");
            Console.WriteLine("Görmek İçin Herhangi Bir tuşa basın...");
            Console.WriteLine("Zamanın Öğrenilmesi Uzun Sürebilir Lütfen Bekleyiniz");
            Console.ReadKey();
            //Zamanı ölçen kod
            // 100 elemanlı rastgele bir dizi oluşturuyoruz
            Random random = new Random();
            int[] originalArray = new int[100];
            for (int i = 0; i < 100; i++)
            {
                originalArray[i] = random.Next(1, 1000);
            }

            long repetitions = 10000000;

            // Insertion Sort Zamanı Ölçümü kısmı
            int[] arrayToSort = new int[100];
            Array.Copy(originalArray, arrayToSort, 100); // Diziyi sıfırla
            Stopwatch stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < repetitions; i++)
            {
                Array.Copy(originalArray, arrayToSort, 100); // Her sıralama öncesi diziyi sıfırla
                InsertionSortExample.InsertionSort(arrayToSort);//sıralama yap
            }
            stopwatch.Stop();
            Console.WriteLine("Insertion Sort için geçen süre (s): " + (double)stopwatch.ElapsedMilliseconds/1000);

            // Merge Sort Zamanı Ölçümü
            Array.Copy(originalArray, arrayToSort, 100); // Diziyi sıfırla
            stopwatch.Restart();
            for (int i = 0; i < repetitions; i++)
            {
                Array.Copy(originalArray, arrayToSort, 100); // Her sıralama öncesi diziyi sıfırla
                MergeSortExample.MergeSort(arrayToSort, 0, arrayToSort.Length - 1);//sıralam
            }
            stopwatch.Stop();
            Console.WriteLine("Merge Sort için geçen süre (s): " + (double)stopwatch.ElapsedMilliseconds/1000);
            
        }
    }
}
