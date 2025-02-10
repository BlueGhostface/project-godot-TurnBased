using System;
using Godot;
using Godot.Collections;


public partial class OptionsMenu : Container
{


    public Action<BaseButton> ButtonFocused;
    public Action<BaseButton> ButtonPressed;
    


    public Array<Node>  getButtons(){
        return GetChildren();
    }

    public void connectToButton(){

        foreach(Button button in getButtons()){
            button.FocusEntered += () => ButtonFocused?.Invoke(button);
            button.Pressed += () => ButtonPressed?.Invoke(button);
        }

    }
}
