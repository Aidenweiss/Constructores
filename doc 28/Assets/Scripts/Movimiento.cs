using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour {
    bool mForward;
    bool mBackward;
    bool mLeft;
    bool mRight;

    public Vector3 pos = Vector3.zero;
    public float speed;
    float f = 0;
    // Use this for initialization
    void Start()
    {
        pos = transform.position;
        

        Members m = new Members();
        m.FirstFunction();

        print(ImANumber());
        print(INeedANumber(1));

        int val = INeedANumber(3) + INeedANumber(7);
        print(val);

        int vali = INeedTwoNumbers(3, 7);
        print(vali);

        f += 0.25f;
        print(f);
       
    }

    // Update is called once per frame
    void Update()
    {

        transform.position += Movement(speed);
    }

   public class Members
    {
        public void FirstFunction()
        {
            print("First function");
        }
    }

    int ImANumber()
    {
        return 3;
    }

    int INeedANumber(int number)
    {
        return number +1;
    }

    int INeedTwoNumbers(int a, float b)
    {
        return a * (int) b;
    }

    bool NumbersAreTheSame(int a, int b)
    {
        if (a == b)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    Vector3 Movement(float dist)
    {
        Vector3 vec = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            vec.z += dist;
        }
        if (Input.GetKey(KeyCode.S))
        {
            vec.z -= dist;
        }
        if (Input.GetKey(KeyCode.D))
        {
            vec.x += dist;
        }
        if (Input.GetKey(KeyCode.A))
        {
            vec.x -= dist;
        }
        return vec;
    }
}
