//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.5
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class OSound : Object3d {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal OSound(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NeoNativeEnginePINVOKE.OSound_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(OSound obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~OSound() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NeoNativeEnginePINVOKE.delete_OSound(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public OSound(SWIGTYPE_p_Neo__SoundRef soundRef) : this(NeoNativeEnginePINVOKE.new_OSound__SWIG_0(SWIGTYPE_p_Neo__SoundRef.getCPtr(soundRef)), true) {
  }

  public OSound(OSound sound) : this(NeoNativeEnginePINVOKE.new_OSound__SWIG_1(OSound.getCPtr(sound)), true) {
    if (NeoNativeEnginePINVOKE.SWIGPendingException.Pending) throw NeoNativeEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public override int getType() {
    int ret = NeoNativeEnginePINVOKE.OSound_getType(swigCPtr);
    return ret;
  }

  public void setSoundRef(SWIGTYPE_p_Neo__SoundRef soundRef) {
    NeoNativeEnginePINVOKE.OSound_setSoundRef(swigCPtr, SWIGTYPE_p_Neo__SoundRef.getCPtr(soundRef));
  }

  public SWIGTYPE_p_Neo__SoundRef getSoundRef() {
    global::System.IntPtr cPtr = NeoNativeEnginePINVOKE.OSound_getSoundRef(swigCPtr);
    SWIGTYPE_p_Neo__SoundRef ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_Neo__SoundRef(cPtr, false);
    return ret;
  }

  public uint getSourceId() {
    uint ret = NeoNativeEnginePINVOKE.OSound_getSourceId(swigCPtr);
    return ret;
  }

  public void setLooping(bool loop) {
    NeoNativeEnginePINVOKE.OSound_setLooping(swigCPtr, loop);
  }

  public void setRelative(bool relative) {
    NeoNativeEnginePINVOKE.OSound_setRelative(swigCPtr, relative);
  }

  public void setPitch(float pitch) {
    NeoNativeEnginePINVOKE.OSound_setPitch(swigCPtr, pitch);
  }

  public void setGain(float gain) {
    NeoNativeEnginePINVOKE.OSound_setGain(swigCPtr, gain);
  }

  public void setRadius(float radius) {
    NeoNativeEnginePINVOKE.OSound_setRadius(swigCPtr, radius);
  }

  public void setRolloff(float rolloff) {
    NeoNativeEnginePINVOKE.OSound_setRolloff(swigCPtr, rolloff);
  }

  public bool isPlaying() {
    bool ret = NeoNativeEnginePINVOKE.OSound_isPlaying(swigCPtr);
    return ret;
  }

  public bool isLooping() {
    bool ret = NeoNativeEnginePINVOKE.OSound_isLooping(swigCPtr);
    return ret;
  }

  public bool isRelative() {
    bool ret = NeoNativeEnginePINVOKE.OSound_isRelative(swigCPtr);
    return ret;
  }

  public float getPitch() {
    float ret = NeoNativeEnginePINVOKE.OSound_getPitch(swigCPtr);
    return ret;
  }

  public float getGain() {
    float ret = NeoNativeEnginePINVOKE.OSound_getGain(swigCPtr);
    return ret;
  }

  public float getRadius() {
    float ret = NeoNativeEnginePINVOKE.OSound_getRadius(swigCPtr);
    return ret;
  }

  public float getRolloff() {
    float ret = NeoNativeEnginePINVOKE.OSound_getRolloff(swigCPtr);
    return ret;
  }

  public float getTimePos() {
    float ret = NeoNativeEnginePINVOKE.OSound_getTimePos(swigCPtr);
    return ret;
  }

  public float getSoundDuration() {
    float ret = NeoNativeEnginePINVOKE.OSound_getSoundDuration(swigCPtr);
    return ret;
  }

  public void play() {
    NeoNativeEnginePINVOKE.OSound_play(swigCPtr);
  }

  public void pause() {
    NeoNativeEnginePINVOKE.OSound_pause(swigCPtr);
  }

  public void stop() {
    NeoNativeEnginePINVOKE.OSound_stop(swigCPtr);
  }

  public override void update() {
    NeoNativeEnginePINVOKE.OSound_update(swigCPtr);
  }

}
