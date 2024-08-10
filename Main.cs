using Godot;
using System;

public partial class Main : Node2D
{
    private const string What = "puto el que lea";

    public override void _Ready()
	{
		GD.Print("Hola Tapia :C, Prueba 2 :V");
		GD.Print(What);
		
	}

	 
	public override void _Process(double delta)
	{
	}
}
