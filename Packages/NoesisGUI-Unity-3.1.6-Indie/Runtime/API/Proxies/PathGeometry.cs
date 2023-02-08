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

public class PathGeometry : Geometry {
  internal new static PathGeometry CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new PathGeometry(cPtr, cMemoryOwn);
  }

  internal PathGeometry(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(PathGeometry obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public override string ToString() {
    return ToStringHelper();
  }

  public PathGeometry() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_PathGeometry();
  }

  public override bool IsEmpty() {
    bool ret = NoesisGUI_PINVOKE.PathGeometry_IsEmpty(swigCPtr);
    return ret;
  }

  public static DependencyProperty FiguresProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.PathGeometry_FiguresProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty FillRuleProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.PathGeometry_FillRuleProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public PathFigureCollection Figures {
    set {
      NoesisGUI_PINVOKE.PathGeometry_Figures_set(swigCPtr, PathFigureCollection.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.PathGeometry_Figures_get(swigCPtr);
      return (PathFigureCollection)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public FillRule FillRule {
    set {
      NoesisGUI_PINVOKE.PathGeometry_FillRule_set(swigCPtr, (int)value);
    } 
    get {
      FillRule ret = (FillRule)NoesisGUI_PINVOKE.PathGeometry_FillRule_get(swigCPtr);
      return ret;
    } 
  }

  private string ToStringHelper() {
    IntPtr strPtr = NoesisGUI_PINVOKE.PathGeometry_ToStringHelper(swigCPtr);
    string str = Noesis.Extend.StringFromNativeUtf8(strPtr);
    NoesisGUI_PINVOKE.FreeString(strPtr);
    return str;
  }

}

}

