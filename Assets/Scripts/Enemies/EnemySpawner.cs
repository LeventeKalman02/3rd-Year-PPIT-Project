using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//enemy spawner works off a wave based system so that the enemies spawned are random
//enemies will have a "cost" assigned to them so that the script can choose which enemies to spawn
public class EnemySpawner : MonoBehaviour
{
    //list for the different enemy types
    public List<Enemy> enemies = new List<Enemy>();
    public int currWave;
    public int waveValue;
    public List<GameObject> enemiesToSpawn = new List<GameObject>();
    public List<GameObject> spawnedEnemies = new List<GameObject>();
    [SerializeField] private GameObject portal;

    public Transform spawnLocation;
    public int waveDuration;
    private float waveTimer;
    private float spawnInterval;
    private float spawnTimer;
    private bool isSpawning;

    // Start is called before the first frame update
    void Start()
    {
        GenerateWave();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (spawnTimer <= 0)
        {
            //spawn enemy
            //check if we have any enemies to spawn
            if (enemiesToSpawn.Count > 0)
            {
                //check 
                GameObject obj = Instantiate(enemiesToSpawn[0], spawnLocation.position, Quaternion.identity);//spawn first enemy in list
                spawnedEnemies.Add(obj);
                enemiesToSpawn.RemoveAt(0);//remove from list when spawned
                spawnTimer = spawnInterval;
            }
            else
            {
                //if no enemies left to spawn, end the wave
                waveTimer = 0;
                //currWave++;
                //GenerateWave();
            }
        }
        else
        {
            //reduce the spawn timer and the wave timer
            spawnTimer -= Time.fixedDeltaTime;
            waveTimer -= Time.fixedDeltaTime;
        }

        StartNextWave();
    }

    //every 10 waves, give player option to return to the base scene
    public IEnumerator ReturnToBase()
    {
        //every 10 waves enable the portal
        if (currWave % 10 == 0)
        {
            portal.SetActive(true);
            yield return new WaitForSeconds(15);
            portal.SetActive(false);
            GenerateWave();
        }
        else
        { 
            portal.SetActive(false);
            GenerateWave();
        }
    }

    //check for the current amount of enemies alive and end the wave if they are all dead
    public void StartNextWave()
    {
        //loop over list of spawned enemies to check if there is any alive before starting the next wave
        //reversed for loop
        for (int i = spawnedEnemies.Count -1; i >= 0; i--)
        {
            //check if entry is null, if true, remove from the list
            if (spawnedEnemies[i] == null)
            {
                spawnedEnemies.RemoveAt(i);
            }
        }

        //check if spawnedEnemies.count == 0 && check if waveTimer == 0 to make sure all enemies in the wave have been spawned
        //if true, increase wave
        if (spawnedEnemies.Count == 0 && waveTimer == 0 && isSpawning)
        {
            currWave++;
            isSpawning = false;
            StartCoroutine(ReturnToBase());
        }        
    }

    //generate the wave
    public void GenerateWave()
    {
        waveValue = currWave * 10;
        GenerateEnemies();

        spawnInterval = waveDuration / enemiesToSpawn.Count; //gives a fixed time between each enemies
        waveTimer = waveDuration; //wave duration is read only
    }

    //generate the enemies for each wave
    public void GenerateEnemies()
    {
        //create a temp list of enemies to generate
        List<GameObject> generatedEnemies = new List<GameObject>();

        //in a loop grab a random enemy
        //see if we can afford to spawn it
        //if we can, add it to our list and deduct cost
        while (waveValue > 0)
        {
            int randEnemyId = Random.Range(0, enemies.Count);
            int randEnemyCost = enemies[randEnemyId].cost;
            //repeat
            if (waveValue - randEnemyCost >= 0)
            {
                generatedEnemies.Add(enemies[randEnemyId].enemyPrefab);
                //subtract the cost
                waveValue -= randEnemyCost;
            }
        }
        //clear the list
        enemiesToSpawn.Clear();
        enemiesToSpawn = generatedEnemies;
        isSpawning = true;
    }

}

//enemy class serializable so that list can be changed in the editor
[System.Serializable]
public class Enemy
{
    public GameObject enemyPrefab;
    public int cost;
}
