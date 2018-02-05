using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class npcColliderVersion : MonoBehaviour {

    public GameObject screenCanvas;
    public bool seenThisNpc = false;

    void Start ()
    {
		
	}
	void Update ()
    {
        thisthing();
	}
    public void thisthing()
    {
        if (seenThisNpc == true && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("next text slide");
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        seenThisNpc = true;

        screenCanvas.SetActive(true);
        screenCanvas.GetComponentInChildren<Text>().text = "Sanon jotain, kun tulet lähelleni.";
    }
    void OnTriggerExit2D(Collider2D other)
    {
        seenThisNpc = false;
        screenCanvas.SetActive(false);
        screenCanvas.GetComponentInChildren<Text>().text = "";
    }
}
