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

public sealed class StringAnimationUsingKeyFrames : StringAnimationBase {
  internal new static StringAnimationUsingKeyFrames CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new StringAnimationUsingKeyFrames(cPtr, cMemoryOwn);
  }

  internal StringAnimationUsingKeyFrames(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(StringAnimationUsingKeyFrames obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  protected internal override string GetCurrentValueCore(string defaultOriginValue, string defaultDestinationValue, AnimationClock animationClock) {
    return GetCurrentValueCoreHelper(defaultOriginValue, defaultDestinationValue, animationClock);
  }

  public StringAnimationUsingKeyFrames() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_StringAnimationUsingKeyFrames();
  }

  public StringKeyFrameCollection KeyFrames {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.StringAnimationUsingKeyFrames_KeyFrames_get(swigCPtr);
      return (StringKeyFrameCollection)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  private string GetCurrentValueCoreHelper(string src, string dst, AnimationClock clock) {
    IntPtr strPtr = NoesisGUI_PINVOKE.StringAnimationUsingKeyFrames_GetCurrentValueCoreHelper(swigCPtr, src != null ? src : string.Empty, dst != null ? dst : string.Empty, AnimationClock.getCPtr(clock));
    string str = Noesis.Extend.StringFromNativeUtf8(strPtr);
    NoesisGUI_PINVOKE.FreeString(strPtr);
    return str;
  }

}

}

