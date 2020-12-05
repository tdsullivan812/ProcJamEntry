using System;
using Godot;
using Anatomy;

public class Tongue : Appendage, ILocomotor
{

    //Consider using constructor to randomly decide movement type



    public override void Move()
    {
        switch (this.appendageMovement)
        {
            case MovementType.Pull:
                Pull();
                break;
            case MovementType.Attach:
                Attach();
                break;
            case MovementType.None:
                break;
        }
    }

    public void Pull()
    {

    }

    public void Attach()
    {

    }


}
