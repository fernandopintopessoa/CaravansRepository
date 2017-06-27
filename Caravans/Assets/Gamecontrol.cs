using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamecontrol : MonoBehaviour {
    public Text mercenariotxt;
	public Text vidatxt;
	public Text goldtxt;
	public Text rodatxt;
    private Player player;

	void Start () {
		player = GetComponent<Player>();
		goldtxt.text = "GOLD: "+ player.gold.ToString();
		
		}
	
	
	void Update () {
		}

    public void Textogold(){
        goldtxt.text = "GOLD: "+ player.gold.ToString();
	}
	public void Textoroda(){
		rodatxt.text = "RODA extra";
	}
	public void textovida(){
		vidatxt.text = "VIDA 3/"+player.saude.ToString();
    }
	public void textomercenario(){
		mercenariotxt.text = "Protegido";
	}


}
