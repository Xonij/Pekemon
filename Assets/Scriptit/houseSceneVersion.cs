using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class houseSceneVersion : MonoBehaviour {

    public GameObject gm;
    public int houseNroIndex;
    public bool Inside = false;

	void Start ()
    {
	}
	void Update ()
    {
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            for(int i = 0; i < gm.GetComponent<gamemanagement>().enterableBuildings.Length; i++)
            {
                if(houseNroIndex == gm.GetComponent<gamemanagement>().enterableBuildings[i].sceneIndex)
                {

                    if (Inside == false)
                    {
                        SceneManager.LoadScene(i);
                    }
                    else if (Inside == true)
                    {
                        other.transform.position = gm.GetComponent<gamemanagement>().enterableBuildings[i].locationOnMap;
                    }

                }
            }
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
    }
}