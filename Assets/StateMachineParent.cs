using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachineParent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
public abstract class State
{
    public virtual IEnumerator start()
    {
        yield break;
    }
    public virtual IEnumerator end()
    {
        yield break;
    }
}
public abstract class StateMachine : MonoBehaviour
{
    protected State state;
    protected State prev_state;
    public void setState(State new_state)
    {
        state = new_state;
        StartCoroutine(routine: state.start());
    }
}
public class Option_Menu: StateMachine
{
    public void onInitialClick()
    {
        //save current state
        //open menu
    }
    public void onExitingClick()
    {
        //close menu
        //load saved state
    }
}

