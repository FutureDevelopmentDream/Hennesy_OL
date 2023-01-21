namespace GameOffsets.Objects.Components
{
    using System;
    using System.Collections.Concurrent;
    using System.Runtime.InteropServices;
    using Natives;

    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct ObjectMagicPropertiesOffsets
    {
        [FieldOffset(0x00)] public ComponentHeader Header;
        [FieldOffset(0x13C)] public int Rarity;
    }
    /*[StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct ArchnemesisModPropertyOffsets
    {
        [FieldOffset(0x28)] public IntPtr Header;
        [FieldOffset(0x42)] public StdWString Name;

        public override string ToString()
        {
            return $"{Name}";
        }
    }*/
    
}