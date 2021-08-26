using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;


public class Player : MonoBehaviour
{
    public float count;
    public float Maxhealth = 100f;
    public float health = 100f;
    public Text healthtxt;
  
    void Update()
    {
        if (health > 0)
        {
            count += Time.deltaTime;
            while (count > 5)
            {
                health = health - 1;
                healthtxt.text = health.ToString();
                count = 0;
            }
            if (health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
   public void Heal(int amount)
   {
        health += amount;
        if(health>Maxhealth)
        {
            health = Maxhealth;
        }
        Update();
    }
}
