/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public class MSystemContext : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal MSystemContext(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MSystemContext obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~MSystemContext() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NeoNativeEnginePINVOKE.delete_MSystemContext(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual void getScreenSize(SWIGTYPE_p_unsigned_int width, SWIGTYPE_p_unsigned_int height) {
    NeoNativeEnginePINVOKE.MSystemContext_getScreenSize(swigCPtr, SWIGTYPE_p_unsigned_int.getCPtr(width), SWIGTYPE_p_unsigned_int.getCPtr(height));
  }

  public virtual void setCursorPosition(int x, int y) {
    NeoNativeEnginePINVOKE.MSystemContext_setCursorPosition(swigCPtr, x, y);
  }

  public virtual void hideCursor() {
    NeoNativeEnginePINVOKE.MSystemContext_hideCursor(swigCPtr);
  }

  public virtual void showCursor() {
    NeoNativeEnginePINVOKE.MSystemContext_showCursor(swigCPtr);
  }

  public virtual string getWorkingDirectory() {
    string ret = NeoNativeEnginePINVOKE.MSystemContext_getWorkingDirectory(swigCPtr);
    return ret;
  }

  public virtual uint getSystemTick() {
    uint ret = NeoNativeEnginePINVOKE.MSystemContext_getSystemTick(swigCPtr);
    return ret;
  }

}