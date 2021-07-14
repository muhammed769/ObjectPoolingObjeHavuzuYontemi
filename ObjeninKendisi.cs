using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjeninKendisi : MonoBehaviour
{
   

    private void OnTriggerEnter(Collider other) // Unity 'de kurduðumuz Bloklarýn altýna bir obje ekledik ve tagýna Pasiflestir ismini verdik buraya topumuz temas ettiðinde
                                                // PAsifleþcek ve döngü baþa dönüp toplar ayný yerden cýkýcak ! ! !
    {
        if (other.gameObject.CompareTag("Pasiflestir"))
        {
            gameObject.SetActive(false);
        }
    }
}
