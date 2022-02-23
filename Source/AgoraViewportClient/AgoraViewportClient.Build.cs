// Created by Satheesh. Copyright 2020.
// https://twitter.com/ryanjon2040. Discord - ryanjon2040#5319
// Please support Agora by becoming a Patron: https://www.patreon.com/ryanjon2040

using UnrealBuildTool;

public class AgoraViewportClient : ModuleRules
{
	public AgoraViewportClient(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
		bUseUnity = false;

#if UE_4_26_OR_LATER
		PublicDependencyModuleNames.AddRange(new []
		{
			"Core",
			"DeveloperSettings"
 });
#else
		PublicDependencyModuleNames.AddRange(new []
		{
			"Core"
		});
#endif

		PrivateDependencyModuleNames.AddRange(new []
		{
			"CoreUObject",
			"Engine",
			"Slate",
			"SlateCore",
			"RHI",
			"InputCore"
		});
	}
}