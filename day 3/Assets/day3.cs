using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class day3 : MonoBehaviour
{
    //hero info
    string heroname = "koko";
    int heropower = 182;
    //villain info
    string villainname = "jojo";
    int villainpower = 155;
    // Start is called before the first frame update
    float playerspeed = 2.5f;
    
    void sitspeed(float newspeed)
    {
        print(playerspeed);
        playerspeed = newspeed;
        print(playerspeed);
    }
    void Start()
    {
        if (heropower > villainpower)
        {
            print("the hero stronger");

        }
        else if (heropower == villainpower)
        {
            print("no one will win");

        }
        else
        {

            print("heropower");

        }


        // Update is called once per frame
        void Update()
        {

        }
    }
}

