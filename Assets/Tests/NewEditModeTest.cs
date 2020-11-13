using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class Basic
    {
        
        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator BasicWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }

        [Test]
        public void BasicTest()
        {
            bool isActive = false;
            Assert.AreEqual(false, isActive);
        }

        [UnityTest]
        public IEnumerator RigidBodyMovementTest()
        {
            var go = new GameObject();
            go.AddComponent<Rigidbody>();
            var originalPosition = go.transform.position.y;

            yield return new WaitForFixedUpdate();

            Assert.AreNotEqual(originalPosition, go.transform.position.y);
        }

        // [UnityTest]
        // public IEnumerator EditorUtility_WhenExecuted_ReturnsSuccess()
        // {
        //     var utility = RunEditorUtilityInTheBackground();

        //     while (utility.isRunning)
        //     {
        //         yield return null;
        //     }

        //     Assert.IsTrue(utility.isSuccess);
        // }
        
        [UnityTest]
        public IEnumerator MonoBehaviourTest_Works()
        {
            yield return new MonoBehaviourTest<MyMonoBehaviourTest>();
        }

        public class MyMonoBehaviourTest : MonoBehaviour, IMonoBehaviourTest
        {
            private int frameCount;
            public bool IsTestFinished
            {
                get { return frameCount > 10; }
            }

            void Update()
            {
                frameCount++;
            }
        }

    }
}
