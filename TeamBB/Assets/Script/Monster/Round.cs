using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Round
{
    public List<GameObject> monsterPrefabs; // ���� �������� ����Ʈ
    public List<int> numberOfMonsters;     // ���� ������ ����Ʈ
    public float timeBetweenSpawns;
}

