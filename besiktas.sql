-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 02 Oca 2023, 22:22:42
-- Sunucu sürümü: 10.4.25-MariaDB
-- PHP Sürümü: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `besiktas`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `admin`
--

CREATE TABLE `admin` (
  `id` int(11) NOT NULL,
  `username` varchar(10) NOT NULL,
  `password` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Tablo döküm verisi `admin`
--

INSERT INTO `admin` (`id`, `username`, `password`) VALUES
(1, 'admin', 'admin');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `basketbol`
--

CREATE TABLE `basketbol` (
  `id` int(11) NOT NULL,
  `isim` varchar(25) NOT NULL,
  `soyisim` varchar(25) NOT NULL,
  `numara` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Tablo döküm verisi `basketbol`
--

INSERT INTO `basketbol` (`id`, `isim`, `soyisim`, `numara`) VALUES
(1, 'Burak Can', 'Yıldızlı', 19),
(2, 'Jason', 'Rich', 25),
(3, 'Yağız', 'Aksu', 10),
(4, 'Emir', 'Adıhüzel', 9),
(5, 'Okben', 'Ulubay', 13),
(6, 'Efe', 'Tahmaz', 14),
(7, 'David', 'McCormack', 33),
(8, 'Jordan', 'Usher', 4),
(9, 'Gediminas', 'Orelik', 17),
(10, 'Yiğit', 'Onan', 1),
(11, 'Matt', 'Mooney', 31),
(12, 'Ömer Can ', 'İlyasoğlu', 11),
(13, 'Egemen', 'Güven', 15),
(14, 'Samet', 'Yiğitoğlu', 0),
(15, 'Demir', 'Doğan', 0),
(16, 'Kerem', 'Konan', 0),
(20, 'Oğuzhan', 'Göktepe', 0);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `futbol`
--

CREATE TABLE `futbol` (
  `id` int(11) NOT NULL,
  `isim` varchar(25) NOT NULL,
  `soyisim` varchar(25) NOT NULL,
  `numara` varchar(25) NOT NULL,
  `brans` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Tablo döküm verisi `futbol`
--

INSERT INTO `futbol` (`id`, `isim`, `soyisim`, `numara`, `brans`) VALUES
(1, 'Muhammed', 'Hlland', '31', 'forvet'),
(2, 'Muhammed', 'Hlland', '31', 'forvet'),
(3, 'Muhammed', 'Hlland', '31', 'forvet'),
(4, 'Muhammed', 'Hlland', '31', 'forvet'),
(7, 'Muhammed', 'Hlland', '31', 'forvet'),
(9, 'Muhammed', 'Hlland', '31', 'forvet'),
(10, 'Muhammed', 'Hlland', '31', 'forvet'),
(11, 'Muhammed', 'Hlland', '31', 'forvet'),
(12, 'Muhammed', 'Hlland', '31', 'forvet'),
(13, 'Muhammed', 'Hlland', '31', 'forvet'),
(14, 'Muhammed', 'Hlland', '31', 'forvet'),
(15, 'Muhammed', 'Hlland', '31', 'forvet'),
(16, 'Muhammed', 'Hlland', '31', 'forvet'),
(17, 'Muhammed', 'Hlland', '31', 'forvet'),
(18, 'Muhammed', 'Hlland', '31', 'forvet'),
(19, 'Muhammed', 'Hlland', '31', 'forvet'),
(20, 'Muhammed', 'Hlland', '31', 'forvet'),
(21, 'Muhammed', 'Hlland', '31', 'forvet'),
(22, 'Muhammed', 'Hlland', '31', 'forvet'),
(23, 'Muhammed', 'Hlland', '31', 'forvet'),
(24, 'Muhammed', 'Hlland', '31', 'forvet'),
(25, 'Muhammed', 'Hlland', '31', 'forvet'),
(26, 'Muhammed', 'Hlland', '31', 'forvet'),
(28, 'Muhammed', 'Hlland', '31', 'forvet');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `iletisim`
--

CREATE TABLE `iletisim` (
  `id` int(11) NOT NULL,
  `isim` varchar(50) NOT NULL,
  `gsm` varchar(20) NOT NULL,
  `mail` varchar(30) NOT NULL,
  `message` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Tablo döküm verisi `iletisim`
--

INSERT INTO `iletisim` (`id`, `isim`, `gsm`, `mail`, `message`) VALUES
(1, 'dsa', 'dsa', 'sa', 'sa');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kulüp`
--

CREATE TABLE `kulüp` (
  `id` int(11) NOT NULL,
  `Kulup_kimligi` varchar(50) NOT NULL,
  `kurulus_tarih` varchar(50) NOT NULL,
  `renkler` varchar(50) NOT NULL,
  `kurulus_ismi` varchar(50) NOT NULL,
  `ilk_baskan` varchar(50) NOT NULL,
  `ilk_sampiyonluk` varchar(50) NOT NULL,
  `futbolsube_kurulus` varchar(50) NOT NULL,
  `f_ilk_sampiyonluk` varchar(50) NOT NULL,
  `f_liggiris` varchar(50) NOT NULL,
  `tarihce` text NOT NULL,
  `baskan_mesaj` text NOT NULL,
  `kulup_adres` text NOT NULL,
  `besiktas_adres` text NOT NULL,
  `gsm` int(11) NOT NULL,
  `faks` int(11) NOT NULL,
  `kulup_mail` varchar(50) NOT NULL,
  `web_mail` varchar(50) NOT NULL,
  `muze_mail` varchar(50) NOT NULL,
  `insankaynak_mail` varchar(50) NOT NULL,
  `uyelik_mail` varchar(50) NOT NULL,
  `bilet_mail` varchar(50) NOT NULL,
  `gizlilik_anlasma` text NOT NULL,
  `baskan_adi` varchar(25) NOT NULL,
  `baskan_soyadi` varchar(25) NOT NULL,
  `baskan_yas` int(25) NOT NULL,
  `baskan_dgtarih` date NOT NULL,
  `baskan_görevbaslamatarihi` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Tablo döküm verisi `kulüp`
--

INSERT INTO `kulüp` (`id`, `Kulup_kimligi`, `kurulus_tarih`, `renkler`, `kurulus_ismi`, `ilk_baskan`, `ilk_sampiyonluk`, `futbolsube_kurulus`, `f_ilk_sampiyonluk`, `f_liggiris`, `tarihce`, `baskan_mesaj`, `kulup_adres`, `besiktas_adres`, `gsm`, `faks`, `kulup_mail`, `web_mail`, `muze_mail`, `insankaynak_mail`, `uyelik_mail`, `bilet_mail`, `gizlilik_anlasma`, `baskan_adi`, `baskan_soyadi`, `baskan_yas`, `baskan_dgtarih`, `baskan_görevbaslamatarihi`) VALUES
(1, 'Beşiktaş Jimnastik Kulübü', '1903', 'Siyah - Beyaz', 'Jimnastik 1911', 'Murat Tiren', 'Beşiktaş Bereket Jimnastik Kulübü', '1919', '1919 Türk İdman Birliği Ligi', '1919', '1902 sonbaharında Beşiktaş Serencebey Mahallesi\'nde, o zamanın Medine Muhafızı olan Osman Paşa\'nın konağının bahçesinde, 22 kişilik genç grup, haftanın bazı günlerinde toplanıp jimnastik hareketleri yapmaktaydı. Başta Osman Paşa\'nın oğulları Mehmet Şamil ve Hüseyin Bereket ile mahellenin gençlerinden Ahmet Fetgeri, Mehmet Ali Fetgeri, Nazımnazif, Cemil Feti ve Şevket Beyler’in aralarında bulunduğu gençlerin ilk ilgilendikleri spor branşları, özellikle barfiks, paralel, güreş, halter, aletli ve aletsiz jimnastikti. O sıralarda siyasi hareketler dolayısıyla her türlü toplanmadan ürkerek hafiyeler dolaştıran 2. Abdülhamit\'in adamları Serencebey\'deki bu toplanmaları haber alınca, spor yapan gençler bir baskınla karakola götürüldü. Bu sporcu gençlerin bir kısmının saray erkanına yakın olması, ayrıca o dönemlerde kötü gözle bakılan futbol oynamadıkları ve sadece beden hareketleri yaptıklarını belirtmeleriyle gergin durum yumuşadı. Hatta saray çevresinden Şeyhzade Abdülhalim bu sporcuları destekledi ve sık sık antrenmanları seyretmeye başladı. Ünlü boksör ve güreşçi Kenan Bey de antrenmanlara gelerek güreş ve boks hareketleri göstermeye başladı. \r\n\r\n1903 Mart\'ında ise özel bir izinle Bereket Jimnastik Kulübü kuruldu. 1908\'de Meşrutiyet\'in ilanıyla sportif hareketler biraz daha serbestlik kazandı. 13 Nisan 1909\'daki (31 Mart 1325) siyasi olaylardan sonra Edirne\'de bulunan Fuat Balkan ve Mazhar Kazancı, Hareket Ordusu ile İstanbul\'a geldi. Siyasi olaylar yatıştıktan sonra iyi bir eskrim hocası olan Fuat Balkan ile başta güreş ve halter sporlarını yapan Mazhar Kazancı, Serencebey\'de jimnastik yapan gençleri bularak birlikte spor yapma fikrini kabul ettirdi. Fuat Balkan, Ihlamur\'daki evinin altındaki yeri, kulüp merkezi yaptı ve Bereket Jimnastik Kulübü\'nün adı Beşiktaş Osmanlı Jimnastik Kulübü olarak değiştirildi. Böylece jimnastik, güreş, boks, eskrim ve atletizmin ön planda tutulduğu güçlü bir spor kulübü meydana geldi. Fuat Bey\'in arkadaşları Refik ve Şerafettin Beyler de iyi birer eskrimciydi. \r\n\r\nBu arada Beyoğlu Mutasarrıfı Muhittin Bey\'in teşvikiyle Beşiktaş Osmanlı Jimnastik Kulübü, 26 Ocak 1911 tarihinde tescil edilen ilk Türk spor kulübü oldu. Semtin gençlerinin bu spor kulübüne ilgisi büyüdü ve spor yapan üyelerin sayısı bir anda 150\'ye yükseldi. Kulübün merkezi de Ihlamur\'dan Akaretler\'de 49 numaralı binaya taşındı. Bir süre sonra bu bina da küçük gelince, yine Akaretler\'de 84 numaralı binaya geçildi. Bu binanın arkasındaki bahçe de bir spor sahası haline getirildi. ', 'Değerli beşiktaşaklılar\n\nÜlkemizin en köklü ve 120 yıllık tarihiyle Avrupa’nın da ender kulüp ve camialarından biri olarak Cumhuriyetimizin 100’üncü yılı olması, ayrıca Beşiktaş Tekerlekli Sandalye Basketbol Takımımızın 20’nci kuruluş yılına denk gelmesi sebebiyle Türkiye’de bir ilki gerçekleştirerek, “Engeller Bizi Durduramaz” sloganıyla sosyal sorumluluk projemizi 3 Aralık Dünya Engelliler Günü’nde hayata geçirmenin mutluluğunu yaşıyoruz. Aynı tarihte Beşiktaş Tekerlekli Sandalye Basketbol Takımımızın maçı öncesinde Akatlar Spor Kompleksi’nde Yönetimimiz, STK’lar, sporcularımız, medya ve engelli arkadaşlarımızın ailelerinin de katılımıyla Dünya Engelliler Günü’nü kutladık.\n\nDünya şampiyonu olarak bizlere tarifi imkânsız bir gurur yaşatan güreşçi kızımız Nesrin Baş’ı ödüllendirdik ve kendisini daha da başarılı olması yönünde teşvik etmeye devam edeceğiz. Diğer amatör branşları da uzun vadede devamlılık prensibiyle programladık.\n\nSporcular yetiştirmek adına yeni bir fabrikamızı faaliyete geçirdik. Şişli’de 6-16 yaş arası voleybol, 4-12 yaş arası jimnastik okulumuz geleceğin şampiyon adaylarını yetiştirmek adına çalışmalarına başladı. Başlarında proje müdürü ve okulun kurucusu olarak bulunan Muammer Yol, büyük özveriyle onları en iyi şekilde yetiştirmeye odaklandı. Kendisini verdiği destekten ötürü kutluyoruz.\n\nDeğerli Beşiktaşlılar,\n\nEn değerli varlığımız olan öğretmenlerimiz bizim baştacımızdır. Hayata atılmamıza vesile olan bu yüce insanların 24 Kasım Öğretmenler Günü’nü bir kez daha kutladık.\n\nGençlik ve Spor Bakanımız Mehmet Muharrem Kasapoğlu’nu İstanbul’daki çalışma ofisinde ziyaret ettik. Gayet faydalı fikir alışverişlerinde bulunduk. Kulübümüz ile Gençlik ve Spor Bakanlığı arasındaki konuları konuştuk. Son derece olumlu bir görüşme oldu.\n\nFutbol takımımızın Dünya Kupası organizasyonu nedeniyle Süper Lig’e verilen arayı en iyi şekilde değerlendireceğinden şüphemiz yok. Futbol A Takımımıza başarılar diliyor ve her anlarında yanlarında olduğumuzu bir kez daha vurgulamak istiyorum.\n\nElimizde tuttuğumuz Beşiktaş Dergimiz 250’nci sayısına ulaştı. Bu da bizi son derece mutlu kılan bir başka husus. Dergimizi büyük bir titizlikle hazırlayan tüm emekçi kardeşlerimizi, bizleri 250’nci sayımıza ulaştırdıkları için kutluyorum. Başarımız daim olsun.\n\nElbette 2023’ten beklentilerimiz büyük. Her branşımızın başarılı olması en büyük dileğimiz. Yeni yılda, yeni beklentiler, yeni umutlar içerisindeyiz. Bu vesileyle herkese iyi yıllar, mutlu yarınlar ve esenlikler diliyorum.\n\nAhmet Nur Çebi\nBeşiktaş JK Yönetim Kurulu Başkanı', 'Vişnezade Mahallesi Kadırgalar Caddesi No:1 Vodafone Park Otopark Girişi Kat:1 34357 Beşiktaş - İstanbul', 'Vişnezade Mahallesi Dolmabahçe Caddesi No:1 Vodafone Park Dolmabahçe Girişi Kat:-2 İç Kapı No:1113 34357 Beşiktaş - İstanbul', 2147483647, 2129481999, 'bilgi@bjk.com.tr', 'webmaster@bjk.com.tr', 'bjkmuze@bjk.com.tr', 'ik@bjk.com.tr', 'naci.yalcin@bjk.com.tr', 'bilet@bjk.com.tr', 'Beşiktaş Jimnastik Kulübü (“BJK”) olarak kişisel verileriniz konusunda büyük bir hassasiyet göstermekteyiz. Bu nedenle, temel hak ve özgürlüklerinizi korumak amacıyla yürürlükte olan 6698 Sayılı Kişisel Verilerin Korunması Kanunu’nu (“KVKK”) kapsamındaki kişisel verilerinizin kullanımı ve korunması ile ilgili haklarınız hakkında sizi bilgilendirmek istiyoruz.\r\n\r\n1. Kişisel Veri Nedir?\r\nKişisel veri, KVKK ’da kimliği belirli veya belirlenebilir gerçek kişiye ilişkin her türlü bilgi olarak tanımlanmıştır. Buna göre bizimle paylaştığınız adınız, soyadınız, elektronik posta adresiniz ve telefon numaranız kişisel veri olarak adlandırılmaktadır.\r\n\r\n2. Kişisel verilerinizin tarafımızca toplanmasının amacı nedir?\r\nBJK ile olan ürün ve hizmet ilişkiniz dolayısıyla yasal yükümlülüklerimizi yerine getirebilmek ve sizi Kulübümüz bünyesindeki gelişmelerden haberdar edebilmek için kişisel bilgilerinizi toplamakta ve bu kapsamda işlemekteyiz.\r\n\r\n3. Kişisel verilerinizi hangi amaçla, kimlere aktarıyoruz?\r\nKişisel verileriniz BJK ile doğrudan/dolaylı yurtiçi/yurtdışı iştiraklerimizle, iş ilişkisinin devamı esnasında birlikte bizi temsil eden ve/veya faaliyetlerimizi yürütebilmek için işbirliği yaptığımız iş ortağımız olan kurum, kuruluşlarla, verilerin bulut ortamında saklanması hizmeti aldığımız yurtiçi/yurtdışı kişi ve kurumlarla paylaşılabilmektedir. Ayrıca, yasal yükümlülüklerimiz nedeniyle ve bunlarla sınırlı olmak üzere mahkemeler ve diğer kamu kurumları ile kişisel veriler paylaşılmaktadır.\r\n\r\n4. Kişisel verilerinizi nasıl saklıyoruz?\r\nBJK ile paylaşılan kişisel verileriniz ilgili yasal düzenlemelere, KVKK hükümlerine ve BJK standartlarına uygun olarak saklanmaktadır.\r\n\r\n5. Kişisel verilerinizi ne kadar süre ile tutuyoruz?\r\nBJK olarak kişisel verilerinizi KVKK’ya uygun olarak saklamaktayız. KVKK md. 7/f.1.’e göre işlenmesi gerektiren amaç ortadan kalktığında ve/veya mevzuat uyarınca verilerinizi işlememiz için zorunlu kılındığımız zamanaşımı süreleri dolduğunda, kişisel verileriniz tarafımızca silinecek, yok edilecek veya anonimleştirerek kullanılmaya devam edilecektir.\r\n\r\n6. Kişisel Verilerin Korunması Kanunu’ndan doğan haklarınız nelerdir?\r\nİşlenen kişisel verilerinizle ilgili mevzuat uyarınca; kişisel veri işlenip işlenmediğini öğrenme, kişisel verileri işlenmişse buna ilişkin bilgi talep etme, kişisel verilerin işlenme amacını ve bunların amacına uygun kullanılıp kullanılmadığını öğrenme, yurt içinde veya yurt dışında kişisel verilerin aktarıldığı üçüncü kişileri bilme, kişisel verilerin eksik veya yanlış işlenmiş olması hâlinde bunların düzeltilmesini isteme, kişisel verilerin silinmesini veya yok edilmesini isteme, kişisel verilerin eksik veya yanlış işlenmiş olması hâlinde bunların düzeltilmesine ve/veya kişisel verilerin silinmesini veya yok edilmesine ilişkin işlemlerin kişisel verilerin aktarıldığı üçüncü kişilere bildirilmesini isteme, işlenen verilerin münhasıran otomatik sistemler vasıtasıyla analiz edilmesi suretiyle kişinin kendisi aleyhine bir sonucun ortaya çıkmasına itiraz etme, kişisel verilerin kanuna aykırı olarak işlenmesi sebebiyle zarara uğraması hâlinde zararın giderilmesini talep etme haklarına sahipsiniz. Web sitemizde yer alan Başvuru Formu üzerinden yapılacak başvurularınıza yasal süresi içerisinde geri dönüş sağlamaktayız.', 'Ahmet Nur', 'Çebi', 64, '1954-10-29', '2019-10-20');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `taraftar`
--

CREATE TABLE `taraftar` (
  `id` int(11) NOT NULL,
  `adi` varchar(50) NOT NULL,
  `soyadi` varchar(50) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `gsm` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Tablo döküm verisi `taraftar`
--

INSERT INTO `taraftar` (`id`, `adi`, `soyadi`, `username`, `password`, `email`, `gsm`) VALUES
(1, 'Kadir', 'Haşlar', 'kadir.haslar', '123456789', '', 0),
(2, '', '', 'adks', '123', '', 0),
(3, 'admin', 'admin', 'admin', 'admin', 'admin', 2147483647),
(4, '', '', 'we', 'we', '', 0),
(5, '', '', 'kadir', 'kadir', '', 0),
(6, '', '', 'kadir', '', '', 0),
(7, '', '', '', '', '', 0),
(8, 'asd', 'asdasd', 'asd', 'asd', 'asd', 0),
(9, '', '', '', '', '', 0),
(10, 'da', 'da', 'dsa', 'dsa', 'das', 0),
(11, 'da', 'da', '', 'dsa', 'das', 0),
(12, 'da', 'da', '', '', 'das', 0),
(13, '', 'da', '', '', 'das', 0),
(14, 'gfd', 'gfd', 'gfd', 'gfd', 'gfd', 0),
(15, 'admin', 'admin', 'admin', 'admin', 'admin', 5341),
(16, 'Furkan', 'Acaroğlu', '31bayburt6962', '123456', 'dans@gmail.com', 546748965),
(17, 'ssa', 'sa', 'mulkan', '123', 'sa', 165);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `vakif_mesage`
--

CREATE TABLE `vakif_mesage` (
  `id` int(11) NOT NULL,
  `isim` varchar(255) NOT NULL DEFAULT 'İsimsiz',
  `gsm` varchar(255) NOT NULL DEFAULT 'Gsm Bos',
  `mail` varchar(255) NOT NULL DEFAULT 'Mail Bos',
  `mesage` text NOT NULL DEFAULT 'Message Bos'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Tablo döküm verisi `vakif_mesage`
--

INSERT INTO `vakif_mesage` (`id`, `isim`, `gsm`, `mail`, `mesage`) VALUES
(1, 'Kadir Haşlar', '05347008428', 'kadir.haslar@gmail.com', 'dsadasdasdad'),
(2, 'murat', '4123', 'dsada@adskşda.com', 'yapamadım aq ');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `vakıf`
--

CREATE TABLE `vakıf` (
  `nasil_bagis_yaparim` text NOT NULL,
  `bagis_gsm` varchar(50) NOT NULL,
  `bagis_nakit` text NOT NULL,
  `bagis_banka` text NOT NULL,
  `bagis_vakifbank` varchar(50) NOT NULL,
  `bagis_mail` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Tablo döküm verisi `vakıf`
--

INSERT INTO `vakıf` (`nasil_bagis_yaparim`, `bagis_gsm`, `bagis_nakit`, `bagis_banka`, `bagis_vakifbank`, `bagis_mail`) VALUES
('BJK-KABATAŞ VAKFI’na ürün, hizmet, gayrimenkul, menkul, vasiyet bağışı yapabileceğiniz gibi, tüm bağış kampanyalarımıza nakdi olarak da destek verebilirsiniz.', '0 212 948 19 03', 'Web sayfamızdan (kredi kartı)\r\n\r\nAşağıda ki Online Bağış butonuna tıklayarak kredi kartınızla bağış yapabilirsiniz.\r\n\r\nTelefon/fax ile (kredi kartı)\r\n\r\n0 212 948 19 03 nolu telefon ile Vakfımızı arayarak veya aşağıda ki bağış formu seçeneğinde yer alan formu doldurup 0 212 948 19 99 nolu faxsa göndererek', 'Aşağıda ki BEŞİKTAŞ JİMNASTİK KULUBÜ-KABATAŞ ERKEK LİSELİLER EĞİTİM,KÜLTÜR VE SAĞLIK VAKFI hesabına havale/eft yaparak', 'TR12 0001 5001 5800 7303 3931 78', 'bagis@bjkkabatasvakfi.org');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `basketbol`
--
ALTER TABLE `basketbol`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `futbol`
--
ALTER TABLE `futbol`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `iletisim`
--
ALTER TABLE `iletisim`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `kulüp`
--
ALTER TABLE `kulüp`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `taraftar`
--
ALTER TABLE `taraftar`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `vakif_mesage`
--
ALTER TABLE `vakif_mesage`
  ADD PRIMARY KEY (`id`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `admin`
--
ALTER TABLE `admin`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Tablo için AUTO_INCREMENT değeri `basketbol`
--
ALTER TABLE `basketbol`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- Tablo için AUTO_INCREMENT değeri `futbol`
--
ALTER TABLE `futbol`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- Tablo için AUTO_INCREMENT değeri `iletisim`
--
ALTER TABLE `iletisim`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Tablo için AUTO_INCREMENT değeri `kulüp`
--
ALTER TABLE `kulüp`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Tablo için AUTO_INCREMENT değeri `taraftar`
--
ALTER TABLE `taraftar`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- Tablo için AUTO_INCREMENT değeri `vakif_mesage`
--
ALTER TABLE `vakif_mesage`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
