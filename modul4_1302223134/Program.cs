// See https://aka.ms/new-console-template for more information
using modul4_1302223134;

// Test KodeBuah
KodeBuah kodeBuah = new KodeBuah();
Console.WriteLine(kodeBuah.getKodeBuah(KodeBuah.enumBuah.Apel));
Console.WriteLine(kodeBuah.getKodeBuah(KodeBuah.enumBuah.Aprikot));
Console.WriteLine(kodeBuah.getKodeBuah(KodeBuah.enumBuah.Alpukat));
Console.WriteLine(kodeBuah.getKodeBuah(KodeBuah.enumBuah.Pisang));
Console.WriteLine(kodeBuah.getKodeBuah(KodeBuah.enumBuah.Paprika));
Console.WriteLine(kodeBuah.getKodeBuah(KodeBuah.enumBuah.Blackberry));
Console.WriteLine(kodeBuah.getKodeBuah(KodeBuah.enumBuah.Ceri));
Console.WriteLine(kodeBuah.getKodeBuah(KodeBuah.enumBuah.Kelapa));
Console.WriteLine(kodeBuah.getKodeBuah(KodeBuah.enumBuah.Jagung));
Console.WriteLine(kodeBuah.getKodeBuah(KodeBuah.enumBuah.Kurma));
Console.WriteLine(kodeBuah.getKodeBuah(KodeBuah.enumBuah.Durian));
Console.WriteLine(kodeBuah.getKodeBuah(KodeBuah.enumBuah.Anggur));
Console.WriteLine(kodeBuah.getKodeBuah(KodeBuah.enumBuah.Melon));
Console.WriteLine(kodeBuah.getKodeBuah(KodeBuah.enumBuah.Semangka));


// Test PosisiKarakterGame
PosisiKarakterGame PKG = new PosisiKarakterGame();

Console.WriteLine("Posisi sekarang adalah " + PKG.posisiSekarang);

PKG.klikTombol(Trigger.TombolW);
Console.WriteLine("Posisi sekarang adalah " + PKG.posisiSekarang);

PKG.klikTombol(Trigger.TombolX);
Console.WriteLine("Posisi sekarang adalah " + PKG.posisiSekarang);

PKG.klikTombol(Trigger.TombolW);
Console.WriteLine("Posisi sekarang adalah " + PKG.posisiSekarang);

PKG.klikTombol(Trigger.TombolW);
Console.WriteLine("Posisi sekarang adalah " + PKG.posisiSekarang);

PKG.klikTombol(Trigger.TombolS);
Console.WriteLine("Posisi sekarang adalah " + PKG.posisiSekarang);

PKG.klikTombol(Trigger.TombolS);
Console.WriteLine("Posisi sekarang adalah " + PKG.posisiSekarang);

PKG.klikTombol(Trigger.TombolS);
Console.WriteLine("Posisi sekarang adalah " + PKG.posisiSekarang);

PKG.klikTombol(Trigger.TombolW);
Console.WriteLine("Posisi sekarang adalah " + PKG.posisiSekarang);