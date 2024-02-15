using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BiplaneStats : MonoBehaviour
{
    public int Health;
    public Score score;

 
    

    private void OnTriggerEnter(Collider other)
    {
        Bomb bomb = other.gameObject.GetComponent<Bomb>();
        


        if (bomb)
        {
            Health -= 1;
            if (Health <= 0)
            {
                gameObject.SetActive(false);
            }
            bomb.Explosion();

        }

        Coin coin = other.gameObject.GetComponent<Coin>();
        if (coin)
        {
            score.AddCoin();
            coin.CollectedCoin();
        }
        
    }
}
