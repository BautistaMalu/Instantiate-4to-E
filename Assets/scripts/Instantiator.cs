using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiator : MonoBehaviour
{
    public GameObject objectToClone;
    public Text txtUserCloneAmount;
      int cloneamount;

    public void MultiInstantiate()
    {
        cloneamount = int.Parse(txtUserCloneAmount.text);
        int counter = 0;
        while (counter < cloneamount)
        {
            Instantiate(objectToClone);
            counter++;
        }
    }
}
