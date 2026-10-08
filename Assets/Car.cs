using UnityEngine;

public class Car : MonoBehaviour
{
   private float driveAxis, brakeAxis, turnAxis;

   public void Drive(float driveAxis){
      this.driveAxis = Mathf.Clamp(driveAxis, -1f, 1f);
   }

   public void Brake(float brakeAxis, 0f, 1f){
      this.brakeAxis = Mathf.Clamp(brakeAxis, 0f, 1f);

   }
}