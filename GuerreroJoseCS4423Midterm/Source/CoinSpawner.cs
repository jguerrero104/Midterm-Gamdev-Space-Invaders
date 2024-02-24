using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private GameObject coinPrefab;
    [SerializeField] private float spawnRange = 10;
    public static FallingProj singleton;


    void Start(){

        SpawnCoins();
        
    }
    

    void update(){
        


    }

    void SpawnCoins(){
        StartCoroutine(SpawnCoinsRoutine());
        IEnumerator SpawnCoinsRoutine(){
            while(true){
            yield return new WaitForSeconds(1);

            SpawnCoinRandom();
            }
        }

    }



    void SpawnCoinRandom(){
        float randomX = Random.Range(-spawnRange,spawnRange);
        float y = 5;
        GameObject newCoin = Instantiate(coinPrefab, new Vector3(randomX, y, 0), Quaternion.identity);
        Destroy(newCoin, 10);
        newCoin.transform.eulerAngles = new Vector3(0, 0, 45);

    }

}
