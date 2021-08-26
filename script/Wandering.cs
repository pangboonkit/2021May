using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wandering : MonoBehaviour
{
    public float speed = 3.0f;
    public float obstacleRange = 5.0f;
    private bool Isalive;

    [SerializeField] private GameObject fireballPrefab;
    private GameObject Isfireball;

    void Start()
    {
        Isalive = true;
    }

    void Update()
    {
        if (Isalive = true)
        {
            transform.Translate(0, 0, speed * Time.deltaTime);

            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;
            if (Physics.SphereCast(ray, 0.75f, out hit))
            {
                GameObject hitObject = hit.transform.gameObject;
                if(hitObject.GetComponent<Player>())
                {
                    if (Isfireball == null)
                    {
                        Isfireball=Instantiate(fireballPrefab)as GameObject;
                        Isfireball.transform.position=transform.TransformPoint(Vector3.forward*1.5f);
                        Isfireball.transform.rotation=transform.rotation;
                    }
                }
                else

                if (hit.distance < obstacleRange)
                {
                    float angle = Random.Range(-110, 110);
                    transform.Rotate(0, angle, 0);
                }
            }
        }
    }
    public void SetAlive(bool alive)
    {
        Isalive = alive;
    }
}
