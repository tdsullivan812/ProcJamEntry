using System;
using Godot;
using Anatomy;

public class Expanding : Body, ILocomotor
{

    //Consider using constructor to randomly decide movement type

    public override void Move()
    {
        switch (this.bodyMovement)
        {
            case MovementType.Pulse:
                Pulse();
                break;

            case MovementType.None:
                break;
        }
    }


    public void Pulse()
    {

    }



}
