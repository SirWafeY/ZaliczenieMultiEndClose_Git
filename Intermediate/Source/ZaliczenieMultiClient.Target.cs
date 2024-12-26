using UnrealBuildTool;

public class ZaliczenieMultiClientTarget : TargetRules
{
	public ZaliczenieMultiClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("ZaliczenieMulti");
	}
}
