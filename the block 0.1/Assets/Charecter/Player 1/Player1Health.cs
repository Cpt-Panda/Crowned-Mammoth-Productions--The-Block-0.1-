using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class Player1Health : MonoBehaviour {
    public float CurrentHealth { get; set; }
    public float MaxHealth { get; set; }

    public Slider healthbar;

	void Start ()
    {
        MaxHealth = 20f;
        // Resets health to full on game load
        CurrentHealth = MaxHealth;

        healthbar.value = CalculateHealth();
	}
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.X))
            DealDamage(6);
	}

    void DealDamage(float damageValue)
    {
        // Deduct the damage dealt from the characters health
        CurrentHealth = damageValue;
        healthbar.value = CalculateHealth();    
        // If the character is out of health, die!
        if (CurrentHealth <= 0)
            Die();
    }

    float CalculateHealth()
    {
        return CurrentHealth / MaxHealth;
    }

    void Die()
    {
        CurrentHealth = 0;
        Debug.Log("Your Brown bread mate!");
    }
}
