using Godot;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Reflection.Metadata;

public partial class Character : Node2D
{

    readonly Random rnd;

	//character stats
	[Export] int max_hp = 10;
	[Export] int strenght = 10;
	[Export] int mana = 10;

	//character level experience
	[Export] public int Level { get ; set;} = 1;

	public int Experience { get ; set;} = 0;
	public int Experience_total  = 0;
	public int Experience_required { get ; set;} = 0;


	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}


	private int Get_required_experience(int level)
	{
		return (int)Math.Round(Math.Pow(level, 1.8) + level * 4);

	}

	public void Gain_experience(int amount)
	{
		Experience_total += amount;
		Experience += amount;
		while (Experience > Experience_required)
		{
			Experience -= Experience_required;
			levelup();
		}
	}

	private void levelup()
	{
		++Level;
		Experience_required = Get_required_experience(Level);
		LevelupRandomStat();
	}

	private void LevelupRandomStat()
	{
		int bonusIncrement = rnd.Next(2,6);

		List<String> stats = ["max_hp", "strenght", "mana"];
		var random_stat = stats[rnd.Next(stats.Count) % stats.Count];

		switch(random_stat){
			case "max_hp":
				max_hp +=bonusIncrement;
				break;
			case "strenght":
				strenght +=bonusIncrement;
				break;
			case "mana":
				mana +=bonusIncrement;
				break;

		}
	}




}
