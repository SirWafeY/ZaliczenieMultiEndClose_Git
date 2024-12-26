using UnrealBuildTool;

public class ZaliczenieMultiTarget : TargetRules
{
	public ZaliczenieMultiTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("ZaliczenieMulti");
	}
}
