using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;
using TestProject;
using Assert = UnityEngine.Assertions.Assert;

namespace Tests
{
    public class SampleTestScript
    {
        // GameObject mainSceneObject;
        GameObject debugButtonObject;

        // Setup for test exec
        [SetUp]
        public void Init()
        {
            // Load a scene for test
            SceneManager.LoadScene("MainScene");
        }

        // Argument(s) value check
        [TestCase(3.141593f)]
        public void TestNearPI(float value)
        {
            // Is near PI
            Assert.AreApproximatelyEqual(Mathf.PI, value);
        }

        // Button onClick test
        [UnityTest]
        public IEnumerator TestProjectButtonClickEventTestScript()
        {
            if (debugButtonObject == null)
            {
                // Get a scene Buttom of test target
                debugButtonObject = GameObject.Find("Button_Test");
            }
            Button debugButton = debugButtonObject.GetComponent<Button>();
            // Is not null object
            Assert.IsNotNull(debugButton);
            // Wait 2 seconds
            yield return new WaitForSeconds(2f);
            // Call onClick event of Button
            debugButton.onClick.Invoke();
            // Wait 2 seconds
            yield return new WaitForSeconds(2f);
            // Finish
            yield return null;
        }

        // Ignore if iOS
        [UnityTest]
#if UNITY_IOS
        [Ignore("Ignored if iOS")]
#endif
        public IEnumerator IgnoredIosTestScript01()
        {
            // Wait 12 seconds
            yield return new WaitForSeconds(12f);
            // Finish
            yield return null;
        }

        // Timeout[ms] sample
        [UnityTest]
        [Timeout(5000)]
        public IEnumerator TimeoutTestScript()
        {
            // Wait 12 seconds
            yield return new WaitForSeconds(12f);
            // Finish
            yield return null;
        }
    }
}
