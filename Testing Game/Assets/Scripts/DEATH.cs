using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DEATH : MonoBehaviour
{
    public int deathCounter;
    public GlobalBool playerDiedDuringLevel;

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Respawn")
        {
            Die();
        }
    }

    void Die()
    {
        //deathCounter++;
        playerDiedDuringLevel.value = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
