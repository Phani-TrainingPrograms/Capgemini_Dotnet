using System;
/*
 * DLLs are not exes. They cannot execute. 
 * We shall refer this dll  in another Exe and run the code in that EXE. 
 * Classes created in the DLL are usually public. 
 */

namespace SampleDataLib
{
    public class MyDllClass
    {
        public string GreetUser(string name) => $"Welcome Mr./ms.{name}";
    }
}
