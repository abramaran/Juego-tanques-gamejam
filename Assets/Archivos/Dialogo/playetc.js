//using UnityEngine.SceneManagement;

//public class play : MonoBehaviour {

public function BotonJugar(){

Application.LoadLevel("nivel1");
//SceneManager.LoadScene("play");
}
public function BotonSalir(){
   
   Debug.Log("Te has salido del juego");  
   Application.Quit();
    
}

//}