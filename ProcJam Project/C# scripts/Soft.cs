using System;
using Godot;
using Anatomy;

public class Soft : Body, ILocomotor
{

    //Consider using constructor to randomly decide movement type

    public override void Move()
    {
        switch (this.bodyMovement)
        {
            case MovementType.Roll:
                Roll();
                break;
            case MovementType.Pulse:
                Pulse();
                break;
            case MovementType.Slither:
                Slither();
                break;
            case MovementType.Swim:
                Swim();
                break;
            case MovementType.Attach:
                Attach();
                break;
            case MovementType.Pull:
                Pull();
                break;
            case MovementType.Swing:
                Swing();
                break;
            case MovementType.None:
                break;
        }
    }

    public void Roll()
    {

    }

    public void Pulse()
    {

    }

    public void Slither()
    {

    }

    public void Swim()
    {

    }

    public void Attach()
    {

    }

    public void Pull()
    {

    }

    public void Swing()
    {

    }

}
