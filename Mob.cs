using Godot;
using System;

public class Mob : RigidBody2D
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";
	[Export]
	public int MinSpeed = 150; // Minimum speed range.
	
	[Export]
	public int MaxSpeed = 250; // Maximum speed range.

	static private Random _random = new Random();
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		var animSprite = GetNode<AnimatedSprite>("AnimatedSprite");
		var mobTypes = animSprite.Frames.GetAnimationNames();
		animSprite.Animation = mobTypes[_random.Next(0, mobTypes.Length)];
	}

	private void _on_VisibilityNotifier2D_screen_exited()
	{
		QueueFree();
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}


