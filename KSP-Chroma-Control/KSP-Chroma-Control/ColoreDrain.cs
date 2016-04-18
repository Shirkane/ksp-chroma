﻿using System;
using KSP_Chroma_Control.ColorSchemes;
using System.Collections.Generic;
using Corale.Colore.Razer.Keyboard;
using UnityEngine;

namespace KSP_Chroma_Control
{
    internal class ColoreDrain : DataDrain
    {
        /*
        private static Dictionary<string, Key> translate = new Dictionary<string, Key>()
        {
            {"esc", Key.Escape },
            { "f1", Key.F1 },
            { "f2", Key.F2 },
            { "f3", Key.F3 },
            { "f4", Key.F4 },
            { "f5", Key.F5 },
            { "f6", Key.F6 },
            { "f7", Key.F7 },
            { "f8", Key.F8 },
            { "f9", Key.F9 },
            { "f10", Key.F10 },
            { "f11", Key.F11 },
            { "f12", Key.F12 },
            { "prtsc", Key.PrintScreen },
            { "scrlk", Key.Scroll },
            { "break", Key.Pause },
            {"`", Key.OemTilde },
            { "1", Key.D1 },
            { "2", Key.D2 },
            { "3", Key.D3 },
            { "4", Key.D4 },
            { "5", Key.D5 },
            { "6", Key.D6 },
            { "7", Key.D7 },
            { "8", Key.D8 },
            { "9", Key.D9 },
            { "0", Key.D0 },
            { "-", Key.OemMinus },
            { "=", Key.OemEquals },
            { "backspace", Key.Backspace },
            { "ins", Key.Insert },
            { "home", Key.Home },
            { "pageup", Key.PageUp },
            {"tab", Key.Tab },
            { "q", Key.Q },
            { "w", Key.W },
            { "e", Key.E },
            { "r", Key.R },
            { "t", Key.T },
            { "y", Key.Y },
            { "u", Key.U },
            { "i", Key.I },
            { "o", Key.O },
            { "p", Key.P },
            { "[", Key.OemLeftBracket },
            { "]", Key.OemRightBracket },
            { "enter", Key.Enter },
            { "del", Key.Delete },
            { "end", Key.End },
            { "pagedown", Key.PageDown },
            {"capslock", Key.CapsLock },
            { "a", Key.A },
            { "s", Key.S },
            {"d", Key.D },
            {"f", Key.F },
            {"g", Key.G },
            {"h", Key.H },
            {"j", Key.J },
            {"k", Key.K },
            {"l", Key.L },
            {";", Key.OemSemicolon },
            {"'", Key.OemApostrophe },
            {"hash", Key.EurPound },
            {"leftshift", Key.LeftShift },
            {"backslash", Key.EurBackslash },
            {"z", Key.Z },
            {"x", Key.X },
            {"c", Key.C },
            {"v", Key.V },
            {"b", Key.B },
            {"n", Key.N },
            {"m", Key.M },
            {",", Key.OemComma },
            {".", Key.OemPeriod },
            {"slash", Key.OemSlash },
            {"rightshift", Key.RightShift },
            {"up", Key.Up },
            {"leftctrl", Key.LeftControl },
            {"windows", Key.LeftWindows },
            {"alt", Key.LeftAlt },
            {"space", Key.Space },
            {"altgr", Key.RightAlt },
            {"fn", Key.Function },
            {"contextmenu", Key.RightMenu },
            {"rightctrl", Key.RightControl },
            {"left", Key.Left },
            {"down", Key.Down },
            {"right", Key.Right },

            /// Numpad
            {"numlk", Key.NumLock },
            {"num/", Key.NumDivide },
            {"num*", Key.NumMultiply },
            {"num-", Key.NumSubtract },
            {"num7", Key.Num7 },
            {"num8", Key.Num8 },
            {"num9", Key.Num9 },
            {"num+", Key.NumAdd },
            {"num4", Key.Num4 },
            {"num5", Key.Num5 },
            {"num6", Key.Num6 },
            {"num1", Key.Num1 },
            {"num2", Key.Num2 },
            {"num3", Key.Num3 },
            {"numenter", Key.NumEnter },
            {"num0", Key.Num0 },
            {"num.", Key.NumDecimal },

            /// Macro keys
            {"m1", Key.Macro1 },
            {"m2", Key.Macro2 },
            {"m3", Key.Macro3 },
            {"m4", Key.Macro4 },
            {"m5", Key.Macro5 }
        };*/

        public void send(ColorScheme scheme)
        {
            applyToKeyboard(scheme);
        }

        /// <summary>
        /// Applies the color scheme to the keyboard.
        /// </summary>
        /// <param name="colorScheme">The color scheme to apply.</param>
        private void applyToKeyboard(ColorScheme colorScheme)
        {
            foreach (KeyValuePair<Key, Color> entry in colorScheme)
            {
                try { 
                    Corale.Colore.Core.Keyboard.Instance.SetKey(entry.Key, entry.Value);
                } catch (ArgumentOutOfRangeException ex)
                {
                    //Debug.LogError("Key was: " + entry.Key.ToString());
                }
            }
        }
    }
}