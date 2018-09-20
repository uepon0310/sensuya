﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


static class GlobalVariables
{
    static public int StageNumber;
    static public bool StageWriteFlag;
}

public class MakeStage : MonoBehaviour
{

    public GameObject GameScreen1;
    public GameObject GameScreen2;
    public GameObject GameScreen3;
    public GameObject GameScreen4;
    public GameObject GameScreen5;
    public GameObject GameScreen6;
    public GameObject GameScreen7;
    public GameObject GameScreen8;
    public GameObject GameScreen9;
    public GameObject GameScreen10;

    
    public float GameObjectHight;
    public float GameObjectWight;

    public GameObject target1;
//    public bool StageWriteFlag;

    public int StageDataX, StageDataY;

//    public int StageNumber;
//    public int Stage;

    enum StageNumbering
    {
        Stage_1 = 1,
        Stage_2,
        Stage_3,
        Stage_4,
        Stage_5,
        Stage_6,
        Stage_7,
        Stage_8

    }
    public int[,] StageData1 = new int[,]{
            { 1,1,1,1,1,1,1,1,1,1 },//0
            { 1,0,0,0,0,0,0,0,0,1 },//1
            { 1,0,0,0,0,0,0,0,0,1 },//2
            { 1,0,0,0,0,0,0,0,0,1 },//3
            { 1,0,0,0,0,0,0,0,0,1 },//4
            { 1,1,1,1,1,0,0,0,0,1 },//5
            { 1,0,0,0,0,0,0,0,0,1 },//6
            { 1,0,0,0,0,0,0,0,0,1 },//7
            { 1,0,0,0,0,0,0,0,0,1 },//8
            { 1,0,0,0,0,0,0,0,0,1 },//9
            { 1,0,0,0,0,0,1,0,0,1 },//10
            { 1,0,0,0,0,0,1,0,0,1 },//11
            { 1,0,0,0,0,0,1,0,0,1 },//12
            { 1,0,0,1,1,1,1,1,1,1 },//13
            { 1,0,0,0,0,0,0,0,0,1 },//14
            { 1,0,0,0,0,0,0,0,0,1 },//15
            { 1,0,0,1,1,1,1,0,0,1 },//16
            { 1,0,0,0,0,0,0,0,0,1 },//17
            { 1,0,0,0,0,0,0,0,0,1 },//18
            { 1,0,0,0,0,0,0,0,0,1 },//19
            { 1,0,0,0,0,0,0,0,0,1 },//20
            { 1,1,1,0,0,0,1,1,1,1 },//21
            { 9,9,9,9,9,9,9,9,9,9 },//22
        };

    public int[,] StageData2 = new int[,]{

//0 1 2 3 4 5 6 7 8 9101112131415161718192021 
{ 1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 },//0
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//1
{ 1,0,0,0,0,0,0,0,0,0,5,0,0,0,0,0,0,0,0,0,0,1 },//2
{ 1,0,4,0,0,0,0,0,0,0,10,0,0,0,0,0,0,0,0,4,0,1 },//3
{ 1,0,0,0,0,5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//4
{ 1,0,4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,0,1 },//5
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//6
{ 1,0,4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,0,1 },//7
{ 1,0,0,0,0,0,0,0,0,0,5,0,0,0,0,0,0,0,5,0,0,1 },//8
{ 1,0,4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,0,1 },//9
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//10
{ 1,0,4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,0,1 },//11
{ 1,0,0,0,0,6,0,0,0,0,6,0,0,0,0,0,6,0,0,0,0,1 },//12
{ 1,0,4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,0,1 },//13
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//14
{ 1,0,4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,0,1 },//15
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//16
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//17
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//18
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//19
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//20
{ 1,2,0,0,0,0,0,0,0,0,0,11,0,0,0,0,0,0,0,0,2,1 },//21
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//22
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//23
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//24
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//25
{ 1,2,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,2,1 },//26
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//27
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//28
{ 1,0,0,0,0,0,0,0,0,0,0,8,0,0,0,0,0,0,0,0,0,1 },//29
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//30
{ 1,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,0,0,2,2,2,1 },//31
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//32
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//33
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//34
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//35
{ 1,2,2,2,2,2,0,0,0,0,0,0,0,0,0,0,0,2,2,2,2,1 },//36
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//37
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//38
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//39
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//40
{ 1,2,2,2,2,2,2,0,0,0,0,0,0,0,0,0,2,2,2,2,2,1 },//41
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//42
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//43
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//44
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//45
{ 1,2,2,2,2,2,2,2,0,0,0,0,0,0,0,2,2,2,2,2,2,1 },//46
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//47
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//48
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//49
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//50
{ 1,2,2,2,2,2,2,2,2,0,0,0,0,2,2,2,2,2,2,2,2,1 },//51
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//52
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//53
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//54
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//55
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,0,0,0,1 },//56
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//57
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//58
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//59
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//60
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//61
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//62
{ 1,0,0,0,0,0,0,1,1,1,1,1,0,0,0,0,0,0,0,0,0,1 },//63
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//64
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//65
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//66
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//67
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//68
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//69
{ 1,0,0,0,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//70
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//71
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//72
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//73
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//74
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//75
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//76
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//77
{ 1,1,1,1,1,1,1,1,1,0,0,0,0,1,1,1,1,1,1,1,1,1 },//78
{ 9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9 }//79

    };
    void Start()
    {
        /*
                StageDataX = 10;
                StageDataY = 22;
                GlobalVariables.StageNumber = (int)StageNumbering.Stage_1;
                GlobalVariables.StageWriteFlag = true;
                CreateStage(StageData1, StageDataX, StageDataY);
        */
        StageDataX = 22;
        StageDataY = 79;
        GlobalVariables.StageNumber = (int)StageNumbering.Stage_2;
        GlobalVariables.StageWriteFlag = true;
        CreateStage(StageData2, StageDataX, StageDataY);
    }

    public void Update()
    {
        if (GlobalVariables.StageWriteFlag == true)
        {

            if (GlobalVariables.StageNumber == (int)StageNumbering.Stage_2)
            {
                StageDataX = 22;
                StageDataY = 79;
                CreateStage(StageData2, StageDataX, StageDataY);
                //                CreateStage(StageData2, StageDataX, StageDataY);//22,79
            }
        }
    }
    public void CreateStage(int[,] data, int x, int y)
    {

        GameObjectWight = GameScreen1.GetComponent<SpriteRenderer>().bounds.size.x;
        GameObjectHight = GameScreen1.GetComponent<SpriteRenderer>().bounds.size.y;

        if (GlobalVariables.StageWriteFlag == true)
        {
            target1.transform.position = new Vector2(GameObjectHight * 2, GameObjectWight * 2);
            for (int i = 0; i < x; i++)
            {
                for (int j = y; j >= 0; j--)
                {
                    if (data[j, i] == 1)
                    {
                        //       GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        GameObject obj = Instantiate(GameScreen1);
                        obj.tag = "ob_wall";
                        obj.transform.localScale = new Vector2(1, 1);
                        obj.transform.position = new Vector2(GameObjectHight * i, GameObjectWight * j);
                    }
                    if (data[j, i] == 2)
                    {
                        //       GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        GameObject obj3 = Instantiate(GameScreen3);
                        obj3.tag = "ob_wall";
                        obj3.transform.localScale = new Vector2(1, 1);
                        obj3.transform.position = new Vector2(GameObjectHight * i, GameObjectWight * j);
                    }
                    if (data[j, i] == 9)
                    {
                        GameObject obj2 = Instantiate(GameScreen2); ;
                        obj2.tag = "goal";
                        obj2.transform.localScale = new Vector2(1, 1);
                        obj2.transform.position = new Vector2(GameObjectHight * i, GameObjectWight * j);
                    }
                    if (data[j, i] == 4)
                    {
                        GameObject obj4 = Instantiate(GameScreen4); ;
                        obj4.tag = "Karasu";
                        obj4.transform.localScale = new Vector2(1, 1);
                        obj4.transform.position = new Vector2(GameObjectHight * i, GameObjectWight * j);
                    }
                    if (data[j, i] == 5)
                    {
                        GameObject obj5 = Instantiate(GameScreen5); ;
                        obj5.tag = "Togetoge";
                        obj5.transform.localScale = new Vector2(1, 1);
                        obj5.transform.position = new Vector2(GameObjectHight * i, GameObjectWight * j);
                    }
                    if (data[j, i] == 6)
                    {
                        GameObject obj6 = Instantiate(GameScreen6); ;
                        obj6.tag = "Togetoge";
                        obj6.transform.localScale = new Vector2(1, 1);
                        obj6.transform.position = new Vector2(GameObjectHight * i, GameObjectWight * j);
                    }
                    if (data[j, i] == 7)
                    {
                        GameObject obj7 = Instantiate(GameScreen7); ;
                        obj7.tag = "Togetoge";
                        obj7.transform.localScale = new Vector2(1, 1);
                        obj7.transform.position = new Vector2(GameObjectHight * i, GameObjectWight * j);
                    }
                    if (data[j, i] == 8)
                    {
                        GameObject obj8 = Instantiate(GameScreen8); ;
                        obj8.tag = "Togetoge";
                        obj8.transform.localScale = new Vector2(1, 1);
                        obj8.transform.position = new Vector2(GameObjectHight * i, GameObjectWight * j);
                    }
                    if (data[j, i] == 10)
                    {
                        GameObject obj9 = Instantiate(GameScreen9); ;
                        obj9.tag = "Togetoge";
                        obj9.transform.localScale = new Vector2(1, 1);
                        obj9.transform.position = new Vector2(GameObjectHight * i, GameObjectWight * j);
                    }
                    if (data[j, i] == 11)
                    {
                        GameObject obj10 = Instantiate(GameScreen10); ;
                        obj10.tag = "Togetoge";
                        obj10.transform.localScale = new Vector2(1, 1);
                        obj10.transform.position = new Vector2(GameObjectHight * i, GameObjectWight * j);
                    }
                }

            }
            GlobalVariables.StageWriteFlag = false;
        }
    }




}

