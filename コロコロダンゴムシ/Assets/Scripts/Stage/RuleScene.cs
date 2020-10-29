using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // ←追加

public class RuleScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 「Enter」キーが押された場合
        if (Input.GetKeyUp(KeyCode.Return))
        {
            // 『ステージ選択画面』へシーン遷移
            SceneManager.LoadScene("SelectStage");
        }
    }

    /// <summary>
    /// 「StartButton」をクリックした際に
    /// 呼び出されます。
    /// </summary>

}
