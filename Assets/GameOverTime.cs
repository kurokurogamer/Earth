using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverTime : MonoBehaviour
{
    public GameObject popObject = null;
    int elapsedTime;
    //int elapsedTime1;
    //int elapsedTime10;
    // Start is called before the first frame update
    void Start()
    {
        elapsedTime = 60 - (int)TimeRote.time - 5;
		//elapsedTime10 = (3600 - elapsedTime) / 60 / 10;
		//elapsedTime1 = (3600 - elapsedTime) / 60 - (elapsedTime10 * 10);
	}

	// Update is called once per frame
	void Update()
    {
        Text popText = popObject.GetComponent<Text>();
		// 10秒以下の場合は0が表示されるようにToStringの引数に00を入れておく
		popText.text = "0:" + elapsedTime.ToString("00");
        //popText.text = "0:" + elapsedTime10.ToString() + elapsedTime1.ToString();
    }
}
