using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BronzeCoin : ICoins

{
    public EnCoinType CoinType
    {
        get { return EnCoinType.Bronze; }
    }
    public int TotalCoins { get; set; }

    public void GetDisplayOfCollectingCoins()

        //GetExtrinsicState()
    {
        
    }
}