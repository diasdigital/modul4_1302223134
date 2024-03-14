using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302223134
{
    public enum Posisi
    {
        Jongkok, Berdiri, Tengkurap, Terbang
    }
    public enum Trigger
    {
        TombolW, TombolS, TombolX
    }

    internal class PosisiKarakterGame
    {
        public class Perubahan
        {
            public Posisi posAwal;
            public Posisi posAkhir;
            public Trigger trigger;

            public Perubahan(Posisi posAwal, Posisi posAkhir, Trigger trigger)
            {
                this.posAwal = posAwal;
                this.posAkhir = posAkhir;
                this.trigger = trigger;
            }
        }

        Perubahan[] transisi =
        {
            new Perubahan(Posisi.Berdiri, Posisi.Terbang, Trigger.TombolW),
            new Perubahan(Posisi.Berdiri, Posisi.Jongkok, Trigger.TombolS),
            new Perubahan(Posisi.Jongkok, Posisi.Berdiri, Trigger.TombolW),
            new Perubahan(Posisi.Jongkok, Posisi.Tengkurap, Trigger.TombolS),
            new Perubahan(Posisi.Tengkurap, Posisi.Jongkok, Trigger.TombolW),
            new Perubahan(Posisi.Terbang, Posisi.Berdiri, Trigger.TombolS),
            new Perubahan(Posisi.Terbang, Posisi.Jongkok, Trigger.TombolX)
        };
        public Posisi posisiSekarang = Posisi.Berdiri;

        public Posisi getNextPosition(Posisi posAwal, Trigger trigger)
        {
            Posisi posAkhir = posAwal;

            foreach (var item in transisi)
            {
                Perubahan perubahan = item;
                if (posAwal == perubahan.posAwal && trigger == perubahan.trigger)
                {
                    posAkhir = perubahan.posAkhir;
                }
            }

            return posAkhir;
        }

        public void klikTombol(Trigger trigger)
        { 

            if (trigger == Trigger.TombolS)
            {
                Console.WriteLine("tombol arah bawah ditekan");
            } else if (trigger == Trigger.TombolW)
            {
                Console.WriteLine("tombola rah atas ditekan");
            }

            posisiSekarang = getNextPosition(posisiSekarang, trigger);
        }
    }
}
