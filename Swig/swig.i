%module NeoNativeEngine
%{
	#include <NeoEngine.h>
	using namespace Neo;
%}

%include <MCore.h>
%include <MUtils.h>

%include <MMaths.h>
%include <MVector2.h>
%include <MVector3.h>
%include <MVector4.h>
%include <MColor.h>
%include <MMatrix4x4.h>
%include <MQuaternion.h>


%include <MSystemContext.h>
%include <MInputContext.h>
%include <MRenderingContext.h>
%include <MSoundContext.h>
%include <MPhysicsContext.h>
%include <MScriptContext.h>
%include <MImage.h>
%include <MSound.h>
%include <MStringTools.h>
%include <MDataManager.h>
%include <MDataLoader.h>

%include <NeoEngine.h>
%include <Level.h>
%include <Scene.h>
%include <Object3d.h>
%include <OEntity.h>
%include <OLight.h>
%include <OSound.h>
%include <OText.h>
%include <OCamera.h>
