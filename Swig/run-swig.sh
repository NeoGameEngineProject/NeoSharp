rm *.cs
swig -csharp -c++ -Wall -I../NeoEngine/SDK/NeoEngine/Includes -I../NeoEngine/SDK/NeoCore/Includes -dllimport Game.so swig.i
