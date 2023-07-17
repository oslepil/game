using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    int Count1 = 500;
    int Count2 = 500;
    public Button btnD;
    public Button btnH;
    GameObject WallsObject;
    Walls WallsComponent;
    public GameObject BulletD;
    Bullet BulletComp;
    private GameObject Score;
    private ScoreCounter sc;

    void Start()
    {
        Score = GameObject.FindGameObjectWithTag("Canvas");
        sc = Score.GetComponent<ScoreCounter>();

        WallsObject = GameObject.FindGameObjectWithTag("Wall");
        WallsComponent = WallsObject.GetComponent<Walls>();
        BulletComp = BulletD.GetComponent<Bullet>();
        btnD.GetComponentInChildren<Text>().text = "+Damage \nPrice:" + Count1.ToString();
        btnH.GetComponentInChildren<Text>().text = "+Hp \nPrice:" + Count2.ToString();
        btnD.onClick.AddListener(DamageUp);
        btnH.onClick.AddListener(HpUp);        
        BulletComp.damage = 1;
        WallsComponent.hp = 10;
    }

    void DamageUp()
    {
        if (sc.score >= Count1)
        {
            sc.score -= Count1;
            BulletComp.damage++;
            Count1 += 100 * BulletComp.damage;
            btnD.GetComponentInChildren<Text>().text = "Price:" + Count1.ToString();
        }
    }

    void HpUp()
    {
        if (sc.score >= Count2)
        {
            sc.score -= Count2;
            WallsComponent.hp++;
            Count2 += 1000;
            btnH.GetComponentInChildren<Text>().text = "Price:" + Count2.ToString();
        }
    }
}
