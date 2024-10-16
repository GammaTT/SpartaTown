using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorCircle : MonoBehaviour
{
    [SerializeField] private Transform tutorText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            tutorText.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            tutorText.gameObject.SetActive(false);
        }
    }
}
