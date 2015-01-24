/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public class MQuaternion : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal MQuaternion(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MQuaternion obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~MQuaternion() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NeoNativeEnginePINVOKE.delete_MQuaternion(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_float values {
    set {
      NeoNativeEnginePINVOKE.MQuaternion_values_set(swigCPtr, SWIGTYPE_p_float.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NeoNativeEnginePINVOKE.MQuaternion_values_get(swigCPtr);
      SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
      return ret;
    } 
  }

  public MQuaternion() : this(NeoNativeEnginePINVOKE.new_MQuaternion__SWIG_0(), true) {
  }

  public MQuaternion(float val0, float val1, float val2, float val3) : this(NeoNativeEnginePINVOKE.new_MQuaternion__SWIG_1(val0, val1, val2, val3), true) {
  }

  public MQuaternion(float angle, MVector3 axis) : this(NeoNativeEnginePINVOKE.new_MQuaternion__SWIG_2(angle, MVector3.getCPtr(axis)), true) {
    if (NeoNativeEnginePINVOKE.SWIGPendingException.Pending) throw NeoNativeEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public MQuaternion(float xAngle, float yAngle, float zAngle) : this(NeoNativeEnginePINVOKE.new_MQuaternion__SWIG_3(xAngle, yAngle, zAngle), true) {
  }

  public MQuaternion(MQuaternion q1, MQuaternion q2, float interpolation) : this(NeoNativeEnginePINVOKE.new_MQuaternion__SWIG_4(MQuaternion.getCPtr(q1), MQuaternion.getCPtr(q2), interpolation), true) {
    if (NeoNativeEnginePINVOKE.SWIGPendingException.Pending) throw NeoNativeEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void normalize() {
    NeoNativeEnginePINVOKE.MQuaternion_normalize(swigCPtr);
  }

  public void loadIdentity() {
    NeoNativeEnginePINVOKE.MQuaternion_loadIdentity(swigCPtr);
  }

  public void setFromAngles(float xAngle, float yAngle, float zAngle) {
    NeoNativeEnginePINVOKE.MQuaternion_setFromAngles(swigCPtr, xAngle, yAngle, zAngle);
  }

  public void slerp(MQuaternion q1, MQuaternion q2, float interpolation) {
    NeoNativeEnginePINVOKE.MQuaternion_slerp(swigCPtr, MQuaternion.getCPtr(q1), MQuaternion.getCPtr(q2), interpolation);
    if (NeoNativeEnginePINVOKE.SWIGPendingException.Pending) throw NeoNativeEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void invert() {
    NeoNativeEnginePINVOKE.MQuaternion_invert(swigCPtr);
  }

  public void setFromAngleAxis(float angle, MVector3 axis) {
    NeoNativeEnginePINVOKE.MQuaternion_setFromAngleAxis(swigCPtr, angle, MVector3.getCPtr(axis));
    if (NeoNativeEnginePINVOKE.SWIGPendingException.Pending) throw NeoNativeEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setFromVectors(MVector3 source, MVector3 destination) {
    NeoNativeEnginePINVOKE.MQuaternion_setFromVectors(swigCPtr, MVector3.getCPtr(source), MVector3.getCPtr(destination));
    if (NeoNativeEnginePINVOKE.SWIGPendingException.Pending) throw NeoNativeEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public MVector3 getEulerAngles() {
    MVector3 ret = new MVector3(NeoNativeEnginePINVOKE.MQuaternion_getEulerAngles(swigCPtr), true);
    return ret;
  }

  public float getAngle() {
    float ret = NeoNativeEnginePINVOKE.MQuaternion_getAngle(swigCPtr);
    return ret;
  }

  public MVector3 getAxis() {
    MVector3 ret = new MVector3(NeoNativeEnginePINVOKE.MQuaternion_getAxis(swigCPtr), true);
    return ret;
  }

}
