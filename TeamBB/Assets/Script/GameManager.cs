using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; // ���� �Ŵ��� �ν��Ͻ�

    public TMP_Text moneyText;
    private int money = 0;

    private void Awake()
    {
        // ���� �Ŵ��� �ν��Ͻ��� ����
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject); // �ٸ� �ν��Ͻ��� �ı�
        }
    }

    public void MoneyIncrease(int amount)
    {
        money += amount;
        ShowInfo();
    }

    private void ShowInfo()
    {
        moneyText.text = " " + money;
    }
}