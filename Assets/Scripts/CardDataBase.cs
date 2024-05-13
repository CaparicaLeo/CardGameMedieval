using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDataBase : MonoBehaviour
{
   public static List<Cards> cardList = new List<Cards>();

   void Awake(){
        cardList.Add(new Cards(0,"None",0,0,0,"None",null));
        cardList.Add(new Cards(1,"Jester",0,0,1,"Who make the clown smile?", Resources.Load<Sprite>("Jester")));
        cardList.Add(new Cards(2,"Villager",1,1,1,"U want a esmerald? ", Resources.Load<Sprite>("Villager")));
        cardList.Add(new Cards(3,"Knight",2,2,3,"I am Ed and this is Silver, u good?", Resources.Load<Sprite>("Knight")));
        cardList.Add(new Cards(4,"Bishop",2,1,4,"Amen bro", Resources.Load<Sprite>("Priest")));
        cardList.Add(new Cards(5,"Bard", 2, 1, 3, "Me chamo de fiuk",Resources.Load<Sprite>("Fiuk")));
        cardList.Add(new Cards(6,"Queen",4,3,5,"Give them brioches", Resources.Load<Sprite>("Fiona")));
        cardList.Add(new Cards(7,"The Plague Doctor",4,4,3,"Yes, i look like a bird", Resources.Load<Sprite>("Peste")));
        cardList.Add(new Cards(8,"Executioner",4,5,3,"die mf", Resources.Load<Sprite>("Peste")));
   }
}
