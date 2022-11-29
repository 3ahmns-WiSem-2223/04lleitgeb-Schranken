
using UnityEngine;

public class OpenGateOnClickScript : MonoBehaviour
{

    public GameObject gate1;
    public GameObject gate2;
    public GameObject player;
    bool gateClosed = true;

  
    public void Gate1Behavior()
    {
        if (gateClosed)
        {
            OpenGate1();
        }
        else if (!gateClosed)
        {
            CloseGate1();
        }

        void OpenGate1()
        {
            gate1.transform.position = new Vector3(-2, 4, 0);
            gateClosed = false;
        }

        void CloseGate1()
        {
            gate1.transform.position = new Vector3(-2, 0, 0);
            gateClosed = true;
        }
    }


    public void Gate2Behavior()
    {
        if (gateClosed)
        {
            OpenGate2();
        }
        else if (!gateClosed)
        {
            CloseGate2();
        }

       void OpenGate2()
       {
            gate2.transform.position = new Vector3(3, 4, 0);
            gateClosed = false;
       }

       void CloseGate2()
       {
            gate2.transform.position = new Vector3(3, 0, 0);
            gateClosed = true;
       }
    }








    public void PlayerBehaviour()
    {
        {
           player.transform.position = new Vector3(3.5f, -1, 0);
        }
    }


}
