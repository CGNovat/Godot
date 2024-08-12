extends CharacterBody2D


const Velocidad = 150
@onready var player = $"."
@onready var animcacion= $AnimatedSprite2D

func _physics_process(_delta):
	
 
	if Input.is_action_pressed("IZQUIERDA"):
		player.position.x -= Velocidad * _delta
		animcacion.play("IzqCam")
	
	elif Input.is_action_pressed("DERECHA"):
		player.position.x += Velocidad * _delta
		animcacion.play("DerCam")
	
	elif Input.is_action_pressed("ARRIBA"):
		player.position.y -= Velocidad * _delta
		animcacion.play("ArribCam")
		
 
	elif Input.is_action_pressed("ABAJO"):
		player.position.y += Velocidad * _delta
		animcacion.play("AbajoCam")
		
	
	#
	else:
		animcacion.stop()
	
	move_and_slide()
