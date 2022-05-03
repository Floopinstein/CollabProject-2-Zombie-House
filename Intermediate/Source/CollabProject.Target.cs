using UnrealBuildTool;

public class CollabProjectTarget : TargetRules
{
	public CollabProjectTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("CollabProject");
	}
}
