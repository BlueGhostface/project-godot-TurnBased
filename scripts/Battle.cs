using Godot;
using System;

public partial class Battle : Control
{


    HudPanel _options;
    OptionsMenu _optionsMenu;

    public override void _Ready()
    {
        _options = GetNode<HudPanel>("Options");
        _optionsMenu = GetNode<OptionsMenu>("OptionsMenu");

    }
}
