using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XD_and_Colosseum_RNG_Tool
{
    class xdRNG
    {
        private uint seed;
        private readonly string[] natures = { "Hardy", "Lonely", "Brave", "Adamant", "Naughty",
                                              "Bold", "Docile", "Relaxed", "Impish", "Lax",
                                              "Timid", "Hasty", "Serious", "Jolly", "Naive",
                                              "Modest", "Mild", "Quiet", "Bashful", "Rash",
                                              "Calm", "Gentle", "Sassy", "Careful", "Quirky"};

        // Constructor for seed
        public xdRNG(uint seed) { this.seed = seed; }
        public void advanceXD() { seed = (seed * 0x343fd) + 0x269ec3; }
        public void reverseXD() { seed = (seed * 0xb9b33155) + 0xa170f641; }

        // Shows seed on -frames from seed input
        public ushort previewHalfReverse(uint startSeed, int frames)
        {
            for (int i = 0; i < frames; i++)
                startSeed = ((startSeed * 0xb9b33155) + 0xa170f641) & 0xFFFFFFFF;
            return (ushort)(startSeed >> 16);
        }

        // Shows seed on +frames from seed input
        public ushort previewHalfAdvance(uint startSeed, int frames)
        {
            for (int i = 0; i < frames; i++)
                startSeed = ((startSeed * 0x000343fd) + 0x00269ec3) & 0xFFFFFFFF;
            return (ushort)(startSeed >> 16);
        }

        public uint getPID() // Grab XD PID
        {
            return (uint)((previewHalfAdvance(seed, 3) << 16) + (previewHalfAdvance(seed, 4)));
        }

        public string getNature(uint pid) { return natures[(byte)(pid % 25)]; }

        public uint getSeed() { return seed; }
    }
}

/* In progress
    class XdRng : GenericRng
    {
        public XdRng(uint seed) : base(seed, 0x343FD, 0x269EC3) {}
    }

    class XdRngR : GenericRng
    {
        public XdRngR(uint seed) : base(seed, 0xB9B33155, 0xA170F641) {}
    }
*/
