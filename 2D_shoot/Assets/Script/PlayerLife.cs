using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour
{
    private int playerLifeNum = 100;
    [SerializeField] PlayerScript playerscript;
    [SerializeField] GameObject FillArea;
    [SerializeField] Slider playerLife;
    [SerializeField] GameObject Explosion;
    private bool deathflag = false;

  
    // Update is called once per frame
    void Update()
    {
        CheckLifeBar();
        if(deathflag)
        {
            Death();
        }
    }

    public void GetHit()
    {
        playerLifeNum -= 10;
    }

    public void GetHeal()
    {
        playerLifeNum += 10;
    }

    private void CheckLifeBar()
    {
        playerLife.value = playerLifeNum;
        if(playerLifeNum <= 0)
        {
            deathflag = true;
        }
    }

    private void Death()
    {
        FillArea.SetActive(false);
        Instantiate(Explosion, transform.position, transform.rotation);
        Destroy(playerscript.gameObject);
        GameObject.Find("BG").GetComponent<Timer>().GameEnd();
    }
}
