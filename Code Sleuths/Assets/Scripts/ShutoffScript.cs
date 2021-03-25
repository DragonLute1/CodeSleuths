using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShutoffScript : MonoBehaviour
{
    public void Shutoff()
    {
        this.gameObject.SetActive(false);
    }
}
