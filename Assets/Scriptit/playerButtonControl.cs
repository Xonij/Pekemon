using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerButtonControl : MonoBehaviour {

    public gamemanagement gm;
    public GameObject evolves,reppu;
    public openCanvas openWindow;


	void Start ()
    {
		
	}
	void Update ()
    {
        playerOtherButtons();
    }
    public void playerOtherButtons()
    {
        if(Input.GetButtonDown("evolutions"))
        {
            if (openWindow==openCanvas.evolutions)//is activated
            {
                evolves.SetActive(false);
                Time.timeScale = 1;
                Cursor.visible = false;
                openWindow = openCanvas.NONE;
            }
            else if(openWindow == openCanvas.NONE)
            {
                evolves.SetActive(true);
                Time.timeScale = 0;
                Cursor.visible = true;
                openWindow = openCanvas.evolutions;
            }
        }
        if (Input.GetButtonDown("reppu"))
        {
            if (openWindow == openCanvas.reppu)//is activated
            {
                reppu.SetActive(false);
                Time.timeScale = 1;
                Cursor.visible = false;
                openWindow = openCanvas.NONE;
            }
            else if (openWindow == openCanvas.NONE)
            {
                reppu.SetActive(true);
                Time.timeScale = 0;
                Cursor.visible = true;
                openWindow = openCanvas.reppu;
            }
        }
    }
#region selectPetButtons
    public void m1() { gm.GetComponent<gamemanagement>().CurrentPetInt = 1; }
    public void m2() { gm.GetComponent<gamemanagement>().CurrentPetInt = 2; }
    public void m3() { gm.GetComponent<gamemanagement>().CurrentPetInt = 3; }
    public void m4() { gm.GetComponent<gamemanagement>().CurrentPetInt = 4; }
    public void m5() { gm.GetComponent<gamemanagement>().CurrentPetInt = 5; }

    public void m6() { gm.GetComponent<gamemanagement>().CurrentPetInt = 6; }
    public void m7() { gm.GetComponent<gamemanagement>().CurrentPetInt = 7; }
    public void m8() { gm.GetComponent<gamemanagement>().CurrentPetInt = 8; }
    public void m9() { gm.GetComponent<gamemanagement>().CurrentPetInt = 9; }
    public void m10() { gm.GetComponent<gamemanagement>().CurrentPetInt = 10; }

    public void m11() { gm.GetComponent<gamemanagement>().CurrentPetInt = 11; }
    public void m12() { gm.GetComponent<gamemanagement>().CurrentPetInt = 12; }
    public void m13() { gm.GetComponent<gamemanagement>().CurrentPetInt = 13; }
    public void m14() { gm.GetComponent<gamemanagement>().CurrentPetInt = 14; }
    public void m15() { gm.GetComponent<gamemanagement>().CurrentPetInt = 15; }

    public void m16() { gm.GetComponent<gamemanagement>().CurrentPetInt = 16; }
    public void m17() { gm.GetComponent<gamemanagement>().CurrentPetInt = 17; }
    public void m18() { gm.GetComponent<gamemanagement>().CurrentPetInt = 18; }
    public void m19() { gm.GetComponent<gamemanagement>().CurrentPetInt = 19; }
    public void m20() { gm.GetComponent<gamemanagement>().CurrentPetInt = 20; }
    #endregion
}
public enum openCanvas
{
NONE,evolutions,reppu
}