//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.5
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class NeoEngine : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal NeoEngine(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(NeoEngine obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~NeoEngine() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NeoNativeEnginePINVOKE.delete_NeoEngine(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public NeoEngine() : this(NeoNativeEnginePINVOKE.new_NeoEngine(), true) {
  }

  public static NeoEngine getInstance() {
    global::System.IntPtr cPtr = NeoNativeEnginePINVOKE.NeoEngine_getInstance();
    NeoEngine ret = (cPtr == global::System.IntPtr.Zero) ? null : new NeoEngine(cPtr, false);
    return ret;
  }

  public void setActive(bool active) {
    NeoNativeEnginePINVOKE.NeoEngine_setActive(swigCPtr, active);
  }

  public bool isActive() {
    bool ret = NeoNativeEnginePINVOKE.NeoEngine_isActive(swigCPtr);
    return ret;
  }

  public void setSoundContext(SoundContext soundContext) {
    NeoNativeEnginePINVOKE.NeoEngine_setSoundContext(swigCPtr, SoundContext.getCPtr(soundContext));
  }

  public void setRenderingContext(RenderingContext renderingContext) {
    NeoNativeEnginePINVOKE.NeoEngine_setRenderingContext(swigCPtr, RenderingContext.getCPtr(renderingContext));
  }

  public void setPhysicsContext(PhysicsContext physicsContext) {
    NeoNativeEnginePINVOKE.NeoEngine_setPhysicsContext(swigCPtr, PhysicsContext.getCPtr(physicsContext));
  }

  public void setScriptContext(ScriptContext scriptContext) {
    NeoNativeEnginePINVOKE.NeoEngine_setScriptContext(swigCPtr, ScriptContext.getCPtr(scriptContext));
  }

  public void setInputContext(InputContext inputContext) {
    NeoNativeEnginePINVOKE.NeoEngine_setInputContext(swigCPtr, InputContext.getCPtr(inputContext));
  }

  public void setSystemContext(SystemContext systemContext) {
    NeoNativeEnginePINVOKE.NeoEngine_setSystemContext(swigCPtr, SystemContext.getCPtr(systemContext));
  }

  public SoundContext getSoundContext() {
    global::System.IntPtr cPtr = NeoNativeEnginePINVOKE.NeoEngine_getSoundContext(swigCPtr);
    SoundContext ret = (cPtr == global::System.IntPtr.Zero) ? null : new SoundContext(cPtr, false);
    return ret;
  }

  public RenderingContext getRenderingContext() {
    global::System.IntPtr cPtr = NeoNativeEnginePINVOKE.NeoEngine_getRenderingContext(swigCPtr);
    RenderingContext ret = (cPtr == global::System.IntPtr.Zero) ? null : new RenderingContext(cPtr, false);
    return ret;
  }

  public PhysicsContext getPhysicsContext() {
    global::System.IntPtr cPtr = NeoNativeEnginePINVOKE.NeoEngine_getPhysicsContext(swigCPtr);
    PhysicsContext ret = (cPtr == global::System.IntPtr.Zero) ? null : new PhysicsContext(cPtr, false);
    return ret;
  }

  public ScriptContext getScriptContext() {
    global::System.IntPtr cPtr = NeoNativeEnginePINVOKE.NeoEngine_getScriptContext(swigCPtr);
    ScriptContext ret = (cPtr == global::System.IntPtr.Zero) ? null : new ScriptContext(cPtr, false);
    return ret;
  }

  public InputContext getInputContext() {
    global::System.IntPtr cPtr = NeoNativeEnginePINVOKE.NeoEngine_getInputContext(swigCPtr);
    InputContext ret = (cPtr == global::System.IntPtr.Zero) ? null : new InputContext(cPtr, false);
    return ret;
  }

  public SystemContext getSystemContext() {
    global::System.IntPtr cPtr = NeoNativeEnginePINVOKE.NeoEngine_getSystemContext(swigCPtr);
    SystemContext ret = (cPtr == global::System.IntPtr.Zero) ? null : new SystemContext(cPtr, false);
    return ret;
  }

  public DataLoader getFontLoader() {
    global::System.IntPtr cPtr = NeoNativeEnginePINVOKE.NeoEngine_getFontLoader(swigCPtr);
    DataLoader ret = (cPtr == global::System.IntPtr.Zero) ? null : new DataLoader(cPtr, false);
    return ret;
  }

  public DataLoader getImageLoader() {
    global::System.IntPtr cPtr = NeoNativeEnginePINVOKE.NeoEngine_getImageLoader(swigCPtr);
    DataLoader ret = (cPtr == global::System.IntPtr.Zero) ? null : new DataLoader(cPtr, false);
    return ret;
  }

  public DataLoader getSoundLoader() {
    global::System.IntPtr cPtr = NeoNativeEnginePINVOKE.NeoEngine_getSoundLoader(swigCPtr);
    DataLoader ret = (cPtr == global::System.IntPtr.Zero) ? null : new DataLoader(cPtr, false);
    return ret;
  }

  public DataLoader getMeshLoader() {
    global::System.IntPtr cPtr = NeoNativeEnginePINVOKE.NeoEngine_getMeshLoader(swigCPtr);
    DataLoader ret = (cPtr == global::System.IntPtr.Zero) ? null : new DataLoader(cPtr, false);
    return ret;
  }

  public DataLoader getArmatureAnimLoader() {
    global::System.IntPtr cPtr = NeoNativeEnginePINVOKE.NeoEngine_getArmatureAnimLoader(swigCPtr);
    DataLoader ret = (cPtr == global::System.IntPtr.Zero) ? null : new DataLoader(cPtr, false);
    return ret;
  }

  public DataLoader getTexturesAnimLoader() {
    global::System.IntPtr cPtr = NeoNativeEnginePINVOKE.NeoEngine_getTexturesAnimLoader(swigCPtr);
    DataLoader ret = (cPtr == global::System.IntPtr.Zero) ? null : new DataLoader(cPtr, false);
    return ret;
  }

  public DataLoader getMaterialsAnimLoader() {
    global::System.IntPtr cPtr = NeoNativeEnginePINVOKE.NeoEngine_getMaterialsAnimLoader(swigCPtr);
    DataLoader ret = (cPtr == global::System.IntPtr.Zero) ? null : new DataLoader(cPtr, false);
    return ret;
  }

  public DataLoader getLevelLoader() {
    global::System.IntPtr cPtr = NeoNativeEnginePINVOKE.NeoEngine_getLevelLoader(swigCPtr);
    DataLoader ret = (cPtr == global::System.IntPtr.Zero) ? null : new DataLoader(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_BehaviorManager getBehaviorManager() {
    global::System.IntPtr cPtr = NeoNativeEnginePINVOKE.NeoEngine_getBehaviorManager(swigCPtr);
    SWIGTYPE_p_BehaviorManager ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_BehaviorManager(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_RendererManager getRendererManager() {
    global::System.IntPtr cPtr = NeoNativeEnginePINVOKE.NeoEngine_getRendererManager(swigCPtr);
    SWIGTYPE_p_RendererManager ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_RendererManager(cPtr, false);
    return ret;
  }

  public void setPackageManager(SWIGTYPE_p_MPackageManager packageManager) {
    NeoNativeEnginePINVOKE.NeoEngine_setPackageManager(swigCPtr, SWIGTYPE_p_MPackageManager.getCPtr(packageManager));
  }

  public SWIGTYPE_p_MPackageManager getPackageManager() {
    global::System.IntPtr cPtr = NeoNativeEnginePINVOKE.NeoEngine_getPackageManager(swigCPtr);
    SWIGTYPE_p_MPackageManager ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_MPackageManager(cPtr, false);
    return ret;
  }

  public void updateRequests() {
    NeoNativeEnginePINVOKE.NeoEngine_updateRequests(swigCPtr);
  }

  public void setLevel(Level level) {
    NeoNativeEnginePINVOKE.NeoEngine_setLevel(swigCPtr, Level.getCPtr(level));
  }

  public bool loadLevel(string filename) {
    bool ret = NeoNativeEnginePINVOKE.NeoEngine_loadLevel(swigCPtr, filename);
    return ret;
  }

  public void requestLoadLevel(string filename) {
    NeoNativeEnginePINVOKE.NeoEngine_requestLoadLevel(swigCPtr, filename);
  }

  public bool doesLevelExist(string filename) {
    bool ret = NeoNativeEnginePINVOKE.NeoEngine_doesLevelExist(swigCPtr, filename);
    return ret;
  }

  public Level getLevel() {
    global::System.IntPtr cPtr = NeoNativeEnginePINVOKE.NeoEngine_getLevel(swigCPtr);
    Level ret = (cPtr == global::System.IntPtr.Zero) ? null : new Level(cPtr, false);
    return ret;
  }

  public void setGame(SWIGTYPE_p_Neo__NeoGame game) {
    NeoNativeEnginePINVOKE.NeoEngine_setGame(swigCPtr, SWIGTYPE_p_Neo__NeoGame.getCPtr(game));
  }

  public SWIGTYPE_p_Neo__NeoGame getGame() {
    global::System.IntPtr cPtr = NeoNativeEnginePINVOKE.NeoEngine_getGame(swigCPtr);
    SWIGTYPE_p_Neo__NeoGame ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_Neo__NeoGame(cPtr, false);
    return ret;
  }

  public void setRenderer(SWIGTYPE_p_Renderer renderer) {
    NeoNativeEnginePINVOKE.NeoEngine_setRenderer(swigCPtr, SWIGTYPE_p_Renderer.getCPtr(renderer));
  }

  public SWIGTYPE_p_Renderer getRenderer() {
    global::System.IntPtr cPtr = NeoNativeEnginePINVOKE.NeoEngine_getRenderer(swigCPtr);
    SWIGTYPE_p_Renderer ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_Renderer(cPtr, false);
    return ret;
  }

}
