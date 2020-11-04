using UnityEngine;
using System.Collections;

public class CubeDestroyer : MonoBehaviour {

    public GameObject Cube;
    public GameObject[] Enemies;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider player)
    {
        if (player.tag == "Player")
        {
            Enemies = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject Enemy in Enemies)
            {
                DestroyObject(Enemy);
            }
            DestroyObject (gameObject);
        }
    }
}
