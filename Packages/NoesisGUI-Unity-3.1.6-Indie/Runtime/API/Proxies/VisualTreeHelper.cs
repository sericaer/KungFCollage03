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
using System.Collections.Generic;

namespace Noesis
{

public static class VisualTreeHelper {
  public static DependencyObject GetRoot(DependencyObject reference) {
    if (reference == null) throw new ArgumentNullException("reference");
    return GetRootHelper(reference);
  }

  public static DependencyObject GetParent(DependencyObject reference) {
    if (reference == null) throw new ArgumentNullException("reference");
    return GetParentHelper(reference);
  }

  public static int GetChildrenCount(DependencyObject reference) {
    if (reference == null) throw new ArgumentNullException("reference");
    return GetChildrenCountHelper(reference);
  }

  public static DependencyObject GetChild(DependencyObject reference, int childIndex) {
    if (reference == null) throw new ArgumentNullException("reference");
    if (childIndex < 0) throw new ArgumentOutOfRangeException("childIndex");
    if (childIndex >= GetChildrenCount(reference)) throw new ArgumentOutOfRangeException("childIndex");
    return GetChildHelper(reference, childIndex);
  }

  public static HitTestResult HitTest(Visual reference, Point point) {
    if (reference == null) throw new ArgumentNullException("reference");
    return HitTestHelper(reference, point);
  }

  public static void HitTest(Visual reference, HitTestFilterCallback filterCallback, HitTestResultCallback resultCallback, HitTestParameters hitTestParameters) {
    if (reference == null) throw new ArgumentNullException("reference");
    PointHitTestParameters pointParams = (PointHitTestParameters)hitTestParameters;
    HitTestCallbackInfo info = new HitTestCallbackInfo { Filter = filterCallback, Result = resultCallback };
    int callbacksId = info.GetHashCode();
    _hitTestCallbacks[callbacksId] = info;
    HitTestCallbackHelper(reference, pointParams.HitPoint, callbacksId, _hitTestFilter, _hitTestResult);
    _hitTestCallbacks.Remove(callbacksId);
  }

  #region HitTest callbacks
  private delegate HitTestFilterBehavior Callback_HitTestFilter(int callbacksId, IntPtr targetPtr);
  private static Callback_HitTestFilter _hitTestFilter = OnHitTestFilter;

  [MonoPInvokeCallback(typeof(Callback_HitTestFilter))]
  private static HitTestFilterBehavior OnHitTestFilter(int callbacksId, IntPtr targetPtr) {
    try {
      HitTestCallbackInfo info = _hitTestCallbacks[callbacksId];
      return info.Filter((Visual)Extend.GetProxy(targetPtr, false));
    }
    catch (Exception e)
    {
      Noesis.Error.UnhandledException(e);
      return HitTestFilterBehavior.Stop;
    }
  }

  private delegate HitTestResultBehavior Callback_HitTestResult(int callbacksId, IntPtr hitPtr);
  private static Callback_HitTestResult _hitTestResult = OnHitTestResult;

  [MonoPInvokeCallback(typeof(Callback_HitTestResult))]
  private static HitTestResultBehavior OnHitTestResult(int callbacksId, IntPtr hitPtr) {
    try {
      HitTestCallbackInfo info = _hitTestCallbacks[callbacksId];
      return info.Result(new HitTestResult(hitPtr, true));
    }
    catch (Exception e)
    {
      Noesis.Error.UnhandledException(e);
      return HitTestResultBehavior.Stop;
    }
  }

  private static void HitTestCallbackHelper(Visual reference, Point point, int callbacksId, Callback_HitTestFilter filter, Callback_HitTestResult result) {
    VisualTreeHelper_HitTestCallback(Visual.getCPtr(reference), ref point, callbacksId, filter, result);
  }

  [DllImport(Library.Name)]
  private static extern void VisualTreeHelper_HitTestCallback(HandleRef reference, ref Point point, int callbacksId, Callback_HitTestFilter filter, Callback_HitTestResult result);

  private struct HitTestCallbackInfo {
    public HitTestFilterCallback Filter { get; set; }
    public HitTestResultCallback Result { get; set; }
  }

  private static Dictionary<int, HitTestCallbackInfo> _hitTestCallbacks = new Dictionary<int, HitTestCallbackInfo>();
  #endregion

  public static Rect GetContentBounds(Visual visual) {
    if (visual == null) throw new ArgumentNullException("visual");
    {
      IntPtr ret = NoesisGUI_PINVOKE.VisualTreeHelper_GetContentBounds(Visual.getCPtr(visual));
      if (ret != IntPtr.Zero) {
        return Marshal.PtrToStructure<Rect>(ret);
      }
      else {
        return new Rect();
      }
    }
  }

  public static Rect GetDescendantBounds(Visual visual) {
    if (visual == null) throw new ArgumentNullException("visual");
    {
      IntPtr ret = NoesisGUI_PINVOKE.VisualTreeHelper_GetDescendantBounds(Visual.getCPtr(visual));
      if (ret != IntPtr.Zero) {
        return Marshal.PtrToStructure<Rect>(ret);
      }
      else {
        return new Rect();
      }
    }
  }

  public static float GetDescendantBoundsMinZ(Visual visual) {
    if (visual == null) throw new ArgumentNullException("visual");
    {
      float ret = NoesisGUI_PINVOKE.VisualTreeHelper_GetDescendantBoundsMinZ(Visual.getCPtr(visual));
      return ret;
    }
  }

  public static float GetDescendantBoundsMaxZ(Visual visual) {
    if (visual == null) throw new ArgumentNullException("visual");
    {
      float ret = NoesisGUI_PINVOKE.VisualTreeHelper_GetDescendantBoundsMaxZ(Visual.getCPtr(visual));
      return ret;
    }
  }

  public static Point GetOffset(Visual visual) {
    if (visual == null) throw new ArgumentNullException("visual");
    {
      IntPtr ret = NoesisGUI_PINVOKE.VisualTreeHelper_GetOffset(Visual.getCPtr(visual));
      if (ret != IntPtr.Zero) {
        return Marshal.PtrToStructure<Point>(ret);
      }
      else {
        return new Point();
      }
    }
  }

  public static Size GetSize(Visual visual) {
    if (visual == null) throw new ArgumentNullException("visual");
    {
      IntPtr ret = NoesisGUI_PINVOKE.VisualTreeHelper_GetSize(Visual.getCPtr(visual));
      if (ret != IntPtr.Zero) {
        return Marshal.PtrToStructure<Size>(ret);
      }
      else {
        return new Size();
      }
    }
  }

  public static Geometry GetClip(Visual visual) {
    if (visual == null) throw new ArgumentNullException("visual");
    {
      IntPtr cPtr = NoesisGUI_PINVOKE.VisualTreeHelper_GetClip(Visual.getCPtr(visual));
      return (Geometry)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  private static DependencyObject GetRootHelper(DependencyObject reference) {
    IntPtr cPtr = NoesisGUI_PINVOKE.VisualTreeHelper_GetRootHelper(DependencyObject.getCPtr(reference));
    return (DependencyObject)Noesis.Extend.GetProxy(cPtr, false);
  }

  private static DependencyObject GetParentHelper(DependencyObject reference) {
    IntPtr cPtr = NoesisGUI_PINVOKE.VisualTreeHelper_GetParentHelper(DependencyObject.getCPtr(reference));
    return (DependencyObject)Noesis.Extend.GetProxy(cPtr, false);
  }

  private static int GetChildrenCountHelper(DependencyObject reference) {
    int ret = NoesisGUI_PINVOKE.VisualTreeHelper_GetChildrenCountHelper(DependencyObject.getCPtr(reference));
    return ret;
  }

  private static DependencyObject GetChildHelper(DependencyObject reference, int childIndex) {
    IntPtr cPtr = NoesisGUI_PINVOKE.VisualTreeHelper_GetChildHelper(DependencyObject.getCPtr(reference), childIndex);
    return (DependencyObject)Noesis.Extend.GetProxy(cPtr, false);
  }

  private static HitTestResult HitTestHelper(Visual reference, Point point) {
    HitTestResult ret = new HitTestResult(NoesisGUI_PINVOKE.VisualTreeHelper_HitTestHelper(Visual.getCPtr(reference), ref point), true);
    return ret;
  }

}

}
