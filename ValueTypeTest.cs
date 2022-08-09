using StackAndHeap;

namespace CSharpTypresMemory;

/// <summary>
/// 固定使用char來做測試
/// </summary>
public unsafe class ValueTypeTest
{
    /// <summary>
    /// 記憶體測試
    /// </summary>
    public static void MemoryAddressView()
    {
        char c = 'X';
        char* cp = &c;
        IntPtr TypePtr = (IntPtr)cp;

        Console.WriteLine($"Address of Type : {TypePtr.FormatToMemberAddress()}");
    }

    /// <summary>
    /// 複製測試
    /// </summary>
    public static void Duplicate()
{
        char c0 = 'A';
        char c1 = c0;
        char* c0p = &c0;
        char* c1p = &c1;

        // 檢視記憶體
        IntPtr TypePtr0 = (IntPtr)c0p;
        IntPtr TypePtr1 = (IntPtr)c1p;

        Console.WriteLine($"Address of `TypePtr0` : {TypePtr0.FormatToMemberAddress()}");
        Console.WriteLine($"Address of `TypePtr1` : {TypePtr1.FormatToMemberAddress()}");
    }
}