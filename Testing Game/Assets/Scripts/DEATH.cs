using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DEATH : MonoBehaviour
{
    public int deathCounter;
    public GameObject baddie;
    public GlobalBool playerDiedDuringLevel;

    // Update is called once per frame
    void Update()
    {
        baddie = GameObject.Find("Baddie");
        //Debug.Log(SceneManager.GetActiveScene().buildIndex);

        //Debug.Log(playerDiedDuringLevel.value);
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
