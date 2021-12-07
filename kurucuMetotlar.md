# Kurucu Metotlar
Bir sınıfın nesnesi oluşturulurken arkada çalışan metotlardır. Bir nesne oluşturulurken bir şeyleri değiştirmek, eklemek istersek bu metotlarda değişiklikler yapmamız lazım.

* Kurucu metotların ismi, class ile aynı olmalı
* Erişim Belirleyicileri public olmalı
* geri dönüş tipi yoktur. Sadece _public Metotlar_ gibi
* Bu sayede kurucu metotun parametre kısmında atamalar yapabilir ve kodu iyileştirebilirsin.
* kurucu metotlar da overload edilebilir. Elindeki veriye bağlı olarak ilk başta sadece isim ve soy ismi atayacağın bir kurucu metot yapabilirsin mesela ancak diğerlerini atamazsan string ise null, int değişken ise 0 olarak atar. (Bool ise False imiş.)