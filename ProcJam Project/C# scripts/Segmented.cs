using System;
using Godot;
using Anatomy;

public class Segmented : Body, ILocomotor
{

    //Consider using constructor to randomly decide movement type

    public override void Move()
    {
        switch (this.bodyMovement)
        {
            case MovementType.Slither:
                Slither();
                break;
            case MovementType.Pulse:
                Pulse();
                break;
            case MovementType.Attach:
                Attach();
                break;
            case MovementType.None:
                break;
        }
    }

    public void Slither()
    {

    }

    public void Pulse()
    {

    }

    public void Attach()
    {

    }


}
