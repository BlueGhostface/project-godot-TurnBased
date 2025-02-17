using System;
using Godot;
using Godot.Collections;


public partial class OptionsMenu : Container
{


    public Action<BaseButton> ButtonFocused;
    public Action<BaseButton> ButtonPressed;
    
    bool is_dummy = false;


    public Array<Node>  getButtons(){
        return GetChildren();
    }

    public void connectToButton(){

        foreach(Button button in getButtons()){
            button.FocusEntered += () => ButtonFocused?.Invoke(button);
            button.Pressed += () => ButtonPressed?.Invoke(button);
        }

    }
    public override void _Ready()
    {
        SetProcessUnhandledInput(false);

        if(!is_dummy){
            
            
        }

        if (is_dummy){
            return;
        }

        connectToButton();
    }


}
