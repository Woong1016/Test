using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float maxHealth = 50f; // ���� �ִ� ü��
    private float currentHealth;   // ���� ü��

    public int moneyValue = 10;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        GameManager.instance.MoneyIncrease(moneyValue);

        Destroy(gameObject);
    }
}
