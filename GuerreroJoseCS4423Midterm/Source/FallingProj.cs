using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallingProj : MonoBehaviour
{
    [SerializeField] private GameObject fallingObjectPrefab;
    public float speed = 5f;
    [SerializeField] private float spawnRange = 10;
   


    // Update is called once per frame
    void Start()
    {
        SpawnFallingObjects();

    }

    void SpawnFallingObjects(){
    StartCoroutine(SpawnFallingObjectsRoutine());
     IEnumerator SpawnFallingObjectsRoutine(){
    while (true){
        yield return new WaitForSeconds(3);
        SpawnFallingObjectRandom();
        }
    }

}




    void SpawnFallingObjectRandom(){
    float randomX = Random.Range(-spawnRange, spawnRange);
    float y = 5;
    GameObject newFallingObject = Instantiate(fallingObjectPrefab, new Vector3(randomX, y, 0), Quaternion.identity);
    Destroy(newFallingObject, 3);
    newFallingObject.transform.eulerAngles = new Vector3(0, 0, 0);
}

void OnCollisionEnter2D(Collision2D collision)
{
    // Check if the object collided with the player
    if (collision.gameObject.GetComponent<Creature>() != null)
    {
        // Restart the game
        SceneManager.LoadScene("MainMenu");
    }
}

}
