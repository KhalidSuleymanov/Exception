using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAbstraction
{
    internal abstract class Television
    {
        public string Name;
        public string Model;
        public double Size;
        public string MatrixType;
        public double TheFrequeUpdatePersonnel;
        public string SupportVideoFormats;
        public byte SoundQuality;
        public string Placement;

        public abstract void Televisions();
    }
}
