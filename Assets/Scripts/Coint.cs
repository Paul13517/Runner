using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coint : MonoBehaviour
{
    float turnSpeed = 90f;
    // Start is called before the first frame update
    private void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.GetComponent<Obstacle>() != null) {
            Destroy(gameObject);
            return;
        }
        if (other.gameObject.name != "Player") {
            return;
        }
        GameManager.inst.IncrementScore();
        Destroy(gameObject);
    }

    // Update is called once per frame
    private void Update () {
        transform.Rotate(0, 0, turnSpeed * Time.deltaTime);
	}
}
