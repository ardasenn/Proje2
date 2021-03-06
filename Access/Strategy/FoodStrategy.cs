using ABOACIDIYET.Entities;
using ABOACIDIYET.Enums;
using Bogus;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Access.Strategy
{
    public class FoodStrategy : CreateDatabaseIfNotExists<AboDbContext>
    {
        protected override void Seed(AboDbContext context)
        {

            //KATEGORİLER
            List<Category> categories = new List<Category>();

            categories.Add(new Category("Alkollü İçkiler ve İçecekler", "Bira ve şarabın da dahil olduğu alkollü içkilerde yer alan kalorilere boş kaloriler denir çünkü bu içecekler üç makro besin olan protein, yağ ve karbonhidratlardan önemli miktarda içermezler. Alkollü kokteyller ise makro besin içerebilen kola, tonik, süt ile yapıldıklarında veya özellikle meyve suyu ile yapıldıklarında ilave olarak vitamin ve mineral içeriğinden ötürü besin değerine sahip olabilirler. Ancak, kokteyllerin çoğu genelde şekerden zengin karışımlar kullanılarak yapıldığı için kalori cetvelinde de görülebileceği üzere kadeh başına daha yüksek kaloriye sahiptirler. Besin etiketleri, birçok alkollü kokteylin şurup kaynaklı şekerle yüklü olduklarını da göstermektedir. Bir içeceğin kalorisinin düşük olmasını istiyorsanız, kalori tablosunda da görüldüğü üzere, damıtma işlemi sonucu neredeyse saf alkol haline gelmiş bulunan likörleri kullanın. Hacim başına daha düşük alkole sahip olan bira ve şarap gibi alkollü içecekler de biradaki tahıl ve şarap yapımında kullanılan üzümlerdeki doğal şeker kaynaklı karbonhidratlar içermektedir. Genel olarak doğru olan, kilo vermeye yönelik beslenme programlarında tüm alkollü içeceklerden sakınmak ve ihtiyacınız olan kaloriyi kalori cetvelinden kaliteli besin değerine sahip yiyecekleri seçerek sağlamaktır.", "https://www.kaloricetveli.org/wp-content/uploads/alkollue-ickiler-ve-icecekler.jpg"));
            categories.Add(new Category("Alkolsüz İçecekler", "Bu kalori cetvelinde, alkollü içecekler ve saf meyve suları dışında kalan içecekler listelenmektedir. Alkolsüz içecekler kahve, meyveli gazoz benzeri meşrubatlar ve gazlı içecekleri içerir. Örneğin, çeşme suyu, bir çok çay çeşidi ve bazı gazlı diyet içecekler vücut için enerji metabolizmasında kullanabileceği kalori içermezler. Normal gazlı içecekler gibi diğer içecekler ise boş kalori bakımından yüksektir. Bu tür meşrubatlar doygunluk hissi yaratmadan çok miktarda tüketilmeye elverişlidir ancak bu tüketimlerinin tek porsiyonla sınırlandırılmaları gerekmektedir. Birçok içecek, tüm gün boyunca tüketilmesi gereken miktarda su içermemesinin yanı sıra, vitamin ve mineral açısından da anlamlı bir besin değerine sahip değildir. Bunlar ayrıca şeker katkısı bakımından çok zengin olabilir. Limonata gibi meyve temelli içecekler dahi yüksek oranda früktoz içeren mısır şurubu barındırır. Özel bilgiler için şişe üzerindeki besin etiketini inceleyin. Bu etiket meyve kokteyli gibi ürünlerin gerçek meyve suyu içerip içermediklerini ve içeriyorlarsa oranlarını gösterecektir. Ayrıca şişe veya kutunun üzerinde kalori değerlerini gösteren bir bilgi yoksa, kalori tablolarından birim başına içerdikleri kaloriyi kontrol edin.", "https://www.kaloricetveli.org/wp-content/uploads/alkolsuez-icecekler.jpg"));
            categories.Add(new Category("Baklagiller", "Baklagiller, diğer bitkisel ürünlere -özellikle sebzelere- göre daha fazla kalori içermektedirler ancak aynı zamanda da besin değeri en yüksek gıdalar arasındadırlar. En yaygın baklagiller fasulye ve mercimek türleridir ama bezelye ve yer fıstığı da baklagiller sınıfındadır. Besin değerlerinden ötürü bezelyeler nişastalı sebzeler, yer fıstıkları da yağlı ağaç fıstıkları sınıflarında gruplanmaktadır. Bu sınıflandırmalardan da anlaşılacağı üzere baklagillerin kalorileri her formda gelebilir, ayrıca yağ, protein ve karbonhidrat dengeleri sınıflar arasında farklılık gösterebilir. Baklagiller ayrıca değerli bitki proteinleri de içermektedirler. Toz protein takviyeleri soya, bezelye ve yer fıstıklarından yapılır. Kalori cetveli, hangi soya ürününün ete alternatif olarak kullanılabileceği konusunda yardımcı bir araç olabilir. Fasulye ve mercimekler son derece önemli kompleks karbonhidrat ve lif kaynağıdır, ayrıca besin profilleri vejetaryen bir diyet için değerli (ve doyurucu!) bir et ikamesi olduklarını göstermektedir. Bir porsiyon etin kalorisiyle bir porsiyon mercimek veya fasulyenin kalorisini kalori cetvellerinden veya kalori listelerinden inceleyebilirsiniz. Konserve şeklinde sunulan baklagiller tuz, şeker ve kalsiyum klorür gibi kimyasal koruyucular içerdiklerinden ürünün saf olup olmadığına emin olmak için kutu üzerindeki besin etiketini kontrol edin, ya da kuru baklagiller satın alın.", "https://www.kaloricetveli.org/wp-content/uploads/baklagiller.jpg"));
            categories.Add(new Category("Balık ve Deniz Ürünleri", "Bu kategori nehirlerden, okyanuslardan veya diğer ortamlardan elde edilen çeşitli etleri içermektedir. Bu nedenle, besin bilgilerinde ve kalori cetvelinde gösterildiği üzere, deniz ürünlerinin bir porsiyonundaki toplam kalori büyük oranda değişkenlik gösterebilir. Balık ve diğer su ürünleri, kümes hayvanlarına ve kırmızı etlere benzer şekilde karbonhidrat bakımından çok fakirdir. Fakat yağ ve protein oranları bir deniz ürününden diğerine farklılık gösterir. Kalori cetvelinde daha yüksek kalori yoğunluğuna sahip olduğu gösterilen somon ve ton gibi balıklar porsiyon başına daha yüksek yağa sahiptirler. Bununla birlikte deniz ürünlerinin omega-3 yağlı asitleri gibi sağlıklı yağları içerdiğine dikkat etmek önemlidir. Bunlar çok yararlı olduklarından, balık yağı sıklıkla gıda takviyesi olarak kullanılır. Bununla birlikte, bu yağların en iyi kaynağı işlem görmemiş yiyeceklerdir. Genelde, balıklar ve diğer deniz ürünlerinin eti çok yağsızdır ve bu durum kalorilerinin hemen tamamının proteinden ileri geldiği anlamına gelir. Sağlıklı bir şekilde hazırlandığında, bu besin kategorisi çok yüksek bir besin değerine sahiptir. Bu nedenle balık ve diğer deniz ürünleri her tür dengeli beslenme programının düzenli bir parçası olarak önerilir. Hatta vejetaryen yaşam tarzını benimseyen bir çok birey, deniz ürünleri dışındaki tüm etleri dışlayan peskateryan diyetini uygular.", "https://www.kaloricetveli.org/wp-content/uploads/balik-ve-deniz-ueruenleri.jpg"));
            categories.Add(new Category("Bira", "Tahıl tanelerinin fermantasyonu ile üretilen alkollü bir içecek olan biranın kalorisi içeriğindeki alkol ve karbonhidratlardan kaynaklanmaktadır. Bunlar, vücudun günlük fonksiyonlarının yürütülmesi için gerekli besinleri anlamlı miktarda içermediklerinden, boş kaloriler olarak adlandırılırlar. Karbonhidratlar, her ne kadar kalori tablolarında da belirtildiği üzere, sağlıklı bir beslenme programının önemli ve %60’a varan oranda zorunlu bir parçası olsalar da, biranın içindeki karbonhidratlar besin değeri yönünden ideal bir kaynak değildir. Genel olarak bira, içeriğindeki kompleks karbonhidratlardan ziyade, kan şekeri seviyesini kötü şekilde etkileyebilen basit karbonhidratlar içerir. Ayrıca biranın kalorisi büyük oranda içeriğindeki alkolden kaynaklandığı ve metabolizmanız enerji için öncelikle bu alkolü kullandığı için, biradaki karbonhidratlar sıklıkla şekere dönüştürülür ve sonrasında yağ olarak depolanır. Bununla birlikte her bira kötü değildir ve besin etiketleri ve kalori cetvelleri düşük kalorili ve düşük karbonhidratlı biraları ayırt etmekte yardımcı olur. Bazı biralar şişe başına 30 gram karbonhidrat içerirken, daha hafif biralar, hatta Guiness, 10 gramdan daha az karbonhidrat içermektedir. Normal olarak, aşağıdaki kalori cetvelinde gözlenen düşük kalori düzeyi daha az karbonhidrat miktarı anlamına gelmektedir. Dengeli beslenme planlarında da genellikle tavsiye edildiği üzere, bira temelde günde bir şişe ile sınırlanmalı, özel durumlarda ise bu miktar en çok iki ya da üç şişe olmalıdır.", "https://www.kaloricetveli.org/wp-content/uploads/bira.jpg"));
            categories.Add(new Category("Bitkisel Sıvıyağlar", "Bu kalori cetveli sebzeleri ve meyveleri içeren bitkilerden elde edilen sıvı yağları listelemektedir. Bitkisel sıvı yağlar, hayvansal yağlar kategorisinin tamamlayıcısıdır. Her iki kategorideki yağların kalori miktarları benzer olmakla birlikte, ürünlerin kökeni farklılık göstermektedir. Bu nedenle, sıvı bitkisel yağlar vejetaryen ve vegan diyetlerine uygundur. Sıvı bitkisel yağlar temelde saf yağ olsalar ve hayvansal yağlarla benzer kalori yoğunluğu içerseler de, mikrobesin içerikler sıvı yağın özütlendiği meyve ya da nebata göre farklılık göstermektedir. Bitkisel (nebati) yağlar bir anlamda bitkinin özüdür ve bu nedenle bünyelerinde bitkinin sağlığa yararlı bazı yönlerinin benzerini taşımaktadır. Örnek olarak, ceviz yağı hormonları dengelemeye yardımcı fitobesinlere ve deriyi güçlendirici vitaminlerle antioksidanlara sahiptir. Popülerliğini her zaman koruyan zeytinyağı doğal antienflamatuvarlar ve önemli miktarda E ve K vitaminleri içerir. En yüksek besin değerini elde etmek için mutfağınızda kullandığınız nebati yağları birbirlerine ekleyin ve satın aldığınız nebati yapın saf olduğundan emin olmak için besin bilgilerini kontrol edin. Ayrıca kullanacağınız yağın kalori miktarını, kullanacağınız ölçüye dikkat ederek kalori tablosundan inceleyin.", "https://www.kaloricetveli.org/wp-content/uploads/bitkisel-siviyaglar.jpg"));
            categories.Add(new Category("Çerez ve Çekirdekler", "Yemişler ve çekirdekler küçük boyutlarından beklenmeyecek düzeyde yüksek kalori içerirler ve küçük porsiyonlar halinde tüketilirler. Bu kategorideki bileşenlerin çoğu temelde yağlardan ve değişik düzeylerde eşlik eden protein ve karbonhidratlardan meydana gelmektedir. Badem gibi ağaç kökenli kuru yemişler ve chia gibi bitkilerden elde edilen yenilebilir çekirdekler omega-3 yağlarını içeren en iyi işlenmemiş besin kaynakları arasındadır. Bu yağlı asitler, omega-6 yağlarıyla birlikte, besn bilgilerinde çoklu doymamış yağlar olarak listelenmektedir. Diyetiniz, bu iki omega asitinin dengeli şekilde içerdiğinde, kan kolesterol seviyelerinin düzenlenmesine yardımcı olur, hatta tip iki diyabet gelişme riskini azaltır. Kalori cetveli aynı zamanda yer fıstığı, bezelye ve soya fasulyesi gibi baklagiller familyasına ait bitkilerin tohum veya meyvelerini içermektedir. Bunlar iyi birer bitkisel protein kaynağıdır. Yemişler ve çekirdekler, ağaç yemişi veya yer fıstığı alerjileri ve diğer nadir sağlık kaygıları hariç tutulduğunda, yüksek besleyici değerleri nedeniyle tüm diyetlerde önerilmektedir. Yemişler ve çekirdekler bütün olarak ya da öğütülmüş şekilde kullanılabilen çok yönlü bileşenlerdir. Salatalara, soslara, ekmeklere, garnitürlere, pürelere ve tatlılara bir kaşık tohum ya da bir avuç yemiş ekleyin, fakat aşırı kalorili olmalarını engellemek için abartmayın. Eklediğiniz yemişin kalorisini kalori tablosundan veya kalori cetvelinden ölçü birimine uygun olarak kontrol edin.", "https://www.kaloricetveli.org/wp-content/uploads/cerez-ve-cekirdekler.jpg"));
            categories.Add(new Category("Çorbalar", "Kaşıkla içilen sıvı bir yemek olan çorba, genellikle et suyu, bulyon, krema veya su ile yapılır. Sebze, et, makarna, pirinç ve baklagiller gibi malzemeler kaynayan suyun içerisinde yumuşayana ve parçalanana kadar pişirilir ve karıştırılarak aromalarının suya geçmesi sağlanır. Baharatlar, otlar ve çeşni karışımları hem çorbaya lezzet verir, hem de ana malzemelerin birbirleri ile birleşmelerini kolaylaştırır. Çorbalar tavuk suyu gibi sade ve sulu, makarna ve sebze ilaveli çorbalar gibi doyurucu, krema ve mantar çorbaları gibi kalın ve kremamsı olabilirler. Çorbalar, yenilebilen her tür malzemeden yapılabildiği için besin değerleri ve kalorileri ciddi anlamda farklılık göstermektedir. Çorbalar, kalori cetvelinde de görüldüğü üzere içerdikleri yüksek su oranı nedeni ile düşük kaloriye sahiptirler. Bununla birlikte, çorbalara krema, tereyağ, hindistancevizi sütü ve benzeri yağlı bileşenler eklenerek içerdikleri yağ oranları arttırılabilir. Bu nedenle değişik türdeki çorbaların yaklaşık kalori değerlerinin belirlenmesinde, içerdikleri malzemelerin kalori değerleri kalori cetvellerinde veya kalori tablolarında ayrı ayrı incelenmelidir. Haşlama et içeren çorbalar haricindeki çorbalar genellikle proteinden fakirdirler.", "https://www.kaloricetveli.org/wp-content/uploads/corbalar.jpg"));
            categories.Add(new Category("Dilimlenmiş Peynir", "Birçok ve sert ve yarı sert peynir türü sandviç, hamburger ve ızgara tavuk gibi yemeklerin hazırlanmasında kullanım kolaylığı sağlamak üzere önceden dilimlenmiş şekilde satılmaktadır. Bu kullanışlı paketleme şeklinin bir avantajı, her dilim bir porsiyona karşılık geldiğinden, porsiyon miktarının kolayca belirlenmesi ve kalori cetvelinin kullanılmasının kolaylaşmasıdır. İsviçre peyniri ve Emental peyniri gibi örnekleri bulunan dilimlenmiş peynirlerin besin değerleri, genellikle klasik dilimlenmemiş halleri ile aynıdır. Peynirlerin kalori cetveli bu süt ürünlerinin yağ içerikleri de dahil olmak üzere genel besin değerleri hakkında daha fazla bilgi içerir. Bazı durumlarda üretim işlemini kolaylaştırmak için dilimlenmiş peynirlere, Amerikan peyniri örneğinde olduğu gibi, ek bileşenlerin de eklenmektedir. Bu ek bileşenler süt yağı karışımları, peynir altı suyu, peynir kültürleri, besin boyası ve kimyasal emülgatörler gibi malzemelerden oluşmaktadır. Bu bileşenler, besin bilgilerini gösteren etiketlerde uzun bir liste şeklinde kolaylıkla görülebilir. İşlem görmüş peynirler doğal peynirlere kıyasla daha fazla sodyum ve doymuş yağ içerebilir ancak kalorileri, kalori tablolarında belirtildiği üzere, aşağı yukarı aynıdır. Dilimlenmiş peynirlerin düşük yağlı türleri geleneksel türlerinden daha az kalori bile içerebilmektedir.", "https://www.kaloricetveli.org/wp-content/uploads/dilimlenmis-peynir.jpg"));
            categories.Add(new Category("Dip Soslar ve Ezmeler", "Bu kalori cetveli, genellikle kendi başlarına yenmeyen, ancak üzerine sürüldükleri kızarmış ekmek ya da kraker gibi besinlere önemli oranda kalori takviyesi yapan dip soslar ve ezmeler gibi besin kalemlerini içerir. Bu nedenle kalori cetveline bakarken sadece temel malzemenin besin ve kalori değerlerinden ziyade, onlara eşlik eden dip sos ve ezmelerin ve krema, bal, reçel gibi sürülebilen diğer malzemelerin kalorilerini de eklemek önem taşımaktadır. Bu besin grubu, ana malzemenin içeriği değil, ilave bir parçası olarak ifade edildiğinden besin değerleri de nasıl kullanıldıklarına göre farklılık göstermektedir. Fıstık ezmesi ve zeytin ezmesi gibi en popüler bazı türler, yüksek doğal yağ içeriklerine bağlı yağ kalorisinden oluşmaktadır. Diğer taraftan, krema, bal ve reçel gibi bazı kahvaltılıklar ise hemen hemen tamamen saf şekerden oluşmaktadır. Bu nedenle, tatlı kahvaltılıkların kalorileri çoğunlukla basit karbonhidratlar şeklindedir. Her ne kadar size en favori ezme veya kremanızdan az az yiyormuşsunuz gibi gelse de, kavanozun ne kadar hızlı boşaldığına dikkat edin. Bu tip ezmeler tipik olarak kalori yoğundur ve bir oturuşta tamamının tüketilmesi çok kolaydır. Önerilen servis porsiyonları için geçerli olan detaylı bilgiler için besin etiketlerini ve ilgili kalori cetvelini kontrol edin.", "https://www.kaloricetveli.org/wp-content/uploads/dip-soslar-ezmeler.jpg"));
            categories.Add(new Category("Domuz Eti", "Bu kalori cetveli domuz etlerini ve domuz yağını listelemektedir. Her bir öğe için yağ ve protein oranları etin hayvanın hangi kesiminden elde edildiğine göre değişmektedir. Domuz pastırması ve İtalyan pastırmasının elde edildiği böğür bölgesi çok yağlı bir ettir ve bu nedenle daha yüksek kalori yoğunluğuna sahiptir. Bazı pastırma dilimleri kalınlıklarına bağlı olarak diğerlerinden daha yüksek kalori yoğunluğuna sahiptir. Kesin kalori miktarının belirlenmesi amacıyla besin bilgileri ve kalori tablosu incelenmelidir. Domuzun az yağlı düşük kalorili parçaları arasında domuz filetosu bulunmaktadır. Bu parça, düzgün şekilde işlendiğinde, derisi sıyrılmış tavuk göğsü ile benzer yağ miktarı içerir. Domuz yağının yarıdan daha azının doymuş durumda olduğu, çoğunun yararlı tekil doymamış yağ olduğunun bilinmesi yararlıdır. Domuz eti, değerli bir protein kaynağı olmasının yanı sıra, B kompleks vitaminleri ve çinko ve fosfor gibi mineralleri de içermesi itibariyle besleyici değere sahiptir.", "https://www.kaloricetveli.org/wp-content/uploads/domuz-eti.jpg"));
            categories.Add(new Category("Dondurma ve Donmuş Tatlılar", "Dondurmanın da aralarında bulunduğu donmuş tatlılar geleneksel olarak kalori yoğundurlar ve yüksek miktarda şeker içerirler. Dondurmanın, kalsiyum ve az miktarda protein içermesi gibi bazı yararlı yönleri bulunmaktadır. Bu bileşenlerin kesin değerlerini öğrenmek için hazır ürün paketlerinin üzerindeki besin bilgilerini kontrol edin. Ürünün kalorisini de yine besin etiketinden veya kalori cetvellerinden öğrenebilirsiniz. Dondurmadaki kalorilerin çoğu yağ veya işlenmiş şeker şeklinde olduğundan, bu tip tatlıların bazı yararlı bileşenler içermesi onların düzenli bir beslenme programının sağlıklı bir parçası oldukları anlamına gelmemektedir. Dondurma sıklıkla çikolata ve vanilya gibi popülerliğini yitirmeyen aromalarla sade olarak yenilse de, günümüzde şekerleme, fındık parçaları ya da çikolata sosu gibi çok sayıda ek malzeme içerecek şekilde de sunulmaktadır. Snickers dondurması gibi, bu bileşenlerden çok sayıda barındıran bir ürün, kalori cetvelinde belirtildiği üzere, olasılıkla yüksek bir toplam kalori değerine sahip olacaktır. Düşük kalorili olanları az yağlı sütten yapılmakta ya da bazı türlerde olduğu üzere karıştırma sürecinde içlerinde daha fazla hava kalması sağlanmaktadır. Soya sütü ya da hindistancevizi sütü gibi alternatif bitkisel sütler kullanılarak hazırlanmış dondurmalar da bulunmakla birlikte, bunlarda hemen hemen benzer miktarda şeker içerir ve bu nedenle düşük besleyici değere sahiptir. Internetten, her tür dondurmanın külah ya da paket başına içerdiği kaloriyi kalori cetvellerinden veya kalori tablolarından bulabilirsiniz.", "https://www.kaloricetveli.org/wp-content/uploads/dondurma-donmus-tatlilar.jpg"));
            categories.Add(new Category("Et ve Et Ürünleri", "Hayvansal ürün olan etler, temelde yağ ve protein formunda kalori içermektedirler. Etlerdeki besin maddelerinin oranları, etin tam olarak nereden kesildiğine, yani başka bir deyişle hayvanın tam olarak neresinden elde edildiğine bağlıdır. Kalori tablosu üzerinden veya farklı kalori cetvellerinden hangi etlerin daha fazla kalori içerdiğini kontrol edin. Yüksek kalori yoğunluğu, yüksek yağ oranının göstergesidir çünkü bir gram protein dört kaloriye eşitken, bir gram yağ dokuz kaloriye eşittir. Tavuk göğsü ve beyaz etli balık gibi yağsız etler gram başına en düşük kalori miktarına sahip etlerdir. Kuzu ve domuz gibi kırmızı etler ise gram başına en yüksek kaloriye sahip etlerdir. Bu etlerin doymuş yağ oranı da yüksek olduğu için kısmen daha düşük besin değerine sahiptirler. Bu nedenle kırmızı et tüketimini haftada birkaç kez ile sınırlamak en iyisidir. Tüm et türleri, gerekli tüm aminoasitleri içerdiğinden ideal protein kaynağıdır. Et aynı zamanda B12 vitamini, demir ve çinko açısından da en iyi besin maddelerinden biridir. Çeşniler ve eti marine etmede kullanılan terbiyeler etin kalorisini ciddi oranda artırabilir. Daha fazla bilgi için soslar ve çeşnilerin besin değerlerini kontrol edin. Ayrıca kalori cetvellerinden bu sosların içerdikleri kalori miktarlarına da göz atabilirsiniz.", "https://www.kaloricetveli.org/wp-content/uploads/et-ve-et-ueruenleri.jpg"));
            categories.Add(new Category("Fast Food", "Bu besin kategorisi, yiyeceğinizi dakikalar içerisinde hazırlayıp sunan ve kimi yerlerde arabalara da bir pencereden servis yapan popüler hızlı servis restoranlarının ürünlerini içermektedir. Fast food ürünleri yüksek kalorili olma eğilimindedir ve servis porsiyonları sıklıkla evde normal şartlarda hazırlananlardan daha büyüktür. Fast food ürünlerdeki kalori miktarı yağ ve şeker eklenmek suretiyle arttırılabilir ve bu ürünler ayrıca hazır ürünlerin bir çoğunda olduğu üzere sodyum ve diğer koruyucular da içerir. Fast food menüleri genellikle düşük besleyici değerleri veya boş kalorileri olan malzemeler içerir. Patates kızartması yağ ve basit nişasta biçiminde yüksek kalori içermesi itibari ile başlıca örnektir. Patates kızartmasının büyük bir porsiyonu ana yemeğin kendisi kadar kalori içerebilir. Fast food restoranları, kalori cetvelinde gösterildiği üzere, ızgara tavuklu salata gibi daha hafif yemekler de sunabilir. Bununla birlikte salata sosu ve diğer lezzet katkılarında gizlenmiş yüksek şeker ve yağ miktarı için besin bilgilerini ve belirtilen katkılara ait kalori cetvellerini kontrol etmek akıllıca olur. Detaylı besin bilgisi restorandaki kalori tablosunda ya da fast food şirketinin internet sitesinde bulunabilir.", "https://www.kaloricetveli.org/wp-content/uploads/fast-food.jpg"));
            categories.Add(new Category("Geyik ve Av Etleri", "Bu kalori cetveli mutfaklarda daha ender kullanılan et çeşitlerini listelemektedir. Bunun nedeni av hayvanlarının genellikle sportif amaçla avlanmaları ve süpermarket ve benzeri dükkanlarda kolayca bulunmamasıdır. Örneğin, geyik eti, evcil olmayan ve yetiştirilmeyen bir av hayvanından elde edilmektedir. Bu kategori, timsah ve Amerikan geyiği (mus) gibi çok ender bulunan etleri de içermekle birlikte, ilgili kategori cetvelindeki bizon eti gibi bazı yiyecekler restoranlarda ve özellikli marketlerde bulunabilir. Genel olarak, av etleri oldukça yağsızdır ve bu etlerdeki protein oranı yağ oranından daha yüksektir. Fakat diğer tüm etler gibi, kesin besin değerleri hayvandan etin elde edildiği bölgeye göre değişkenlik gösterir. Bu kategori memelilerin, av kuşlarının ve hatta sürüngenlerin tüm üyelerini kapsadığından, kalori yoğunlukları ve besin bilgileri standart değildir. Farklı kalori cetvelleri veya kalori tablolarından, yiyeceğiniz türe ve miktara en yakın ürünü bulup kalorisi hakkında bilgi sahibi olabilirsiniz. Geyik eti ve diğer av hayvanlarının tek benzer özelliği, tümünün iyi birer hayvansal protein kaynağı olmalarıdır. Bu nedenle, bu nadir et çeşitleri, mevcut olduklarında, yüksek kolesterol gibi bazı sağlık problemleri sorunları dışında, dengeli beslenme programlarına uygundurlar.", "https://www.kaloricetveli.org/wp-content/uploads/geyik-ve-av-etleri.jpg"));
            categories.Add(new Category("Kek ve Tartlar", "Kek ve tartlar, genellikle buğday unu, tereyağ, margarin, krema ve şeker gibi yüksek kalorili besinler içermektedirler. Bu malzemelerin içerikleri pasta malzemeleri kalori cetvelinde görülebilir. Hamur işlerinin besin değeri düşük olma eğilimindedir çünkü içerdiği ana malzemeler çoğunlukla, kan şeker seviyesinde hızla ani dalgalanmalara yol açan ve zamanla kiloda artışa neden olan basit karbonhidratlara sahiptir. Ancak kek ve tartların kalorisinin bir kısmı yumurta gibi protein ve besleyici öğeler içeren sağlıklı malzemelerden de gelebilir. Kek, tart ve pastaların yapımında ufak miktarlarda baharat ve vanilya özütü gibi malzemeler de kullanılsa da, bu malzemelerden gelen kalori yok denecek kadar azdır. Ancak yemişler ve kurutulmuş meyveler gibi diğer aroma verici ilaveler hem besin değerini, hem de kalori yoğunluğunu artırabilir. Üzerinde “az yağlı” ibaresi olan paketlenmiş hazır kekler ve tartlar bile yüksek früktoz mısır şurubu, yapay aromalar ve yapay tatlandırıcılar içerebilir. Her ne kadar sağlıklı ikameler olarak satılan hazır kek ve tartlar porsiyon başına daha düşük kalori içeriyor olabilse de, orijinal tariften daha iyi olmadıkları (hatta daha bile zararlı olabildikleri) de bir gerçektir. Bu nedenle, pasta ve türevlerinin düzenli olarak tüketilmemeleri ve hazır kek karışımlarının ve tartların üzerinde yer alan besin etiketlerinden besin değerlerinin kontrol edilerek beslenme programınıza uyup uymadıklarının kontrol edilmeleri gerekmektedir. Diğer yandan artık birçok pastane veya cafe, pastalarının kalori cetvellerini ve bir dilim veya porsiyonun kalori miktarını da sunmaktadır. Özellikle kilo verme veya kilonuzu koruma amacındaysanız, yemeden önce kalori tablosunu inceleyip bir kez daha düşünmenizde fayda var.", "https://www.kaloricetveli.org/wp-content/uploads/kek-ve-tartlar.jpg"));
            categories.Add(new Category("Konserve Meyveler", "Teneke kutularda ve hava almayan kavanozlarda sunulan konserve meyveler, taze meyvelere oranla daha fazla şeker, dolayısıyla daha fazla kalori içermektedirler. Yine de konserve meyvelerin taze meyvelerle aynı kaloriye ve besin değerine sahip olması da mümkündür. Hasat zamanı toplanan ve işlem gören konserve meyvelerin besin bileşenleri, hasat zamanı dışında toplanan taze meyvelerden daha yüksek oranda bile olabilir. Meyvelerin tümü çoğunlukla karbonhidratlardan oluşmakla birlikte, konserve meyvelerin kalorileri yağlardan ve az miktardaki proteinlerden de kaynaklanabilir. Meyveler, porsiyon başına A ve C vitaminleri gibi birçok vitamin, potasyum ve fosfor gibi birçok mineral içerdiğinden, iyi besin değerlerine sahiptirler. Konserve yapımında kullanılan bir çok meyve türü doğal olarak yüksek şeker oranına sahiptir. Örnek olarak şeftali, armut ve papayanın her biri 100 gram başına 40 gramın üstünde şeker barındırır. Meyvelerin kutulanması işlemi esnasında aşırı şeker ilave edildiğinde, besin bilgilerinde yüksek kalori değerinin belirtildiği gözlenir. Aşağıdaki kalori cetveli bir rehber olarak kullanılabilir. Bununla birlikte her bir marka için kesin değerler, eğer kullanıldıysa konservenin içerdiği şurup miktarına göre değişkenlik gösterir. Konserve meyvenin tam kalori miktarını, ambalaj üzerinde yer alan kalori tablosundan öğrenebilirsiniz.", "https://www.kaloricetveli.org/wp-content/uploads/konserve-meyveler.jpg"));
            categories.Add(new Category("Krem Peynir", "Krem peynirler yumuşak ve sürülebilir türdedir ve yüksek oranda yağ barındırdıklarından kalori cetvellerinde de belirtildiği üzere, diğer peynirlere göre daha fazla kalori içerirler. Ancak, bu grupta süzme peynir ve Fransız tipi Neufchatel peyniri gibi daha düşük yağ oranına sahip olan peynirler de bulunmaktadır. Krem peynirler, değişik soslarda ve tiramisu ve cheesecake gibi tatlılarda çok az tat kaybı olacak şekilde ikame edilebilirler. Krem peynirler simit ve diğer ekmeklerle sıklıkla eşlik ettiğinden, genellikle ilave malzemelerle tatlandırılır. Bununla birlikte, kalori cetvellerinde görüldüğü üzere, bu ek bileşenlerin kalori katkısı anlamlı düzeyde değildir. Krem peynirler ayrıca ek şeker de içerebilirler. Paket üzerinde yer alan besin değeri etiketinden, içerdikleri şeker miktarını görebilirsiniz. Tüm peynirler yağ ve protein içerir ve karbonhidrat kaynaklı kalori oranları çok düşüktür. Peynir bir süt ürünü olduğundan, besin değeri sütün besin değeri ile benzerlik gösterir, fakat krem peynir gibi daha yumuşak olanları bile gerçek süte oranla daha yoğun kaloriye sahiptir. Süt ürünlerinin kalori seviyeleri kalori tablolarında karşılaştırılabilir.", "https://www.kaloricetveli.org/wp-content/uploads/krem-peynir.jpg"));
            categories.Add(new Category("Kümes Hayvanları", "En yağsız ve en sağlıklı hayvansal protein çeşitlerinden bir olarak sıklıkla önerilen bu besin kategorisi özel olarak kuş etlerini içerir. Kümes hayvanları terimi yumurta ve et elde etmek için beslenen evcil kuşları tanımlamakta kullanılır. Av hayvanları terimi ise yetiştirilmek yerine doğada sportif amaçlarla avlanan sülün gibi kuşlar için kullanılır. Tavuklar, ördekler ve hindiler kümes hayvanlarının başlıcaları olsa da, kazlar ve bıldırcınlar da belirli bazı mutfaklarda (örneğin Fransız mutfağında) sıklıkla bulunur. Kalori cetvelinde bulunan devekuşu ve Avustralya devekuşu gibi büyük kuşlarda çiftliklerde yetiştirilir. Tüm etler için geçerli olduğu üzere, besin bilgileri hayvanın gerçek türüne ve etin elde edildiği kısma göre değişkenlik gösterir. Tavuk ve hindi göğsü düşük kalorili ve düşük yağlı tam protein kaynağı olarak diyetlerde sıklıkla önerilir. Kümes hayvanlarının değişik kısımlarının yaklaşık kalori değerleri kalori cetvelinde izlenebilir. Kümes hayvanlarının en çok yağ ve kolesterol içeren bölgesi derileridir. Butlar ise protein kaynaklı kaloriden ziyade yağ kaynaklı kalori içerirler. Yine de, kümes hayvanlarının yağının büyük kısmı tekli doymamış türde olduğundan sağlıklıdır. Bu nedenle, kümes ve av hayvanlarının etleri tüm vejetaryen olmayan diyetler için önemli bir protein kaynağıdır. Bununla birlikte, önceden hazırlanmış yemeklerde ek kalori bulunup bulunmadığını öğrenmek için besin etiketlerinin kontrol edilmesi ve ilave malzemelerinin kalori miktarları kalori tablosundan öğrenilmelidir.", "https://www.kaloricetveli.org/wp-content/uploads/kuemes-hayvanlari.jpg"));
            categories.Add(new Category("Makarna ve Noodle", "Makarna ve noodle (Çin eriştesi) un ve şekerin basit karışımından yapılmakla birlikte, yumurta gibi birleştirici malzemeler de içerebilirler. Bu kategorideki yiyecekler, belirtilen temel karışımları nedeniyle hemen tamamen karbonhidrat kalorilerinden oluşmaktadır. Semolina makarnası ve pirinç noodle gibi sık kullanılan çeşitler, sıklıkla basit karbonhidratlar içerdiklerinden hızla sindirilirler ve glisemik endeksleri yüksektir. Bununla birlikte, tam buğday unundan yapılan makarnalar ve kahverengi pirinçten yapılan noodle’lar da giderek yaygınlaşmaktadır. Bunlar diğerleriyle aynı kalori oranına sahip olmakla birlikte, daha fazla besin bileşeni içermektedirler. Makarna, İtalyan mutfağının başlıca unsurudur ve kalori cetveli temelde bu mutfakta kullanılan spagetti, penne, rigatoni ve fettucini gibi makarna çeşitlerinden oluşmaktadır. Bu İtalyan makarnaları genelde benzer besin değerlerine sahiptir ve sadece şekil ve boyut yönünden farklılık gösterirler. Kalori cetveli spaetzle, yumurtalı noodle, mantı ve tatar böreği gibi erişteleri ve makarna hamurlarını da içermektedir. Bu kalemler, ravioli de dahil olmak üzere, hamur ek olarak peynirli iç malzeme gibi başka bileşenler de içerebilirler. Bu bileşenlerin ek kalori, yağ ve protein içeriklerine dair besin bilgileri için besin etiketlerini kontrol edin. Aşırı kalori alımından kaçınmak için porsiyon boyutuna özellikle dikkat edin. Belirtilen boyut düşündüğünüzden çok daha küçük olabilir. Internetten ulaşabileceğiniz kalori listelerinden bir porsiyonun kaç grama veya adede (ravioli) denk geldiğini öğrenebilirsiniz.", "https://www.kaloricetveli.org/wp-content/uploads/makarna-ve-noodle.jpg"));
            categories.Add(new Category("Meyve Suları", "Meyve suları, sıkma işlemi esnasında liflerini kaybettikleri için hemen hemen saf şeker haline gelirler. Meyvelerin sıkılmasıyla elde edilen sıvı, vitaminler gibi birçok mikro besin içerse de aşağıda yer alan kalori cetveli bir porsiyon meyve suyunun çok fazla kalori içerdiğini göstermektedir. Meyve suyunun besin değerleri ile gazlı içecekler gibi meşrubatların besin değerleri karşılaştırıldığında, her ikisinin de benzer oranlarda şeker içerdiği açıkça görülmektedir. Ancak, rafine beyaz şeker (sakaroz) ve yüksek früktozlu mısır şurubunun aksine meyve şekeri (früktoz), vücudun tatlı gıda ihtiyacını gidermede tamamen doğal bir yoldur. Taze sıkılmış meyve suyu çok çeşitli vitamin ve antioksidanın yanı sıra çinko, demir, kalsiyum ve magnezyum gibi mineraller içerdiğinden, aynı zamanda besleyici değere sahiptir. Meyve suyunun içerdiği kalori, günde en fazla 250 ml içilmesi halinde sağlıklı ve aktif bir insanın dengeli beslenme programının bir parçası olabilir. Meyve suyu kutusunun veya şişesinin üzerinde yer alan besin etiketinden porsiyon miktarını ve şeker ilavesi olup olmadığını kontrol edin. Özellikle kilo verme programı uyguluyorsanız kalori cetveli üzerinden, içeceğiniz meyve suyu miktarının bir bütün bir elma gibi bir atıştırmalığa eşdeğer olup olmadığına dikkat edin. İçeceğiniz meyve suyu sayfada yer alan kalori cetvelinde yer almıyorsa, İnternet üzerinden rahatlıkla kalori tablosuna ulaşabilirsiniz.", "https://www.kaloricetveli.org/wp-content/uploads/meyve-sulari.jpg"));
            categories.Add(new Category("Meyveler", "Meyvelerin tümü çoğunlukla karbonhidratlardan oluşmakla birlikte, kalorileri yağlardan ve az miktarda proteinden de kaynaklanabilir. Bununla birlikte karbonhidratların tamamı tek tip olmayıp, genellikle kompleks (üç ya da daha fazla sayıda bağlı şekerler) ve basit karbonhidratların (basit şekerler) karışımından meydana gelmektedirler. Bu, glikoz ve früktoz miktarının -doğal meyve şekerleri- meyvenin türüne göre değişkenlik gösterdiği anlamına gelmektedir. Örneğin, muz ve incirde şeker oranı yüksektir ve bu meyveler çok tatlıdırlar. Buna karşın, limon ve yaban mersini düşük şeker oranlarından kaynaklanan ekşi lezzetleriyle tanınırlar. Meyveler, belirtilen tat farklılıkları ne olursa olsun, düşük kalorili besinler olarak nitelendirilirler. Porsiyon başına yüksek seviyede vitamin ve mineral içerdikleri için meyvelerin iyi besin değerine sahip oldukları söylenir. Ayrıca, avokado ve hindistancevizi gibi türler sağlıklı yağlar içerirler. Bir gram yağ, eşdeğer ağırlıktaki protein ya da karbonhidratlara göre iki kat daha fazla kalori içerdiğinden, bu yüksek yağlı meyvelerin daha yüksek kalori yoğunluğuna sahip olduklarını bilmek önemlidir. Taze meyveler besin bilgilerini içeren etiketlerle satılmazlar. Bununla birlikte bu meyvelerin içerdikleri kalorileri kalori cetvellerinden öğrenmek mümkündür. Amacınız ister karbonhidrat alımını kısıtlamak, isterse kalori saymak veya sadece daha fazla işlenmemiş yiyecek yemeye çalışmak olsun, kalori cetveli hangi meyvelerin sağlıklı diyet planınıza daha uygun olduğunu ortaya koyacaktır.", "https://www.kaloricetveli.org/wp-content/uploads/meyveler.jpg"));
            categories.Add(new Category("Otlar ve Baharatlar", "Pişmiş yiyeceklerin içindeki ot ve baharatların kalorileri sıklıkla ihmal edilebilir düzeydedir. Bunun nedeni bu malzemelerin, tarçın için bir fiske veya kuru fesleğen için bit kaşık olmak üzere, küçük miktarlarda kullanılmasıdır. Bununla birlikte çok sayıda porsiyon için hazırlanmış olan bir tarifte bitki ve ve baharatlara bağlı kalorilerin göz önüne alınması gerekebilir. Kalori cetvelindeki az sayıda kalem, küçük miktarlarda kullanıldığında bile, özel işlem görmüş olmaları nedeniyle kaloride önemli oranda artışa yol açar. Bu duruma bir örnek olarak karamelize zencefil yapımında şeker kullanılmasıdır. Kümes hayvanlarının etlerinin terbiye edilmesinde kullanılanları da içeren birçok baharat karışımı fazla miktarda tuz da içerebilir. Sodyum ve şeker düzeylerinin kesin olarak belirlenmesi için besin bilgilerini kontrol edin. Kalori cetvelinde iyotlu tuz olarak listelenmiş bulunan sofra tuzu kalori yoğunluğu düşüktür. Bununla birlikte günlük önerilen miktar olan 2000 mg aşıldığında, sağlığınız yönünden, kan basıncınızda artış şeklinde ortaya çıkan olumsuz etkileri bulunmaktadır. Bitkiler ve baharatlar temelde besinlere toplam kaloriyi artırmaksızın aroma eklemek için kullanılırlar. Bununla birlikte bu bileşenlerin sıklıkla sağlığımız yönünden olumlu faydaları da bulunmaktadır. Örnek olarak acı kırmızı biber, endorfin salgılatan ve antienflamatuvar olarak davranan capsaicin ve içerdiğinden, tarhun otu ise zengin bir antioksidan, vitamin ve kalsiyum ve demir gibi mineral kaynağı olduğundan yüksek besin değerine sahiptir. Hazır olarak satılan baharat karışımlarının kalorilerini, ambalaj üzerinde yer alan kalori listesinden öğrenebilirsiniz.", "https://www.kaloricetveli.org/wp-content/uploads/otlar-ve-baharatlar.jpg"));
            categories.Add(new Category("Pasta Malzemeleri", "Hamurlu fırın ürünlerinde sık kullanılan malzemeler, buğday unu, tereyağı ve şeker gibi yüksek kalorili besinlerdir. Bu bileşenler çoğunlukla kan şekeri seviyelerinde hızlı dalgalanmalara ve kilo artışına neden olan vücut ağırlığında artışa neden olan yağlar ve basit karbonhidratlar içerdiğinden, bunlardan yapılan fırın ürünlerinin besin değerleri düşük olma eğilimindedir. Bununla birlikte, yumurta gibi bazı bileşenler kolin ve lütein gibi sağlıklı protein ve besin bileşenleri içerdiğinden oldukça besleyici olabilirler. Hamurlu fırın ürünlerinde sık bulunan tarçın ve maya gibi diğer malzemeler çok küçük miktarlarda kullanıldığından kalorileri ihmal edilebilir düzeydedir. Buna rağmen bu tatlandırıcı ve kabartıcıların kendilerine özgü sağlıklı özellikleri bulunmaktadır. Her ne kadar kalori cetveli bu bileşenlerin enerji katkılarının düşük olduğunu gösterse de, sık kullanılan baharatların antienflamatuvar, kilo verdirici ve hastalıklara iyi gelen yönleri olduğu bilinmektedir. Aynı şekilde, mayalar B kompleksi vitaminleri, çinko ve potasyum gibi besin bileşenleri içermektedir. Düşük kalorili ya da kalorisiz fırın bileşenleri sükraloz ve stevia gibi yapay tatlandırıcılar ve şeker ikameleri de içerirler. Araştırmalar kimyasal tatlandırıcıların sağlık açısından zararları olduğunu ve şeker krizlerini arttırdığını göstermiştir. Bu nedenle bu bileşenlerin tüketimi en az düzeyde tutulmalıdır. Hazır kek karışımları ve diğer paketlenmiş hamur işleri üzerindeki besin etiketleri beslenme programınıza uygunlukları yönünden kontrol edilmeli, kalori tablosundan porsiyon başına kalorileri incelenmelidir.", "https://www.kaloricetveli.org/wp-content/uploads/pasta-malzemeleri.jpg"));
            categories.Add(new Category("Pastalar, Ekmek ve Unlu Mamuller", "Bu kalori cetveli, fırınlarda üretilen ve aralarında somun ekmeklerin, pide ve tandır ekmeği gibi bazlamaların, sandviç ekmeklerinin ve pastaların bulunduğu çok çeşitli unlu mamulleri listelemektedir. Belli başlı ekmek türleri benzer besin değerlerine sahiptir çünkü hepsi de buğday unu ve yumurtadan yapılmaktadır. Bununla birlikte tam oranlar farklılık gösterebilmektedir. İçerikler, özellikle maya da, ekmeğin yoğunluğunu etkileyen unsurlardan biridir. Mesela, simit ve pideden aynı miktarda yemiş olsanız bile, pideden alacağınız kalori daha fazla olacaktır. Sandviç ekmekleri ve somunları tohum ve tam tahıl içerecek şekilde de üretilmiş olabilir. Bu tip ekmekler daha kalorili olmakla birlikte besin değerleri daha yoğundur. Kruvasan, yağlı çörek ve pay hamurları gibi pastahane ürünleri, yağ yani porsiyon başına kalori miktarını arttıracak şekilde çok yüksek oranda katı veya sıvı yağ içerirler. Bu ürünler sıklıkla kuru yemiş, meyve, çikolata ve dondurma ile süslenir ya da doldurulurlar. Bu malzemelerin hepsi hamur işinin kalorisini artırmakla kalmaz, çoğunlukla şeker oranını da artırır. Unlu mamullerin besin bilgilerini, özellikle yüksek früktozlu mısır şurubu formundaki şeker katkısı yönünden inceleyin. Kilo vermeye veya kilonuzu korumaya yönelik bir beslenme planı uyguluyorsanız da, kalori tablolarından veya malzemelerin yer aldığı kalori cetvellerinden bir porsiyon hamur işinin kalorisini hesaplayın.", "https://www.kaloricetveli.org/wp-content/uploads/pastalar-ekmek-ve-unlu-mamuller.jpg"));
            categories.Add(new Category("Patates Ürünleri", "Patates, hızla sindirilen ve vücudun enerji için yakabileceği şekere dönüşen basit karbonhidratlardan zengin nişastalı bir kök sebzedir. Ancak bu, patatesten alınacak kalorilerden mutlaka kaçınılması ve kompleks karbonhidratlara sahip besin maddelerinin tercih edilmesi anlamına gelmemektedir. Patatesin kabuğundaki lifler, domatesten daha fazla C vitamini ve muzdan daha fazla potasyum içermektedir dolayısıyla patates besin değeri taşımaktadır. Bununla birlikte, yağda kızartılmış patateslerin en sağlıklı pişirme yöntemi olmadığı da herkesçe bilinen bir gerçektir. Aşağıdaki kalori cetvelinde de görülebileceği üzere yüksek kalori yoğunluğu, bu yöntemle hazırlanan patateslerde yüksek miktarda yağ bulunduğunu gösterir. Patates graten ve patates salatası gibi diğer yemekler de, içlerine eklenen peynir, tereyağı ve mayonez gibi malzemelerden kaynaklanan yüksek miktarda yağ içerebilirler. İlgili kalori cetvellerinden patatese ilave ettiğiniz malzemelerin kalorilerini hesaplayabilir, patatesli yemekleri sıkça tüketiyorsanız el altında bir kalori tablosu bulundurabilirsiniz. Fazla kalori alımından kaçınmak için patatesleri kaynar suda pişirin ya da ince bir zeytinyağ tabakası ile kaplayarak fırınlayın. Birçok patates türü ve patates ürünü bulunmakta ve karbonhidrat, protein ve mikro besinlerle ilgili besin değerleri az da olsa farklılıklar göstermektedir. Örneğin, kırmızı kabuklu patatesler beyaz türlere göre daha fazla antioksidan içermektedir. Tatlı patatesler ise, hem diğer patates türlerine göre daha fazla A vitamini ve kalsiyum içerir, hem de daha az kalori barındırır.", "https://www.kaloricetveli.org/wp-content/uploads/patates-ueruenleri.jpg"));
            categories.Add(new Category("Peynir", "Peynir, yağ ve protein içerir; karbonhidrat kaynaklı kalori oranı çok düşüktür. Bir süt ürünü olan peynirin besin değeri sütün besin değeriyle benzerlik gösterse de, peynir daha yüksek kalori yoğunluğuna sahiptir. Yağ-protein oranı peynirin türüne, sütün elde edildiği hayvana ve peynirin tam yağlı sütten mi, yoksa az yağlı sütten mi yapıldığına bağlı olarak farklılık göstermektedir. Aşağıdaki kalori cetvelinde, yağ oranı yüksek peynirler, gram başına daha yüksek kalori değerleriyle ya da daha küçük porsiyon miktarları ile belirtilmiştir. Tüketeceğiniz peynirin kalorisini hesaplarken kalori cetvellerini bu gözle incelemek faydalı olacaktır. Birçok kalori tablosunda porsiyon ölçüsü olarak kibrit kutusu büyüklüğü ifadesi kullanılsa da, gram hesabı yapmak daha sağlıklı olacaktır. Peynirler birçok kategoride sınıflandırılabilirler. Örneğin, haftalardan yıllara kadar değişen olgunlaşma sürelerine göre taze veya olgun adlandırılabilirler. Ayrıca, kıvamına yani nem içeriğine göre yumuşak, yarı yumuşak ve sert olarak sınıflandırılmaları da mümkündür. Genel olarak, Parmesan gibi olgun bir peynir türü, süzme peynir gibi taze bir peynir türüne nazaran daha kalori yoğundur. Amerikan peyniri gibi işlem görmüş peynirler süt yağı karışımı, peynir altı suyu, peynir kültürleri, besin boyası ve kimyasal emülgatörler gibi ek bileşenler içerirler. Bu bileşenler, besin bilgilerini gösteren etiketlerde rahatlıkla görülebilir. İşlem görmüş peynirler, doğal peynirlere kıyasla daha fazla sodyum ve doymuş yağ içerebilirler.", "https://www.kaloricetveli.org/wp-content/uploads/peynir.jpg"));
            categories.Add(new Category("Pizza", "Pizza bizde suçluluk duygusu uyandıran yiyeceklerden biri olarak kötü bir şöhrete sahip olsa da, sosuna ve üst malzemesine bağlı olarak belli bir oranda besin değeri içerebilir. Pizza hamurunun nasıl hazırlandığı da kalori seviyesini ve sağlıklılığını etkiler. Beyaz un yerine tam tahıllı un kullanılması kompleks karbonhidratların miktarını arttırır. Bu aynı zamanda besin yoğunluğunu da arttırmaktadır. Çalışmalar, tam tahıllı unlar ile, inme ve tip 2 diyabet riskinin azalması arasında ilişki bulmuştur. Pizza üzerindeki malzeme yediğiniz pizza diliminin genel besin değeri üzerine en büyük etkiyi yapar. Yüksek kalorili malzemeler peynir, yağlı soslar, alfredo (beyaz) sosu ve her daim popüler İtalyan salamı gibi salamları içerir. Düşük kalorili pizzalar biber gibi birçok sebze, ıspanak gibi taze yeşillikler ve mantarlar kullanılarak hazırlanırlar. Pizzaların kalori değeri çok geniş bir değişkenlik gösterdiğinden bu kalori cetveli, Pizza Hut gibi belirli restoran ürünleri haricinde, genel bir rehber olarak kullanılmalıdır. Sonuç olarak, pizzanın kalorisi, hamuruna ve üzerindeki malzemeye göre farklılık gösterdiğinden, kalori cetvellerinde veya kalori tablolarında buna dikkat edilmelidir.", "https://www.kaloricetveli.org/wp-content/uploads/pizza.jpg"));
            categories.Add(new Category("Sakatat ve İç Organları", "Sakatat terimi genellikle hayvanların kalp ve karaciğerleri gibi iç organlarını tanımlamakta kullanılsa da, tavuk ayağı ve inek dili gibi sert parçalar da bu grup altında sınıflanır. Bu grup içerisinde bulunan ve taşlığın da dahil olduğu kuş iç organları, kümes hayvanlarından elde edilen özel bir sakat olup, örneğin yılbaşında kızarttığımız bütün bir hindinin içinde bulunabilir. Bu atık et parçaları, Fransız mutfağındaki kaz ciğeri örneğinde olduğu üzere, bazı mutfak türlerinde özel lezzetler olarak kabul edilir. Bu kalori cetvelindeki yiyeceklerin çoğu pek rağbet görmese de, araştırmalar sakatatların yüksek besleyici değeri olduğunu ortaya koymaktadır. Örneğin beyin, bağışıklık sistemimizin korunması için gerekli selenyum ve bakırı içerir. Fakat, bu sakatat deli dana hastalığı riskini taşır. Bu nedenle sakatat yenecekse, bunların otlaklarda beslenmiş, sağlıklı hayvanlardan elde edilmiş olması önem taşır. Çiftlik hayvanlarının yemleri bu hayvanların organları başta olmak üzere etlerinin besin değerlerini etkiler. Birçok sakatat türü yüksek oranda yağ içerdiğinden, -örneğin dil %70 yağ içermektedir-, kalori bakımından yüksektirler. Yürek ve böbrek gibi diğer sakatat türleri yağ ve kalori yönünden daha fakir olmakla birlikte diğer sakatatlar kadar zengin birer protein ve besin kaynağıdırlar. Sakatatların içerdikleri kalori, ambalaj üzerindeki kalori tablosundan veya internette yer alan kalori listelerinden öğrenilebilinir.", "https://www.kaloricetveli.org/wp-content/uploads/sakatat-ve-ic-organlari.jpg"));
            categories.Add(new Category("Sebzeler", "Sebzelerin, herkesin beslenme programının düzenli bir parçası olması gerektiği su götürmez bir gerçektir. Bunun neden böyle olduğunu bu kalori cetveline bir kere bakmakla kolayca anlayabilirsiniz. Büyük bir porsiyon sebze çok fazla kalori içermemekle birlikte, vitamin, mineral ve diğer besinlerin olağanüstü bir miktarını bünyesinde bulundurur. Sebzeler karbonhidratların bir karışımını ve daha az miktarlarda sağlıklı yağları ve proteinleri içerir. Aynı zamanda, besinsel liflerin en değerli kaynaklarından birini oluşturur. Bu özellikleri enginar, patates gibi nişastalı sebzeler ve kara lahana gibi yapraklı yeşilliklerin yüksek besinsel değere sahip olmasının nedenlerinden biridir. Hatta bu süper besinler gerekli besin bileşenleri yönünden bir günlük gereksinimimize bedeldir. Brokoli günlük önerilen C vitamini miktarının iki katını içinde barındırır. İster inanın, ister inanmayın, bir orta boy patates gereken A vitamini beş katından daha fazlasına sahiptir. Vejetaryen veya vegan diyeti uygulayanlar bol miktarda ıspanak yemeyi ihmal etmemelidirler. Bu sebzenin her yarım bardağında 3 gram protein bulunur. Taze bir sebze salatasına kalori eklemeden protein katmanın daha iyi bir yolu var mıdır? Taze sebzeler besin bilgiler içermeksizin satıldıklarından, alttaki bilgiler ve kalori cetveli sağlıklı beslenme programınız için hangi sebzelerin daha uygun olacağına karar vermenize yardımcı olacaktır.", "https://www.kaloricetveli.org/wp-content/uploads/sebzeler.jpg"));
            categories.Add(new Category("Sığır ve Dana Eti", "Her ikisi de büyükbaş hayvanlardan elde edilen sığır ve dana etleri yağ ve proteinden meydana gelmektedir. Besin bileşenlerinin oranları hayvanın etin elde edildiği bölgesine göre değişir. Hayvanın hangi kesimlerinin daha yüksek kaloriye sahip olduğunu yani daha fazla yağ içerdiğini görmek için kalori cetvelini kontrol edin. Kalori ve yağ arasındaki bu ilişkinin nedeni bir gram protein dört kaloriye eşitken, bir gram yağın dokuz kalori içermesidir. Özellikle paketlenmiş kıyma veya et ürünleri üstünde bulabileceğiniz ürün ya da besin etiketi, bu besin değerini yüzdelerle temsil eder. Örnek olarak etikette yazan %85 yağsız ibaresi, etin %15 yağ içerdiğini gösterir. Sığır eti biraz daha yüksek olmak üzere, tüm kırmızı etler güçlü birer demir ve çinko kaynağıdır. Bununla birlikte, dana eti niyasin ve riboflavin gibi B vitaminleri için daha iyi bir kaynaktır. Sığır ve dana etlerinin kalorisinin yeterli bir bölümü doymuş yağlardan kaynaklanır. Bu nedenle standart sağlıklı bir diyette bu ürünlerin haftada sadece iki ila dört porsiyon (60 ila 120 gram) düzeyinde tüketilmesi önerilir. Hangi tip sığır etlerinin beslenme ihtiyacınıza uygun olduğunu öğrenmek içim besin bilgilerini kontrol edin. Tüketeceğiniz etin kalorisini öğrenmek için kalori cetvellerindeki veya kalori listelerindeki porsiyon miktarına dikkat edin.", "https://www.kaloricetveli.org/wp-content/uploads/sigir-ve-dana-eti.jpg"));
            categories.Add(new Category("Sıvı ve Katı Yağlar", "Sıvı ve katı yağların kalorileri, kategori isimlerinde belirtildiği üzere, karbonhidratlardan veya proteinlerden ziyade hemen hemen tamamen yağlardan kaynaklanmaktadır. Bununla birlikte, bu durum kalori cetvelinde bulunan bu tip besin ürünlerinin sağlıksız olduğu anlamına gelmemektedir. Yağ, kişisel gereksinimler ne olursa olsun, her dengeli diyetin önemli bir parçasını oluşturmalıdır. Yağdan sağlanan kaloriler günlük toplam kalori alımının %20 ila %40’ına tekabül edebilir. Atkins ve Paleo gibi bazı diyet programları kuru yemiş, zeytin, haşhaş, ay çekirdeği ve avokadoda bulunan sağlıklı yağların yenmesinin önemini vurgulamaktadır. Bu kaynaklardan elde edilen yağların pişirmede kullanılması önerilmektedir. Tüketiminde aşırıya kaçılmadığı sürece gerçek tereyağı bile sağlıklı bir yağ kaynağı olabilir. Örneğin, bir dilim kızarmış ekmek üzerine sürülen tereyağı, doktorunuz veya diyetisyeniniz sınırlı kolesterol alımını önermediği sürece, çoğu birey için kabul edilebilir. En iyi yağlar çoklu doymamış ve tekli doymamış olanlardır, trans yağlardan ise her zaman uzak durulmalıdır. Favori yiyeceklerinizde hangi tip katı ve sıvı yağların bulunduğunu öğrenmek içim kalori tablolarını ve besin bilgilerini kontrol edin.", "https://www.kaloricetveli.org/wp-content/uploads/sivi-ve-kati-yaglar.jpg"));
            categories.Add(new Category("Soda ve Meşrubatlar", "Gazlı içecekler gibi meşrubatlar diğer aromalarının yanında şeker gibi tatlandırıcılar içermeleriyle ünlüdürler. Bu içecekler alkolsüz olmakla birlikte, rom-Kola örneğinde olduğu üzere, kokteyl yapımında kullanılabilirler. Birçok meşrubat, gazlı içecek özelliği kazandırılmak üzere karbonatlı su kullanılarak yapılsa da, bu grupta meyve pançı gibi gazsız olanlar da mevcuttur. Ortak bileşenleri sıklıkla şeker, yani yüksek früktozlu mısır şurubu olduğundan, meşrubat ve gazlı içeceklerin kalorisi boş kaloriler olarak değerlendirilir. Bu durum, bu meşrubatlarda kalori cetvelinde porsiyon başına belirtilen enerji miktarı başına, vücudunuzun iyi yağlanmış bir makine gibi işlemesi için gerekli besinlerden çok az bulunduğu anlamına gelmektedir. Bunu, kendiniz de en sevdiğiniz meşrubatın besin bilgilerinde görebilirsiniz. Meyve aromalı gazlı bir içecek olan Fanta içmek yerine, Fanta’dan alınacak kalori potasyum içeren muz ya da yüksek oranda C vitamini içeren portakal gibi meyvelerden bir parça yemekle de sağlanabilir. Özellikle kilo verme odaklı bir beslenme programı uyguluyorsanız, meşrubatların kalori cetvellerini dikkatle incelemenizde fayda var. Diyet gazlı içecekler daha az kalori içermekle birlikte, içlerinde yüksek oranda yapay tatlandırıcılar, aromalar ve boya maddeleri barındırırlar.", "https://www.kaloricetveli.org/wp-content/uploads/soda-ve-mesrubatlar.jpg"));
            categories.Add(new Category("Sosis ve Sucuk", "Kıymadan yapılan bir yiyecek ürünü olan sosis, hemen her hayvanın etinden veya et yerine kullanılan vejetaryen ürünlerden üretilebilir. Bu nedenle, niteliklerine bağlı olarak kalori ve yağ içerikleri büyük değişkenlik gösterebilse de, sosislerin tümü ciddi miktarda tam protein içermektedir. Farklı sosis türleri hakkında bilgi edinmek için, öncelikle sosisin yapılmış olduğu etin (ör. tavuk veya domuz) besin değerine ve kalori tablosuna bakın. Sosisler, düşük yağlı sosis üretiminde yağsız hindi göğsünün kullanılması örneğindeki gibi, hayvanın herhangi bir yerinden yapılabilse de, üretimde genellikle kesimden arta kalanlar kullanılmaktadır. Sosisli sandviçte kullanılan sosisler ve domuz sosisleri gibi bazı belirli türler, sıklıkla kelle ve pıhtılaşmış kan gibi sakatat içerirler. Ancak her sosis türü hayvanların bu çok arzu edilmeyen yan ürünlerinden yapılmaz. Sosisler geleneksel olarak hayvan bağırsaklarının içi doldurularak yapılır, ancak bu durum da her sosis türü için geçerli değildir. Aşağıda yer alan kalori cetveli, sosis harcında birçok farklı malzemenin kullanıldığı göz önünde tutulmak kaydıyla, bir rehber olarak kullanılabilir. Kalori cetvelinin kullanımında porsiyon miktarlarına da dikkat edilmesi gereklidir. Özel içeriklerin yanı sıra yağ içeriği, kalori yoğunluğu ve düzenli tüketildiğinde kanser riski oluşturan ya da oluşturmayan sodyum benzeri koruyucuların varlığı gibi hususları içeren diğer bilgiler açısından besin etiketlerini kontrol edin.", "https://www.kaloricetveli.org/wp-content/uploads/sosis-ve-sucuk.jpg"));
            categories.Add(new Category("Soslar ve Salata Sosları", "Bu kalori cetveli, kendi başlarına tüketilmemekle birlikte, yemeklere önemli oranda kalori katkısı yapan besin bileşenlerini içermektedir. Bu nedenle, erişte veya tavuk göğsü yemeklerin ana bileşenlerinin besin değerlerinin yalnız başlarına dikkate alınmaması, bu yemeklerdeki sosların da kalori hesabına eklenmesi önem taşımaktadır. Bu besin grubunun adı ortak bileşenlerden ziyade yemeğin belirli bir parçasını tanımladığından, sosların besin bilgileri geniş değişkenlik gösterebilir. Acı sos gibiler hemen hiç kalori içermemekle birlikte yemeğin lezzetini önemli ölçüde değiştirir. Tam yağlı ekşi krema sosu gibiler ise daha yüksek kalori yoğunluğuna sahiptirler. Salata soslarının ve terbiye karışımlarının çoğu düşük kalori içermekle ve porsiyon boyutları küçük olmakla birlikte, yüksek oranda yağ ve şeker katkısı içerebilirler. Lezzetlendiriciler yüksek früktozlu mısır şurubu ile tatlandırılmış olabilirler. Ketçaplar bu duruma bir örnek oluştururlar. Daha fazla bilgi için besin etiketini ve besin içeriğini gözden geçirin. Temel olarak besleyici besleyici bir yemekteki gereksiz kalori yükünü sınırlamak için salata soslarını, özellikle zeytin yağından yapılmışlarsa, tedbirli bir şekilde kullanmak uygun olur.", "https://www.kaloricetveli.org/wp-content/uploads/soslar-ve-salata-soslari.jpg"));
            categories.Add(new Category("Söğüş Et ve Şarküteri Ürünleri", "İşlem görmüş etlerin kalorileri temelde proteinlerden kaynaklanır. Fakat, aşağıdaki besin bilgilerinde gösterildiği üzere, salam gibi sığır ve domuz ürünlerinde en az bir o kadar hayvansal yağ kaynaklı kalori bulunmaktadır. İnce dilimlenmiş işlem görmüş söğüş etler sandviçlerdeki temel gıda maddeleridir. Bu çeşit etler, yüksek besin değerine sahip fırınlanmış ya da kızartılmış yağsız hindi, tavuk ve domuz etlerini yemenin çok kolay bir şeklidir. İşlem görmüş etler, örneğin fırınlanmış sığır eti ve bologna gibi değişik sosis tipleri, kalori yönünden çok zengin olabilir. İşlem görmüş söğüş etler sıklıkla, ordövr tabağında olduğu üzere, sıklıkla dilimlenmiş sebzelerin ve peynirlerin yanında iştah açıcı olarak servis edilirler. Popüler işlem görmüş etlerin porsiyonlarını karşılaştırmak için kalori cetvelini gözden geçirin. Bu kalori cetvelinde daha yüksek kalori daha yüksek yağ oranı anlamına gelmektedir. Çoğu işlem görmüş et insan sağlığı üzerine etkisi oldukça tartışmalı olan bir koruyucu madde olan sodyum nitrat ile imal edilmiştir. Ayrıca yapay aromalar, mısır nişastası gibi katkı maddeleri ve şeker ilavesi için besin bilgilerini kontrol edin. Her ne kadar tatlı olmasalar da, mezelik etler, besin bilgilerinde gösterildiği üzere sıklıkla bal, akçaağaç şurubu veya yüksek früktozlu mısır şurubu içerirler.", "https://www.kaloricetveli.org/wp-content/uploads/soegues-et-ve-sarkueteri-ueruenleri.jpg"));
            categories.Add(new Category("Süt ve Süt Ürünleri", "Süt, birçok hayvandan elde edilebilen besleyici bir sıvı gıdadır. Ancak dünyada en yaygın olarak inek sütü tüketilmektedir. Bu nedenle aşağıdaki kalori cetvelinde yer alan mandıra ürünleri -aksi belirtilmedikçe- inek sütünden yapılmıştır. Uygulamada yer alan kalori cetvelinde bulamadığınız ürünler için internetten farklı kalori listeleri inceleyebilirsiniz. Süt ürünleri dengeli oranlarda yağ, karbonhidrat ve protein içermesinin yanı sıra, değerli bir kalsiyum, riboflavin (B2 vitamini) ve B12 vitamini kaynağıdır. Tam yağlı süt eşit miktarlarda yağ ve protein içerirken, az yağlı süt gibi diğer çeşitlerde yağ içeriği büyük oranda veya tamamen azaltılmış ve kalorileri düşürülmüştür. Diğer yandan, ağır krema (kaymak) ve tereyağ daha yüksek oranda yağ içermektedir. Sütün temel bileşeni, birçok bireyin sindirim sistemini olumsuz yönde etkileyen doğal bir şeker olan laktozdur. Badem sütü ve hindistancevizi sütü gibi hayvansal olmayan, bitki esaslı sütler hayvansal sütlerden farklı besin değerlerine sahip olsalar da, hayvansal sütlerin iyi birer ikamesidir. Hayvansal süt ve süt ürünlerinin kutu, ambalaj veya şişelerinde yer alan besin etiketinden ürünün içerdiği yağ, protein ve karbonhidratlar hakkında spesifik bilgilere ulaşabilirsiniz. Ayrıca bitki esaslı sütlerin kalorilerini ambalaj üzerinde yer alan kalori tablosundan öğrenebilirsiniz.", "https://www.kaloricetveli.org/wp-content/uploads/suet-ve-suet-ueruenleri.jpg"));
            categories.Add(new Category("Şarap", "Meyve suyu fermente edildiğinde ve şekeri alkole dönüştüğünde elde edilen içecek şarap olarak adlandırılır. Bu alkollü içkiler genellikle üzümden yapılsa da, şarap kalori cetvelinde de görüldüğü üzere, şarap yapımında erik gibi başka meyve türleri de kullanılabilir. Şarap, farklı aromalar elde etmek için diğer malzemelerle de karıştırılabilir ve bu işlem çikolata ilaveli şarap örneğinde görüldüğü üzere gram başına kalori miktarını artırır. Aşağıdaki kalori listesinde, şarapla hazırlanan popüler bir kokteyl olan sangria da bulunmaktadır. Sangria, ayrıca çeşitli meyve suları ve çeşitli sert likörler kullanılarak da yapılabilir. Dolayısıyla, kalori cetvelinde belirtilen kalori miktarları sadece genel bir fikir edinmenizi sağlar. Saf şarapların besin değerleri görece aynıdır. Bir kadeh şarap genel olarak 150 ve 200 kalori arasında olsa da, bu değer şarabın tatlılığına, karbonasyonuna (Prosecco şarabında olduğu üzere) ve alkol miktarına göre farklılık gösterir. Porto şarabı gibi tatlı bir şarabın kalorisi, klasik kırmızı şarabın kalorisinin iki katı ve sek beyaz şarabın üç katı kadardır. Şarabın birçok çeşidi ve harmanı olduğundan, kesin bilgi edinmek için şişe üzerindeki besin değerlerine bakılmasında fayda bulunmaktadır.", "https://www.kaloricetveli.org/wp-content/uploads/sarap.jpg"));
            categories.Add(new Category("Şekerleme ve Tatlılar", "Şekerleme ve tatlılar kalori yoğun yiyeceklerdir. Ayrıca, adlarından da anlaşılacağı üzere bu yiyecek grubunun üyeleri hiçte şaşırtıcı olmayan şekilde yüksek oranda şeker de içermektedirler. Bu nedenle bu gruptaki yiyecekler küçük porsiyonlar şeklinde ve dikkatle tüketilmelidir. Şekerleme ve tatlılar, rahatlatıcı ikramların çoğunda olduğu üzere, dengeli bir beslenme programı için gerekli yiyecekler değildirler. Bunun anlamı, şekerlemeler ve diğer tatlılardan alınacak kalori ya da enerjinin yüksek besin değerlerine sahip meyve ve sebze gibi diğer yiyeceklerden alınmasının daha yararlı olacağıdır. Şekerleme ve tatlıların çoğunun besin bilgilerine hızlıca bakıldığında, kalorilerinin çoğunun basit şeker biçiminde olduğu görülür. Ürün, kimi durumda, yüksek früktozlu mısır şurubu benzeri %100 oranında işlem görmüş şekerden oluşur. Akçaağaç şekeri veya mısır şekeri gibi bazı basit şekerleme türleri doğal şekerin işlenmemiş türlerinden yapılmış olabilirler. Paketlenmiş kurabiyeler ve çubuk şekerler gibi diğer şekerleme ve tatlı ürünleri, kanola yağı ve lezzet katkıları gibi uzun bir besin bileşeni listesi içerebilirler. Kalori cetvelinde verilen besin bilgiler temelinde değerlendirildiğinde, porsiyon başına düşük kalori içeren bir şekerleme olasılıkla saf şekerdir. Benzer şekilde, porsiyon başına daha fazla kalori içeren şekerleme ise olasılıkla yağ ve şeker karışımından yapılmıştır.", "https://www.kaloricetveli.org/wp-content/uploads/sekerleme-ve-tatlilar.jpg"));
            categories.Add(new Category("Tahıllar ve Tahıllı Ürünler", "Bu kalori cetveli buğday, arpa ve mısır gibi tam tahılların yanı sıra bu temel bileşenlerden üretilen kraker ve gofretleri de içermektedir. Bu kalemler farklı miktarlarda yağ ve protein içermekle birlikte, tahıl ürünlerindeki kalorinin büyük kısmı karbonhidrat biçimindedir. Besinsel liflerin, sağlık açısından, sindirim sisteminin desteklenmesi ve ensülin direncinin düzenlenmesi gibi yararları nedeniyle her gün birkaç porsiyon tam tahıllı gevrek tüketilmesi önerilir. Tahıllar ayrıca önemli miktarda protein içerir. Bir bardak (250 ml) pişirilmiş horozibiği veya kinoa 9 gram protein barındırmaktadır. Tahıl ürünlerinin büyük bölümünde çok az miktarda doymamış yağ bulunur ve bu nedenle az miktarda kalori içerirler. Kalori cetvelinden veya ürünün üzerinde yer alan kalori tablosundan porsiyon başına kalori miktarını öğrenebilirsiniz. Tahıl tanelerinin, vitaminler ve lifleri de içeren besleyici değerlerinin çoğu bu tahıllardan tam buğday unu veya mısır unu gibi ürünlerin üretilmesi işleminde kepeklerin ayrıştırılması sırasında yitirilir. Fakat bu üretim süreci kalorilerin çoğunu uzaklaştırmaz. Besin bilgileri tahıl ürünlerinin vitamin ve minerallerle güçlendirilip , içerik listesi ise tahılların tam ya da rafine olup olmadıklarını ortaya koyar.", "https://www.kaloricetveli.org/wp-content/uploads/tahillar-ve-tahilli-ueruenler.jpg"));
            categories.Add(new Category("Tropik ve Egzotik Meyveler", "Tüm meyveler çoğunlukla karbonhidratlardan oluşsa da, içerdikleri kalori yağlardan ve az miktardaki proteinden de gelebilmektedir. Meyveler, pek çok vitamin ve mineral içerdikleri ve düşük kalorili oldukları için iyi besin değerine sahiptir. Adını, elde edildiği kaktüsten alan Hint inciri, magnezyum ve C vitamininden zengindir. Ancak tropikal ve egzotik meyvelerin her birinin tam faydaları bir miktar farklılık gösterebilir. Muza oldukça benzeyen Hint muzu (plantain), muza oranla çok daha fazla A vitamini ve potasyum içermektedir. Guava, kivi ve mango gibi bazı tropikal meyveler önemli miktarda sağlıklı lif içerirken, avokado gibi diğer tropikal meyveler sağlıklı omega 3 yağ asitleri içermektedir. Bir gram yağın kalorisi, bir gram protein veya karbonhidratın kalorisinin iki katından fazla olduğu için, yağdan zengin meyvelerin daha kalori yoğun olduğunu unutmamakta fayda vardır. Genel olarak taze meyveler, besin değerlerini gösteren paketlerde satılmadıkları için aşağıda yer alan kalori cetveli, hangi tropikal veya egzotik meyvenin sağlıklı beslenme planınıza uygun olduğunu belirlemenizde yardımcı olacaktır. Ayrıca internetten de kolaylıkla bulabileceğiniz kalori tablolarını kullanarak meyvenin büyüklüğüne veya adedine göre kalorisini ve besin değerlerini kolaylıkla öğrenebilirsiniz.", "https://www.kaloricetveli.org/wp-content/uploads/tropik-ve-egzotik-meyveler.jpg"));
            categories.Add(new Category("Yemekler ve Öğünler", "Bu kategori, lazanya gibi ev yapımı akşam yemeklerini, pişmiş olarak satılan ve evde sadece ısıtmanız gereken hazır yemekleri ve Pekin ördeği ve Çin böreği gibi restoran yemeklerini içermektedir. Yemekler, birkaç malzemenin bir arada pişirilmesiyle hazırlandıkları için besin değerleri oldukça farklılık gösterir. Bir yemek yapılırken farklı besin maddeleri bir araya getirilir ve böylece dengeli bir beslenmenin gereksinimlerini karşılamak üzere karbonhidratlardan, yağlardan ve proteinden oluşan bir karışım meydana gelir. Yemekler, birden fazla malzemeden yapıldıkları için çoğunlukla kalori yoğundurlar. Bu sayfada yer alan kalori cetvelinde de görüldüğü üzere bir porsiyon ana ya da yan yemek günlük kalorinin önemli bir miktarını içermektedir. Bir yemeği hazırlarken her bir malzemenin besin değerini tek tek gözden geçirmek zor olabilir; ancak bir kalori sayacı programı (ör. YAZIO) veya tarif (reçete) analizcisi ile her bir porsiyonda ne kadar kalori olduğunu ve besin değerlerini öğrenebilirsiniz. Bu araçlar, marketlerde satılan paketlenmiş hazır yemekler satın almak yerine, evde sağlıklı yemekler yapmanızı kolaylaştırmaktadır. Ayrıca internette de hemen hemen her yemek için kalori tabloları bulunmaktadır. Yapmış olduğunuz yemeğin kalorisini herhangi bir kalori cetvelinden bulamıyorsanız, malzemelerinin kalorilerini hesaplayabilirsiniz.", "https://www.kaloricetveli.org/wp-content/uploads/yemekler-ve-oeguenler.jpg"));
            categories.Add(new Category("Yoğurtlar", "Bu kalın ve kremamsı süt ürünü, hayvansal veya bitki temelli sütlerin belirli bakteri kültürleri ile fermente edilmesi ile üretilir. Yoğurt, genel olarak inek sütünden elde edildiği için kalsiyum ve proteinden zengin besin değerine sahiptir. Daha fazla bilgi için süt ve süt ürünleri kalori cetvelini inceleyin. Fermantasyon işlemi yoğurda keskin bir aroma verir ayrıca yoğurdun içerdiği bakteriler sindirim sistemi için son derece yararlıdır. Aktif kültürler içeren yoğurt, sağlıklı bir bağışıklık sistemi için faydalı olabilir. Yoğurtta aktif kültür olup olmadığını ürünün paketi üzerinde, besin etiketi yanında bir not olarak görebilirsiniz. Yoğurt tek başına son derece besleyici olsa da, ilave şeker eklenerek aromalı türleri ve parfe halinde sunulan türleri de bulunmaktadır. İlave şekerli yoğurdun kalorisini, paketin üzerinde yer alan kalori tablosundan görebilirsiniz. Yoğurt, süt ürününden gelen doğal şekeri halihazırda içermektedir ancak ilave olarak basit masa şekeri veya şurup gibi bir tatlandırıcı içerip içermediğini paket üzerinden kontrol edin. Bu yaklaşık bir çay kaşığı tutarındaki ilave şeker yoğurdun kalorisini ciddi oranda artırmasa da, kan şekeri seviyesi üzerinde olumsuz etkisi olacaktır. Yoğurdu meyveli veya aromalı yemek istiyorsanız, sade yoğurt alın, içine taze meyveler, granola, şurup ve istediğiniz başka bir doğal tatlandırıcı ekleyin. Böylece alacağınız kalori ve şeker miktarını kontrol edebilir, ne kadar kalori aldığınızı da ilave malzemelerin kalori cetvellerinden öğrenerek hesaplayabilirsiniz. Yoğurt, pasta, kek, hamur işi gibi yiyeceklerin yapımında tereyağ veya sıvı yağın ikamesi olarak kullanılabilir. Ayrıca, mayonez veya eksi krema yerine de kullanılması tavsiye edilmektedir. Yoğurt, içerdiği yağdan ötürü çok fazla kaloriye sahip olsa da, yağsız türleri de günümüzde son derece yaygın şekilde bulunabilmektedir.", "https://www.kaloricetveli.org/wp-content/uploads/yogurt.jpg"));
            categories.Add(new Category("Yulaf Ezmesi, Müsli ve Tahıl Gevrekleri", "Yulaf ezmesi, müsli ve granola gibi kahvaltılık gevreklerin en sık temel bileşenidir. Preslenmiş yulaf ya da geleneksel yulaf olarak da adlandırılan sade yulaf ezmesi çok sayıda kompleks karbonhidrat, bazı besleyici lifler ve önemli miktarda A ve B6 vitamini ve kalsiyum içerdiği için yüksek besleyici değere sahiptir. Ayrıca, pişmiş yulaf ezmesinin bir bardağı (250 ml) önerilen günlük demir miktarının %77’sini sağlar. Aşağıdaki kalori cetveli ayrıca Kellog’s, Psot ve Kashi gibi popüler markaları içeren birçok kutulanmış kahvaltılık gevreğin kalorisini göstermektedir. Bu ürünlerdeki kaloriler, temelde yulaf ezmesine benzer şekilde karbonhidrat biçimindedir. Bu gevreklerin üretiminde kullanılan diğer hububat arasında mısır, buğday, pirinç ve arpa bulunmaktadır. Multigrain Cheerios gibi bazı gevrekler, temel gıda maddelerinin sağlık yararlarını tek seferde sunmak üzere hububat karışımları kullanır. Yulaf ezmesi, müsli ve gevrekler her ne kadar kompleks karbonhidratlar ve lifler yönünden zenginlerse de, bu ürünlerin şeker kaynaklı ek kaloriler içerecek şekilde paketlenmiş olabilecekleri bilinmelidir. Örneğin, tatlandırılmış hazır yulaf ezmesi paket başına 15 gram şeker içerebilir. Kesin kalori miktarının saptanması için besin cetvellerinin dikkatlice incelenmesinde fayda bulunmaktadır. Bu hususu ve kahvaltılık gevreklerin hangi vitamin ve minerallerle güçlendirildiğini içeren diğer beslenme bilgilerini öğrenmek için besin etiketlerini gözden geçirin. Ayrıca, süt ilaveli tahıl gevreği veya müslinin kalorisinin, sütün türüne göre değişeceğini unutmayın. Porsiyonun kalorisini hesaplarken, sütler için kalori tablosunu incelemenizde fayda var.", "https://www.kaloricetveli.org/wp-content/uploads/yulaf-ezmesi-muesli-ve-tahil-gevrekleri.jpg"));

            context.Categories.AddRange(categories);
            context.SaveChanges();

            //YİYECEKLER
            List<Food> foods = new List<Food>();

            //ALKOLLÜ İÇKİLER VE İÇECEKLER
            foods.Add(new Food("Absinthe", 100, PortionType.ml, 348, 1));
            foods.Add(new Food("Advokatt", 100, PortionType.ml, 283, 1));
            foods.Add(new Food("Amaretto", 100, PortionType.ml, 310, 1));
            foods.Add(new Food("Asti Şarabı", 100, PortionType.ml, 138, 1));
            foods.Add(new Food("Bailey’s", 100, PortionType.ml, 327, 1));
            foods.Add(new Food("Bailey’s Irish Cream", 100, PortionType.ml, 327, 1));
            foods.Add(new Food("Beyaz Şarap", 100, PortionType.ml, 82, 1));
            foods.Add(new Food("Bira", 100, PortionType.ml, 43, 1));
            foods.Add(new Food("Blue Curacao (Mavi Likör)", 100, PortionType.ml, 243, 1));
            foods.Add(new Food("Brandy", 100, PortionType.ml, 213, 1));
            foods.Add(new Food("Burbon", 100, PortionType.ml, 233, 1));
            foods.Add(new Food("Chambord (Ahududu Likörü)", 100, PortionType.ml, 348, 1));
            foods.Add(new Food("Cin", 100, PortionType.ml, 263, 1));
            foods.Add(new Food("Cointreau (Fransız Likörü)", 100, PortionType.ml, 320, 1));
            foods.Add(new Food("Drambuie (İsveç Likörü)", 100, PortionType.ml, 358, 1));
            foods.Add(new Food("Elma Şarabı", 100, PortionType.ml, 49, 1));
            foods.Add(new Food("Erik Cini", 100, PortionType.ml, 332, 1));
            foods.Add(new Food("Frangelico (Fındık Likörü)", 100, PortionType.ml, 238, 1));
            foods.Add(new Food("Glenfiddich (Yeşil Viski)", 100, PortionType.ml, 230, 1));
            foods.Add(new Food("Grand Marnier (Fransız Likörü)", 100, PortionType.ml, 253, 1));
            foods.Add(new Food("Irish Viski", 100, PortionType.ml, 233, 1));
            foods.Add(new Food("Jack Daniel’s", 100, PortionType.ml, 146, 1));
            foods.Add(new Food("Jegermeister", 100, PortionType.ml, 250, 1));
            foods.Add(new Food("Jim Beam", 100, PortionType.ml, 222, 1));
            foods.Add(new Food("Kahlua", 100, PortionType.ml, 180, 1));
            foods.Add(new Food("Kanada Viskisi", 100, PortionType.ml, 216, 1));
            foods.Add(new Food("Kanyak", 100, PortionType.ml, 235, 1));
            foods.Add(new Food("Kırmızı Şarap", 100, PortionType.ml, 85, 1));
            foods.Add(new Food("Likör", 100, PortionType.ml, 250, 1));
            foods.Add(new Food("Mastika", 100, PortionType.ml, 367, 1));
            foods.Add(new Food("Midori", 100, PortionType.ml, 267, 1));
            foods.Add(new Food("Prosecco (İtalyan Şampanyası)", 100, PortionType.ml, 66, 1));
            foods.Add(new Food("Punch", 100, PortionType.ml, 62, 1));
            foods.Add(new Food("Rakı", 100, PortionType.ml, 251, 1));
            foods.Add(new Food("Rom", 100, PortionType.ml, 231, 1));
            foods.Add(new Food("Roze Şarap", 100, PortionType.ml, 71, 1));
            foods.Add(new Food("Sambuka", 100, PortionType.ml, 333, 1));
            foods.Add(new Food("Sangria", 100, PortionType.ml, 96, 1));
            foods.Add(new Food("Scotch", 100, PortionType.ml, 222, 1));
            foods.Add(new Food("Sherry", 100, PortionType.ml, 116, 1));
            foods.Add(new Food("Sothern Comfort", 100, PortionType.ml, 247, 1));
            foods.Add(new Food("Tekila", 100, PortionType.ml, 110, 1));
            foods.Add(new Food("Triple Sec", 100, PortionType.ml, 153, 1));
            foods.Add(new Food("Uzo", 100, PortionType.ml, 234, 1));
            foods.Add(new Food("Vermut", 100, PortionType.ml, 130, 1));
            foods.Add(new Food("Viski", 100, PortionType.ml, 250, 1));
            foods.Add(new Food("Votka", 100, PortionType.ml, 231, 1));
            foods.Add(new Food("Şampanya", 100, PortionType.ml, 75, 1));
            foods.Add(new Food("Şarap", 100, PortionType.ml, 83, 1));

            //ALKOLSÜZ İÇECEKLER
            foods.Add(new Food("Alkolsüz Bira", 100, PortionType.ml, 37, 2));
            foods.Add(new Food("Bergamot Çayı", 100, PortionType.ml, 1, 2));
            foods.Add(new Food("Boza", 100, PortionType.ml, 148, 2));
            foods.Add(new Food("Club Mate", 100, PortionType.ml, 30, 2));
            foods.Add(new Food("Coca Cola", 100, PortionType.ml, 42, 2));
            foods.Add(new Food("Diyet Kola", 100, PortionType.ml, 1, 2));
            foods.Add(new Food("Egg Nog", 100, PortionType.ml, 88, 2));
            foods.Add(new Food("Elmalı Spritzer", 100, PortionType.ml, 24, 2));
            foods.Add(new Food("Evian", 100, PortionType.ml, 0, 2));
            foods.Add(new Food("Gatorade", 100, PortionType.ml, 23, 2));
            foods.Add(new Food("Gazoz", 100, PortionType.ml, 42, 2));
            foods.Add(new Food("Horchata", 100, PortionType.ml, 54, 2));
            foods.Add(new Food("Ice Tea/Buzlu Çay", 100, PortionType.ml, 27, 2));
            foods.Add(new Food("Kahve", 100, PortionType.ml, 1, 2));
            foods.Add(new Food("Karamalz", 100, PortionType.ml, 37, 2));
            foods.Add(new Food("Kola", 100, PortionType.ml, 42, 2));
            foods.Add(new Food("Kola Zero", 100, PortionType.ml, 1, 2));
            foods.Add(new Food("Kombuça", 100, PortionType.ml, 13, 2));
            foods.Add(new Food("Lassi (Hint Ayranı)", 100, PortionType.ml, 104, 2));
            foods.Add(new Food("Latte Macchiato", 100, PortionType.ml, 57, 2));
            foods.Add(new Food("Limonata", 100, PortionType.ml, 42, 2));
            foods.Add(new Food("Malt Birası", 100, PortionType.ml, 37, 2));
            foods.Add(new Food("Milkshake", 100, PortionType.ml, 329, 2));
            foods.Add(new Food("Nektar", 100, PortionType.ml, 53, 2));
            foods.Add(new Food("Nestea", 100, PortionType.ml, 36, 2));
            foods.Add(new Food("Powerade", 100, PortionType.ml, 16, 2));
            foods.Add(new Food("Slush Puppy (Meybuz)", 100, PortionType.ml, 50, 2));
            foods.Add(new Food("Smoothie", 100, PortionType.ml, 37, 2));
            foods.Add(new Food("Soya Sütü", 100, PortionType.ml, 45, 2));
            foods.Add(new Food("Su", 100, PortionType.ml, 0, 2));
            foods.Add(new Food("Süt", 100, PortionType.ml, 61, 2));
            foods.Add(new Food("Sıcak Çikolata", 100, PortionType.ml, 89, 2));
            foods.Add(new Food("Türk Kahvesi", 100, PortionType.ml, 2, 2));
            foods.Add(new Food("Türk Çayı", 100, PortionType.ml, 2, 2));
            foods.Add(new Food("Vanilyalı Milkshake", 100, PortionType.ml, 149, 2));
            foods.Add(new Food("Volvic", 100, PortionType.ml, 0, 2));
            foods.Add(new Food("Yerba Mate (Gün. Amer. Çayı)", 100, PortionType.ml, 62, 2));
            foods.Add(new Food("Zençefilli Çay", 100, PortionType.ml, 0, 2));
            foods.Add(new Food("Çay", 100, PortionType.ml, 1, 2));
            foods.Add(new Food("Çikolatalı Milkshake", 100, PortionType.ml, 125, 2));
            foods.Add(new Food("Çikolatalı Süt", 100, PortionType.ml, 89, 2));
            foods.Add(new Food("Çilekli Milkshake", 100, PortionType.ml, 113, 2));
            foods.Add(new Food("Çin Çayı", 100, PortionType.ml, 0, 2));

            //BAKLAGİLLER
            foods.Add(new Food("Akceviz", 100, PortionType.g, 612, 3));
            foods.Add(new Food("Bakla", 100, PortionType.g, 84, 3));
            foods.Add(new Food("Bambu Filizi", 100, PortionType.g, 27, 3));
            foods.Add(new Food("Bamya", 100, PortionType.g, 33, 3));
            foods.Add(new Food("Barbunya Fasulyesi", 100, PortionType.g, 347, 3));
            foods.Add(new Food("Bezelye", 100, PortionType.g, 42, 3));
            foods.Add(new Food("Börülce", 100, PortionType.g, 341, 3));
            foods.Add(new Food("Chili Fasulye", 100, PortionType.g, 97, 3));
            foods.Add(new Food("Fasulye Filizi", 100, PortionType.g, 30, 3));
            foods.Add(new Food("Kahverengi Mercimek", 100, PortionType.g, 353, 3));
            foods.Add(new Food("Katı Tofu", 100, PortionType.g, 70, 3));
            foods.Add(new Food("Kestane İçi", 100, PortionType.g, 210, 3));
            foods.Add(new Food("Kuru Fasulye / Beyaz Fasulye", 100, PortionType.g, 336, 3));
            foods.Add(new Food("Kırmızı Barbunya", 100, PortionType.g, 124, 3));
            foods.Add(new Food("Kırmızı Fasulye", 100, PortionType.g, 337, 3));
            foods.Add(new Food("Kırmızı Mercimek", 100, PortionType.g, 329, 3));
            foods.Add(new Food("Kızartılmış Tofu", 100, PortionType.g, 271, 3));
            foods.Add(new Food("Maş Fasulyesi", 100, PortionType.g, 12, 3));
            foods.Add(new Food("Mercimek", 100, PortionType.g, 353, 3));
            foods.Add(new Food("Miso", 100, PortionType.g, 199, 3));
            foods.Add(new Food("Nohut", 100, PortionType.g, 364, 3));
            foods.Add(new Food("Pekan Cevizi", 100, PortionType.g, 691, 3));
            foods.Add(new Food("Sarı Mercimek", 100, PortionType.g, 304, 3));
            foods.Add(new Food("Siyah Nohut", 100, PortionType.g, 364, 3));
            foods.Add(new Food("Soya Fasulyesi", 100, PortionType.g, 147, 3));
            foods.Add(new Food("Soya Fıstığı", 100, PortionType.g, 471, 3));
            foods.Add(new Food("Soya Mayonezi", 100, PortionType.g, 322, 3));
            foods.Add(new Food("Soya Peyniri", 100, PortionType.g, 235, 3));
            foods.Add(new Food("Soya Yoğurdu", 100, PortionType.g, 66, 3));
            foods.Add(new Food("Tempeh (Endonezya Yemeği)", 100, PortionType.g, 193, 3));
            foods.Add(new Food("Tofu", 100, PortionType.g, 76, 3));
            foods.Add(new Food("Uzun Fasulye", 100, PortionType.g, 85, 3));
            foods.Add(new Food("Yer Fıstığı", 100, PortionType.g, 567, 3));
            foods.Add(new Food("Yeşil Fasulye", 100, PortionType.g, 31, 3));
            foods.Add(new Food("Yeşil Mercimek", 100, PortionType.g, 257, 3));
            foods.Add(new Food("Yumuşak Tofu", 100, PortionType.g, 55, 3));
            foods.Add(new Food("Çok Katı Tofu", 100, PortionType.g, 91, 3));
            foods.Add(new Food("Şeker Bezelyesi", 100, PortionType.g, 42, 3));

            //BALIK VE DENİZ ÜRÜNLERİ
            foods.Add(new Food("Ahtapot", 100, PortionType.g, 164, 4));
            foods.Add(new Food("Alabalık", 100, PortionType.g, 190, 4));
            foods.Add(new Food("Amerikan Pisi Balığı", 100, PortionType.g, 91, 4));
            foods.Add(new Food("Ançuez", 100, PortionType.g, 131, 4));
            foods.Add(new Food("Barlam", 100, PortionType.g, 71, 4));
            foods.Add(new Food("Beyaz Balık", 100, PortionType.g, 172, 4));
            foods.Add(new Food("Deniz Levreği", 100, PortionType.g, 124, 4));
            foods.Add(new Food("Deniz Tarağı", 100, PortionType.g, 148, 4));
            foods.Add(new Food("Deniz Tarağı", 100, PortionType.g, 111, 4));
            foods.Add(new Food("Dil Balığı", 100, PortionType.g, 86, 4));
            foods.Add(new Food("Dilbalığı", 100, PortionType.g, 86, 4));
            foods.Add(new Food("Fish Finger / Fish Sticks", 100, PortionType.g, 290, 4));
            foods.Add(new Food("Gümüş Balığı", 100, PortionType.g, 124, 4));
            foods.Add(new Food("Havyar", 100, PortionType.g, 264, 4));
            foods.Add(new Food("Istakoz", 100, PortionType.g, 89, 4));
            foods.Add(new Food("Kalamar", 100, PortionType.g, 175, 4));
            foods.Add(new Food("Kalkan Balığı", 100, PortionType.g, 122, 4));
            foods.Add(new Food("Kapan Levrek", 100, PortionType.g, 94, 4));
            foods.Add(new Food("Karabalık", 100, PortionType.g, 187, 4));
            foods.Add(new Food("Kerevit", 100, PortionType.g, 82, 4));
            foods.Add(new Food("Kömür Balığı", 100, PortionType.g, 111, 4));
            foods.Add(new Food("Köpek Balığı", 100, PortionType.g, 130, 4));
            foods.Add(new Food("Kılıçbalığı", 100, PortionType.g, 172, 4));
            foods.Add(new Food("Kırlangıç Balığı", 100, PortionType.g, 87, 4));
            foods.Add(new Food("Lüfer", 100, PortionType.g, 159, 4));
            foods.Add(new Food("Mavi Barlam", 100, PortionType.g, 121, 4));
            foods.Add(new Food("Maymunbalığı", 100, PortionType.g, 97, 4));
            foods.Add(new Food("Mersin Balığı", 100, PortionType.g, 135, 4));
            foods.Add(new Food("Mezgit", 100, PortionType.g, 90, 4));
            foods.Add(new Food("Mezgit Balığı", 100, PortionType.g, 116, 4));
            foods.Add(new Food("Midye", 100, PortionType.g, 172, 4));
            foods.Add(new Food("Morina", 100, PortionType.g, 105, 4));
            foods.Add(new Food("Norveç İstakozu", 100, PortionType.g, 84, 4));
            foods.Add(new Food("Orfoz", 100, PortionType.g, 118, 4));
            foods.Add(new Food("Pisi Balığı", 100, PortionType.g, 111, 4));
            foods.Add(new Food("Ringa Balığı", 100, PortionType.g, 203, 4));
            foods.Add(new Food("Rulo Balık", 100, PortionType.g, 171, 4));
            foods.Add(new Food("Salamura Ringa Balığı", 100, PortionType.g, 262, 4));
            foods.Add(new Food("Sardalya", 100, PortionType.g, 208, 4));
            foods.Add(new Food("Sazan", 100, PortionType.g, 162, 4));
            foods.Add(new Food("Somon", 100, PortionType.g, 206, 4));
            foods.Add(new Food("Sushi", 100, PortionType.g, 150, 4));
            foods.Add(new Food("Sütbalığı", 100, PortionType.g, 190, 4));
            foods.Add(new Food("Tatlısu Levreği", 100, PortionType.g, 84, 4));
            foods.Add(new Food("Tekir Balığı", 100, PortionType.g, 150, 4));
            foods.Add(new Food("Tirsi Balığı", 100, PortionType.g, 252, 4));
            foods.Add(new Food("Ton Balığı", 100, PortionType.g, 132, 4));
            foods.Add(new Food("Ton Balığı Salatası", 100, PortionType.g, 187, 4));
            foods.Add(new Food("Turna", 100, PortionType.g, 113, 4));
            foods.Add(new Food("Tütsülenmiş Ringa Balığı", 100, PortionType.g, 217, 4));
            foods.Add(new Food("Uskumru", 100, PortionType.g, 262, 4));
            foods.Add(new Food("Uzungelincik Balığı", 100, PortionType.g, 128, 4));
            foods.Add(new Food("Vahu", 100, PortionType.g, 109, 4));
            foods.Add(new Food("Yılan Balığı", 100, PortionType.g, 236, 4));
            foods.Add(new Food("Çipura", 100, PortionType.g, 135, 4));
            foods.Add(new Food("Çotira Balığı", 100, PortionType.g, 93, 4));

            //BİRA
            foods.Add(new Food("Ale", 100, PortionType.ml, 35, 5));
            foods.Add(new Food("Alkolsüz Bira", 100, PortionType.ml, 37, 5));
            foods.Add(new Food("Altbier", 100, PortionType.ml, 43, 5));
            foods.Add(new Food("Beck’s", 100, PortionType.ml, 39, 5));
            foods.Add(new Food("Bira", 100, PortionType.ml, 43, 5));
            foods.Add(new Food("Bock Bier", 100, PortionType.ml, 50, 5));
            foods.Add(new Food("Buğday Birası", 100, PortionType.ml, 45, 5));
            foods.Add(new Food("Carlsberg", 100, PortionType.ml, 32, 5));
            foods.Add(new Food("Clausthaler (Alkolsüz)", 100, PortionType.ml, 26, 5));
            foods.Add(new Food("Corona", 100, PortionType.ml, 42, 5));
            foods.Add(new Food("Dark Bira", 100, PortionType.ml, 46, 5));
            foods.Add(new Food("Efes Pilsen Limonlu Fıçı Bira", 100, PortionType.ml, 50, 5));
            foods.Add(new Food("Ekstra Alkollü Bira", 100, PortionType.ml, 55, 5));
            foods.Add(new Food("Filtresiz Bira", 100, PortionType.ml, 44, 5));
            foods.Add(new Food("Guiness", 100, PortionType.ml, 35, 5));
            foods.Add(new Food("Heineken", 100, PortionType.ml, 35, 5));
            foods.Add(new Food("Hint Pale Ale / Şerbetçiotlu Bira", 100, PortionType.ml, 51, 5));
            foods.Add(new Food("Kölsch", 100, PortionType.ml, 43, 5));
            foods.Add(new Food("Lager Birası", 100, PortionType.ml, 43, 5));
            foods.Add(new Food("Light Bira", 100, PortionType.ml, 29, 5));
            foods.Add(new Food("Löwenbrau", 100, PortionType.ml, 45, 5));
            foods.Add(new Food("Malt Bira", 100, PortionType.ml, 37, 5));
            foods.Add(new Food("Meyveli Bira", 100, PortionType.ml, 47, 5));
            foods.Add(new Food("Pale Ale", 100, PortionType.ml, 42, 5));
            foods.Add(new Food("Pilsen", 100, PortionType.ml, 43, 5));
            foods.Add(new Food("Porter", 100, PortionType.ml, 54, 5));
            foods.Add(new Food("Stout", 100, PortionType.ml, 51, 5));
            foods.Add(new Food("Taps Smoke Lager", 100, PortionType.ml, 54, 5));
            foods.Add(new Food("Tilt", 100, PortionType.ml, 64, 5));
            foods.Add(new Food("Zencefilli Bira", 100, PortionType.ml, 42, 5));

            //BİTKİSEL SIVIYAĞLAR
            foods.Add(new Food("Argan Yağı", 100, PortionType.ml, 896, 6));
            foods.Add(new Food("Avokado Yağı", 100, PortionType.ml, 857, 6));
            foods.Add(new Food("Ayçiçeği Yağı", 100, PortionType.ml, 884, 6));
            foods.Add(new Food("Babassu Yağı", 100, PortionType.ml, 884, 6));
            foods.Add(new Food("Badem Yağı", 100, PortionType.ml, 882, 6));
            foods.Add(new Food("Ceviz Yağı", 100, PortionType.ml, 889, 6));
            foods.Add(new Food("Domates Çekirdeği Yağı", 100, PortionType.ml, 884, 6));
            foods.Add(new Food("Fındık Yağı", 100, PortionType.ml, 889, 6));
            foods.Add(new Food("Hardal Yağı", 100, PortionType.ml, 884, 6));
            foods.Add(new Food("Haşhaş Tohumu Yağı", 100, PortionType.ml, 884, 6));
            foods.Add(new Food("Hindistan Cevizi Yağı", 100, PortionType.ml, 857, 6));
            foods.Add(new Food("Kabak Çekirdeği Yağı", 100, PortionType.ml, 880, 6));
            foods.Add(new Food("Kanola Yağı", 100, PortionType.ml, 884, 6));
            foods.Add(new Food("Karite Yağı", 100, PortionType.ml, 884, 6));
            foods.Add(new Food("Kayısı Çekirdeği Yağı", 100, PortionType.ml, 889, 6));
            foods.Add(new Food("Keten Tohumu Yağı", 100, PortionType.ml, 837, 6));
            foods.Add(new Food("Mısırözü Yağı", 100, PortionType.ml, 800, 6));
            foods.Add(new Food("Palm Yağı", 100, PortionType.ml, 882, 6));
            foods.Add(new Food("Pamuk Tohumu Yağı", 100, PortionType.ml, 882, 6));
            foods.Add(new Food("Pirinç Kepeği Yağı", 100, PortionType.ml, 889, 6));
            foods.Add(new Food("Ringa Balığı Yağı", 100, PortionType.ml, 911, 6));
            foods.Add(new Food("Ruşeym Yağı", 100, PortionType.ml, 929, 6));
            foods.Add(new Food("Sebze Yağı", 100, PortionType.ml, 800, 6));
            foods.Add(new Food("Somon Yağı", 100, PortionType.ml, 911, 6));
            foods.Add(new Food("Soya Yağı", 100, PortionType.ml, 882, 6));
            foods.Add(new Food("Susam Yağı", 100, PortionType.ml, 889, 6));
            foods.Add(new Food("Yalancısafran Yağı", 100, PortionType.ml, 857, 6));
            foods.Add(new Food("Yerfıstığı Yağı", 100, PortionType.ml, 857, 6));
            foods.Add(new Food("Yulaf Yağı", 100, PortionType.ml, 884, 6));
            foods.Add(new Food("Zeytinyağ", 100, PortionType.ml, 800, 6));
            foods.Add(new Food("Üzüm Çekirdeği Yağı", 100, PortionType.ml, 884, 6));

            //ÇEREZ VE ÇEKİRDEKLER
            foods.Add(new Food("Akceviz", 100, PortionType.g, 612, 7));
            foods.Add(new Food("Antep Fıstığı", 100, PortionType.g, 562, 7));
            foods.Add(new Food("At Kestanesi", 100, PortionType.g, 576, 7));
            foods.Add(new Food("Avustralya Fındığı", 100, PortionType.g, 718, 7));
            foods.Add(new Food("Ayçiçeği Tohumu", 100, PortionType.g, 584, 7));
            foods.Add(new Food("Badem", 100, PortionType.g, 575, 7));
            foods.Add(new Food("Barbunya Fasulyesi", 100, PortionType.g, 347, 7));
            foods.Add(new Food("Bezelye", 100, PortionType.g, 81, 7));
            foods.Add(new Food("Brezilya Fındığı", 100, PortionType.g, 656, 7));
            foods.Add(new Food("Ceviz", 100, PortionType.g, 654, 7));
            foods.Add(new Food("Ceviz", 100, PortionType.g, 657, 7));
            foods.Add(new Food("Chia Çekirdeği", 100, PortionType.g, 486, 7));
            foods.Add(new Food("Ekmek Ağacı", 100, PortionType.g, 191, 7));
            foods.Add(new Food("Fındık", 100, PortionType.g, 628, 7));
            foods.Add(new Food("Gingko Cevizi", 100, PortionType.g, 182, 7));
            foods.Add(new Food("Haşhaş Tohumu", 100, PortionType.g, 525, 7));
            foods.Add(new Food("Hindistan Cevizi", 100, PortionType.g, 354, 7));
            foods.Add(new Food("Kaba Yonca", 100, PortionType.g, 23, 7));
            foods.Add(new Food("Kabak Çekirdeği", 100, PortionType.g, 559, 7));
            foods.Add(new Food("Kaju", 100, PortionType.g, 553, 7));
            foods.Add(new Food("Karpuz", 100, PortionType.g, 30, 7));
            foods.Add(new Food("Kestane", 100, PortionType.g, 213, 7));
            foods.Add(new Food("Keten Tohumu", 100, PortionType.g, 534, 7));
            foods.Add(new Food("Leblebi", 100, PortionType.g, 267, 7));
            foods.Add(new Food("Lotus Tohumu", 100, PortionType.g, 89, 7));
            foods.Add(new Food("Meşe Palamudu", 100, PortionType.g, 387, 7));
            foods.Add(new Food("Pamuk Tohumu", 100, PortionType.g, 506, 7));
            foods.Add(new Food("Pekan Cevizi", 100, PortionType.g, 691, 7));
            foods.Add(new Food("Soya Fasulyesi", 100, PortionType.g, 147, 7));
            foods.Add(new Food("Susam Tohumu", 100, PortionType.g, 573, 7));
            foods.Add(new Food("Tatlı Kestane", 100, PortionType.g, 194, 7));
            foods.Add(new Food("Yer Fıstığı", 100, PortionType.g, 567, 7));
            foods.Add(new Food("Çam Fıstığı", 100, PortionType.g, 673, 7));

            //ÇORBALAR
            foods.Add(new Food("Alfabe Çorbası", 100, PortionType.g, 25, 8));
            foods.Add(new Food("Bezelye Çorbası", 100, PortionType.g, 75, 8));
            foods.Add(new Food("Brokoli Çorbası", 100, PortionType.g, 87, 8));
            foods.Add(new Food("Bulyon", 100, PortionType.g, 16, 8));
            foods.Add(new Food("Domates Çorbası", 100, PortionType.g, 30, 8));
            foods.Add(new Food("Domatesli Pirinç Çorbası", 100, PortionType.g, 47, 8));
            foods.Add(new Food("Düğün Çorbası", 100, PortionType.g, 53, 8));
            foods.Add(new Food("Et Bulyon", 100, PortionType.g, 3, 8));
            foods.Add(new Food("Et Çorbası", 100, PortionType.g, 33, 8));
            foods.Add(new Food("Etli Kuru Fasulye", 100, PortionType.g, 133, 8));
            foods.Add(new Food("Etli Noodle Çorbası", 100, PortionType.g, 34, 8));
            foods.Add(new Food("Gulaş", 100, PortionType.g, 50, 8));
            foods.Add(new Food("Havuç Çorbası", 100, PortionType.g, 25, 8));
            foods.Add(new Food("Havuçlu Zencefilli Çorba", 100, PortionType.g, 25, 8));
            foods.Add(new Food("Hazır Ramen", 100, PortionType.g, 436, 8));
            foods.Add(new Food("Istakoz Çorbası", 100, PortionType.g, 100, 8));
            foods.Add(new Food("Kabak Çorbası", 100, PortionType.g, 29, 8));
            foods.Add(new Food("Kremalı Brokoli Çorbası", 100, PortionType.g, 45, 8));
            foods.Add(new Food("Kremalı Kereviz Çorbası", 100, PortionType.g, 37, 8));
            foods.Add(new Food("Kremalı Kuşkonmaz Çorbası", 100, PortionType.g, 35, 8));
            foods.Add(new Food("Kremalı Mantar Çorbası", 100, PortionType.g, 39, 8));
            foods.Add(new Food("Kremalı Patates Çorbası", 100, PortionType.g, 30, 8));
            foods.Add(new Food("Kremalı Soğan Çorbası", 100, PortionType.g, 44, 8));
            foods.Add(new Food("Kremalı Tavuk Çorbası", 100, PortionType.g, 48, 8));
            foods.Add(new Food("Kremalı Tavuklu Noodle Çorbası", 100, PortionType.g, 23, 8));
            foods.Add(new Food("Lahana Çorbası", 100, PortionType.g, 28, 8));
            foods.Add(new Food("Makarnalı Sebze Çorbası", 100, PortionType.g, 34, 8));
            foods.Add(new Food("Mantar Çorbası", 100, PortionType.g, 35, 8));
            foods.Add(new Food("Mercimek Çorbası", 100, PortionType.g, 56, 8));
            foods.Add(new Food("Noodle Çorbası", 100, PortionType.g, 34, 8));
            foods.Add(new Food("Patates Çorbası", 100, PortionType.g, 80, 8));
            foods.Add(new Food("Peynirli Brokoli Çorbası", 100, PortionType.g, 87, 8));
            foods.Add(new Food("Pirinç Çorbası ve Tavuk", 100, PortionType.g, 24, 8));
            foods.Add(new Food("Ramen", 100, PortionType.g, 436, 8));
            foods.Add(new Food("Sebze Suyu", 100, PortionType.g, 5, 8));
            foods.Add(new Food("Sebze Çorbası", 100, PortionType.g, 28, 8));
            foods.Add(new Food("Soğan Çorbası", 100, PortionType.g, 23, 8));
            foods.Add(new Food("Sığır Çorbası", 100, PortionType.g, 28, 8));
            foods.Add(new Food("Tavuk Bulyon", 100, PortionType.g, 4, 8));
            foods.Add(new Food("Tavuk Suyu", 100, PortionType.g, 16, 8));
            foods.Add(new Food("Tavuklu Noodle Çorbasu", 100, PortionType.g, 25, 8));
            foods.Add(new Food("Tavuklu Sebze Çorbası", 100, PortionType.g, 31, 8));
            foods.Add(new Food("Thai Çorbası", 100, PortionType.g, 60, 8));
            foods.Add(new Food("Yuvarlak Köfte Çorbası", 100, PortionType.g, 49, 8));

            //DİLİMLENMİŞ PEYNİR
            foods.Add(new Food("Biberli Peynir", 100, PortionType.g, 100, 9));
            foods.Add(new Food("Cheddar", 100, PortionType.g, 403, 9));
            foods.Add(new Food("Dilimlenmiş Peynir", 100, PortionType.g, 357, 9));
            foods.Add(new Food("Edam Peyniri", 100, PortionType.g, 357, 9));
            foods.Add(new Food("Emmental", 100, PortionType.g, 357, 9));
            foods.Add(new Food("Eski Kaşar Peyniri", 100, PortionType.g, 435, 9));
            foods.Add(new Food("Esrom Peyniri", 100, PortionType.g, 322, 9));
            foods.Add(new Food("Fol Epi Peyniri", 100, PortionType.g, 388, 9));
            foods.Add(new Food("Füme Peynir", 100, PortionType.g, 410, 9));
            foods.Add(new Food("Genç Gouda", 100, PortionType.g, 356, 9));
            foods.Add(new Food("Gouda", 100, PortionType.g, 356, 9));
            foods.Add(new Food("Havarti Peyniri", 100, PortionType.g, 371, 9));
            foods.Add(new Food("Kaskaval Peyniri", 100, PortionType.g, 340, 9));
            foods.Add(new Food("Kaşar Peyniri", 100, PortionType.g, 337, 9));
            foods.Add(new Food("Maasdam Peyniri", 100, PortionType.g, 344, 9));
            foods.Add(new Food("Mozzarella", 100, PortionType.g, 280, 9));
            foods.Add(new Food("Muenster Peyniri", 100, PortionType.g, 368, 9));
            foods.Add(new Food("Peynir Dilimleri", 100, PortionType.g, 356, 9));
            foods.Add(new Food("Sandviç Peyniri", 100, PortionType.g, 148, 9));
            foods.Add(new Food("Tilsit", 100, PortionType.g, 340, 9));
            foods.Add(new Food("Tulum Peyniri", 100, PortionType.g, 363, 9));

            //DİP SOSLAR VE EZMELER
            foods.Add(new Food("Ançuezli Zeytin Ezmesi", 100, PortionType.g, 233, 10));
            foods.Add(new Food("Badem Ezmesi", 100, PortionType.g, 614, 10));
            foods.Add(new Food("Bal", 100, PortionType.g, 304, 10));
            foods.Add(new Food("Böğürtlen Reçeli", 100, PortionType.g, 250, 10));
            foods.Add(new Food("Ciğer Salamı", 100, PortionType.g, 305, 10));
            foods.Add(new Food("Elma Püresi", 100, PortionType.g, 68, 10));
            foods.Add(new Food("Erik Reçeli", 100, PortionType.g, 250, 10));
            foods.Add(new Food("Fıstık Ezmesi", 100, PortionType.g, 589, 10));
            foods.Add(new Food("Jöle", 100, PortionType.g, 278, 10));
            foods.Add(new Food("Kaymak", 100, PortionType.g, 233, 10));
            foods.Add(new Food("Kayısı Reçeli", 100, PortionType.g, 250, 10));
            foods.Add(new Food("Kiraz Reçeli", 100, PortionType.g, 250, 10));
            foods.Add(new Food("Krem Peynir", 100, PortionType.g, 342, 10));
            foods.Add(new Food("Krem Peynir", 100, PortionType.g, 290, 10));
            foods.Add(new Food("Kuşüzümü Reçeli", 100, PortionType.g, 250, 10));
            foods.Add(new Food("Labne Peyniri", 100, PortionType.g, 189, 10));
            foods.Add(new Food("Margarin", 100, PortionType.g, 717, 10));
            foods.Add(new Food("Marmelat", 100, PortionType.g, 283, 10));
            foods.Add(new Food("Nutella", 100, PortionType.g, 544, 10));
            foods.Add(new Food("Pate", 100, PortionType.g, 319, 10));
            foods.Add(new Food("Philadelphia Krem Peynir", 100, PortionType.g, 342, 10));
            foods.Add(new Food("Süzme Peynir", 100, PortionType.g, 98, 10));
            foods.Add(new Food("Tahin", 100, PortionType.g, 583, 10));
            foods.Add(new Food("Tuzlu Tereyağ", 100, PortionType.g, 717, 10));
            foods.Add(new Food("Tuzsuz Yağ", 100, PortionType.g, 717, 10));
            foods.Add(new Food("Yaban Balı", 100, PortionType.g, 286, 10));
            foods.Add(new Food("Yabanmersini Reçeli", 100, PortionType.g, 250, 10));
            foods.Add(new Food("Yumurta", 100, PortionType.g, 97, 10));
            foods.Add(new Food("Çilek Reçeşi", 100, PortionType.g, 250, 10));
            foods.Add(new Food("Çilekli Jöle", 100, PortionType.g, 250, 10));
            foods.Add(new Food("Çokokrem", 100, PortionType.g, 541, 10));
            foods.Add(new Food("Üzüm Jölesi", 100, PortionType.g, 255, 10));

            //DOMUZ ETİ
            foods.Add(new Food("Bacon", 100, PortionType.g, 407, 11));
            foods.Add(new Food("Bumbar", 100, PortionType.g, 233, 11));
            foods.Add(new Food("Domuz Bacağı", 100, PortionType.g, 201, 11));
            foods.Add(new Food("Domuz Bacon", 100, PortionType.g, 407, 11));
            foods.Add(new Food("Domuz Fileto", 100, PortionType.g, 143, 11));
            foods.Add(new Food("Domuz Göbeği", 100, PortionType.g, 518, 11));
            foods.Add(new Food("Domuz İncik", 100, PortionType.g, 172, 11));
            foods.Add(new Food("Domuz İçyağı", 100, PortionType.g, 898, 11));
            foods.Add(new Food("Domuz Kaburga", 100, PortionType.g, 292, 11));
            foods.Add(new Food("Domuz Kesilmiş Steak", 100, PortionType.g, 232, 11));
            foods.Add(new Food("Domuz Kotlet", 100, PortionType.g, 131, 11));
            foods.Add(new Food("Domuz Kulağı", 100, PortionType.g, 166, 11));
            foods.Add(new Food("Domuz Kuyruğu", 100, PortionType.g, 396, 11));
            foods.Add(new Food("Domuz Köftesi", 100, PortionType.g, 243, 11));
            foods.Add(new Food("Domuz Kıyması", 100, PortionType.g, 263, 11));
            foods.Add(new Food("Domuz Midesi", 100, PortionType.g, 250, 11));
            foods.Add(new Food("Domuz Omuz Kesilmiş", 100, PortionType.g, 232, 11));
            foods.Add(new Food("Domuz Omzu", 100, PortionType.g, 269, 11));
            foods.Add(new Food("Domuz Paçası", 100, PortionType.g, 243, 11));
            foods.Add(new Food("Domuz Rosto", 100, PortionType.g, 194, 11));
            foods.Add(new Food("Domuz Sosisi", 100, PortionType.g, 339, 11));
            foods.Add(new Food("Domuz Yahni", 100, PortionType.g, 73, 11));
            foods.Add(new Food("Domuz Yağı", 100, PortionType.g, 638, 11));
            foods.Add(new Food("Kaburga", 100, PortionType.g, 396, 11));
            foods.Add(new Food("Kas", 100, PortionType.g, 309, 11));
            foods.Add(new Food("Parma Jambonu", 100, PortionType.g, 261, 11));
            foods.Add(new Food("Rulo Köfte", 100, PortionType.g, 89, 11));
            foods.Add(new Food("Serrano Jambon", 100, PortionType.g, 339, 11));
            foods.Add(new Food("Tuzlanmış Domuz Eti", 100, PortionType.g, 286, 11));
            foods.Add(new Food("Tuzlanmış Et", 100, PortionType.g, 286, 11));

            //DONDURMA VE DONMUŞ TATLILAR
            foods.Add(new Food("Antep Fıstıklı Dondurma", 100, PortionType.g, 204, 12));
            foods.Add(new Food("Bademli Magnum", 100, PortionType.g, 315, 12));
            foods.Add(new Food("Beyaz Çikolatalı Magnum", 100, PortionType.g, 297, 12));
            foods.Add(new Food("Damla Sakızlı Dondurma", 100, PortionType.g, 115, 12));
            foods.Add(new Food("Dondurmalı Sandviç", 100, PortionType.g, 237, 12));
            foods.Add(new Food("Drumsticks", 100, PortionType.g, 255, 12));
            foods.Add(new Food("Fıstıklı Dondurma", 100, PortionType.g, 305, 12));
            foods.Add(new Food("Kahveli Dondurma", 100, PortionType.g, 236, 12));
            foods.Add(new Food("Karamelli Dondurma", 100, PortionType.g, 179, 12));
            foods.Add(new Food("Kaymak Dondurma", 100, PortionType.g, 222, 12));
            foods.Add(new Food("Kurabiye Parçacıklı Dondurma", 100, PortionType.g, 200, 12));
            foods.Add(new Food("Magnum", 100, PortionType.g, 300, 12));
            foods.Add(new Food("Magnum Double Karamel", 100, PortionType.g, 355, 12));
            foods.Add(new Food("Magnum Double Çikolata", 100, PortionType.g, 380, 12));
            foods.Add(new Food("Magnum Gold", 100, PortionType.g, 341, 12));
            foods.Add(new Food("McFlurry", 100, PortionType.g, 153, 12));
            foods.Add(new Food("McFlurry Oreo", 100, PortionType.g, 186, 12));
            foods.Add(new Food("McFlurry Smarties", 100, PortionType.g, 198, 12));
            foods.Add(new Food("Meyveli Dondurma", 100, PortionType.g, 131, 12));
            foods.Add(new Food("Mini Milk", 100, PortionType.g, 120, 12));
            foods.Add(new Food("Nane Çikolata Tanecikli Dondurma", 100, PortionType.g, 239, 12));
            foods.Add(new Food("Snickers Dondurma", 100, PortionType.g, 360, 12));
            foods.Add(new Food("Sundae", 100, PortionType.g, 215, 12));
            foods.Add(new Food("Vanilyalı Dondurma", 100, PortionType.g, 201, 12));
            foods.Add(new Food("Çikolata Tanecikli Dondurma", 100, PortionType.g, 215, 12));
            foods.Add(new Food("Çikolatalı Dondurma", 100, PortionType.g, 216, 12));
            foods.Add(new Food("Çilekli Dondurma", 100, PortionType.g, 236, 12));
            foods.Add(new Food("Çilekli Sundae", 100, PortionType.g, 158, 12));

            //ET VE ET ÜRÜNLERİ
            foods.Add(new Food("Antrikot", 100, PortionType.g, 121, 13));
            foods.Add(new Food("Biftek Döş", 100, PortionType.g, 242, 13));
            foods.Add(new Food("Bonfile", 100, PortionType.g, 138, 13));
            foods.Add(new Food("Dana Kıyması", 100, PortionType.g, 246, 13));
            foods.Add(new Food("Devekuşu", 100, PortionType.g, 145, 13));
            foods.Add(new Food("Domuz Budu", 100, PortionType.g, 163, 13));
            foods.Add(new Food("Domuz Eti", 100, PortionType.g, 196, 13));
            foods.Add(new Food("Domuz Geri Kaburga", 100, PortionType.g, 212, 13));
            foods.Add(new Food("Domuz Kontrfile", 100, PortionType.g, 204, 13));
            foods.Add(new Food("Domuz Pirzolası", 100, PortionType.g, 196, 13));
            foods.Add(new Food("Domuz Rostosu", 100, PortionType.g, 254, 13));
            foods.Add(new Food("Domuz Steak", 100, PortionType.g, 196, 13));
            foods.Add(new Food("Fleminyon", 100, PortionType.g, 267, 13));
            foods.Add(new Food("Gerdan Steak", 100, PortionType.g, 277, 13));
            foods.Add(new Food("Hindi", 100, PortionType.g, 189, 13));
            foods.Add(new Food("Hindi Budu", 100, PortionType.g, 208, 13));
            foods.Add(new Food("Hindi Göğsü", 100, PortionType.g, 135, 13));
            foods.Add(new Food("Hindi Kanadı", 100, PortionType.g, 221, 13));
            foods.Add(new Food("Hindi Steak", 100, PortionType.g, 189, 13));
            foods.Add(new Food("Kaburga", 100, PortionType.g, 238, 13));
            foods.Add(new Food("Kaburga Rosto", 100, PortionType.g, 333, 13));
            foods.Add(new Food("Kontrfile", 100, PortionType.g, 163, 13));
            foods.Add(new Food("Kuzu İncik", 100, PortionType.g, 201, 13));
            foods.Add(new Food("Kuzu Pirzola", 100, PortionType.g, 276, 13));
            foods.Add(new Food("Pançeta", 100, PortionType.g, 194, 13));
            foods.Add(new Food("Rozbif", 100, PortionType.g, 140, 13));
            foods.Add(new Food("Sığır Eti", 100, PortionType.g, 248, 13));
            foods.Add(new Food("Sığır Filetosu", 100, PortionType.g, 218, 13));
            foods.Add(new Food("Sığır Kaburgası", 100, PortionType.g, 238, 13));
            foods.Add(new Food("T-Bone Steak", 100, PortionType.g, 202, 13));
            foods.Add(new Food("Tavuk", 100, PortionType.g, 219, 13));
            foods.Add(new Food("Tavuk Butu", 100, PortionType.g, 174, 13));
            foods.Add(new Food("Tavuk Ciğeri", 100, PortionType.g, 167, 13));
            foods.Add(new Food("Tavuk Eti", 100, PortionType.g, 172, 13));
            foods.Add(new Food("Tavuk Göğsü", 100, PortionType.g, 172, 13));
            foods.Add(new Food("Tavuk İç Organları", 100, PortionType.g, 158, 13));
            foods.Add(new Food("Tavuk Kanadı", 100, PortionType.g, 266, 13));
            foods.Add(new Food("Tavuk Taşlığı", 100, PortionType.g, 146, 13));
            foods.Add(new Food("Tavuk Yağı", 100, PortionType.g, 898, 13));
            foods.Add(new Food("Tranç", 100, PortionType.g, 182, 13));
            foods.Add(new Food("Ördek", 100, PortionType.g, 337, 13));
            foods.Add(new Food("Şinitzel", 100, PortionType.g, 156, 13));

            //FAST FOOD
            foods.Add(new Food("Arby’s Market Fresh Sandviç", 100, PortionType.g, 308, 14));
            foods.Add(new Food("Arby’s Roast Beef", 100, PortionType.g, 233, 14));
            foods.Add(new Food("Arby’s Roast Chicken", 100, PortionType.g, 203, 14));
            foods.Add(new Food("Balık Fileto", 100, PortionType.g, 282, 14));
            foods.Add(new Food("Balıklı Sandviç", 100, PortionType.g, 273, 14));
            foods.Add(new Food("Barbekü Kaburga", 100, PortionType.g, 212, 14));
            foods.Add(new Food("Burger King Bean Burger", 100, PortionType.g, 446, 14));
            foods.Add(new Food("Burger King Chipotle Etli Burger", 100, PortionType.g, 281, 14));
            foods.Add(new Food("Burger King Chipotle Tavuklu Burger", 100, PortionType.g, 353, 14));
            foods.Add(new Food("Burger King Double Whopper", 100, PortionType.g, 239, 14));
            foods.Add(new Food("Burger King Tendercrips Spicy Burger", 100, PortionType.g, 404, 14));
            foods.Add(new Food("Burger King Texas smoke burger", 100, PortionType.g, 446, 14));
            foods.Add(new Food("Burger King Whopper", 100, PortionType.g, 231, 14));
            foods.Add(new Food("Cheeseburger", 100, PortionType.g, 263, 14));
            foods.Add(new Food("Domuz Etli Sandviç", 100, PortionType.g, 241, 14));
            foods.Add(new Food("Domuz Sucuğu", 100, PortionType.g, 333, 14));
            foods.Add(new Food("Double Cheeseburger", 100, PortionType.g, 267, 14));
            foods.Add(new Food("Falafel", 100, PortionType.g, 335, 14));
            foods.Add(new Food("Fish and Chips", 100, PortionType.g, 195, 14));
            foods.Add(new Food("Füme Somon", 100, PortionType.g, 158, 14));
            foods.Add(new Food("Hamburger", 100, PortionType.g, 254, 14));
            foods.Add(new Food("Hindi", 100, PortionType.g, 104, 14));
            foods.Add(new Food("Izgara Tavuk Salata", 100, PortionType.g, 88, 14));
            foods.Add(new Food("İtalyan Sandviç", 100, PortionType.g, 183, 14));
            foods.Add(new Food("Köfteli Sandviç", 100, PortionType.g, 161, 14));
            foods.Add(new Food("Kıvrımlı Patates Kızartması", 100, PortionType.g, 311, 14));
            foods.Add(new Food("Lazanya", 100, PortionType.g, 132, 14));
            foods.Add(new Food("McDonalds Balık Fileto", 100, PortionType.g, 275, 14));
            foods.Add(new Food("McDonalds Big Mac", 100, PortionType.g, 256, 14));
            foods.Add(new Food("McDonalds Cheeseburger", 100, PortionType.g, 263, 14));
            foods.Add(new Food("McDonalds Chicken Nuggets", 100, PortionType.g, 297, 14));
            foods.Add(new Food("McDonalds Double Cheeseburger", 100, PortionType.g, 282, 14));
            foods.Add(new Food("McDonalds McChicken", 100, PortionType.g, 251, 14));
            foods.Add(new Food("McDonalds McDouble", 100, PortionType.g, 252, 14));
            foods.Add(new Food("McDonalds McTurco Etli", 100, PortionType.g, 262, 14));
            foods.Add(new Food("McDonalds Mighty Wings", 100, PortionType.g, 308, 14));
            foods.Add(new Food("McDonalds Sucuklu Yumurtalı McMuffin", 100, PortionType.g, 267, 14));
            foods.Add(new Food("McDonalds Yumurtalı McMuffin", 100, PortionType.g, 225, 14));
            foods.Add(new Food("Patates Kızartması", 100, PortionType.g, 254, 14));
            foods.Add(new Food("Peynirli Nachos", 100, PortionType.g, 306, 14));
            foods.Add(new Food("Sebzeli Etli Çin Yemeği", 100, PortionType.g, 172, 14));
            foods.Add(new Food("Sosisli Sandviç", 100, PortionType.g, 269, 14));
            foods.Add(new Food("Soğan Halkaları", 100, PortionType.g, 411, 14));
            foods.Add(new Food("Steakhouse Burger", 100, PortionType.g, 280, 14));
            foods.Add(new Food("Tavuk Fajita", 100, PortionType.g, 147, 14));
            foods.Add(new Food("Tavuk Göğsü", 100, PortionType.g, 163, 14));
            foods.Add(new Food("Tavuk Kanatları", 100, PortionType.g, 324, 14));
            foods.Add(new Food("Tavuk Nugget", 100, PortionType.g, 296, 14));
            foods.Add(new Food("Tavuk Pizziola", 100, PortionType.g, 141, 14));
            foods.Add(new Food("Tavuk Teriyaki Sandviç", 100, PortionType.g, 138, 14));
            foods.Add(new Food("Tavuklu Sandviç", 100, PortionType.g, 241, 14));
            foods.Add(new Food("Tortilla Wrap", 100, PortionType.g, 271, 14));
            foods.Add(new Food("Tuna", 100, PortionType.g, 86, 14));
            foods.Add(new Food("Vejetaryen Buton Sandviç", 100, PortionType.g, 138, 14));
            foods.Add(new Food("Vejetaryen Yuvarlak Sandviç", 100, PortionType.g, 390, 14));
            foods.Add(new Food("Vejeteryan Burger", 100, PortionType.g, 181, 14));
            foods.Add(new Food("Çin Böreği", 100, PortionType.g, 250, 14));

            //GEYİK VE AV ETLERİ
            foods.Add(new Food("Amerikan Geyiği", 100, PortionType.g, 134, 15));
            foods.Add(new Food("Antilop", 100, PortionType.g, 150, 15));
            foods.Add(new Food("Ayı", 100, PortionType.g, 259, 15));
            foods.Add(new Food("Bizon", 100, PortionType.g, 171, 15));
            foods.Add(new Food("Bizon Sirloin", 100, PortionType.g, 171, 15));
            foods.Add(new Food("Bufalo", 100, PortionType.g, 131, 15));
            foods.Add(new Food("Devekuşu", 100, PortionType.g, 175, 15));
            foods.Add(new Food("Geyik", 100, PortionType.g, 200, 15));
            foods.Add(new Food("Karaca Eti", 100, PortionType.g, 164, 15));
            foods.Add(new Food("Karaca Sirloin", 100, PortionType.g, 158, 15));
            foods.Add(new Food("Kaz", 100, PortionType.g, 238, 15));
            foods.Add(new Food("Koyun Eti", 100, PortionType.g, 234, 15));
            foods.Add(new Food("Kunduz", 100, PortionType.g, 212, 15));
            foods.Add(new Food("Kuzu", 100, PortionType.g, 202, 15));
            foods.Add(new Food("Rakun", 100, PortionType.g, 255, 15));
            foods.Add(new Food("Ren Geyiği", 100, PortionType.g, 159, 15));
            foods.Add(new Food("Sincap", 100, PortionType.g, 173, 15));
            foods.Add(new Food("Sülün", 100, PortionType.g, 239, 15));
            foods.Add(new Food("Tavşan", 100, PortionType.g, 197, 15));
            foods.Add(new Food("Timsah", 100, PortionType.g, 104, 15));
            foods.Add(new Food("Yaban Domuzu", 100, PortionType.g, 160, 15));
            foods.Add(new Food("Yabani Ördek", 100, PortionType.g, 211, 15));

            //KEK VE TARTLAR
            foods.Add(new Food("Ahududulu Tart", 100, PortionType.g, 240, 16));
            foods.Add(new Food("Baked Alaska", 100, PortionType.g, 247, 16));
            foods.Add(new Food("Banoffee Tart", 100, PortionType.g, 395, 16));
            foods.Add(new Food("Bisküvili Rulo Pasta", 100, PortionType.g, 280, 16));
            foods.Add(new Food("Cheesecake", 100, PortionType.g, 321, 16));
            foods.Add(new Food("Cupcake", 100, PortionType.g, 305, 16));
            foods.Add(new Food("Dondurmalı Kek", 100, PortionType.g, 200, 16));
            foods.Add(new Food("Donut", 100, PortionType.g, 403, 16));
            foods.Add(new Food("Doğumgünü Pastası", 100, PortionType.g, 465, 16));
            foods.Add(new Food("Düğün Pastası", 100, PortionType.g, 381, 16));
            foods.Add(new Food("Ekşili Tart", 100, PortionType.g, 380, 16));
            foods.Add(new Food("Elmalı Kek", 100, PortionType.g, 252, 16));
            foods.Add(new Food("Elmalı Strudel", 100, PortionType.g, 274, 16));
            foods.Add(new Food("Elmalı Turta", 100, PortionType.g, 348, 16));
            foods.Add(new Food("Erikli Kek", 100, PortionType.g, 109, 16));
            foods.Add(new Food("Fransız Lokması", 100, PortionType.g, 412, 16));
            foods.Add(new Food("Fındıklı Kek", 100, PortionType.g, 432, 16));
            foods.Add(new Food("Havuçlu Kek", 100, PortionType.g, 408, 16));
            foods.Add(new Food("Haşhaşlı Kek", 100, PortionType.g, 394, 16));
            foods.Add(new Food("Hindistan Cevizli Kek", 100, PortionType.g, 356, 16));
            foods.Add(new Food("İsveç Keki", 100, PortionType.g, 439, 16));
            foods.Add(new Food("Kara Orman Keki", 100, PortionType.g, 264, 16));
            foods.Add(new Food("Kral Keki", 100, PortionType.g, 377, 16));
            foods.Add(new Food("Krem Puf", 100, PortionType.g, 334, 16));
            foods.Add(new Food("Kremalı Avustralya Tatlısı", 100, PortionType.g, 294, 16));
            foods.Add(new Food("Kırıntı Pastası", 100, PortionType.g, 441, 16));
            foods.Add(new Food("Limonlu Kek", 100, PortionType.g, 352, 16));
            foods.Add(new Food("Meringue", 100, PortionType.g, 285, 16));
            foods.Add(new Food("Mermer Kek", 100, PortionType.g, 339, 16));
            foods.Add(new Food("Meyveli Kek", 100, PortionType.g, 324, 16));
            foods.Add(new Food("Misket Limonlu Turta", 100, PortionType.g, 359, 16));
            foods.Add(new Food("Mozaik Pasta", 100, PortionType.g, 428, 16));
            foods.Add(new Food("Muzlu Tart", 100, PortionType.g, 245, 16));
            foods.Add(new Food("Pandispanya", 100, PortionType.g, 180, 16));
            foods.Add(new Food("Pandispanya Kek", 100, PortionType.g, 258, 16));
            foods.Add(new Food("Panettone", 100, PortionType.g, 360, 16));
            foods.Add(new Food("Pankek", 100, PortionType.g, 227, 16));
            foods.Add(new Food("Pound Kek", 100, PortionType.g, 390, 16));
            foods.Add(new Food("Profiterol", 100, PortionType.g, 334, 16));
            foods.Add(new Food("Puf Pasta", 100, PortionType.g, 558, 16));
            foods.Add(new Food("Reçelli Tatlı", 100, PortionType.g, 145, 16));
            foods.Add(new Food("Sacher Turtası", 100, PortionType.g, 352, 16));
            foods.Add(new Food("Siyah Beyaz Kurabiye", 100, PortionType.g, 381, 16));
            foods.Add(new Food("Sünger Kek", 100, PortionType.g, 289, 16));
            foods.Add(new Food("Tarçınlı Ekmek", 100, PortionType.g, 356, 16));
            foods.Add(new Food("Tatin Turta", 100, PortionType.g, 210, 16));
            foods.Add(new Food("Tiramisu", 100, PortionType.g, 283, 16));
            foods.Add(new Food("Tiramisu Keki", 100, PortionType.g, 291, 16));
            foods.Add(new Food("Unsuz Çikolatalı Kek", 100, PortionType.g, 509, 16));
            foods.Add(new Food("Vişneli Turta", 100, PortionType.g, 260, 16));
            foods.Add(new Food("Waffle", 100, PortionType.g, 312, 16));
            foods.Add(new Food("Yabanmersinli Muffin", 100, PortionType.g, 377, 16));
            foods.Add(new Food("Yabanmersinli Tart", 100, PortionType.g, 232, 16));
            foods.Add(new Food("Yuvarlak Kek", 100, PortionType.g, 370, 16));
            foods.Add(new Food("Çikolatalı Kek", 100, PortionType.g, 389, 16));
            foods.Add(new Food("Çikolatalı Mafin/Muffin", 100, PortionType.g, 420, 16));
            foods.Add(new Food("Çikolatalı Mus", 100, PortionType.g, 260, 16));
            foods.Add(new Food("Çilekli Muzlu Pasta", 100, PortionType.g, 281, 16));
            foods.Add(new Food("Çilekli Turta", 100, PortionType.g, 230, 16));
            foods.Add(new Food("Şeftalili Turta", 100, PortionType.g, 223, 16));

            //KONSERVE MEYVELER
            foods.Add(new Food("Ahududu Konservesi", 100, PortionType.g, 91, 17));
            foods.Add(new Food("Ananas Konservesi", 100, PortionType.g, 60, 17));
            foods.Add(new Food("Armut Konservesi", 100, PortionType.g, 35, 17));
            foods.Add(new Food("Bektaşi Üzümü Konservesi", 100, PortionType.g, 73, 17));
            foods.Add(new Food("Böğürtlen Konservesi", 100, PortionType.g, 92, 17));
            foods.Add(new Food("Dilimlenmiş Ananas Konservesi", 100, PortionType.g, 53, 17));
            foods.Add(new Food("Elma Püresi", 100, PortionType.g, 62, 17));
            foods.Add(new Food("Erik Konservesi", 100, PortionType.g, 58, 17));
            foods.Add(new Food("Greyfurt Konservesi", 100, PortionType.g, 37, 17));
            foods.Add(new Food("İncir Konservesi", 100, PortionType.g, 107, 17));
            foods.Add(new Food("Kayısı Konservesi", 100, PortionType.g, 48, 17));
            foods.Add(new Food("Kiraz Konservesi", 100, PortionType.g, 54, 17));
            foods.Add(new Food("Konserve Karışık Meyve", 100, PortionType.g, 71, 17));
            foods.Add(new Food("Konserve Meyve Kokteyli", 100, PortionType.g, 81, 17));
            foods.Add(new Food("Konserve Meyve Salatası", 100, PortionType.g, 50, 17));
            foods.Add(new Food("Kurutulmuş Meyve", 100, PortionType.g, 243, 17));
            foods.Add(new Food("Küp Ananas Konservesi", 100, PortionType.g, 53, 17));
            foods.Add(new Food("Kızılcık Konservesi", 100, PortionType.g, 178, 17));
            foods.Add(new Food("Mandarin / Mandalina Konservesi", 100, PortionType.g, 71, 17));
            foods.Add(new Food("Mango Konservesi", 100, PortionType.g, 65, 17));
            foods.Add(new Food("Portakal Konservesi", 100, PortionType.g, 62, 17));
            foods.Add(new Food("Vişne Konservesi", 100, PortionType.g, 81, 17));
            foods.Add(new Food("Yabanmersini Konservesi", 100, PortionType.g, 88, 17));
            foods.Add(new Food("Çilek Konservesi", 100, PortionType.g, 92, 17));
            foods.Add(new Food("Üzüm Konservesi", 100, PortionType.g, 76, 17));
            foods.Add(new Food("Şeftali Konservesi", 100, PortionType.g, 54, 17));

            //KREM PEYNİR
            foods.Add(new Food("Bayır Turpu", 100, PortionType.g, 48, 18));
            foods.Add(new Food("Cevizli Krem Peynir", 100, PortionType.g, 342, 18));
            foods.Add(new Food("Feta Krem Peynir", 100, PortionType.g, 342, 18));
            foods.Add(new Food("Kekikli Krem Peynir", 100, PortionType.g, 203, 18));
            foods.Add(new Food("Keçi Peyniri", 100, PortionType.g, 364, 18));
            foods.Add(new Food("Krem Peynir", 100, PortionType.g, 342, 18));
            foods.Add(new Food("Labne Peyniri", 100, PortionType.g, 63, 18));
            foods.Add(new Food("Lavaşkiri", 100, PortionType.g, 239, 18));
            foods.Add(new Food("Maskarpone", 100, PortionType.g, 450, 18));
            foods.Add(new Food("Otlu Krem Peynir", 100, PortionType.g, 342, 18));
            foods.Add(new Food("Philadelphia Krem Peynir", 100, PortionType.g, 342, 18));
            foods.Add(new Food("Sarımsaklı Krem Peynir", 100, PortionType.g, 342, 18));
            foods.Add(new Food("Süzme Peynir", 100, PortionType.g, 98, 18));
            foods.Add(new Food("Zeytinli Krem Peynir", 100, PortionType.g, 342, 18));

            //KÜMES HAYVANLARI
            foods.Add(new Food("Beç Tavuğu", 100, PortionType.g, 158, 19));
            foods.Add(new Food("Bıldırcın", 100, PortionType.g, 227, 19));
            foods.Add(new Food("Bıldırcın Göğsü", 100, PortionType.g, 123, 19));
            foods.Add(new Food("Devekuşu", 100, PortionType.g, 145, 19));
            foods.Add(new Food("Hindi", 100, PortionType.g, 189, 19));
            foods.Add(new Food("Hindi Budu", 100, PortionType.g, 208, 19));
            foods.Add(new Food("Hindi Göğsü", 100, PortionType.g, 135, 19));
            foods.Add(new Food("Hindi Kanadı", 100, PortionType.g, 221, 19));
            foods.Add(new Food("Hindi Pirzola", 100, PortionType.g, 189, 19));
            foods.Add(new Food("Hindi Steak", 100, PortionType.g, 189, 19));
            foods.Add(new Food("Kaz", 100, PortionType.g, 305, 19));
            foods.Add(new Food("Kumru", 100, PortionType.g, 142, 19));
            foods.Add(new Food("Kısırlaştırılmış Horoz", 100, PortionType.g, 229, 19));
            foods.Add(new Food("Poularde Albufera", 100, PortionType.g, 200, 19));
            foods.Add(new Food("Sülün", 100, PortionType.g, 239, 19));
            foods.Add(new Food("Sülün Budu", 100, PortionType.g, 239, 19));
            foods.Add(new Food("Sülün Göğsü", 100, PortionType.g, 133, 19));
            foods.Add(new Food("Tavuk", 100, PortionType.g, 219, 19));
            foods.Add(new Food("Tavuk Budu", 100, PortionType.g, 174, 19));
            foods.Add(new Food("Tavuk Göğsü", 100, PortionType.g, 172, 19));
            foods.Add(new Food("Tavuk Kanadı", 100, PortionType.g, 266, 19));
            foods.Add(new Food("Tavuk Taşlığı", 100, PortionType.g, 154, 19));
            foods.Add(new Food("Yaban Ördeği", 100, PortionType.g, 211, 19));
            foods.Add(new Food("Ördek", 100, PortionType.g, 337, 19));
            foods.Add(new Food("Ördek Göğsü", 100, PortionType.g, 201, 19));

            //MAKARNA VE NOODLE
            foods.Add(new Food("Arpa Şehriye", 100, PortionType.g, 357, 20));
            foods.Add(new Food("Bardakta Noodle", 100, PortionType.g, 192, 20));
            foods.Add(new Food("Burgu Makarna", 100, PortionType.g, 367, 20));
            foods.Add(new Food("Cannelloni / İri Düdük", 100, PortionType.g, 146, 20));
            foods.Add(new Food("Capellini /İnce Makarna", 100, PortionType.g, 353, 20));
            foods.Add(new Food("Cappelletti", 100, PortionType.g, 164, 20));
            foods.Add(new Food("Deniz Kabuğu", 100, PortionType.g, 353, 20));
            foods.Add(new Food("Durum Buğdaylı Semolina", 100, PortionType.g, 397, 20));
            foods.Add(new Food("Düdük Makarna", 100, PortionType.g, 370, 20));
            foods.Add(new Food("Düşük Karbonhidratlı Makarna", 100, PortionType.g, 282, 20));
            foods.Add(new Food("Ev Yapımı Erişte", 100, PortionType.g, 260, 20));
            foods.Add(new Food("Farfalle", 100, PortionType.g, 358, 20));
            foods.Add(new Food("Fetuccini", 100, PortionType.g, 353, 20));
            foods.Add(new Food("Fusilli", 100, PortionType.g, 352, 20));
            foods.Add(new Food("Ispanaklı Tortellini", 100, PortionType.g, 314, 20));
            foods.Add(new Food("Kayseri Mantısı", 100, PortionType.g, 264, 20));
            foods.Add(new Food("Lazanya Katları", 100, PortionType.g, 271, 20));
            foods.Add(new Food("Linguini", 100, PortionType.g, 357, 20));
            foods.Add(new Food("Makarna", 100, PortionType.g, 370, 20));
            foods.Add(new Food("Mantı", 100, PortionType.g, 200, 20));
            foods.Add(new Food("Mantı Hamuru", 100, PortionType.g, 99, 20));
            foods.Add(new Food("Mostaccioli", 100, PortionType.g, 184, 20));
            foods.Add(new Food("Orecchiette", 100, PortionType.g, 370, 20));
            foods.Add(new Food("Penne", 100, PortionType.g, 351, 20));
            foods.Add(new Food("Peynirli Tortellini", 100, PortionType.g, 291, 20));
            foods.Add(new Food("Ravioli", 100, PortionType.g, 77, 20));
            foods.Add(new Food("Rigatoni", 100, PortionType.g, 353, 20));
            foods.Add(new Food("Shirataki Noodle", 100, PortionType.g, 18, 20));
            foods.Add(new Food("Soya Noodle", 100, PortionType.g, 216, 20));
            foods.Add(new Food("Spagetti", 100, PortionType.g, 370, 20));
            foods.Add(new Food("Tagliatelle", 100, PortionType.g, 370, 20));
            foods.Add(new Food("Tam Buğday Noodle", 100, PortionType.g, 347, 20));
            foods.Add(new Food("Tam Buğday Spagetti", 100, PortionType.g, 351, 20));
            foods.Add(new Food("Tel Şehriye", 100, PortionType.g, 368, 20));
            foods.Add(new Food("Tortellini", 100, PortionType.g, 291, 20));
            foods.Add(new Food("Yağ Mantısı", 100, PortionType.g, 157, 20));
            foods.Add(new Food("Yumurtalı Noodle", 100, PortionType.g, 384, 20));

            //MEYVE SULARI
            foods.Add(new Food("Akai Suyu", 100, PortionType.ml, 58, 21));
            foods.Add(new Food("Aloe Vera", 100, PortionType.ml, 44, 21));
            foods.Add(new Food("Ananas Suyu", 100, PortionType.ml, 53, 21));
            foods.Add(new Food("Armut Nektarı", 100, PortionType.ml, 60, 21));
            foods.Add(new Food("Armut Suyu", 100, PortionType.ml, 60, 21));
            foods.Add(new Food("Böğürtlen Suyu", 100, PortionType.ml, 48, 21));
            foods.Add(new Food("Capri-Sun", 100, PortionType.ml, 41, 21));
            foods.Add(new Food("Domates Suyu", 100, PortionType.ml, 17, 21));
            foods.Add(new Food("Elma Suyu", 100, PortionType.ml, 46, 21));
            foods.Add(new Food("Enerji İçeceği", 100, PortionType.ml, 87, 21));
            foods.Add(new Food("Erik Suyu", 100, PortionType.ml, 71, 21));
            foods.Add(new Food("Greyfurt Suyu", 100, PortionType.ml, 46, 21));
            foods.Add(new Food("Havuç Suyu", 100, PortionType.ml, 40, 21));
            foods.Add(new Food("Hindistan Cevizi Suyu", 100, PortionType.ml, 19, 21));
            foods.Add(new Food("Hindistan Cevizi Sütü", 100, PortionType.ml, 233, 21));
            foods.Add(new Food("Kayısı Nektarı", 100, PortionType.ml, 56, 21));
            foods.Add(new Food("Kuşüzümü Suyu", 100, PortionType.ml, 48, 21));
            foods.Add(new Food("Kızılcık Suyu", 100, PortionType.ml, 46, 21));
            foods.Add(new Food("Lahana Suyu", 100, PortionType.ml, 14, 21));
            foods.Add(new Food("Limon Suyu", 100, PortionType.ml, 21, 21));
            foods.Add(new Food("Limonata", 100, PortionType.ml, 50, 21));
            foods.Add(new Food("Mandalina Suyu", 100, PortionType.ml, 43, 21));
            foods.Add(new Food("Mango Lassi", 100, PortionType.ml, 66, 21));
            foods.Add(new Food("Misket Limonu Suyu", 100, PortionType.ml, 21, 21));
            foods.Add(new Food("Muz Suyu", 100, PortionType.ml, 50, 21));
            foods.Add(new Food("Nar Suyu", 100, PortionType.ml, 66, 21));
            foods.Add(new Food("Nestea", 100, PortionType.ml, 21, 21));
            foods.Add(new Food("Papatya Suyu", 100, PortionType.ml, 0, 21));
            foods.Add(new Food("Papaya Suyu", 100, PortionType.ml, 58, 21));
            foods.Add(new Food("Portakal Suyu", 100, PortionType.ml, 46, 21));
            foods.Add(new Food("Salatalık Suyu", 100, PortionType.ml, 10, 21));
            foods.Add(new Food("Sebze Suyu", 100, PortionType.ml, 21, 21));
            foods.Add(new Food("Vişne Suyu", 100, PortionType.ml, 45, 21));
            foods.Add(new Food("Çarkıfelek Suyu", 100, PortionType.ml, 48, 21));
            foods.Add(new Food("Çavuşüzümü Suyu", 100, PortionType.ml, 75, 21));
            foods.Add(new Food("Üzüm Suyu", 100, PortionType.ml, 60, 21));
            foods.Add(new Food("Şeftali Nektarı", 100, PortionType.ml, 54, 21));
            foods.Add(new Food("Şeftali Suyu", 100, PortionType.ml, 54, 21));

            //MEYVELER
            foods.Add(new Food("Ahududu", 100, PortionType.g, 52, 22));
            foods.Add(new Food("Akai", 100, PortionType.g, 70, 22));
            foods.Add(new Food("Altın Çilek", 100, PortionType.g, 49, 22));
            foods.Add(new Food("Ananas", 100, PortionType.g, 50, 22));
            foods.Add(new Food("Armut", 100, PortionType.g, 57, 22));
            foods.Add(new Food("Avokado", 100, PortionType.g, 160, 22));
            foods.Add(new Food("Ayva", 100, PortionType.g, 57, 22));
            foods.Add(new Food("Böğürtlen", 100, PortionType.g, 43, 22));
            foods.Add(new Food("Dut", 100, PortionType.g, 43, 22));
            foods.Add(new Food("Elma", 100, PortionType.g, 52, 22));
            foods.Add(new Food("Elma Püresi", 100, PortionType.g, 68, 22));
            foods.Add(new Food("Erik", 100, PortionType.g, 46, 22));
            foods.Add(new Food("Frenk Üzümü", 100, PortionType.g, 56, 22));
            foods.Add(new Food("Guava", 100, PortionType.g, 68, 22));
            foods.Add(new Food("Hint Hurması", 100, PortionType.g, 239, 22));
            foods.Add(new Food("Hurma", 100, PortionType.g, 282, 22));
            foods.Add(new Food("İncir", 100, PortionType.g, 74, 22));
            foods.Add(new Food("İri Muz", 100, PortionType.g, 122, 22));
            foods.Add(new Food("Jackfruit (tayland meyvesi", 100, PortionType.g, 95, 22));
            foods.Add(new Food("Kan Portakalı", 100, PortionType.g, 50, 22));
            foods.Add(new Food("Kantalup Kavun", 100, PortionType.g, 34, 22));
            foods.Add(new Food("Karpuz", 100, PortionType.g, 30, 22));
            foods.Add(new Food("Kayısı", 100, PortionType.g, 48, 22));
            foods.Add(new Food("Kiraz", 100, PortionType.g, 50, 22));
            foods.Add(new Food("Kivi", 100, PortionType.g, 61, 22));
            foods.Add(new Food("Klementin Mandalina", 100, PortionType.g, 47, 22));
            foods.Add(new Food("Kuru Üzüm", 100, PortionType.g, 299, 22));
            foods.Add(new Food("Kızılcık", 100, PortionType.g, 46, 22));
            foods.Add(new Food("Limon", 100, PortionType.g, 29, 22));
            foods.Add(new Food("Liçi (tropik bir meyve)", 100, PortionType.g, 66, 22));
            foods.Add(new Food("Mandarin / Mandalina", 100, PortionType.g, 53, 22));
            foods.Add(new Food("Mango", 100, PortionType.g, 60, 22));
            foods.Add(new Food("Meyve Salatası", 100, PortionType.g, 50, 22));
            foods.Add(new Food("Misket Limonu", 100, PortionType.g, 30, 22));
            foods.Add(new Food("Muz", 100, PortionType.g, 89, 22));
            foods.Add(new Food("Nar", 100, PortionType.g, 83, 22));
            foods.Add(new Food("Nektarin", 100, PortionType.g, 44, 22));
            foods.Add(new Food("Papaya", 100, PortionType.g, 43, 22));
            foods.Add(new Food("Portakal", 100, PortionType.g, 47, 22));
            foods.Add(new Food("Rambutan", 100, PortionType.g, 82, 22));
            foods.Add(new Food("Trabzon Hurması", 100, PortionType.g, 127, 22));
            foods.Add(new Food("Yabanmersini", 100, PortionType.g, 57, 22));
            foods.Add(new Food("Yayla Muzu", 100, PortionType.g, 21, 22));
            foods.Add(new Food("Yeşil Erik", 100, PortionType.g, 41, 22));
            foods.Add(new Food("Yıldız Meyvesi", 100, PortionType.g, 31, 22));
            foods.Add(new Food("Zeytin", 100, PortionType.g, 115, 22));
            foods.Add(new Food("Çarkıfelek", 100, PortionType.g, 97, 22));
            foods.Add(new Food("Çilek", 100, PortionType.g, 32, 22));
            foods.Add(new Food("Üzüm", 100, PortionType.g, 69, 22));
            foods.Add(new Food("Şeftali", 100, PortionType.g, 39, 22));

            //OTLAR VE BAHARATLAR
            foods.Add(new Food("Acı Kırmızı Biber", 100, PortionType.g, 282, 23));
            foods.Add(new Food("Adaçayı", 100, PortionType.g, 315, 23));
            foods.Add(new Food("Anason", 100, PortionType.g, 337, 23));
            foods.Add(new Food("Anason Tohumu", 100, PortionType.g, 337, 23));
            foods.Add(new Food("Ardıç", 100, PortionType.g, 45, 23));
            foods.Add(new Food("Arnavut Biberi", 100, PortionType.g, 318, 23));
            foods.Add(new Food("Arugula", 100, PortionType.g, 25, 23));
            foods.Add(new Food("Asma Yaprağı", 100, PortionType.g, 93, 23));
            foods.Add(new Food("Badem Özütü", 100, PortionType.g, 374, 23));
            foods.Add(new Food("Balzamik Sirke", 100, PortionType.g, 88, 23));
            foods.Add(new Food("Bamya", 100, PortionType.g, 33, 23));
            foods.Add(new Food("Bayırturpu", 100, PortionType.g, 48, 23));
            foods.Add(new Food("Beyaz Biber", 100, PortionType.g, 296, 23));
            foods.Add(new Food("Biber", 100, PortionType.g, 251, 23));
            foods.Add(new Food("Biberiye", 100, PortionType.g, 131, 23));
            foods.Add(new Food("Deniz Tuzu", 100, PortionType.g, 0, 23));
            foods.Add(new Food("Dereotu", 100, PortionType.g, 43, 23));
            foods.Add(new Food("Elma Sirkesi", 100, PortionType.g, 21, 23));
            foods.Add(new Food("Etsuyu", 100, PortionType.g, 100, 23));
            foods.Add(new Food("Fesleğen", 100, PortionType.g, 233, 23));
            foods.Add(new Food("Frenk Soğanı", 100, PortionType.g, 30, 23));
            foods.Add(new Food("Gulgas", 100, PortionType.g, 112, 23));
            foods.Add(new Food("Hardal Tohumu", 100, PortionType.g, 508, 23));
            foods.Add(new Food("Haşhaş Tohumu", 100, PortionType.g, 525, 23));
            foods.Add(new Food("Hindiba", 100, PortionType.g, 23, 23));
            foods.Add(new Food("Hint Hurması", 100, PortionType.g, 239, 23));
            foods.Add(new Food("İyotlu Tuz", 100, PortionType.g, 0, 23));
            foods.Add(new Food("Jalapeno", 100, PortionType.g, 13, 23));
            foods.Add(new Food("Kapari", 100, PortionType.g, 23, 23));
            foods.Add(new Food("Kara Biber", 100, PortionType.g, 251, 23));
            foods.Add(new Food("Kara Hindiba", 100, PortionType.g, 45, 23));
            foods.Add(new Food("Kara Susam Tohumu", 100, PortionType.g, 573, 23));
            foods.Add(new Food("Karanfil", 100, PortionType.g, 274, 23));
            foods.Add(new Food("Kekik", 100, PortionType.g, 276, 23));
            foods.Add(new Food("Keklik Otu", 100, PortionType.g, 265, 23));
            foods.Add(new Food("Kimyon", 100, PortionType.g, 375, 23));
            foods.Add(new Food("Kişniş", 100, PortionType.g, 23, 23));
            foods.Add(new Food("Kristalize Tarçın", 100, PortionType.g, 335, 23));
            foods.Add(new Food("Köri", 100, PortionType.g, 325, 23));
            foods.Add(new Food("Küçük Hindistancevizi", 100, PortionType.g, 525, 23));
            foods.Add(new Food("Kırmızı Biber", 100, PortionType.g, 251, 23));
            foods.Add(new Food("Kırmızı Şarap Sirkesi", 100, PortionType.g, 19, 23));
            foods.Add(new Food("Kıyılmış Soğan", 100, PortionType.g, 40, 23));
            foods.Add(new Food("Maggi", 100, PortionType.g, 104, 23));
            foods.Add(new Food("Manyok", 100, PortionType.g, 160, 23));
            foods.Add(new Food("Maydanoz", 100, PortionType.g, 36, 23));
            foods.Add(new Food("Mercanköşkü Otu", 100, PortionType.g, 271, 23));
            foods.Add(new Food("Meyan Kökü", 100, PortionType.g, 375, 23));
            foods.Add(new Food("Nane", 100, PortionType.g, 70, 23));
            foods.Add(new Food("Pazı Otu", 100, PortionType.g, 19, 23));
            foods.Add(new Food("Portakal Kabuğu", 100, PortionType.g, 97, 23));
            foods.Add(new Food("Radika Kökü", 100, PortionType.g, 72, 23));
            foods.Add(new Food("Rezene", 100, PortionType.g, 31, 23));
            foods.Add(new Food("Rezene Tohumu", 100, PortionType.g, 345, 23));
            foods.Add(new Food("Safran", 100, PortionType.g, 310, 23));
            foods.Add(new Food("Sarımsak", 100, PortionType.g, 149, 23));
            foods.Add(new Food("Sarımsak Tozu", 100, PortionType.g, 331, 23));
            foods.Add(new Food("Sarımsak Tozu", 100, PortionType.g, 0, 23));
            foods.Add(new Food("Sirke", 100, PortionType.g, 18, 23));
            foods.Add(new Food("Soğan", 100, PortionType.g, 40, 23));
            foods.Add(new Food("Soğan Tozu", 100, PortionType.g, 341, 23));
            foods.Add(new Food("Susam Tohumları", 100, PortionType.g, 573, 23));
            foods.Add(new Food("Tarhun Otu", 100, PortionType.g, 295, 23));
            foods.Add(new Food("Tarçın", 100, PortionType.g, 247, 23));
            foods.Add(new Food("Tatlı Patates", 100, PortionType.g, 118, 23));
            foods.Add(new Food("Tere", 100, PortionType.g, 32, 23));
            foods.Add(new Food("Toz Kırmızı Biber", 100, PortionType.g, 282, 23));
            foods.Add(new Food("Tuz", 100, PortionType.g, 0, 23));
            foods.Add(new Food("Vanilya Fasulyesi", 100, PortionType.g, 250, 23));
            foods.Add(new Food("Vanilya Özütü", 100, PortionType.g, 288, 23));
            foods.Add(new Food("Yaban Havucu", 100, PortionType.g, 75, 23));
            foods.Add(new Food("Zencefil", 100, PortionType.g, 80, 23));
            foods.Add(new Food("Zerdeçal", 100, PortionType.g, 354, 23));
            foods.Add(new Food("Çörekotu", 100, PortionType.g, 333, 23));
            foods.Add(new Food("Şekerotu", 100, PortionType.g, 0, 23));

            //PASTA MALZEMELERİ
            foods.Add(new Food("Agar / Su Yosunu Jelatini", 100, PortionType.g, 26, 24));
            foods.Add(new Food("Agave / Sabır Otu Şurubu", 100, PortionType.g, 310, 24));
            foods.Add(new Food("Akçaağaç Pekmezi", 100, PortionType.g, 270, 24));
            foods.Add(new Food("Ayçiçeği Tohumu", 100, PortionType.g, 117, 24));
            foods.Add(new Food("Badem", 100, PortionType.g, 529, 24));
            foods.Add(new Food("Badem Özü", 100, PortionType.g, 258, 24));
            foods.Add(new Food("Bitkisel / Nebati Yağ", 100, PortionType.g, 884, 24));
            foods.Add(new Food("Ceviz", 100, PortionType.g, 131, 24));
            foods.Add(new Food("Damla Çikolata", 100, PortionType.g, 467, 24));
            foods.Add(new Food("Dark / Siyah Rom", 100, PortionType.g, 216, 24));
            foods.Add(new Food("Egg Nog", 100, PortionType.g, 88, 24));
            foods.Add(new Food("Esmer Şeker", 100, PortionType.g, 395, 24));
            foods.Add(new Food("Fruktoz", 100, PortionType.g, 368, 24));
            foods.Add(new Food("Fındık", 100, PortionType.g, 628, 24));
            foods.Add(new Food("Glikoz / Dekstroz", 100, PortionType.g, 286, 24));
            foods.Add(new Food("Glikoz Şurubu", 100, PortionType.g, 387, 24));
            foods.Add(new Food("Granül Şeker", 100, PortionType.g, 387, 24));
            foods.Add(new Food("Haşhaş Tohumu", 100, PortionType.g, 525, 24));
            foods.Add(new Food("Hindistan Cevizi Sütü", 100, PortionType.g, 50, 24));
            foods.Add(new Food("İrmik Unu", 100, PortionType.g, 350, 24));
            foods.Add(new Food("Jöle", 100, PortionType.g, 335, 24));
            foods.Add(new Food("Kabartma Tozu", 100, PortionType.g, 53, 24));
            foods.Add(new Food("Kakao", 100, PortionType.g, 228, 24));
            foods.Add(new Food("Katı Şeker", 100, PortionType.g, 625, 24));
            foods.Add(new Food("Kaymak", 100, PortionType.g, 345, 24));
            foods.Add(new Food("Koyulaştırılmış Süt", 100, PortionType.g, 134, 24));
            foods.Add(new Food("Krem Peynir", 100, PortionType.g, 54, 24));
            foods.Add(new Food("Krem Tartar", 100, PortionType.g, 258, 24));
            foods.Add(new Food("Kristalize Tarçın", 100, PortionType.g, 335, 24));
            foods.Add(new Food("Kuru Erik", 100, PortionType.g, 107, 24));
            foods.Add(new Food("Kuru İncir", 100, PortionType.g, 249, 24));
            foods.Add(new Food("Kuru Kayısı", 100, PortionType.g, 241, 24));
            foods.Add(new Food("Kuru Üzüm", 100, PortionType.g, 474, 24));
            foods.Add(new Food("Kuvertür", 100, PortionType.g, 600, 24));
            foods.Add(new Food("Laksatif", 100, PortionType.g, 240, 24));
            foods.Add(new Food("Limon Kabuğu Rendesi", 100, PortionType.g, 47, 24));
            foods.Add(new Food("Malt Unu", 100, PortionType.g, 361, 24));
            foods.Add(new Food("Malt Şekeri", 100, PortionType.g, 344, 24));
            foods.Add(new Food("Maltitol", 100, PortionType.g, 210, 24));
            foods.Add(new Food("Maltlı Süt", 100, PortionType.g, 405, 24));
            foods.Add(new Food("Maltodekstrin", 100, PortionType.g, 375, 24));
            foods.Add(new Food("Maya (kuru)", 100, PortionType.g, 325, 24));
            foods.Add(new Food("Mısır Nişastası", 100, PortionType.g, 381, 24));
            foods.Add(new Food("Mısır Unu / İri Taneli", 100, PortionType.g, 361, 24));
            foods.Add(new Food("Mısır Şurubu", 100, PortionType.g, 281, 24));
            foods.Add(new Food("Nane Şekeri Özütü", 100, PortionType.g, 0, 24));
            foods.Add(new Food("Nişasta", 100, PortionType.g, 381, 24));
            foods.Add(new Food("Pasta Süsleri", 100, PortionType.g, 500, 24));
            foods.Add(new Food("Pekmez", 100, PortionType.g, 290, 24));
            foods.Add(new Food("Pirinç Sütü", 100, PortionType.g, 49, 24));
            foods.Add(new Food("Portakal Kabuğu Şekerlemesi", 100, PortionType.g, 97, 24));
            foods.Add(new Food("Protein Tozu", 100, PortionType.g, 411, 24));
            foods.Add(new Food("Pudra Şekeri", 100, PortionType.g, 389, 24));
            foods.Add(new Food("Rende Hindistan Cevizi", 100, PortionType.g, 501, 24));
            foods.Add(new Food("Rom", 100, PortionType.g, 246, 24));
            foods.Add(new Food("Sakaroz", 100, PortionType.g, 387, 24));
            foods.Add(new Food("Sebze Yağı", 100, PortionType.g, 884, 24));
            foods.Add(new Food("Serpme Çikolata", 100, PortionType.g, 500, 24));
            foods.Add(new Food("Sorbitol", 100, PortionType.g, 375, 24));
            foods.Add(new Food("Soya Sütü", 100, PortionType.g, 41, 24));
            foods.Add(new Food("Susam Çekirdeği", 100, PortionType.g, 573, 24));
            foods.Add(new Food("Süt Tozu", 100, PortionType.g, 496, 24));
            foods.Add(new Food("Tam Buğday Unu", 100, PortionType.g, 340, 24));
            foods.Add(new Food("Tam Yağlı Süt", 100, PortionType.g, 61, 24));
            foods.Add(new Food("Tatlandırıcı", 100, PortionType.g, 360, 24));
            foods.Add(new Food("Toz Tarçın", 100, PortionType.g, 247, 24));
            foods.Add(new Food("Tuzsuz Tereyağı", 100, PortionType.g, 717, 24));
            foods.Add(new Food("Un", 100, PortionType.g, 364, 24));
            foods.Add(new Food("Vanilya Özütü", 100, PortionType.g, 288, 24));
            foods.Add(new Food("Vanilya Şekeri", 100, PortionType.g, 357, 24));
            foods.Add(new Food("Yaban Mersini Kurusu", 100, PortionType.g, 308, 24));
            foods.Add(new Food("Yağı Alınmış Koyu Süt", 100, PortionType.g, 62, 24));
            foods.Add(new Food("Yulaf Ezmesi", 100, PortionType.g, 384, 24));
            foods.Add(new Food("Yumurta", 100, PortionType.g, 97, 24));
            foods.Add(new Food("Yumurta Beyazı", 100, PortionType.g, 13, 24));
            foods.Add(new Food("Yumurta Sarısı", 100, PortionType.g, 322, 24));
            foods.Add(new Food("Çilek Reçeli", 100, PortionType.g, 278, 24));
            foods.Add(new Food("Ördek Yumurtası", 100, PortionType.g, 185, 24));
            foods.Add(new Food("Şeker", 100, PortionType.g, 21, 24));
            foods.Add(new Food("Şeker Kamışı", 100, PortionType.g, 387, 24));
            foods.Add(new Food("Şeker Kaplı Çikolata", 100, PortionType.g, 475, 24));
            foods.Add(new Food("Şekerleme / Bonbon", 100, PortionType.g, 592, 24));
            foods.Add(new Food("Şekerli Konsantre Süt", 100, PortionType.g, 321, 24));

            //PASTALAR, EKMEK VE UNLU MAMÜLLER
            foods.Add(new Food("Bagel", 100, PortionType.g, 257, 25));
            foods.Add(new Food("Baget", 100, PortionType.g, 274, 25));
            foods.Add(new Food("Bazlama", 100, PortionType.g, 240, 25));
            foods.Add(new Food("Beyaz Ekmek", 100, PortionType.g, 238, 25));
            foods.Add(new Food("Biküvi", 100, PortionType.g, 269, 25));
            foods.Add(new Food("Brioche", 100, PortionType.g, 346, 25));
            foods.Add(new Food("Browni", 100, PortionType.g, 405, 25));
            foods.Add(new Food("Cannoli", 100, PortionType.g, 254, 25));
            foods.Add(new Food("Chapati Pidesi", 100, PortionType.g, 240, 25));
            foods.Add(new Food("Ciabatta / Cabata", 100, PortionType.g, 271, 25));
            foods.Add(new Food("Cupcake", 100, PortionType.g, 305, 25));
            foods.Add(new Food("Donut", 100, PortionType.g, 421, 25));
            foods.Add(new Food("Ekşi Mayalı Ekmek", 100, PortionType.g, 289, 25));
            foods.Add(new Food("Elmalı Milföy", 100, PortionType.g, 348, 25));
            foods.Add(new Food("Elmalı Tart", 100, PortionType.g, 237, 25));
            foods.Add(new Food("Esmer Ekmek", 100, PortionType.g, 250, 25));
            foods.Add(new Food("Grissini", 100, PortionType.g, 400, 25));
            foods.Add(new Food("Hamburger Ekmeği", 100, PortionType.g, 178, 25));
            foods.Add(new Food("Ispanaklı Börek", 100, PortionType.g, 246, 25));
            foods.Add(new Food("İsveç Keki", 100, PortionType.g, 313, 25));
            foods.Add(new Food("İtalyan Ekmeği", 100, PortionType.g, 271, 25));
            foods.Add(new Food("İtalyan Pidesi", 100, PortionType.g, 249, 25));
            foods.Add(new Food("Krep", 100, PortionType.g, 224, 25));
            foods.Add(new Food("Kruvasan", 100, PortionType.g, 406, 25));
            foods.Add(new Food("Lavaş", 100, PortionType.g, 264, 25));
            foods.Add(new Food("Matzo / Hamursuz Ekmek", 100, PortionType.g, 351, 25));
            foods.Add(new Food("Muffin", 100, PortionType.g, 296, 25));
            foods.Add(new Food("Muzlu Ekmek", 100, PortionType.g, 326, 25));
            foods.Add(new Food("Mısır Ekmeği", 100, PortionType.g, 179, 25));
            foods.Add(new Food("Panettone", 100, PortionType.g, 318, 25));
            foods.Add(new Food("Pankek", 100, PortionType.g, 233, 25));
            foods.Add(new Food("Paskalya Çöreği", 100, PortionType.g, 283, 25));
            foods.Add(new Food("Patatesli Ekmek", 100, PortionType.g, 266, 25));
            foods.Add(new Food("Pide", 100, PortionType.g, 268, 25));
            foods.Add(new Food("Pita Ekmeği", 100, PortionType.g, 275, 25));
            foods.Add(new Food("Pişi", 100, PortionType.g, 258, 25));
            foods.Add(new Food("Pretzel", 100, PortionType.g, 338, 25));
            foods.Add(new Food("Pretzel", 100, PortionType.g, 338, 25));
            foods.Add(new Food("Pumpernickel / Alman Ekmeği", 100, PortionType.g, 250, 25));
            foods.Add(new Food("Sandviç", 100, PortionType.g, 304, 25));
            foods.Add(new Food("Sarımsaklı Ekmek", 100, PortionType.g, 350, 25));
            foods.Add(new Food("Sodalı Ekmek", 100, PortionType.g, 290, 25));
            foods.Add(new Food("Sosisli Sandviç Ekmeği", 100, PortionType.g, 279, 25));
            foods.Add(new Food("Su Böreği", 100, PortionType.g, 229, 25));
            foods.Add(new Food("Sufle", 100, PortionType.g, 204, 25));
            foods.Add(new Food("Talaş Böreği", 100, PortionType.g, 558, 25));
            foods.Add(new Food("Tam Buğday Ekmek", 100, PortionType.g, 247, 25));
            foods.Add(new Food("Tandır Ekmeği", 100, PortionType.g, 275, 25));
            foods.Add(new Food("Tarçınlı Çörek", 100, PortionType.g, 436, 25));
            foods.Add(new Food("Tortilla", 100, PortionType.g, 265, 25));
            foods.Add(new Food("Tost", 100, PortionType.g, 261, 25));
            foods.Add(new Food("Turta", 100, PortionType.g, 237, 25));
            foods.Add(new Food("Tuzlu Tart", 100, PortionType.g, 544, 25));
            foods.Add(new Food("Yassı Ekmek", 100, PortionType.g, 311, 25));
            foods.Add(new Food("Yağlı Yumuşak Çörek", 100, PortionType.g, 362, 25));
            foods.Add(new Food("Yufka", 100, PortionType.g, 236, 25));
            foods.Add(new Food("Yulaf Ezmeli Kurabiye", 100, PortionType.g, 450, 25));
            foods.Add(new Food("Çavdar Ekmeği", 100, PortionType.g, 259, 25));
            foods.Add(new Food("Çok Tahıllı Ekmek", 100, PortionType.g, 265, 25));
            foods.Add(new Food("Çörek", 100, PortionType.g, 316, 25));
            foods.Add(new Food("Üzümlü Ekmek", 100, PortionType.g, 274, 25));

            //PATATES ÜRÜNLERİ
            foods.Add(new Food("Beyaz Patates", 100, PortionType.g, 94, 26));
            foods.Add(new Food("Elma Dilim Patates", 100, PortionType.g, 123, 26));
            foods.Add(new Food("Fırınlanmış Biberiyeli Patates", 100, PortionType.g, 93, 26));
            foods.Add(new Food("Fırınlanmış Patates", 100, PortionType.g, 93, 26));
            foods.Add(new Food("Gnocchi/Niyokki", 100, PortionType.g, 133, 26));
            foods.Add(new Food("Haşlanmış Patates", 100, PortionType.g, 87, 26));
            foods.Add(new Food("Kroket", 100, PortionType.g, 127, 26));
            foods.Add(new Food("Kızarmış Patates", 100, PortionType.g, 312, 26));
            foods.Add(new Food("Kızarmış Patates", 100, PortionType.g, 312, 26));
            foods.Add(new Food("Mantı", 100, PortionType.g, 124, 26));
            foods.Add(new Food("Mantı Hamuru", 100, PortionType.g, 124, 26));
            foods.Add(new Food("Manyok", 100, PortionType.g, 160, 26));
            foods.Add(new Food("Omlet", 100, PortionType.g, 154, 26));
            foods.Add(new Food("Patates", 100, PortionType.g, 77, 26));
            foods.Add(new Food("Patates Graten", 100, PortionType.g, 132, 26));
            foods.Add(new Food("Patates Mantısı", 100, PortionType.g, 124, 26));
            foods.Add(new Food("Patates Nişastası", 100, PortionType.g, 331, 26));
            foods.Add(new Food("Patates Püresi", 100, PortionType.g, 89, 26));
            foods.Add(new Food("Patates Salatası", 100, PortionType.g, 143, 26));
            foods.Add(new Food("Patatesli Börek", 100, PortionType.g, 185, 26));
            foods.Add(new Food("Rösti", 100, PortionType.g, 138, 26));
            foods.Add(new Food("Tatlı Patates", 100, PortionType.g, 92, 26));
            foods.Add(new Food("Yukon Sarı Patates", 100, PortionType.g, 82, 26));
            foods.Add(new Food("Çubuk Patates", 100, PortionType.g, 522, 26));

            //PEYNİR
            foods.Add(new Food("Asiago Peyniri", 100, PortionType.g, 392, 27));
            foods.Add(new Food("Babybel Peyniri", 100, PortionType.g, 333, 27));
            foods.Add(new Food("Brie Peyniri", 100, PortionType.g, 334, 27));
            foods.Add(new Food("Camembert Peyniri", 100, PortionType.g, 300, 27));
            foods.Add(new Food("Cheddar Peyniri", 100, PortionType.g, 403, 27));
            foods.Add(new Food("Chester", 100, PortionType.g, 387, 27));
            foods.Add(new Food("Cottage Peyniri", 100, PortionType.g, 98, 27));
            foods.Add(new Food("Edam Peyniri", 100, PortionType.g, 357, 27));
            foods.Add(new Food("Emmantel", 100, PortionType.g, 357, 27));
            foods.Add(new Food("Eski Kaşar Peyniri", 100, PortionType.g, 435, 27));
            foods.Add(new Food("Feta", 100, PortionType.g, 264, 27));
            foods.Add(new Food("Fondü Peyniri", 100, PortionType.g, 228, 27));
            foods.Add(new Food("Fontina", 100, PortionType.g, 389, 27));
            foods.Add(new Food("Gorgonzola", 100, PortionType.g, 350, 27));
            foods.Add(new Food("Gouda", 100, PortionType.g, 356, 27));
            foods.Add(new Food("Gruyere", 100, PortionType.g, 413, 27));
            foods.Add(new Food("Havarti", 100, PortionType.g, 371, 27));
            foods.Add(new Food("Hellim", 100, PortionType.g, 321, 27));
            foods.Add(new Food("Hollanda Peyniri", 100, PortionType.g, 393, 27));
            foods.Add(new Food("Izgara Peynir", 100, PortionType.g, 350, 27));
            foods.Add(new Food("İngiliz Rokfor Peyniri", 100, PortionType.g, 393, 27));
            foods.Add(new Food("İsveç Peyniri", 100, PortionType.g, 380, 27));
            foods.Add(new Food("İsviçre Fondü Peyniri", 100, PortionType.g, 357, 27));
            foods.Add(new Food("İtalyan Peyniri", 100, PortionType.g, 397, 27));
            foods.Add(new Food("Jarlsberg", 100, PortionType.g, 352, 27));
            foods.Add(new Food("Kaskaval Peyniri", 100, PortionType.g, 340, 27));
            foods.Add(new Food("Kaşar Peyniri", 100, PortionType.g, 337, 27));
            foods.Add(new Food("Keçi Peyniri", 100, PortionType.g, 364, 27));
            foods.Add(new Food("Koyun Peyniri", 100, PortionType.g, 364, 27));
            foods.Add(new Food("Krem Peynir", 100, PortionType.g, 290, 27));
            foods.Add(new Food("Maasdam Peyniri", 100, PortionType.g, 344, 27));
            foods.Add(new Food("Manchego Peyniri", 100, PortionType.g, 320, 27));
            foods.Add(new Food("Mavi Peynir", 100, PortionType.g, 353, 27));
            foods.Add(new Food("Mozzarella", 100, PortionType.g, 280, 27));
            foods.Add(new Food("Muenster Peyniri", 100, PortionType.g, 368, 27));
            foods.Add(new Food("Neufchatel Peyniri", 100, PortionType.g, 253, 27));
            foods.Add(new Food("Parmesan", 100, PortionType.g, 431, 27));
            foods.Add(new Food("Pecorino", 100, PortionType.g, 387, 27));
            foods.Add(new Food("Provolone", 100, PortionType.g, 351, 27));
            foods.Add(new Food("Rende Parmesan", 100, PortionType.g, 431, 27));
            foods.Add(new Food("Ricotta", 100, PortionType.g, 174, 27));
            foods.Add(new Food("Rokfor", 100, PortionType.g, 369, 27));
            foods.Add(new Food("Tulum Peyniri", 100, PortionType.g, 363, 27));
            foods.Add(new Food("Yumuşak Peynir", 100, PortionType.g, 268, 27));

            //PİZZA
            foods.Add(new Food("Beyaz Pizza", 100, PortionType.g, 246, 28));
            foods.Add(new Food("Calabrese Pizza", 100, PortionType.g, 235, 28));
            foods.Add(new Food("Calzone", 100, PortionType.g, 231, 28));
            foods.Add(new Food("Capricciosa Pizza", 100, PortionType.g, 260, 28));
            foods.Add(new Food("Deniz Ürünlü Pizza", 100, PortionType.g, 245, 28));
            foods.Add(new Food("Doldurulmuş Kabuk Pizza", 100, PortionType.g, 255, 28));
            foods.Add(new Food("Dört Peynirli Pizza", 100, PortionType.g, 248, 28));
            foods.Add(new Food("Hawai Pizza", 100, PortionType.g, 115, 28));
            foods.Add(new Food("Ispanaklı Feta Peynirli Pizza", 100, PortionType.g, 242, 28));
            foods.Add(new Food("Ispanaklı Pizza", 100, PortionType.g, 234, 28));
            foods.Add(new Food("İnce Kabuk Pizza", 100, PortionType.g, 261, 28));
            foods.Add(new Food("Kare Pizza", 100, PortionType.g, 200, 28));
            foods.Add(new Food("Karidesli Pizza", 100, PortionType.g, 209, 28));
            foods.Add(new Food("Keçi Peynirli Pizza", 100, PortionType.g, 219, 28));
            foods.Add(new Food("Kırmızı Biberli Pizza", 100, PortionType.g, 192, 28));
            foods.Add(new Food("Kıymalı Pizza", 100, PortionType.g, 197, 28));
            foods.Add(new Food("Mantarlı Pizza", 100, PortionType.g, 212, 28));
            foods.Add(new Food("Margarita Pizza", 100, PortionType.g, 275, 28));
            foods.Add(new Food("Mozarellalı Pizza", 100, PortionType.g, 249, 28));
            foods.Add(new Food("Napoli Pizza", 100, PortionType.g, 202, 28));
            foods.Add(new Food("Peynirli Pizza", 100, PortionType.g, 267, 28));
            foods.Add(new Food("Pizza Hamuru", 100, PortionType.g, 228, 28));
            foods.Add(new Food("Pizza Hut Doldurulmuş Kabuk Piza", 100, PortionType.g, 255, 28));
            foods.Add(new Food("Pizza Hut Supreme Pizza", 100, PortionType.g, 248, 28));
            foods.Add(new Food("Pizza Pepperoni", 100, PortionType.g, 255, 28));
            foods.Add(new Food("Pizza Rulosu", 100, PortionType.g, 247, 28));
            foods.Add(new Food("Salamlı Pizza", 100, PortionType.g, 255, 28));
            foods.Add(new Food("Sebzeli Pizza", 100, PortionType.g, 256, 28));
            foods.Add(new Food("Sicilya Pizza", 100, PortionType.g, 241, 28));
            foods.Add(new Food("Sosisli Pizza", 100, PortionType.g, 246, 28));
            foods.Add(new Food("Sucuklu Pizza", 100, PortionType.g, 254, 28));
            foods.Add(new Food("Tavuklu Pizza", 100, PortionType.g, 234, 28));
            foods.Add(new Food("Ton Balıklı Pizza", 100, PortionType.g, 254, 28));
            foods.Add(new Food("Vejeteryan Pizza", 100, PortionType.g, 256, 28));

            //SAKATAT VE İÇ ORGANLAR
            foods.Add(new Food("Bumbar", 100, PortionType.g, 233, 29));
            foods.Add(new Food("Dana Akciğeri", 100, PortionType.g, 192, 29));
            foods.Add(new Food("Dana Beyni", 100, PortionType.g, 136, 29));
            foods.Add(new Food("Dana Böbreği", 100, PortionType.g, 163, 29));
            foods.Add(new Food("Dana Dili", 100, PortionType.g, 202, 29));
            foods.Add(new Food("Dana Yüreği", 100, PortionType.g, 186, 29));
            foods.Add(new Food("Domuz Akciğeri", 100, PortionType.g, 99, 29));
            foods.Add(new Food("Domuz Beyni", 100, PortionType.g, 138, 29));
            foods.Add(new Food("Domuz Böbreği", 100, PortionType.g, 151, 29));
            foods.Add(new Food("Domuz Ciğeri", 100, PortionType.g, 165, 29));
            foods.Add(new Food("Domuz Dili", 100, PortionType.g, 271, 29));
            foods.Add(new Food("Domuz Yüreği", 100, PortionType.g, 148, 29));
            foods.Add(new Food("Hindi İç Organlar", 100, PortionType.g, 173, 29));
            foods.Add(new Food("Hindi Karaciğeri", 100, PortionType.g, 189, 29));
            foods.Add(new Food("Hindi Midesi", 100, PortionType.g, 148, 29));
            foods.Add(new Food("Hindi Yüreği", 100, PortionType.g, 174, 29));
            foods.Add(new Food("Kaz Ciğeri", 100, PortionType.g, 133, 29));
            foods.Add(new Food("Koç Yumurtası", 100, PortionType.g, 109, 29));
            foods.Add(new Food("Kuzu Beyni", 100, PortionType.g, 122, 29));
            foods.Add(new Food("Kuzu Ciğeri", 100, PortionType.g, 238, 29));
            foods.Add(new Food("Kuzu Yüreği", 100, PortionType.g, 185, 29));
            foods.Add(new Food("Sığır Akciğeri", 100, PortionType.g, 120, 29));
            foods.Add(new Food("Sığır Beyni", 100, PortionType.g, 196, 29));
            foods.Add(new Food("Sığır Böbreği", 100, PortionType.g, 158, 29));
            foods.Add(new Food("Sığır Dili", 100, PortionType.g, 284, 29));
            foods.Add(new Food("Sığır Karaciğeri", 100, PortionType.g, 191, 29));
            foods.Add(new Food("Sığır Yüreği", 100, PortionType.g, 165, 29));
            foods.Add(new Food("Tavuk İç Organları", 100, PortionType.g, 277, 29));
            foods.Add(new Food("Tavuk Karaciğeri", 100, PortionType.g, 172, 29));
            foods.Add(new Food("Tavuk Midesi", 100, PortionType.g, 148, 29));
            foods.Add(new Food("Tavuk Yüreği", 100, PortionType.g, 185, 29));
            foods.Add(new Food("Yumuşak Domuz Eti", 100, PortionType.g, 219, 29));
            foods.Add(new Food("Yumuşak Sığır Eti", 100, PortionType.g, 271, 29));
            foods.Add(new Food("Ördek Karaciğeri", 100, PortionType.g, 136, 29));

            //SEBZELER
            foods.Add(new Food("Acur", 100, PortionType.g, 14, 30));
            foods.Add(new Food("Acı Marul", 100, PortionType.g, 17, 30));
            foods.Add(new Food("Bamya", 100, PortionType.g, 33, 30));
            foods.Add(new Food("Bayırturpu", 100, PortionType.g, 48, 30));
            foods.Add(new Food("Bebek Soğan", 100, PortionType.g, 72, 30));
            foods.Add(new Food("Bezelye", 100, PortionType.g, 81, 30));
            foods.Add(new Food("Biber", 100, PortionType.g, 27, 30));
            foods.Add(new Food("Brokoli", 100, PortionType.g, 34, 30));
            foods.Add(new Food("Brüksel Lahanası", 100, PortionType.g, 43, 30));
            foods.Add(new Food("Deniz Börülcesi", 100, PortionType.g, 133, 30));
            foods.Add(new Food("Dolmalık Kabak", 100, PortionType.g, 17, 30));
            foods.Add(new Food("Domates", 100, PortionType.g, 18, 30));
            foods.Add(new Food("Enginar", 100, PortionType.g, 47, 30));
            foods.Add(new Food("Frenksoğanu", 100, PortionType.g, 30, 30));
            foods.Add(new Food("Hardal Otu", 100, PortionType.g, 27, 30));
            foods.Add(new Food("Havuz", 100, PortionType.g, 41, 30));
            foods.Add(new Food("Hindiba", 100, PortionType.g, 72, 30));
            foods.Add(new Food("Ispanak", 100, PortionType.g, 23, 30));
            foods.Add(new Food("Ispanak Ezmesi", 100, PortionType.g, 74, 30));
            foods.Add(new Food("Kabak", 100, PortionType.g, 26, 30));
            foods.Add(new Food("Kara Lahana", 100, PortionType.g, 32, 30));
            foods.Add(new Food("Karnabahar", 100, PortionType.g, 25, 30));
            foods.Add(new Food("Kereviz", 100, PortionType.g, 16, 30));
            foods.Add(new Food("Kuşkonmaz", 100, PortionType.g, 20, 30));
            foods.Add(new Food("Kırmızı Biber", 100, PortionType.g, 27, 30));
            foods.Add(new Food("Kırmızı Kabak", 100, PortionType.g, 31, 30));
            foods.Add(new Food("Kırmızı Pancar", 100, PortionType.g, 43, 30));
            foods.Add(new Food("Kırmızı Turp", 100, PortionType.g, 16, 30));
            foods.Add(new Food("Kıvırcık Lahana", 100, PortionType.g, 49, 30));
            foods.Add(new Food("Lahana", 100, PortionType.g, 25, 30));
            foods.Add(new Food("Mantar", 100, PortionType.g, 22, 30));
            foods.Add(new Food("Marul", 100, PortionType.g, 15, 30));
            foods.Add(new Food("Mısır", 100, PortionType.g, 365, 30));
            foods.Add(new Food("Nori Denizyosunu", 100, PortionType.g, 35, 30));
            foods.Add(new Food("Patates", 100, PortionType.g, 77, 30));
            foods.Add(new Food("Patlıcan", 100, PortionType.g, 25, 30));
            foods.Add(new Food("Pazı", 100, PortionType.g, 19, 30));
            foods.Add(new Food("Pırasa", 100, PortionType.g, 61, 30));
            foods.Add(new Food("Rezene", 100, PortionType.g, 31, 30));
            foods.Add(new Food("Roka", 100, PortionType.g, 25, 30));
            foods.Add(new Food("Salatalık", 100, PortionType.g, 16, 30));
            foods.Add(new Food("Sarımsak", 100, PortionType.g, 149, 30));
            foods.Add(new Food("Siyah Zeytin", 100, PortionType.g, 115, 30));
            foods.Add(new Food("Soğan", 100, PortionType.g, 40, 30));
            foods.Add(new Food("Su Kabağı", 100, PortionType.g, 14, 30));
            foods.Add(new Food("Tatlı Patates", 100, PortionType.g, 86, 30));
            foods.Add(new Food("Turp", 100, PortionType.g, 28, 30));
            foods.Add(new Food("Wasabi", 100, PortionType.g, 109, 30));
            foods.Add(new Food("Yabani Havuç", 100, PortionType.g, 75, 30));
            foods.Add(new Food("Yapraklı Turp", 100, PortionType.g, 20, 30));
            foods.Add(new Food("Yer Lahanası", 100, PortionType.g, 27, 30));
            foods.Add(new Food("Yeşil Fasulye", 100, PortionType.g, 31, 30));
            foods.Add(new Food("Yeşil Soğan", 100, PortionType.g, 32, 30));
            foods.Add(new Food("Yeşil Zeytin", 100, PortionType.g, 115, 30));
            foods.Add(new Food("Zeytin", 100, PortionType.g, 115, 30));
            foods.Add(new Food("Çin Kabağı", 100, PortionType.g, 16, 30));
            foods.Add(new Food("Şalgam", 100, PortionType.g, 38, 30));
            foods.Add(new Food("Şeri Domates", 100, PortionType.g, 100, 30));
            foods.Add(new Food("Şevketibostan", 100, PortionType.g, 158, 30));

            //SIĞIR VE DANA ETİ
            foods.Add(new Food("Dana", 100, PortionType.g, 282, 31));
            foods.Add(new Food("Dana Bacağı", 100, PortionType.g, 211, 31));
            foods.Add(new Food("Dana Döşü", 100, PortionType.g, 282, 31));
            foods.Add(new Food("Dana Fileto", 100, PortionType.g, 217, 31));
            foods.Add(new Food("Dana İncik", 100, PortionType.g, 177, 31));
            foods.Add(new Food("Dana İçyağı", 100, PortionType.g, 854, 31));
            foods.Add(new Food("Dana Kıyması", 100, PortionType.g, 143, 31));
            foods.Add(new Food("Dana Omuzu", 100, PortionType.g, 183, 31));
            foods.Add(new Food("Dana Rozbif", 100, PortionType.g, 175, 31));
            foods.Add(new Food("Dana Sirloin", 100, PortionType.g, 204, 31));
            foods.Add(new Food("Döş Steak", 100, PortionType.g, 205, 31));
            foods.Add(new Food("Fleminyon", 100, PortionType.g, 207, 31));
            foods.Add(new Food("Gerdan Kıyma", 100, PortionType.g, 250, 31));
            foods.Add(new Food("Gerdan Rosto", 100, PortionType.g, 141, 31));
            foods.Add(new Food("Gerdan Steak", 100, PortionType.g, 137, 31));
            foods.Add(new Food("Kemiksiz Pirzola", 100, PortionType.g, 217, 31));
            foods.Add(new Food("Pançeta", 100, PortionType.g, 194, 31));
            foods.Add(new Food("Rozbif", 100, PortionType.g, 187, 31));
            foods.Add(new Food("Rumstek", 100, PortionType.g, 171, 31));
            foods.Add(new Food("Sığır Boynu", 100, PortionType.g, 213, 31));
            foods.Add(new Food("Sığır Döşü", 100, PortionType.g, 137, 31));
            foods.Add(new Food("Sığır Eti", 100, PortionType.g, 171, 31));
            foods.Add(new Food("Sığır Eti Güveç", 100, PortionType.g, 191, 31));
            foods.Add(new Food("Sığır Fileto", 100, PortionType.g, 189, 31));
            foods.Add(new Food("Sığır Gulaş", 100, PortionType.g, 123, 31));
            foods.Add(new Food("Sığır İçyağı", 100, PortionType.g, 902, 31));
            foods.Add(new Food("Sığır İşkembe", 100, PortionType.g, 94, 31));
            foods.Add(new Food("Sığır Kaburga", 100, PortionType.g, 196, 31));
            foods.Add(new Food("Sığır Köftesi", 100, PortionType.g, 247, 31));
            foods.Add(new Food("Sığır Kıyması", 100, PortionType.g, 241, 31));
            foods.Add(new Food("Sığır Orta Kaburga", 100, PortionType.g, 404, 31));
            foods.Add(new Food("Sığır Pankreas", 100, PortionType.g, 271, 31));
            foods.Add(new Food("Sığır Sirloin", 100, PortionType.g, 182, 31));
            foods.Add(new Food("Sığır Timus", 100, PortionType.g, 319, 31));
            foods.Add(new Food("T-Bone Steak", 100, PortionType.g, 221, 31));
            foods.Add(new Food("Şerit Steak", 100, PortionType.g, 117, 31));

            //SIVI VE KATI YAĞLAR
            foods.Add(new Food("Avokado Yağı", 100, PortionType.ml, 857, 32));
            foods.Add(new Food("Ayçiçeği Yağ", 100, PortionType.ml, 884, 32));
            foods.Add(new Food("Badem Yağı", 100, PortionType.ml, 882, 32));
            foods.Add(new Food("Balık Yağı", 100, PortionType.ml, 1000, 32));
            foods.Add(new Food("Ceviz Yağı", 100, PortionType.ml, 889, 32));
            foods.Add(new Food("Domuz Yağı", 100, PortionType.ml, 902, 32));
            foods.Add(new Food("Fındık Yağı", 100, PortionType.ml, 857, 32));
            foods.Add(new Food("Hardal Yağı", 100, PortionType.ml, 884, 32));
            foods.Add(new Food("Hindistan Cevizi Yağı", 100, PortionType.ml, 857, 32));
            foods.Add(new Food("Kanola Yağı", 100, PortionType.ml, 884, 32));
            foods.Add(new Food("Keten Tohumu Yağı", 100, PortionType.ml, 884, 32));
            foods.Add(new Food("Macadamia Yağı", 100, PortionType.ml, 819, 32));
            foods.Add(new Food("Margarin", 100, PortionType.ml, 717, 32));
            foods.Add(new Food("Mısırözü Yağı", 100, PortionType.ml, 800, 32));
            foods.Add(new Food("PalmYağı", 100, PortionType.ml, 882, 32));
            foods.Add(new Food("Pamuk Tohumu Yağı", 100, PortionType.ml, 882, 32));
            foods.Add(new Food("Ringa Balığı Yağı", 100, PortionType.ml, 902, 32));
            foods.Add(new Food("Safyağ", 100, PortionType.ml, 120, 32));
            foods.Add(new Food("Sardalye Yağı", 100, PortionType.ml, 902, 32));
            foods.Add(new Food("Soya Fasulyesi Yağı", 100, PortionType.ml, 889, 32));
            foods.Add(new Food("Susam Yağı", 100, PortionType.ml, 884, 32));
            foods.Add(new Food("Tereyağ", 100, PortionType.ml, 720, 32));
            foods.Add(new Food("Yalancısafran Yağı", 100, PortionType.ml, 857, 32));
            foods.Add(new Food("Zeytinyağ", 100, PortionType.ml, 884, 32));
            foods.Add(new Food("Üzüm Çekirdeği Yağı", 100, PortionType.ml, 884, 32));

            //SODA VE MEŞRUBATLAR
            foods.Add(new Food("Coca Cola Lime", 100, PortionType.ml, 41, 33));
            foods.Add(new Food("Diet Kola", 100, PortionType.ml, 1, 33));
            foods.Add(new Food("Diet Pepsi", 100, PortionType.ml, 0, 33));
            foods.Add(new Food("Fanta", 100, PortionType.ml, 39, 33));
            foods.Add(new Food("Fanta Zero", 100, PortionType.ml, 0, 33));
            foods.Add(new Food("Gazoz", 100, PortionType.ml, 35, 33));
            foods.Add(new Food("Ginger Ale", 100, PortionType.ml, 35, 33));
            foods.Add(new Food("Ice Tea", 100, PortionType.ml, 27, 33));
            foods.Add(new Food("Kola", 100, PortionType.ml, 42, 33));
            foods.Add(new Food("Kola Zero", 100, PortionType.ml, 0, 33));
            foods.Add(new Food("Light Minute Maid", 100, PortionType.ml, 2, 33));
            foods.Add(new Food("Limonata", 100, PortionType.ml, 42, 33));
            foods.Add(new Food("Limonlu Meşrubat", 100, PortionType.ml, 34, 33));
            foods.Add(new Food("Minute Maid", 100, PortionType.ml, 46, 33));
            foods.Add(new Food("Pepsi", 100, PortionType.ml, 44, 33));
            foods.Add(new Food("Portakallı Soda", 100, PortionType.ml, 48, 33));
            foods.Add(new Food("Powerade", 100, PortionType.ml, 120, 33));
            foods.Add(new Food("Schweppes Ginger Ale", 100, PortionType.ml, 38, 33));
            foods.Add(new Food("Soda", 100, PortionType.ml, 53, 33));
            foods.Add(new Food("Sprite", 100, PortionType.ml, 37, 33));
            foods.Add(new Food("Sprite Zero", 100, PortionType.ml, 0, 33));
            foods.Add(new Food("Tonik", 100, PortionType.ml, 35, 33));

            //SOSİS VE SUCUK
            foods.Add(new Food("Acılı İspanyol Domuz Sucuğu", 100, PortionType.g, 455, 34));
            foods.Add(new Food("Bacon", 100, PortionType.g, 407, 34));
            foods.Add(new Food("Baharatlı Alman Sosisi", 100, PortionType.g, 305, 34));
            foods.Add(new Food("Baharatlı Küçük Sosis", 100, PortionType.g, 307, 34));
            foods.Add(new Food("Bockwurst", 100, PortionType.g, 301, 34));
            foods.Add(new Food("Bolonya Sosisi", 100, PortionType.g, 247, 34));
            foods.Add(new Food("Ciğer Pate", 100, PortionType.g, 319, 34));
            foods.Add(new Food("Ciğer Salamı", 100, PortionType.g, 326, 34));
            foods.Add(new Food("Domuz Eti", 100, PortionType.g, 247, 34));
            foods.Add(new Food("Domuz Sucuğu", 100, PortionType.g, 297, 34));
            foods.Add(new Food("Füme Domuz Sosisi", 100, PortionType.g, 232, 34));
            foods.Add(new Food("Füme Sosis", 100, PortionType.g, 301, 34));
            foods.Add(new Food("Hot Dog", 100, PortionType.g, 278, 34));
            foods.Add(new Food("İtalyan Sosisi", 100, PortionType.g, 149, 34));
            foods.Add(new Food("Kanlı Domuz Sosisi", 100, PortionType.g, 379, 34));
            foods.Add(new Food("Kas (Brawn)", 100, PortionType.g, 157, 34));
            foods.Add(new Food("Kielbasa", 100, PortionType.g, 309, 34));
            foods.Add(new Food("Konserve Sığır", 100, PortionType.g, 153, 34));
            foods.Add(new Food("Landjager", 100, PortionType.g, 352, 34));
            foods.Add(new Food("Mettwurst", 100, PortionType.g, 310, 34));
            foods.Add(new Food("Mortadella (İtalyan Sosisi)", 100, PortionType.g, 311, 34));
            foods.Add(new Food("Pastırma", 100, PortionType.g, 133, 34));
            foods.Add(new Food("Pişmiş Jambon", 100, PortionType.g, 133, 34));
            foods.Add(new Food("Prosciutto (İtalyan Salamı)", 100, PortionType.g, 195, 34));
            foods.Add(new Food("Pıhtılaşmış Domuz Kanı Sosisi", 100, PortionType.g, 379, 34));
            foods.Add(new Food("Salam", 100, PortionType.g, 336, 34));
            foods.Add(new Food("Sosis", 100, PortionType.g, 230, 34));
            foods.Add(new Food("Sucuk", 100, PortionType.g, 332, 34));
            foods.Add(new Food("Tavuk Eti", 100, PortionType.g, 79, 34));
            foods.Add(new Food("Tavuk Göğsü", 100, PortionType.g, 79, 34));
            foods.Add(new Food("Tavuk Salatası", 100, PortionType.g, 81, 34));
            foods.Add(new Food("Weisswurst (Beyaz Sosis)", 100, PortionType.g, 313, 34));
            foods.Add(new Food("Öğle Yemeği Eti", 100, PortionType.g, 117, 34));

            //SOSLAR VE SALATA SOSLARI
            foods.Add(new Food("Arrabiata Sos", 100, PortionType.g, 36, 35));
            foods.Add(new Food("Avcı Sosu", 100, PortionType.g, 45, 35));
            foods.Add(new Food("Ayvar", 100, PortionType.g, 18, 35));
            foods.Add(new Food("Ballı Hardal Sosu", 100, PortionType.g, 464, 35));
            foods.Add(new Food("Balzamik Vinaigrette Salata Sosu", 100, PortionType.g, 290, 35));
            foods.Add(new Food("Barbekü Sos", 100, PortionType.g, 150, 35));
            foods.Add(new Food("Bearnez Sosu", 100, PortionType.g, 414, 35));
            foods.Add(new Food("Beşamel Sos", 100, PortionType.g, 225, 35));
            foods.Add(new Food("Bolonez", 100, PortionType.g, 106, 35));
            foods.Add(new Food("Cacık", 100, PortionType.g, 94, 35));
            foods.Add(new Food("Chili Sos", 100, PortionType.g, 112, 35));
            foods.Add(new Food("Domates Püresi", 100, PortionType.g, 38, 35));
            foods.Add(new Food("Domates Salçası", 100, PortionType.g, 82, 35));
            foods.Add(new Food("Domates Sosu", 100, PortionType.g, 24, 35));
            foods.Add(new Food("Ekşi Krema", 100, PortionType.g, 217, 35));
            foods.Add(new Food("Ekşi Krema Sosu", 100, PortionType.g, 60, 35));
            foods.Add(new Food("Fransız Salata Sosu", 100, PortionType.g, 60, 35));
            foods.Add(new Food("Gravy", 100, PortionType.g, 53, 35));
            foods.Add(new Food("Hamburger Sosu", 100, PortionType.g, 383, 35));
            foods.Add(new Food("Hardal", 100, PortionType.g, 60, 35));
            foods.Add(new Food("Hardal Sosu", 100, PortionType.g, 645, 35));
            foods.Add(new Food("Harissa", 100, PortionType.g, 52, 35));
            foods.Add(new Food("Hollandez Sosu", 100, PortionType.g, 535, 35));
            foods.Add(new Food("İtalyan Salata Sosu", 100, PortionType.g, 293, 35));
            foods.Add(new Food("Ketçap", 100, PortionType.g, 100, 35));
            foods.Add(new Food("Krem Sos", 100, PortionType.g, 180, 35));
            foods.Add(new Food("Köri Sos", 100, PortionType.g, 26, 35));
            foods.Add(new Food("Körili Ketçap", 100, PortionType.g, 124, 35));
            foods.Add(new Food("Mayonez", 100, PortionType.g, 692, 35));
            foods.Add(new Food("Nar Ekşisi", 100, PortionType.g, 319, 35));
            foods.Add(new Food("Pesto", 100, PortionType.g, 458, 35));
            foods.Add(new Food("Portakal Sosu", 100, PortionType.g, 179, 35));
            foods.Add(new Food("Ranch Salata Sosu", 100, PortionType.g, 510, 35));
            foods.Add(new Food("Remoulade Sos", 100, PortionType.g, 635, 35));
            foods.Add(new Food("Salata Sosu", 100, PortionType.g, 449, 35));
            foods.Add(new Food("Sambal Oelek (Acı Sos)", 100, PortionType.g, 21, 35));
            foods.Add(new Food("Sezar Sos", 100, PortionType.g, 429, 35));
            foods.Add(new Food("Soya Sosu", 100, PortionType.g, 67, 35));
            foods.Add(new Food("Susam Ezmesi", 100, PortionType.g, 595, 35));
            foods.Add(new Food("Tabasco", 100, PortionType.g, 70, 35));
            foods.Add(new Food("Tatlı Ekşi Sos", 100, PortionType.g, 179, 35));
            foods.Add(new Food("Teriyaki Sos", 100, PortionType.g, 89, 35));
            foods.Add(new Food("Vinaigrette Salata Sosu", 100, PortionType.g, 120, 35));
            foods.Add(new Food("Wasabi", 100, PortionType.g, 158, 35));
            foods.Add(new Food("Workester Sosu", 100, PortionType.g, 78, 35));
            foods.Add(new Food("Yaban Turpu Sosu", 100, PortionType.g, 48, 35));
            foods.Add(new Food("Yoğurtlu Salata Sosu", 100, PortionType.g, 45, 35));
            foods.Add(new Food("Yunan Salata Sosu", 100, PortionType.g, 467, 35));

            //SÖĞÜŞ ET VE ŞARKÜTERİ
            foods.Add(new Food("Bolonya Sosisi", 100, PortionType.g, 247, 36));
            foods.Add(new Food("Capocollo", 100, PortionType.g, 110, 36));
            foods.Add(new Food("Chorizo (İspanyol Salamı)", 100, PortionType.g, 455, 36));
            foods.Add(new Food("Ciğer Salamı", 100, PortionType.g, 326, 36));
            foods.Add(new Food("Dil", 100, PortionType.g, 284, 36));
            foods.Add(new Food("Domuz Rosto", 100, PortionType.g, 247, 36));
            foods.Add(new Food("Domuz Sosisi", 100, PortionType.g, 164, 36));
            foods.Add(new Food("Füme Hindi Göğüs", 100, PortionType.g, 104, 36));
            foods.Add(new Food("Füme Jambon", 100, PortionType.g, 107, 36));
            foods.Add(new Food("Fırında Jambon", 100, PortionType.g, 343, 36));
            foods.Add(new Food("Fırınlanmış Hindi Göğüs", 100, PortionType.g, 104, 36));
            foods.Add(new Food("Haşlanmış Jambon", 100, PortionType.g, 126, 36));
            foods.Add(new Food("Hindi Göğsü", 100, PortionType.g, 104, 36));
            foods.Add(new Food("Hindi Jambon", 100, PortionType.g, 126, 36));
            foods.Add(new Food("Hindi Salamı", 100, PortionType.g, 152, 36));
            foods.Add(new Food("İtalyan Pastırması", 100, PortionType.g, 178, 36));
            foods.Add(new Food("Jambon", 100, PortionType.g, 145, 36));
            foods.Add(new Food("Kas (Brawn)", 100, PortionType.g, 157, 36));
            foods.Add(new Food("Konserve Sığır", 100, PortionType.g, 251, 36));
            foods.Add(new Food("Parma Jambonu", 100, PortionType.g, 345, 36));
            foods.Add(new Food("Pastırma", 100, PortionType.g, 133, 36));
            foods.Add(new Food("Prosciutto (İtalyan Salamı)", 100, PortionType.g, 195, 36));
            foods.Add(new Food("Rozbif", 100, PortionType.g, 267, 36));
            foods.Add(new Food("Salam", 100, PortionType.g, 336, 36));
            foods.Add(new Food("Serrano Jambon", 100, PortionType.g, 300, 36));
            foods.Add(new Food("Sığır Salamı", 100, PortionType.g, 375, 36));
            foods.Add(new Food("Tavuk Göğsü Fileto", 100, PortionType.g, 79, 36));
            foods.Add(new Food("Yaz Sosisi", 100, PortionType.g, 298, 36));

            //SÜT VE SÜT ÜRÜNLERİ
            foods.Add(new Food("Ayran", 100, PortionType.g, 34, 37));
            foods.Add(new Food("Az Yağlı Süt", 100, PortionType.g, 35, 37));
            foods.Add(new Food("Badem Sütü", 100, PortionType.g, 17, 37));
            foods.Add(new Food("Cacık", 100, PortionType.g, 117, 37));
            foods.Add(new Food("Ekşi Krema", 100, PortionType.g, 181, 37));
            foods.Add(new Food("Fraiche Kreması", 100, PortionType.g, 393, 37));
            foods.Add(new Food("Hindistan Cevizi Sütü", 100, PortionType.g, 230, 37));
            foods.Add(new Food("İrmikli Puding", 100, PortionType.g, 67, 37));
            foods.Add(new Food("Kahve Kreması", 100, PortionType.g, 195, 37));
            foods.Add(new Food("Kefir", 100, PortionType.g, 55, 37));
            foods.Add(new Food("Kesilmiş Süt", 100, PortionType.g, 98, 37));
            foods.Add(new Food("Keçi Sütü", 100, PortionType.g, 69, 37));
            foods.Add(new Food("Krema", 100, PortionType.g, 242, 37));
            foods.Add(new Food("Kremşanti", 100, PortionType.g, 257, 37));
            foods.Add(new Food("Laktozsuz Süt", 100, PortionType.g, 52, 37));
            foods.Add(new Food("Lassi", 100, PortionType.g, 75, 37));
            foods.Add(new Food("Pirinç Sütü", 100, PortionType.g, 49, 37));
            foods.Add(new Food("Soya Sütü", 100, PortionType.g, 45, 37));
            foods.Add(new Food("Süt", 100, PortionType.g, 61, 37));
            foods.Add(new Food("Süt Tozu", 100, PortionType.g, 496, 37));
            foods.Add(new Food("Sütlaç", 100, PortionType.g, 118, 37));
            foods.Add(new Food("Süzme Peynir", 100, PortionType.g, 98, 37));
            foods.Add(new Food("Sıcak Çikolata", 100, PortionType.g, 89, 37));
            foods.Add(new Food("Tam Yağlı Süt", 100, PortionType.g, 61, 37));
            foods.Add(new Food("Tatlandırılmış Yoğun Süt", 100, PortionType.g, 321, 37));
            foods.Add(new Food("Yarım Yağlı Süt", 100, PortionType.g, 50, 37));
            foods.Add(new Food("Yayık Ayranı", 100, PortionType.g, 62, 37));
            foods.Add(new Food("Yoğunlaştırılmış Süt", 100, PortionType.g, 321, 37));
            foods.Add(new Food("Yoğurt", 100, PortionType.g, 61, 37));
            foods.Add(new Food("Çikolata Mousse", 100, PortionType.g, 225, 37));

            //ŞARAP
            foods.Add(new Food("Beyaz Şarap", 100, PortionType.ml, 82, 38));
            foods.Add(new Food("Boğazkere", 100, PortionType.ml, 75, 38));
            foods.Add(new Food("Cabernet Sauvignon", 100, PortionType.ml, 77, 38));
            foods.Add(new Food("Cava", 100, PortionType.ml, 76, 38));
            foods.Add(new Food("Chardonnay", 100, PortionType.ml, 85, 38));
            foods.Add(new Food("Chenin Blanc", 100, PortionType.ml, 80, 38));
            foods.Add(new Food("Erik Şarabı", 100, PortionType.ml, 163, 38));
            foods.Add(new Food("Gamay", 100, PortionType.ml, 78, 38));
            foods.Add(new Food("Kalecik Karası", 100, PortionType.ml, 100, 38));
            foods.Add(new Food("Köpüklü Şarap", 100, PortionType.ml, 190, 38));
            foods.Add(new Food("Kırmızı Şarap", 100, PortionType.ml, 85, 38));
            foods.Add(new Food("Malbec", 100, PortionType.ml, 82, 38));
            foods.Add(new Food("Marsala Şarabı", 100, PortionType.ml, 100, 38));
            foods.Add(new Food("Merlot", 100, PortionType.ml, 83, 38));
            foods.Add(new Food("Pinot Gris", 100, PortionType.ml, 83, 38));
            foods.Add(new Food("Pinot Noir", 100, PortionType.ml, 75, 38));
            foods.Add(new Food("Porto Şarabı", 100, PortionType.ml, 160, 38));
            foods.Add(new Food("Prosecco", 100, PortionType.ml, 71, 38));
            foods.Add(new Food("Riesling", 100, PortionType.ml, 80, 38));
            foods.Add(new Food("Roze Şarap", 100, PortionType.ml, 71, 38));
            foods.Add(new Food("Sangria", 100, PortionType.ml, 132, 38));
            foods.Add(new Food("Sauvignon Blanc", 100, PortionType.ml, 81, 38));
            foods.Add(new Food("Sek Kırmızı Şarap", 100, PortionType.ml, 85, 38));
            foods.Add(new Food("Sherry", 100, PortionType.ml, 116, 38));
            foods.Add(new Food("Shiraz", 100, PortionType.ml, 71, 38));
            foods.Add(new Food("Sıcak Şarap", 100, PortionType.ml, 196, 38));
            foods.Add(new Food("Tatlı Beyaz Şarap", 100, PortionType.ml, 82, 38));
            foods.Add(new Food("Tatlı Kırmızı Şarap", 100, PortionType.ml, 81, 38));
            foods.Add(new Food("Tatlı Şarap", 100, PortionType.ml, 83, 38));
            foods.Add(new Food("Vermouth", 100, PortionType.ml, 108, 38));
            foods.Add(new Food("Zinfandel", 100, PortionType.ml, 88, 38));
            foods.Add(new Food("Çal Karası", 100, PortionType.ml, 72, 38));
            foods.Add(new Food("Öküzgözü", 100, PortionType.ml, 74, 38));
            foods.Add(new Food("Şampanya", 100, PortionType.ml, 76, 38));
            foods.Add(new Food("Şarap", 100, PortionType.ml, 83, 38));

            //ŞEKERLEME VE TATLILAR
            foods.Add(new Food("After Eight", 100, PortionType.g, 452, 39));
            foods.Add(new Food("Antepfıstıklı Çikolata", 100, PortionType.g, 567, 39));
            foods.Add(new Food("Badem Ezmesi", 100, PortionType.g, 411, 39));
            foods.Add(new Food("Baston Şeker", 100, PortionType.g, 423, 39));
            foods.Add(new Food("Beyaz Çikolata Bar", 100, PortionType.g, 540, 39));
            foods.Add(new Food("Biscolata Mood", 100, PortionType.g, 494, 39));
            foods.Add(new Food("Bitter Çikolata", 100, PortionType.g, 586, 39));
            foods.Add(new Food("Bonibon", 100, PortionType.g, 357, 39));
            foods.Add(new Food("Draje", 100, PortionType.g, 429, 39));
            foods.Add(new Food("Elma Şekeri", 100, PortionType.g, 152, 39));
            foods.Add(new Food("Ferrero Rocher", 100, PortionType.g, 576, 39));
            foods.Add(new Food("Fındıklı Gofret", 100, PortionType.g, 465, 39));
            foods.Add(new Food("Fıstıklı Bar", 100, PortionType.g, 533, 39));
            foods.Add(new Food("Fıstıklı Tereyağlı Kurabiye", 100, PortionType.g, 475, 39));
            foods.Add(new Food("Fıstıklı Şekerleme", 100, PortionType.g, 183, 39));
            foods.Add(new Food("Granola Bar", 100, PortionType.g, 452, 39));
            foods.Add(new Food("Gummi Ayıcık", 100, PortionType.g, 316, 39));
            foods.Add(new Food("Hanuta", 100, PortionType.g, 541, 39));
            foods.Add(new Food("Hayvan Krakerleri", 100, PortionType.g, 446, 39));
            foods.Add(new Food("İrmik", 100, PortionType.g, 340, 39));
            foods.Add(new Food("Jelibon", 100, PortionType.g, 354, 39));
            foods.Add(new Food("Kabak Çekirdekleri", 100, PortionType.g, 560, 39));
            foods.Add(new Food("Kavrulmuş Badem", 100, PortionType.g, 452, 39));
            foods.Add(new Food("Kit Kat", 100, PortionType.g, 521, 39));
            foods.Add(new Food("Kurabiye", 100, PortionType.g, 488, 39));
            foods.Add(new Food("Lindt", 100, PortionType.g, 548, 39));
            foods.Add(new Food("Lolipop", 100, PortionType.g, 392, 39));
            foods.Add(new Food("M&M", 100, PortionType.g, 479, 39));
            foods.Add(new Food("Mars Bar", 100, PortionType.g, 448, 39));
            foods.Add(new Food("Marşmelov", 100, PortionType.g, 318, 39));
            foods.Add(new Food("Meyan Kökü Şekeri", 100, PortionType.g, 375, 39));
            foods.Add(new Food("Milky Way", 100, PortionType.g, 449, 39));
            foods.Add(new Food("Naneli Çikolata Barı", 100, PortionType.g, 500, 39));
            foods.Add(new Food("Pamuk Şeker", 100, PortionType.g, 643, 39));
            foods.Add(new Food("Patlamış Mısır", 100, PortionType.g, 582, 39));
            foods.Add(new Food("Pez", 100, PortionType.g, 427, 39));
            foods.Add(new Food("Pop Rocks", 100, PortionType.g, 358, 39));
            foods.Add(new Food("Rolo", 100, PortionType.g, 474, 39));
            foods.Add(new Food("Skittles", 100, PortionType.g, 405, 39));
            foods.Add(new Food("Snickers", 100, PortionType.g, 484, 39));
            foods.Add(new Food("Spritz Kurabiyeler", 100, PortionType.g, 500, 39));
            foods.Add(new Food("Sütlaç", 100, PortionType.g, 134, 39));
            foods.Add(new Food("Toblerone", 100, PortionType.g, 525, 39));
            foods.Add(new Food("Trifle", 100, PortionType.g, 186, 39));
            foods.Add(new Food("Twix", 100, PortionType.g, 495, 39));
            foods.Add(new Food("Waffle", 100, PortionType.g, 272, 39));
            foods.Add(new Food("Yumurtalı Ekmek", 100, PortionType.g, 196, 39));
            foods.Add(new Food("Çikolata", 100, PortionType.g, 529, 39));
            foods.Add(new Food("Çikolata Bar", 100, PortionType.g, 533, 39));
            foods.Add(new Food("Çikolata Cipsi", 100, PortionType.g, 493, 39));
            foods.Add(new Food("Çikolatalı Bonbon", 100, PortionType.g, 498, 39));
            foods.Add(new Food("Şans Kurabiyeleri", 100, PortionType.g, 214, 39));

            //TAHILLAR VE TAHILLI ÜRÜNLER
            foods.Add(new Food("Akdarı", 100, PortionType.g, 378, 40));
            foods.Add(new Food("Akdarı Lapası", 100, PortionType.g, 46, 40));
            foods.Add(new Food("Akdarı Unu", 100, PortionType.g, 372, 40));
            foods.Add(new Food("Amarant", 100, PortionType.g, 371, 40));
            foods.Add(new Food("Arpa", 100, PortionType.g, 354, 40));
            foods.Add(new Food("Ayçiçeği Tohumu", 100, PortionType.g, 584, 40));
            foods.Add(new Food("Buğday Filizi (Ruşeym)", 100, PortionType.g, 382, 40));
            foods.Add(new Food("Buğday Gluteni", 100, PortionType.g, 325, 40));
            foods.Add(new Food("Buğday İrmiği", 100, PortionType.g, 360, 40));
            foods.Add(new Food("Buğday Kepeği", 100, PortionType.g, 216, 40));
            foods.Add(new Food("Buğday Nişastası", 100, PortionType.g, 351, 40));
            foods.Add(new Food("Durum Buğdayı İrmik", 100, PortionType.g, 397, 40));
            foods.Add(new Food("Esmer Pirinç", 100, PortionType.g, 388, 40));
            foods.Add(new Food("Grissini", 100, PortionType.g, 408, 40));
            foods.Add(new Food("Hintirmiği", 100, PortionType.g, 354, 40));
            foods.Add(new Food("İnce Mısır Unu", 100, PortionType.g, 351, 40));
            foods.Add(new Food("İri Taneli Mısır Unu", 100, PortionType.g, 362, 40));
            foods.Add(new Food("Kamut", 100, PortionType.g, 337, 40));
            foods.Add(new Food("Kara Buğday", 100, PortionType.g, 343, 40));
            foods.Add(new Food("Karides Krakeri", 100, PortionType.g, 527, 40));
            foods.Add(new Food("Kavuzlu Buğday", 100, PortionType.g, 338, 40));
            foods.Add(new Food("Kavuzlu İrmik", 100, PortionType.g, 360, 40));
            foods.Add(new Food("Kavuzlu Kepek", 100, PortionType.g, 177, 40));
            foods.Add(new Food("Keten Tohumu", 100, PortionType.g, 534, 40));
            foods.Add(new Food("Kinoa", 100, PortionType.g, 368, 40));
            foods.Add(new Food("Kraker", 100, PortionType.g, 502, 40));
            foods.Add(new Food("Kuskus", 100, PortionType.g, 376, 40));
            foods.Add(new Food("Mısır İrmiği", 100, PortionType.g, 366, 40));
            foods.Add(new Food("Mısır Nişastası", 100, PortionType.g, 381, 40));
            foods.Add(new Food("Mısır Waffle", 100, PortionType.g, 274, 40));
            foods.Add(new Food("Nohut Unu", 100, PortionType.g, 307, 40));
            foods.Add(new Food("Peksimet", 100, PortionType.g, 410, 40));
            foods.Add(new Food("Pirinç Unu", 100, PortionType.g, 358, 40));
            foods.Add(new Food("Tam Tahıllı Buğday", 100, PortionType.g, 339, 40));
            foods.Add(new Food("Tam Tahıllı Yulaf", 100, PortionType.g, 375, 40));
            foods.Add(new Food("Tortilla", 100, PortionType.g, 237, 40));
            foods.Add(new Food("Tortilla Cipsi", 100, PortionType.g, 499, 40));
            foods.Add(new Food("Un Kurabiyesi", 100, PortionType.g, 502, 40));
            foods.Add(new Food("Yulaf Kepeği", 100, PortionType.g, 246, 40));
            foods.Add(new Food("Çavdar Tohumu", 100, PortionType.g, 281, 40));
            foods.Add(new Food("Çubuk Pretzel (Çubuk Kraker)", 100, PortionType.g, 380, 40));
            foods.Add(new Food("Öğütülmüş Arpa", 100, PortionType.g, 352, 40));

            //TROPİK VE EGZOTİK MEYVELER
            foods.Add(new Food("Ananas", 100, PortionType.g, 50, 41));
            foods.Add(new Food("Asya Armudu", 100, PortionType.g, 42, 41));
            foods.Add(new Food("Avokado", 100, PortionType.g, 160, 41));
            foods.Add(new Food("Barbados Kirazı", 100, PortionType.g, 32, 41));
            foods.Add(new Food("Che Meyvesi", 100, PortionType.g, 92, 41));
            foods.Add(new Food("Durian", 100, PortionType.g, 147, 41));
            foods.Add(new Food("Ekmek Ağacı", 100, PortionType.g, 103, 41));
            foods.Add(new Food("Feijoa", 100, PortionType.g, 55, 41));
            foods.Add(new Food("Galia Kavunu", 100, PortionType.g, 23, 41));
            foods.Add(new Food("Greyfurt", 100, PortionType.g, 42, 41));
            foods.Add(new Food("Guava", 100, PortionType.g, 68, 41));
            foods.Add(new Food("Hint Dutu", 100, PortionType.g, 53, 41));
            foods.Add(new Food("Hint Hurması", 100, PortionType.g, 239, 41));
            foods.Add(new Food("Hint İnciri", 100, PortionType.g, 41, 41));
            foods.Add(new Food("Hint Muzu", 100, PortionType.g, 122, 41));
            foods.Add(new Food("Kantalup Kavunu", 100, PortionType.g, 34, 41));
            foods.Add(new Food("Karpuz", 100, PortionType.g, 30, 41));
            foods.Add(new Food("Kivi", 100, PortionType.g, 61, 41));
            foods.Add(new Food("Kumkat", 100, PortionType.g, 71, 41));
            foods.Add(new Food("Kış Kavunu", 100, PortionType.g, 28, 41));
            foods.Add(new Food("Liçi", 100, PortionType.g, 66, 41));
            foods.Add(new Food("Mandarin Portakal", 100, PortionType.g, 53, 41));
            foods.Add(new Food("Mango", 100, PortionType.g, 60, 41));
            foods.Add(new Food("Mangostan", 100, PortionType.g, 73, 41));
            foods.Add(new Food("Marakuya / Çarkıfelek", 100, PortionType.g, 97, 41));
            foods.Add(new Food("Maraskino Kirazı", 100, PortionType.g, 165, 41));
            foods.Add(new Food("Misk Kavunu", 100, PortionType.g, 34, 41));
            foods.Add(new Food("Muz", 100, PortionType.g, 89, 41));
            foods.Add(new Food("Nar", 100, PortionType.g, 83, 41));
            foods.Add(new Food("Pembe Greyfurt", 100, PortionType.g, 42, 41));
            foods.Add(new Food("Pitaya", 100, PortionType.g, 60, 41));
            foods.Add(new Food("Pomelo", 100, PortionType.g, 38, 41));
            foods.Add(new Food("Rambutan", 100, PortionType.g, 82, 41));
            foods.Add(new Food("Sursop", 100, PortionType.g, 75, 41));
            foods.Add(new Food("Tayland Meyvesi", 100, PortionType.g, 95, 41));
            foods.Add(new Food("Yıldız Meyvesi", 100, PortionType.g, 31, 41));

            //YEMEKLER VE ÖĞÜNLER
            foods.Add(new Food("Bezelye Çorbası", 100, PortionType.g, 75, 42));
            foods.Add(new Food("Bulgur Pilavı", 100, PortionType.g, 215, 42));
            foods.Add(new Food("Burrito (Meksika Dürümü)", 100, PortionType.g, 163, 42));
            foods.Add(new Food("Chili con Carne (Kıymalı Fasulye)", 100, PortionType.g, 105, 42));
            foods.Add(new Food("Dal Makhani (Hint Bezelye Yemeği", 100, PortionType.g, 330, 42));
            foods.Add(new Food("Domuz Pirzola", 100, PortionType.g, 225, 42));
            foods.Add(new Food("Enchilada", 100, PortionType.g, 168, 42));
            foods.Add(new Food("Esmer Pirinç", 100, PortionType.g, 362, 42));
            foods.Add(new Food("Fajita", 100, PortionType.g, 117, 42));
            foods.Add(new Food("Fish and Chips", 100, PortionType.g, 195, 42));
            foods.Add(new Food("Fırında Kurufasulye", 100, PortionType.g, 94, 42));
            foods.Add(new Food("Fırında Tavuk", 100, PortionType.g, 164, 42));
            foods.Add(new Food("Humus", 100, PortionType.g, 177, 42));
            foods.Add(new Food("Hünkar Beğendi", 100, PortionType.g, 174, 42));
            foods.Add(new Food("Karnıyarık", 100, PortionType.g, 134, 42));
            foods.Add(new Food("Kebap", 100, PortionType.g, 215, 42));
            foods.Add(new Food("Kuzu Tandır", 100, PortionType.g, 150, 42));
            foods.Add(new Food("Kıymalı Dolma", 100, PortionType.g, 114, 42));
            foods.Add(new Food("Kıymalı/Etli Pide", 100, PortionType.g, 297, 42));
            foods.Add(new Food("Kızarmış Pirinç", 100, PortionType.g, 186, 42));
            foods.Add(new Food("Lazanya", 100, PortionType.g, 132, 42));
            foods.Add(new Food("Makarna ve Peynir", 100, PortionType.g, 370, 42));
            foods.Add(new Food("Paella", 100, PortionType.g, 156, 42));
            foods.Add(new Food("Patates Püresi", 100, PortionType.g, 83, 42));
            foods.Add(new Food("Patates Salatası", 100, PortionType.g, 143, 42));
            foods.Add(new Food("Pekin Ördeği", 100, PortionType.g, 225, 42));
            foods.Add(new Food("Peynirli Pide", 100, PortionType.g, 275, 42));
            foods.Add(new Food("Pilav", 100, PortionType.g, 352, 42));
            foods.Add(new Food("Pizza", 100, PortionType.g, 267, 42));
            foods.Add(new Food("Ravioli", 100, PortionType.g, 203, 42));
            foods.Add(new Food("Rozbif", 100, PortionType.g, 111, 42));
            foods.Add(new Food("Rulo Köfte", 100, PortionType.g, 254, 42));
            foods.Add(new Food("Spagetti Bolonez", 100, PortionType.g, 132, 42));
            foods.Add(new Food("Sığır Eti Güveci", 100, PortionType.g, 95, 42));
            foods.Add(new Food("Taco", 100, PortionType.g, 217, 42));
            foods.Add(new Food("Tandır Ekmeği", 100, PortionType.g, 310, 42));
            foods.Add(new Food("Tavuklu Sezar Salata", 100, PortionType.g, 127, 42));
            foods.Add(new Food("Yaprak Sarması", 100, PortionType.g, 141, 42));
            foods.Add(new Food("Zeytinyağlı Dolma", 100, PortionType.g, 173, 42));
            foods.Add(new Food("Zeytinyağlı Enginar", 100, PortionType.g, 166, 42));
            foods.Add(new Food("Zeytinyağlı Kereviz", 100, PortionType.g, 66, 42));
            foods.Add(new Food("Zeytinyağlı Taze Fasulye", 100, PortionType.g, 56, 42));
            foods.Add(new Food("Çin Böreği", 100, PortionType.g, 250, 42));

            //YOĞURTLAR
            foods.Add(new Food("Activia", 100, PortionType.g, 74, 43));
            foods.Add(new Food("Ayran", 100, PortionType.g, 42, 43));
            foods.Add(new Food("Az Yağlı Yoğurt", 100, PortionType.g, 56, 43));
            foods.Add(new Food("Diyet Yoğurt", 100, PortionType.g, 54, 43));
            foods.Add(new Food("Düşük Yağlı Yoğurt", 100, PortionType.g, 63, 43));
            foods.Add(new Food("Kayısılı Activia", 100, PortionType.g, 92, 43));
            foods.Add(new Food("Keten Tohumlu Yoğurt", 100, PortionType.g, 62, 43));
            foods.Add(new Food("Kirazlı Yoğurt", 100, PortionType.g, 97, 43));
            foods.Add(new Food("Limonlu Activia", 100, PortionType.g, 100, 43));
            foods.Add(new Food("Meyveli Yoğurt", 100, PortionType.g, 97, 43));
            foods.Add(new Food("Müsli Yoğurt", 100, PortionType.g, 109, 43));
            foods.Add(new Food("Organik Yoğurt", 100, PortionType.g, 75, 43));
            foods.Add(new Food("Probiyotik Yoğurt", 100, PortionType.g, 80, 43));
            foods.Add(new Food("Süzme Yoğurt", 100, PortionType.g, 90, 43));
            foods.Add(new Food("Tava Yoğurdu", 100, PortionType.g, 93, 43));
            foods.Add(new Food("Vanilyalı Yoğurt", 100, PortionType.g, 101, 43));
            foods.Add(new Food("Yabanmersinli Yoğurt", 100, PortionType.g, 105, 43));
            foods.Add(new Food("Yağsız Yoğurt", 100, PortionType.g, 50, 43));
            foods.Add(new Food("Yoğurt", 100, PortionType.g, 61, 43));
            foods.Add(new Food("Yunan Yoğurdu", 100, PortionType.g, 53, 43));
            foods.Add(new Food("Çikolatalı Yoğurt", 100, PortionType.g, 128, 43));
            foods.Add(new Food("Çilekli Activia", 100, PortionType.g, 97, 43));
            foods.Add(new Food("Çilekli Yoğurt", 100, PortionType.g, 100, 43));
            foods.Add(new Food("Şeftalili Yoğurt", 100, PortionType.g, 97, 43));
            foods.Add(new Food("Şekerli Yoğurt", 100, PortionType.g, 118, 43));

            //YULAF EZMESİ, MÜSLİ VE TAHIL GEVREKLERİ
            foods.Add(new Food("Ballı Müsli", 100, PortionType.g, 423, 44));
            foods.Add(new Food("Buğday Ezmesi", 100, PortionType.g, 364, 44));
            foods.Add(new Food("Buğday Patlakları", 100, PortionType.g, 367, 44));
            foods.Add(new Food("Cheerios", 100, PortionType.g, 347, 44));
            foods.Add(new Food("Cheerios Çok Tahıllı", 100, PortionType.g, 380, 44));
            foods.Add(new Food("Chocos", 100, PortionType.g, 380, 44));
            foods.Add(new Food("Coco Pops", 100, PortionType.g, 376, 44));
            foods.Add(new Food("Cocoa Krispies", 100, PortionType.g, 386, 44));
            foods.Add(new Food("Cocoa Puffs", 100, PortionType.g, 400, 44));
            foods.Add(new Food("Cookie Crisp", 100, PortionType.g, 400, 44));
            foods.Add(new Food("Corn Flakes (Mısır Gevreği)", 100, PortionType.g, 357, 44));
            foods.Add(new Food("Corn Pops", 100, PortionType.g, 377, 44));
            foods.Add(new Food("Crunchy Nut", 100, PortionType.g, 600, 44));
            foods.Add(new Food("Dr. Oetker Multi Meyveli Müsli", 100, PortionType.g, 346, 44));
            foods.Add(new Food("Dr. Oetker Çikolatalı Müsli", 100, PortionType.g, 415, 44));
            foods.Add(new Food("Froot Loops", 100, PortionType.g, 379, 44));
            foods.Add(new Food("Frosted Mini-Wheats", 100, PortionType.g, 353, 44));
            foods.Add(new Food("Frosties", 100, PortionType.g, 367, 44));
            foods.Add(new Food("Hahne Bircher Musli", 100, PortionType.g, 351, 44));
            foods.Add(new Food("Honey Smacks", 100, PortionType.g, 370, 44));
            foods.Add(new Food("Kellogs Corn Flakes", 100, PortionType.g, 357, 44));
            foods.Add(new Food("Kellogs Extra Granola", 100, PortionType.g, 378, 44));
            foods.Add(new Food("Kuru Meyve ve Yemişli Müsli", 100, PortionType.g, 357, 44));
            foods.Add(new Food("Mini Wheats", 100, PortionType.g, 353, 44));
            foods.Add(new Food("Müsli", 100, PortionType.g, 336, 44));
            foods.Add(new Food("Nesquick Due Chocolate Mısır Gevreği", 100, PortionType.g, 392, 44));
            foods.Add(new Food("Nestle Gold Flakes", 100, PortionType.g, 383, 44));
            foods.Add(new Food("Nestle Tropikal Meyveli Tam Tahıllı Müsli", 100, PortionType.g, 381, 44));
            foods.Add(new Food("Organik Yulaf Ezmesi", 100, PortionType.g, 386, 44));
            foods.Add(new Food("Pirinç Kıtırları", 100, PortionType.g, 394, 44));
            foods.Add(new Food("Pirinç Patlakları", 100, PortionType.g, 383, 44));
            foods.Add(new Food("Prebiyotik Müsli", 100, PortionType.g, 355, 44));
            foods.Add(new Food("Shreddies", 100, PortionType.g, 351, 44));
            foods.Add(new Food("Special K", 100, PortionType.g, 377, 44));
            foods.Add(new Food("Special K Kırmızı Meyveler", 100, PortionType.g, 345, 44));
            foods.Add(new Food("Special K Protein Plus", 100, PortionType.g, 375, 44));
            foods.Add(new Food("Special K Çikolatalı", 100, PortionType.g, 388, 44));
            foods.Add(new Food("Weetabix", 100, PortionType.g, 358, 44));
            foods.Add(new Food("Yulaf Ezmesi", 100, PortionType.g, 375, 44));

            context.Foods.AddRange(foods);
            context.SaveChanges();

            List<Activity> activities = new List<Activity>();
            activities.Add(new Activity("Archery", 4.3));
            activities.Add(new Activity("Athletic Training, general", 6));
            activities.Add(new Activity("BASE Jumping", 3.5));
            activities.Add(new Activity("BMX Biking", 8.5));
            activities.Add(new Activity("Badminton, competitive", 7));
            activities.Add(new Activity("Badminton, general", 5.5));
            activities.Add(new Activity("Baseball", 2.5));
            activities.Add(new Activity("Basketball, competitive", 8));
            activities.Add(new Activity("Basketball, general", 6));
            activities.Add(new Activity("Beach Volleyball", 8));
            activities.Add(new Activity("Biathlon", 10));
            activities.Add(new Activity("Billiards", 2.5));
            activities.Add(new Activity("Bowling", 3.8));
            activities.Add(new Activity("Boxing, competitive", 12.8));
            activities.Add(new Activity("Boxing, punching bag", 5.5));
            activities.Add(new Activity("Boxing, sparring", 7.8));
            activities.Add(new Activity("Broomball", 7));
            activities.Add(new Activity("Bungee Jumping", 3.5));
            activities.Add(new Activity("Canoeing, competitive", 12));
            activities.Add(new Activity("Canoeing, general", 4));
            activities.Add(new Activity("Canoeing, wildwater", 3.3));
            activities.Add(new Activity("Car Racing", 8.5));
            activities.Add(new Activity("Cheerleading", 6));
            activities.Add(new Activity("Chopping Wood", 4.5));
            activities.Add(new Activity("Circuit Training, cardiovascular", 4.3));
            activities.Add(new Activity("Circuit Training, strength", 8));
            activities.Add(new Activity("Cleaning, Household Tasks ", 3.3));
            activities.Add(new Activity("Climbing, competitive", 8));
            activities.Add(new Activity("Climbing, general", 5.8));
            activities.Add(new Activity("Cricket", 4.8));
            activities.Add(new Activity("Croquet", 3.3));
            activities.Add(new Activity("Curling", 4));
            activities.Add(new Activity("Cycling, commute", 5.8));
            activities.Add(new Activity("Cycling, fast", 7.8));
            activities.Add(new Activity("Cycling, general", 6.4));
            activities.Add(new Activity("Cycling, leisurely", 4));
            activities.Add(new Activity("Dancing: Aerobic", 7.3));
            activities.Add(new Activity("Dancing: Ballet, Modern, Jazz", 5));
            activities.Add(new Activity("Dancing: Caribbean", 3.5));
            activities.Add(new Activity("Dancing: Cultural Celebrations", 4.5));
            activities.Add(new Activity("Dancing: Cumbia", 6.5));
            activities.Add(new Activity("Dancing: Disco, Folk, Polka", 7.8));
            activities.Add(new Activity("Dancing: Merengue", 7.3));
            activities.Add(new Activity("Dancing: Salsa, Flamenco, Swing", 4.5));
            activities.Add(new Activity("Dancing: Tango, Mambo, Cha-Cha", 3));
            activities.Add(new Activity("Dancing: Waltz, Foxtrot, Tango", 3));
            activities.Add(new Activity("Darts", 4));
            activities.Add(new Activity("Diving", 7));
            activities.Add(new Activity("Dog Sledding", 5));
            activities.Add(new Activity("Dog Walking", 3.5));
            activities.Add(new Activity("Elliptical, Crosstrainer", 5));
            activities.Add(new Activity("Felling Trees", 5.3));
            activities.Add(new Activity("Fencing", 6));
            activities.Add(new Activity("Field Hockey", 7.8));
            activities.Add(new Activity("Fishing", 1.8));
            activities.Add(new Activity("Football, competitive", 8));
            activities.Add(new Activity("Football, general", 4));
            activities.Add(new Activity("Frisbee", 3));
            activities.Add(new Activity("Golf", 4.8));
            activities.Add(new Activity("Gym Exercise", 5.5));
            activities.Add(new Activity("Gymnastics", 3.8));
            activities.Add(new Activity("Hacky Sack", 4));
            activities.Add(new Activity("Handball, competitive", 10));
            activities.Add(new Activity("Handball, general", 8));
            activities.Add(new Activity("Hang Gliding", 3.5));
            activities.Add(new Activity("High Ropes Course", 4));
            activities.Add(new Activity("Hiking, advanced", 6.3));
            activities.Add(new Activity("Hiking, general", 4.3));
            activities.Add(new Activity("Hockey", 7.8));
            activities.Add(new Activity("Home Exercise", 3.8));
            activities.Add(new Activity("Home Repair", 3.5));
            activities.Add(new Activity("Horse Riding, gallop", 7.3));
            activities.Add(new Activity("Horse Riding, general", 5.5));
            activities.Add(new Activity("Horse Riding, jumping", 9));
            activities.Add(new Activity("Horse Riding, trot", 5.8));
            activities.Add(new Activity("Hunting", 5));
            activities.Add(new Activity("Ice Dancing", 12));
            activities.Add(new Activity("Ice Hockey, competitive", 10));
            activities.Add(new Activity("Ice Hockey, general", 8));
            activities.Add(new Activity("Ice Skating, competitive", 9));
            activities.Add(new Activity("Ice Skating, general", 5.5));
            activities.Add(new Activity("Indoor Cycling, Spinning (100 watts)", 6.8));
            activities.Add(new Activity("Indoor Cycling, Spinning (150 watts)", 8.8));
            activities.Add(new Activity("Indoor Cycling, Spinning (200 watts)", 11));
            activities.Add(new Activity("Indoor Cycling, Spinning (50 watts)", 3.5));

            context.Activities.AddRange(activities);
            context.SaveChanges();

            //üretilen kişilerin hep aynı değerlere sahip olmasını sağlıyor
            Randomizer.Seed = new Random(1337);

            //bogus nuget paketiyle rastgele kişi üretiyor
            Faker<User> testUsers = new Faker<User>(locale: "tr")

                //Use an enum outside scope.
                .RuleFor(u => u.Gender, f => f.PickRandom<Gender>())

                //Basic rules using built-in generators
                .RuleFor(u => u.FirstName, (f, u) => f.Name.FirstName())
                .RuleFor(u => u.LastName, (f, u) => f.Name.LastName())
                .RuleFor(u => u.Email, (f, u) => f.Internet.Email(u.FirstName, u.LastName))
                .RuleFor(u => u.Height, f => f.Random.Number(150, 220))
                .RuleFor(u => u.Password, f => f.Internet.Password())
                .RuleFor(u => u.BirthDate, f => f.Person.DateOfBirth)
                .RuleFor(u => u.Country, f => "Türkiye")
                .RuleFor(u => u.City, f => f.Address.City());

            //ürettiği rastgele kişinin gerekli değerlerini admin olarak düzeltiyor
            User user = testUsers.Generate();
            user.FirstName = "Admin";
            user.LastName = "Admin";
            user.Email = "admin@bilgeadam.com";
            user.Password = "admin";
            user.BirthDate = DateTime.Now.AddYears(-10);
            user.UserType = UserType.Admin;

            context.Users.Add(user);
            context.SaveChanges();

            testUsers = new Faker<User>(locale: "tr")
            //Use an enum outside scope.
            .RuleFor(u => u.Gender, f => f.PickRandom<Gender>())

            //Basic rules using built-in generators
            .RuleFor(u => u.FirstName, (f, u) => f.Name.FirstName())
            .RuleFor(u => u.LastName, (f, u) => f.Name.LastName())
            .RuleFor(u => u.Email, (f, u) => f.Internet.Email(u.FirstName, u.LastName))
            .RuleFor(u => u.Height, f => f.Random.Number(150, 220))
            .RuleFor(u => u.Password, f => f.Internet.Password())
            .RuleFor(u => u.BirthDate, f => f.Person.DateOfBirth)
            .RuleFor(u => u.Country, f => "Türkiye")
            .RuleFor(u => u.City, f => f.Address.City())
            .RuleFor(u => u.UserType, f => UserType.User);

            List<User> users = new List<User>();
            users = testUsers.Generate(50);

            context.Users.AddRange(users);
            context.SaveChanges();

            //Activity activities = new Faker<Activity>()
            //    .RuleFor(a => a.ActivityName, f => f);

            int Ids = 2;
            Faker<Kilo> kilo = new Faker<Kilo>()
                .RuleFor(k => k.Weight, f => f.Random.Number(30, 300))
                .RuleFor(k => k.UserID, f => Ids++)
                .RuleFor(k => k.CreationDate, f => f.Date.Past(1, DateTime.Now));

            List<Kilo> kilos = new List<Kilo>();
            kilos = kilo.Generate(50);

            context.Kilos.AddRange(kilos);
            context.SaveChanges();

            Faker<Kilo> kilo2;
            List<Kilo> kilos2 = new List<Kilo>();
            for (int Ids2 = 2; Ids2 <= 51; Ids2++)
            {
                DateTime tarih = context.Kilos.Where(x => x.UserID == Ids2).OrderByDescending(x => x.CreationDate).FirstOrDefault().CreationDate;
                DateTime tarih2 = tarih;
                int kalanGunler = (DateTime.Now - tarih).Days;
                for (int i = kalanGunler; i > 0; i--)
                {
                    Random r = new Random();
                    int rInt = r.Next(1, 3);
                    i -= rInt;
                    tarih2 = tarih2.AddDays(rInt);
                    if (tarih2 <= DateTime.Now)
                    {
                        kilo2 = new Faker<Kilo>()
                        .RuleFor(k => k.Weight, f =>
                        {
                            int gilo = context.Kilos.Where(x => x.UserID == Ids2).OrderByDescending(x => x.CreationDate).FirstOrDefault().Weight;
                            Random g = new Random();
                            return gilo = g.Next(gilo - 1, gilo + 2);
                        })
                        .RuleFor(k => k.UserID, f => Ids2)
                        .RuleFor(k => k.CreationDate, f => tarih2);
                        kilos2.Add(kilo2);
                    }
                }
            }

            context.Kilos.AddRange(kilos2);
            context.SaveChanges();


            Faker<UserAndActivity> userAndActivity;
            List<UserAndActivity> usersAndActivities = new List<UserAndActivity>();
            for (int Ids2 = 2; Ids2 <= 51; Ids2++)
            {
                List<DateTime> tarihlistesi = context.Kilos.Where(x => x.UserID == Ids2).Select(x => x.CreationDate).ToList();
                foreach (DateTime gun in tarihlistesi)
                {
                    Random r = new Random();
                    for (int i = r.Next(1, 4); i >= 0; i--)
                    {
                        userAndActivity = new Faker<UserAndActivity>()
                        .RuleFor(ua => ua.UserID, f => Ids2)
                        .RuleFor(ua => ua.ActivityID, f => {

                            var activity = usersAndActivities.Where(x => x.UserID == Ids2 && x.ActivityDate == gun).Select(x => x.ActivityID).ToList();
                            int activiteSayisi;
                            do
                            {
                                activiteSayisi = f.Random.Number(1, activities.Count);
                            } while (activity.Contains(activiteSayisi));

                            return activiteSayisi;

                        })
                        .RuleFor(ua => ua.ActivityDuration, f => f.Random.Number(300))
                        .RuleFor(ua => ua.ActivityDate, f => gun);

                        usersAndActivities.Add(userAndActivity);
                    }
                }
            }

            context.UsersAndActivities.AddRange(usersAndActivities);
            context.SaveChanges();


            Faker<Meal> meal;
            List<Meal> meals = new List<Meal>();
            for (int Ids2 = 2; Ids2 <= 51; Ids2++)
            {
                List<DateTime> tarihlistesi = context.Kilos.Where(x => x.UserID == Ids2).Select(x => x.CreationDate).ToList();
                foreach (DateTime gun in tarihlistesi)
                {
                    Random r = new Random();
                    for (int i = r.Next(1, 4); i >= 0; i--)
                    {
                        meal = new Faker<Meal>()
                        .RuleFor(m => m.UserID, f => Ids2)
                        .RuleFor(m => m.MealName, f =>
                        {

                            List<MealType> ogunler = meals.Where(x => x.UserID == Ids2 && x.MealTime == gun).Select(x => x.MealName).ToList();
                            MealType ogun;
                            do
                            {
                                ogun = f.PickRandom<MealType>();
                            } while (ogunler.Contains(ogun));

                            return ogun;
                        })
                        .RuleFor(m => m.MealTime, f => gun);

                        meals.Add(meal);
                    }
                }
            }

            context.Meals.AddRange(meals);
            context.SaveChanges();


            Faker<MealAndFood> mealAndFood;
            List<MealAndFood> mealsAndFoods = new List<MealAndFood>();
            for (int Ids2 = 2; Ids2 <= 51; Ids2++)
            {
                List<DateTime> tarihlistesi = context.Kilos.Where(x => x.UserID == Ids2).Select(x => x.CreationDate).ToList();
                foreach (DateTime gun in tarihlistesi)
                {
                    List<Meal> ogunListesi = context.Meals.Where(x => x.UserID == Ids2 && x.MealTime == gun).ToList();
                    foreach (Meal yemek in ogunListesi)
                    {
                        Random r = new Random();
                        for (int i = r.Next(1, 4); i >= 0; i--)
                        {
                            mealAndFood = new Faker<MealAndFood>()
                            .RuleFor(mf => mf.MealID, f => yemek.MealID)
                            .RuleFor(mf => mf.FoodID, f =>
                            {
                                Random yeniSayi = new Random();
                                int sayi = yeniSayi.Next(1, foods.Count);
                                return sayi;
                            });

                            mealsAndFoods.Add(mealAndFood);
                        }

                    }
                }
            }

            context.MealsAndFoods.AddRange(mealsAndFoods);
            context.SaveChanges();


        }
    }
}
