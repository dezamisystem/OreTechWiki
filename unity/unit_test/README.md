# Unity Test Framework

## 前提条件

### 確認したUnityバージョン

```sh
2019.2.21f1
```

## 導入方法

- Unityの```Package Manager```から以下をインポート

```sh
Test Framework
```

<img src="unity001.png" width="640">

- Unityの```Test Runner```を起動

<img src="unity002.png" width="360">

- 初回起動時は以下

<img src="unity003.png" width="360">

- ウィンドウのタイトルバーにある三本線アイコンをクリック

<img src="unity004.png" width="560">

- ```Enable playmode tests for all assemblies```を選択

- Unityを**再起動**する

- Unityの```Test Runner```を起動し、以下になっていれば準備完了

<img src="unity005.png" width="360">

## テストスクリプト作成方法

- ```Test Runner```内のモード選択から```PlayMode```を選択

- Unityの```Project```窓で```Assets```を選択する

<img src="unity006.png" width="200">

- ```Test Runner```の```PlayMode```内のボタンから```Create Test Script in current folder```をクリック
  
- **警告！決して```Create PlayMode Test Assembly Folder```を選んではいけない！もし選んでしまったら…**

<img src="kibayasi01.jpg" width="800">

- **（Testsフォルダと新規シナリオスクリプトは作成されるが、そこからプロジェクトのスクリプトクラスなどにはアクセス出来ない、という現象を確認）**

- ```Assets```直下に新規テストスクリプトが作成されるので、適切な名前を付ける

<img src="unity007.png" width="400">

## シナリオの書き方

### テスト例

- 「Button」クリック時の動作テスト

<img src="ios_screen02.png" width="320">

- テストスクリプトをエディタで開き、シナリオを書く

<details><summary>テストスクリプト例</summary><div>

```c#
using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;
using TestProject;

namespace Tests
{
    public class SampleTestScript
    {
        GameObject mainSceneObject;
        GameObject debugButtonObject;

        // Setup for test exec
        [SetUp]
        public void Init()
        {
            // Load a scene for test
            SceneManager.LoadScene("MainScene");
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator TestProjectOnButtonMethodTestScript()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            if (mainSceneObject == null)
            {
                // Get a scene object of test target
                mainSceneObject = GameObject.Find("GameObject_MainScene");
            }
            // Get a script class of test target
            MainScene mainScene = mainSceneObject.GetComponentInChildren<MainScene>();
            // Wait 2 seconds
            yield return new WaitForSeconds(2f);
            // Call a method of test target
            mainScene.OnButton();
            // Wait 2 seconds
            yield return new WaitForSeconds(2f);
            // Finish
            yield return null;
        }

        [UnityTest]
        public IEnumerator TestProjectButtonClickEventTestScript()
        {
            if (debugButtonObject == null)
            {
                // Get a scene Buttom of test target
                debugButtonObject = GameObject.Find("Button_Test");
            }
            Button debugButton = debugButtonObject.GetComponent<Button>();
            // Wait 2 seconds
            yield return new WaitForSeconds(2f);
            // Call onClick event of Button
            debugButton.onClick.Invoke();
            // Wait 2 seconds
            yield return new WaitForSeconds(2f);
            // Finish
            yield return null;
        }


        [UnityTest]
#if UNITY_ANDROID
        [Ignore("BAN!")]
#endif
        public IEnumerator IgnoredTestScript01()
        {
            // Wait 12 seconds
            yield return new WaitForSeconds(12f);
            // Finish
            yield return null;
        }

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
```

</div></details>

- ```Test Runner```にテストシナリオが反映されているのを確認

<img src="unity008.png" width="400">

### 注意点

- シナリオから必ず対象の```Scene```を指定する

```C#
// Setup for test exec
[SetUp]
public void Init()
{
    // Load a scene for test
    SceneManager.LoadScene("MainScene");
}
```

## 実機テスト

- あらかじめ実機での通常動作が正常なのを確認

- ```Test Runner```内の階層窓からテストしたいカテゴリを選択

- ```Test Runner```内のタブバーから```Run all in player (現在のターゲット)```をクリック

### Androidの場合

- ```Run all in player (Android)```をクリックするとビルドからテスト実行まで自動でやってくれる

- テストの結果は```Test Runner```上で確認できる

### iOSの場合

- ```Run all in player (iOS)```をクリックすると```Xcode```プロジェクトの出力まではやってくれる

- ```Xcode```から```Run```すればテストが開始される

- テストの結果は```Test Runner```上で確認できる

### 補足

- テストを実行するアプリはOSホーム上で新たに作成される（AndroidとiOSで共通）

<img src="ios_screen01.png" width="320">

## テストは成功した、しかし…

### なぜ```Create PlayMode Test Assembly Folder```が動作してくれないのか？

<img src="kibayasi02.jpg" width="800">

---

Copyright (C) 2020 東亜プリン秘密研究所. All rights reserved.
