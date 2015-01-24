#ifdef _WIN32
	#include <windows.h>
	extern "C" __declspec(dllexport) void StartPlugin(void);
	extern "C" __declspec(dllexport) void EndPlugin(void);
#else
	extern "C" void StartPlugin(void);
	extern "C" void EndPlugin(void);
#endif

#include <NeoEngine.h>
#include "MonoSubgame.h"
#include "MonoContext.h"

using namespace Neo;

MonoSubgame* sg = new MonoSubgame();

extern "C" void StartPlugin()
{
	NeoEngine* engine = NeoEngine::getInstance();
	NeoGame* game = engine->getGame();
	MonoContext* monoContext = MonoContext::getInstance();

	game->registerSubGame(sg);

	// Load our assembly
	monoContext->loadAssembly("NeoSharp.dll");

	// Load external assembly with game specific code
	monoContext->callMethod("NeoGame:loadExternalAssembly()");
}

extern "C" void EndPlugin()
{
	SAFE_DELETE(sg);
}
