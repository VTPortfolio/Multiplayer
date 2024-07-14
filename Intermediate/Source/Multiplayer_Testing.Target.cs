using UnrealBuildTool;

public class Multiplayer_TestingTarget : TargetRules
{
	public Multiplayer_TestingTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Multiplayer_Testing");
	}
}
