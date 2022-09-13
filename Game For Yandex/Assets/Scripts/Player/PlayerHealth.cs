using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [Header("GameObj Links")]
    public CharacterController controller;

    [Header("UI Links")]
    public Text healthText;

    private CharacterStats character;

    private void Start()
    {
        character = GetComponent<CharacterStats>();
        AddHealthText();
    }

    public void AddHealthText()
    {
        healthText.text = System.Convert.ToString(character.currentHealth) + " | " + System.Convert.ToString(character.maxHealth);
    }
}
