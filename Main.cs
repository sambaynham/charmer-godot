using Godot;
using System;

public class Main : Node
{
	// Don't forget to rebuild the project so the editor knows about the new export variable.
	[Export]
	public PackedScene Mob;

	private int _score;

	// We use 'System.Random' as an alternative to GDScript's random methods.
	private Random _random = new Random();

	public override void _Ready()
	{
	}

	// We'll use this later because C# doesn't support GDScript's randi().
	private float RandRange(float min, float max)
	{
		return (float)_random.NextDouble() * (max - min) + min;
	}
}
