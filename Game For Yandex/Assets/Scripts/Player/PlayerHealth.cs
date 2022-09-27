using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : CharacterStats
{
    [Header("GameObj Links")]
    public CharacterController controller;
    public GameObject prefabBloody;

    [Header("UI Links")]
    public Text healthText;
    public GameObject diePanel;
    public GameObject canvas;

    private CharacterStats character;

    private void Start()
    {
        diePanel.SetActive(false);

        character = GetComponent<CharacterStats>();
        AddHealthText();
    }

    public void CreateBloody()
    {
        float positionX = Random.Range(-800, 800);
        float positionY = Random.Range(-400, 400);

        GameObject bloody = Instantiate(prefabBloody, 
            prefabBloody.transform.position = new Vector3(positionX, positionY, 0), 
            Quaternion.identity) as GameObject;
        float scaleValue = Random.Range(1, 4);
        bloody.transform.localScale =  new Vector3(scaleValue, scaleValue, scaleValue);

        bloody.transform.SetParent(canvas.transform, false);
        bloody.transform.SetSiblingIndex(0);
    }

    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);

        CreateBloody();
        AddHealthText();
    }

    public void AddHealthText()
    {
        healthText.text = System.Convert.ToString(character.currentHealth);
    }

    public override void Die()
    {
        base.Die();

        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        diePanel.SetActive(true);
    }
}
