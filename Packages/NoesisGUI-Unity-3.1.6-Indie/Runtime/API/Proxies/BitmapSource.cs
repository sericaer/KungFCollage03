//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


using System;
using System.Runtime.InteropServices;

namespace Noesis
{

public class BitmapSource : ImageSource {
  internal new static BitmapSource CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new BitmapSource(cPtr, cMemoryOwn);
  }

  internal BitmapSource(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(BitmapSource obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  protected BitmapSource() {
  }

  /// <summary>
  /// Create a BitmapSource from an array of pixels.
  /// </summary>
  public static BitmapSource Create(int pixelWidth, int pixelHeight, double dpiX, double dpiY, byte[] pixels, int stride, Format format) {
    IntPtr cPtr = CreateHelper(pixelWidth, pixelHeight, (float)dpiX, (float)dpiY, pixels, stride, (uint)format);
    return (BitmapSource)Noesis.Extend.GetProxy(cPtr, true);
  }

  /// <summary>
  /// Copy the pixel data from the bitmap into the array of pixels that
  /// has the specified stride and offset
  public void CopyPixels(byte[] pixels, int stride, int offset) {
    if (stride <= 0)
      throw new ArgumentOutOfRangeException("stride");
    if (offset < 0)
      throw new ArgumentOutOfRangeException("offset");
    if (pixels == null)
      throw new ArgumentNullException("pixels");

    CopyPixelsHelper(pixels, (uint)pixels.Length, stride, offset);
  }

  public BitmapSource.Format GetFormat() {
    BitmapSource.Format ret = (BitmapSource.Format)NoesisGUI_PINVOKE.BitmapSource_GetFormat(swigCPtr);
    return ret;
  }

  public float DpiX {
    get {
      float ret = NoesisGUI_PINVOKE.BitmapSource_DpiX_get(swigCPtr);
      return ret;
    } 
  }

  public float DpiY {
    get {
      float ret = NoesisGUI_PINVOKE.BitmapSource_DpiY_get(swigCPtr);
      return ret;
    } 
  }

  public int PixelWidth {
    get {
      int ret = NoesisGUI_PINVOKE.BitmapSource_PixelWidth_get(swigCPtr);
      return ret;
    } 
  }

  public int PixelHeight {
    get {
      int ret = NoesisGUI_PINVOKE.BitmapSource_PixelHeight_get(swigCPtr);
      return ret;
    } 
  }

  private static IntPtr CreateHelper(int pixelWidth, int pixelHeight, float dpiX, float dpiY, byte[] buffer, int stride, uint format) {
    IntPtr ret = NoesisGUI_PINVOKE.BitmapSource_CreateHelper(pixelWidth, pixelHeight, dpiX, dpiY, buffer, stride, format);
    return ret;
  }

  private void CopyPixelsHelper(byte[] buffer, uint bufferSize, int stride, int offset) {
    NoesisGUI_PINVOKE.BitmapSource_CopyPixelsHelper(swigCPtr, buffer, bufferSize, stride, offset);
  }

  public enum Format {
    BGRA8,
    BGR8,
    RGBA8,
    RGB8
  }

}

}

