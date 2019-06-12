using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class setupplayer : NetworkBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (isLocalPlayer)
        {
            GetComponent<Player0>().enabled = true;
        }
    }

}
