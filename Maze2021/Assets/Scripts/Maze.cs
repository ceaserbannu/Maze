using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maze : MonoBehaviour
{
    protected int width = 30;
    protected int depth = 30;
    protected byte[,] map;
    private int scale = 6;

    // Start is called before the first frame update
    void Start()
    {
        map = new byte[width, depth];
        InitializeMap();
        CrawlMap();
        DrawMap();

    }

    private void InitializeMap()
    {
        int aWidth = 0;
        int aDepth = 0;

        while (aDepth < depth)
        {
            while (aWidth < width)
            {
                map[aWidth, aDepth] = 1;
                aWidth = aWidth + 1;
            }
            aWidth = 0;
            aDepth = aDepth + 1;
        }

    }

    protected virtual void CrawlMap()
    {
        int aWidth = 0;
        int aDepth = 0;

        while (aDepth < depth)
        {
            while (aWidth < width)
            {
                if (Random.Range(0, 100) < 50)
                {
                    map[aWidth, aDepth] = 0;
                }

                aWidth = aWidth + 1;
            }
            aWidth = 0;
            aDepth = aDepth + 1;
        }




    }
    private void DrawMap()
    {
        int aWidth = 0;
        int aDepth = 0;

        while (aDepth < depth)
        {
            while (aWidth < width)
            {

                if (map[aWidth, aDepth] == 1)
                {
                    Vector3 aPosition = new Vector3(aWidth * scale, 0, aDepth * 6);
                    // this line draws the cubes
                    GameObject wall = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    // rescale the cubes
                    wall.transform.localScale = new Vector3(scale, scale, scale);
                    wall.transform.position = aPosition;
                }

                aWidth = aWidth + 1;
            }
            aWidth = 0;
            aDepth = aDepth + 1;
        }
    }



    // Update is called once per frame
    void Update()
    {

    }
}
