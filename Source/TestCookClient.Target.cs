// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class TestCookClientTarget : TargetRules
{
	public TestCookClientTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Client;

		ExtraModuleNames.AddRange( new string[] { "TestCook" } );
	}
}
