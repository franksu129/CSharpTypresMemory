namespace StackAndHeap;

public static class IntPtrExtension
{
    public static string FormatToMemberAddress(this IntPtr ptr)
        => string.Format("0x{0:X16}", (long)ptr);
}