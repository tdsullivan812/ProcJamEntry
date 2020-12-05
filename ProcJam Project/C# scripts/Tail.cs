using System;
using Godot;
using Anatomy;

public class Tail : Appendage, ILocomotor
{

    //Consider using constructor to randomly decide movement type



    public override void Move()
    {
        switch (this.appendageMovement)
        {
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


    public void Pull()
    {

    }

    public void Swing()
    {

    }


}
