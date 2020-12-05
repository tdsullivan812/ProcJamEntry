using System;
using Godot;
using Anatomy;

public class Fin : Appendage, ILocomotor
{

    //Consider using constructor to randomly decide movement type



    public override void Move()
    {
        switch (this.appendageMovement)
        {
            case MovementType.Push:
                Push();
                break;
            case MovementType.Swim:
                Swim();
                break;
            case MovementType.None:
                break;
        }
    }

    public void Push()
    {

    }

    public void Swim()
    {

    }


}
