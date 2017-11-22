using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoreboard : MonoBehaviour {

    [SerializeField]
    GameObject playerScoreBoardItem;

    [SerializeField]
    Transform playerScoreBoardList;

    void OnEnable()
    {   
        
        Player[] players = GameManager.GetAllPlayers();
        foreach(Player player in players)
        {
            GameObject itemGO = (GameObject)Instantiate(playerScoreBoardItem, playerScoreBoardList);
            PlayerScrollBoardItem item = itemGO.GetComponent<PlayerScrollBoardItem>();
            if (item != null)
            {
                item.Setup(player.username, player.kills, player.deaths);
            }
        }

        //Loop through and set up a list item for each one

        //Setting the ui elements equal to the relevant data
    }

    void OnDisable()
    {
        foreach(Transform child in playerScoreBoardList)
        {
            Destroy(child.gameObject);
        }
        //Clean up our list of items
    }
}
