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
using System.Collections;

namespace Noesis
{

public static class LogicalTreeHelper {
  public static DependencyObject GetParent(DependencyObject current) {
    if (current == null) throw new ArgumentNullException("current");
    return GetParentHelper(current);
  }

  public static IEnumerable GetChildren(DependencyObject current) {
    if (current == null) throw new ArgumentNullException("current");
    return new ChildrenEnumerable(current);
  }

  public static DependencyObject FindLogicalNode(DependencyObject current, string name) {
    if (current == null) throw new ArgumentNullException("current");
    IntPtr cPtr = FindLogicalNodeHelper(current, name);
    return (DependencyObject)Noesis.Extend.GetProxy(cPtr, true);
  }

  private struct ChildrenEnumerable : IEnumerable {
    public ChildrenEnumerable(DependencyObject parent) {
      this._parent = parent;
    }

    IEnumerator IEnumerable.GetEnumerator() {
      return new Enumerator(this._parent);
    }

    private struct Enumerator : IEnumerator {
      object IEnumerator.Current {
        get { return this.Current; }
      }

      public object Current {
        get {
          IntPtr cPtr = LogicalTreeHelper.GetChildHelper(this._parent, this._index);
          return Noesis.Extend.GetProxy(cPtr, true);
        }
      }

      public bool MoveNext() {
        if (++this._index >= this._count) {
          return false;
        }
        return true;
      }

      public void Reset() {
        this._index = -1;
      }

      public void Dispose() {
      }

      public Enumerator(DependencyObject parent) {
        this._parent = parent;
        this._index = -1;
        this._count = LogicalTreeHelper.GetChildrenCountHelper(this._parent);
      }

      private DependencyObject _parent;
      private int _index;
      private int _count;
    }

    private DependencyObject _parent;
  }

  private static DependencyObject GetParentHelper(DependencyObject current) {
    IntPtr cPtr = NoesisGUI_PINVOKE.LogicalTreeHelper_GetParentHelper(DependencyObject.getCPtr(current));
    return (DependencyObject)Noesis.Extend.GetProxy(cPtr, false);
  }

  private static int GetChildrenCountHelper(DependencyObject current) {
    int ret = NoesisGUI_PINVOKE.LogicalTreeHelper_GetChildrenCountHelper(DependencyObject.getCPtr(current));
    return ret;
  }

  private static IntPtr GetChildHelper(DependencyObject current, int index) {
    IntPtr ret = NoesisGUI_PINVOKE.LogicalTreeHelper_GetChildHelper(DependencyObject.getCPtr(current), index);
    return ret;
  }

  private static IntPtr FindLogicalNodeHelper(DependencyObject current, string name) {
    IntPtr ret = NoesisGUI_PINVOKE.LogicalTreeHelper_FindLogicalNodeHelper(DependencyObject.getCPtr(current), name != null ? name : string.Empty);
    return ret;
  }

}

}

