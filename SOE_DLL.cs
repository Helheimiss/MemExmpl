using System.Runtime.InteropServices;

namespace MemExmpl
{
    internal class SOE_DLL
    {
        // for int
        [DllImport("SimpleOffsetExplorerX64.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool ReadMemEx(
            string processName,
            string moduleName,
            uint[] offsets,
            int offsetCount,
            out int outBuffer,
            int size
        );


        [DllImport("SimpleOffsetExplorerX64.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool WriteMemEx(
            string processName,
            string moduleName,
            uint[] offsets,
            int offsetCount,
            ref int newValue,
            int size
        );


        // for float
        [DllImport("SimpleOffsetExplorerX64.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool ReadMemEx(
            string processName,
            string moduleName,
            uint[] offsets,
            int offsetCount,
            out float outBuffer,
            int size
        );


        [DllImport("SimpleOffsetExplorerX64.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool WriteMemEx(
            string processName,
            string moduleName,
            uint[] offsets,
            int offsetCount,
            ref float newValue,
            int size
        );
    }
}
