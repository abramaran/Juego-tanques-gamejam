//using UnityEngine.SceneManagement;

//public class play : MonoBehaviour {

public function BotonJugar(){

Application.LoadLevel("slenderpartepri");
//SceneManager.LoadScene("play");
}
public function BotonSalir(){
   
   Debug.Log("Te has salido del juego");  
   Application.Quit();
    
}

//}