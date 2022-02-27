using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
    public GlobalBool PlayerDiedDuringLevel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Victory" && SceneManager.GetActiveScene().buildIndex < 7)
        {
            PlayerDiedDuringLevel.value = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else if (collision.gameObject.tag == "Victory")
        {
            PlayerDiedDuringLevel.value = false;
            SceneManager.LoadScene(0);
        }
    }

    
}
