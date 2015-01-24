using System.Reflection;
using System;
using System.Runtime.InteropServices;

public class NeoGame
{
	private static Assembly externalAssembly;
	private static Type gameClassType;
	
	private static MethodInfo onBeginMethod;
	private static MethodInfo updateMethod;
	private static MethodInfo onEndMethod;
	
	static void loadExternalAssembly()
	{
		try
		{
			externalAssembly = Assembly.LoadFile("MonoGame.dll");
			System.Object obj = externalAssembly.CreateInstance("Game");
			
			gameClassType = obj.GetType();			
			onBeginMethod = gameClassType.GetMethod("onBegin");
			updateMethod = gameClassType.GetMethod("update");
			onEndMethod = gameClassType.GetMethod("onEnd");
		}
		catch(Exception e)
		{
			externalAssembly = null;
			onBeginMethod = null;
			updateMethod = null;
			onEndMethod = null;
			
			System.Console.WriteLine("[ ERROR ] Could not load MonoGame.dll: " + e.Message);	
		}
	}
	
	static void onBegin()
	{	
		if(externalAssembly != null)
		{
			onBeginMethod.Invoke(null, null);
		}
	}
	
	static void update()
	{
		if(externalAssembly != null)
		{
			updateMethod.Invoke(null, null);
		}
	}
	
	static void onEnd()
	{
		if(externalAssembly != null)
		{
			onEndMethod.Invoke(null, null);
		}
	}
}
