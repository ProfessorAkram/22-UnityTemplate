/**** 
 * Created by: Akram Taghavi-Burris
 * Date Created: July 03, 2022
 * 
 * Last Edited by: NA
 * Last Edited: July 03, 2022
 * 
 * Description: Updates HUD canvas referecing game manager
****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class HUDScript : MonoBehaviour
{
    /*** VARIABLES ***/


    [Header("Stats Placement")]
    public TMP_Text levelCountTextbox; //textbox for level count
    public TMP_Text livesTextbox; //textbox for the lives
    public TMP_Text healthTextbox; //textbox for highscore
    public TMP_Text scoreTextbox; //textbox for the score
    public TMP_Text highScoreTextbox; //textbox for highscore
    public TMP_Text collectableCountTextbox; //textbox for amount of collectables
    public TMP_Text TimerTextbox; //textbox for Timer display
    public TMP_Text fastestTimeTextbox; //textbox for the Fastest Time



    private void Start()
    {


    }//end Start

    // Update is called once per frame
    void Update()
    {

    }//end Update()



}
