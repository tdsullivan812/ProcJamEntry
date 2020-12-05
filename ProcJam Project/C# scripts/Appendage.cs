using System;
using Godot;
using Anatomy;

public abstract class Appendage : Node2D
{
    private int _segmentQuantity;
    private Polygon2D _segmentShape;
    private AppendageType _whichAppendage;
    public MovementType appendageMovement;


    public override void _Ready()
    {

    }

}
