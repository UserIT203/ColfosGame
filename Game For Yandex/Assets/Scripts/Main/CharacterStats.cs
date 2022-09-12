using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth { get; private set; }

    public Stat damage;

    private void Awake()
    {
        currentHealth = maxHealth;
    }

    public virtual void Die()
    {
        //Die gameobject 
        Debug.Log(transform.name + " Die");
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log(transform.name + " takes " + damage);

        if (currentHealth <= 0)
        {
            Die();
        }
    }
}
