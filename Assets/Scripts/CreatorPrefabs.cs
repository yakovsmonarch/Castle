using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatorPrefabs : MonoBehaviour
{
    public GameObject Prefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject gameObject = Instantiate(Prefab, transform.position, transform.rotation);
            gameObject.transform.position = new Vector3(transform.position.x + Random.Range(0.001f, 0.002f), transform.position.y, transform.position.z + Random.Range(0.001f, 0.002f));
        }
    }
}
