using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crawler : Maze
{

    protected override void CrawlMap()
    {
        CrawlXPath();
        CrawlXPath();
        CrawlXPath();
        CrawlZPath();
        CrawlZPath();
    }

    private void CrawlXPath()
    {
        int x = 0;
        int z = Random.Range(5, depth - 5);
        bool done = false;

        while (!done)
        {
            map[x, z] = 0;
            if (Random.Range(0, 100) > 50)
            {
                x = x + Random.Range(0, 2);
            }
            else
            {
                z = z + Random.Range(-1, 2);
            }

            if (x < 0 || x > width - 1 || z < 0 || z > depth - 1)
            {
                done = true;
            }
        }
    }

    private void CrawlZPath()
    {
        int x = Random.Range(5, width - 5);
        int z = 0;
        bool done = false;

        while (!done)
        {
            map[x, z] = 0;
            if (Random.Range(0, 100) > 50)
            {
                x = x + Random.Range(-1, 2);
            }
            else
            {
                z = z + Random.Range(0, 2);
            }


            if (x < 0 || x > width - 1 || z < 0 || z > depth - 1)
            {
                done = true;
            }
        }
    }

}
