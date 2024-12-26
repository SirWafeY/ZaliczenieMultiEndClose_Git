using UnrealBuildTool;

public class ZaliczenieMultiServerTarget : TargetRules
{
	public ZaliczenieMultiServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("ZaliczenieMulti");
	}
}
