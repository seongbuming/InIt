﻿using UnityEngine;
using System.Collections;

public class Film_Artist : MonoBehaviour {
	void Start () {
	    GetComponent<NPC>().dontChat = true;
	}
	
	void OnNPCCommandsEnd() {
        if(PlayerData.Player.Location != "세종관 옥상") {
            PlayerData.Player.Level = GameObject.Find("Mingyeong_Kim").GetComponent<NPC>().Stage-1;
            GameObject.Find("Dialogue UI").GetComponent<Dialogue>().ShowDialogue("실패", "미스터리 영예과가 옥상 문을 잠궜습니다.");
        } else if(PlayerData.Player.Level == GetComponent<NPC>().Stage-2) {
            PlayerData.Player.Level = GetComponent<NPC>().Stage-1;
            GetComponent<NPC>().dontChat = false;
        }
    }
}
