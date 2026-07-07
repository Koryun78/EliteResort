// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class EliteResort : ModuleRules
{
	public EliteResort(ReadOnlyTargetRules Target) : base(Target)
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
			"EliteResort",
			"EliteResort/Variant_Platforming",
			"EliteResort/Variant_Platforming/Animation",
			"EliteResort/Variant_Combat",
			"EliteResort/Variant_Combat/AI",
			"EliteResort/Variant_Combat/Animation",
			"EliteResort/Variant_Combat/Gameplay",
			"EliteResort/Variant_Combat/Interfaces",
			"EliteResort/Variant_Combat/UI",
			"EliteResort/Variant_SideScrolling",
			"EliteResort/Variant_SideScrolling/AI",
			"EliteResort/Variant_SideScrolling/Gameplay",
			"EliteResort/Variant_SideScrolling/Interfaces",
			"EliteResort/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
