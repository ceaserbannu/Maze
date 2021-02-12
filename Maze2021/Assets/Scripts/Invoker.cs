using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoker : MonoBehaviour
{
    Command keyLeft, keyRight, keyForward, keyBack;
    public GameObject aGameObject;
    CharacterController aCharacterContorller;
    Stack<Command> undoPath;
    List<Command> macroPath;
    Stack<Command> redoPath;
    Vector3 startPosition;
    Quaternion facingAtStart;
    Vector3 rightNowAt;




    // Start is called before the first frame update
    void Start()
    {
        keyLeft = new Turnleft();
        keyRight = new TurnRight();
        keyForward = new MoveForward();
        keyBack = new MoveBack();
        aCharacterContorller = aGameObject.GetComponent<CharacterController>();
        undoPath = new Stack<Command>();
        macroPath = new List<Command>();
        redoPath = new Stack<Command>();
        startPosition = aGameObject.transform.position;
        facingAtStart = aGameObject.transform.rotation;
        rightNowAt = startPosition;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lastPosition = rightNowAt;
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            keyForward.Execute(aGameObject, aCharacterContorller);
            redoPath.Clear();
            rightNowAt = aGameObject.transform.position;
            if (rightNowAt != lastPosition)
            {
                undoPath.Push(keyForward);
                macroPath.Add(keyForward);
            }

        }

        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            keyBack.Execute(aGameObject, aCharacterContorller);
            redoPath.Clear();
            rightNowAt = aGameObject.transform.position;
            if (rightNowAt != lastPosition)
            {
                undoPath.Push(keyBack);
                macroPath.Add(keyBack);
            }
        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            keyRight.Execute(aGameObject, aCharacterContorller);
            undoPath.Push(keyRight);
            macroPath.Add(keyRight);
            redoPath.Clear();
            rightNowAt = aGameObject.transform.position;
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            keyLeft.Execute(aGameObject, aCharacterContorller);
            undoPath.Push(keyLeft);
            macroPath.Add(keyLeft);
            redoPath.Clear();
            rightNowAt = aGameObject.transform.position;
        }

        if (Input.GetKeyUp(KeyCode.Z))
        {
            StepBack();
            rightNowAt = aGameObject.transform.position;
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            aCharacterContorller.transform.position = startPosition;
            aCharacterContorller.transform.rotation = facingAtStart;
            rightNowAt = aGameObject.transform.position;
        }


        //if (Input.GetKeyUp(KeyCode.Y))
        //{
        //    Redo();
        //}
    }

    //void Redo()
    //{
    //    if(redoPath.Count > 0)
    //    {
    //        Command redoCommand = redoPath.Pop();
    //        if (redoCommand == keyForward)
    //        {
    //            keyForward.Execute(aGameObject, aCharacterContorller);
    //            macroPath.Add(keyForward);
    //            undoPath.Push(keyForward);

    //        }

    //        if (redoCommand == keyBack)
    //        {
    //            keyBack.Execute(aGameObject, aCharacterContorller);
    //            macroPath.Add(keyBack);
    //            undoPath.Push(keyBack);

    //        }

    //        if (redoCommand == keyRight)
    //        {
    //            keyRight.Execute(aGameObject, aCharacterContorller);
    //            macroPath.Add(keyRight);
    //            undoPath.Push(keyRight);

    //        }

    //        if (redoCommand == keyLeft)
    //        {
    //            keyLeft.Execute(aGameObject, aCharacterContorller);
    //            macroPath.Add(keyLeft);
    //            undoPath.Push(keyLeft);
    //        }
    //    }

    //}

    void StepBack()
    {
        if (undoPath.Count > 0)
        {
            Command undoCommand = undoPath.Pop();
            undoCommand.Undo(aGameObject, aCharacterContorller);
            macroPath.RemoveAt(macroPath.Count - 1);
        }

    }
}
