using UnityEngine;
using System.Collections.Generic;

public class PathManager : MonoBehaviour
{

    public List<List<Vector3>> paths = new List<List<Vector3>>();


    public List<Vector3> GetRandomPath()
    {
        if (paths.Count == 0)
        {
            Debug.LogWarning("No paths available.");
            return null;
        }

        int randomIndex = Random.Range(0, paths.Count);
        return paths[randomIndex];
    }



    public List<Vector3> path1; // ���� 1
    public List<Vector3> path2; // ���� 2
    public List<Vector3> path3; // ���� 3
    public List<Vector3> path4; // ���� 4
    public List<Vector3> path5; // ���� 5
    public List<Vector3> path6; // ���� 6
    public List<Vector3> path7; // ���� 7
    public List<Vector3> path8; // ���� 8
    public List<Vector3> path9; // ���� 9
    public List<Vector3> path10; // ���� 10
    public List<Vector3> path11; // ���� 11
    public List<Vector3> path12; // ���� 12
    public List<Vector3> path13; // ���� 13
    public List<Vector3> path14; // ���� 14


    

    public List<Vector3> GetPath(int pathNumber)
    {
        switch (pathNumber)
        {
            case 1:
                return path1;
            case 2:
                return path2;
            case 3:
                return path3;
            case 4:
                return path4;
            case 5:
                return path5;
            case 6:
                return path6;
            case 7:
                return path7;
            case 8:
                return path8;
            case 9:
                return path9;
            case 10:
                return path10;
            case 11:
                return path11;
            case 12:
                return path12;
            case 13:
                return path13;
            case 14:
                return path14;
            default:
                Debug.LogWarning("Invalid path number!");
                return null;
        }
    }







    void Awake()
    {
        // ���� �ʱ�ȭ
        path1 = new List<Vector3>
        {
            // Waypoint ������Ʈ�� ��ġ�� ����Ͽ� �ʱ�ȭ
        GameObject.Find("WayPoint1").transform.position,
        GameObject.Find("WayPoint4").transform.position,
        GameObject.Find("WayPoint16").transform.position,
       
        };

        path2 = new List<Vector3>
        {
            // Waypoint ������Ʈ�� ��ġ�� ����Ͽ� �ʱ�ȭ
        GameObject.Find("WayPoint1").transform.position,
        GameObject.Find("WayPoint3").transform.position,
        GameObject.Find("WayPoint7").transform.position,
         GameObject.Find("WayPoint8").transform.position,
         GameObject.Find("WayPoint16").transform.position,

        };

        path3 = new List<Vector3>
        {
            // Waypoint ������Ʈ�� ��ġ�� ����Ͽ� �ʱ�ȭ
        GameObject.Find("WayPoint1").transform.position,
        GameObject.Find("WayPoint3").transform.position,
        GameObject.Find("WayPoint11").transform.position,
        GameObject.Find("WayPoint12").transform.position,
        GameObject.Find("WayPoint16").transform.position,



        };
        path4 = new List<Vector3>
        {
            // Waypoint ������Ʈ�� ��ġ�� ����Ͽ� �ʱ�ȭ
        GameObject.Find("WayPoint1").transform.position,
        GameObject.Find("WayPoint3").transform.position,
        GameObject.Find("WayPoint15").transform.position,
        GameObject.Find("WayPoint16").transform.position,

        };
        path5 = new List<Vector3>
        {
            // Waypoint ������Ʈ�� ��ġ�� ����Ͽ� �ʱ�ȭ
        GameObject.Find("WayPoint1").transform.position,
        GameObject.Find("WayPoint2").transform.position,
        GameObject.Find("WayPoint6").transform.position,
        GameObject.Find("WayPoint8").transform.position,
        GameObject.Find("WayPoint16").transform.position,



        };
        path6 = new List<Vector3>
        {
            // Waypoint ������Ʈ�� ��ġ�� ����Ͽ� �ʱ�ȭ
        GameObject.Find("WayPoint1").transform.position,
        GameObject.Find("WayPoint2").transform.position,
        GameObject.Find("WayPoint10").transform.position,
        GameObject.Find("WayPoint12").transform.position,
        GameObject.Find("WayPoint16").transform.position,

        };
        path7 = new List<Vector3>
        {
            // Waypoint ������Ʈ�� ��ġ�� ����Ͽ� �ʱ�ȭ
       GameObject.Find("WayPoint1").transform.position,
        GameObject.Find("WayPoint2").transform.position,
        GameObject.Find("WayPoint14").transform.position,
        GameObject.Find("WayPoint16").transform.position,

        };
        path8 = new List<Vector3>
        {
            // Waypoint ������Ʈ�� ��ġ�� ����Ͽ� �ʱ�ȭ
        GameObject.Find("WayPoint1").transform.position,
        GameObject.Find("WayPoint5").transform.position,
        GameObject.Find("WayPoint8").transform.position,
        GameObject.Find("WayPoint16").transform.position,

        };
        path9 = new List<Vector3>
        {
            // Waypoint ������Ʈ�� ��ġ�� ����Ͽ� �ʱ�ȭ
        GameObject.Find("WayPoint1").transform.position,
        GameObject.Find("WayPoint5").transform.position,
        GameObject.Find("WayPoint7").transform.position,
        GameObject.Find("WayPoint11").transform.position,
        GameObject.Find("WayPoint12").transform.position,
        GameObject.Find("WayPoint16").transform.position,

        };
        path10 = new List<Vector3>
        {
            // Waypoint ������Ʈ�� ��ġ�� ����Ͽ� �ʱ�ȭ
        GameObject.Find("WayPoint1").transform.position,
        GameObject.Find("WayPoint5").transform.position,
         GameObject.Find("WayPoint7").transform.position,
        GameObject.Find("WayPoint15").transform.position,
        GameObject.Find("WayPoint16").transform.position,

        };
        path11 = new List<Vector3>
        {
            // Waypoint ������Ʈ�� ��ġ�� ����Ͽ� �ʱ�ȭ
        GameObject.Find("WayPoint1").transform.position,
        GameObject.Find("WayPoint5").transform.position,
        GameObject.Find("WayPoint6").transform.position,
        GameObject.Find("WayPoint14").transform.position,
        GameObject.Find("WayPoint16").transform.position,
        };


        path12 = new List<Vector3>
        {
            // Waypoint ������Ʈ�� ��ġ�� ����Ͽ� �ʱ�ȭ
            // Waypoint ������Ʈ�� ��ġ�� ����Ͽ� �ʱ�ȭ
        GameObject.Find("WayPoint1").transform.position,
        GameObject.Find("WayPoint9").transform.position,
        GameObject.Find("WayPoint10").transform.position,
        GameObject.Find("WayPoint14").transform.position,
        GameObject.Find("WayPoint16").transform.position,

        };
        path13 = new List<Vector3>
        {
            // Waypoint ������Ʈ�� ��ġ�� ����Ͽ� �ʱ�ȭ
            // Waypoint ������Ʈ�� ��ġ�� ����Ͽ� �ʱ�ȭ
        GameObject.Find("WayPoint1").transform.position,
        GameObject.Find("WayPoint9").transform.position,
        GameObject.Find("WayPoint12").transform.position,
        GameObject.Find("WayPoint16").transform.position,
       

        };
        path14 = new List<Vector3>
        {
            // Waypoint ������Ʈ�� ��ġ�� ����Ͽ� �ʱ�ȭ
            // Waypoint ������Ʈ�� ��ġ�� ����Ͽ� �ʱ�ȭ
        GameObject.Find("WayPoint1").transform.position,
        GameObject.Find("WayPoint13").transform.position,
        GameObject.Find("WayPoint16").transform.position,

        };
        // ��ε��� paths ����Ʈ�� �߰�
        paths.Add(path1);
        paths.Add(path2);
        paths.Add(path3);
        paths.Add(path4);
        paths.Add(path5);
        paths.Add(path6);
        paths.Add(path7);
        paths.Add(path8);
        paths.Add(path9);
        paths.Add(path10);
        paths.Add(path11);
        paths.Add(path12);
        paths.Add(path13);
        paths.Add(path14);

    }




        // �ٸ� �ʱ�ȭ �ڵ� �߰�


    }





