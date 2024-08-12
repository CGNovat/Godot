using Godot;
using System;

public partial class MovPers1 : CharacterBody2D
{
	public const float Velocidad = 150.0f;
	 private KinematicBody2D player;

	public override void _Ready()
	{
		// Inicializar los nodos
		player = GetNode<KinematicBody2D>(".");
		animcacion = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
	}

	public override void _PhysicsProcess(float delta)
	{
		Vector2 movement = new Vector2();

		if (Input.IsActionPressed("IZQUIERDA"))
		{
			movement.x -= Velocidad * delta;
			animcacion.Play("IzqCam");
		}
		else if (Input.IsActionPressed("DERECHA"))
		{
			movement.x += Velocidad * delta;
			animcacion.Play("DerCam");
		}
		else if (Input.IsActionPressed("ARRIBA"))
		{
			movement.y -= Velocidad * delta;
			animcacion.Play("ArribCam");
		}
		else if (Input.IsActionPressed("ABAJO"))
		{
			movement.y += Velocidad * delta;
			animcacion.Play("AbajoCam");
		}
		else
		{
			animcacion.Stop();
		}

		// Mover el jugador
		player.Position += movement;

		// Usar el método move_and_slide equivalente en C#
		MoveAndSlide(movement);
	}
}
