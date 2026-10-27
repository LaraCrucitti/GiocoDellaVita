using System;
using System.Collections.Generic;
using System.Text;

namespace GiocoDellaVita 
{
    internal class CCarota:  CPersonaggi, IComportamento
    {
        private int[,] _posizionecarota;

        public CCarota() : base()
        {
            _posizionecarota = new int [0,0];
        }
    }
}
