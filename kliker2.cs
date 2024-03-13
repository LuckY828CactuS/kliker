using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

 void OnTriggerEnter2D(Collider2D other){// столкновение объекта (меч, щит)
// проверка на соответствие тэга
  if (other.gameObject.tag != gameObject.tag) { 
   Time.timeScale = 0;
   MainScript.score = 0;
  } else {
   MainScript.score++;
   Destroy (other.gameObject);// уничтожение префаба
  }
 }
}