using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//https://www.youtube.com/watch?v=SELTWo1XZ0c&ab_channel=ModdingbyKaupenjoe source
public class EnemySpawnB : MonoBehaviour
{
   [SerializeField] private GameObject enemy;
    public int x;
    public int y;
    public int counter = 0;
    public int limit = 2;
    public bool enemyDead;
    void Start()
    {
        StartCoroutine(EnemyDrop(enemy));
    }

        IEnumerator EnemyDrop(GameObject enemy)
    
    {

        //NEED TO FIX, should be 2 enemies at a time, when one dies, another will spawn.
           	while(counter < limit)
          	{
            x = Random.Range(-25,25);
            y = Random.Range(10, -13);
            yield return new WaitForSeconds(3f);
            Instantiate(enemy, new Vector2(x,y), Quaternion.identity);
             
                enemyDead = false;
                
                counter++;
                yield return new WaitForSeconds(3f);
          		}
          		yield return new WaitUntil(() => enemyDead == true);
          		StartCoroutine(EnemyDrop(enemy));

          	}
      		}

