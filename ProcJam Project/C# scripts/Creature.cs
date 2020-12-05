using Godot;
using System;
using Anatomy;

public class Creature : Node2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    private Body _cretureBody;
    private Appendage _creatureAppendage;
    //public Behavior creatureBehavior;
    public ILocomotor creatureLocomotor;
    public MovementType creatureMovement;


    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
