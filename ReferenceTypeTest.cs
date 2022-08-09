using StackAndHeap;

namespace CSharpTypresMemory;

public unsafe class ReferenceTypeTest
{
    /// <summary>
    /// 記憶體測試
    /// </summary>
    public static void MemoryAddressView()
    {
        string Str = "X";

        // 取得 TypeReferences
        TypedReference tr = __makeref(Str);

        // Type pointer
        IntPtr TypePtr = *(IntPtr*)(&tr);
        // Ref pointer
        IntPtr RefPtr = **(IntPtr**)(&tr);

        Console.WriteLine($"Address of Type : {TypePtr.FormatToMemberAddress()}");
        Console.WriteLine($"Address of Ref : {RefPtr.FormatToMemberAddress()}");
    }

    /// <summary>
    /// 複製測試
    /// </summary>
    public static void Duplicate()
    {
        string Str0 = "X";
        string Str1 = Str0;

        // 取得 TypeReferences
        TypedReference tr0 = __makeref(Str0);
        TypedReference tr1 = __makeref(Str1);

        // Type pointer
        IntPtr TypePtr0 = *(IntPtr*)(&tr0);
        IntPtr TypePtr1 = *(IntPtr*)(&tr1);

        // Ref pointer
        IntPtr RefPtr0 = **(IntPtr**)(&tr0);
        IntPtr RefPtr1 = **(IntPtr**)(&tr1);

        Console.WriteLine($"Address of Type0 : {TypePtr0.FormatToMemberAddress()}");
        Console.WriteLine($"Address of Ref0 : {RefPtr0.FormatToMemberAddress()}");

        Console.WriteLine($"Address of Type1 : {TypePtr1.FormatToMemberAddress()}");
        Console.WriteLine($"Address of Ref1 : {RefPtr1.FormatToMemberAddress()}");
    }
}