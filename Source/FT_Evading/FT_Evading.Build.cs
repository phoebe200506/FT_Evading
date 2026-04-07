// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class FT_Evading : ModuleRules
{
	public FT_Evading(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"FT_Evading",
			"FT_Evading/Variant_Platforming",
			"FT_Evading/Variant_Platforming/Animation",
			"FT_Evading/Variant_Combat",
			"FT_Evading/Variant_Combat/AI",
			"FT_Evading/Variant_Combat/Animation",
			"FT_Evading/Variant_Combat/Gameplay",
			"FT_Evading/Variant_Combat/Interfaces",
			"FT_Evading/Variant_Combat/UI",
			"FT_Evading/Variant_SideScrolling",
			"FT_Evading/Variant_SideScrolling/AI",
			"FT_Evading/Variant_SideScrolling/Gameplay",
			"FT_Evading/Variant_SideScrolling/Interfaces",
			"FT_Evading/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
