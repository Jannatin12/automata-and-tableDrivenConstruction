using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4_1302213051
{
    internal class PosisiKarakterGame
    {
        private StatePosisi state;

        public enum StatePosisi
        {
            Jongkok, Tengkurap, Terbang, Berdiri
        }

        public enum Tombol
        {
            TombolW, TombolS, Tombolx
        }
        
        class ubahPosisi
        {
            public StatePosisi prevState;
            public StatePosisi nextState;
            public Tombol trigger;

            public  ubahPosisi(StatePosisi prevState, StatePosisi nextState, Tombol trigger)
            {
                this.prevState = prevState;
                this.nextState = nextState;
                this.trigger = trigger;
            }

            public ubahPosisi[] posisi =
            {
                new ubahPosisi(StatePosisi.Jongkok, StatePosisi.Tengkurap, Tombol.TombolS),
                new ubahPosisi(StatePosisi.Tengkurap, StatePosisi.Jongkok, Tombol.TombolW),
                new ubahPosisi(StatePosisi.Terbang, StatePosisi.Jongkok, Tombol.Tombolx),
                new ubahPosisi(StatePosisi.Jongkok, StatePosisi.Berdiri, Tombol.TombolW),
                new ubahPosisi(StatePosisi.Berdiri, StatePosisi.Jongkok, Tombol.TombolS),
                new ubahPosisi(StatePosisi.Berdiri, StatePosisi.Terbang, Tombol.TombolW),
                new ubahPosisi(StatePosisi.Terbang, StatePosisi.Berdiri, Tombol.TombolS),
            };
        }
    }
}
