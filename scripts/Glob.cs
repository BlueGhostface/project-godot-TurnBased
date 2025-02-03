using System;
using System.Diagnostics;
using Godot;

public partial class Glob : Node
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	SetProcessUnhandledKeyInput(true);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public override void _UnhandledInput (InputEvent @event){

		if(@event is InputEventKey keyEvent && keyEvent.Pressed){
			Debug.WriteLine("I'm being pressed");
			Key key = keyEvent.Keycode;
			switch (key)
			{
				case Key.R:
					GetTree().ReloadCurrentScene();
					break;
				case Key.Escape:
					GetTree().Quit();
					break;
				case Key.F11:
					var is_fullscreen = DisplayServer.WindowGetMode() == DisplayServer.WindowMode.Fullscreen;
					var targetMode = !is_fullscreen? DisplayServer.WindowMode.Fullscreen : DisplayServer.WindowMode.Windowed;
					DisplayServer.WindowSetMode(targetMode);
					break;
					
			}

		}
	}
}
