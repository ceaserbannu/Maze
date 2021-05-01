using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : ICoins
{
    public static object Console { get; private set; }

    public EnCoinType CoinType
    {
        get; set;
    }
    public int TotalCoins { get ; set ; }

    public void GetDisplayOfCollectingCoins()
    {
        //This method would display graphical representation like 

       
                                      
    }
}