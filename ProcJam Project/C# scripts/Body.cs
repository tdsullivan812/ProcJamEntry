using Godot;
using System;
using Anatomy;

public abstract class Body : Node2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";
    private int _segmentQuantity;
    private Polygon2D _segmentShape;
    private BodyType _whichBody;
    public MovementType bodyMovement;







    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }



}
