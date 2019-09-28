 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Experimental.UIElements;
using UnityEngine.UI; 
public class Interface : MonoBehaviour {

	public Text Scoretext;
    bool khelkhatam; 
    int score; 
   public Button[] buttons;
    	void Start () {
            khelkhatam = false;
		score = 0; 
        InvokeRepeating("updateScore",1.0f,0.5f); 
	}
	
	// Update is called once per frame
	void Update () {
        string v = "Score:- " + score;
        Scoretext.text  = v; 
	}

    void updateScore(){

        if(!khelkhatam)
        {        
      score += 1;
        }
    }

    public void gameOver()
    {
        khelkhatam = true;
        foreach (Button button in buttons)
        {
            button.gameObject.SetActive(true);
        }
    }
    public void Run()
    {
            Application.LoadLevel("Lvl1");

    }







    public void Pause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
    }
   
    public void Menu()
    {
        Application.LoadLevel("Menu");
    }
    public void Exit()
    {
        Application.Quit();
    }
        
    




}


