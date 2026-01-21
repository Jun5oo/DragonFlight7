using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    const int SPAWN_Y = 6; 
    [SerializeField] GameObject monsterPrefab;

    public bool spawnEnabled = false; 

    int[] monsterSpawnLine;
    
    void Start()
    {
        monsterSpawnLine = new int[5] { -2, -1, 0, 1, 2 };
        InvokeRepeating("Spawn", 0, 1f); 
    }

    void Spawn()
    {
        if (!spawnEnabled) return; 

        Shuffle();

        int selected = monsterSpawnLine[0];
        Instantiate(monsterPrefab, new Vector3(selected, SPAWN_Y), Quaternion.identity); 
    }

    void Shuffle()
    {
        for(int i= monsterSpawnLine.Length - 1;  i > 0;  i--)
        {
            int rand = Random.Range(0, i+1);
            int temp = monsterSpawnLine[i];
            monsterSpawnLine[i] = monsterSpawnLine[rand];
            monsterSpawnLine[rand] = temp; 
        }
    }
}
