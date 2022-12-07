using UnityEngine;

public class OpenGateOnClickScript : MonoBehaviour
{

    public GameObject gate1;
    public GameObject gate2;
    public GameObject player;
    public bool gateClosed1 = true;
    public bool gateClosed2 = true;

  
    public void Gate1Behavior()
    {
        if (gateClosed1)
        {
            OpenGate1();
        }
        else if (!gateClosed1)
        {
            CloseGate1();
        }

        void OpenGate1()
        {
            gate1.transform.position = new Vector3(-2, 4, 0);
            gateClosed1 = false;
        }

        void CloseGate1()
        {
            gate1.transform.position = new Vector3(-2, 0, 0);
            gateClosed1 = true;
        }
    }


    public void Gate2Behavior()
    {
        if (gateClosed2)
        {
            OpenGate2();
        }
        else if (!gateClosed2)
        {
            CloseGate2();
        }

       void OpenGate2()
       {
            gate2.transform.position = new Vector3(3, 4, 0);
            gateClosed2 = false;
       }

       void CloseGate2()
       {
            gate2.transform.position = new Vector3(3, 0, 0);
            gateClosed2 = true;
       }
    }

    private void Update()
    {
        PlayerBehaviour();
    }

    public void PlayerBehaviour()
    {
        if(gateClosed1 == false && gateClosed2 == false)
        {
            player.GetComponent<Animator>().enabled = true;
        }
        else
        {
            player.GetComponent<Animator>().enabled = false;
        }
 
    }
}
