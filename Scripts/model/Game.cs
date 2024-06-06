using Godot;
using System;

public partial class Game : Node2D
{
	private AudioStreamPlayer2D audio;
	public static bool reload;
	public Camera2D camera;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		audio = GetNode<AudioStreamPlayer2D>("backGround");
        audio.Play(GlobalVars.musicProgress);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (reload)
        {
			GlobalVars.musicProgress = audio.GetPlaybackPosition();
            GetTree().ReloadCurrentScene();
			reload = false;
		}
	}

    public void OnTeleport(CharacterBody2D body)
	{
		var p = body.GetTree().CurrentScene.Name;
		GD.Print(body);
		if (p == "Level01")

        {
			body.GetTree().ChangeSceneToFile("res://Scenes/transition_01.tscn");
        }

		if (p == "Level02")
		{
			
			body.GetTree().ChangeSceneToFile("res://Scenes/transition_02.tscn");
		}

		if (p == "level03")
		{
            body.GetTree().ChangeSceneToFile("res://Scenes/cutscene_02.tscn");
        }


		audio.Play(0.0f);
	}









}
