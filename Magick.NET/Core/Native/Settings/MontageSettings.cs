//=================================================================================================
// Copyright 2013-2016 Dirk Lemstra <https://magick.codeplex.com/>
//
// Licensed under the ImageMagick License (the "License"); you may not use this file except in
// compliance with the License. You may obtain a copy of the License at
//
//   http://www.imagemagick.org/script/license.php
//
// Unless required by applicable law or agreed to in writing, software distributed under the
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
// express or implied. See the License for the specific language governing permissions and
// limitations under the License.
//=================================================================================================

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

#if Q8
using QuantumType = System.Byte;
#elif Q16
using QuantumType = System.UInt16;
#elif Q16HDRI
using QuantumType = System.Single;
#else
#error Not implemented!
#endif

namespace ImageMagick
{
  public partial class MontageSettings
  {
    private static class NativeMethods
    {
      public static class X64
      {
        [SuppressMessage("Microsoft.Performance", "CA1810: InitializeReferenceTypeStaticFieldsInline", Scope = "member", Target = "ImageMagick.MontageSettings+NativeMethods.X64#.cctor()")]
        static X64() { NativeLibraryLoader.Load(); }
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr MontageSettings_Create();
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MontageSettings_Dispose(IntPtr instance);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MontageSettings_SetBackgroundColor(IntPtr Instance, IntPtr value);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MontageSettings_SetBorderColor(IntPtr Instance, IntPtr value);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MontageSettings_SetBorderWidth(IntPtr Instance, UIntPtr value);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MontageSettings_SetFillColor(IntPtr Instance, IntPtr value);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MontageSettings_SetFont(IntPtr Instance, IntPtr value);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MontageSettings_SetFontPointsize(IntPtr Instance, double value);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MontageSettings_SetFrameGeometry(IntPtr Instance, IntPtr value);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MontageSettings_SetGeometry(IntPtr Instance, IntPtr value);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MontageSettings_SetGravity(IntPtr Instance, UIntPtr value);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MontageSettings_SetShadow(IntPtr Instance, [MarshalAs(UnmanagedType.Bool)] bool value);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MontageSettings_SetStrokeColor(IntPtr Instance, IntPtr value);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MontageSettings_SetTextureFileName(IntPtr Instance, IntPtr value);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MontageSettings_SetTileGeometry(IntPtr Instance, IntPtr value);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MontageSettings_SetTitle(IntPtr Instance, IntPtr value);
      }
      public static class X86
      {
        [SuppressMessage("Microsoft.Performance", "CA1810: InitializeReferenceTypeStaticFieldsInline", Scope = "member", Target = "ImageMagick.MontageSettings+NativeMethods.X86#.cctor()")]
        static X86() { NativeLibraryLoader.Load(); }
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr MontageSettings_Create();
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MontageSettings_Dispose(IntPtr instance);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MontageSettings_SetBackgroundColor(IntPtr Instance, IntPtr value);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MontageSettings_SetBorderColor(IntPtr Instance, IntPtr value);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MontageSettings_SetBorderWidth(IntPtr Instance, UIntPtr value);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MontageSettings_SetFillColor(IntPtr Instance, IntPtr value);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MontageSettings_SetFont(IntPtr Instance, IntPtr value);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MontageSettings_SetFontPointsize(IntPtr Instance, double value);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MontageSettings_SetFrameGeometry(IntPtr Instance, IntPtr value);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MontageSettings_SetGeometry(IntPtr Instance, IntPtr value);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MontageSettings_SetGravity(IntPtr Instance, UIntPtr value);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MontageSettings_SetShadow(IntPtr Instance, [MarshalAs(UnmanagedType.Bool)] bool value);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MontageSettings_SetStrokeColor(IntPtr Instance, IntPtr value);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MontageSettings_SetTextureFileName(IntPtr Instance, IntPtr value);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MontageSettings_SetTileGeometry(IntPtr Instance, IntPtr value);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MontageSettings_SetTitle(IntPtr Instance, IntPtr value);
      }
    }
    private sealed class NativeMontageSettings : NativeInstance
    {
      private IntPtr _Instance = IntPtr.Zero;
      protected override void Dispose(IntPtr instance)
      {
        DisposeInstance(instance);
      }
      public static void DisposeInstance(IntPtr instance)
      {
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.MontageSettings_Dispose(instance);
        else
          NativeMethods.X86.MontageSettings_Dispose(instance);
      }
      public NativeMontageSettings()
      {
        if (NativeLibrary.Is64Bit)
          _Instance = NativeMethods.X64.MontageSettings_Create();
        else
          _Instance = NativeMethods.X86.MontageSettings_Create();
        if (_Instance == IntPtr.Zero)
          throw new InvalidOperationException();
      }
      public override IntPtr Instance
      {
        get
        {
          if (_Instance == IntPtr.Zero)
            throw new ObjectDisposedException(typeof(MontageSettings).ToString());
          return _Instance;
        }
        set
        {
          if (_Instance != IntPtr.Zero)
            Dispose(_Instance);
          _Instance = value;
        }
      }
      public void SetBackgroundColor(MagickColor value)
      {
        using (INativeInstance valueNative = MagickColor.CreateInstance(value))
        {
          if (NativeLibrary.Is64Bit)
            NativeMethods.X64.MontageSettings_SetBackgroundColor(Instance, valueNative.Instance);
          else
            NativeMethods.X86.MontageSettings_SetBackgroundColor(Instance, valueNative.Instance);
        }
      }
      public void SetBorderColor(MagickColor value)
      {
        using (INativeInstance valueNative = MagickColor.CreateInstance(value))
        {
          if (NativeLibrary.Is64Bit)
            NativeMethods.X64.MontageSettings_SetBorderColor(Instance, valueNative.Instance);
          else
            NativeMethods.X86.MontageSettings_SetBorderColor(Instance, valueNative.Instance);
        }
      }
      public void SetBorderWidth(int value)
      {
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.MontageSettings_SetBorderWidth(Instance, (UIntPtr)value);
        else
          NativeMethods.X86.MontageSettings_SetBorderWidth(Instance, (UIntPtr)value);
      }
      public void SetFillColor(MagickColor value)
      {
        using (INativeInstance valueNative = MagickColor.CreateInstance(value))
        {
          if (NativeLibrary.Is64Bit)
            NativeMethods.X64.MontageSettings_SetFillColor(Instance, valueNative.Instance);
          else
            NativeMethods.X86.MontageSettings_SetFillColor(Instance, valueNative.Instance);
        }
      }
      public void SetFont(string value)
      {
        using (INativeInstance valueNative = UTF8Marshaler.CreateInstance(value))
        {
          if (NativeLibrary.Is64Bit)
            NativeMethods.X64.MontageSettings_SetFont(Instance, valueNative.Instance);
          else
            NativeMethods.X86.MontageSettings_SetFont(Instance, valueNative.Instance);
        }
      }
      public void SetFontPointsize(double value)
      {
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.MontageSettings_SetFontPointsize(Instance, value);
        else
          NativeMethods.X86.MontageSettings_SetFontPointsize(Instance, value);
      }
      public void SetFrameGeometry(string value)
      {
        using (INativeInstance valueNative = UTF8Marshaler.CreateInstance(value))
        {
          if (NativeLibrary.Is64Bit)
            NativeMethods.X64.MontageSettings_SetFrameGeometry(Instance, valueNative.Instance);
          else
            NativeMethods.X86.MontageSettings_SetFrameGeometry(Instance, valueNative.Instance);
        }
      }
      public void SetGeometry(string value)
      {
        using (INativeInstance valueNative = UTF8Marshaler.CreateInstance(value))
        {
          if (NativeLibrary.Is64Bit)
            NativeMethods.X64.MontageSettings_SetGeometry(Instance, valueNative.Instance);
          else
            NativeMethods.X86.MontageSettings_SetGeometry(Instance, valueNative.Instance);
        }
      }
      public void SetGravity(Gravity value)
      {
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.MontageSettings_SetGravity(Instance, (UIntPtr)value);
        else
          NativeMethods.X86.MontageSettings_SetGravity(Instance, (UIntPtr)value);
      }
      public void SetShadow(bool value)
      {
        if (NativeLibrary.Is64Bit)
          NativeMethods.X64.MontageSettings_SetShadow(Instance, value);
        else
          NativeMethods.X86.MontageSettings_SetShadow(Instance, value);
      }
      public void SetStrokeColor(MagickColor value)
      {
        using (INativeInstance valueNative = MagickColor.CreateInstance(value))
        {
          if (NativeLibrary.Is64Bit)
            NativeMethods.X64.MontageSettings_SetStrokeColor(Instance, valueNative.Instance);
          else
            NativeMethods.X86.MontageSettings_SetStrokeColor(Instance, valueNative.Instance);
        }
      }
      public void SetTextureFileName(string value)
      {
        using (INativeInstance valueNative = UTF8Marshaler.CreateInstance(value))
        {
          if (NativeLibrary.Is64Bit)
            NativeMethods.X64.MontageSettings_SetTextureFileName(Instance, valueNative.Instance);
          else
            NativeMethods.X86.MontageSettings_SetTextureFileName(Instance, valueNative.Instance);
        }
      }
      public void SetTileGeometry(string value)
      {
        using (INativeInstance valueNative = UTF8Marshaler.CreateInstance(value))
        {
          if (NativeLibrary.Is64Bit)
            NativeMethods.X64.MontageSettings_SetTileGeometry(Instance, valueNative.Instance);
          else
            NativeMethods.X86.MontageSettings_SetTileGeometry(Instance, valueNative.Instance);
        }
      }
      public void SetTitle(string value)
      {
        using (INativeInstance valueNative = UTF8Marshaler.CreateInstance(value))
        {
          if (NativeLibrary.Is64Bit)
            NativeMethods.X64.MontageSettings_SetTitle(Instance, valueNative.Instance);
          else
            NativeMethods.X86.MontageSettings_SetTitle(Instance, valueNative.Instance);
        }
      }
    }
    internal static INativeInstance CreateInstance(MontageSettings instance)
    {
      if (instance == null)
        return NativeInstance.Zero;
      return instance.CreateNativeInstance();
    }
  }
}
