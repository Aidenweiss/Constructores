using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Constructor : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        string[] names = new string[]
        {
            "stubbs",
            "rob",
            "white"
        };
        for (int i= 0; i < names.Length; i++)
        {
            Zombie z = new Zombie(names[i], Random.Range(10, 15));
            Debug.Log(z.name);
        }

        Zombie rob = new Zombie("Rob",10);
    }

    // Update is called once per frame
    void Update()
    {

    }

    class Zombie
    {
        public string name;
        public int brainsEaten;
        public int hitPoints;
        GameObject zombieMesh;

        public Zombie(string n, int hp)
        {
            name = n;
            hitPoints = 10;
            brainsEaten = hp;
            zombieMesh = GameObject.CreatePrimitive(PrimitiveType.Capsule);
            Vector3 pos = new Vector3();
            pos.x = Random.Range(-10, 10);
            pos.y = 0f;
            pos.z = Random.Range(-10, 10);
            zombieMesh.transform.position = pos;
        }
    }
}
