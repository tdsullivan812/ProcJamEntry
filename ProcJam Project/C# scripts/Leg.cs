using System;
using Godot;
using Anatomy;

public class Leg : Appendage, ILocomotor
{

    //Consider using constructor to randomly decide movement type



    public override void Move()
    {
        switch (this.appendageMovement)
        {
            case MovementType.Walk:
                Walk();
                break;
            
            case MovementType.None:
                break;
        }
    }

    public void Walk()
    {

    }



}
