using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class spawnManager : MonoBehaviour
{
  
    public GameObject[] candys;
    public GameObject[] spawnNoktaları;
    int rastgele = 2;

    public GameObject[] spawnlananCandy;
    int z = 0;
    public GameObject baslatCanvas;
    public TMPro.TMP_Text gerisayım;

    float time = 5;
    bool zamanBaslat;

   
    public void Start()
    {
        zamanBaslat = true;
        
        for (int i = 0; i < candys.Length; i++)
        {
            while (spawnNoktaları[rastgele] == null)
            {
                rastgele = Random.RandomRange(0, spawnNoktaları.Length);

            }

            spawnlananCandy[z] = Instantiate(candys[i], spawnNoktaları[rastgele].transform.position, Quaternion.identity);
            z++;
            spawnNoktaları[rastgele] = null;


            rastgele = Random.RandomRange(0, spawnNoktaları.Length);
            while (spawnNoktaları[rastgele] == null)
            {
                rastgele = Random.RandomRange(0, spawnNoktaları.Length);

            }

            spawnlananCandy[z] = Instantiate(candys[i], spawnNoktaları[rastgele].transform.position, Quaternion.identity);
            z++;
            spawnNoktaları[rastgele] = null;


        }
        StartCoroutine(spriteDisable());
    }


    public void Update()
    {
        if (zamanBaslat)
        {
            time -= Time.deltaTime;

            gerisayım.text = time.ToString("0");

        }
      
    }
    IEnumerator spriteDisable()
    {
        yield return new WaitForSeconds(5f);
        zamanBaslat = false;
        gerisayım.text = "";
        for (int i = 0; i < spawnlananCandy.Length; i++)
        {
            spawnlananCandy[i].GetComponent<SpriteRenderer>().enabled = false;
            spawnlananCandy[i].GetComponent<candy>().basladiMi = true;
        }
    }
  
}
