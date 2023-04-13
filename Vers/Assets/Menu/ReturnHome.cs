using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ReturnHome : MonoBehaviour
{
  [SerializeField] private Button Home,Reroll;
    void Start()
    {
        Home.onClick.AddListener(()=>RealHome(Home));
        Reroll.onClick.AddListener(()=>RealReroll(Reroll));
    }

   public void RealHome(Button home){

     SceneManager.LoadScene(0);
   }
   public void RealReroll(Button reroll){

     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
   }
    
}
