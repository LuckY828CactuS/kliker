using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainScript : MonoBehaviour
{
 public GameObject[] prefabs;   //массив префабов
 public GameObject[] players;   //массив объектов 
 public static int score,record,n,k = 0; //счёт, рекорд, "n,k" - счетчики
 public Text scoreT;    //текст на экране

void Start()
{
  score = 0;
  Time.timeScale = 1;        
  StartCoroutine (PrefabsCreate ());
  scoreT = scoreT.GetComponent<Text> ();
  record = PlayerPrefs.GetInt ("Record");
}


void Update()
{
  n = Random.Range (0, prefabs.Length); // генерация случайных чисел 
//от 0 до кол-ва префабов
  scoreT.text = score + "/" + record;  // вывод счета и рекорда 
  if (score >= record) {       
   record = score;
   PlayerPrefs.SetInt ("Record", record); // сохранение рекорда
  }
   
}

 IEnumerator PrefabsCreate(){ // создание случайного префаба
  while (true) {
   Instantiate (prefabs [n], new Vector2 (0, 6.5f), Quaternion.identity);
   yield return new WaitForSeconds (0.5f);
  }
 }

 public void BtnClick(string btn){   // метод для кнопок
  if(btn == "Click"){
   Time.timeScale = 1;
   
   k++;          
   if (k >= prefabs.Length) {     
    k = 0; 
// обнуляем счетчик, если k превышает кол-во префабов
   } 
   
  }
  
 }

}
