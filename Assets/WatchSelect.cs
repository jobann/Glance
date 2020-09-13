using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WatchSelect : MonoBehaviour
{

    public GameObject watchModel1;
    public GameObject watchModel2;
    public GameObject watchModel3;


    public GameObject w1window;
    public GameObject w2window;
    public GameObject w3window;

    Animation w1animation;
    Animation w2animation;
    Animation w3animation;

    // Start is called before the first frame update
    void Start()
    {
        w1animation = w1window.GetComponent<Animation>();
        w2animation = w2window.GetComponent<Animation>();
        w3animation = w3window.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void watchOneButtonClicked()
    {
        //Show watch One model
        watchModel1.SetActive(true);
        watchModel2.SetActive(false);
        watchModel3.SetActive(false);

        //Animate watch 1 window
        w1animation["w1animation"].speed = 1;
        w1animation.Play();
    }

    public void watchTwoButtonClicked()
    {
        //Show Watch two Model
        watchModel1.SetActive(false);
        watchModel2.SetActive(true);
        watchModel3.SetActive(false);

        //Animate watch 2 window
        w2animation["w2animation"].speed = 1;
        w2animation.Play();
    }
    public void watchThreeButtonClicked()
    {
        //Show Watch three Model
        watchModel1.SetActive(false);
        watchModel2.SetActive(false);
        watchModel3.SetActive(true);

        //Animate watch 3 window
        w3animation["w3animation"].speed = 1;
        w3animation.Play();
    }
    public void CloseButtonClicked()
    {
        string name = EventSystem.current.currentSelectedGameObject.name;

        if(name == "w1close")
        {
            //play animation to close w1 window
            w1animation["w1animation"].speed = -1;
            w1animation["w1animation"].time = w1animation["w1animation"].length;
            w1animation.Play();
        }
        else if(name == "w2close")
        {
            //play animation to close w2 window
            w2animation["w2animation"].speed = -1;
            w2animation["w2animation"].time = w2animation["w2animation"].length;
            w2animation.Play();
        }
        else if(name == "w3close")
        {
            //Play animation to close w3 window
            w3animation["w3animation"].speed = -1;
            w3animation["w3animation"].time = w3animation["w3animation"].length;
            w3animation.Play();
        }

    }

}
