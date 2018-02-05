using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour {

    public GameObject player;
    public float distToPlayer;
    public state EnemyState=state.idle;
    [Range(0,1)]
    public int health;

    void Start ()
    {		
	}
	void Update ()
    {
        if(EnemyState != state.dead && health>0)
        {
            distToPlayer = Vector3.Distance(this.transform.position, player.transform.position);
            if (distToPlayer < 8 && distToPlayer > 2.5f) { EnemyState = state.following; }
            else if (distToPlayer <= 2.5f) { EnemyState = state.idle; }

            if (EnemyState == state.following && player.GetComponent<playerAttacking>().playerHealth > 0)
            {
                this.gameObject.transform.position = Vector2.MoveTowards(gameObject.transform.position, player.transform.position, Time.deltaTime * 2.5f);
                StartCoroutine(randDelay());
            }
            if (health <= 0) { EnemyState = state.dead; }
        }
        else { deadStateOperation(); }
    }
    public void deadStateOperation()
    {
        Destroy(gameObject);
    }
    IEnumerator randDelay()
    {
        if (health < 0)
        { EnemyState = state.following; }
        yield return new WaitForSeconds(Random.Range(1,4));
        if (health < 0)
        { EnemyState = state.idle; }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" )
        {
           health =-1;
        }
    }
}
public enum state
{
idle,following,dead
}
