using System;
using Godot;
using Anatomy;

public class Tentacle : Appendage, ILocomotor
{

    //Consider using constructor to randomly decide movement type



    public override void Move()
    {
        switch (this.appendageMovement)
        {
            case MovementType.Push:
                Push();
                break;
            case MovementType.Pull:
                Pull();
                break;
            case MovementType.Swing:
                Swing();
                break;
            case MovementType.Attach:
                Attach();
                break;
            case MovementType.Walk:
                Walk();
                break;
            case MovementType.None:
                break;
        }
    }

    public void Push()
    {

    }

    public void Pull()
    {

    }

    public void Swing()
    {

    }

    public void Attach()
    {

    }

    public void Walk()
    {

    }
}
