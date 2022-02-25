using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DEATH : MonoBehaviour
{
    public int deathCounter;
    public GameObject baddie;

    // Update is called once per frame
    void Update()
    {
        baddie = GameObject.Find("Baddie");
        Debug.Log(SceneManager.GetActiveScene().buildIndex);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Respawn")
        {
            gameObject.SetActive(false);
            Die();
        }
    }

    void Die()
    {
        deathCounter++;
        baddie.GetComponent<BaddieStateManager>().playerDied = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
