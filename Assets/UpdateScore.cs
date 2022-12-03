using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateScore : MonoBehaviour
{
    private int score;
    private TextMesh textmesh;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        textmesh = GameObject.Find("Score").GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        //textmesh.text = "Score: 20";
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name.StartsWith("Kegel"))
        {
            Debug.Log(col.gameObject.name);
            score = score +2;
            textmesh.text = "Score: "+ score.ToString();
        }
    }


}
