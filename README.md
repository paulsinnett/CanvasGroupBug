# CanvasGroupBug

This is a Unity TestRunner tests to show a bug and workaround in CanvasGroup. To run the tests, open the Test Runner window and press the Run All button.

https://issuetracker.unity3d.com/issues/ui-canvasgroup-interactable-fields-graphics-are-not-applied-when-ui-element-is-not-a-direct-child-of-canvasgroup

## Bug description

If an interactive object (e.g. Button) is instantiated at run time as a grandchild of a CanvasGroup, the groups `interactable` flag is not respected. If the object is a child, or added manually to the scene, the flag is respected.

## Workaround

After instantiating the interactive object send it the message `"OnCanvasGroupChanged"`. This updates the state of the object from the CanvasGroup.
