using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loja1 : MonoBehaviour {

private Gamecontrol gamecontrole;
private Player player;
	void Start () {
		player = gameObject.GetComponent<Player>();
		gamecontrole = gameObject.GetComponent<Gamecontrol>();
	
	}

	void Update () {
		
	}

    public void roda () {
		if (player.gold >= 50f){
		    player.gold = player.gold - 50f;
			player.rodas = true;
			gamecontrole.Textoroda();
		
		}
		
	}

	public void vida(){
		if (player.gold >= 100f && player.saude < 3f){
			player.gold = player.gold - 100f;
			player.saude++;
		}
		
	}

	public void mercenarios () {
		if (player.gold >= 50f){
		    player.gold = player.gold - 50f;
			player.mercenario = true;
			gamecontrole.textomercenario();
		
		}
		
	}


	



}
