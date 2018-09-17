using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HussenController : MonoBehaviour
{

    new Rigidbody2D rigidbody2D;

    public float MaxHeight;
    public float HusenVelocity;
    public Vector3 Pos;
    public Vector3 WorldPointPos;
    public float PointX;
    public float PointY;

    public GameObject target1;

    public int HusenGravityX;
    public int HusenGravityY;

    public int StageSize = 6;

    public bool StageWriteFlag;

    public Vector2 HusenPosition;

    public GameObject GameScreen1;
    public GameObject GameScreen2;
    public GameObject GameScreen3;
    public GameObject GameScreen4;

    public float GameObjectHight;
    public float GameObjectWight;

    public float[] KarasuHight;
    public Vector2[] KarasuPosition;
    public int KarasuHiki=0;


    public float HusenPositionDontMoveX;
    public float HusenPositionDontMoveY;

    public float coefficient;

    public int StageNumber;

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
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//2
{ 1,0,4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,0,1 },//3
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//4
{ 1,0,4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,0,1 },//5
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//6
{ 1,0,4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,0,1 },//7
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//8
{ 1,0,4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,0,1 },//9
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//10
{ 1,0,4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,0,1 },//11
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//12
{ 1,0,4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,0,1 },//13
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//14
{ 1,0,4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,0,1 },//15
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//16
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//17
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//18
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//19
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//20
{ 1,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,1 },//21
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//22
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//23
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//24
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//25
{ 1,2,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,2,1 },//26
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//27
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//28
{ 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },//29
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


    void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Use this for initialization
    void Start()
    {
        target1 = GameObject.Find("huusen");
        HusenPosition = target1.transform.position;
        StageNumber = 1;
        StageWriteFlag = true;
        //CreateStage(StageData1, 10, 22);
        CreateStage(StageData2, 22, 79);
    }

    // Update is called once per frame
    void Update()
    {
        if (StageWriteFlag == true)
        {
            if (StageNumber == 2)
            {
                CreateStage(StageData2, 22, 79);
            }
        }

        HusenPosition = target1.transform.position;

        if (Input.GetMouseButtonDown(0) && transform.position.y < MaxHeight)
        {
            //            target1.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y, 0);
            //マウス位置座標をVector3で取得
            Pos = Input.mousePosition;
            // マウス位置座標をスクリーン座標からワールド座標に変換する
            WorldPointPos = Camera.main.ScreenToWorldPoint(Pos);
            PointX = WorldPointPos.x;
            PointY = WorldPointPos.y;

            Flap();
        }
    }

    public void Flap()
    {
        
        HusenGravityX = Mathf.CeilToInt(PointX - HusenPosition.x);
        HusenGravityY = Mathf.CeilToInt(PointY - HusenPosition.y);
        /*
        HusenGravityX = Mathf.CeilToInt(PointX);
        HusenGravityY = Mathf.CeilToInt(PointY);
        */
        if (HusenGravityX == 0)
        {
            HusenGravityX = -1;
        }
        if (HusenGravityY == 0)
        {
            HusenGravityY = -1;
        }

        HusenPositionDontMoveX = Mathf.CeilToInt(PointX - HusenPosition.x);
        HusenPositionDontMoveY = Mathf.CeilToInt(PointY - HusenPosition.y);


        if (((HusenPositionDontMoveX <= 0) && (HusenPositionDontMoveY <= 0)) || ((HusenPositionDontMoveX >= 0) && (HusenPositionDontMoveY <= 0)))
        {
            if ((HusenGravityX < 0.0f) && (HusenGravityY < 0.0f))//00
            {
                //            rigidbody2D.velocity = new Vector2(-1 * 6.0f / HusenGravityX, -1 * 6.0f / HusenGravityY);
                rigidbody2D.velocity = new Vector2(-1 * 10.0f / HusenGravityX * 0.5f, -1 * 10.0f / HusenGravityY);
            }
            if ((HusenGravityX >= 0.0f) && (HusenGravityY < 0.0f))//10
            {
                rigidbody2D.velocity = new Vector2(-1 * 10.0f / HusenGravityX * 0.5f, -1 * 10.0f / HusenGravityY);
            }
            if ((HusenGravityX >= 0.0f) && (HusenGravityY >= 0.0f))//11
            {
                rigidbody2D.velocity = new Vector2(-1 * 10.0f / HusenGravityX * 0.5f, -1 * 10.0f / HusenGravityY);
            }
            if ((HusenGravityX < 0.0f) && (HusenGravityY >= 0.0f))//01
            {
                rigidbody2D.velocity = new Vector2(-1 * 10.0f / HusenGravityX * 0.5f, -1 * 10.0f / HusenGravityY);
            }
        }
            //        Debug.Log("PointX:" + PointX);
        Debug.Log("PointY:" + PointY);
        //        Debug.Log("HusenGravityX:" + HusenGravityX);
        Debug.Log("HusenGravityY:" + HusenGravityY);
        Debug.Log("pos1.x:" + HusenPosition.x);
        Debug.Log("pos1.y:" + HusenPosition.y);

    }

    public void CreateStage(int[,] data, int x, int y)
    {
        GameObjectWight = GameScreen1.GetComponent<SpriteRenderer>().bounds.size.x;
        GameObjectHight = GameScreen1.GetComponent<SpriteRenderer>().bounds.size.y;

        if (StageWriteFlag == true )
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
                        KarasuHiki = KarasuHiki + 1;
                    }
                }

            }
            StageWriteFlag = false;
        }
    }

    public void OnCollisionEnter2D(Collision2D c)
    {
        string tag = c.gameObject.tag;

        if (tag == "ob_wall")
        {
            //            rigidbody2D.velocity = new Vector2(-1 * PointX, -1 * PointY);

            if ((PointX < 0.0f) && (PointY < 0.0f))//00
            {
                rigidbody2D.velocity = new Vector2( 2, 2);
            }
            if ((PointX >= 0.0f) && (PointY < 0.0f))//10
            {
                rigidbody2D.velocity = new Vector2(-1 * 2, 2);
            }
            if ((PointX >= 0.0f) && (PointY >= 0.0f))//11
            {
                rigidbody2D.velocity = new Vector2(-1 * 2, -1 * 2);
            }
            if ((PointX < 0.0f) && (PointY >= 0.0f))//01
            {
                rigidbody2D.velocity = new Vector2( 2, -1 * 2);
            }

            Debug.Log("hit Object  COLLISION");
            Debug.Log("1:hit filed: " + c.gameObject.tag);

        }
        if (tag == "goal")
        {
            StageNumber = StageNumber + 1;
            StageWriteFlag = true;
            //            CreateStage(StageData2, 21, 57);
            GameObject[] cubes = GameObject.FindGameObjectsWithTag("ob_wall");
            foreach (GameObject cube in cubes)
            {
                // 消す！
                Destroy(cube);
            }
            GameObject[] cubes2 = GameObject.FindGameObjectsWithTag("goal");
            foreach (GameObject cube in cubes2)
            {
                // 消す！
                Destroy(cube);
            }
        }

    }
    void FixedUpdate()
    {
        // 空気抵抗を与える
        rigidbody2D.AddForce(-coefficient * rigidbody2D.velocity);
    }
}