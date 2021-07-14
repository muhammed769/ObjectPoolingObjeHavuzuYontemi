using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyunKontrol : MonoBehaviour
{
    //    public GameObject OlusacakObje;
    //    public GameObject OlusacakObjeninKonumu;



    public GameObject[] OlusacakOBje;
    public GameObject OlusacakObjeninKonumu;
    int siraNumarasi = 0;


    private void Start()
    {
        //  OlusacakOBje[5].SetActive(true);
        // OlusacakOBje[5].transform.position = OlusacakObjeninKonumu.transform.position; // Ýlk baþta Unity 'de 8 tane oluþascak objeyi PASÝFLEÞTÝR.
        //  StartCoroutine("ObjeOlustur");


        StartCoroutine(Objeolustur());
       
    }


    #region Ýkinci Yöntem

    IEnumerator Objeolustur()
    {
        while (true)
        {
            if (siraNumarasi <= 8)
            {
                OlusacakOBje[siraNumarasi].SetActive(true);
                OlusacakOBje[siraNumarasi].transform.position = OlusacakObjeninKonumu.transform.position;

                siraNumarasi++;
                yield return new WaitForSeconds(.4f);

            }
            else
            {
                siraNumarasi = 0;
                OlusacakOBje[siraNumarasi].SetActive(true);
                OlusacakOBje[siraNumarasi].transform.position = OlusacakObjeninKonumu.transform.position;
            }


            /* foreach (GameObject Objem in OlusacakOBje) // Gameobject türünde bir objem var bu olusacakObje koleksiyonu(dizisi) içerisinde demiþ olduk ! ! !
             {
                 Objem.transform.position = OlusacakObjeninKonumu.transform.position;
                 Objem.SetActive(true);

             }
            */


        }
    }

    #endregion


    #region Birinci Yontem ( eski yöntem )
    //IEnumerator ObjeOlustur()
    //{
    //    while (true)
    //    {
    //        //Instantiate(OlusacakObje, OlusacakObjeninKonumu.transform.position, OlusacakObjeninKonumu.transform.rotation);
    //        //// yield return null;
    //        //yield return new WaitForSeconds(4f);



    //    }
    //}

    #endregion




}
