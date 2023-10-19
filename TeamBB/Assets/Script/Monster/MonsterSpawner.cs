using UnityEngine;
using System.Collections.Generic;

public class MonsterSpawner : MonoBehaviour
{
    [System.Serializable]
    public class RoundInfo
    {
        public string roundName;
        public List<GameObject> objectsToSpawn;
        public float timeBetweenSpawns;
    }

    public List<RoundInfo> rounds = new List<RoundInfo>();

    private int currentRound = 0;
    private int objectsSpawned = 0;
    private float nextSpawnTime = 0.0f;

    void Update()
    {
        if (currentRound < rounds.Count)
        {
            if (Time.time >= nextSpawnTime)
            {
                if (objectsSpawned < rounds[currentRound].objectsToSpawn.Count)
                {
                    GameObject objectPrefab = rounds[currentRound].objectsToSpawn[objectsSpawned];
                    SpawnObject(objectPrefab);

                    objectsSpawned++;
                    nextSpawnTime = Time.time + rounds[currentRound].timeBetweenSpawns;
                }
                else
                {
                    // ��� ������Ʈ�� �����Ǿ����� Ȯ��
                    GameObject[] spawnedObjects = GameObject.FindGameObjectsWithTag("SpawnedObject");
                    if (spawnedObjects.Length == 0)
                    {
                        currentRound++;
                        objectsSpawned = 0;
                    }
                }
            }
        }
    }

    private void SpawnObject(GameObject objectPrefab)
    {
        if (objectPrefab != null)
        {
            // ���ϴ� ���� ��ġ�� ������ �����ϰ� �������� ����
            Vector3 spawnPosition = new Vector3(0, 0, 0); // ���ϴ� ��ġ�� ����
            Quaternion spawnRotation = Quaternion.identity; // ���ϴ� �������� ����

            GameObject spawnedObject = Instantiate(objectPrefab, spawnPosition, spawnRotation);
            spawnedObject.tag = "SpawnedObject"; // ������ ������Ʈ�� �±� �Ҵ�
        }
    }
}
