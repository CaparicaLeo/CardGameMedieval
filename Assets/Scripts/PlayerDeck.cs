using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeck : MonoBehaviour
{
    public List<Cards> deck = new List<Cards>();
    // Start is called before the first frame update
    void Start()
    {  
        int x=0;
        for(int i=0;i<40;i++){
            x = Random.Range(1,9);
            deck[i] = CardDataBase.cardList[x];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
