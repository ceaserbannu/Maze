using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldCoin : ICoins
{
    public static object Console { get; private set; }
    public int TotalCoins { get; set; }

    public EnCoinType CoinType
    {
        get { return EnCoinType.Gold; }
    }

    public void GetDisplayOfCollectingCoins()
    {
       
    }
}

