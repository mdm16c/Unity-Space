using UnityEngine;
 
 // Attach this component to the GameObject you want to follow the touch position.
 public class touchFollow : MonoBehaviour
 {
     // every frame
     void Update ()
     {
         // if left-mouse-button is being held OR there is at least one touch
         if (Input.GetMouseButton(0) || Input.touchCount > 0)
         {
             // get mouse position in screen space
             // (if touch, gets average of all touches)
             Vector3 screenPos = Input.mousePosition;
             // set a distance from the camera
             screenPos.z = 10.0f;
             // convert mouse position to world space
             Vector3 worldPos = Camera.main.ScreenToWorldPoint(screenPos);
 
             // get current position of this GameObject
             Vector3 newPos = transform.position;
             // set x position to mouse world-space x position
             newPos.x = worldPos.x;
             newPos.z = worldPos.z;
             // apply new position
             transform.position = Vector3.MoveTowards(transform.position, worldPos, 10 * Time.deltaTime);
         }
     }
 }