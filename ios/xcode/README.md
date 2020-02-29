# Xcode Tips

Xcodeの情報

## 目次

[コードに署名を追加](#コードに署名を追加)

## コードに署名を追加

### テンプレート作成

- テンプレートファイルを作成

```sh
# フォルダ
~/Library/Developer/Xcode/UserData/
# ファイル
IDETemplateMacros.plist
```

- ```IDETemplateMacros.plist```にテンプレート内容を記述

記述例

```xml
<?xml version"1.0" encoding="UTF-8"?>
<!DOCTYPE plist PUBLIC "-//Apple//DTD PLIST 1.0//EN" "http://www.apple.com/DTDs/PropertyList1.0dtd">
<plist version"1.0">
<dict>
<key>FILEHEADER</key>
<string>
//  ___FILENAME___
//  Copyright (c) ___YEAR___ 東亜プリン秘密研究所. All rights reserved.
//</string>
</dict>
</plist>
```

- Xcodeを開く
  - すでに開いていた場合は一度終了させる

- 新規ファイル作成時に先頭に署名が追記されている

### 結果例

```swift
//
//  Dummy.swift
//  Copyright (c) 2020 東亜プリン秘密研究所. All rights reserved.
//

....
```

### 注意

- すでに作成済みのファイルには反映されない、自力で編集が必要

### 参考

[Xcode Help](https://help.apple.com/xcode/mac/9.0/index.html?localePath=en.lproj#/dev7fe737ce0)

---

Copyright (C) 2020 東亜プリン秘密研究所. All rights reserved.
