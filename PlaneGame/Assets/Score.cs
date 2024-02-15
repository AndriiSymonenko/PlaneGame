using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public int Coins;
    public TMP_Text CoinCounter;

    //Coin coin;

    public void AddCoin()
    {
        Coins += 1;
        CoinCounter.text = Coins.ToString();
    }

}
