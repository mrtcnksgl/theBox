using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace theBox.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var Kategoriler = new List<Category>
            {
                new Category(){Name = "Müzik", Description="Müzik Kutuları"},
                new Category(){Name = "Moda", Description="Moda Kutuları"},
                new Category(){Name = "Oyun", Description="Oyun Kutuları"},
                new Category(){Name = "Retro", Description="Retro Kutuları"},
                new Category(){Name = "Video Oyun", Description="Video Oyun Kutuları"},
                new Category(){Name = "Yemek", Description="Yemek Kutuları"}
            };

            foreach(var kategori in Kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();

            var Urunler = new List<Product>
            {
                new Product(){Name = "Klasik Nota Serenat Kutusu", Description="Bu müzik kutusu, klasik müziğin büyülü dünyasını keşfetmek isteyenler için idealdir. İçerisinde ünlü klasik eserlerin notalarını içeren bir vinyl plak, klasik bestecilere ait özel seçilmiş eserler ve zarif müzik notalarını temsil eden aksesuarlar bulunur.", Price= 499, Stock=100 ,IsApproved=true , CategoryId=1, IsHome = true, Image="muzik-kutu.png"},
                new Product(){Name = "Rock Rüzgarı Müzik Kutusu", Description="Rock müzik tutkunları için tasarlanan bu kutu, efsanevi rock gruplarına ve unutulmaz rock şarkılarına adanmıştır. İçeriğinde bir rock albümünün vinyl plakı, rock müziğin simgesi eşyalar ve konsept albümle ilgili bilgiler içeren kartlar bulunur.", Price= 499, Stock=120 ,IsApproved=true , CategoryId=1, Image="muzik-kutu.png"},
                new Product(){Name = "Dünya Rhythms Keşif Kutusu", Description="Müzikseverlere dünya müziğinin çeşitliliğini keşfetme fırsatı sunan bu kutu, farklı kültürlerden ve coğrafyalardan seçilmiş müzikal eserleri içerir. Ethnic enstrümanların bulunduğu bir vinyl plak, kültürel temsil eden aksesuarlar ve müzikle ilgili bilgiler içeren kartlar kutunun içeriğini oluşturur.", Price= 499, Stock=130 ,IsApproved=true , CategoryId=1, Image="muzik-kutu.png"},
                new Product(){Name = "Elektronik Ritimler Sanatı Kutusu ", Description="Elektronik müzik dünyasına adanmış bu kutu, modern elektronik müziğin çeşitli türlerini keşfetmeyi amaçlar. İçeriğinde bir elektronik albümünün vinyl plakı, DJ ve elektronik müziği simgeler içeren aksesuarlar, müzik prodüksiyonu ile ilgili bilgiler içeren kartlar bulunur.", Price= 499, Stock=100 ,IsApproved=true , CategoryId=1, Image="muzik-kutu.png"},
                
                new Product(){Name = "Klasik Chic Stil Kutusu", Description="Bu moda kutusu, klasik ve zamansız şıklığa ilgi duyanları hedefler. İçeriğinde zarif tasarımlı ve kaliteli kumaşlardan üretilmiş kıyafetler, klasik takılar, şık güzellik ürünleri ve moda dergileri bulunur. Moda dünyasının klasik stil ikonlarına ve trendlere odaklanır.", Price= 599, Stock=100 ,IsApproved=true , CategoryId=2, Image="moda-kutu.png"},
                new Product(){Name = "Boho Ruhlu Macera Kutusu", Description="Bu kutu, bohem tarzını seven ve özgür ruhlu bireyleri hedefler. İçeriğinde etnik desenli kıyafetler, boho takılar, el yapımı aksesuarlar, vintage görünümlü güzellik ürünleri ve boho stil ikonlarına dair ilham verici içerikler bulunur. Doğadan ilham alınan renk paleti ve rahat giyim tarzı ön plandadır.", Price= 499, Stock=120 ,IsApproved=true , CategoryId=2, Image="moda-kutu.png"},
                new Product(){Name = "Gece Şıklığı ve Parti Kutusu", Description="Bu moda kutusu, gece şıklığına ve sosyal etkinliklere özel kıyafetlere ilgi duyanları hedefler. İçeriğinde şık elbiseler, parti ayakkabıları, ışıltılı takılar, makyaj ürünleri ve gece hayatına dair stil ipuçları içeren kartlar bulunur. Moda dünyasının geceye özel ikonlarına odaklanır.", Price= 699, Stock=140 ,IsApproved=true , CategoryId=2, IsHome = true, Image="moda-kutu.png"},
                
                new Product(){Name = "Strateji ve Zeka Harikası Kutusu", Description="Bu kutu, strateji ve zeka oyunlarına tutkun oyuncuları hedefler. İçeriğinde ödüllü strateji oyunları, bulmacalar, zeka geliştirici oyunlar ve oyuncuları meydan okuyan oyunlar bulunur. Her ay farklı bir zeka oyunu temasına odaklanarak müşterilere beyin gücünü sınamak için yeni bir fırsat sunar.", Price= 399, Stock=100 ,IsApproved=true , CategoryId=3, Image="oyun-kutu.png"},
                new Product(){Name = "Aile Oyunları ve Eğlence Kutusu", Description="Bu kutu, ailece keyifli zaman geçirmeyi sevenleri hedefler. İçeriğinde aile dostu ve eğlenceli oyunlar, grup aktiviteleri için tasarlanmış oyunlar, kart oyunları ve aile oyun gecesi ile ilgili ipuçları içeren kartlar bulunur. Her ay farklı bir aile oyunu temasıyla müşterilere bir araya gelerek eğlenme şansı sunar.", Price= 399, Stock=150 ,IsApproved=true , CategoryId=3, Image="oyun-kutu.png"},
                new Product(){Name = "Maceraperestler İçin Aksiyon Kutusu", Description="Bu kutu, macera ve aksiyon dolu oyunları seven oyuncuları hedefler. İçeriğinde stratejik aksiyon oyunları, hikaye tabanlı macera oyunları, fantastik temalı oyunlar ve macera oyunu figürleri bulunur. Her ay farklı bir aksiyon temalı oyun ile müşterilere heyecan dolu bir board oyunu deneyimi sunar.", Price= 399, Stock=120 ,IsApproved=true , CategoryId=3, Image="oyun-kutu.png"},
                
                new Product(){Name = "80'ler Nostaljisi Kutusu", Description="Bu kutu, 80'lerin eğlence dünyasına dair nostaljik bir yolculuğa çıkarmayı amaçlar. İçeriğinde 80'lerin popüler kültürüne ait kıyafetler, vintage müzik kasetleri, eski film posterleri, retro oyuncaklar ve 80'lerin ikonik karakterleriyle ilgili bilgiler içeren kartlar bulunur. Her ay farklı bir 80'ler temalı nostaljik deneyim sunar.", Price= 399, Stock=110 ,IsApproved=true , CategoryId=4, Image="retro-kutu.png"},
                new Product(){Name = "90'lar Çocukluğu Geri Getiren Kutu", Description="Bu kutu, 90'ların çocukluğuna özlem duyanları hedefler. İçeriğinde 90'lar popüler çizgi filmlerine ve oyunlarına ait kıyafetler, eski video oyunlarından çıkartmalar, eski dergi kapakları, retro oyuncaklar ve 90'ların efsanevi karakterlerini tanıtan kartlar bulunur. Her ay farklı bir 90'lar temasıyla müşterilere çocukluklarının hatıralarını tazeleme şansı sunar.", Price= 399, Stock=115 ,IsApproved=true , CategoryId=4, Image="retro-kutu.png"},
                
                new Product(){Name = "Efsanevi RPG Macerası Kutusu", Description="Bu kutu, rol yapma oyunlarını seven oyunculara odaklanır. İçeriğinde popüler RPG oyunlarından esinlenmiş kıyafetler, oyun dünyası karakterlerini temsil eden figürler, RPG oyunlarının müziklerini içeren özel disketler ve hikaye odaklı oyunlar hakkında bilgiler içeren kartlar bulunur. Her ay farklı bir epik macera temasıyla müşterilere RPG dünyasının büyüsünü yaşatmayı amaçlar.", Price=   599, Stock=140 ,IsApproved=true , CategoryId=5, Image="video-oyun-kutu.png"},
                new Product(){Name = "Strateji ve Savaş Sanatı Kutusu", Description="Bu kutu, strateji ve savaş oyunlarına ilgi duyan oyunculara hitap eder. İçeriğinde stratejik oyunları temsil eden kıyafetler, savaş oyunlarından esinlenmiş oyuncaklar, strateji oyunlarına özel stratejiler içeren kartlar ve strateji rehberleri bulunur. Her ay farklı bir strateji savaşı temasıyla müşterilere zihinsel savaşın heyecanını yaşatmayı amaçlar.", Price= 599, Stock=145 ,IsApproved=true , CategoryId=5, Image="video-oyun-kutu.png"},
                new Product(){Name = "Futuristik FPS Deneyimi Kutusu", Description="Bu kutu, geleceğin FPS (First Person Shooter) oyunlarına ilgi duyan oyunculara yöneliktir. İçeriğinde futuristik tasarımlara sahip kıyafetler, FPS oyunlarından esinlenmiş oyuncaklar, özel FPS müziklerini içeren disketler ve yeni FPS oyunları hakkında bilgiler içeren kartlar bulunur. Her ay farklı bir futuristik FPS temasıyla müşterilere bilgisayar ekranlarının ötesinde bir dünyaya yolculuk etme fırsatı sunmayı amaçlar.", Price= 599, Stock=105 ,IsApproved=true , CategoryId=5, IsHome = true, Image="video-oyun-kutu.png"},
                
                new Product(){Name = "Dünya Mutfağı Keşfi Kutusu", Description="Bu kutu, dünya genelindeki farklı mutfaklardan lezzetleri keşfetmeyi sevenlere hitap eder. İçeriğinde farklı ülkelerin yöresel yemek malzemeleri, tarif kartları, özel soslar ve baharatlar bulunur. Her ay farklı bir ülkenin mutfak kültürüne odaklanarak müşterilere evlerinde dünya turu yapma şansı sunar.", Price= 399, Stock=140 ,IsApproved=true , CategoryId=6, Image="yemek-kutu.png"},
                new Product(){Name = "Sağlıklı ve Denge Kutusu", Description="Bu kutu, sağlıklı beslenmeye öncelik verenleri hedefler. İçeriğinde organik ve sağlıklı atıştırmalıklar, besleyici yemek malzemeleri, tarif kartları, sağlıklı yaşam ipuçları içeren broşürler ve özel diyetlere uygun alternatif ürünler bulunur. Her ay farklı sağlıklı ve dengeli yemek temalarıyla müşterilere sağlıklı bir yaşam tarzını benimseme fırsatı sunar.", Price= 399, Stock=120 ,IsApproved=true , CategoryId=6, Image="yemek-kutu.png"},
                new Product(){Name = "Gurme Lezzetler ve Tatlılar Kutusu", Description="Bu kutu, gurme lezzetlere ve özel tatlılara ilgi duyanları hedefler. İçeriğinde özel şeflerin seçtiği gurme ürünler, el yapımı tatlılar, özel kahve veya çay çeşitleri, tarif kartları ve lezzet deneyimini artıran özel soslar bulunur. Her ay farklı bir gurme tema veya özel tatlılarla müşterilere özel lezzet şöleni yaşatmayı amaçlar.", Price= 399, Stock=125 ,IsApproved=true , CategoryId=6, Image="yemek-kutu.png"},


            };

            foreach (var urun in Urunler)
            {
                context.Products.Add(urun);
            }

            context.SaveChanges();

            base.Seed(context);
        }
    }
}