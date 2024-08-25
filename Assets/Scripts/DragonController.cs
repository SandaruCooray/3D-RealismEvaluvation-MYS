using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragonController : MonoBehaviour
{


    private int HP = 100;
    public Animator animator;

    public GameObject fireball;
    public Transform fireballPoint;


    public Slider healthBar;


    public void Update()
    {
        healthBar.value = HP;
    }

    public void Scream()
    {

        FindObjectOfType<AudioManager>().Play("DragonScream");
    }

    public void Attack()
    {

        FindObjectOfType<AudioManager>().Play("DragonAttack");
    }

    public void TakeDamage(int damageAmount)
    {

        HP -= damageAmount;

        if(HP <= 0)
        {
            //play death animation
            FindObjectOfType<AudioManager>().Play("DragonDeath");
            animator.SetTrigger("die");
            GetComponent<Collider>().enabled = false;

        }
        else
        {
            // Pla getr hit animation
            animator.SetTrigger("damage");
        }
    }

}
