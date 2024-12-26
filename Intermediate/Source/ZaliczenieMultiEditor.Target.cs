using UnrealBuildTool;

public class ZaliczenieMultiEditorTarget : TargetRules
{
	public ZaliczenieMultiEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("ZaliczenieMulti");
	}
}
