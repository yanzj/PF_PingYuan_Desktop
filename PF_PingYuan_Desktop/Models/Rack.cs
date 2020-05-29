using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF_PingYuan_Desktop.Models
{
    public class Rack
    {
        public int AreaNo { get; set; }

        public ushort RackNo { get; set; }
        public uint BatchNo { get; set; }

        public byte[] WorkpieceType { get; set; }

        public ushort PrimerColor { get; set; }

        public ushort PrimerFirm { get; set; }

        public ushort PrimerCraft { get; set; }

        public ushort PigmentedCoatingColor { get; set; }

        public ushort PigmentedCoatingFirm { get; set; }

        public ushort PigmentedCoatingCraft { get; set; }

        public ushort VarnishColor { get; set; }

        public ushort VarnishFirm { get; set; }

        public ushort VarnishCraft { get; set; }

        public byte b1 { get; set; }
        public byte b2 { get; set; }
    }
}
