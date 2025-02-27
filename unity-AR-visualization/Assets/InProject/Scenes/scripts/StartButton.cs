using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace jsonhelpernamespace
{
    public class StartButton : MonoBehaviour
    {
        // Start is called before the first frame update
        public LoadingObjectController LoadObject; 
        public GameObject prefab_click;
        public GameObject prefab_drag;
        public GameObject prefab_drag_goal;
        void Start()
        {

        }

        public void SceneBuilder(status status)
        {
            if (status.loaded_status == true)
            {
                LoadObject.LoadingObject.SetActive(true);
                JsonHelper sceneElements = GameObject.Find("Load_File").GetComponent<JsonLoader>().jsonHelper;
                SceneBuilderController.prefab_click = prefab_click;
                SceneBuilderController.prefab_drag = prefab_drag;
                SceneBuilderController.prefab_drag_goal = prefab_drag_goal;
                SceneManager.LoadScene("task_scene");
            }
            else if(SceneBuilderController.oneJSON)
            {
                LoadObject.LoadingObject.SetActive(true);
                JsonHelper sceneElements = GameObject.Find("RadialSet_Interaction").GetComponent<JsonLoader>().jsonHelper;
                SceneBuilderController.prefab_click = prefab_click;
                SceneBuilderController.prefab_drag = prefab_drag;
                SceneBuilderController.prefab_drag_goal = prefab_drag_goal;
                SceneManager.LoadScene("task_scene");
            }
            else
            {
                return;
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
