using System;

namespace XF_LoginActivity
{
    internal class BtnLogin
    {
        public static Action<object, EventArgs> Clicked { get; internal set; }
    }
}