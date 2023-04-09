//score text
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ScoreText : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform driverlocation;
    public TMPro.TextMeshProUGUI scoretext;
    public static int scorededuct = 0;

    // Update is called once per frame
    public static void scoreDeduct() {
        scorededuct -= 10;
    }
    void Update()
    {
        int val = (int)Mathf.Abs(driverlocation.position.z) + scorededuct;
        scoretext.text = "" + val ;

        if ((int)Mathf.Abs(driverlocation.position.z) > 100 && ((int)Mathf.Abs(driverlocation.position.z) + scorededuct) < 50)
        {
            scoretext.text = "You lost";
        }
        else if ((int)Mathf.Abs(driverlocation.position.z) > 100 && ((int)Mathf.Abs(driverlocation.position.z) + scorededuct) >= 50)
        {
            scoretext.text = "You Win";
        }

    }
}