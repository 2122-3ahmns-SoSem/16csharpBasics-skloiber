using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variablen : MonoBehaviour
{

    Color farbe;
    int anzTueren1;
    int anzTueren2;
    int anzTueren3;
    bool fahren;
    string name;
   


    public enum Himmelsrichtung 
{
	Nord,
	Sued,
	West,
	Ost,
}


        //Ich habe es gemeinsam mit Vanessa Dürnberger und Laura Forsthuber gemacht. :)
void Start()
    {
        Debug.Log(
            Himmelsrichtung.Nord + "" + Himmelsrichtung.Sued + "" + Himmelsrichtung.West + "" + Himmelsrichtung.Ost);

      
        int anzTueren1 = 8, anzTueren2 = 4, anzTueren3 = 600;  //Wenn man eine Anzahl berechnen will.
        Debug.Log(anzTueren1 + anzTueren2 + anzTueren3);  
        
        Debug.Log(anzTueren2 > anzTueren3); // returns False, weil anzTueren größer ist.

        string name = "Sophie";     //Wenn man jemanden anreden will.
        Debug.Log("Hello " + name);

        Color farbe = Color.blue;  //Wenn das Gameobject Blau werden soll.
        Debug.Log(farbe);
        gameObject.GetComponent<Renderer>().material.color = farbe;
         

    }

        }
