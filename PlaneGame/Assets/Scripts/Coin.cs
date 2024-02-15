using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public void CollectedCoin()
    {
        Destroy(gameObject);
    }

    private void Update()
    {
        transform.Rotate(0, 1, 0);
    }
}
