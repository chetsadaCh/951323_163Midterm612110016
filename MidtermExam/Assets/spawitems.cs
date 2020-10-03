using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawitems : MonoBehaviour
{
    public GameObject greenobtacle;
    public GameObject redobtacle;
    public GameObject blueobtacle;
    public GameObject grayobtacle;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawnball", 5f,5f);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Spawnball()
    {
        var position = new Vector3(Random.Range(-10, -15), 10, Random.Range(10, -38));
        var position2 = new Vector3(Random.Range(-10, -15), 10, Random.Range(10, -38));
        var position3 = new Vector3(Random.Range(-10, -15), 10, Random.Range(10, -38));
        var position4 = new Vector3(Random.Range(-10, -15), 10, Random.Range(10, -38));

        var greenb = GameObject.Instantiate(greenobtacle, position,Quaternion.identity);
        var redb = GameObject.Instantiate(redobtacle, position2, Quaternion.identity);
        var blueb = GameObject.Instantiate(blueobtacle, position3, Quaternion.identity);
        var grayb = GameObject.Instantiate(grayobtacle, position4, Quaternion.identity);
    }
}
