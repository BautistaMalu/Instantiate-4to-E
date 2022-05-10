using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiator : MonoBehaviour
{
    public GameObject objectToClone;
    public Text txtUserCloneAmount;
    int cloneamount;
    GameObject clon;

    public void MultiInstantiate()
    {
        cloneamount = int.Parse(txtUserCloneAmount.text);

  

        for (int i=0; i<cloneamount; i++)
        {
            clon = Instantiate(objectToClone);
            Destroy(clon, 2);

        }

    }
}
