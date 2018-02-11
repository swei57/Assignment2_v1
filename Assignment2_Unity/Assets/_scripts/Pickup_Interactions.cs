using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Pickup_Interactions : MonoBehaviour {
    public Text score;
    public float count;
    public Transform yellowPreFab;
    public Transform redPreFab;
    public Transform greenPreFab;

    void Start()
    {
        for (int i = 0; i < Random.Range(3f, 10f); i++) //loops 3 to 10 times to generate random pick ups in the box.
        {
            Instantiate(yellowPreFab, new Vector3(Random.Range(-5f, 5f), Random.Range(1.3f, 1.6f), Random.Range(-5f, 5f)), Quaternion.identity);
            Instantiate(redPreFab, new Vector3(Random.Range(-5f, 5f), Random.Range(1.3f, 1.6f), Random.Range(-5f, 5f)), Quaternion.identity);
            Instantiate(greenPreFab, new Vector3(Random.Range(-5f, 5f), Random.Range(1.3f, 1.6f), Random.Range(-5f, 5f)), Quaternion.identity); //make 2x the green cubes than the other colours
            Instantiate(greenPreFab, new Vector3(Random.Range(-5f, 5f), Random.Range(1.3f, 1.6f), Random.Range(-5f, 5f)), Quaternion.identity);
        }
    }
    void Update()
    {
        score.text = count.ToString();
    }
    void OnTriggerEnter(Collider collisionInf)
    {

        if (collisionInf.gameObject.tag == "Red_Item")
        {
            Destroy(collisionInf.gameObject);
            count += 2; //get 2 points for hitting red item
        }
        if (collisionInf.gameObject.tag == "Green_Item")
        {
            Destroy(collisionInf.gameObject);
            count += 1; //get 1 points for hitting green item
        }
        if (collisionInf.gameObject.tag == "Yellow_Item")
        {
            Destroy(collisionInf.gameObject);
            count += 4; //get 4 points for hitting yellow item
        }
    }
}