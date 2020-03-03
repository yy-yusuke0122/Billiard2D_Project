using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BallType
{
    Blue,
    Red
};

public class Ball : MonoBehaviour
{
    [SerializeField]
    BallType initType;
    public BallType type { get; private set; }

    Rigidbody2D rb = null;

    // Start is called before the first frame update
    void Start()
    {
        // 初期タイプを代入
        type = initType;
        // コンポーネントの取得
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 新しい状態を外部からセットし、新しいBodyを生成する
    public void ChangeState(BallType _type)
    {
        this.type = _type;
        CreateNewBody();
    }

    [SerializeField]
    GameObject BluePref = null;
    [SerializeField]
    GameObject RedPref = null;
    // 現在の状態を見て、新しいBodyを生成する
    void CreateNewBody()
    {
        // 現在のBodyを検索し、破壊する
        foreach (Transform c in this.transform)
        {
            if (c.gameObject.tag == "Body")
                GameObject.Destroy(c.gameObject);
        }

        // 新しいBodyを生成
        GameObject body = null;
        switch (type)
        {
            case BallType.Blue:body = BluePref; break;
            case BallType.Red: body = RedPref; break;
        }
        Instantiate(body, this.transform);
    }
}
