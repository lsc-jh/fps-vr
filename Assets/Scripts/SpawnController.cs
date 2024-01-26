using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public EnemyController monster;
    private Vector3 randomPos;
    private bool onGame = false;

    // Start is called before the first frame update
    void Start()
    {
        onGame = true;
        StartCoroutine(Spawing());
    }
  
    IEnumerator Spawing()
    {
      while(onGame) {
        yield return new WaitForSeconds(Random.Range(1, 4));
        randomPos = new Vector3(15, Random.Range(0.5f, 3), 23);
        Instantiate(monster, randomPos, Quaternion.Euler(0, 180, 0), transform);
      }
      StopCoroutine(Spawing());
    }
}
