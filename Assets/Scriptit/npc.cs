using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class npc : MonoBehaviour {

    public bool useAltTextBox;
    [TextArea(1, 15)]
    public string shortDialog;
    public GameObject player;
    public float distToPlayer;
    public GameObject npcTextBox,screenCanvas;
    public bool seenThisNpc=false;

    void Start ()
    {	
	}
	void Update ()
    {
        distToPlayer = Vector3.Distance(this.transform.position, player.transform.position);

        if (useAltTextBox == false)
        {
            if (distToPlayer < 3)
            {
                npcTextBox.SetActive(true);
                npcTextBox.GetComponentInChildren<Text>().text = shortDialog;
                seenThisNpc = true;
            }
            else if (seenThisNpc == true && distToPlayer > 3)
            {
                npcTextBox.SetActive(false);
                npcTextBox.GetComponentInChildren<Text>().text = "";
            }
        }
        else if(useAltTextBox == true)
        {
            if (distToPlayer < 3 && Input.GetKeyDown(KeyCode.Space))
            {
                screenCanvas.SetActive(true);
                screenCanvas.GetComponentInChildren<Text>().text = "Tässä on dialogi.";
                seenThisNpc = true;
            }
            else if (seenThisNpc == true && distToPlayer > 3)
            {
                screenCanvas.SetActive(false);
                screenCanvas.GetComponentInChildren<Text>().text = "";
            }
        }
    }
}