using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public partial class GameView : Control
{
    public async override void _Ready()
    {
        string sceneName = (String)GetTree().CurrentScene.Name;
        
        if (sceneName == "Transition01")
        {
            await ToSignal(GetTree().CreateTimer(2f), "timeout");
            GetTree().ChangeSceneToFile("res://Scenes/level_03.tscn");
        }

        if (sceneName == "Transition02")
        {
            await ToSignal(GetTree().CreateTimer(2f), "timeout");
            GetTree().ChangeSceneToFile("res://Scenes/level04.tscn");
        }
    }




    public void onAnimationFinished(string anim_name)
    {
        if (anim_name == "cutScene")
        {
            GetTree().ChangeSceneToFile("res://Scenes/Level02.tscn");
        }

    }

    public void OnFinishedCutscene02(string anim_name)
    {
        if (anim_name == "CutScene02")
        {
            GetTree().ChangeSceneToFile("res://Scenes/main_menu.tscn");
        }
    }


    public void _on_start_button_pressed()
    {
        GetTree().ChangeSceneToFile("res://Scenes/cutsene_main.tscn");
    }


}

