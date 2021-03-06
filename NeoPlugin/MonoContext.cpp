#include "MonoContext.h"
#include <NeoEngine.h>
#include <mono/metadata/debug-helpers.h>
#include <mono/metadata/threads.h>

MonoContext::MonoContext()
{
	// TODO Auto-generated constructor stub
}

MonoContext::~MonoContext()
{
	// TODO Auto-generated destructor stub
}

void MonoContext::loadAssembly(const char* path)
{
	if(!path)
		return;

	clear();

	domain = mono_jit_init("MainDomain");
	assembly = mono_domain_assembly_open(domain, path);

	if(!assembly)
	{
		MLOG_ERROR("Could not load assembly: " << path);
		return;
	}

}

void MonoContext::addAssembly(const char* path)
{
	if(!path || !domain)
		return;

	// FIXME: More fine grained control over what assembly to use!
	assembly = mono_domain_assembly_open(domain, path);

	if(!assembly)
	{
		MLOG_ERROR("Could not load assembly: " << path);
		return;
	}
}

void MonoContext::callMethod(const char* name)
{
	attachToThread();

	MonoMethodDesc* desc = mono_method_desc_new(name, true);
	MonoMethod* method = mono_method_desc_search_in_image(desc, mono_assembly_get_image(assembly));

	if(!method)
	{
		MLOG_ERROR("Could not call method: " << name);
		return;
	}

	mono_runtime_invoke(method, NULL, NULL, NULL);
}

void MonoContext::clear()
{

}

void MonoContext::attachToThread()
{
	mono_thread_attach(domain);
}
