using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/* 
Incremental clicker requriements;

have an object
be able to click it
Upon click, a value must be raised (the "score/currency")

a button that with enough currency will increase the amount of currency per click
Currency must be subtracted upon purchase.
Upon purchase of particular item, the next upgrade for that line of upgrade must increase in price.



This script is what happens when you press a button (or the cube)
 */


public class Button : MonoBehaviour
{

    [SerializeField]
    private Button increaseScore; //the button to press to increse score is declared here.




    // Start is called before the first frame update
    void Start()
    {
        Button btn = increaseScore.GetComponent<Button>();
        btn.onClick.AddListener(DoThisOnClick);
    }

    void DoThisOnClick()
    {
            //Output this to console when Button1 or Button3 is clicked
            Debug.Log("You have clicked the button!");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
