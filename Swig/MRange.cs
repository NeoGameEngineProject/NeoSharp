/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public class MRange : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal MRange(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MRange obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~MRange() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NeoNativeEnginePINVOKE.delete_MRange(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public int start {
    set {
      NeoNativeEnginePINVOKE.MRange_start_set(swigCPtr, value);
    } 
    get {
      int ret = NeoNativeEnginePINVOKE.MRange_start_get(swigCPtr);
      return ret;
    } 
  }

  public int end {
    set {
      NeoNativeEnginePINVOKE.MRange_end_set(swigCPtr, value);
    } 
    get {
      int ret = NeoNativeEnginePINVOKE.MRange_end_get(swigCPtr);
      return ret;
    } 
  }

  public MRange() : this(NeoNativeEnginePINVOKE.new_MRange(), true) {
  }

}