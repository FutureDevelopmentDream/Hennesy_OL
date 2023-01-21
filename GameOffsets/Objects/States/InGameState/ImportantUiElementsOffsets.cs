namespace GameOffsets.Objects.States.InGameState
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    ///     All offsets over here are UiElements.
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct ImportantUiElementsOffsets
    {
        [FieldOffset(0x688)] public IntPtr MapParentPtr;//670
    }

    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct MapParentStruct
    {
        [FieldOffset(0x278)] public IntPtr LargeMapPtr;
        [FieldOffset(0x280)] public IntPtr MiniMapPtr;
    }
    /*
    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct MPS1
    {
        [FieldOffset(0x30)] public IntPtr Off;
    }
    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct MPS2
    {
        [FieldOffset(0x18)] public IntPtr Off;
    }
    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct MPS3
    {
        [FieldOffset(0x0)] public IntPtr Off;
    }*/
}
