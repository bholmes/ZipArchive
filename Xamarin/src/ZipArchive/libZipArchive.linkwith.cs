using System;
using MonoTouch.ObjCRuntime; using ObjCRuntime;

[assembly: LinkWith ("libZipArchive.a", 
#if __UNIFIED__
	LinkTarget.Simulator | LinkTarget.Simulator64| LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Arm64,
#else
	LinkTarget.Simulator | LinkTarget.ArmV7 | LinkTarget.ArmV7s, 
#endif
	ForceLoad = true)]
