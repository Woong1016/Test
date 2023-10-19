using UnityEngine;
using System.Collections.Generic;

public class MonsterSpawner : MonoBehaviour
{
    public GameObject monsterPrefab; // Monster �������� �����ϱ� ���� ����
    void Start()
    {
        // 'Monster' �������� ������ ��ġ�� ������ ����
        Vector3 spawnPosition = new Vector3(0, 0, 0); // ���ϴ� ��ġ�� ����
        Quaternion spawnRotation = Quaternion.identity; // ���ϴ� �������� ����

        // 'Monster' �������� �ν��Ͻ�ȭ�Ͽ� 'monsterPrefab' ������ �Ҵ�
        GameObject monster = Instantiate(monsterPrefab, spawnPosition, spawnRotation);
    }


    

     public List<Round> rounds = new List<Round>
    {
        // 1����
        new Round
        {
            monsterPrefabs = new List<GameObject> { monsterPrefab }, // 'Monster' �������� ���� ����Ʈ�� �߰�
            numberOfMonsters = new List<int> { 5 }, // 1���忡 5������ 'Monster'
            timeBetweenSpawns = 3.0f // ���� ���� ����
        },
        // 2���� (����)
        new Round
        {
            monsterPrefabs = new List<GameObject> { monsterPrefab }, // 'Monster' �������� ���� ����Ʈ�� �߰�
            numberOfMonsters = new List<int> { 2 }, // 2���忡 2������ 'Monster'
            timeBetweenSpawns = 3.0f // ���� ���� ����
        },
    // ���� ���� ���� ���...
};


    private int currentRound = 0;
    private int monstersSpawned = 0;
    private float nextSpawnTime = 0.0f;

    private void Update()
    {
        // ���� ���尡 ��� �����Ǹ� ���� ����� ����
        if (currentRound < rounds.Count)
        {
            if (Time.time >= nextSpawnTime)
            {
                if (monstersSpawned < rounds[currentRound].monsterPrefabs.Count)
                {
                    GameObject monsterPrefab = rounds[currentRound].monsterPrefabs[monstersSpawned];
                    int numberOfMonsters = rounds[currentRound].numberOfMonsters[monstersSpawned];

                    for (int i = 0; i < numberOfMonsters; i++)
                    {
                        SpawnMonster(monsterPrefab);
                    }

                    monstersSpawned++;
                    nextSpawnTime = Time.time + rounds[currentRound].timeBetweenSpawns;
                }
                else
                {
                    // ��� ���Ͱ� �����Ǿ����� Ȯ��
                    GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
                    if (enemies.Length == 0)
                    {
                        // ���� ������ ���͸� ��� ������ ��� ���� ����� ����
                        currentRound++;
                        monstersSpawned = 0;
                    }
                }
            }
        }
    }

    private void SpawnMonster(GameObject monsterPrefab)
    {
        if (monsterPrefab != null)
        {
            // ���͸� ���� ��ġ�� ����
            GameObject monster = Instantiate(monsterPrefab, transform.position, Quaternion.identity);
        }
    }
}
