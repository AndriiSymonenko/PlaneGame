using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropsCreator : MonoBehaviour
{
    public GameObject Coin;
    public GameObject Bomb;
    public int CoinQuantity;
    public int BombQuantity;
    void Start()
    {
        Creator(Coin, Bomb);
    }

    public void Creator(GameObject prefabCoin, GameObject prefabBomb)
    {
        
        for (int i = 0; i < CoinQuantity; i++)
        {
            if (Random.Range(0, 3) == 0)
            {
                Vector3 position = new Vector3(i, Random.Range(-20, 20), 0);
                Instantiate(prefabCoin, position, Quaternion.identity);
            }

        }
        for (int i = 0; i < BombQuantity; i++)
        {
            if (Random.Range(0, 6) == 0)
            {
                Vector3 position = new Vector3(i, Random.Range(-20, 20), 0);
                Instantiate(prefabBomb, position, Quaternion.identity);
            }
        }

    }

}
