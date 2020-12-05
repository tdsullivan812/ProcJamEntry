using System;
using Godot;

namespace Anatomy
{
    public enum BodyType
    {
        Chunk,
        Segmented,
        Soft,
        Long,
        Proportioned,
        Expanding,
        Asymmetric
    }

    public enum AppendageType
    {
        Arm,
        Leg,
        Tail,
        Tentacle,
        Wing,
        Fin,
        Tongue,
        None
    }

    public enum MovementType
    {
        Slither,
        Pulse,
        Walk,
        Pull,
        Swim,
        Fly,
        Push,
        Swing,
        Attach,
        Roll,
        None
    }

    public interface ILocomotor
    {
        void Move();
    }

}
