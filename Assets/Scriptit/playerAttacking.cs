using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerAttacking : MonoBehaviour {

    //[Range(0,3)]
    public int playerHealth;
    public bool attackingOn,atkAllow=true;
    public GameObject attackSprt;
    public directionFacing DirectionFacing;
    public Collider2D attackCollider;

    public Image UIhealth;
    float hpMax = 1200;
    float healthCalculated;

	void Start ()
    {
        DirectionFacing = directionFacing.down;
        attackCollider = attackSprt.GetComponent<Collider2D>();
    }
	void Update ()
    {
        calcHealth();
        attackControls();
        spriteRot();
        spritePos();
	}
    public void calcHealth()
    {
        healthCalculated = playerHealth / hpMax;
        UIhealth.fillAmount = healthCalculated;
    }
    public void attackControls()
    {
        if (attackingOn == true)
        {
            if (Input.GetKeyDown(KeyCode.Q)&&atkAllow==true)
            {
                StartCoroutine(atkdelay());
            }
        }
    }
    public void spriteRot()
    {
        if(DirectionFacing == directionFacing.up) { attackSprt.transform.rotation = Quaternion.Euler(0,0,0); }
        if (DirectionFacing == directionFacing.down) { attackSprt.transform.rotation = Quaternion.Euler(0, 0, 180); }
        if (DirectionFacing == directionFacing.left) { attackSprt.transform.rotation = Quaternion.Euler(0, 0, 90); }
        if (DirectionFacing == directionFacing.right) { attackSprt.transform.rotation = Quaternion.Euler(0, 0, 270); }
    }
    public void spritePos()
    {
        if (DirectionFacing == directionFacing.up) { attackSprt.transform.localPosition = new Vector3(0,5,0); }
        if (DirectionFacing == directionFacing.down) { attackSprt.transform.localPosition = new Vector3(0, -5, 0); }
        if (DirectionFacing == directionFacing.left) { attackSprt.transform.localPosition = new Vector3(-5, 0, 0); }
        if (DirectionFacing == directionFacing.right) { attackSprt.transform.localPosition = new Vector3(5, 0, 0); }
    }
    IEnumerator atkdelay()
    {
        atkAllow = false;
        attackSprt.SetActive(true);
        yield return new WaitForSeconds(0.15f);
        attackSprt.SetActive(false);
        atkAllow = true;
    }
}
public enum directionFacing
{
left,right,up,down
}
