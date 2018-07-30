using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TestCanvasGroupBug {

    // A UnityTest behaves like a coroutine in PlayMode
    // and allows you to yield null to skip a frame in EditMode
    [UnityTest]
    public IEnumerator TestCanvasGroupAsParentStatic() {
        yield return SceneManager.LoadSceneAsync("CanvasGroupAsParentStatic");
        yield return null;
        var button = GameObject.FindObjectOfType<Button>();
        Assert.IsFalse(button.IsInteractable());
    }

    [UnityTest]
    public IEnumerator TestCanvasGroupAsParentDynamic() {
        yield return SceneManager.LoadSceneAsync("CanvasGroupAsParentDynamic");
        yield return null;
        var button = GameObject.FindObjectOfType<Button>();
        Assert.IsFalse(button.IsInteractable());
    }

    [UnityTest]
    public IEnumerator TestCanvasGroupAsGrandparentStatic() {
        yield return SceneManager.LoadSceneAsync("CanvasGroupAsGrandparentStatic");
        yield return null;
        var button = GameObject.FindObjectOfType<Button>();
        Assert.IsFalse(button.IsInteractable());
    }

    [UnityTest]
    public IEnumerator TestCanvasGroupAsGrandparentDynamic() {
        yield return SceneManager.LoadSceneAsync("CanvasGroupAsGrandparentDynamic");
        yield return null;
        var button = GameObject.FindObjectOfType<Button>();
        Assert.IsFalse(button.IsInteractable());
    }

    [UnityTest]
    public IEnumerator TestCanvasGroupAsGrandparentDynamicWorkaround() {
        yield return SceneManager.LoadSceneAsync("CanvasGroupAsGrandparentDynamicWorkaround");
        yield return null;
        var button = GameObject.FindObjectOfType<Button>();
        Assert.IsFalse(button.IsInteractable());
    }
}
