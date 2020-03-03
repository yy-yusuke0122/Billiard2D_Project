using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManagement : MonoBehaviour
{
    int stageNum;
    [SerializeField]
    GameObject[] stages;
    // Start is called before the first frame update
    void Start()
    {
        // ステージ番号を取得
        SetCurrentStageNum();
        // ステージを生成
        CreateStage();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 保存されている番号を取得。取得に失敗すると、0番がセットされる
    void SetCurrentStageNum()
    {
        if (PlayerPrefs.HasKey("StageNum"))
        {
            stageNum = PlayerPrefs.GetInt("StageNum");
        }
        else
        {
            stageNum = 0;
        }
    }

    // ステージ番号を見て、ステージを生成する
    void CreateStage()
    {
        GameObject obj = Instantiate(stages[stageNum], this.transform.position, Quaternion.identity);
    }
}
