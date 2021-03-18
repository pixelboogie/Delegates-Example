using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delegates : MonoBehaviour
{

    // accessor, keyword delegate, define return type, name signature, parameters
    public delegate void TestDelegate();

    private TestDelegate testDelegateFunction;

    void Start()
    {
        
        testDelegateFunction = MyTestDelegateFunction;

        testDelegateFunction += MyTestDelegateFunction2;

        testDelegateFunction();

        testDelegateFunction -= MyTestDelegateFunction2;

        testDelegateFunction();

    }

    private void MyTestDelegateFunction()
    {
        Debug.Log("Executing - MyTestDelegateFunction");
    }

    private void MyTestDelegateFunction2()
    {
        Debug.Log("Executing - MyTestDelegateFunction2");
    }

}
