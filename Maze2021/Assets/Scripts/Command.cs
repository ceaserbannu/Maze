using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Command
{
    public abstract void Execute(GameObject aCharacter, CharacterController aController);

    public abstract void Undo(GameObject aCharacter, CharacterController aController);



}

public class MoveForward : Command
{

    public override void Execute(GameObject aCharacter, CharacterController aController)
    {
        float hMove = 0f;
        float vMove = 2f;
        float speed = 1f;
        Vector3 aMove = aCharacter.transform.forward * vMove + aCharacter.transform.right * hMove;
        aController.Move(aMove * speed);
    }
    public override void Undo(GameObject aCharacter, CharacterController aController)
    {
        float hMove = 0f;
        float vMove = -2f;
        float speed = 1f;
        Vector3 aMove = aCharacter.transform.forward * vMove + aCharacter.transform.right * hMove;
        aController.Move(aMove * speed);
    }
}

public class MoveBack : Command
{

    public override void Execute(GameObject aCharacter, CharacterController aController)
    {
        float hMove = 0f;
        float vMove = -2f;
        float speed = 1f;
        Vector3 aMove = aCharacter.transform.forward * vMove + aCharacter.transform.right * hMove;
        aController.Move(aMove * speed);
    }

    public override void Undo(GameObject aCharacter, CharacterController aController)
    {
        float hMove = 0.0f;
        float vMove = 2f;
        float speed = 1f;
        Vector3 aMove = aCharacter.transform.forward * vMove + aCharacter.transform.right * hMove;
        aController.Move(aMove * speed);
    }


}

public class Turnleft : Command
{
    public override void Execute(GameObject aCharacter, CharacterController aController)
    {
        aCharacter.transform.Rotate(0, -90.0f, 0, 0f);
    }

    public override void Undo(GameObject aCharacter, CharacterController aController)
    {
        aCharacter.transform.Rotate(0, 90.0f, 0, 0f);
    }
}

public class TurnRight : Command
{
    public override void Execute(GameObject aCharacter, CharacterController aController)
    {
        aCharacter.transform.Rotate(0, 90.0f, 0, 0f);
    }

    public override void Undo(GameObject aCharacter, CharacterController aController)
    {
        aCharacter.transform.Rotate(0, -90.0f, 0, 0f);
    }
}
