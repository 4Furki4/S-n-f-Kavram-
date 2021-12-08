# Static Sınıf ve Üyeler
* Static olmayan metotlara, propertylere vb. nesne ile ulaşırsın ancak static olanlara class ismiyle ulaşırsın ve nesne de oluşturamazsın zaten. SınıfAdı.Metot vb. ile ulaşabilirsin staticlerde.

## Farklar ve Bazı Özellikler
* Static olmayanlarda özellikler, metotlar nesneye özgü olur ancak staticlerde sınıfa ait olduğu için son aldığı değer onun değeri olur.
* Static kurucu yaratabilirsin. Static constructor'ların erişim belirteçleri yoktur.
* Çalışan sınıfının static kurucusuna sadece bir kez ve ilk defa çalıştırıldığında erişilir. Ancak normal constructor'a her nesne oluşturulduğunda erişilir.
