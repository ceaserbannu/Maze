using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Xml.Linq;
using System.Linq;
using System;

public class MazeXMLParser : MonoBehaviour
{
    // Start is called before the first frame update
    public static void loadXMLDoc()
    {
        // Load the XML file from our project directory containing the maze actions
        var filename = "Assets/Scripts/MazeActions.xml";
        var currentDirectory = Directory.GetCurrentDirectory();
        var mazeFilePath = Path.Combine(currentDirectory, filename);

        XElement mazeElement = XElement.Load(mazeFilePath);
        Debug.Log("**** Name of XML file:" + filename);

        IEnumerable<string> moveForwardAction = from item in mazeElement.Descendants("Maze")
                                      select (string)item.Element("MoveForward");
        IEnumerable<string> moveBackAction = from item in mazeElement.Descendants("Maze")
                                                select (string)item.Element("MoveBack");
        IEnumerable<string> turnLeftAction = from item in mazeElement.Descendants("Maze")
                                                select (string)item.Element("TurnLeft");
        IEnumerable<string> turnRightAction = from item in mazeElement.Descendants("Maze")
                                                select (string)item.Element("TurnRight");

        Debug.Log("the actions are " + moveForwardAction.ToString() + moveBackAction.ToString() + turnLeftAction.ToString() + turnRightAction.ToString());
    }
}
