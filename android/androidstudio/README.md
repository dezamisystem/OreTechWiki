# AndroidStudio Tips

AndroidStudioの情報

## 目次

[コードに署名を追加](#コードに署名を追加)

## コードに署名を追加

### テンプレート作成

- ```Preference（設定）```開く

- 左枠から```Editor -> Copyright -> Formatting -> Java```選択

- ```Use custom formatting options```を選択

- 左枠から```Editor -> Copyright -> Copyright Profiles```選択

- 「＋」ボタンで新規テンプレート作成、名前を入力する

- 「Copyright text」にテンプレートを入力

記述例

```sh
Copyright (c) $today.year 東亜プリン秘密研究所. All rights reserved.
```

- 左枠から```Copyright```選択

- 「＋」ボタンで新規作成し、パラメータを以下にする

| Scope | Copyright |
| :--: | :--: |
| Project Source Files | (テンプレート名) |

- ```OKボタン```で設定を保存

### コードに署名

- Project枠が```Android```選択しているのを確認

- ```app```上で右クリックして、```Update Copyright```を選択

- 以下を確認
  - 反映先が```Whole project```
  - ```Update existing copyrights```にチェックが入っている

- ```OKボタン```で実行

### 結果例

```java
/*
 * Copyright (c) 2020 東亜プリン秘密研究所. All rights reserved.
 */

....
```

### 参考

[Automatically updating copyright messages in JetBrains IDEs](https://developerlife.com/2017/07/12/automatically-updating-copyright-messages-in-jetbrains-ides/)

---

Copyright (C) 2020 東亜プリン秘密研究所. All rights reserved.
