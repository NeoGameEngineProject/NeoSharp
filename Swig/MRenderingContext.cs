/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public class MRenderingContext : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal MRenderingContext(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MRenderingContext obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~MRenderingContext() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NeoNativeEnginePINVOKE.delete_MRenderingContext(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual string getRendererVersion() {
    string ret = NeoNativeEnginePINVOKE.MRenderingContext_getRendererVersion(swigCPtr);
    return ret;
  }

  public virtual void setOrthoView(float left, float right, float bottom, float top, float zNear, float zFar) {
    NeoNativeEnginePINVOKE.MRenderingContext_setOrthoView(swigCPtr, left, right, bottom, top, zNear, zFar);
  }

  public virtual void setPerspectiveView(float fov, float ratio, float zNear, float zFar) {
    NeoNativeEnginePINVOKE.MRenderingContext_setPerspectiveView(swigCPtr, fov, ratio, zNear, zFar);
  }

  public virtual void setViewport(int x, int y, uint width, uint height) {
    NeoNativeEnginePINVOKE.MRenderingContext_setViewport(swigCPtr, x, y, width, height);
  }

  public virtual void clear(int buffer) {
    NeoNativeEnginePINVOKE.MRenderingContext_clear(swigCPtr, buffer);
  }

  public virtual void setClearColor(MVector4 color) {
    NeoNativeEnginePINVOKE.MRenderingContext_setClearColor(swigCPtr, MVector4.getCPtr(color));
    if (NeoNativeEnginePINVOKE.SWIGPendingException.Pending) throw NeoNativeEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void enableTexture() {
    NeoNativeEnginePINVOKE.MRenderingContext_enableTexture(swigCPtr);
  }

  public virtual void disableTexture() {
    NeoNativeEnginePINVOKE.MRenderingContext_disableTexture(swigCPtr);
  }

  public virtual void setTextureGenMode(M_TEX_GEN_MODES mode) {
    NeoNativeEnginePINVOKE.MRenderingContext_setTextureGenMode(swigCPtr, (int)mode);
  }

  public virtual void setTextureFilterMode(M_TEX_FILTER_MODES min, M_TEX_FILTER_MODES mag) {
    NeoNativeEnginePINVOKE.MRenderingContext_setTextureFilterMode(swigCPtr, (int)min, (int)mag);
  }

  public virtual void setTextureUWrapMode(M_WRAP_MODES wrap) {
    NeoNativeEnginePINVOKE.MRenderingContext_setTextureUWrapMode(swigCPtr, (int)wrap);
  }

  public virtual void setTextureVWrapMode(M_WRAP_MODES wrap) {
    NeoNativeEnginePINVOKE.MRenderingContext_setTextureVWrapMode(swigCPtr, (int)wrap);
  }

  public virtual void setTextureCombineMode(M_TEX_COMBINE_MODES combine) {
    NeoNativeEnginePINVOKE.MRenderingContext_setTextureCombineMode(swigCPtr, (int)combine);
  }

  public virtual void bindTexture(uint textureId, uint multitextureId) {
    NeoNativeEnginePINVOKE.MRenderingContext_bindTexture__SWIG_0(swigCPtr, textureId, multitextureId);
  }

  public virtual void bindTexture(uint textureId) {
    NeoNativeEnginePINVOKE.MRenderingContext_bindTexture__SWIG_1(swigCPtr, textureId);
  }

  public virtual void createTexture(SWIGTYPE_p_unsigned_int textureId) {
    NeoNativeEnginePINVOKE.MRenderingContext_createTexture(swigCPtr, SWIGTYPE_p_unsigned_int.getCPtr(textureId));
  }

  public virtual void deleteTexture(SWIGTYPE_p_unsigned_int textureId) {
    NeoNativeEnginePINVOKE.MRenderingContext_deleteTexture(swigCPtr, SWIGTYPE_p_unsigned_int.getCPtr(textureId));
  }

  public virtual void sendTextureImage(MImage image, bool mipMap, bool filter, bool compress) {
    NeoNativeEnginePINVOKE.MRenderingContext_sendTextureImage(swigCPtr, MImage.getCPtr(image), mipMap, filter, compress);
  }

  public virtual void texImage(uint level, uint width, uint height, M_TYPES type, M_TEX_MODES mode, SWIGTYPE_p_void pixels) {
    NeoNativeEnginePINVOKE.MRenderingContext_texImage(swigCPtr, level, width, height, (int)type, (int)mode, SWIGTYPE_p_void.getCPtr(pixels));
  }

  public virtual void texSubImage(uint level, int xoffset, int yoffset, uint width, uint height, M_TYPES type, M_TEX_MODES mode, SWIGTYPE_p_void pixels) {
    NeoNativeEnginePINVOKE.MRenderingContext_texSubImage(swigCPtr, level, xoffset, yoffset, width, height, (int)type, (int)mode, SWIGTYPE_p_void.getCPtr(pixels));
  }

  public virtual void generateMipMap() {
    NeoNativeEnginePINVOKE.MRenderingContext_generateMipMap(swigCPtr);
  }

  public virtual void getTexImage(uint level, MImage image) {
    NeoNativeEnginePINVOKE.MRenderingContext_getTexImage(swigCPtr, level, MImage.getCPtr(image));
  }

  public virtual void createFrameBuffer(SWIGTYPE_p_unsigned_int frameBufferId) {
    NeoNativeEnginePINVOKE.MRenderingContext_createFrameBuffer(swigCPtr, SWIGTYPE_p_unsigned_int.getCPtr(frameBufferId));
  }

  public virtual void deleteFrameBuffer(SWIGTYPE_p_unsigned_int frameBufferId) {
    NeoNativeEnginePINVOKE.MRenderingContext_deleteFrameBuffer(swigCPtr, SWIGTYPE_p_unsigned_int.getCPtr(frameBufferId));
  }

  public virtual void bindFrameBuffer(uint frameBufferId) {
    NeoNativeEnginePINVOKE.MRenderingContext_bindFrameBuffer(swigCPtr, frameBufferId);
  }

  public virtual void getCurrentFrameBuffer(SWIGTYPE_p_unsigned_int frameBufferId) {
    NeoNativeEnginePINVOKE.MRenderingContext_getCurrentFrameBuffer(swigCPtr, SWIGTYPE_p_unsigned_int.getCPtr(frameBufferId));
  }

  public virtual void attachFrameBufferTexture(M_FRAME_BUFFER_ATTACHMENT attachment, uint textureId) {
    NeoNativeEnginePINVOKE.MRenderingContext_attachFrameBufferTexture(swigCPtr, (int)attachment, textureId);
  }

  public virtual void attachFrameBufferRB(M_FRAME_BUFFER_ATTACHMENT attachment, uint renderBufferId) {
    NeoNativeEnginePINVOKE.MRenderingContext_attachFrameBufferRB(swigCPtr, (int)attachment, renderBufferId);
  }

  public virtual void setDrawingBuffers(SWIGTYPE_p_M_FRAME_BUFFER_ATTACHMENT buffers, uint size) {
    NeoNativeEnginePINVOKE.MRenderingContext_setDrawingBuffers(swigCPtr, SWIGTYPE_p_M_FRAME_BUFFER_ATTACHMENT.getCPtr(buffers), size);
  }

  public virtual void createRenderBuffer(SWIGTYPE_p_unsigned_int renderBufferId) {
    NeoNativeEnginePINVOKE.MRenderingContext_createRenderBuffer(swigCPtr, SWIGTYPE_p_unsigned_int.getCPtr(renderBufferId));
  }

  public virtual void deleteRenderBuffer(SWIGTYPE_p_unsigned_int renderBufferId) {
    NeoNativeEnginePINVOKE.MRenderingContext_deleteRenderBuffer(swigCPtr, SWIGTYPE_p_unsigned_int.getCPtr(renderBufferId));
  }

  public virtual void bindRenderBuffer(uint renderBufferId) {
    NeoNativeEnginePINVOKE.MRenderingContext_bindRenderBuffer(swigCPtr, renderBufferId);
  }

  public virtual void setRenderBuffer(M_RENDER_BUFFER_MODES mode, uint width, uint height) {
    NeoNativeEnginePINVOKE.MRenderingContext_setRenderBuffer(swigCPtr, (int)mode, width, height);
  }

  public virtual void createVertexShader(SWIGTYPE_p_unsigned_int shaderId) {
    NeoNativeEnginePINVOKE.MRenderingContext_createVertexShader(swigCPtr, SWIGTYPE_p_unsigned_int.getCPtr(shaderId));
  }

  public virtual void createPixelShader(SWIGTYPE_p_unsigned_int shaderId) {
    NeoNativeEnginePINVOKE.MRenderingContext_createPixelShader(swigCPtr, SWIGTYPE_p_unsigned_int.getCPtr(shaderId));
  }

  public virtual void deleteShader(SWIGTYPE_p_unsigned_int shaderId) {
    NeoNativeEnginePINVOKE.MRenderingContext_deleteShader(swigCPtr, SWIGTYPE_p_unsigned_int.getCPtr(shaderId));
  }

  public virtual bool sendShaderSource(uint shaderId, string source) {
    bool ret = NeoNativeEnginePINVOKE.MRenderingContext_sendShaderSource(swigCPtr, shaderId, source);
    return ret;
  }

  public virtual void bindFX(uint fxId) {
    NeoNativeEnginePINVOKE.MRenderingContext_bindFX(swigCPtr, fxId);
  }

  public virtual void createFX(SWIGTYPE_p_unsigned_int fxId, uint vertexShaderId, uint pixelShaderId) {
    NeoNativeEnginePINVOKE.MRenderingContext_createFX(swigCPtr, SWIGTYPE_p_unsigned_int.getCPtr(fxId), vertexShaderId, pixelShaderId);
  }

  public virtual void updateFX(uint fxId) {
    NeoNativeEnginePINVOKE.MRenderingContext_updateFX(swigCPtr, fxId);
  }

  public virtual void deleteFX(SWIGTYPE_p_unsigned_int fxId) {
    NeoNativeEnginePINVOKE.MRenderingContext_deleteFX(swigCPtr, SWIGTYPE_p_unsigned_int.getCPtr(fxId));
  }

  public virtual void sendUniformInt(uint fxId, string name, SWIGTYPE_p_int values, int count) {
    NeoNativeEnginePINVOKE.MRenderingContext_sendUniformInt__SWIG_0(swigCPtr, fxId, name, SWIGTYPE_p_int.getCPtr(values), count);
  }

  public virtual void sendUniformInt(uint fxId, string name, SWIGTYPE_p_int values) {
    NeoNativeEnginePINVOKE.MRenderingContext_sendUniformInt__SWIG_1(swigCPtr, fxId, name, SWIGTYPE_p_int.getCPtr(values));
  }

  public virtual void sendUniformFloat(uint fxId, string name, SWIGTYPE_p_float value, int count) {
    NeoNativeEnginePINVOKE.MRenderingContext_sendUniformFloat__SWIG_0(swigCPtr, fxId, name, SWIGTYPE_p_float.getCPtr(value), count);
  }

  public virtual void sendUniformFloat(uint fxId, string name, SWIGTYPE_p_float value) {
    NeoNativeEnginePINVOKE.MRenderingContext_sendUniformFloat__SWIG_1(swigCPtr, fxId, name, SWIGTYPE_p_float.getCPtr(value));
  }

  public virtual void sendUniformVec2(uint fxId, string name, SWIGTYPE_p_float values, int count) {
    NeoNativeEnginePINVOKE.MRenderingContext_sendUniformVec2__SWIG_0(swigCPtr, fxId, name, SWIGTYPE_p_float.getCPtr(values), count);
  }

  public virtual void sendUniformVec2(uint fxId, string name, SWIGTYPE_p_float values) {
    NeoNativeEnginePINVOKE.MRenderingContext_sendUniformVec2__SWIG_1(swigCPtr, fxId, name, SWIGTYPE_p_float.getCPtr(values));
  }

  public virtual void sendUniformVec3(uint fxId, string name, SWIGTYPE_p_float values, int count) {
    NeoNativeEnginePINVOKE.MRenderingContext_sendUniformVec3__SWIG_0(swigCPtr, fxId, name, SWIGTYPE_p_float.getCPtr(values), count);
  }

  public virtual void sendUniformVec3(uint fxId, string name, SWIGTYPE_p_float values) {
    NeoNativeEnginePINVOKE.MRenderingContext_sendUniformVec3__SWIG_1(swigCPtr, fxId, name, SWIGTYPE_p_float.getCPtr(values));
  }

  public virtual void sendUniformVec4(uint fxId, string name, SWIGTYPE_p_float values, int count) {
    NeoNativeEnginePINVOKE.MRenderingContext_sendUniformVec4__SWIG_0(swigCPtr, fxId, name, SWIGTYPE_p_float.getCPtr(values), count);
  }

  public virtual void sendUniformVec4(uint fxId, string name, SWIGTYPE_p_float values) {
    NeoNativeEnginePINVOKE.MRenderingContext_sendUniformVec4__SWIG_1(swigCPtr, fxId, name, SWIGTYPE_p_float.getCPtr(values));
  }

  public virtual void sendUniformMatrix(uint fxId, string name, MMatrix4x4 matrix, int count, bool transpose) {
    NeoNativeEnginePINVOKE.MRenderingContext_sendUniformMatrix__SWIG_0(swigCPtr, fxId, name, MMatrix4x4.getCPtr(matrix), count, transpose);
  }

  public virtual void sendUniformMatrix(uint fxId, string name, MMatrix4x4 matrix, int count) {
    NeoNativeEnginePINVOKE.MRenderingContext_sendUniformMatrix__SWIG_1(swigCPtr, fxId, name, MMatrix4x4.getCPtr(matrix), count);
  }

  public virtual void sendUniformMatrix(uint fxId, string name, MMatrix4x4 matrix) {
    NeoNativeEnginePINVOKE.MRenderingContext_sendUniformMatrix__SWIG_2(swigCPtr, fxId, name, MMatrix4x4.getCPtr(matrix));
  }

  public virtual void getAttribLocation(uint fxId, string name, SWIGTYPE_p_int location) {
    NeoNativeEnginePINVOKE.MRenderingContext_getAttribLocation(swigCPtr, fxId, name, SWIGTYPE_p_int.getCPtr(location));
  }

  public virtual void createVBO(SWIGTYPE_p_unsigned_int vboId) {
    NeoNativeEnginePINVOKE.MRenderingContext_createVBO(swigCPtr, SWIGTYPE_p_unsigned_int.getCPtr(vboId));
  }

  public virtual void deleteVBO(SWIGTYPE_p_unsigned_int vboId) {
    NeoNativeEnginePINVOKE.MRenderingContext_deleteVBO(swigCPtr, SWIGTYPE_p_unsigned_int.getCPtr(vboId));
  }

  public virtual void bindVBO(M_VBO_TYPES type, uint vboId) {
    NeoNativeEnginePINVOKE.MRenderingContext_bindVBO(swigCPtr, (int)type, vboId);
  }

  public virtual void setVBO(M_VBO_TYPES type, SWIGTYPE_p_void data, uint size, M_VBO_MODES mode) {
    NeoNativeEnginePINVOKE.MRenderingContext_setVBO(swigCPtr, (int)type, SWIGTYPE_p_void.getCPtr(data), size, (int)mode);
  }

  public virtual void setVBOSubData(M_VBO_TYPES type, uint offset, SWIGTYPE_p_void data, uint size) {
    NeoNativeEnginePINVOKE.MRenderingContext_setVBOSubData(swigCPtr, (int)type, offset, SWIGTYPE_p_void.getCPtr(data), size);
  }

  public virtual void enableVertexArray() {
    NeoNativeEnginePINVOKE.MRenderingContext_enableVertexArray(swigCPtr);
  }

  public virtual void enableColorArray() {
    NeoNativeEnginePINVOKE.MRenderingContext_enableColorArray(swigCPtr);
  }

  public virtual void enableNormalArray() {
    NeoNativeEnginePINVOKE.MRenderingContext_enableNormalArray(swigCPtr);
  }

  public virtual void enableTexCoordArray() {
    NeoNativeEnginePINVOKE.MRenderingContext_enableTexCoordArray(swigCPtr);
  }

  public virtual void enableAttribArray(uint location) {
    NeoNativeEnginePINVOKE.MRenderingContext_enableAttribArray(swigCPtr, location);
  }

  public virtual void disableVertexArray() {
    NeoNativeEnginePINVOKE.MRenderingContext_disableVertexArray(swigCPtr);
  }

  public virtual void disableColorArray() {
    NeoNativeEnginePINVOKE.MRenderingContext_disableColorArray(swigCPtr);
  }

  public virtual void disableNormalArray() {
    NeoNativeEnginePINVOKE.MRenderingContext_disableNormalArray(swigCPtr);
  }

  public virtual void disableTexCoordArray() {
    NeoNativeEnginePINVOKE.MRenderingContext_disableTexCoordArray(swigCPtr);
  }

  public virtual void disableAttribArray(uint location) {
    NeoNativeEnginePINVOKE.MRenderingContext_disableAttribArray(swigCPtr, location);
  }

  public virtual void setVertexPointer(M_TYPES type, uint components, SWIGTYPE_p_void pointer) {
    NeoNativeEnginePINVOKE.MRenderingContext_setVertexPointer(swigCPtr, (int)type, components, SWIGTYPE_p_void.getCPtr(pointer));
  }

  public virtual void setColorPointer(M_TYPES type, uint components, SWIGTYPE_p_void pointer) {
    NeoNativeEnginePINVOKE.MRenderingContext_setColorPointer(swigCPtr, (int)type, components, SWIGTYPE_p_void.getCPtr(pointer));
  }

  public virtual void setNormalPointer(M_TYPES type, SWIGTYPE_p_void pointer) {
    NeoNativeEnginePINVOKE.MRenderingContext_setNormalPointer(swigCPtr, (int)type, SWIGTYPE_p_void.getCPtr(pointer));
  }

  public virtual void setTexCoordPointer(M_TYPES type, uint components, SWIGTYPE_p_void pointer) {
    NeoNativeEnginePINVOKE.MRenderingContext_setTexCoordPointer(swigCPtr, (int)type, components, SWIGTYPE_p_void.getCPtr(pointer));
  }

  public virtual void setAttribPointer(uint location, M_TYPES type, uint components, SWIGTYPE_p_void pointer, bool normalized) {
    NeoNativeEnginePINVOKE.MRenderingContext_setAttribPointer__SWIG_0(swigCPtr, location, (int)type, components, SWIGTYPE_p_void.getCPtr(pointer), normalized);
  }

  public virtual void setAttribPointer(uint location, M_TYPES type, uint components, SWIGTYPE_p_void pointer) {
    NeoNativeEnginePINVOKE.MRenderingContext_setAttribPointer__SWIG_1(swigCPtr, location, (int)type, components, SWIGTYPE_p_void.getCPtr(pointer));
  }

  public virtual void drawArray(M_PRIMITIVE_TYPES type, uint begin, uint size) {
    NeoNativeEnginePINVOKE.MRenderingContext_drawArray(swigCPtr, (int)type, begin, size);
  }

  public virtual void drawElement(M_PRIMITIVE_TYPES type, uint size, M_TYPES indicesType, SWIGTYPE_p_void indices) {
    NeoNativeEnginePINVOKE.MRenderingContext_drawElement(swigCPtr, (int)type, size, (int)indicesType, SWIGTYPE_p_void.getCPtr(indices));
  }

  public virtual void enableLineAntialiasing() {
    NeoNativeEnginePINVOKE.MRenderingContext_enableLineAntialiasing(swigCPtr);
  }

  public virtual void disableLineAntialiasing() {
    NeoNativeEnginePINVOKE.MRenderingContext_disableLineAntialiasing(swigCPtr);
  }

  public virtual void setMaterialDiffuse(MVector4 diffuse) {
    NeoNativeEnginePINVOKE.MRenderingContext_setMaterialDiffuse(swigCPtr, MVector4.getCPtr(diffuse));
    if (NeoNativeEnginePINVOKE.SWIGPendingException.Pending) throw NeoNativeEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void setMaterialSpecular(MVector4 specular) {
    NeoNativeEnginePINVOKE.MRenderingContext_setMaterialSpecular(swigCPtr, MVector4.getCPtr(specular));
    if (NeoNativeEnginePINVOKE.SWIGPendingException.Pending) throw NeoNativeEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void setMaterialAmbient(MVector4 ambient) {
    NeoNativeEnginePINVOKE.MRenderingContext_setMaterialAmbient(swigCPtr, MVector4.getCPtr(ambient));
    if (NeoNativeEnginePINVOKE.SWIGPendingException.Pending) throw NeoNativeEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void setMaterialEmit(MVector4 emit) {
    NeoNativeEnginePINVOKE.MRenderingContext_setMaterialEmit(swigCPtr, MVector4.getCPtr(emit));
    if (NeoNativeEnginePINVOKE.SWIGPendingException.Pending) throw NeoNativeEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void setMaterialShininess(float shininess) {
    NeoNativeEnginePINVOKE.MRenderingContext_setMaterialShininess(swigCPtr, shininess);
  }

  public virtual void enableScissorTest() {
    NeoNativeEnginePINVOKE.MRenderingContext_enableScissorTest(swigCPtr);
  }

  public virtual void disableScissorTest() {
    NeoNativeEnginePINVOKE.MRenderingContext_disableScissorTest(swigCPtr);
  }

  public virtual void setScissor(int x, int y, uint width, uint height) {
    NeoNativeEnginePINVOKE.MRenderingContext_setScissor(swigCPtr, x, y, width, height);
  }

  public virtual void setColor(MColor color) {
    NeoNativeEnginePINVOKE.MRenderingContext_setColor(swigCPtr, MColor.getCPtr(color));
    if (NeoNativeEnginePINVOKE.SWIGPendingException.Pending) throw NeoNativeEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void setColor3(MVector3 color) {
    NeoNativeEnginePINVOKE.MRenderingContext_setColor3(swigCPtr, MVector3.getCPtr(color));
    if (NeoNativeEnginePINVOKE.SWIGPendingException.Pending) throw NeoNativeEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void setColor4(MVector4 color) {
    NeoNativeEnginePINVOKE.MRenderingContext_setColor4(swigCPtr, MVector4.getCPtr(color));
    if (NeoNativeEnginePINVOKE.SWIGPendingException.Pending) throw NeoNativeEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void setColorMask(bool r, bool g, bool b, bool a) {
    NeoNativeEnginePINVOKE.MRenderingContext_setColorMask(swigCPtr, r, g, b, a);
  }

  public virtual void setDepthMask(bool depth) {
    NeoNativeEnginePINVOKE.MRenderingContext_setDepthMask(swigCPtr, depth);
  }

  public virtual void setAlphaTest(float value) {
    NeoNativeEnginePINVOKE.MRenderingContext_setAlphaTest(swigCPtr, value);
  }

  public virtual void enableDepthTest() {
    NeoNativeEnginePINVOKE.MRenderingContext_enableDepthTest(swigCPtr);
  }

  public virtual void disableDepthTest() {
    NeoNativeEnginePINVOKE.MRenderingContext_disableDepthTest(swigCPtr);
  }

  public virtual void setDepthMode(M_DEPTH_MODES mode) {
    NeoNativeEnginePINVOKE.MRenderingContext_setDepthMode(swigCPtr, (int)mode);
  }

  public virtual void enablePolygonOffset(float x, float y) {
    NeoNativeEnginePINVOKE.MRenderingContext_enablePolygonOffset(swigCPtr, x, y);
  }

  public virtual void disablePolygonOffset() {
    NeoNativeEnginePINVOKE.MRenderingContext_disablePolygonOffset(swigCPtr);
  }

  public virtual void enableStencilTest() {
    NeoNativeEnginePINVOKE.MRenderingContext_enableStencilTest(swigCPtr);
  }

  public virtual void disableStencilTest() {
    NeoNativeEnginePINVOKE.MRenderingContext_disableStencilTest(swigCPtr);
  }

  public virtual void setStencilFunc(M_STENCIL_FUNCS func, int arg1) {
    NeoNativeEnginePINVOKE.MRenderingContext_setStencilFunc__SWIG_0(swigCPtr, (int)func, arg1);
  }

  public virtual void setStencilFunc(M_STENCIL_FUNCS func) {
    NeoNativeEnginePINVOKE.MRenderingContext_setStencilFunc__SWIG_1(swigCPtr, (int)func);
  }

  public virtual void setStencilOp(M_STENCIL_OPS op) {
    NeoNativeEnginePINVOKE.MRenderingContext_setStencilOp(swigCPtr, (int)op);
  }

  public virtual void enableCullFace() {
    NeoNativeEnginePINVOKE.MRenderingContext_enableCullFace(swigCPtr);
  }

  public virtual void disableCullFace() {
    NeoNativeEnginePINVOKE.MRenderingContext_disableCullFace(swigCPtr);
  }

  public virtual void setCullMode(M_CULL_MODES mode) {
    NeoNativeEnginePINVOKE.MRenderingContext_setCullMode(swigCPtr, (int)mode);
  }

  public virtual void createQuery(SWIGTYPE_p_unsigned_int queryId) {
    NeoNativeEnginePINVOKE.MRenderingContext_createQuery(swigCPtr, SWIGTYPE_p_unsigned_int.getCPtr(queryId));
  }

  public virtual void deleteQuery(SWIGTYPE_p_unsigned_int queryId) {
    NeoNativeEnginePINVOKE.MRenderingContext_deleteQuery(swigCPtr, SWIGTYPE_p_unsigned_int.getCPtr(queryId));
  }

  public virtual void beginQuery(uint queryId) {
    NeoNativeEnginePINVOKE.MRenderingContext_beginQuery(swigCPtr, queryId);
  }

  public virtual void endQuery() {
    NeoNativeEnginePINVOKE.MRenderingContext_endQuery(swigCPtr);
  }

  public virtual void getQueryResult(uint queryId, SWIGTYPE_p_unsigned_int result) {
    NeoNativeEnginePINVOKE.MRenderingContext_getQueryResult(swigCPtr, queryId, SWIGTYPE_p_unsigned_int.getCPtr(result));
  }

  public virtual void loadIdentity() {
    NeoNativeEnginePINVOKE.MRenderingContext_loadIdentity(swigCPtr);
  }

  public virtual void setMatrixMode(M_MATRIX_MODES mode) {
    NeoNativeEnginePINVOKE.MRenderingContext_setMatrixMode(swigCPtr, (int)mode);
  }

  public virtual void pushMatrix() {
    NeoNativeEnginePINVOKE.MRenderingContext_pushMatrix(swigCPtr);
  }

  public virtual void popMatrix() {
    NeoNativeEnginePINVOKE.MRenderingContext_popMatrix(swigCPtr);
  }

  public virtual void multMatrix(MMatrix4x4 matrix) {
    NeoNativeEnginePINVOKE.MRenderingContext_multMatrix(swigCPtr, MMatrix4x4.getCPtr(matrix));
  }

  public virtual void translate(MVector3 position) {
    NeoNativeEnginePINVOKE.MRenderingContext_translate(swigCPtr, MVector3.getCPtr(position));
    if (NeoNativeEnginePINVOKE.SWIGPendingException.Pending) throw NeoNativeEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void rotate(MVector3 axis, float angle) {
    NeoNativeEnginePINVOKE.MRenderingContext_rotate(swigCPtr, MVector3.getCPtr(axis), angle);
    if (NeoNativeEnginePINVOKE.SWIGPendingException.Pending) throw NeoNativeEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void scale(MVector3 scale) {
    NeoNativeEnginePINVOKE.MRenderingContext_scale(swigCPtr, MVector3.getCPtr(scale));
    if (NeoNativeEnginePINVOKE.SWIGPendingException.Pending) throw NeoNativeEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void getViewport(SWIGTYPE_p_int viewport) {
    NeoNativeEnginePINVOKE.MRenderingContext_getViewport(swigCPtr, SWIGTYPE_p_int.getCPtr(viewport));
  }

  public virtual void getModelViewMatrix(MMatrix4x4 matrix) {
    NeoNativeEnginePINVOKE.MRenderingContext_getModelViewMatrix(swigCPtr, MMatrix4x4.getCPtr(matrix));
  }

  public virtual void getProjectionMatrix(MMatrix4x4 matrix) {
    NeoNativeEnginePINVOKE.MRenderingContext_getProjectionMatrix(swigCPtr, MMatrix4x4.getCPtr(matrix));
  }

  public virtual void getTextureMatrix(MMatrix4x4 matrix) {
    NeoNativeEnginePINVOKE.MRenderingContext_getTextureMatrix(swigCPtr, MMatrix4x4.getCPtr(matrix));
  }

  public virtual void enableFog() {
    NeoNativeEnginePINVOKE.MRenderingContext_enableFog(swigCPtr);
  }

  public virtual void disableFog() {
    NeoNativeEnginePINVOKE.MRenderingContext_disableFog(swigCPtr);
  }

  public virtual void setFogColor(MVector3 color) {
    NeoNativeEnginePINVOKE.MRenderingContext_setFogColor(swigCPtr, MVector3.getCPtr(color));
    if (NeoNativeEnginePINVOKE.SWIGPendingException.Pending) throw NeoNativeEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void setFogDistance(float min, float max) {
    NeoNativeEnginePINVOKE.MRenderingContext_setFogDistance(swigCPtr, min, max);
  }

  public virtual void getFogColor(MVector3 color) {
    NeoNativeEnginePINVOKE.MRenderingContext_getFogColor(swigCPtr, MVector3.getCPtr(color));
  }

  public virtual void getFogDistance(SWIGTYPE_p_float min, SWIGTYPE_p_float max) {
    NeoNativeEnginePINVOKE.MRenderingContext_getFogDistance(swigCPtr, SWIGTYPE_p_float.getCPtr(min), SWIGTYPE_p_float.getCPtr(max));
  }

  public virtual void enableLighting() {
    NeoNativeEnginePINVOKE.MRenderingContext_enableLighting(swigCPtr);
  }

  public virtual void disableLighting() {
    NeoNativeEnginePINVOKE.MRenderingContext_disableLighting(swigCPtr);
  }

  public virtual void enableLight(uint id) {
    NeoNativeEnginePINVOKE.MRenderingContext_enableLight(swigCPtr, id);
  }

  public virtual void disableLight(uint id) {
    NeoNativeEnginePINVOKE.MRenderingContext_disableLight(swigCPtr, id);
  }

  public virtual void setLightPosition(uint id, MVector4 position) {
    NeoNativeEnginePINVOKE.MRenderingContext_setLightPosition(swigCPtr, id, MVector4.getCPtr(position));
    if (NeoNativeEnginePINVOKE.SWIGPendingException.Pending) throw NeoNativeEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void setLightDiffuse(uint id, MVector4 diffuse) {
    NeoNativeEnginePINVOKE.MRenderingContext_setLightDiffuse(swigCPtr, id, MVector4.getCPtr(diffuse));
    if (NeoNativeEnginePINVOKE.SWIGPendingException.Pending) throw NeoNativeEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void setLightSpecular(uint id, MVector4 specular) {
    NeoNativeEnginePINVOKE.MRenderingContext_setLightSpecular(swigCPtr, id, MVector4.getCPtr(specular));
    if (NeoNativeEnginePINVOKE.SWIGPendingException.Pending) throw NeoNativeEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void setLightAmbient(uint id, MVector4 ambient) {
    NeoNativeEnginePINVOKE.MRenderingContext_setLightAmbient(swigCPtr, id, MVector4.getCPtr(ambient));
    if (NeoNativeEnginePINVOKE.SWIGPendingException.Pending) throw NeoNativeEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void setLightAttenuation(uint id, float constant, float linear, float quadratic) {
    NeoNativeEnginePINVOKE.MRenderingContext_setLightAttenuation(swigCPtr, id, constant, linear, quadratic);
  }

  public virtual void setLightSpotDirection(uint id, MVector3 direction) {
    NeoNativeEnginePINVOKE.MRenderingContext_setLightSpotDirection(swigCPtr, id, MVector3.getCPtr(direction));
    if (NeoNativeEnginePINVOKE.SWIGPendingException.Pending) throw NeoNativeEnginePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void setLightSpotAngle(uint id, float angle) {
    NeoNativeEnginePINVOKE.MRenderingContext_setLightSpotAngle(swigCPtr, id, angle);
  }

  public virtual void setLightSpotExponent(uint id, float exponent) {
    NeoNativeEnginePINVOKE.MRenderingContext_setLightSpotExponent(swigCPtr, id, exponent);
  }

  public virtual void getLightPosition(uint id, MVector4 position) {
    NeoNativeEnginePINVOKE.MRenderingContext_getLightPosition(swigCPtr, id, MVector4.getCPtr(position));
  }

  public virtual void getLightDiffuse(uint id, MVector4 diffuse) {
    NeoNativeEnginePINVOKE.MRenderingContext_getLightDiffuse(swigCPtr, id, MVector4.getCPtr(diffuse));
  }

  public virtual void getLightSpecular(uint id, MVector4 specular) {
    NeoNativeEnginePINVOKE.MRenderingContext_getLightSpecular(swigCPtr, id, MVector4.getCPtr(specular));
  }

  public virtual void getLightAmbient(uint id, MVector4 ambient) {
    NeoNativeEnginePINVOKE.MRenderingContext_getLightAmbient(swigCPtr, id, MVector4.getCPtr(ambient));
  }

  public virtual void getLightAttenuation(uint id, SWIGTYPE_p_float constant, SWIGTYPE_p_float linear, SWIGTYPE_p_float quadratic) {
    NeoNativeEnginePINVOKE.MRenderingContext_getLightAttenuation(swigCPtr, id, SWIGTYPE_p_float.getCPtr(constant), SWIGTYPE_p_float.getCPtr(linear), SWIGTYPE_p_float.getCPtr(quadratic));
  }

  public virtual void getLightSpotDirection(uint id, MVector3 direction) {
    NeoNativeEnginePINVOKE.MRenderingContext_getLightSpotDirection(swigCPtr, id, MVector3.getCPtr(direction));
  }

  public virtual void getLightSpotAngle(uint id, SWIGTYPE_p_float angle) {
    NeoNativeEnginePINVOKE.MRenderingContext_getLightSpotAngle(swigCPtr, id, SWIGTYPE_p_float.getCPtr(angle));
  }

  public virtual void getLightSpotExponent(uint id, SWIGTYPE_p_float exponent) {
    NeoNativeEnginePINVOKE.MRenderingContext_getLightSpotExponent(swigCPtr, id, SWIGTYPE_p_float.getCPtr(exponent));
  }

  public virtual void enableBlending() {
    NeoNativeEnginePINVOKE.MRenderingContext_enableBlending(swigCPtr);
  }

  public virtual void disableBlending() {
    NeoNativeEnginePINVOKE.MRenderingContext_disableBlending(swigCPtr);
  }

  public virtual void setBlendingMode(M_BLENDING_MODES mode) {
    NeoNativeEnginePINVOKE.MRenderingContext_setBlendingMode(swigCPtr, (int)mode);
  }

  public virtual void setPointSize(float size) {
    NeoNativeEnginePINVOKE.MRenderingContext_setPointSize(swigCPtr, size);
  }

}
