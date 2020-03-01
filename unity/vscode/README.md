# VSCode Tips

VSCode(VisualStudioCode)の情報

## 目次

[コードに署名を追加](#コードに署名を追加)

## コードに署名を追加

### テンプレート作成

- 拡張機能```psioniq File Header```をインストール

- 設定から```settings.json```を開く
  - デフォルトは以下

<details><summary>setting.json</summary><div>

```json
{
    "workbench.colorTheme": "Default Light+",
    "editor.renderWhitespace": "all",
    "workbench.startupEditor": "newUntitledFile",
    "editor.scrollBeyondLastLine": false,
    "editor.wordWrap": "on",
    "editor.wrappingIndent": "indent",
    "update.showReleaseNotes": false,
    "telemetry.enableCrashReporter": false,
    "telemetry.enableTelemetry": false,
    "files.autoSave": "afterDelay",
    "editor.minimap.enabled": false,
}
```

</div></details>

- 「settings.json」と「デフォルト設定」を同時に表示する機能を追加

```setting.json```に以下を追加

```json
    "workbench.settings.useSplitJSON": true,
```

- 署名のテンプレートデータを```setting.json```に追加

設定例

```json
    "psi-header.templates": [
        {
            "language": "*",
            "template": [
                "<<filename>>",
                "Copyright (c) <<year>> <<company>>. All rights reserved."
            ]
        },
    ],
    "psi-header.variables": [
        ["company", "東亜プリン秘密研究所"],
    ],
```

### コードに署名

- コマンドパレットを開く
  - デフォルトは```F1キー```

- パレット窓に```header insert```と入力し実行
  - ファイルの先頭に著名コメントが追加される

### 結果例

```cs
/*
 * testtest.cs
 * Copyright (c) 2020 東亜プリン秘密研究所. All rights reserved.
 */

....
```

### 注意

- すでに署名がある場合は追記されるので、古い方はあらかじめ消しておく

### 参考

[psioniq File Header](https://marketplace.visualstudio.com/items?itemName=psioniq.psi-header)

---

Copyright (C) 2020 東亜プリン秘密研究所. All rights reserved.
