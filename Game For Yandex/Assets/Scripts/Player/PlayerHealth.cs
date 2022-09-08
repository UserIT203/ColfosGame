using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [Header("Main Characteristic")]
    public float maxHP;
    public float currentHP;

    [Header("UI Links")]
    public Text healthText;

    private void Awake()
    {
        currentHP = maxHP;
        healthText.text = System.Convert.ToString(currentHP) + " | " + System.Convert.ToString(maxHP);
    }

    public void TakeDamage(float damage)
    {
        currentHP -= damage;

        healthText.text = System.Convert.ToString(currentHP) + " | " + System.Convert.ToString(maxHP);
    }
}
