Yapay Zeka (Artificial Intelligence - AI), bilgisayarların ve yazılımların insan zekasına benzer şekilde problem çözme, öğrenme, akıl yürütme ve karar verme yeteneklerine sahip olması için geliştirilmiş bir alandır. AI, makinelerin belirli görevleri insan müdahalesi olmadan yerine getirebilmesi amacıyla veri işleme, algoritmalar ve istatistiksel yöntemler kullanarak çalışır.

Bu GitHub projesinde yer alan A* algoritması, 8 Taş Bulmacası (8 Puzzle Problem) üzerinde uygulanmış. 8 Taş Bulmacası, 3x3'lük bir kare ızgarada 8 taşın rastgele bir sırayla yerleştirilmesi ve boş bir hücreyi kullanarak taşları hedef duruma getirmeyi amaçlayan bir problemdir. Hedef, taşların belirli bir düzen içinde sıralanmasıdır.

A* algoritmasının bu problem üzerindeki uygulamasını detaylandırarak açıklayayım.

8 Taş Bulmacası Problemi Nedir?
Bu problemde:

Bir 3x3 kare üzerinde 1'den 8'e kadar taşlar ve bir boş alan (genellikle 0 ile gösterilir) bulunur.
Amaç, taşları hedef bir dizilime getirmek için taşları boş hücre ile kaydırarak yer değiştirmektir.
Hedef durum genellikle şu şekildedir:

1 2 3
4 5 6
7 8 0
A* Algoritmasının Uygulaması
Bu algoritma, bulmacayı çözmek için en kısa yolu bulmaya çalışır ve bu sırada iki temel maliyet fonksiyonu kullanır:

g(n): Şu ana kadar yapılan taş hamlelerinin sayısı (başlangıç durumundan mevcut duruma kadar olan maliyet).
h(n): Sezgisel fonksiyon, hedef durumdan ne kadar uzakta olunduğunu tahmin eder. Genellikle iki farklı sezgisel fonksiyon kullanılır:
Manhattan Mesafesi: Her taşın hedef pozisyonuna olan yatay ve dikey uzaklığı.
Yanlış Konumlanmış Taşlar: Hedefe yanlış konumlanmış olan taşların sayısı.
A* algoritması, her düğüm için şu fonksiyonu hesaplar:

𝑓
(
𝑛
)
=
𝑔
(
𝑛
)
+
ℎ
(
𝑛
)
f(n)=g(n)+h(n)
g(n): O ana kadar yapılan hamlelerin sayısı.
h(n): Taşların hedefe olan uzaklığı (sezgisel fonksiyon).
Algoritmanın Çalışma Mantığı
Başlangıç durumunu açık listeye ekle: Algoritma, taşların başlangıçtaki sıralanışını temel alarak başlar. Bu durum açık listeye eklenir (ziyaret edilecek düğümler).

Açık listedeki en düşük f(n) değerine sahip düğümü seç: Algoritma, başlangıçta yalnızca bir düğüm olduğu için, bu düğüm (başlangıç durumu) işleme alınır.

Seçilen düğümün komşu durumlarını üret: Seçilen durumdaki boş hücrenin etrafındaki taşlar hareket ettirilerek yeni durumlar üretilir. Bu yeni durumlar açık listeye eklenir.

Her komşu durum için g(n) ve h(n) hesaplanır: Her yeni durumda yapılan hamle sayısı (g(n)) ve hedef durumdan uzaklık (h(n)) hesaplanır.

Hedef duruma ulaşana kadar işlem tekrarlanır: Her adımda en düşük f(n) değerine sahip düğüm genişletilir. Hedef duruma ulaşılırsa, çözüm yolu bulunmuş olur.

A* Algoritmasının Bu Projede Kullanımı
Bu projede A* algoritması, bulmaca çözme işlemini adım adım takip eder. İzlenen adımlar şu şekildedir:

Başlangıç ve hedef durumları tanımlanır.
Açık liste ve kapalı liste kullanılır: Açık liste, çözüm yolunda ziyaret edilecek durumları içerir. Kapalı liste ise zaten ziyaret edilen durumları içerir.
Sezgisel fonksiyon olarak Manhattan Mesafesi kullanılır: Her taşın doğru konumuna olan Manhattan mesafesi hesaplanarak h(n) değeri bulunur.
Taşlar yer değiştirilerek yeni durumlar üretilir. A* algoritması boş hücrenin komşularına giderek yeni durumlar oluşturur.
Hedef durumuna ulaşana kadar bu süreç devam eder. Hedef durum, taşların doğru sırada olduğu durumdur.
Kodun Ana Unsurları
Bu proje içinde A* algoritmasını tanımlayan bazı önemli parçalar şunlardır:

Durumun Temsili: Durum, 3x3'lük bir dizide taşların sırasını içerir.
Sezgisel Fonksiyon: Manhattan mesafesi ile her durumun hedefe ne kadar yakın olduğu hesaplanır.
Yol Bulma: A* algoritması, bulmaca durumlarını genişleterek hedef duruma en kısa yoldan ulaşmayı sağlar.
Projedeki A* algoritmasının temel mantığı bu şekildedir.
