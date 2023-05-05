using UnityEngine;

public class ObjectClickedDetector : MonoBehaviour
{

    public GameObject resume;
    public GameObject info; 

    // Update is called once per frame
    void Update()
    {
            // Check for mouse click
      if (Input.GetMouseButtonDown(0))
      {
     
         Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
         RaycastHit hit;
         if (Physics.Raycast(ray, out hit))
         {
             if (hit.collider.gameObject.name == "Resume Model" )
             {
                resume.SetActive(true);
                info.SetActive(false);
             }
             
         }
      }
      // Check for touch input
      else if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
      {
          Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
          RaycastHit hit;
          if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
          {
              Debug.Log("Object touched: " + gameObject.name);
              // Do something when the object is touched
          }
      }
        
    }
}
