using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjeninKendisi : MonoBehaviour
{
   

    private void OnTriggerEnter(Collider other) // Unity 'de kurdu�umuz Bloklar�n alt�na bir obje ekledik ve tag�na Pasiflestir ismini verdik buraya topumuz temas etti�inde
                                                // PAsifle�cek ve d�ng� ba�a d�n�p toplar ayn� yerden c�k�cak ! ! !
    {
        if (other.gameObject.CompareTag("Pasiflestir"))
        {
            gameObject.SetActive(false);
        }
    }
}
