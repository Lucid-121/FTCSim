using Unity.Mathematics;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{

    [SerializeField] private GameObject CoinPrefab;
    [SerializeField] private GameObject groundCollider;
    [SerializeField] private int coinAmount = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < coinAmount; i++) {
            Instantiate(CoinPrefab, transform.position, transform.rotation);

        }
    }

}
