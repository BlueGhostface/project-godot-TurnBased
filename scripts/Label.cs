using Godot;
using System;
using System.Text;

public partial class Label : Godot.Label
{

	public void Update_text(int level, int experience, int experience_required){
		Text =  $"Level : {level}\n"
        + $"Experience : {experience}\n"
        + $"Next Level : {experience_required}\n";
	}
}
