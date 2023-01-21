namespace GameOffsets.Objects.Components
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct ModHeader
    {
        [FieldOffset(0x38)] public int Modifier;
    }
}
