using UnityEditor;
using UnityEngine;

namespace Shortcuts
{
    static class Shortcuts
    {
        const int resetMenuPriority = 2000;

        [MenuItem("GameObject/Reset Position", false, resetMenuPriority + 1)]
        static void ResetPosition()
        {
            Selection.activeTransform.position = Vector3.zero;
        }

        [MenuItem("GameObject/Reset Position", true)]
        static bool ResetPositionValidate()
        {
            return Selection.activeTransform != null;
        }

        [MenuItem("GameObject/Reset Rotation", false, resetMenuPriority + 2)]
        static void ResetRotation()
        {
            Selection.activeTransform.rotation = Quaternion.identity;
        }

        [MenuItem("GameObject/Reset Rotation", true)]
        static bool ResetRotationValidate()
        {
            return Selection.activeTransform != null;
        }

        [MenuItem("GameObject/Reset Scale", false, resetMenuPriority + 3)]
        static void ResetScale()
        {
            Selection.activeTransform.localScale = Vector3.one;
        }

        [MenuItem("GameObject/Reset Scale", true)]
        static bool ResetScaleValidate()
        {
            return Selection.activeTransform != null;
        }

        [MenuItem("GameObject/Reset Transform", false, resetMenuPriority + 4)]
        static void ResetTransform()
        {
            Selection.activeTransform.SetPositionAndRotation(Vector3.zero, Quaternion.identity);
            Selection.activeTransform.localScale = Vector3.one;
        }

        [MenuItem("GameObject/Reset Transform", true)]
        static bool ResetTransformValidate()
        {
            return Selection.activeTransform != null;
        }

        [MenuItem("Edit/Select Parent", false, 81)] // Before "Select Children"
        static void SelectParent()
        {
            Selection.activeTransform = Selection.activeTransform.parent;
        }

        [MenuItem("Edit/Select Parent", true)]
        static bool SelectParentValidate()
        {
            return Selection.activeTransform != null &&
                   Selection.activeTransform.transform.parent != null;
        }
    }
}
