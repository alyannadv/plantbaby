using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehaviour : MonoBehaviour {
   int n;
   public void OnButtonPress(){
      if(GUILayout.Button("Visit Web Site"))
         {
             Application.OpenURL("https://www.thespruce.com/pothos-an-easy-to-grow-houseplant-1403154");
         }
   }
}
