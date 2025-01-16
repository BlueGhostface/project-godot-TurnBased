using Godot;
using System;

public partial class Game : Node2D
{


	Character _character;
	Label _label;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_character = GetNode<Character>("Character");
		_label = GetNode<Label>("Interface/Label");
		_label.Update_text(_character.Level, _character.Experience, _character.Experience_required);

	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

		if (Input.IsKeyPressed(Key.Space))
		{
			_character.Gain_experience(50);
			_label.Update_text(_character.Level, _character.Experience, _character.Experience_required);
		}
	}
}
