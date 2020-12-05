using System;
using Godot;
using Anatomy;

public class Wing : Appendage, ILocomotor
{

    //Consider using constructor to randomly decide movement type



    public override void Move()
    {
        switch (this.appendageMovement)
        {
            case MovementType.Fly:
                Fly();
                break;
            case MovementType.None:
                break;
        }
    }

    public void Fly()
    {

    }


}
