using System;
using Godot;
using Anatomy;

public class Chunk : Body, ILocomotor
{

    //Consider using constructor to randomly decide movement type

    public override void Move()
    {
        switch (this.bodyMovement)
        {
            case MovementType.Roll:
                Roll();
                break;
            case MovementType.None:
                break;
        }
    }

    public void Roll()
    {

    }


}
