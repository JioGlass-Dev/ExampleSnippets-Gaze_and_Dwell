using JMRSDK.InputModule;
using UnityEngine;

public class GazeAndDwellDemo : MonoBehaviour,ISelectClickHandler,ISelectHandler
{
    public GameObject model;
    public GameObject sphere;
    int num = 0;
    private void Start()
    {
        JMRInputManager.Instance.AddGlobalListener(gameObject);
    }
    public void ChangeColor()
    {
        num = Random.Range(1, 4);
        MeshRenderer meshRenderer = model.GetComponent<MeshRenderer>();

        switch (num)
        {
            case 1:
                meshRenderer.material.color = Color.red;
                break;
            case 2:
                meshRenderer.material.color = Color.blue;
                break;
            case 3:
                meshRenderer.material.color = Color.green;
                break;
            case 4:
                meshRenderer.material.color = Color.cyan;
                break;
        }
    }
    public void ChangeSize()
    {
        num = Random.Range(1, 4);
        switch (num)
        {
            case 1:
                model.transform.localScale = Vector3.one * .1f;
                break;
            case 2:
                model.transform.localScale = Vector3.one * .2f;
                break;
            case 3:
                model.transform.localScale = Vector3.one * .3f;
                break;
            case 4:
                model.transform.localScale = Vector3.one * .4f;
                break;
        }
    }
    public void OnSelectClicked(SelectClickEventData eventData)
    {
        num = Random.Range(1, 4);
        MeshRenderer meshRenderer = eventData.selectedObject.GetComponent<MeshRenderer>();
        switch (num)
        {
            case 1:
                meshRenderer.material.color = Color.red;
                break;
            case 2:
                meshRenderer.material.color = Color.blue;
                break;
            case 3:
                meshRenderer.material.color = Color.green;
                break;
            case 4:
                meshRenderer.material.color = Color.cyan;
                break;
        }
    }
}
