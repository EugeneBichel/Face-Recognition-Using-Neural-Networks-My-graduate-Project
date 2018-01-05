﻿using System;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Windows.Forms;

namespace Utility
{
    public static class ResizingWindow
    {
        #region public methods

        public static void Maximize(string name)
        {
            ResizeWindow(name);
        }

        public static void SetPositionSize(string name, int x, int y, int width, int height)
        {
            IntPtr hWind = NativeMethods.FindWindow(null, name);
            NativeMethods.WINDOWINFO info = new NativeMethods.WINDOWINFO();
            info.cbSize = (uint)Marshal.SizeOf(info);
            NativeMethods.GetWindowInfo(hWind, ref info);
            do
            {
                NativeMethods.SetWindowPos(hWind, (IntPtr)null, x, y, width, height, 0u);

                info.cbSize = (uint)Marshal.SizeOf(info);
                NativeMethods.GetWindowInfo(hWind, ref info);

            } while (info.rcWindow.Size.Height != height && info.rcWindow.Location.Y != y);
        }
        public static void SetPosition(string name, int x, int y)
        {
            IntPtr hWind = NativeMethods.FindWindow(null, name);
            NativeMethods.WINDOWINFO info = new NativeMethods.WINDOWINFO();
            info.cbSize = (uint)Marshal.SizeOf(info);
            NativeMethods.GetWindowInfo(hWind, ref info);

            NativeMethods.SetWindowPos(hWind, (IntPtr)null, x, y, info.rcWindow.Size.Width, info.rcWindow.Size.Height, 0u);
        }

        #endregion

        #region Private Methods

        private static void SetPositionWindow(string name)
        {
            Rectangle scBounds = GetResolutionOfTheScreen();
            ResizingWindow.SetPosition(name, scBounds.X + 10, scBounds.Y + 10);
        }
        /// <summary>
        /// Resize of application window
        /// </summary>
        private static void ResizeWindow(string name)
        {
            Rectangle scBounds = GetResolutionOfTheScreen();
            ResizingWindow.SetPositionSize(name, scBounds.X + 10, scBounds.Y + 10,
                scBounds.Width - 20, scBounds.Height - 20);
        }
        /// <summary>
        /// Get coordinated and size of active screen.
        /// </summary>
        /// <returns>coordinates and size</returns>
        private static Rectangle GetResolutionOfTheScreen()
        {
            return Screen.PrimaryScreen.WorkingArea;
        }

        #endregion //Private Methods

        private class NativeMethods
        {
            #region Structs

            [StructLayout(LayoutKind.Sequential)]
            public struct WINDOWINFO
            {
                public uint cbSize;
                public RECT rcWindow;
                public RECT rcClient;
                public uint dwStyle;
                public uint dwExStyle;
                public uint dwWindowStatus;
                public uint cxWindowBorders;
                public uint cyWindowBorders;
                public ushort atomWindowType;
                public ushort wCreatorVersion;

                public WINDOWINFO(Boolean? filler)
                    : this()   // Allows automatic initialization of "cbSize" with "new WINDOWINFO(null/true/false)".
                {
                    cbSize = (UInt32)(Marshal.SizeOf(typeof(WINDOWINFO)));
                }

            }

            [StructLayout(LayoutKind.Sequential)]
            public struct RECT
            {
                private int _Left;
                private int _Top;
                private int _Right;
                private int _Bottom;

                public RECT(Rectangle Rectangle)
                    : this(Rectangle.Left, Rectangle.Top, Rectangle.Right, Rectangle.Bottom)
                {
                }
                public RECT(int Left, int Top, int Right, int Bottom)
                {
                    _Left = Left;
                    _Top = Top;
                    _Right = Right;
                    _Bottom = Bottom;
                }

                public int X
                {
                    get { return _Left; }
                    set { _Left = value; }
                }
                public int Y
                {
                    get { return _Top; }
                    set { _Top = value; }
                }
                public int Left
                {
                    get { return _Left; }
                    set { _Left = value; }
                }
                public int Top
                {
                    get { return _Top; }
                    set { _Top = value; }
                }
                public int Right
                {
                    get { return _Right; }
                    set { _Right = value; }
                }
                public int Bottom
                {
                    get { return _Bottom; }
                    set { _Bottom = value; }
                }
                public int Height
                {
                    get { return _Bottom - _Top; }
                    set { _Bottom = value - _Top; }
                }
                public int Width
                {
                    get { return _Right - _Left; }
                    set { _Right = value + _Left; }
                }
                public Point Location
                {
                    get { return new Point(Left, Top); }
                    set
                    {
                        _Left = value.X;
                        _Top = value.Y;
                    }
                }
                public Size Size
                {
                    get { return new Size(Width, Height); }
                    set
                    {
                        _Right = value.Width + _Left;
                        _Bottom = value.Height + _Top;
                    }
                }

                public static implicit operator Rectangle(RECT Rectangle)
                {
                    return new Rectangle(Rectangle.Left, Rectangle.Top, Rectangle.Width, Rectangle.Height);
                }
                public static implicit operator RECT(Rectangle Rectangle)
                {
                    return new RECT(Rectangle.Left, Rectangle.Top, Rectangle.Right, Rectangle.Bottom);
                }
                public static bool operator ==(RECT Rectangle1, RECT Rectangle2)
                {
                    return Rectangle1.Equals(Rectangle2);
                }
                public static bool operator !=(RECT Rectangle1, RECT Rectangle2)
                {
                    return !Rectangle1.Equals(Rectangle2);
                }

                public override string ToString()
                {
                    return "{Left: " + _Left + "; " + "Top: " + _Top + "; Right: " + _Right + "; Bottom: " + _Bottom + "}";
                }

                public override int GetHashCode()
                {
                    return ToString().GetHashCode();
                }

                public bool Equals(RECT Rectangle)
                {
                    return Rectangle.Left == _Left && Rectangle.Top == _Top && Rectangle.Right == _Right && Rectangle.Bottom == _Bottom;
                }

                public override bool Equals(object Object)
                {
                    if (Object is RECT)
                    {
                        return Equals((RECT)Object);
                    }
                    else if (Object is Rectangle)
                    {
                        return Equals(new RECT((Rectangle)Object));
                    }

                    return false;
                }
            }

            #endregion

            #region public static extern methods

            [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

            [DllImport(@"user32.dll", EntryPoint = "SetWindowPos", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
            public static extern int SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

            [return: MarshalAs(UnmanagedType.Bool)]
            [DllImport("user32.dll", SetLastError = true)]
            public static extern bool GetWindowInfo(IntPtr hwnd, ref WINDOWINFO pwi);

            #endregion
        }
    }
}